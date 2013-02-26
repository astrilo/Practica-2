using System;

namespace ProyectoRelojCronometro
{
	public class Reloj
	{
		int hora;
		int minuto;
		int segundo;
	
		public void iniciar(){
			obtenHoraLocal ();
		}
		private void obtenHoraLocal(){
			hora = DateTime.Now.Hour;
			minuto = DateTime.Now.Minute;
			segundo = DateTime.Now.Second;

			for (hora = hora; hora < 24; hora++) {
				for (minuto= minuto; minuto < 60; minuto++) {
					for (segundo = segundo; segundo < 60; segundo++) {
						Console.WriteLine ((hora)+":"+(minuto)+":"+(segundo));
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
