namespace ProyectoDeConsola.Modelo
{
	public abstract class Vehiculo
	{				
		public int Posicion { get; set; }

		public abstract void Arrancar();

		protected int Avanzar(int distancia = 1)
		{
			Posicion = Posicion + distancia;
			return Posicion;
		}

		protected int Retroceder(int distancia = 1)
		{
			Posicion = Posicion - distancia;
			return Posicion;
		}
	}
}
