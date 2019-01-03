using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace ControlDomino.Clases
{
	[Serializable]
	public class RegistroJugador
	{
		public string nombreJugador;
		private double elo;
		//private List<List<RegistroPartido>> listaRegistros;
		private List<RegistroPartido> jugadosConQuien, jugadosContraQuien, ganadosContraQuien, ganadosConQuien, perdidosContraQuien,
			perdidosConQuien, pollosPropContraQuien, pollosPropConQuien, pollosRecContraQuien,
			pollosRecConQuien, reculPropContraQuien, reculPropConQuien, reculRecibContraQuien,
			reculRecibConQuien;
		private List<Record> records;
		private List<HistorialELO> historialELO;
		public int cantJugados, cantGanados, cantPerdidos;
		
		public RegistroJugador(string pNombreJugador, double pElo)
		{
			nombreJugador = pNombreJugador;
			elo = pElo;
			cantJugados = 0;
			cantGanados = 0;
			cantPerdidos = 0;
			records = new List<Record>();
			records.Add(new Record("Mayor ELO", "", new Partido(), 1000.00));
			records.Add(new Record("Menor ELO", "", new Partido(), 1000.00));
			records.Add(new Record("Mayor diferencia", "", new Partido(), 0));
			records.Add(new Record("Menor diferencia", "", new Partido(), 0));
			/*records.Add(new Record("Victorias consecutivas", "", new Partido(), 0));
			records.Add(new Record("Derrotas consecutivas", "", new Partido(), 0));*/
			jugadosConQuien = new List<RegistroPartido>();
			jugadosContraQuien = new List<RegistroPartido>();
			ganadosContraQuien = new List<RegistroPartido>();
			ganadosConQuien = new List<RegistroPartido>();
			perdidosContraQuien = new List<RegistroPartido>();
			perdidosConQuien = new List<RegistroPartido>();
			pollosPropContraQuien = new List<RegistroPartido>();
			pollosPropConQuien = new List<RegistroPartido>();
			pollosRecContraQuien = new List<RegistroPartido>();
			pollosRecConQuien = new List<RegistroPartido>();
			reculPropContraQuien = new List<RegistroPartido>();
			reculPropConQuien = new List<RegistroPartido>();
			reculRecibContraQuien = new List<RegistroPartido>();
			reculRecibConQuien = new List<RegistroPartido>();
			historialELO = new List<HistorialELO>();
		}
		
		public List<HistorialELO> HistorialELO
		{
			get { return historialELO; }
		}
		
		public RegistroJugador
		(
			List<Record> pRecords, List<RegistroPartido> pJugadosConQuien, List<RegistroPartido> pJugadosContraQuien,
			List<RegistroPartido> pGanadosContraQuien, List<RegistroPartido> pGanadosConQuien,
			List<RegistroPartido> pPerdidosContraQuien, List<RegistroPartido> pPerdidosConQuien,
			List<RegistroPartido> pPollosPropContraQuien, List<RegistroPartido> pPollosPropConQuien,
			List<RegistroPartido> pPollosRecContraQuien, List<RegistroPartido> pPollosRecConQuien,
			List<RegistroPartido> pReculPropContraQuien, List<RegistroPartido> pReculPropConQuien,
			List<RegistroPartido> pReculRecibContraQuien, List<RegistroPartido> pReculRecibConQuien
		)
		{
			records = pRecords;
			jugadosConQuien = pJugadosConQuien;
			jugadosContraQuien = pJugadosContraQuien;
			ganadosContraQuien = pGanadosContraQuien;
			ganadosConQuien = pGanadosConQuien;
			perdidosContraQuien = pPerdidosContraQuien;
			perdidosConQuien = pPerdidosConQuien;
			pollosPropContraQuien = pPollosPropContraQuien;
			pollosPropConQuien = pPollosPropConQuien;
			pollosRecContraQuien = pPollosRecContraQuien;
			pollosRecConQuien = pPollosRecConQuien;
			reculPropContraQuien = pReculPropContraQuien;
			reculPropConQuien = pReculPropConQuien;
			reculRecibContraQuien = pReculRecibContraQuien;
			reculRecibConQuien = pReculRecibConQuien;
		}
		
		public void ActualizarELO(double variacion)
		{
			elo = Math.Round(elo + variacion, 2);
		}
		
		public double Elo {
			get { return elo; }
			set { elo = value; }
		}
		
		public List<Record> Records {
			get { return records; }
			set { records = value; }
		}
		
		public List<RegistroPartido> JugadosContraQuien {
			get { return jugadosContraQuien; }
		}
		
		public List<RegistroPartido> JugadosConQuien {
			get { return jugadosConQuien; }
		}
		
		public List<RegistroPartido> ReculRecibConQuien {
			get { return reculRecibConQuien; }
		}
		
		public List<RegistroPartido> ReculRecibContraQuien {
			get { return reculRecibContraQuien; }
		}
		
		public List<RegistroPartido> ReculPropConQuien {
			get { return reculPropConQuien; }
		}
		
		public List<RegistroPartido> ReculPropContraQuien {
			get { return reculPropContraQuien; }
		}
		
		public List<RegistroPartido> PollosRecConQuien {
			get { return pollosRecConQuien; }
		}
		
		public List<RegistroPartido> PollosRecContraQuien {
			get { return pollosRecContraQuien; }
		}
		
		public List<RegistroPartido> PollosPropConQuien {
			get { return pollosPropConQuien; }
		}
		
		public List<RegistroPartido> PollosPropContraQuien {
			get { return pollosPropContraQuien; }
		}
		
		public List<RegistroPartido> PerdidosConQuien {
			get { return perdidosConQuien; }
		}
		
		public List<RegistroPartido> PerdidosContraQuien {
			get { return perdidosContraQuien; }
		}
		
		public List<RegistroPartido> GanadosConQuien {
			get { return ganadosConQuien; }
		}
		
		public List<RegistroPartido> GanadosContraQuien {
			get { return ganadosContraQuien; }
		}
		
		public int IndiceJugadorEnRegistro(string nombreJugador, List<RegistroPartido> registro)
		{
			for (int i = 0; i < registro.Count; i++)
				if (registro[i].nombreJugador == nombreJugador)
					return i;
			return -1;
		}
		
		public void OrdenarRegistros(List<RegistroPartido> registro)
		{
			RegistroPartido tmp;
			for (int i = 0; i < registro.Count; i++)
			{
				for (int j = i + 1; j < registro.Count; j++)
				{
					if (registro[j].cantPartidos > registro[i].cantPartidos)
					{
						tmp = registro[i];
						registro[i] = registro[j];
						registro[j] = tmp;
					}
				}
			}
		}
		
		public int SumarPartidos(ref List<RegistroPartido> lista)
		{
			int res = 0;
			for (int i = 0; i < lista.Count; i++)
				res += lista[i].cantPartidos;
			return res;
		}
		
		public int DiferenciaGP()
		{
			return cantGanados - cantPerdidos;
		}
		
		public double Average()
		{
			return Math.Round((double)cantGanados * 1000 / cantJugados);
		}
		
		public int PollosPropinados()
		{
			return SumarPartidos(ref pollosPropConQuien);
		}
		
		public int PollosRecibidos()
		{
			return SumarPartidos(ref pollosRecConQuien);
		}
		
		public int ReculPropinados()
		{
			return SumarPartidos(ref reculPropConQuien);
		}
		
		public int ReculRecibidos()
		{
			return SumarPartidos(ref reculRecibConQuien);
		}
		
		public string RegistrarPartidoAFavor(Partido nuevo, string[] nombresJugadores)
		{
			OrdenarHistorialELO();
			string res = "";
			cantJugados ++;
			cantGanados ++;
			int indAux;
			//Jugados con el compannero
			indAux = IndiceJugadorEnRegistro(nombresJugadores[0], jugadosConQuien);
			if (indAux == -1)
			{
				jugadosConQuien.Add(new RegistroPartido(nombresJugadores[0], 0));
				indAux = jugadosConQuien.Count - 1;
			}
			jugadosConQuien[indAux].cantPartidos ++;
			OrdenarRegistros(jugadosConQuien);
			//Jugados con los 2
			for (int i = 1; i < nombresJugadores.Length; i++)
			{
				indAux = IndiceJugadorEnRegistro(nombresJugadores[i], jugadosContraQuien);
				if (indAux == -1)
				{
					jugadosContraQuien.Add(new RegistroPartido(nombresJugadores[i], 0));
					indAux = jugadosContraQuien.Count - 1;
				}
				jugadosContraQuien[indAux].cantPartidos ++;
			}
			OrdenarRegistros(jugadosContraQuien);
			//Ganados con compannero
			indAux = IndiceJugadorEnRegistro(nombresJugadores[0], ganadosConQuien);
			if (indAux == -1)
			{
				ganadosConQuien.Add(new RegistroPartido(nombresJugadores[0], 0));
				indAux = ganadosConQuien.Count - 1;
			}
			ganadosConQuien[indAux].cantPartidos ++;
			OrdenarRegistros(ganadosConQuien);
			//Ganados contra los 2
			for (int i = 1; i < nombresJugadores.Length; i++)
			{
				indAux = IndiceJugadorEnRegistro(nombresJugadores[i], ganadosContraQuien);
				if (indAux == -1)
				{
					ganadosContraQuien.Add(new RegistroPartido(nombresJugadores[i], 0));
					indAux = ganadosContraQuien.Count - 1;
				}
				ganadosContraQuien[indAux].cantPartidos ++;
			}
			OrdenarRegistros(ganadosContraQuien);
			if (nuevo.parejaGan.dioZapato)
			{
				//Zapateros con el compannero
				indAux = IndiceJugadorEnRegistro(nombresJugadores[0], pollosPropConQuien);
				if (indAux == -1)
				{
					pollosPropConQuien.Add(new RegistroPartido(nombresJugadores[0], 0));
					indAux = pollosPropConQuien.Count - 1;
				}
				pollosPropConQuien[indAux].cantPartidos ++;
				OrdenarRegistros(pollosPropConQuien);
				//Zapateros contra los contrarios
				for (int i = 1; i < nombresJugadores.Length; i++)
				{
					indAux = IndiceJugadorEnRegistro(nombresJugadores[i], pollosPropContraQuien);
					if (indAux == -1)
					{
						pollosPropContraQuien.Add(new RegistroPartido(nombresJugadores[i], 0));
						indAux = pollosPropContraQuien.Count - 1;
					}
					pollosPropContraQuien[indAux].cantPartidos ++;
				}
				OrdenarRegistros(pollosPropContraQuien);
			}
			else if (nuevo.parejaGan.dioReculillo)
			{
				//Reculillos con el compannero
				indAux = IndiceJugadorEnRegistro(nombresJugadores[0], reculPropConQuien);
				if (indAux == -1)
				{
					reculPropConQuien.Add(new RegistroPartido(nombresJugadores[0], 0));
					indAux = reculPropConQuien.Count - 1;
				}
				reculPropConQuien[indAux].cantPartidos ++;
				OrdenarRegistros(reculPropConQuien);
				//Reculillos contra los contrarios
				for (int i = 1; i < nombresJugadores.Length; i++)
				{
					indAux = IndiceJugadorEnRegistro(nombresJugadores[i], reculPropContraQuien);
					if (indAux == -1)
					{
						reculPropContraQuien.Add(new RegistroPartido(nombresJugadores[i], 0));
						indAux = reculPropContraQuien.Count - 1;
					}
					reculPropContraQuien[indAux].cantPartidos ++;
				}
				OrdenarRegistros(reculPropContraQuien);
			}
			if (elo > records[0].valor)
			{
				records[0] = new Record("Mayor ELO", nombreJugador, nuevo, elo);
				res += nombreJugador + " (mayor elo): " + elo + ".\n";
			}
			int dif = cantGanados - cantPerdidos;
			if (dif > records[2].valor)
			{
				records[2] = new Record("Mejor diferencia", nombreJugador, nuevo, dif);
				res += nombreJugador + " (mejor diferencia): " + dif + ".\n";
			}
			return res;
		}
		
		public string RegistrarPartidoEnContra(Partido nuevo, string[] nombresJugadores)
		{
			string res = "";
			cantJugados++;
			cantPerdidos++;
			int indAux;
			//Jugados con el compannero
			indAux = IndiceJugadorEnRegistro(nombresJugadores[0], jugadosConQuien);
			if (indAux == -1)
			{
				jugadosConQuien.Add(new RegistroPartido(nombresJugadores[0], 0));
				indAux = jugadosConQuien.Count - 1;
			}
			jugadosConQuien[indAux].cantPartidos ++;
			OrdenarRegistros(jugadosConQuien);
			//Jugados contra los 2
			for (int i = 1; i < nombresJugadores.Length; i++)
			{
				indAux = IndiceJugadorEnRegistro(nombresJugadores[i], jugadosContraQuien);
				if (indAux == -1)
				{
					jugadosContraQuien.Add(new RegistroPartido(nombresJugadores[i], 0));
					indAux = jugadosContraQuien.Count - 1;
				}
				jugadosContraQuien[indAux].cantPartidos ++;
			}
			OrdenarRegistros(jugadosContraQuien);
			//Perdidos con compannero
			indAux = IndiceJugadorEnRegistro(nombresJugadores[0], perdidosConQuien);
			if (indAux == -1)
			{
				perdidosConQuien.Add(new RegistroPartido(nombresJugadores[0], 0));
				indAux = perdidosConQuien.Count - 1;
			}
			perdidosConQuien[indAux].cantPartidos ++;
			OrdenarRegistros(perdidosConQuien);
			//Perdidos contra los 2
			for (int i = 1; i < nombresJugadores.Length; i++)
			{
				indAux = IndiceJugadorEnRegistro(nombresJugadores[i], perdidosContraQuien);
				if (indAux == -1)
				{
					perdidosContraQuien.Add(new RegistroPartido(nombresJugadores[i], 0));
					indAux = perdidosContraQuien.Count - 1;
				}
				perdidosContraQuien[indAux].cantPartidos ++;
			}
			OrdenarRegistros(perdidosContraQuien);
			if (nuevo.parejaGan.dioZapato)
			{
				//Zapateros con el compannero
				indAux = IndiceJugadorEnRegistro(nombresJugadores[0], pollosRecConQuien);
				if (indAux == -1)
				{
					pollosRecConQuien.Add(new RegistroPartido(nombresJugadores[0], 0));
					indAux = pollosRecConQuien.Count - 1;
				}
				pollosRecConQuien[indAux].cantPartidos ++;
				OrdenarRegistros(pollosRecConQuien);
				//Zapateros contra los contrarios
				for (int i = 1; i < nombresJugadores.Length; i++)
				{
					indAux = IndiceJugadorEnRegistro(nombresJugadores[i], pollosRecContraQuien);
					if (indAux == -1)
					{
						pollosRecContraQuien.Add(new RegistroPartido(nombresJugadores[i], 0));
						indAux = pollosRecContraQuien.Count - 1;
					}
					pollosRecContraQuien[indAux].cantPartidos ++;
				}
				OrdenarRegistros(pollosRecContraQuien);
			}
			else if (nuevo.parejaGan.dioReculillo)
			{
				//Reculillos con el compannero
				indAux = IndiceJugadorEnRegistro(nombresJugadores[0], reculRecibConQuien);
				if (indAux == -1)
				{
					reculRecibConQuien.Add(new RegistroPartido(nombresJugadores[0], 0));
					indAux = reculRecibConQuien.Count - 1;
				}
				reculRecibConQuien[indAux].cantPartidos ++;
				OrdenarRegistros(reculRecibConQuien);
				//Reculillos contra los contrarios
				for (int i = 1; i < nombresJugadores.Length; i++)
				{
					indAux = IndiceJugadorEnRegistro(nombresJugadores[i], reculRecibContraQuien);
					if (indAux == -1)
					{
						reculRecibContraQuien.Add(new RegistroPartido(nombresJugadores[i], 0));
						indAux = reculRecibContraQuien.Count - 1;
					}
					reculRecibContraQuien[indAux].cantPartidos ++;
				}
				OrdenarRegistros(reculRecibContraQuien);
			}
			if (elo < records[1].valor)
			{
				records[1] = new Record("Menor ELO", nombreJugador, nuevo, elo);
				res += nombreJugador + " (menor ELO): " + elo + ".\n";
			}
			int dif = cantGanados - cantPerdidos;
			if (dif < records[3].valor)
			{
				records[3] = new Record("Peor diferencia", nombreJugador, nuevo, dif);
				res += nombreJugador + " (peor diferencia): " + dif + ".\n";
			}
			return res;
		}
		
		public void EliminarPartidoPerdido(Partido nuevo, string[] nombresJugadores)
		{
			cantJugados --;
			cantPerdidos --;
			int indAux;
			
			//Jugados con el compannero
			indAux = IndiceJugadorEnRegistro(nombresJugadores[0], jugadosConQuien);
			if (indAux != -1)
			{
				jugadosConQuien[indAux].cantPartidos --;
				OrdenarRegistros(jugadosConQuien);
			}
			
			//Perdidos con el compannero
			indAux = IndiceJugadorEnRegistro(nombresJugadores[0], perdidosConQuien);
			if (indAux != -1)
			{
				perdidosConQuien[indAux].cantPartidos --;
				OrdenarRegistros(perdidosConQuien);
			}
			
			for (int i = 1; i < nombresJugadores.Length; i++)
			{
				//Jugados contra los 2
				indAux = IndiceJugadorEnRegistro(nombresJugadores[i], jugadosContraQuien);
				if (indAux != -1)
					jugadosContraQuien[indAux].cantPartidos --;
				//Perdidos contra los 2
				indAux = IndiceJugadorEnRegistro(nombresJugadores[i], perdidosContraQuien);
				if (indAux != -1)
					perdidosContraQuien[indAux].cantPartidos --;
				if (nuevo.parejaGan.dioZapato)
				{
					//Zapateros contra los contrarios
					indAux = IndiceJugadorEnRegistro(nombresJugadores[i], pollosRecContraQuien);
					if (indAux != -1)
						pollosRecContraQuien[indAux].cantPartidos ++;
				}
				else if (nuevo.parejaGan.dioReculillo)
				{
					indAux = IndiceJugadorEnRegistro(nombresJugadores[i], reculRecibContraQuien);
					if (indAux != -1)
						reculRecibContraQuien[indAux].cantPartidos --;
				}
			}
			OrdenarRegistros(jugadosContraQuien);
			OrdenarRegistros(perdidosContraQuien);
			if (nuevo.parejaGan.dioZapato)
			{
				//Zapateros con el compannero
				indAux = IndiceJugadorEnRegistro(nombresJugadores[0], pollosRecConQuien);
				if (indAux != -1)
				{
					pollosRecConQuien[indAux].cantPartidos --;
					OrdenarRegistros(pollosRecConQuien);
				}
				OrdenarRegistros(pollosRecContraQuien);
			}
			else if (nuevo.parejaGan.dioReculillo)
			{
				//Reculillos con el compannero
				indAux = IndiceJugadorEnRegistro(nombresJugadores[0], reculRecibConQuien);
				if (indAux != -1)
				{
					reculRecibConQuien[indAux].cantPartidos --;
					OrdenarRegistros(reculRecibConQuien);
				}
				OrdenarRegistros(reculRecibContraQuien);
			}
		}
		
		public void EliminarPartidoGanado(Partido nuevo, string[] nombresJugadores)
		{
			cantJugados --;
			cantGanados --;
			int indAux;
			//Jugados con el compannero
			indAux = IndiceJugadorEnRegistro(nombresJugadores[0], jugadosConQuien);
			if (indAux != -1)
			{
				jugadosConQuien[indAux].cantPartidos --;
				OrdenarRegistros(jugadosConQuien);
			}
			//Ganados con el compannero
			indAux = IndiceJugadorEnRegistro(nombresJugadores[0], ganadosConQuien);
			if (indAux != -1)
			{
				ganadosConQuien[indAux].cantPartidos --;
				OrdenarRegistros(ganadosConQuien);
			}
			
			for (int i = 1; i < nombresJugadores.Length; i++)
			{
				//Jugados contra los 2
				indAux = IndiceJugadorEnRegistro(nombresJugadores[i], jugadosContraQuien);
				if (indAux != -1)
					jugadosContraQuien[indAux].cantPartidos --;
				//Ganados contra los 2
				indAux = IndiceJugadorEnRegistro(nombresJugadores[i], ganadosContraQuien);
				if (indAux != -1)
					ganadosContraQuien[indAux].cantPartidos --;
				if (nuevo.parejaGan.dioZapato)
				{
					//Zapateros contra los contrarios
					indAux = IndiceJugadorEnRegistro(nombresJugadores[i], pollosPropContraQuien);
					if (indAux != -1)
						pollosPropContraQuien[indAux].cantPartidos ++;
				}
				else if (nuevo.parejaGan.dioReculillo)
				{
					indAux = IndiceJugadorEnRegistro(nombresJugadores[i], reculPropContraQuien);
					if (indAux != -1)
						reculPropContraQuien[indAux].cantPartidos --;
				}
			}
			OrdenarRegistros(jugadosContraQuien);
			OrdenarRegistros(ganadosContraQuien);
			if (nuevo.parejaGan.dioZapato)
			{
				//Zapateros con el compannero
				indAux = IndiceJugadorEnRegistro(nombresJugadores[0], pollosPropConQuien);
				if (indAux != -1)
				{
					pollosPropConQuien[indAux].cantPartidos --;
					OrdenarRegistros(pollosPropConQuien);
				}
				OrdenarRegistros(pollosPropContraQuien);
			}
			else if (nuevo.parejaGan.dioReculillo)
			{
				//Reculillos con el compannero
				indAux = IndiceJugadorEnRegistro(nombresJugadores[0], reculPropConQuien);
				if (indAux != -1)
				{
					reculPropConQuien[indAux].cantPartidos --;
					OrdenarRegistros(reculPropConQuien);
				}
				OrdenarRegistros(reculPropContraQuien);
			}
		}
		
		public void OrdenarHistorialELO()
		{
			HistorialELO histAux;
			for (int i = 0; i < historialELO.Count; i++)
			{
				for (int j = i + 1; j < historialELO.Count; j++)
				{
					if (historialELO[j].Fecha < historialELO[i].Fecha)
					{
						histAux = historialELO[i];
						historialELO[i] = historialELO[j];
						historialELO[j] = histAux;
					}
				}
			}
		}
		
		public void SetRecord(int posRecord, Record nRecord)
		{
			records[posRecord] = nRecord;
		}
		
		public void CambiarNombreContrario(string nombreViejo, string nombreNuevo)
		{
			CambiarNombreRegistro(ref jugadosConQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref jugadosContraQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref ganadosContraQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref ganadosConQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref perdidosContraQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref perdidosConQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref pollosPropContraQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref pollosPropConQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref pollosRecContraQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref pollosRecConQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref reculPropContraQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref reculPropConQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref reculRecibContraQuien, nombreViejo, nombreNuevo);
			CambiarNombreRegistro(ref reculRecibConQuien, nombreViejo, nombreNuevo);
		}
		
		void CambiarNombreRegistro(ref List<RegistroPartido> listaRegistro, string nombreViejo, string nombreNuevo)
		{
			for (int i = 0; i < listaRegistro.Count; i++)
				if (listaRegistro[i].nombreJugador == nombreViejo)
					listaRegistro[i].nombreJugador = nombreNuevo;
		}
	}
}
