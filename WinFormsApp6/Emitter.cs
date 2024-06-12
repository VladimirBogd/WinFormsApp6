using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
	public class Emitter
	{
		List<Particle> particles = new List<Particle>();
		public int MousePositionX;
		public int MousePositionY;

		public float GravitationX = 0;
		public float GravitationY = 1; // пусть гравитация будет силой один пиксель за такт, нам хватит

		public List<IImpactPoint> impactPoints = new List<IImpactPoint>(); // <<< ТАК ВОТ

		public int X; // координата X центра эмиттера
		public int Y; // соответствующая координата Y 
		public int Direction = 0; // вектор направления в градусах куда сыпет эмиттер
		public int Spreading = 0; // разброс частиц относительно Direction
		public int Speed = 10; // начальная максимальная скорость движения частицы
		public int RadiusMin = 2; // минимальный радиус частицы
		public int RadiusMax = 10; // максимальный радиус частицы
		public int LifeMin = 20; // минимальное время жизни частицы
		public int LifeMax = 100; // максимальное время жизни частицы
		public int ParticlesCount = 0; // количество частиц

		public Color ColorFrom = Color.White; // начальный цвет частицы
		public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц

		public int ParticlesPerTick = 1; // добавил новое поле

		// добавил новый метод, виртуальным, чтобы переопределять можно было
		public virtual void ResetParticle(Particle particle)
		{
			particle.Life = Particle.rand.Next(LifeMin, LifeMax);
			particle.X = X;
			particle.Y = Y;

			var direction = Direction
				+ (double)Particle.rand.Next(Spreading)
				- Spreading / 2;
			var speed = Speed;

			particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
			particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);
			particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
		}

		public virtual Particle CreateParticle()
		{
			var particle = new ParticleColorful();
			particle.FromColor = ColorFrom;
			particle.ToColor = ColorTo;

			return particle;
		}

		List<Particle> deadParticles = new List<Particle>();

		public void UpdateState()
		{
			int particlesToCreate = ParticlesPerTick; // фиксируем счетчик сколько частиц нам создавать за тик
			foreach (var particle in particles)
			{
				particle.Life -= 1;
				if (particle.Life <= 0) // если частица умерла
				{
					if (particlesToCreate > 0) // то проверяем надо ли создать частицу
					{
						/* у нас как сброс частицы равносилен созданию частицы */
						particlesToCreate -= 1; // поэтому уменьшаем счётчик созданных частиц на 1
						ResetParticle(particle);
					}
					else
					{
						deadParticles.Add(particle);
					}
				}
				else
				{
					particle.X += particle.SpeedX;
					particle.Y += particle.SpeedY;

					// гравитация воздействует на вектор скорости, поэтому пересчитываем его
					particle.SpeedX += GravitationX;
					particle.SpeedY += GravitationY;

					// Проверяем, попала ли частица в какую-либо точку-счетчик
					foreach (var counterPoint in impactPoints)
					{
						counterPoint.ImpactParticle(particle);
					}
				}
			}
			foreach (var deadParticle in deadParticles)
			{
				particles.Remove(deadParticle);
			}
			while (particlesToCreate >= 1)
			{
				particlesToCreate -= 1;
				var particle = CreateParticle();
				ResetParticle(particle);
				particles.Add(particle);
			}
			ParticlesCount = particles.Count;
		}

		public void Render(Graphics g)
		{
			foreach (var particle in particles)
			{
				particle.Draw(g);
			}
			// рисую точки притяжения красными кружочками
			foreach (var point in impactPoints)
			{
				point.Render(g); // это добавили
			}
			// Рисуем точки-счетчики
			foreach (var counterPoint in impactPoints)
			{
				counterPoint.Render(g);
			}
		}
	}
}
