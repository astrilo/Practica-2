using System;

namespace ProyectoRelojCronometro
{
	public class Cronometro{
		int hora;
		int minuto;
		int segundo;

		public void Proceso(){
		for(hora = 0; hora < 1000; hora++){
			for(minuto = 0; minuto < 60; minuto++){
				for(segundo = 0; segundo < 60; segundo++){
						Console.WriteLine ((hora)+":"+(minuto)+":"+(segundo));
						System.Threading.Thread.Sleep (1000);
						Console.Clear();
					}
				}
			}
		}
	}
}
