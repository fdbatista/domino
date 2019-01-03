
using System;
using System.Collections.Generic;

namespace ControlDomino.Clases
{
	[Serializable]
	public class Partido
	{
		public Pareja parejaGan;
		public Pareja parejaPerd;
		public DateTime fecha;
		public string comentario;
		
		public Partido()
		{
			parejaGan = new Pareja();
			parejaPerd = new Pareja();
			fecha = DateTime.Now;
		}
		
		public Partido(Pareja parGan, Pareja parPerd, DateTime pFecha, string pComentario, Parametros parametros)
		{
			if (parGan.puntuacion != parametros.PuntosParaGanar)
				throw new Exception("¿Cómo es posible que la pareja ganadora\nhaya acumulado " + parGan.puntuacion.ToString() + " puntos?");
			else if (parPerd.puntuacion < 0 || parPerd.puntuacion >= parametros.PuntosParaGanar)
				throw new Exception("¿Cómo es posible que la pareja perdedora\nhaya acumulado " + parGan.puntuacion.ToString() + " puntos?");
			else if (parGan.dioReculillo && parPerd.dioReculillo)
				throw new Exception("No me jodas, ¿las dos parejas dieron reculillo?\n¿Hasta dónde puede llegar tu estupidez?");
			else if (parGan.dioZapato && parPerd.dioZapato)
				throw new Exception("No me jodas, ¿las dos parejas dieron pollona?\n¿Existe algún límite para tu estupidez?");
			else if (parGan.dioZapato && parPerd.puntuacion > 0)
				throw new Exception("Primera pollona que veo en que los perdedores cogen puntos...\nEso es lo que yo llamo un y2n3l...1smo");
			else if (parGan.dioReculillo && parPerd.puntuacion < parametros.InicioReculillo)
				throw new Exception("El reculillo comienza con " + parametros.InicioReculillo.ToString() + " puntos...\n¿serás gilipollas?");
			else if (!parGan.dioZapato && parPerd.puntuacion == 0)
				throw new Exception("Si la pareja perdedora no cogió puntos,\neso casi siempre se llama POLLO.\nEmpieza de nuevo, cerebro de POLLO...");
			else if (parPerd.puntuacion == 1 || parPerd.puntuacion == 2)
				throw new Exception("Ven acá, ¿tú eres mentepollo o mentepollo?\n¿Cómo es posible que una pareja coja solamente " + parejaPerd.puntuacion.ToString() + "?");
			else if (parGan.puntuacion == parPerd.puntuacion)
				throw new Exception("Ven acá, ¿tú eres mentepollo o mentepollo?\n¿Cómo es posible que ambas tengan " + parejaPerd.puntuacion.ToString() + " puntos?");
			else if (parGan.nombreJugador1 == "" || parGan.nombreJugador2 == "" || parPerd.nombreJugador1 == "" || parPerd.nombreJugador2 == "")
				throw new Exception("Datos incompletos... intenta de nuevo, so mentepollo...");
			else if (parGan.JugadorEnPareja(parPerd.nombreJugador1) || parGan.JugadorEnPareja(parPerd.nombreJugador2) || parPerd.JugadorEnPareja(parGan.nombreJugador1) || parPerd.JugadorEnPareja(parGan.nombreJugador2))
				throw new Exception("Vamos a ver, animalito,\n¿cómo es posible que " + parGan.nombreJugador1 + "\nhaya jugado en ambas parejas?");
			parejaGan = parGan;
			parejaPerd = parPerd;
			fecha = pFecha.Date;
			comentario = pComentario;
			OrdenarJugadores();
		}
		
		public bool JugadorEnPartido(string nombreJugador)
		{
			return (parejaGan.JugadorEnPareja(nombreJugador) || parejaPerd.JugadorEnPareja(nombreJugador));
		}
		
		public void OrdenarJugadores()
		{
			parejaGan.OrdenarJugadores();
			parejaPerd.OrdenarJugadores();
		}
		
		public string GetCompanneroEnPareja(string nombre)
		{
			if (parejaGan.nombreJugador1 == nombre)
				return parejaGan.nombreJugador2;
			else if (parejaGan.nombreJugador2 == nombre)
				return parejaGan.nombreJugador1;
			else if (parejaPerd.nombreJugador1 == nombre)
				return parejaPerd.nombreJugador2;
			else if (parejaPerd.nombreJugador2 == nombre)
				return parejaPerd.nombreJugador1;
			else
				return "";
		}
		
		public string GetParejaContraria(string nombre)
		{
			if (parejaGan.JugadorEnPareja(nombre))
				return parejaPerd.IdPareja();
			else if (parejaPerd.JugadorEnPareja(nombre))
				return parejaGan.IdPareja();
			else
				return "";
		}
		
		public bool ParejaEnPartido(string idPareja)
		{
			return (parejaGan.IdPareja() == idPareja || parejaPerd.IdPareja() == idPareja);
		}
	}
}
