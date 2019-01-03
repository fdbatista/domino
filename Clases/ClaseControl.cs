using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;


namespace ControlDomino.Clases
{
	[Serializable]
	public class ClaseControl
	{
		private Parametros parametros;
		public int cantPartAMostrar, correoPuerto;
		public string contrasenna, correoRemitente, correoAsunto, correoServidor, correoCuenta, correoContrasenna, nombreLista;
		public bool correoHTML, correoSSL, correoCredencPredet, correoHabilitado;
		public List<Partido> partidos;
		public List<Jugador> jugadores;
		public List<Record> records;
		public List<EstadGeneral> estadGeneral;
		public MailPriority correoPrioridad;
		
		public ClaseControl(string nombre)
		{
			cantPartAMostrar = 0;
			contrasenna = MiembrosEstaticos.Encriptar("");
			partidos = new List<Partido>();
			jugadores = new List<Jugador>();
			parametros = new Parametros();
			ResetearRecords();
			estadGeneral = new List<EstadGeneral>();
			correoAsunto = "Récords afectados el ";
			correoCredencPredet = false;
			correoHTML = true;
			correoPrioridad = MailPriority.Normal;
			correoPuerto = 25;
			correoServidor = "correo.das.ltu";
			correoRemitente = "domino@" + correoServidor;
			correoSSL = false;
			correoHabilitado = false;
			correoCuenta = "";
			correoContrasenna = "";
			nombreLista = nombre;
		}
		
		void ResetearRecords()
		{
			records = new List<Record>();
			records.Add(new Record("Mayor ELO", "<No establecido>", new Partido(), parametros.EloInicial));
			records.Add(new Record("Menor ELO", "<No establecido>", new Partido(), parametros.EloInicial));
			records.Add(new Record("Mayor diferencia", "<No establecido>", new Partido(), -1));
			records.Add(new Record("Menor diferencia", "<No establecido>", new Partido(), 1));
			/*records.Add(new Record("Victorias consecutivas", "<No establecido>", new Partido(), -1));
			records.Add(new Record("Derrotas consecutivas", "<No establecido>", new Partido(), 1));*/
		}
		
		public Parametros Parametros()
		{
			return parametros;
		}
		
		public List<Partido> Partidos
		{
			get { return partidos; }
		}
		
		public void ActualizarParametros(double valorPartido, double valorPollo, double valorReculillo, double eloInicial, int inicioReculillo, int puntosParaGanar)
		{
			parametros.cambios = (parametros.ValorPartido != valorPartido || parametros.ValorPollo != valorPollo || parametros.ValorReculillo != valorReculillo || parametros.EloInicial  != eloInicial);
			parametros.ValorPartido = valorPartido;
			parametros.ValorPollo = valorPollo;
			parametros.ValorReculillo = valorReculillo;
			parametros.EloInicial = eloInicial;
			parametros.InicioReculillo = inicioReculillo;
			parametros.PuntosParaGanar = puntosParaGanar;
		}
		
		public void CambiarNombre(int indiceJug, string nuevoNombre)
		{
			if (nuevoNombre == "")
				throw new Exception("Tienes que ponerle un nombre, so mamarracho...");
			Jugador jugOrig = jugadores[indiceJug];
			string idJugNuevo = MiembrosEstaticos.NormalizarCadena(nuevoNombre, true, false), idJugOrig = jugOrig.nombre;
			if (idJugNuevo == idJugOrig)
				throw new Exception("Tienes que cambiarle el nombre, mentepollo...");
			for (int i = 0; i < jugadores.Count; i++)
				if (jugadores[i].nombre == idJugNuevo)
					throw new Exception("Ya existe un jugador con ese nombre, cerebro de pollo.");
			
			for (int i = 0; i < partidos.Count; i++)
			{
				if (partidos[i].JugadorEnPartido(idJugOrig))
				{
					if (partidos[i].parejaGan.nombreJugador1 == idJugOrig)
					{
						partidos[i].parejaGan.nombreJugador1 = idJugNuevo;
						partidos[i].parejaGan.OrdenarJugadores();
					}
					else if (partidos[i].parejaGan.nombreJugador2 == idJugOrig)
					{
						partidos[i].parejaGan.nombreJugador2 = idJugNuevo;
						partidos[i].parejaGan.OrdenarJugadores();
					}
					else if (partidos[i].parejaPerd.nombreJugador1 == idJugOrig)
					{
						partidos[i].parejaPerd.nombreJugador1 = idJugNuevo;
						partidos[i].parejaPerd.OrdenarJugadores();
					}
					else if (partidos[i].parejaPerd.nombreJugador2 == idJugOrig)
					{
						partidos[i].parejaPerd.nombreJugador2 = idJugNuevo;
						partidos[i].parejaPerd.OrdenarJugadores();
					}
				}
			}
			jugadores[indiceJug].nombre = idJugNuevo;
			jugadores[indiceJug].RegistroPersonal.nombreJugador = idJugNuevo;
			for (int i = 0; i < jugadores.Count; i++)
				if (i != indiceJug)
					jugadores[i].RegistroPersonal.CambiarNombreContrario(idJugOrig, idJugNuevo);
		}
		
		public void RecalcularEstadisticas(ref int avance)
		{
			avance = 0;
			for (int i = 0; i < jugadores.Count; i++)
				jugadores[i].RegistroPersonal = new RegistroJugador(jugadores[i].nombre, parametros.EloInicial);
			Partido[] arrPart = partidos.ToArray();
			partidos.Clear();
			ResetearRecords();
			int cant = arrPart.Length;
			bool tmp = correoHabilitado;
			correoHabilitado = false;
			for (int i = 0; i < cant; i++)
			{
				avance = (i + 1) * 100 / cant;
				RegistrarPartido(arrPart[i]);
			}
			correoHabilitado = tmp;
		}
		
		public void AdicionarJugador(Jugador nuevo)
		{
			Jugador jugAux = new Jugador(MiembrosEstaticos.NormalizarCadena(nuevo.nombre, true, false), nuevo.sexo, nuevo.Avatar, parametros.EloInicial, nuevo.correo);
			for (int i = 0; i < jugadores.Count; i++)
				if (jugadores[i].Iguales(jugAux))
					throw new Exception("Ya existe un jugador con ese nombre.");
			jugadores.Add(jugAux);
			OrdenarJugadores();
		}
		
		public int CantidadPartidosJugador(string idJugador)
		{
			int res = 0;
			for (int i = 0; i < partidos.Count; i++)
				if (partidos[i].JugadorEnPartido(idJugador))
					res++;
			return res;
		}
		
		string ActualizarRachas(Partido nuevo, int[] posJugadores)
		{
			string res = "";
			
			return res;
		}
		
