
using System;

namespace ControlDomino.Clases
{
	[Serializable]
	public class Parametros
	{
		private double valorPartido, valorPollo, valorReculillo, eloInicial;
		private int inicioReculillo, puntosParaGanar;
		public bool cambios;
		
		public Parametros()
		{
			this.valorPartido = 1;
			this.valorPollo = 2;
			this.valorReculillo = 1.5;
			this.eloInicial = 1000;
			this.inicioReculillo = 18;
			this.puntosParaGanar = 20;
		}
		
		public Parametros(double valorPartido, double valorPollo, double valorReculillo, double eloInicial, int inicioReculillo, int puntosParaGanar)
		{
			this.valorPartido = valorPartido;
			this.valorPollo = valorPollo;
			this.valorReculillo = valorReculillo;
			this.eloInicial = eloInicial;
			this.inicioReculillo = inicioReculillo;
			this.puntosParaGanar = puntosParaGanar;
		}
		
		public double EloInicial {
			get { return eloInicial; }
			set { eloInicial = value; }
		}
		
		public double ValorReculillo {
			get { return valorReculillo; }
			set { valorReculillo = value; }
		}
		
		public double ValorPollo {
			get { return valorPollo; }
			set { valorPollo = value; }
		}
		
		public double ValorPartido {
			get { return valorPartido; }
			set { valorPartido = value; }
		}
		
		public int InicioReculillo {
			get { return inicioReculillo; }
			set { inicioReculillo = value; }
		}
		
		public int PuntosParaGanar {
			get { return puntosParaGanar; }
			set { puntosParaGanar = value; }
		}
	}
}
