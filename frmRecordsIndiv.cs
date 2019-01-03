
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmRecordsIndiv : frmGenerico
	{
		ListaClaseControl objListaDomino;
		ClaseControl objControl;
		int indAvataresRecords;
		
		public frmRecordsIndiv(ListaClaseControl objListaDomino)
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
			while (imgMini.Images.Count > 2)
				imgMini.Images.RemoveAt(2);
			lstJugadores.Items.Clear();
			lstRecords.Items.Clear();
			indAvataresRecords = objControl.jugadores.Count;
			for (int i = 0; i < indAvataresRecords; i++)
			{
				imgMini.Images.Add(objControl.jugadores[i].Avatar);
				lstJugadores.Items.Add(objControl.jugadores[i].nombre, i + 2);
			}
		}
		
		void ListView1KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				lstRecords.Items.Clear();
				List<Record> res = objControl.jugadores[lstJugadores.SelectedIndices[0]].RegistroPersonal.Records;
				for (int i = 0; i < res.Count; i++)
				{
					int restoDiv;
					Math.DivRem(i, 2, out restoDiv);
					lstRecords.Items.Add(res[i].nombre, (restoDiv == 0) ? 0 : 1);
					lstRecords.Items[i].SubItems.Add(res[i].valor.ToString());
					lstRecords.Items[i].SubItems.Add(res[i].partido.fecha.ToShortDateString());
					lstRecords.Items[i].SubItems.Add(res[i].partido.GetCompanneroEnPareja(res[i].nombreJugador));
					lstRecords.Items[i].SubItems.Add(res[i].partido.GetParejaContraria(res[i].nombreJugador));
				}
			}
			catch (Exception)
			{
			}
		}
		
		void CmbTorneoSelectedIndexChanged(object sender, EventArgs e)
		{
			objControl = objListaDomino.ListaEnPosicion(cmbTorneo.SelectedIndex);
			ActualizarInterfaz();
		}
	}
}
