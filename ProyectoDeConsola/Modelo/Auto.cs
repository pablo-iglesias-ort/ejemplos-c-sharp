namespace ProyectoDeConsola.Modelo
{
	public class Auto : Vehiculo, IMovil
	{
		public bool LucesPrendidas { get; set; }
		public Velocidad Velocidad { get; set; }

		public Auto()
		{
			LucesPrendidas = false;
		}

		public override void Arrancar()
		{
			Velocidad = Velocidad.Primera;
			PrenderLuces();
		}

		private void PrenderLuces() 
		{
			LucesPrendidas = true;
		}

		int IMovil.Avanzar()
		{
			var distancia = ConvertirVelocidadEnDistancia(Velocidad);
			return base.Avanzar(distancia);
		}

		int IMovil.Retroceder()
		{
			Velocidad = Velocidad.Reversa;
			var distancia = ConvertirVelocidadEnDistancia(Velocidad);
			return base.Retroceder(distancia);
		}

		private int ConvertirVelocidadEnDistancia(Velocidad vel)
		{
			int distancia = 0;
			switch (vel) 
			{
				case Velocidad.Primera:
					distancia = 1;
					break;
				case Velocidad.Segunda:
					distancia = 3;
					break;
				case Velocidad.Tercera:
					distancia = 5;
					break;
				case Velocidad.Cuarta:
					distancia = 10;
					break;
				case Velocidad.Quinta:
					distancia = 20;
					break;
				default:
					distancia = 2;
					break;
			}

			return distancia;
		}
	}
}
