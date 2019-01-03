
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmCompJug : frmGenerico
	{
		ClaseControl objControl;
		ListaClaseControl objListaDomino;
		
		public frmCompJug()
		{
			InitializeComponent();
		}
		
		public frmCompJug(ListaClaseControl objListaDomino)
		{
			InitializeComponent();
			this.objListaDomino = objListaDomino;
			int cantListas = objListaDomino.CantidadListas();
			for (int i = 0; i < cantListas; i++)
				cmbTorneo.Items.Add(objListaDomino.NombreLista(i));
			ActTorneoYJugadoresActuales(objListaDomino.PosListaActual());
			cmbModo.SelectedIndex = 0;
		}
		
		void ActTorneoYJugadoresActuales(int posTorneo)
		{
			objControl = objListaDomino.ListaDomino[posTorneo];
			cmbJugador1.Items.Clear();
			cmbJugador2.Items.Clear();
			imgList1.Images.Clear();
			for (int i = 0; i < objControl.jugadores.Count; i++)
			{
				if (!objControl.jugadores[i].Eliminado)
				{
					cmbJugador1.Items.Add(objControl.jugadores[i].nombre);
					cmbJugador2.Items.Add(objControl.jugadores[i].nombre);
					imgList1.Images.Add(objControl.jugadores[i].Avatar);
				}
			}
		}
		
		void CmbJugador1SelectedIndexChanged(object sender, EventArgs e)
		{
			imgJugador1.Image = imgList1.Images[cmbJugador1.SelectedIndex];
			ActComparacion();
		}
		
		void CmbJugador2SelectedIndexChanged(object sender, EventArgs e)
		{
			imgJugador2.Image = imgList1.Images[cmbJugador2.SelectedIndex];
			ActComparacion();
		}
		
		void CmbModoSelectedIndexChanged(object sender, EventArgs e)
		{
			ActComparacion();
		}
		
		void ActComparacion()
		{
			try
			{
				if (cmbJugador1.SelectedIndex >= 0 && cmbJugador2.SelectedIndex >= 0)
				{
					ResultComparacion res;
					if (chkTiempo.Checked)
						res = objControl.GetComparacionIndiv(objControl.IndiceEnLista(cmbJugador1.SelectedItem.ToString()), objControl.IndiceEnLista(cmbJugador2.SelectedItem.ToString()), cmbModo.SelectedIndex, dtDesde.Value.Date, dtHasta.Value.Date);
					else
						res = objControl.GetComparacionIndiv(objControl.IndiceEnLista(cmbJugador1.SelectedItem.ToString()), objControl.IndiceEnLista(cmbJugador2.SelectedItem.ToString()), cmbModo.SelectedIndex);
					double[] rend = res.GetCoeficienteRend();
					List<EstadGeneral> ranking = objControl.GetRanking();
					for (int i = 0; i < ranking.Count; i++)
					{
						if (ranking[i].NombreJugador == res.jugadores[0].nombre)
							res.posActual[0] = i + 1;
						else if (ranking[i].NombreJugador == res.jugadores[1].nombre)
							res.posActual[1] = i + 1;
					}
					
					lstEstad.Items[0].Text = res.partidosJugados[0].ToString();
					lstEstad.Items[0].SubItems[2].Text = res.partidosJugados[1].ToString();
					lstEstad.Items[1].Text = res.partidosGanados[0].ToString();
					lstEstad.Items[1].SubItems[2].Text = res.partidosGanados[1].ToString();
					lstEstad.Items[2].Text = res.partidosPerdidos[0].ToString();
					lstEstad.Items[2].SubItems[2].Text = res.partidosPerdidos[1].ToString();
					lstEstad.Items[3].Text = res.pollosProp[0].ToString();
					lstEstad.Items[3].SubItems[2].Text = res.pollosProp[1].ToString();
					lstEstad.Items[4].Text = res.pollosRecib[0].ToString();
					lstEstad.Items[4].SubItems[2].Text = res.pollosRecib[1].ToString();
					lstEstad.Items[5].Text = res.reculProp[0].ToString();
					lstEstad.Items[5].SubItems[2].Text = res.reculProp[1].ToString();
					lstEstad.Items[6].Text = res.reculRecib[0].ToString();
					lstEstad.Items[6].SubItems[2].Text = res.reculRecib[1].ToString();
					lstEstad.Items[7].Text = res.jugadores[0].RegistroPersonal.Elo.ToString();
					lstEstad.Items[7].SubItems[2].Text = res.jugadores[1].RegistroPersonal.Elo.ToString();
					lstEstad.Items[8].Text = res.posActual[0].ToString();
					lstEstad.Items[8].SubItems[2].Text = res.posActual[1].ToString();
					lstEstad.Items[9].Text = rend[0].ToString();
					lstEstad.Items[9].SubItems[2].Text = rend[1].ToString();
				}
			}
			catch (ArgumentException){}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void VerificarTeclado(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27)
				Close();
		}
		
		void DtDesdeValueChanged(object sender, EventArgs e)
		{
			ActComparacion();
		}
		
		void DtHastaValueChanged(object sender, EventArgs e)
		{
			ActComparacion();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MiembrosEstaticos.MostrarInformacion(objControl.partidos[0].fecha.ToString() + "\n" + dtDesde.Value.Date.ToString() + "\n" + dtHasta.Value.Date.ToString());
			if (objControl.partidos[0].fecha <= dtHasta.Value.Date && objControl.partidos[0].fecha <= dtHasta.Value.Date)
				MiembrosEstaticos.MostrarInformacion("yea");
			else
				MiembrosEstaticos.MostrarInformacion("no");
		}
		
		void ChkTiempoCheckedChanged(object sender, EventArgs e)
		{
			ActComparacion();
		}
		
		void CmbTorneoSelectedIndexChanged(object sender, EventArgs e)
		{
			ActTorneoYJugadoresActuales(cmbTorneo.SelectedIndex);
		}
	}
}
