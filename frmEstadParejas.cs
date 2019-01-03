
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmEstadParejas : frmGenerico
	{
		int ultimoValorCombo;
		ListaEstadPareja res;
		ListaClaseControl objListaDomino;
		ClaseControl objControl;
		
		public frmEstadParejas(ListaClaseControl objListaDomino)
		{
			InitializeComponent();
			this.objListaDomino = objListaDomino;
			int cantListas = objListaDomino.CantidadListas();
			for (int i = 0; i < cantListas; i++)
				cmbTorneo.Items.Add(objListaDomino.NombreLista(i));
			objControl = objListaDomino.ListaDomino[objListaDomino.PosListaActual()];
			ultimoValorCombo = -1;
			ActualizarJugadores();
			ActualizarInterfaz();
		}
		
		public void ActualizarInterfaz()
		{
			try
			{
				lst1.Items.Clear();
				lst2.Items.Clear();
				int indModo = cmbModo.SelectedIndex;
				res = new ListaEstadPareja();
				
				switch (indModo)
				{
					case 0: //Jugados
						{
							res = objControl.GetParejasJugadoras(cmbJugadores.SelectedItem.ToString());
							List<EstadPareja> parejas = res.ListaParejas;
							int cant = parejas.Count;
							for (int i = 0; i < cant; i++)
							{
								lst1.Items.Add((i + 1).ToString() + ". " + parejas[i].Pareja.IdPareja());
								lst1.Items[i].SubItems.Add(parejas[i].Pareja.puntuacion.ToString());
							}
						}
						break;
					case 1:	//Ganados
						{
							res = objControl.GetParejasGanadoras(cmbJugadores.SelectedItem.ToString());
							List<EstadPareja> parejas = res.ListaParejas;
							int cant = parejas.Count;
							for (int i = 0; i < cant; i++)
							{
								lst1.Items.Add((i + 1).ToString() + ". " + parejas[i].Pareja.IdPareja());
								lst1.Items[i].SubItems.Add(parejas[i].Pareja.puntuacion.ToString());
							}
						}
						break;
					case 2:	//Perdidos
						{
							res = objControl.GetParejasPerdedoras(cmbJugadores.SelectedItem.ToString());
							List<EstadPareja> parejas = res.ListaParejas;
							int cant = parejas.Count;
							for (int i = 0; i < cant; i++)
							{
								lst1.Items.Add((i + 1).ToString() + ". " + parejas[i].Pareja.IdPareja());
								lst1.Items[i].SubItems.Add(parejas[i].Pareja.puntuacion.ToString());
							}
						}
						break;
					case 3://Pollos a favor
						{
							res = objControl.GetParejasPorPollonasProp(cmbJugadores.SelectedItem.ToString());
							List<EstadPareja> parejas = res.ListaParejas;
							int cant = parejas.Count;
							for (int i = 0; i < cant; i++)
							{
								lst1.Items.Add((i + 1).ToString() + ". " + parejas[i].Pareja.IdPareja());
								lst1.Items[i].SubItems.Add(parejas[i].Pareja.puntuacion.ToString());
							}
						}
						break;
					case 4:	//Pollos en contra
						{
							res = objControl.GetParejasPorPollonasRecib(cmbJugadores.SelectedItem.ToString());
							List<EstadPareja> parejas = res.ListaParejas;
							int cant = parejas.Count;
							for (int i = 0; i < cant; i++)
							{
								lst1.Items.Add((i + 1).ToString() + ". " + parejas[i].Pareja.IdPareja());
								lst1.Items[i].SubItems.Add(parejas[i].Pareja.puntuacion.ToString());
							}
						}
						break;
					case 5:	//Reculillos a favor
						{
							res = objControl.GetParejasPorReculProp(cmbJugadores.SelectedItem.ToString());
							List<EstadPareja> parejas = res.ListaParejas;
							int cant = parejas.Count;
							for (int i = 0; i < cant; i++)
							{
								lst1.Items.Add((i + 1).ToString() + ". " + parejas[i].Pareja.IdPareja());
								lst1.Items[i].SubItems.Add(parejas[i].Pareja.puntuacion.ToString());
							}
						}
						break;
					case 6:	//Reculillos en contra
						{
							res = objControl.GetParejasPorReculRec(cmbJugadores.SelectedItem.ToString());
							List<EstadPareja> parejas = res.ListaParejas;
							int cant = parejas.Count;
							for (int i = 0; i < cant; i++)
							{
								lst1.Items.Add((i + 1).ToString() + ". " + parejas[i].Pareja.IdPareja());
								lst1.Items[i].SubItems.Add(parejas[i].Pareja.puntuacion.ToString());
							}
						}
						break;
					case 7:	//Diferencia G - P
						{
							string nombre = cmbJugadores.SelectedItem.ToString();
							res = objControl.GetParejasPorDiferenciaGP(nombre);
							List<EstadPareja> parejas = res.ListaParejas;
							int cant = parejas.Count, indice = 0;
							for (int i = 0; i < cant; i++)
							{
								if (nombre == "<TODOS>" || parejas[i].Pareja.JugadorEnPareja(nombre))
								{
									lst1.Items.Add((indice + 1).ToString() + ". " + parejas[i].Pareja.IdPareja());
									lst1.Items[indice].SubItems.Add(((parejas[i].Pareja.puntuacion > 0) ? "+" : "") + parejas[i].Pareja.puntuacion.ToString());
									indice++;
								}
							}
						}
						break;
					default:
						break;
				}
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarInformacion(exc.Message);
			}
		}
		
		void CmbModoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbModo.SelectedIndex != ultimoValorCombo)
			{
				ultimoValorCombo = cmbModo.SelectedIndex;
				ActualizarInterfaz();
			}
		}
		
		void Lst1SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				lst2.Items.Clear();
				List<Pareja> parejas = res.ListaParejas[lst1.SelectedIndices[0]].Parejas;
				int cant = parejas.Count;
				for (int i = 0; i < cant; i++)
				{
					lst2.Items.Add(parejas[i].IdPareja());
					lst2.Items[i].SubItems.Add(parejas[i].puntuacion.ToString());
				}
			}
			catch (ArgumentException){}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarInformacion(exc.Message);
			}
		}
		
		void FrmEstadParejasKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}
		
		void CmbJugadoresSelectedIndexChanged(object sender, EventArgs e)
		{
			ActualizarInterfaz();
		}
		
		void CmbTorneoSelectedIndexChanged(object sender, EventArgs e)
		{
			objControl = objListaDomino.ListaEnPosicion(cmbTorneo.SelectedIndex);
			ActualizarJugadores();
			ActualizarInterfaz();
		}
		
		void ActualizarJugadores()
		{
			cmbJugadores.Items.Clear();
			for (int i = 0; i < objControl.jugadores.Count; i++)
			{
				if (!objControl.jugadores[i].Eliminado)
				{
					cmbJugadores.Items.Add(objControl.jugadores[i].nombre);
				}
			}
			cmbJugadores.Items.Add("<TODOS>");
			cmbJugadores.SelectedIndex = cmbJugadores.Items.Count - 1;
		}
	}
}
