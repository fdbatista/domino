
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmEstadIndiv : frmGenerico
	{
		ListaClaseControl objListaDomino;
		ClaseControl objControl;
		List<EstadGeneral> res;
		int ultimoValorCombo;
		
		public frmEstadIndiv(ListaClaseControl objListaDomino)
		{
			InitializeComponent();
			this.objListaDomino = objListaDomino;
			int cantListas = objListaDomino.CantidadListas();
			for (int i = 0; i < cantListas; i++)
				cmbTorneo.Items.Add(objListaDomino.NombreLista(i));
			objControl = objListaDomino.ListaDomino[objListaDomino.PosListaActual()];
			res = new List<EstadGeneral>();
			for (int i = 0; i < objControl.jugadores.Count; i++)
				imgList1.Images.Add(objControl.jugadores[i].Avatar);
			cmbTorneo.SelectedIndex = cmbTorneo.Items.Count - 1;
			ultimoValorCombo = -1;
			cmbModo.Focus();
		}
		
		void ActualizarAvatares()
		{
			imgList1.Images.Clear();
			for (int i = 0; i < objControl.jugadores.Count; i++)
				imgList1.Images.Add(objControl.jugadores[i].Avatar);
		}
		
		void ActualizarInterfaz()
		{
			lst1.Items.Clear();
			lst2.Items.Clear();
			lst3.Items.Clear();
			lst1.Columns[1].Text = "Total";
			lst2.Columns[1].Text = "Total";
			int indModo = cmbModo.SelectedIndex;
			ActualizarAvatares();
			switch (indModo)
			{
				case 0: //Jugados
					{
						res = objControl.GetPartidosJugados();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString() + " (" + Math.Round((res[i].Valor * 100 / objControl.partidos.Count)).ToString() + "%)");
						}
					}
					break;
				case 1:	//Ganados
					{
						res = objControl.GetGanadores();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString());
						}
					}
					break;
				case 2:	//Perdidos
					{
						res = objControl.GetPerdedores();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString());
						}
					}
					break;
				case 3://Pollos a favor
					{
						res = objControl.GetZapaterosProp();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString());
						}
					}
					break;
				case 4:	//Pollos en contra
					{
						res = objControl.GetZapaterosRecib();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString());
						}
					}
					break;
				case 5:	//Reculillos a favor
					{
						res = objControl.GetReculProp();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString());
						}
					}
					break;
				case 6:	//Reculillos en contra
					{
						res = objControl.GetReculRecib();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString());
						}
					}
					break;
				case 7:	//Diferencia G - P
					{
						res = objControl.GetDiferenciaGP();
						int indJugador;
						for (int i = 0; i < res.Count; i++)
						{
							indJugador = objControl.IndiceEnLista(res[i].NombreJugador);
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(((res[i].Valor > 0) ? "+" : "") + res[i].Valor.ToString() + " (" + objControl.jugadores[indJugador].RegistroPersonal.cantGanados.ToString() + " - " + objControl.jugadores[indJugador].RegistroPersonal.cantPerdidos.ToString() + ")");
						}
					}
					break;
				case 8:	//Mejores rachas
					{
						lst1.Columns[1].Text = "Racha";
						res = objControl.GetMejoresRachasJugadores();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString());
						}
					}
					break;
				case 9:	//Peores rachas
					{
						lst1.Columns[1].Text = "Racha";
						res = objControl.GetPeoresRachasJugadores();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add("-" + res[i].Valor.ToString());
						}
					}
					break;
				case 10:	//Duelos
					{
						lst1.Columns[1].Text = "ELO";
						res = objControl.GetDuelosIndiv();
						string nombre;
						for (int i = 0; i < res.Count; i++)
						{
							nombre = res[i].NombreJugador.Substring(0, res[i].NombreJugador.IndexOf(" a "));
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(nombre));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString());
						}
					}
					break;
				case 11:	//Ranking
					{
						lst1.Columns[1].Text = "ELO";
						res = objControl.GetRanking();
						for (int i = 0; i < res.Count; i++)
						{
							lst1.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
							lst1.Items[i].SubItems.Add(res[i].Valor.ToString());
						}
					}
					break;
				default:
					break;
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
				lst3.Items.Clear();
				EstadGeneral actual = res[lst1.SelectedIndices[0]];
				List<RegistroPartido> contrarios = actual.Contrarios, parejas = actual.Parejas;
				double total = (actual.Valor == 0) ? 1 : actual.Valor;
				for (int i = 0; i < contrarios.Count; i++)
				{
					lst2.Items.Add(contrarios[i].nombreJugador, objControl.IndiceEnLista(contrarios[i].nombreJugador));
					lst2.Items[i].SubItems.Add(contrarios[i].cantPartidos.ToString() + " (" + (Math.Round(contrarios[i].cantPartidos * 100 / total, 2)).ToString() + "%)");
				}
				for (int i = 0; i < parejas.Count; i++)
				{
					lst3.Items.Add(parejas[i].nombreJugador, objControl.IndiceEnLista(parejas[i].nombreJugador));
					lst3.Items[i].SubItems.Add(parejas[i].cantPartidos.ToString() + " (" + (Math.Round(parejas[i].cantPartidos * 100 / total, 2)).ToString() + "%)");
				}
			}
			catch (ArgumentException){}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void Lst1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27)
				Close();
		}
		
		void CmbTorneoSelectedIndexChanged(object sender, EventArgs e)
		{
			objControl = objListaDomino.ListaEnPosicion(cmbTorneo.SelectedIndex);
			ActualizarInterfaz();
		}
	}
}
