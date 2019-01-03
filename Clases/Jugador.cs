
using System;
using System.Drawing;

namespace ControlDomino.Clases
{
	[Serializable]
	public class Jugador
	{
		const int anchoAvatar = 250;
		const int altoAvatar = 250;
		private bool eliminado;
		private Image avatar;
		private RegistroJugador registroPersonal;
		public string nombre, sexo, correo;
		
		public Jugador()
		{
			nombre = "";
			sexo = "";
			avatar = null;
			correo = "";
			registroPersonal = new RegistroJugador("", 0);
		}
		
		public Jugador(string pNombre, string pSexo, Image pAvatar, double pElo, string pCorreo)
		{
			if (pNombre == "" || pSexo == "")
				throw new Exception("Datos insuficientes.");
			if (pAvatar != null && (pAvatar.Width > anchoAvatar || pAvatar.Height > altoAvatar))
				throw new Exception("La imagen es demasiado grande.\nDimensiones máximas: " + anchoAvatar.ToString() + " x " + altoAvatar.ToString() + " px.");
			eliminado = false;
			nombre = pNombre;
			sexo = pSexo;
			avatar = pAvatar;
			correo = pCorreo;
			registroPersonal = new RegistroJugador(pNombre, pElo);
		}
		
		public bool Eliminado {
			get { return eliminado; }
			set { eliminado = value; }
		}
		
		public RegistroJugador RegistroPersonal {
			get { return registroPersonal; }
			set { registroPersonal = value; }
		}
		
		public Image Avatar {
			get { return avatar; }
			set { avatar = value; }
		}
		
		public void SetAvatar(Image pAvatar)
		{
			if (pAvatar.Width > altoAvatar || pAvatar.Height > anchoAvatar)
				throw new Exception("La imagen es demasiado grande.\nDimensiones máximas: " + anchoAvatar.ToString() + " x " + altoAvatar.ToString() + "px.");
			avatar = pAvatar;
		}
		
		public bool Iguales(Jugador nuevo)
		{
			return (MiembrosEstaticos.NormalizarCadena(nombre, true, false) == MiembrosEstaticos.NormalizarCadena(nuevo.nombre, true, false));
		}
	}
}