		string RegistrarDatos(Partido nuevo, int modo)
		{
			string recordsIndiv = "", recordsColect = "";
			double variacion;
			if (nuevo.parejaGan.dioReculillo)
				variacion = parametros.ValorReculillo;
			else if (nuevo.parejaGan.dioZapato)
				variacion = parametros.ValorPollo;
			else
				variacion = parametros.ValorPartido + Math.Round((((double)nuevo.parejaGan.puntuacion - (double)nuevo.parejaPerd.puntuacion) / 100), 2);
			int[] posJugadores = new int[]
			{
				IndiceEnLista(nuevo.parejaGan.nombreJugador1), IndiceEnLista(nuevo.parejaGan.nombreJugador2),
				IndiceEnLista(nuevo.parejaPerd.nombreJugador1), IndiceEnLista(nuevo.parejaPerd.nombreJugador2)
			};
			
			if (modo == 1)
			{
				jugadores[posJugadores[0]].RegistroPersonal.ActualizarELO(variacion);
				jugadores[posJugadores[1]].RegistroPersonal.ActualizarELO(variacion);
				jugadores[posJugadores[2]].RegistroPersonal.ActualizarELO(-variacion);
				jugadores[posJugadores[3]].RegistroPersonal.ActualizarELO(-variacion);
				
				//Actualizar registros
				recordsIndiv += jugadores[posJugadores[0]].RegistroPersonal.RegistrarPartidoAFavor(nuevo, new string[]{nuevo.parejaGan.nombreJugador2, nuevo.parejaPerd.nombreJugador1, nuevo.parejaPerd.nombreJugador2});
				recordsIndiv += jugadores[posJugadores[1]].RegistroPersonal.RegistrarPartidoAFavor(nuevo, new string[]{nuevo.parejaGan.nombreJugador1, nuevo.parejaPerd.nombreJugador1, nuevo.parejaPerd.nombreJugador2});
				recordsIndiv += jugadores[posJugadores[2]].RegistroPersonal.RegistrarPartidoEnContra(nuevo, new string[]{nuevo.parejaPerd.nombreJugador2, nuevo.parejaGan.nombreJugador1, nuevo.parejaGan.nombreJugador2});
				recordsIndiv += jugadores[posJugadores[3]].RegistroPersonal.RegistrarPartidoEnContra(nuevo, new string[]{nuevo.parejaPerd.nombreJugador1, nuevo.parejaGan.nombreJugador1, nuevo.parejaGan.nombreJugador2});
				
				//Actualizar records de rachas
				/*double[] arrRachas = new double[]
				{
					GetMejorRachaJugador(posJugadores[0]), GetMejorRachaJugador(posJugadores[1]),
					GetPeorRachaJugador(posJugadores[2]), GetPeorRachaJugador(posJugadores[3])
				};
				
				if (arrRachas[0] > jugadores[posJugadores[0]].RegistroPersonal.Records[4].valor)
				{
					jugadores[posJugadores[0]].RegistroPersonal.SetRecord(4, new Record("Victorias consecutivas", jugadores[posJugadores[0]].nombre, nuevo, arrRachas[0]));
					recordsIndiv += "Victorias consecutivas: " + jugadores[posJugadores[0]].nombre + " (" + jugadores[posJugadores[0]].RegistroPersonal.Records[4].valor.ToString() + ").\n";
				}
				if (arrRachas[1] > jugadores[posJugadores[1]].RegistroPersonal.Records[4].valor)
				{
					jugadores[posJugadores[1]].RegistroPersonal.SetRecord(4, new Record("Victorias consecutivas", jugadores[posJugadores[1]].nombre, nuevo, arrRachas[1]));
					recordsIndiv += "Victorias consecutivas: " + jugadores[posJugadores[0]].nombre + " (" + jugadores[posJugadores[1]].RegistroPersonal.Records[4].valor.ToString() + ").\n";
				}
				if (arrRachas[2] < jugadores[posJugadores[2]].RegistroPersonal.Records[5].valor)
				{
					jugadores[posJugadores[2]].RegistroPersonal.SetRecord(5, new Record("Derrotas consecutivas", jugadores[posJugadores[2]].nombre, nuevo, arrRachas[2]));
					recordsIndiv += "Derrotas consecutivas: " + jugadores[posJugadores[2]].nombre + " (" + jugadores[posJugadores[2]].RegistroPersonal.Records[5].valor.ToString() + ").\n";
				}
				if (arrRachas[3] < jugadores[posJugadores[3]].RegistroPersonal.Records[5].valor)
				{
					jugadores[posJugadores[3]].RegistroPersonal.SetRecord(5, new Record("Derrotas consecutivas", jugadores[posJugadores[3]].nombre, nuevo, arrRachas[3]));
					recordsIndiv += "Derrotas consecutivas: " + jugadores[posJugadores[3]].nombre + " (" + jugadores[posJugadores[3]].RegistroPersonal.Records[5].valor.ToString() + ").\n";
				}
				*/
				//Actualizar historial rendimiento
				jugadores[posJugadores[0]].RegistroPersonal.HistorialELO.Add(new HistorialELO(nuevo.fecha, jugadores[posJugadores[0]].RegistroPersonal.Elo));
				jugadores[posJugadores[1]].RegistroPersonal.HistorialELO.Add(new HistorialELO(nuevo.fecha, jugadores[posJugadores[1]].RegistroPersonal.Elo));
				jugadores[posJugadores[2]].RegistroPersonal.HistorialELO.Add(new HistorialELO(nuevo.fecha, jugadores[posJugadores[2]].RegistroPersonal.Elo));
				jugadores[posJugadores[3]].RegistroPersonal.HistorialELO.Add(new HistorialELO(nuevo.fecha, jugadores[posJugadores[3]].RegistroPersonal.Elo));
				
				//Actualizar records elo
				if (jugadores[posJugadores[0]].RegistroPersonal.Elo > records[0].valor)
				{
					records[0] = new Record("Mayor ELO", jugadores[posJugadores[0]].nombre, nuevo, jugadores[posJugadores[0]].RegistroPersonal.Elo);
					recordsColect += "Mayor ELO: " + jugadores[posJugadores[0]].nombre + " (" + records[0].valor.ToString() + ").\n";
				}
				if (jugadores[posJugadores[1]].RegistroPersonal.Elo > records[0].valor)
				{
					records[0] = new Record("Mayor ELO", jugadores[posJugadores[1]].nombre, nuevo, jugadores[posJugadores[1]].RegistroPersonal.Elo);
					recordsColect += "Mayor ELO: " + jugadores[posJugadores[1]].nombre + " (" + records[0].valor.ToString() + ").\n";
				}
				if (jugadores[posJugadores[2]].RegistroPersonal.Elo < records[1].valor)
				{
					records[1] = new Record("Menor ELO", jugadores[posJugadores[2]].nombre, nuevo, jugadores[posJugadores[2]].RegistroPersonal.Elo);
					recordsColect += "Menor ELO: " + jugadores[posJugadores[2]].nombre + " (" + records[1].valor.ToString() + ").\n";
				}
				if (jugadores[posJugadores[3]].RegistroPersonal.Elo < records[1].valor)
				{
					records[1] = new Record("Menor ELO", jugadores[posJugadores[3]].nombre, nuevo, jugadores[posJugadores[3]].RegistroPersonal.Elo);
					recordsColect += "Menor ELO: " + jugadores[posJugadores[3]].nombre + " (" + records[1].valor.ToString() + ").\n";
				}
				
				//Actualizar records diferencia
				if (jugadores[posJugadores[0]].RegistroPersonal.DiferenciaGP() > records[2].valor)
				{
					records[2] = new Record("Mejor diferencia", jugadores[posJugadores[0]].nombre, nuevo, jugadores[posJugadores[0]].RegistroPersonal.DiferenciaGP());
					recordsColect += "Mejor diferencia: " + jugadores[posJugadores[0]].nombre + " (" + records[2].valor.ToString() + ").\n";
				}
				if (jugadores[posJugadores[1]].RegistroPersonal.DiferenciaGP() > records[2].valor)
				{
					records[2] = new Record("Mejor diferencia", jugadores[posJugadores[1]].nombre, nuevo, jugadores[posJugadores[1]].RegistroPersonal.DiferenciaGP());
					recordsColect += "Mejor diferencia: " + jugadores[posJugadores[1]].nombre + " (" + records[2].valor.ToString() + ".)\n";
				}
				if (jugadores[posJugadores[2]].RegistroPersonal.DiferenciaGP() < records[3].valor)
				{
					records[3] = new Record("Peor diferencia", jugadores[posJugadores[2]].nombre, nuevo, jugadores[posJugadores[2]].RegistroPersonal.DiferenciaGP());
					recordsColect += "Peor diferencia: " + jugadores[posJugadores[2]].nombre + " (" + records[3].valor.ToString() + ").\n";
				}
				if (jugadores[posJugadores[3]].RegistroPersonal.DiferenciaGP() < records[3].valor)
				{
					records[3] = new Record("Peor diferencia", jugadores[posJugadores[3]].nombre, nuevo, jugadores[posJugadores[3]].RegistroPersonal.DiferenciaGP());
					recordsColect += "Peor diferencia: " + jugadores[posJugadores[3]].nombre + " (: " + records[3].valor.ToString() + ").\n";
				}
				
				//Actualizar records rachas
				/*if (arrRachas[0] > records[4].valor)
				{
					records[4] = new Record("Victorias consecutivas", jugadores[posJugadores[0]].nombre, nuevo, arrRachas[0]);
					recordsColect += "Victorias consecutivas: " + jugadores[posJugadores[0]].nombre + " (" + records[4].valor.ToString() + ").\n";
				}
				if (arrRachas[1] > records[4].valor)
				{
					records[4] = new Record("Victorias consecutivas", jugadores[posJugadores[1]].nombre, nuevo, arrRachas[1]);
					recordsColect += "Victorias consecutivas: " + jugadores[posJugadores[1]].nombre + " (" + records[4].valor.ToString() + ").\n";
				}
				if (arrRachas[2] < records[5].valor)
				{
					records[5] = new Record("Derrotas consecutivas", jugadores[posJugadores[2]].nombre, nuevo, arrRachas[2]);
					recordsColect += "Derrotas consecutivas: " + jugadores[posJugadores[2]].nombre + " (" + records[5].valor.ToString() + ").\n";
				}
				if (arrRachas[3] < records[5].valor)
				{
					records[5] = new Record("Derrotas consecutivas", jugadores[posJugadores[3]].nombre, nuevo, arrRachas[3]);
					recordsColect += "Derrotas consecutivas: " + jugadores[posJugadores[3]].nombre + " (" + records[5].valor.ToString() + ").\n";
				}
				*/
				string res = (recordsColect != "") ? "\n\nRÉCORDS GENERALES AFECTADOS:\n\n" + recordsColect : "";
				res += (recordsIndiv != "") ? "\n\nRÉCORDS PERSONALES AFECTADOS:\n\n" + recordsIndiv : "";
				return "Partido registrado." + res;
			}
			else
			{
				jugadores[posJugadores[0]].RegistroPersonal.Elo -= variacion;
				jugadores[posJugadores[1]].RegistroPersonal.Elo -= variacion;
				jugadores[posJugadores[2]].RegistroPersonal.Elo += variacion;
				jugadores[posJugadores[3]].RegistroPersonal.Elo += variacion;
				
				//ActualizarRegistros
				jugadores[posJugadores[0]].RegistroPersonal.EliminarPartidoGanado(nuevo, new string[]{nuevo.parejaGan.nombreJugador2, nuevo.parejaPerd.nombreJugador1, nuevo.parejaPerd.nombreJugador2});
				jugadores[posJugadores[1]].RegistroPersonal.EliminarPartidoGanado(nuevo, new string[]{nuevo.parejaGan.nombreJugador1, nuevo.parejaPerd.nombreJugador1, nuevo.parejaPerd.nombreJugador2});
				jugadores[posJugadores[2]].RegistroPersonal.EliminarPartidoPerdido(nuevo, new string[]{nuevo.parejaPerd.nombreJugador2, nuevo.parejaGan.nombreJugador1, nuevo.parejaGan.nombreJugador2});
				jugadores[posJugadores[3]].RegistroPersonal.EliminarPartidoPerdido(nuevo, new string[]{nuevo.parejaPerd.nombreJugador1, nuevo.parejaGan.nombreJugador1, nuevo.parejaGan.nombreJugador2});
				
				return null;
			}
		}
		
