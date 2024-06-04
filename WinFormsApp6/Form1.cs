namespace WinFormsApp6
{
	public partial class Form1 : Form
	{
		Emitter emitter; // ��� ������ ����� ��������
		List<Emitter> emitters = new List<Emitter>();

		GravityPoint point1; // ������� ���� ��� ������ �����
		GravityPoint point2; // ������� ���� ��� ������ �����

		public Form1()
		{
			InitializeComponent();
			picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
			this.emitter = new Emitter // ������ ������� � ���������� ��� � ���� emitter
			{
				Direction = 0,
				Spreading = 10,
				SpeedMin = 10,
				SpeedMax = 10,
				ColorFrom = Color.Gold,
				ColorTo = Color.FromArgb(0, Color.Red),
				ParticlesPerTick = 10,
				X = picDisplay.Width / 2,
				Y = picDisplay.Height / 2,
			};
			emitters.Add(this.emitter); // ��� ����� �������� � ������ emitters, ����� �� ���������� � ����������

			// ����������� ��������� � �����
			point1 = new GravityPoint
			{
				X = picDisplay.Width / 2 - 100,
				Y = picDisplay.Height / 2,
				Power = 0
			};
			point2 = new GravityPoint
			{
				X = picDisplay.Width / 2 + 100,
				Y = picDisplay.Height / 2,
                Power = 0
            };

			// ����������� ���� � ��������
			emitter.impactPoints.Add(point1);
			emitter.impactPoints.Add(point2);
		}

		// �� � ��������� ���� �������, ��� ������ ������������ ���������
		private void timer1_Tick(object sender, EventArgs e)
		{
			emitter.UpdateState(); // ��� ������ ��������� �������

			using (var g = Graphics.FromImage(picDisplay.Image))
			{
				g.Clear(Color.Black); // � ��� ������ ��� ������
				emitter.Render(g); // � ��� ������ �������� ����� �������
			}

			picDisplay.Invalidate();
		}

		private void picDisplay_MouseMove(object sender, MouseEventArgs e)
		{
			// � ��� � ������� �������� ��������� �����
			emitter.MousePositionX = e.X;
			emitter.MousePositionY = e.Y;
        }

		private void tbDirection_Scroll(object sender, EventArgs e)
		{
			emitter.Direction = tbDirection.Value; // ����������� �������� ����������� �������� �������� 
			lblDirection.Text = $"{tbDirection.Value}�"; // ������� ����� ��������
		}

		private void tbSpreading_Scroll(object sender, EventArgs e)
		{
			emitter.Spreading = tbSpreading.Value; // ����������� �������� ����������� �������� �������� 
			lblSpreading.Text = $"{tbSpreading.Value}�"; // ������� ����� ��������
		}

		private void tbGraviton_Scroll(object sender, EventArgs e)
		{
            point1.Power = tbGraviton1.Value;
            lblGraviton1.Text = $"{tbGraviton1.Value}";
		}

		private void tbGraviton2_Scroll(object sender, EventArgs e)
		{
            point2.Power = tbGraviton2.Value;
            lblGraviton2.Text = $"{tbGraviton2.Value}";
        }
	}
}