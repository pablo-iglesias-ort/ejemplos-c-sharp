using ProyectoDeConsola.Modelo;
using System;

namespace Main
{
	public class PuntoDeEntrada
	{
		static void Main(string[] args)
		{

			string mensaje = "Hello World!";

			Console.WriteLine(mensaje);
		
			//var valorMaximo = Math.Max(1, 2);
			//Console.WriteLine(valorMaximo);

			Auto a = new Auto();			
			//Console.WriteLine(a.LucesPrendidas);
			//a.LucesPrendidas = true;
			//Console.WriteLine(a.LucesPrendidas);

			Console.WriteLine("Cantidad de Puertas: " + a.CantidadDePuertas);
			a.CantidadDePuertas = -10;
			Console.WriteLine("Cantidad de Puertas: " + a.CantidadDePuertas);


			
			var listaDeNombres = new string[] { "Pablo", "Jose", "Juan" };
			foreach (var nombre in listaDeNombres)
			{
				Console.WriteLine(nombre);
			}
			
			Console.Read();

		}
	}
}