		public string RegistrarPartido(Partido nuevo)
		{
			nuevo.OrdenarJugadores();
			partidos.Add(nuevo);
			OrdenarPartidos();
			return RegistrarDatos(nuevo, 1);
		}
		
		public void OrdenarPartidos()
		{
			Partido partAux;
			for (int i = 0; i < partidos.Count; i++)
			{
				for (int j = i + 1; j < partidos.Count; j++)
				{
					if (partidos[j].fecha < partidos[i].fecha)
					{
						partAux = partidos[i];
						partidos[i] = partidos[j];
						partidos[j] = partAux;
					}
				}
			}
		}
		
		public void EliminarPartido(int indice)
		{
			int posReal = partidos.Count - indice - 1;
			RegistrarDatos(partidos[posReal], -1);
			partidos.RemoveAt(posReal);
		}
		
		public void OrdenarJugadores()
		{
			Jugador jugAux;
			for (int i = 0; i < jugadores.Count; i++)
			{
				for (int j = i + 1; j < jugadores.Count; j++)
				{
					if (jugadores[i].nombre.CompareTo(jugadores[j].nombre) == 1)
					{
						jugAux = jugadores[j];
						jugadores[j] = jugadores[i];
						jugadores[i] = jugAux;
					}
				}
			}
		}
		
		public List<Partido> GetUltimosPartidos(int cant)
		{
			cantPartAMostrar = cant;
			List<Partido> res = new List<Partido>();
			int cantTotal = partidos.Count, limInf = cantTotal - cant;
			for (int i = cantTotal - 1; i >= limInf; i--)
				res.Add(partidos[i]);
			return res;
		}
		
		public List<Partido> GetUltimosPartidos(int cant, int tipoPartido, string nombreJugador, bool porFecha, DateTime desde, DateTime hasta)
		{
			cantPartAMostrar = cant;
			List<Partido> res = new List<Partido>();
			int i = partidos.Count - 1, limInf = i - cant + 1, cantCoinc = 0;
			bool iterar = true;
			while (iterar)
			{
				if
				(
						((nombreJugador == "<TODOS>") ||
						(
							(tipoPartido == 1 && partidos[i].parejaGan.JugadorEnPareja(nombreJugador)) ||
							(tipoPartido == 2 && partidos[i].parejaPerd.JugadorEnPareja(nombreJugador)) ||
							(tipoPartido == 0 && partidos[i].JugadorEnPartido(nombreJugador))
						)) &&
						(
							!porFecha ||
							(partidos[i].fecha.Date >= desde && partidos[i].fecha.Date <= hasta)
						)
				)
				{
					res.Add(partidos[i]);
					cantCoinc++;
				}
				i--;
				iterar = (i >= 0 && cantCoinc < cant && (!porFecha || partidos[i].fecha.Date >= desde && partidos[i].fecha.Date <= hasta));
			}
			return res;
		}
		
