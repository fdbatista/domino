using System;
using System.Collections.Generic;
using System.IO;

namespace ControlDomino.Clases
{
	[Serializable]
	public class ListaClaseControl
	{
		private List<ClaseControl> listaDomino;
		public string nombreFicheroReprod;
		public List<Sonido> sonidos;
		public ReproductorAudio reprod;
		
		public ListaClaseControl()
		{
			this.listaDomino = new List<ClaseControl>();
			this.listaDomino.Add(new ClaseControl("Dominó"));
			this.sonidos = new List<Sonido>();
			nombreFicheroReprod = "_d4DsaX4f_1.tmp";
		}
		
		public ListaClaseControl(List<ClaseControl> listaDomino)
		{
			this.listaDomino = listaDomino;
			this.sonidos = new List<Sonido>();
			nombreFicheroReprod = "_d4DsaX4f_1.tmp";
		}
		
		public List<ClaseControl> ListaDomino
		{
			get { return listaDomino; }
			set { listaDomino = value; }
		}
		
		public int PosListaActual()
		{
			return listaDomino.Count - 1;
		}
		
		public void AdicionarLista(string nombre, bool copiarUsuarios)
		{
			string nombreAux = MiembrosEstaticos.NormalizarCadena(nombre, true, false);
			ValidarNombreLista(nombreAux);
			ClaseControl nueva = new ClaseControl(nombreAux);
			if (listaDomino.Count > 0 && copiarUsuarios)
			{
				List<Jugador> listaJug = listaDomino[PosListaActual()].jugadores;
				Jugador jugAux;
				for (int i = 0; i < listaJug.Count; i++)
				{
					if (!listaJug[i].Eliminado)
					{
						jugAux = new Jugador(listaJug[i].nombre, listaJug[i].sexo, listaJug[i].Avatar, nueva.Parametros().EloInicial, listaJug[i].correo);
						nueva.jugadores.Add(jugAux);
					}
				}
			}
			listaDomino.Add(nueva);
		}
		
		public int CantidadListas()
		{
			return listaDomino.Count;
		}
		
		public void EliminarLista(int posLista)
		{
			listaDomino.RemoveAt(posLista);
		}
		
		public void CambiarNombreLista(int posLista, string nuevoNombre)
		{
			string nombreAux = MiembrosEstaticos.NormalizarCadena(nuevoNombre, true, false);
			ValidarNombreLista(nombreAux);
			listaDomino[posLista].nombreLista = nombreAux;
		}
		
		void ValidarNombreLista(string nombre)
		{
			if (nombre == "")
				throw new Exception("Botonzo, tienes que poner un nombre...");
			for (int i = 0; i < listaDomino.Count; i++)
				if (listaDomino[i].nombreLista == nombre)
					throw new Exception("Ya existe un torneo con ese nombre, so anormal.");
		}
		
		public string NombreLista(int posLista)
		{
			return listaDomino[posLista].nombreLista;
		}
		
		public ClaseControl ListaEnPosicion(int posLista)
		{
			return listaDomino[posLista];
		}
		
		public void ReproducirSonido(string prefijoNombreSonido, bool repetir)
		{
			try
			{
				nombreFicheroReprod = "_d4DsaX4f_1.mp3";
				byte[] sonido = GetSonido(prefijoNombreSonido);
				File.Delete(nombreFicheroReprod);
				Stream fichero = new FileStream(nombreFicheroReprod, FileMode.Create);
				fichero.Write(sonido, 0, sonido.Length);
				File.SetAttributes(nombreFicheroReprod, FileAttributes.Hidden);
				fichero.Close();
				reprod = new ReproductorAudio();
				reprod.Open(nombreFicheroReprod);
				reprod.Play(repetir);
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
			finally
			{
				
			}
		}
		
		public void DetenerReproduccion()
		{
			try
			{
				reprod.Close();
				File.Delete(nombreFicheroReprod);
			}
			catch (Exception){}
		}
		
		public byte[] GetSonido(string prefijoNombreSonido)
		{
			for (int i = 0; i < sonidos.Count; i++)
				if (sonidos[i].Nombre.StartsWith(prefijoNombreSonido))
					return sonidos[i].Bytes;
			return new byte[0];
		}
	}
}
