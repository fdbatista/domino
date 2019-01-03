
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmListaNegra : frmGenerico
	{
		ListaClaseControl objListaDomino;
		ClaseControl objControl;
		
		public frmListaNegra(ListaClaseControl objListaDomino)
		{
			InitializeComponent();
			this.objListaDomino = objListaDomino;
			int cantListas = objListaDomino.CantidadListas();
			for (int i = 0; i < cantListas; i++)
				cmbTorneo.Items.Add(objListaDomino.NombreLista(i));
			objControl = objListaDomino.ListaDomino[objListaDomino.PosListaActual()];
			ActualizarInterfaz();
		}
		
		void ActualizarInterfaz()
		{
			imgMini.Images.Clear();
			lstJugadores.Items.Clear();
			for (int i = 0; i < objControl.jugadores.Count; i++)
				imgMini.Images.Add(objControl.jugadores[i].Avatar);
			
			List<EstadGeneral> res = objControl.GetGruposJugadores(2);
			for (int i = 0; i < res.Count; i++)
			{
				lstJugadores.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
				lstJugadores.Items[i].SubItems.Add(res[i].Valor.ToString());
			}
			try
			{
				objListaDomino.ReproducirSonido("listaneg_", true);
			}
			catch (Exception) {}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			imgOff.Visible = !imgOff.Visible;
		}
		
		void FrmListaNegraKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
				Close();
		}
		
		void FrmListaNegraFormClosing(object sender, FormClosingEventArgs e)
		{
			objListaDomino.DetenerReproduccion();
		}
		
		void CmbTorneoSelectedIndexChanged(object sender, EventArgs e)
		{
			objControl = objListaDomino.ListaEnPosicion(cmbTorneo.SelectedIndex);
			ActualizarInterfaz();
		}
	}
}