		public int IndiceEnLista(string nombreJugador)
		{
			for (int i = 0; i < jugadores.Count; i++)
				if (jugadores[i].nombre == nombreJugador)
					return i;
			return -1;
		}
		
		public void OrdenarEstadGenerales(ref List<EstadGeneral> lista)
		{
			EstadGeneral tmp;
			for (int i = 0; i < lista.Count; i++)
			{
				for (int j = i + 1; j < lista.Count; j++)
				{
					if (lista[j].Valor > lista[i].Valor)
					{
						tmp = lista[i];
						lista[i] = lista[j];
						lista[j] = tmp;
					}
				}
			}
		}
		
		public List<EstadGeneral> GetPartidosJugados()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.cantJugados, jugadores[i].RegistroPersonal.JugadosContraQuien, jugadores[i].RegistroPersonal.JugadosConQuien));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetGanadores()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.cantGanados, jugadores[i].RegistroPersonal.GanadosContraQuien, jugadores[i].RegistroPersonal.GanadosConQuien));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetDuelosIndiv()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			List<RegistroPartido> tmp;
			for (int i = 0; i < jugadores.Count; i++)
			{
				if (!jugadores[i].Eliminado)
				{
					tmp = jugadores[i].RegistroPersonal.GanadosContraQuien;
					for (int j = 0; j < tmp.Count; j++)
					{
						res.Add(new EstadGeneral(jugadores[i].nombre + " a " + tmp[j].nombreJugador, tmp[j].cantPartidos, new List<RegistroPartido>(), new List<RegistroPartido>()));
					}
				}
			}
			OrdenarEstadGenerales(ref res);
			if (res.Count > 20)
				res.RemoveRange(20, res.Count - 20);
			return res;
		}
		
		public List<EstadGeneral> GetPerdedores()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.cantPerdidos, jugadores[i].RegistroPersonal.PerdidosContraQuien, jugadores[i].RegistroPersonal.PerdidosConQuien));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetZapaterosProp()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.PollosPropinados(), jugadores[i].RegistroPersonal.PollosPropContraQuien, jugadores[i].RegistroPersonal.PollosPropConQuien));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetZapaterosRecib()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.PollosRecibidos(), jugadores[i].RegistroPersonal.PollosRecContraQuien, jugadores[i].RegistroPersonal.PollosRecConQuien));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetReculProp()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.ReculPropinados(), jugadores[i].RegistroPersonal.ReculPropContraQuien, jugadores[i].RegistroPersonal.ReculPropConQuien));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetReculRecib()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.ReculRecibidos(), jugadores[i].RegistroPersonal.ReculRecibContraQuien, jugadores[i].RegistroPersonal.ReculRecibConQuien));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetDiferenciaGP()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.DiferenciaGP(), new List<RegistroPartido>(), new List<RegistroPartido>()));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetAverages()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.Average(), new List<RegistroPartido>(), new List<RegistroPartido>()));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetRanking()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, jugadores[i].RegistroPersonal.Elo, new List<RegistroPartido>(), new List<RegistroPartido>()));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public ResultComparacion GetComparacionIndiv(int indJug1, int indJug2, int modo)
		{
			if (indJug1 == indJug2)
				throw new Exception("No se puede comparar a un jugador\ncon él mismo, so mentepollo...");
			string idJug1 = jugadores[indJug1].nombre, idJug2 = jugadores[indJug2].nombre;
			ResultComparacion res = new ResultComparacion(jugadores[indJug1], jugadores[indJug2]);
			
			if (modo == 0)
			{
				string[] idJugs = new string[4];
				for (int i = 0; i < partidos.Count; i++)
				{
					idJugs[0] = partidos[i].parejaGan.nombreJugador1;
					idJugs[1] = partidos[i].parejaGan.nombreJugador2;
					idJugs[2] = partidos[i].parejaPerd.nombreJugador1;
					idJugs[3] = partidos[i].parejaPerd.nombreJugador2;
					
					if (idJugs[0] == idJug1 || idJugs[1] == idJug1)
					{
						res.partidosJugados[0]++;
						res.partidosGanados[0]++;
						if (partidos[i].parejaGan.dioZapato)
							res.pollosProp[0]++;
						else if (partidos[i].parejaGan.dioReculillo)
							res.reculProp[0]++;
					}
					else if (idJugs[2] == idJug1 || idJugs[3] == idJug1)
					{
						res.partidosJugados[0]++;
						res.partidosPerdidos[0]++;
						if (partidos[i].parejaGan.dioZapato)
							res.pollosRecib[0]++;
						else if (partidos[i].parejaGan.dioReculillo)
							res.reculRecib[0]++;
					}
					if (idJugs[0] == idJug2 || idJugs[1] == idJug2)
					{
						res.partidosJugados[1]++;
						res.partidosGanados[1]++;
						if (partidos[i].parejaGan.dioZapato)
							res.pollosProp[1]++;
						else if (partidos[i].parejaGan.dioReculillo)
							res.reculProp[1]++;
					}
					else if (idJugs[2] == idJug2 || idJugs[3] == idJug2)
					{
						res.partidosJugados[1]++;
						res.partidosPerdidos[1]++;
						if (partidos[i].parejaGan.dioZapato)
							res.pollosRecib[1]++;
						else if (partidos[i].parejaGan.dioReculillo)
							res.reculRecib[1]++;
					}
				}
			}
			else if (modo == 1)
			{
				string[] idJugs = new string[4];
				for (int i = 0; i < partidos.Count; i++)
				{
					idJugs[0] = partidos[i].parejaGan.nombreJugador1;
					idJugs[1] = partidos[i].parejaGan.nombreJugador2;
					idJugs[2] = partidos[i].parejaPerd.nombreJugador1;
					idJugs[3] = partidos[i].parejaPerd.nombreJugador2;
					
					if ((idJugs[0] == idJug1 || idJugs[1] == idJug1) && (idJugs[2] == idJug2 || idJugs[3] == idJug2))
					{
						res.partidosJugados[0]++;
						res.partidosGanados[0]++;
						res.partidosJugados[1]++;
						res.partidosPerdidos[1]++;
						if (partidos[i].parejaGan.dioZapato)
						{
							res.pollosProp[0]++;
							res.pollosRecib[1]++;
						}
						else if (partidos[i].parejaGan.dioReculillo)
						{
							res.reculProp[0]++;
							res.reculRecib[1]++;
						}	
					}
					else if ((idJugs[2] == idJug1 || idJugs[3] == idJug1) && (idJugs[0] == idJug2 || idJugs[1] == idJug2))
					{
						res.partidosJugados[0]++;
						res.partidosPerdidos[0]++;
						res.partidosJugados[1]++;
						res.partidosGanados[1]++;
						if (partidos[i].parejaGan.dioZapato)
						{
							res.pollosRecib[0]++;
							res.pollosProp[1]++;
						}
						else if (partidos[i].parejaGan.dioReculillo)
						{
							res.reculRecib[0]++;
							res.reculProp[1]++;
						}
					}
				}
			}
			else if (modo == 2)
			{
				string[] idJugs = new string[4];
				for (int i = 0; i < partidos.Count; i++)
				{
					idJugs[0] = partidos[i].parejaGan.nombreJugador1;
					idJugs[1] = partidos[i].parejaGan.nombreJugador2;
					idJugs[2] = partidos[i].parejaPerd.nombreJugador1;
					idJugs[3] = partidos[i].parejaPerd.nombreJugador2;
					
					if ((idJugs[0] == idJug1 && idJugs[1] == idJug2) || (idJugs[0] == idJug2 && idJugs[1] == idJug1))
					{
						res.partidosJugados[0]++;
						res.partidosJugados[1]++;
						res.partidosGanados[0]++;
						res.partidosGanados[1]++;
						if (partidos[i].parejaGan.dioZapato)
						{
							res.pollosProp[0]++;
							res.pollosProp[1]++;
						}
						else if (partidos[i].parejaGan.dioReculillo)
						{
							res.reculProp[0]++;
							res.reculProp[1]++;
						}	
					}
					else if ((idJugs[2] == idJug1 && idJugs[3] == idJug2) || (idJugs[2] == idJug2 && idJugs[3] == idJug1))
					{
						res.partidosJugados[0]++;
						res.partidosJugados[1]++;
						res.partidosPerdidos[0]++;
						res.partidosPerdidos[1]++;
						if (partidos[i].parejaGan.dioZapato)
						{
							res.pollosRecib[0]++;
							res.pollosRecib[1]++;
						}
						else if (partidos[i].parejaGan.dioReculillo)
						{
							res.reculRecib[0]++;
							res.reculRecib[1]++;
						}
					}
				}
			}
			return res;
		}
		
		
		public ResultComparacion GetComparacionIndiv(int indJug1, int indJug2, int modo, DateTime fechaInic, DateTime fechaFin)
		{
			if (indJug1 == indJug2)
				throw new Exception("No se puede comparar a un jugador\ncon él mismo, so mentepollo...");
			string idJug1 = jugadores[indJug1].nombre, idJug2 = jugadores[indJug2].nombre;
			ResultComparacion res = new ResultComparacion(jugadores[indJug1], jugadores[indJug2]);

			if (modo == 0)
			{
				string[] idJugs = new string[4];
				for (int i = 0; i < partidos.Count; i++)
				{
					idJugs[0] = partidos[i].parejaGan.nombreJugador1;
					idJugs[1] = partidos[i].parejaGan.nombreJugador2;
					idJugs[2] = partidos[i].parejaPerd.nombreJugador1;
					idJugs[3] = partidos[i].parejaPerd.nombreJugador2;
					
					if ((idJugs[0] == idJug1 || idJugs[1] == idJug1) && partidos[i].fecha >= fechaInic && partidos[i].fecha <= fechaFin)
					{
						res.partidosJugados[0]++;
						res.partidosGanados[0]++;
						if (partidos[i].parejaGan.dioZapato)
							res.pollosProp[0]++;
						else if (partidos[i].parejaGan.dioReculillo)
							res.reculProp[0]++;
					}
					else if ((idJugs[2] == idJug1 || idJugs[3] == idJug1) && partidos[i].fecha >= fechaInic && partidos[i].fecha <= fechaFin)
					{
						res.partidosJugados[0]++;
						res.partidosPerdidos[0]++;
						if (partidos[i].parejaGan.dioZapato)
							res.pollosRecib[0]++;
						else if (partidos[i].parejaGan.dioReculillo)
							res.reculRecib[0]++;
					}
					if ((idJugs[0] == idJug2 || idJugs[1] == idJug2) && partidos[i].fecha >= fechaInic && partidos[i].fecha <= fechaFin)
					{
						res.partidosJugados[1]++;
						res.partidosGanados[1]++;
						if (partidos[i].parejaGan.dioZapato)
							res.pollosProp[1]++;
						else if (partidos[i].parejaGan.dioReculillo)
							res.reculProp[1]++;
					}
					else if ((idJugs[2] == idJug2 || idJugs[3] == idJug2) && partidos[i].fecha >= fechaInic && partidos[i].fecha <= fechaFin)
					{
						res.partidosJugados[1]++;
						res.partidosPerdidos[1]++;
						if (partidos[i].parejaGan.dioZapato)
							res.pollosRecib[1]++;
						else if (partidos[i].parejaGan.dioReculillo)
							res.reculRecib[1]++;
					}
				}
			}
			else if (modo == 1)
			{
				string[] idJugs = new string[4];
				for (int i = 0; i < partidos.Count; i++)
				{
					idJugs[0] = partidos[i].parejaGan.nombreJugador1;
					idJugs[1] = partidos[i].parejaGan.nombreJugador2;
					idJugs[2] = partidos[i].parejaPerd.nombreJugador1;
					idJugs[3] = partidos[i].parejaPerd.nombreJugador2;
					
					if (((idJugs[0] == idJug1 || idJugs[1] == idJug1) && (idJugs[2] == idJug2 || idJugs[3] == idJug2)) && partidos[i].fecha >= fechaInic && partidos[i].fecha <= fechaFin)
					{
						res.partidosJugados[0]++;
						res.partidosGanados[0]++;
						res.partidosJugados[1]++;
						res.partidosPerdidos[1]++;
						if (partidos[i].parejaGan.dioZapato)
						{
							res.pollosProp[0]++;
							res.pollosRecib[1]++;
						}
						else if (partidos[i].parejaGan.dioReculillo)
						{
							res.reculProp[0]++;
							res.reculRecib[1]++;
						}	
					}
					else if (((idJugs[2] == idJug1 || idJugs[3] == idJug1) && (idJugs[0] == idJug2 || idJugs[1] == idJug2)) && partidos[i].fecha >= fechaInic && partidos[i].fecha <= fechaFin)
					{
						res.partidosJugados[0]++;
						res.partidosPerdidos[0]++;
						res.partidosJugados[1]++;
						res.partidosGanados[1]++;
						if (partidos[i].parejaGan.dioZapato)
						{
							res.pollosRecib[0]++;
							res.pollosProp[1]++;
						}
						else if (partidos[i].parejaGan.dioReculillo)
						{
							res.reculRecib[0]++;
							res.reculProp[1]++;
						}
					}
				}
			}
			else if (modo == 2)
			{
				string[] idJugs = new string[4];
				for (int i = 0; i < partidos.Count; i++)
				{
					idJugs[0] = partidos[i].parejaGan.nombreJugador1;
					idJugs[1] = partidos[i].parejaGan.nombreJugador2;
					idJugs[2] = partidos[i].parejaPerd.nombreJugador1;
					idJugs[3] = partidos[i].parejaPerd.nombreJugador2;
					
					if (((idJugs[0] == idJug1 && idJugs[1] == idJug2) || (idJugs[0] == idJug2 && idJugs[1] == idJug1)) && partidos[i].fecha >= fechaInic && partidos[i].fecha <= fechaFin)
					{
						res.partidosJugados[0]++;
						res.partidosJugados[1]++;
						res.partidosGanados[0]++;
						res.partidosGanados[1]++;
						if (partidos[i].parejaGan.dioZapato)
						{
							res.pollosProp[0]++;
							res.pollosProp[1]++;
						}
						else if (partidos[i].parejaGan.dioReculillo)
						{
							res.reculProp[0]++;
							res.reculProp[1]++;
						}	
					}
					else if (((idJugs[2] == idJug1 && idJugs[3] == idJug2) || (idJugs[2] == idJug2 && idJugs[3] == idJug1)) && partidos[i].fecha >= fechaInic && partidos[i].fecha <= fechaFin)
					{
						res.partidosJugados[0]++;
						res.partidosJugados[1]++;
						res.partidosPerdidos[0]++;
						res.partidosPerdidos[1]++;
						if (partidos[i].parejaGan.dioZapato)
						{
							res.pollosRecib[0]++;
							res.pollosRecib[1]++;
						}
						else if (partidos[i].parejaGan.dioReculillo)
						{
							res.reculRecib[0]++;
							res.reculRecib[1]++;
						}
					}
				}
			}
			return res;
		}
		
		/*public List<Pareja> GetParejas()
		{
			List<Pareja> parejas = new List<Pareja>();
			for (int i = 0; i < jugadores.Count; i++)
				for (int j = i + 1; j < jugadores.Count; j++)
					parejas.Add(new Pareja(jugadores[i].nombre, jugadores[j].nombre));
			return parejas;
		}*/
		
		public ListaEstadPareja GetParejas()
		{
			ListaEstadPareja parejas = new ListaEstadPareja();
			for (int i = 0; i < jugadores.Count; i++)
				for (int j = i + 1; j < jugadores.Count; j++)
					parejas.AdicionarPareja(new Pareja(jugadores[i].nombre, jugadores[j].nombre));
			return parejas;
		}
		
		public ListaEstadPareja GetParejasJugadoras(string pNombre)
		{
			ListaEstadPareja res = GetParejas();
			int posParejaGan, posParejaPerd, posParejaGanAsoc, posParejaPerdAsoc;
			string idParejaGan, idParejaPerd;
			for (int i = 0; i < partidos.Count; i++)
			{
				if (pNombre == "<TODOS>" || partidos[i].JugadorEnPartido(pNombre))
				{
					partidos[i].OrdenarJugadores();
					idParejaGan = partidos[i].parejaGan.IdPareja();
					idParejaPerd = partidos[i].parejaPerd.IdPareja();
					posParejaGan = res.PosicionEnLista(idParejaGan);
					if (posParejaGan == -1)
					{
						res.AdicionarPareja(partidos[i].parejaGan);
						posParejaGan = res.CantidadParejas() - 1;
					}
					posParejaPerd = res.PosicionEnLista(idParejaPerd);
					if (posParejaPerd == -1)
					{
						res.AdicionarPareja(partidos[i].parejaPerd);
						posParejaPerd = res.CantidadParejas() - 1;
					}
					posParejaGanAsoc = res.PosicionEnListaDeParejas(posParejaPerd, idParejaGan);
					if (posParejaGanAsoc == -1)
					{
						res.AdicionarParejaAsoc(posParejaPerd, partidos[i].parejaGan);
						posParejaGanAsoc = res.CantidadParejasAsoc(posParejaPerd) - 1;
					}
					posParejaPerdAsoc = res.PosicionEnListaDeParejas(posParejaGan, idParejaPerd);
					if (posParejaPerdAsoc == -1)
					{
						res.AdicionarParejaAsoc(posParejaGan, partidos[i].parejaPerd);
						posParejaPerdAsoc = res.CantidadParejasAsoc(posParejaGan) - 1;
					}
					res.ActualizarValorParejaAsoc(posParejaGan, posParejaPerdAsoc);
					res.ActualizarValorParejaAsoc(posParejaPerd, posParejaGanAsoc);
				}
			}
			OrdenarListaEstadParejas(ref res, true);
			return res;
		}
		
		public ListaEstadPareja GetParejasGanadoras(string pNombre)
		{
			ListaEstadPareja res = GetParejas();
			int posParejaGan, posParejaPerdAsoc;
			string idParejaGan, idParejaPerd;
			for (int i = 0; i < partidos.Count; i++)
			{
				if (pNombre == "<TODOS>" || partidos[i].parejaGan.JugadorEnPareja(pNombre))
				{
						partidos[i].OrdenarJugadores();
					idParejaGan = partidos[i].parejaGan.IdPareja();
					idParejaPerd = partidos[i].parejaPerd.IdPareja();
					posParejaGan = res.PosicionEnLista(idParejaGan);
					if (posParejaGan == -1)
					{
						res.AdicionarPareja(partidos[i].parejaGan);
						posParejaGan = res.CantidadParejas() - 1;
					}
					posParejaPerdAsoc = res.PosicionEnListaDeParejas(posParejaGan, idParejaPerd);
					if (posParejaPerdAsoc == -1)
					{
						res.AdicionarParejaAsoc(posParejaGan, partidos[i].parejaPerd);
						posParejaPerdAsoc = res.CantidadParejasAsoc(posParejaGan) - 1;
					}
					res.ActualizarValorParejaAsoc(posParejaGan, posParejaPerdAsoc);
				}
			}
			OrdenarListaEstadParejas(ref res, true);
			return res;
		}
		
		public ListaEstadPareja GetParejasPerdedoras(string pNombre)
		{
			ListaEstadPareja res = GetParejas();
			int posParejaPerd, posParejaGanAsoc;
			string idParejaGan, idParejaPerd;
			for (int i = 0; i < partidos.Count; i++)
			{
				if (pNombre == "<TODOS>" || partidos[i].parejaPerd.JugadorEnPareja(pNombre))
				{
					partidos[i].OrdenarJugadores();
					idParejaGan = partidos[i].parejaGan.IdPareja();
					idParejaPerd = partidos[i].parejaPerd.IdPareja();
					posParejaPerd = res.PosicionEnLista(idParejaPerd);
					if (posParejaPerd == -1)
					{
						res.AdicionarPareja(partidos[i].parejaPerd);
						posParejaPerd = res.CantidadParejas() - 1;
					}
					posParejaGanAsoc = res.PosicionEnListaDeParejas(posParejaPerd, idParejaGan);
					if (posParejaGanAsoc == -1)
					{
						res.AdicionarParejaAsoc(posParejaPerd, partidos[i].parejaGan);
						posParejaGanAsoc = res.CantidadParejasAsoc(posParejaPerd) - 1;
					}
					res.ActualizarValorParejaAsoc(posParejaPerd, posParejaGanAsoc);
				}
			}
			OrdenarListaEstadParejas(ref res, true);
			return res;
		}
		
		public ListaEstadPareja GetParejasPorPollonasProp(string pNombre)
		{
			ListaEstadPareja res = GetParejas();
			int posParejaGan, posParejaPerdAsoc;
			string idParejaGan, idParejaPerd;
			for (int i = 0; i < partidos.Count; i++)
			{
				if (partidos[i].parejaGan.dioZapato && (pNombre == "<TODOS>" || partidos[i].parejaGan.JugadorEnPareja(pNombre)))
				{
					partidos[i].OrdenarJugadores();
					idParejaGan = partidos[i].parejaGan.IdPareja();
					idParejaPerd = partidos[i].parejaPerd.IdPareja();
					posParejaGan = res.PosicionEnLista(idParejaGan);
					if (posParejaGan == -1)
					{
						res.AdicionarPareja(partidos[i].parejaGan);
						posParejaGan = res.CantidadParejas() - 1;
					}
					posParejaPerdAsoc = res.PosicionEnListaDeParejas(posParejaGan, idParejaPerd);
					if (posParejaPerdAsoc == -1)
					{
						res.AdicionarParejaAsoc(posParejaGan, partidos[i].parejaPerd);
						posParejaPerdAsoc = res.CantidadParejasAsoc(posParejaGan) - 1;
					}
					res.ActualizarValorParejaAsoc(posParejaGan, posParejaPerdAsoc);
				}
			}
			OrdenarListaEstadParejas(ref res, true);
			return res;
		}
		
		public ListaEstadPareja GetParejasPorPollonasRecib(string pNombre)
		{
			ListaEstadPareja res = GetParejas();
			int posParejaPerd, posParejaGanAsoc;
			string idParejaGan, idParejaPerd;
			for (int i = 0; i < partidos.Count; i++)
			{
				if (partidos[i].parejaGan.dioZapato && (pNombre == "<TODOS>" || partidos[i].parejaPerd.JugadorEnPareja(pNombre)))
				{
					partidos[i].OrdenarJugadores();
					idParejaGan = partidos[i].parejaGan.IdPareja();
					idParejaPerd = partidos[i].parejaPerd.IdPareja();
					posParejaPerd = res.PosicionEnLista(idParejaPerd);
					if (posParejaPerd == -1)
					{
						res.AdicionarPareja(partidos[i].parejaPerd);
						posParejaPerd = res.CantidadParejas() - 1;
					}
					posParejaGanAsoc = res.PosicionEnListaDeParejas(posParejaPerd, idParejaGan);
					if (posParejaGanAsoc == -1)
					{
						res.AdicionarParejaAsoc(posParejaPerd, partidos[i].parejaGan);
						posParejaGanAsoc = res.CantidadParejasAsoc(posParejaPerd) - 1;
					}
					res.ActualizarValorParejaAsoc(posParejaPerd, posParejaGanAsoc);
				}
			}
			OrdenarListaEstadParejas(ref res, true);
			return res;
		}
		
		public ListaEstadPareja GetParejasPorReculProp(string pNombre)
		{
			ListaEstadPareja res = GetParejas();
			int posParejaGan, posParejaPerdAsoc;
			string idParejaGan, idParejaPerd;
			for (int i = 0; i < partidos.Count; i++)
			{
				if (partidos[i].parejaGan.dioReculillo && (pNombre == "<TODOS>" || partidos[i].parejaGan.JugadorEnPareja(pNombre)))
				{
					partidos[i].OrdenarJugadores();
					idParejaGan = partidos[i].parejaGan.IdPareja();
					idParejaPerd = partidos[i].parejaPerd.IdPareja();
					posParejaGan = res.PosicionEnLista(idParejaGan);
					if (posParejaGan == -1)
					{
						res.AdicionarPareja(partidos[i].parejaGan);
						posParejaGan = res.CantidadParejas() - 1;
					}
					posParejaPerdAsoc = res.PosicionEnListaDeParejas(posParejaGan, idParejaPerd);
					if (posParejaPerdAsoc == -1)
					{
						res.AdicionarParejaAsoc(posParejaGan, partidos[i].parejaPerd);
						posParejaPerdAsoc = res.CantidadParejasAsoc(posParejaGan) - 1;
					}
					res.ActualizarValorParejaAsoc(posParejaGan, posParejaPerdAsoc);
				}
			}
			OrdenarListaEstadParejas(ref res, true);
			return res;
		}
		
		public ListaEstadPareja GetParejasPorReculRec(string pNombre)
		{
			ListaEstadPareja res = GetParejas();
			int posParejaPerd, posParejaGanAsoc;
			string idParejaGan, idParejaPerd;
			for (int i = 0; i < partidos.Count; i++)
			{
				if (partidos[i].parejaGan.dioReculillo && (pNombre == "<TODOS>" || partidos[i].parejaPerd.JugadorEnPareja(pNombre)))
				{
					partidos[i].OrdenarJugadores();
					idParejaGan = partidos[i].parejaGan.IdPareja();
					idParejaPerd = partidos[i].parejaPerd.IdPareja();
					posParejaPerd = res.PosicionEnLista(idParejaPerd);
					if (posParejaPerd == -1)
					{
						res.AdicionarPareja(partidos[i].parejaPerd);
						posParejaPerd = res.CantidadParejas() - 1;
					}
					posParejaGanAsoc = res.PosicionEnListaDeParejas(posParejaPerd, idParejaGan);
					if (posParejaGanAsoc == -1)
					{
						res.AdicionarParejaAsoc(posParejaPerd, partidos[i].parejaGan);
						posParejaGanAsoc = res.CantidadParejasAsoc(posParejaPerd) - 1;
					}
					res.ActualizarValorParejaAsoc(posParejaPerd, posParejaGanAsoc);
				}
			}
			OrdenarListaEstadParejas(ref res, true);
			return res;
		}
		
		public ListaEstadPareja GetParejasPorDiferenciaGP(string pNombre)
		{
			//ListaEstadPareja res = GetParejas(), ganadoras = GetParejasGanadoras(pNombre), perdedoras = GetParejasPerdedoras(pNombre);
			ListaEstadPareja res = GetParejas(), ganadoras = GetParejasGanadoras("<TODOS>"), perdedoras = GetParejasPerdedoras("<TODOS>");
			int i = 0, ganados, perdidos;
			string idPareja;
			Pareja parAux;
			while (i < res.ListaParejas.Count)
			{
				parAux = res.ListaParejas[i].Pareja;
				idPareja = parAux.IdPareja();
				/*if (pNombre == "<TODOS>" || parAux.JugadorEnPareja(pNombre))
				{*/
					ganados = (int)ganadoras.PuntuacionEnLista(idPareja);
					perdidos = (int)perdedoras.PuntuacionEnLista(idPareja);
					if ((ganados > 0 || perdidos > 0))
						res.ListaParejas[i].Pareja.puntuacion = ganados - perdidos;
					else
						res.ListaParejas.RemoveAt(i);
				/*}
				else
					res.ListaParejas.RemoveAt(i);*/
				i++;
			}
			OrdenarListaEstadParejas(ref res, false);
			return res;
		}
		
		void OrdenarListaEstadParejas(ref ListaEstadPareja res, bool eliminarCeros)
		{
			int cant = res.CantidadParejas(), cantParejas;
			EstadPareja estadAux;
			Pareja parejaAux;
			for (int i = 0; i < cant; i++)
			{
				cantParejas = res.ListaParejas[i].Parejas.Count;
				
				for (int k = 0; k < cantParejas; k++)
				{
					for (int l = k + 1; l < cantParejas; l++)
					{
						if (res.ListaParejas[i].Parejas[l].puntuacion > res.ListaParejas[i].Parejas[k].puntuacion)
						{
							parejaAux = res.ListaParejas[i].Parejas[k];
							res.ListaParejas[i].Parejas[k] = res.ListaParejas[i].Parejas[l];
							res.ListaParejas[i].Parejas[l] = parejaAux;
						}
					}
				}
			}
			
			for (int i = 0; i < cant; i++)
			{
				for (int j = i + 1; j < cant; j++)
				{
					if (res.ListaParejas[j].Pareja.puntuacion > res.ListaParejas[i].Pareja.puntuacion)
					{
						estadAux = res.ListaParejas[i];
						res.ListaParejas[i] = res.ListaParejas[j];
						res.ListaParejas[j] = estadAux;
					}
				}
				if (res.ListaParejas[i].Pareja.puntuacion == 0 && eliminarCeros)
				{
					res.ListaParejas.RemoveRange(i, res.ListaParejas.Count - i);
					break;
				}
			}
		}
		
		public int TercioDeJugadores()
		{
			int cantJugadoresActivos = 0;
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					cantJugadoresActivos++;
			return cantJugadoresActivos / 3;
		}
		
		public List<EstadGeneral> GetGruposJugadores(int modo)
		{
			List<EstadGeneral> res = GetRanking();
			int tercio = TercioDeJugadores();
			
			if (modo != 1)
			{
				if (modo == 2)
					res.Reverse();
				res.RemoveRange(tercio, res.Count - tercio);
			}
			else
			{
				int fin = res.Count - tercio;
				res.RemoveRange(0, tercio);
				res.Reverse();
				res.RemoveRange(0, tercio);
				res.Reverse();
			}
			return res;
		}
		
		public List<HistorialELO> GetHistorialELOJugador(string nombreJugador, bool porFecha, DateTime desde, DateTime hasta)
		{
			List<HistorialELO> historial = jugadores[IndiceEnLista(nombreJugador)].RegistroPersonal.HistorialELO;
			if (!porFecha)
				return historial;
			else
			{
				List<HistorialELO> res = new List<HistorialELO>();
				for (int i = 0; i < historial.Count; i++)
					if (historial[i].Fecha >= desde && historial[i].Fecha <= hasta)
						res.Add(historial[i]);
				return res;
			}
		}
		
		public List<Color> GetListaColores(bool eliminarClaros)
		{
			List<Color> colores = new List<Color>();
			Array arrColores = Enum.GetValues(typeof(KnownColor));
			Color tmp;
			foreach(KnownColor colorTmp in arrColores)
			{
				tmp = Color.FromKnownColor(colorTmp);
				if (!((tmp.Name.ToLower().Contains("light") || tmp.Name.ToLower().Contains("white") || tmp.Name.ToLower().Contains("gray") || tmp.Name.ToLower().Contains("transp")) || !eliminarClaros) && !tmp.IsSystemColor)
					colores.Add(tmp);
			}
			return colores;
		}
		
		public List<Color> GetListaColores()
		{
			List<Color> colores = new List<Color>();
			colores.Add(Color.Red);
			colores.Add(Color.Green);
			colores.Add(Color.Blue);
			colores.Add(Color.DarkOrange);
			colores.Add(Color.CadetBlue);
			colores.Add(Color.DarkViolet);
			colores.Add(Color.DarkKhaki);
			colores.Add(Color.DarkRed);
			colores.Add(Color.ForestGreen);
			colores.Add(Color.DarkTurquoise);
			colores.Add(Color.Crimson);
			colores.Add(Color.DarkCyan);
			colores.Add(Color.DeepPink);
			colores.Add(Color.DeepSkyBlue);
			colores.Add(Color.DarkMagenta);
			colores.Add(Color.GreenYellow);
			return colores;
		}
		
		public string EnviarCorreo(string mensaje, Partido partido)
        {
			try
			{
				MailMessage correo = new MailMessage();
	        	correo.From = new MailAddress(correoRemitente);
	        	correo.Sender = correo.From;
	        	for (int i = 0; i < jugadores.Count; i++)
	        		if (!jugadores[i].Eliminado && jugadores[i].correo != "")
	        			correo.To.Add(jugadores[i].correo);
	        	correo.Subject = correoAsunto;
	        	correo.IsBodyHtml = correoHTML;
	        	correo.Body = mensaje;
				correo.Priority = correoPrioridad;
				SmtpClient smtp = new SmtpClient();
				smtp.Host = correoServidor;
				smtp.Port = correoPuerto;
				smtp.EnableSsl = correoSSL;
				smtp.UseDefaultCredentials = correoCredencPredet;
				smtp.Credentials = new NetworkCredential(correoCuenta, correoContrasenna);
				smtp.Send(correo);
			 	correo.Dispose();
			 	return "Mensaje enviado.";
			}
			catch (Exception exc)
			{
				return exc.Message;
			}
        }
		
		public List<EstadGeneral> GetMejoresRachasJugadores()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, GetMejorRachaJugador(i), new List<RegistroPartido>(), new List<RegistroPartido>()));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public List<EstadGeneral> GetPeoresRachasJugadores()
		{
			List<EstadGeneral> res = new List<EstadGeneral>();
			for (int i = 0; i < jugadores.Count; i++)
				if (!jugadores[i].Eliminado)
					res.Add(new EstadGeneral(jugadores[i].nombre, Math.Abs(GetPeorRachaJugador(i)), new List<RegistroPartido>(), new List<RegistroPartido>()));
			OrdenarEstadGenerales(ref res);
			return res;
		}
		
		public int GetMejorRachaJugador(int indJugador)
		{
			string nombreJugAux = jugadores[indJugador].nombre;
			int mejorRacha = 0, rachaParcial = 0;
			for (int i = 0; i < partidos.Count; i++)
			{
				if (partidos[i].parejaGan.JugadorEnPareja(nombreJugAux))
					rachaParcial++;
				else if (partidos[i].parejaPerd.JugadorEnPareja(nombreJugAux))
				{
					if (rachaParcial > mejorRacha)
						mejorRacha = rachaParcial;
					rachaParcial = 0;
				}
			}
			return mejorRacha;
		}
		
		public int GetPeorRachaJugador(int indJugador)
		{
			string nombreJugAux = jugadores[indJugador].nombre;
			int mejorRacha = 0, rachaParcial = 0;
			for (int i = 0; i < partidos.Count; i++)
			{
				if (partidos[i].parejaPerd.JugadorEnPareja(nombreJugAux))
					rachaParcial--;
				else if (partidos[i].parejaGan.JugadorEnPareja(nombreJugAux))
				{
					if (rachaParcial < mejorRacha)
						mejorRacha = rachaParcial;
					rachaParcial = 0;
				}
			}
			return mejorRacha;
		}
		
		/*public void ReproducirSonido(int indSonido, bool repetir)
		{
			nombreFicheroReprod = "_d4DsaX4f_1.tmp";
			File.Delete(nombreFicheroReprod);
			Stream fichero = new FileStream(nombreFicheroReprod, FileMode.Create);
			fichero.Write(sonidos[indSonido].Bytes, 0, sonidos[indSonido].Bytes.Length);
			File.SetAttributes(nombreFicheroReprod, FileAttributes.Hidden);
			fichero.Close();
			reprod = new ReproductorAudio();
			reprod.Open(nombreFicheroReprod);
			reprod.Play(repetir);
		}*/
	}
}
