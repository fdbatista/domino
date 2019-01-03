
using System;
using System.Collections.Generic;

namespace ControlDomino.Clases
{
	[Serializable]
	public class RegistroPartido
	{
		public string nombreJugador;
		public int cantPartidos;
		
		public RegistroPartido()
		{
			nombreJugador = "";
			cantPartidos = 0;
		}
		
		public RegistroPartido(string pNombJug, int pCant)
		{
			nombreJugador = pNombJug;
			cantPartidos = pCant;
		}
	}
}
