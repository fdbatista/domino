using System;
using System.Text;
using System.Runtime.InteropServices;

namespace ControlDomino.Clases
{
	[Serializable]
	public class Sonido
	{
		private string nombre;
		private byte[] bytes;
		
		public Sonido(string pNombre, byte[] pBytes)
		{
			nombre = pNombre;
			bytes = pBytes;
		}
		
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		
		public byte[] Bytes
		{
			get { return bytes; }
			set { bytes = value; }
		}
	}
}