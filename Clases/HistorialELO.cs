
using System;

namespace ControlDomino.Clases
{
	[Serializable]
	public class HistorialELO
	{
		private DateTime fecha;
		private double elo;
		
		public HistorialELO()
		{
			this.fecha = DateTime.Now;
			this.elo = 0;
		}
		
		public HistorialELO(DateTime fecha, double elo)
		{
			this.fecha = fecha;
			this.elo = elo;
		}
		
		public DateTime Fecha
		{
			get { return fecha; }
		}
		
		public double Elo
		{
			get { return elo; }
		}
	}
}
