using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmEditarListas : frmGenerico
	{
		ListaClaseControl objControl;
		
		public frmEditarListas(ListaClaseControl objControl)
		{
			InitializeComponent();
			this.objControl = objControl;
			ActualizarLstTorneos();
		}
		
		void ActualizarLstTorneos()
		{
			lstTorneos.Items.Clear();
			List<ClaseControl> torneos = objControl.ListaDomino;
			for (int i = 0; i < torneos.Count; i++)
				lstTorneos.Items.Add(torneos[i].nombreLista, 0);
		}
		
		void AdicionarTorneo()
		{
			try
			{
				if (MiembrosEstaticos.MostrarPregunta("Ten en cuenta que no podrás registrar\npartidos en el torneo anterior.\n¿Seguro que deseas continuar?") == DialogResult.Yes)
				{
					bool copiarUsuarios = true;
					if (MiembrosEstaticos.MostrarPregunta("¿Quieres mantener última la lista de jugadores?") != DialogResult.Yes)
						copiarUsuarios = false;
					objControl.AdicionarLista(txtNombre.Text, copiarUsuarios);
					txtNombre.Clear();
					MiembrosEstaticos.MostrarInformacion("Torneo registrado.");
					MiembrosEstaticos.SerializarObjeto(objControl, "datos.dom");
					txtNombre.Focus();
					ActualizarLstTorneos();
				}
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void BtnOkClick(object sender, EventArgs e)
		{
			AdicionarTorneo();
		}
		
		void EliminarTorneoToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				if (MiembrosEstaticos.MostrarPregunta("Ten en cuenta que esta acción es irreversible.\n¿Seguro que deseas continuar?") == DialogResult.Yes)
				{
					objControl.EliminarLista(lstTorneos.SelectedIndices[0]);
					ActualizarLstTorneos();
					MiembrosEstaticos.SerializarObjeto(objControl, "datos.dom");
				}
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void TxtNombreKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				AdicionarTorneo();
			else if (e.KeyData == Keys.Escape)
				Close();
		}
		
		void CambiarNombreToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				string nuevoNombre = lstTorneos.SelectedItems[0].Text;
				if (MiembrosEstaticos.InputBox("Nuevo nombre:", "Nuevo nombre:", ref nuevoNombre) == DialogResult.OK)
				{
					objControl.CambiarNombreLista(lstTorneos.SelectedIndices[0], nuevoNombre);
					ActualizarLstTorneos();
					MiembrosEstaticos.MostrarInformacion("Nombre actualizado.");
				}
			}
			catch (ArgumentException) {}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void LstTorneosKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
				Close();
		}
	}
}
