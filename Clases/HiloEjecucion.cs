using System;
using System.Threading;

namespace ControlDomino.Clases
{
	public class HiloEjecucion
	{
		public int avance;
		public Thread hilo;
		
		public HiloEjecucion(Thread nHilo)
		{
			avance = 0;
			hilo = nHilo;
		}
	}
}
