using System;

namespace ProyectoRelojCronometro
{
	public class Reloj
	{
		int hora;
		int minuto;
		int segundo;
		public Reloj()
		{ 

		}
		public void iniciar(){
			obtenHoraLocal ();
		}
		private void obtenHoraLocal(){
			hora = DateTime.Now.Hour;
			minuto = DateTime.Now.Minute;
			segundo = DateTime.Now.Second;

			for (hora =0; hora <= 24; hora++) {
				for (minuto= 0; minuto <= 60; minuto++) {
					for (segundo =0; segundo <= 60; segundo++) {
						Console.WriteLine ((segundo)+":"+(minuto)+":"+(hora));
						System.Threading.Thread.Sleep (1000);
						Console.Clear();

					}
					segundo = 0;
				}
				minuto = 0;
			}
			hora = 0;
		}
	}
}
