
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmProspectos : frmGenerico
	{
		ListaClaseControl objListaDomino;
		ClaseControl objControl;
		
		public frmProspectos(ListaClaseControl objListaDomino)
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
			imgList1.Images.Clear();
			lstJugadores.Items.Clear();
			for (int i = 0; i < objControl.jugadores.Count; i++)
				imgList1.Images.Add(objControl.jugadores[i].Avatar);
			
			List<EstadGeneral> res = objControl.GetGruposJugadores(1);
			for (int i = 0; i < res.Count; i++)
			{
				lstJugadores.Items.Add((i + 1).ToString() + ". " + res[i].NombreJugador, objControl.IndiceEnLista(res[i].NombreJugador));
				lstJugadores.Items[i].SubItems.Add(res[i].Valor.ToString());
			}
			try
			{
				objListaDomino.ReproducirSonido("prosp_", true);
			}
			catch (Exception) {}
		}
		
		void FrmProspectosFormClosing(object sender, FormClosingEventArgs e)
		{
			objListaDomino.DetenerReproduccion();
		}
		
		void FrmProspectosKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
				Close();
		}
		
		void CmbTorneoSelectedIndexChanged(object sender, EventArgs e)
		{
			objControl = objListaDomino.ListaEnPosicion(cmbTorneo.SelectedIndex);
			ActualizarInterfaz();
		}
	}
}
