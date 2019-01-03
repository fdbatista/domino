
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmRecords : frmGenerico
	{
		
		ListaClaseControl objListaDomino;
		ClaseControl objControl;
		
		public frmRecords(ListaClaseControl objListaDomino)
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
			imgList.Images.Clear();
			lstRes.Items.Clear();
			List<Record> res = objControl.records;
			for (int i = 0; i < res.Count; i++)
			{
				int posJug = objControl.IndiceEnLista(res[i].nombreJugador);
				if (posJug > -1)
					imgList.Images.Add(objControl.jugadores[posJug].Avatar);
				lstRes.Items.Add(res[i].nombre, i);
				lstRes.Items[i].SubItems.Add(res[i].valor.ToString());
				lstRes.Items[i].SubItems.Add(res[i].nombreJugador);
				lstRes.Items[i].SubItems.Add(res[i].partido.fecha.ToShortDateString());
				lstRes.Items[i].SubItems.Add(res[i].partido.GetCompanneroEnPareja(res[i].nombreJugador));
				lstRes.Items[i].SubItems.Add(res[i].partido.GetParejaContraria(res[i].nombreJugador));
			}
		}
		
		void LstResKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}
		
		void CmbTorneoSelectedIndexChanged(object sender, EventArgs e)
		{
			objControl = objListaDomino.ListaEnPosicion(cmbTorneo.SelectedIndex);
			ActualizarInterfaz();
		}
	}
}
