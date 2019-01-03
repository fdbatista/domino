
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlDomino.Clases
{
	[Serializable]
	public class EstadGeneral
	{
		private string nombreJugador;
		private double valor;
		private List<RegistroPartido> contrarios;
		private List<RegistroPartido> parejas;
		
		public EstadGeneral(string pNombre, double pValor, List<RegistroPartido> pCont, List<RegistroPartido> pParejas)
		{
			nombreJugador = pNombre;
			valor = pValor;
			contrarios = pCont;
			parejas = pParejas;
		}
		
		public string NombreJugador {
			get { return nombreJugador; }
			set { nombreJugador = value; }
		}
		
		public double Valor {
			get { return valor; }
			set { valor = value; }
		}
		
		public List<RegistroPartido> Parejas {
			get { return parejas; }
			set { parejas = value; }
		}
		
		public List<RegistroPartido> Contrarios {
			get { return contrarios; }
			set { contrarios = value; }
		}
	}
	
	public class ResultComparacion
	{
		public Jugador[] jugadores;
		public int[] partidosJugados;
		public int[] partidosGanados;
		public int[] partidosPerdidos;
		public int[] pollosProp;
		public int[] pollosRecib;
		public int[] reculProp;
		public int[] reculRecib;
		public double[] posActual;
		
		public ResultComparacion()
		{
		}
		
		public ResultComparacion(Jugador nJug1, Jugador nJug2)
		{
			jugadores = new Jugador[]{nJug1, nJug2};
			partidosJugados = new int[2];
			partidosGanados = new int[2];
			partidosPerdidos = new int[2];
			pollosProp = new int[2];
			pollosRecib = new int[2];
			reculProp = new int[2];
			reculRecib = new int[2];
			posActual = new double[2];
		}		
		
		public double[] GetCoeficienteRend()
		{
			double[] res = new double[2];
			double tmp1 = partidosJugados[0], tmp2 = partidosJugados[1];
			if (tmp1 == 0) tmp1 = 1;
			if (tmp2 == 0) tmp2 = 1;
			res[0] = Math.Round(((pollosProp[0] * 2) + (reculProp[0] * 1.5) + (partidosGanados[0] - (pollosProp[0] + reculProp[0])))
			                    - ((pollosRecib[0] * 2) + (reculRecib[0] * 1.5) + (partidosPerdidos[0] - (pollosRecib[0] + reculRecib[0]))), 2);
			res[1] = Math.Round(((pollosProp[1] * 2) + (reculProp[1] * 1.5) + (partidosGanados[1] - (pollosProp[1] + reculProp[1])))
				- ((pollosRecib[1] * 2) + (reculRecib[1] * 1.5) + (partidosPerdidos[1] - (pollosRecib[1] + reculRecib[1]))), 2);
			return res;
		}
	}
	
	public class EstadPareja
	{
		private Pareja pareja;
		private List<Pareja> parejas;
		
		public EstadPareja()
		{
			pareja = new Pareja();
			parejas = new List<Pareja>();
		}
		
		public EstadPareja(Pareja nPar)
		{
			pareja = nPar;
			parejas = new List<Pareja>();
		}
		
		public Pareja Pareja
		{
			get { return pareja; }
			set { pareja = value; }
		}
		
		public List<Pareja> Parejas
		{
			get { return parejas; }
			set { parejas = value; }
		}
		
		public void AdicionarParejaAsoc(Pareja nPar)
		{
			parejas.Add(nPar);
		}
		
		public int CantParejasAsoc()
		{
			return parejas.Count;
		}
	}
	
	public class ListaEstadPareja
	{
		private List<EstadPareja> listaParejas;
		
		public ListaEstadPareja()
		{
			listaParejas = new List<EstadPareja>();
		}
		
		public List<EstadPareja> ListaParejas
		{
			get { return listaParejas; }
			set { listaParejas = value; }
		}
		
		public void AdicionarPareja(Pareja nPar)
		{
			listaParejas.Add(new EstadPareja(nPar));
		}
		
		public void AdicionarParejaAsoc(int posPareja, Pareja nPar)
		{
			listaParejas[posPareja].AdicionarParejaAsoc(new Pareja(nPar.nombreJugador1, nPar.nombreJugador2));
		}
		
		public int PosicionEnLista(string idPareja)
		{
			for (int i = 0; i < listaParejas.Count; i++)
				if (listaParejas[i].Pareja.IdPareja() == idPareja)
					return i;
			return -1;
		}
		
		public decimal PuntuacionEnLista(string idPareja)
		{
			for (int i = 0; i < listaParejas.Count; i++)
				if (listaParejas[i].Pareja.IdPareja() == idPareja)
					return listaParejas[i].Pareja.puntuacion;
			return 0;
		}
		
		public int PosicionEnListaDeParejas(int posPareja, string idParejaRelac)
		{
			List<Pareja> aux = listaParejas[posPareja].Parejas;
			for (int i = 0; i < aux.Count; i++)
				if (aux[i].IdPareja() == idParejaRelac)
					return i;
			return -1;
		}
		
		public int PosicionEnListaDeParejas(string idPareja, string idParejaRelac)
		{
			for (int i = 0; i < listaParejas.Count; i++)
			{
				if (listaParejas[i].Pareja.IdPareja() == idPareja)
				{
					List<Pareja> aux = listaParejas[i].Parejas;
					for (int j = 0; j < aux.Count; j++)
					{
						if (aux[i].IdPareja() == idParejaRelac)
							return i;
					}
				}
			}
			return -1;
		}
		
		public int CantidadParejas()
		{
			return listaParejas.Count;
		}
		
		public int CantidadParejasAsoc(int posPareja)
		{
			return listaParejas[posPareja].CantParejasAsoc();
		}
		
		public void ActualizarValorPareja(int posPareja)
		{
			listaParejas[posPareja].Pareja.puntuacion ++;
		}
		
		public void ActualizarValorParejaAsoc(int posPareja, int posParejaAsoc)
		{
			listaParejas[posPareja].Pareja.puntuacion++;
			listaParejas[posPareja].Parejas[posParejaAsoc].puntuacion++;
		}
	}
}
