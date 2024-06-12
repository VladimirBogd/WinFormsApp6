using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
	public class Basket : IImpactPoint
	{
		public int ParticlesCount = 0;
		public int sizeBasket = 100;
		public int capacity = 100;
		public override void ImpactParticle(Particle particle)
		{
			float gX = X - particle.X;
			float gY = Y - particle.Y;

			double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
			if (r <= particle.Radius + sizeBasket / 2) // если частица оказалось внутри окружности
			{
				// Если частица попала в точку, то увеличиваем счетчик и убиваем частицу
				ParticlesCount++;
				particle.Life = 0;
			}
		}
		public override void Render(Graphics g)
		{
			// Рисуем точку-счетчик
			g.FillEllipse(
				new SolidBrush(Color.White),
				X - sizeBasket/2, Y - sizeBasket/2, sizeBasket, sizeBasket
			);
			g.DrawEllipse(
				new Pen(Color.Red, 3),
				X - sizeBasket / 2, Y - sizeBasket / 2, sizeBasket, sizeBasket
			);

			// Отображаем количество собранных частиц
			var stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			var font = new Font("Verdana", 13);
			g.DrawString(
				ParticlesCount.ToString(),
				font,
				new SolidBrush(Color.Black),
				X, Y,
				stringFormat
			);
		}
	}
}
