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
        public int ParticlesCount = 500;

        // добавил новый метод, виртуальным, чтобы переопределять можно было
        public virtual void ResetParticle(Particle particle)
		{
			particle.Life = 20 + Particle.rand.Next(100);
			particle.X = MousePositionX;
			particle.Y = MousePositionY;

			var direction = (double)Particle.rand.Next(360);
			var speed = 1 + Particle.rand.Next(10);

			particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
			particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

			particle.Radius = 2 + Particle.rand.Next(10);
		}

		public void UpdateState()
		{
			foreach (var particle in particles)
			{
				particle.Life -= 1;  // не трогаем
				if (particle.Life < 0)
				{
					ResetParticle(particle);
				}
				else
				{
					foreach (var point in impactPoints)
					{
						point.ImpactParticle(particle);
					}
					// гравитация воздействует на вектор скорости, поэтому пересчитываем его
					particle.SpeedX += GravitationX;
					particle.SpeedY += GravitationY;
					// и добавляем новый, собственно он даже проще становится, 
					// так как теперь мы храним вектор скорости в явном виде и его не надо пересчитывать
					particle.X += particle.SpeedX;
					particle.Y += particle.SpeedY;
				}
			}
			for (var i = 0; i < 10; ++i)
			{
				if (particles.Count < ParticlesCount) // пока частиц меньше 500 генерируем новые
				{
                    /* ну и тут чуток подкрутили */
                    var particle = new ParticleColorful();
                    particle.FromColor = Color.White;
                    particle.ToColor = Color.FromArgb(0, Color.Black);

                    ResetParticle(particle); // добавили вызов ResetParticle

                    particles.Add(particle);
                }
				else
				{
					break; // а если частиц уже 500 штук, то ничего не генерирую
				}
			}
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
		}
	}
}
