using System;

namespace ProyectoRelojCronometro
{
	class Menu
	{

		public void pantalla(){
			Console.WriteLine ("Bienvenido. Elije una opcion");
			Console.WriteLine ("1-. Reloj");
			Console.WriteLine ("2-. Cronometro");
		}
		public void leeropcion(){
			int opcion = int.Parse (Console.ReadLine ());
			Console.Clear ();
			if (opcion == 1) {
				Reloj reloj = new Reloj ();
				reloj.iniciar ();
			} else {
				if (opcion == 2) {
					Cronometro cronometro = new Cronometro ();
					cronometro.Proceso();
				}
			}
		}

		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			Menu Correr = new Menu();
			Correr.pantalla ();
			Correr.leeropcion ();
		
		}
	}
}
