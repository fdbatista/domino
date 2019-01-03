
using System;

namespace ControlDomino.Clases
{
	[Serializable]
	public class Pareja
	{
		public decimal puntuacion;
		public bool ganadora, dioZapato, dioReculillo;
		public string nombreJugador1, nombreJugador2;
		
		public Pareja()
		{
			puntuacion = -1;
			ganadora = false;
			dioZapato = false;
			nombreJugador1 = "";
			nombreJugador2 = "";
		}
		
		public Pareja(Jugador pJug1, Jugador pJug2, decimal pPuntos, bool pGanadora, bool pZapato, bool pReculillo)
		{
			if (pJug1.Iguales(pJug2))
				throw new Exception("Ohh... vamos a ver, animalito,\n¿cómo es posible que " + pJug1.nombre + "\nhaya jugado consigo mismo de compañero?");
			else if (pZapato && pReculillo)
				throw new Exception("No se puede dar pollo y reculillo al mismo tiempo, so gilipollas...");
			else if (!pGanadora && pPuntos == 20)
				throw new Exception("¿Cómo van a perder si llegaron a 20 puntos?\nTienes el coeficiente intelectual de un ladrillo...");
			else if ((pZapato || pReculillo) && !pGanadora)
				throw new Exception("No me jodas...\n¿Dieron pollona/reculillo y perdieron?\nVerdad que hay gente bruta en este mundo...");
			
			if (pJug2.nombre.CompareTo(pJug1.nombre) == -1)
			{
				nombreJugador1 = pJug2.nombre;
				nombreJugador2 = pJug1.nombre;
			}
			else
			{
				nombreJugador1 = pJug1.nombre;
				nombreJugador2 = pJug2.nombre;
			}
			this.puntuacion = pPuntos;
			this.ganadora = pGanadora;
			this.dioZapato = pZapato;
			this.dioReculillo = pReculillo;
		}
		
		public Pareja(Jugador pJug1, Jugador pJug2)
		{
			if (pJug2.nombre.CompareTo(pJug1.nombre) == -1)
			{
				nombreJugador1 = pJug2.nombre;
				nombreJugador2 = pJug1.nombre;
			}
			else
			{
				nombreJugador1 = pJug1.nombre;
				nombreJugador2 = pJug2.nombre;
			}
			this.puntuacion = 0;
			this.ganadora = false;
			this.dioZapato = false;
			this.dioReculillo = false;
		}
		
		public Pareja(string pJug1, string pJug2)
		{
			if (pJug2.CompareTo(pJug1) == -1)
			{
				nombreJugador1 = pJug2;
				nombreJugador2 = pJug1;
			}
			else
			{
				nombreJugador1 = pJug1;
				nombreJugador2 = pJug2;
			}
			this.puntuacion = 0;
			this.ganadora = false;
			this.dioZapato = false;
			this.dioReculillo = false;
		}
		
		public string IdPareja()
		{
			return nombreJugador1 + ((nombreJugador2 != "") ? " y " : "") + nombreJugador2;
		}
		
		public bool JugadorEnPareja(string nombre)
		{
			return (nombreJugador1 == nombre || nombreJugador2 == nombre);
		}
		
		public void OrdenarJugadores()
		{
			if (nombreJugador1.CompareTo(nombreJugador2) == 1)
			{
				string nombJugAux = nombreJugador1;
				nombreJugador1 = nombreJugador2;
				nombreJugador2 = nombJugAux;
			}
		}
	}
}
