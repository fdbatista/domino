
using System;
using System.Drawing;

namespace ControlDomino.Clases
{
	[Serializable]
	public class Record
	{
		//private Image avatar;
		public string nombre, nombreJugador;
		//public Jugador jugador;
		public Partido partido;
		public double valor;
		
		public Record()
		{
			nombre = "";
			nombreJugador = "";
			//avatar = null;
			partido = new Partido();
			valor = 0;
		}
		
		/*public Image Avatar {
			get { return avatar; }
		}*/
		
		public Record(string nNombre, string nJug, Partido nPart, double nVal/*, Image nAvatar*/)
		{
			nombre = nNombre;
			nombreJugador = nJug;
			partido = nPart;
			valor = nVal;
			//avatar = nAvatar;
		}
	}
}
