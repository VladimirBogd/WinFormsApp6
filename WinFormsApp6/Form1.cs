namespace WinFormsApp6
{
	public partial class Form1 : Form
	{
		Emitter emitter = new Emitter(); // �������� �������

		public Form1()
		{
			InitializeComponent();
			picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            // ������� �������
            emitter.gravityPoints.Add(new Point(
                picDisplay.Width / 2, picDisplay.Height / 2
            ));
            // ������� ��� ���        
            emitter.gravityPoints.Add(new Point(
              (int)(picDisplay.Width * 0.75), picDisplay.Height / 2
           ));

            emitter.gravityPoints.Add(new Point(
               (int)(picDisplay.Width * 0.25), picDisplay.Height / 2
           ));
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

		// ��������� ���������� ��� �������� ��������� ����
		private int MousePositionX = 0;
		private int MousePositionY = 0;

		private void picDisplay_MouseMove(object sender, MouseEventArgs e)
		{
            // � ��� � ������� �������� ��������� �����
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }
	}
}