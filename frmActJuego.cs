
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmActJuego : frmGenerico
	{
		ClaseControl objControl;
		
		public frmActJuego()
		{
			InitializeComponent();
		}
		
		public frmActJuego(ClaseControl objControl)
		{
			InitializeComponent();
			this.objControl = objControl;
			nmPartidos.Maximum = objControl.partidos.Count;
			nmPartidos.Value = objControl.cantPartAMostrar;
			ActualizarLstPartidos();
		}
		
		void ActualizarLstPartidos()
		{
			lstPartidos.Items.Clear();
			List<Partido> partidos = objControl.GetUltimosPartidos((int)nmPartidos.Value);
			int indImg;
			
			for (int i = 0; i < partidos.Count; i++)
			{
				indImg = 0;
				if (partidos[i].parejaGan.dioZapato)
					indImg = 1;
				else if (partidos[i].parejaGan.dioReculillo)
					indImg = 2;
				lstPartidos.Items.Add(partidos[i].fecha.ToShortDateString(), indImg);
				lstPartidos.Items[i].SubItems.Add(partidos[i].parejaGan.IdPareja() + " - " + partidos[i].parejaPerd.IdPareja());
				lstPartidos.Items[i].SubItems.Add(partidos[i].parejaGan.puntuacion.ToString() + " - " + partidos[i].parejaPerd.puntuacion.ToString());
			}
		}
		
		void NmPartidosValueChanged(object sender, EventArgs e)
		{
			ActualizarLstPartidos();
		}
		
		void EliminarCódigoToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				if (MiembrosEstaticos.MostrarPregunta("¿Confirma que deseas eliminar el partido seleccionado?") == DialogResult.Yes)
				{
					if (MiembrosEstaticos.MostrarPregunta("Vamos a ver, gilipollas:\nestás a punto de eliminar un partido\noficial y alterar las estadísticas.\n¿Seguro que estás seguro?") == DialogResult.Yes)
					{
						objControl.EliminarPartido(lstPartidos.SelectedIndices[0]);
						nmPartidos.Maximum = objControl.partidos.Count;
						ActualizarLstPartidos();
					}
				}
			}
			catch (NullReferenceException)
			{
				MiembrosEstaticos.MostrarError("Seleccione los valores correctamente.");
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void NmPartidosKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
				Close();
		}
	}
}
