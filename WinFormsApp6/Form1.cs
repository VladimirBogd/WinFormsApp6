namespace WinFormsApp6
{
	public partial class Form1 : Form
	{
		Emitter emitter; // тут убрали явное создание
		List<Emitter> emitters = new List<Emitter>();

		GravityPoint point1; // добавил поле под первую точку
		GravityPoint point2; // добавил поле под вторую точку

		public Form1()
		{
			InitializeComponent();
			picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
			this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
			{
				LifeMax = tbLife.Value,
				LifeMin = tbLife.Value/10,
                Direction = tbDirection.Value,
				Spreading = tbSpreading.Value,
				Speed = tbSpeed.Value,
				ParticlesPerTick = tbPartPerTick.Value,
				ColorFrom = Color.Gold,
				ColorTo = Color.FromArgb(0, Color.Red),
				X = picDisplay.Width / 2,
				Y = picDisplay.Height / 2,
			};
			emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся

			// привязываем гравитоны к полям
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

			// привязываем поля к эмиттеру
			emitter.impactPoints.Add(point1);
			emitter.impactPoints.Add(point2);

            lblLife.Text = $"{tbLife.Value}";
            lblPartPerTick.Text = $"{tbPartPerTick.Value}";
            lblSpeed.Text = $"{tbSpeed.Value}";
            lblDirection.Text = $"{tbDirection.Value}°";
            lblSpreading.Text = $"{tbSpreading.Value}°";
            lblGraviton1.Text = $"{tbGraviton1.Value}";
            lblGraviton2.Text = $"{tbGraviton2.Value}";
			lblPartCount.Text = $"Количество частиц: {emitter.ParticlesCount}";
        }

		// ну и обработка тика таймера, тут просто декомпозицию выполнили
		private void timer1_Tick(object sender, EventArgs e)
		{
			emitter.UpdateState(); // тут теперь обновляем эмиттер
            lblPartCount.Text = $"Количество частиц: {emitter.ParticlesCount}";

            using (var g = Graphics.FromImage(picDisplay.Image))
			{
				g.Clear(Color.Black); // А ЕЩЕ ЧЕРНЫЙ ФОН СДЕЛАЮ
				emitter.Render(g); // а тут теперь рендерим через эмиттер
			}

			picDisplay.Invalidate();
		}

		private void picDisplay_MouseMove(object sender, MouseEventArgs e)
		{
			// а тут в эмиттер передаем положение мыфки
			emitter.MousePositionX = e.X;
			emitter.MousePositionY = e.Y;
        }

		private void tbDirection_Scroll(object sender, EventArgs e)
		{
			emitter.Direction = tbDirection.Value; // направлению эмиттера присваиваем значение ползунка 
			lblDirection.Text = $"{tbDirection.Value}°"; // добавил вывод значения
		}
		private void tbSpreading_Scroll(object sender, EventArgs e)
		{
			emitter.Spreading = tbSpreading.Value; // направлению эмиттера присваиваем значение ползунка 
			lblSpreading.Text = $"{tbSpreading.Value}°"; // добавил вывод значения
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
			emitter.LifeMin = tbLife.Value/10;
            lblLife.Text = $"{tbLife.Value}";
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