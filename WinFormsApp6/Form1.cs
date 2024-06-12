namespace WinFormsApp6
{
	public partial class Form1 : Form
	{
		Emitter emitter; // ��� ������ ����� ��������
		List<Emitter> emitters = new List<Emitter>();
		List<Basket> baskets = new List<Basket>();
		Basket basket;

		public Form1()
		{
			InitializeComponent();
			picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
			this.emitter = new Emitter // ������ ������� � ���������� ��� � ���� emitter
			{
				LifeMax = tbLife.Value,
				LifeMin = tbLife.Value * 2/3,
				Direction = tbDirection.Value,
				Spreading = tbSpreading.Value,
				Speed = tbSpeed.Value,
				ParticlesPerTick = tbPartPerTick.Value,
				ColorFrom = Color.Gold,
				ColorTo = Color.FromArgb(0, Color.Red),
				X = picDisplay.Width / 2,
				Y = picDisplay.Height / 2,
			};
			emitters.Add(this.emitter); // ��� ����� �������� � ������ emitters, ����� �� ���������� � ����������

			lblLife.Text = $"{tbLife.Value}";
			lblPartPerTick.Text = $"{tbPartPerTick.Value}";
			lblSpeed.Text = $"{tbSpeed.Value}";
			lblDirection.Text = $"{tbDirection.Value}�";
			lblSpreading.Text = $"{tbSpreading.Value}�";
			lblPartCount.Text = $"���������� ������: {emitter.ParticlesCount}";
		}

		// �� � ��������� ���� �������, ��� ������ ������������ ���������
		private void timer1_Tick(object sender, EventArgs e)
		{
			emitter.UpdateState(); // ��� ������ ��������� �������
			lblPartCount.Text = $"���������� ������: {emitter.ParticlesCount}";

			using (var g = Graphics.FromImage(picDisplay.Image))
			{
				g.Clear(Color.Black); // � ��� ������ ��� ������
				emitter.Render(g); // � ��� ������ �������� ����� �������

                // ������� ������ ������ ��� ��������
                var basketsToRemove = new List<Basket>();

                foreach (var b in baskets)
                {
                    b.Render(g);
                    if (b.ParticlesCount >= b.capacity)
                    {
                        basketsToRemove.Add(b);
                    }
                }

                // ������� ������� �� ������
                foreach (var b in basketsToRemove)
                {
                    baskets.Remove(b);
                    emitters.First().impactPoints.Remove(b);
                }
            }
			picDisplay.Invalidate();
		}

		private void picDisplay_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
                int basketSize = 50;
                int basketCapacity = 100;
                if (rb100.Checked)
                {
                    basketSize = 50;
                    basketCapacity = 100;
                }
                else if (rb250.Checked)
                {
                    basketSize = 100;
                    basketCapacity = 250;
                }
                else if (rb500.Checked)
                {
                    basketSize = 150;
                    basketCapacity = 500;
                }
                else if (rb1000.Checked)
                {
                    basketSize = 200;
                    basketCapacity = 1000;
                }

                this.basket = new Basket
                {
                    X = e.X,
                    Y = e.Y,
                    sizeBasket = basketSize,
                    capacity = basketCapacity
                };
                baskets.Add(this.basket);
				emitters.First().impactPoints.Add(this.basket);
			}
			else if (e.Button == MouseButtons.Right)
			{
				var basketToRemove = baskets.FindLast(b => (b.X - e.X) * (b.X - e.X) + (b.Y - e.Y) * (b.Y - e.Y) <= b.sizeBasket / 2 * b.sizeBasket / 2);
				if (basketToRemove != null)
				{
					baskets.Remove(basketToRemove);
					emitters.First().impactPoints.Remove(basketToRemove);
				}
			}
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
		private void tbSpeed_Scroll(object sender, EventArgs e)
		{
			emitter.Speed = tbSpeed.Value;
			lblSpeed.Text = $"{tbSpeed.Value}";
		}
		private void tbPartPerTick_Scroll(object sender, EventArgs e)
		{
			emitter.ParticlesPerTick = tbPartPerTick.Value;
			lblPartPerTick.Text = $"{tbPartPerTick.Value}";
		}
		private void tbLife_Scroll(object sender, EventArgs e)
		{
			emitter.LifeMax = tbLife.Value;
			emitter.LifeMin = tbLife.Value * 2/3;
			lblLife.Text = $"{tbLife.Value}";
		}
	}
}