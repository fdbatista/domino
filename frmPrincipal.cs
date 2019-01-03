
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmPrincipal : frmGenerico
	{
		ListaClaseControl objControl;
		HiloEjecucion hiloSec;
		
		public frmPrincipal(ListaClaseControl objControl, bool admin)
		{
			InitializeComponent();
			this.objControl = objControl;
			nmPartidos.Value = objControl.ListaDomino[objControl.PosListaActual()].cantPartAMostrar;
			nmPartidos.Maximum = objControl.ListaDomino[objControl.PosListaActual()].partidos.Count;
			cmbTipoPartido.SelectedIndex = 0;
			ActualizarCmbJugadores();
			ActualizarLstPartidos(0);
			if (!admin)
			{
				guardarCambiosToolStripMenuItem.Enabled = false;
				cambiarContraseñaToolStripMenuItem.Enabled = false;
				administrarToolStripMenuItem1.Enabled = false;
				registrarPartidoToolStripMenuItem.Enabled = false;
				actualizarPartidoToolStripMenuItem.Enabled = false;
				cambiarContraseñaToolStripMenuItem.Enabled = false;
				administrarToolStripMenuItem.Enabled = false;
				calcularELOGeneralToolStripMenuItem.Enabled = false;
				adicionarToolStripMenuItem.Enabled = false;
				actualizarSonidosToolStripMenuItem.Enabled = false;
				notificacionesPorCorreoToolStripMenuItem.Enabled = false;
				editarListasDePartidosToolStripMenuItem.Enabled = false;
			}
		}
		
		void FrmPrincipalFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		
		void GuardarCambiosToolStripMenuItemClick(object sender, EventArgs e)
		{
			GuardarCambios();
		}
		
		void GuardarCambios()
		{
			try
			{
				MiembrosEstaticos.SerializarObjeto(objControl, "datos.dom");
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, exc.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void CambiarContraseñaToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmCambiarPass obj = new frmCambiarPass(objControl.ListaDomino[objControl.PosListaActual()]);
			obj.ShowDialog();
			GuardarCambios();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void AdicionarToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmAdicJug obj = new frmAdicJug(objControl.ListaDomino[objControl.PosListaActual()]);
			obj.ShowDialog();
			ActualizarLstPartidos(0);
			GuardarCambios();
		}
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmAcercaDe obj = new frmAcercaDe(objControl);
			obj.ShowDialog();
		}
		
		void RegistrarPartidoToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmJuegoNuevo obj = new frmJuegoNuevo(objControl.ListaDomino[objControl.PosListaActual()]);
			obj.ShowDialog();
			nmPartidos.Maximum = objControl.ListaDomino[objControl.PosListaActual()].partidos.Count;
			ActualizarLstPartidos(0);
			GuardarCambios();
		}
		
		void ActualizarCmbJugadores()
		{
			cmbJugadores.Items.Clear();
			for (int i = 0; i < objControl.ListaDomino[objControl.PosListaActual()].jugadores.Count; i++)
				if (!objControl.ListaDomino[objControl.PosListaActual()].jugadores[i].Eliminado || chkInactivos.Checked)
					cmbJugadores.Items.Add(objControl.ListaDomino[objControl.PosListaActual()].jugadores[i].nombre);
			cmbJugadores.Items.Add("<TODOS>");
			cmbJugadores.SelectedIndex = cmbJugadores.Items.Count - 1;
		}
		
		void ActualizarLstPartidos(int modo)
		{
			try
			{
				lstPartidos.Items.Clear();
				List<Partido> partidos;
				if (modo == 0)
					partidos = objControl.ListaDomino[objControl.PosListaActual()].GetUltimosPartidos(objControl.ListaDomino[objControl.PosListaActual()].cantPartAMostrar);
				else
					partidos = objControl.ListaDomino[objControl.PosListaActual()].GetUltimosPartidos(objControl.ListaDomino[objControl.PosListaActual()].cantPartAMostrar, cmbTipoPartido.SelectedIndex, cmbJugadores.SelectedItem.ToString(), chkFecha.Checked, dtDesde.Value.Date, dtHasta.Value.Date);
				int indImg;
				for (int i = 0; i < partidos.Count; i++)
				{
					indImg = 0;
					if (partidos[i].parejaGan.dioZapato)
						indImg = 1;
					else if (partidos[i].parejaGan.dioReculillo)
						indImg = 2;
					lstPartidos.Items.Add(partidos[i].parejaGan.IdPareja(), indImg);
					lstPartidos.Items[i].SubItems.Add(partidos[i].parejaPerd.IdPareja());
					lstPartidos.Items[i].SubItems.Add(partidos[i].parejaGan.puntuacion.ToString() + " - " + partidos[i].parejaPerd.puntuacion.ToString());
					lstPartidos.Items[i].SubItems.Add(partidos[i].fecha.ToShortDateString());
				}
			}
			catch (Exception)
			{
				ActualizarLstPartidos(0);
			}
			finally
			{
				int cantRes = lstPartidos.Items.Count;
				lblTotal.Text = "Resultados: " + cantRes.ToString() + " (de " + objControl.ListaDomino[objControl.PosListaActual()].partidos.Count.ToString() + " posibles)";
				lblTotal.ForeColor = (cantRes > 0) ? Color.Green : Color.Red;
			}
		}
		
		void NmPartidosValueChanged(object sender, EventArgs e)
		{
			objControl.ListaDomino[objControl.PosListaActual()].cantPartAMostrar = (int)nmPartidos.Value;
			ActualizarLstPartidos(1);
		}
		
		void ActualizarPartidoToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmActJuego obj = new frmActJuego(objControl.ListaDomino[objControl.PosListaActual()]);
			obj.ShowDialog();
			nmPartidos.Maximum = objControl.ListaDomino[objControl.PosListaActual()].partidos.Count;
			ActualizarLstPartidos(0);
			GuardarCambios();
		}
		
		void EstadIndivToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmEstadIndiv obj = new frmEstadIndiv(objControl);
			obj.ShowDialog();
		}
		
		void CompararJugadoresToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmCompJug obj = new frmCompJug(objControl);
			obj.ShowDialog();
		}
		
		void RecalcularEstadisticas()
		{
			objControl.ListaDomino[objControl.PosListaActual()].RecalcularEstadisticas(ref hiloSec.avance);
		}
		
		void LevantarHilo()
		{
			Thread nHilo = new Thread(RecalcularEstadisticas);
			hiloSec = new HiloEjecucion(nHilo);
			hiloSec.hilo.Start();
			timer1.Enabled = true;
			lstPartidos.Enabled = false;
			progressBar1.Visible = true;
		}
		
		void CalcularELOGeneralToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				if (MiembrosEstaticos.MostrarPregunta("Te recomiendo hacer una copia del\nfichero de datos antes de continuar.\n¿Todo listo?") == DialogResult.Yes)
					LevantarHilo();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, exc.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void RecordsToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmRecords obj = new frmRecords(objControl);
			obj.ShowDialog();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (hiloSec.hilo.ThreadState == ThreadState.Stopped)
			{
				timer1.Enabled = false;
				progressBar1.Visible = false;
				lstPartidos.Enabled = true;
				this.Text = "DominArte";
				ActualizarLstPartidos(0);
				objControl.ListaDomino[objControl.PosListaActual()].Parametros().cambios = false;
				GuardarCambios();
				MiembrosEstaticos.MostrarInformacion("Datos actualizados.");
			}
			else
			{
				progressBar1.Value = hiloSec.avance;
				this.Text = hiloSec.avance.ToString() + "%";
			}
		}
		
		void RércordsIndividualesToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmRecordsIndiv obj = new frmRecordsIndiv(objControl);
			obj.ShowDialog();
		}
		
		void AdministrarToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmEditarParametros obj = new frmEditarParametros(objControl.ListaDomino[objControl.PosListaActual()]);
			obj.ShowDialog();
			if (objControl.ListaDomino[objControl.PosListaActual()].Parametros().cambios)
				LevantarHilo();
			else
				GuardarCambios();
		}
		
		void ChkInactivosCheckedChanged(object sender, EventArgs e)
		{
			ActualizarCmbJugadores();
		}
		
		void CmbTipoPartidoSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbTipoPartido.SelectedIndex == 0)
				lblMostrarUltimos.Text = "Mostrar últimos                                               de";
			else
				lblMostrarUltimos.Text = "Mostrar últimas                                               de";
			ActualizarLstPartidos(1);
		}
		
		void CmbJugadoresSelectedIndexChanged(object sender, EventArgs e)
		{
			ActualizarLstPartidos(1);
		}
		
		void ChkFechaCheckedChanged(object sender, EventArgs e)
		{
			ActualizarLstPartidos(1);
		}
		
		void DtDesdeValueChanged(object sender, EventArgs e)
		{
			ActualizarLstPartidos(1);
		}
		
		void DtHastaValueChanged(object sender, EventArgs e)
		{
			ActualizarLstPartidos(1);
		}
		
		void ActualizarSonidosToolStripMenuItemClick(object sender, EventArgs e)
		{
			var obj = new frmActSonidos(objControl);
			obj.ShowDialog();
		}
		
		void PorParejasToolStripMenuItemClick(object sender, EventArgs e)
		{
			var obj = new frmEstadParejas(objControl);
			obj.ShowDialog();
		}
		
		void ListaNegraToolStripMenuItemClick(object sender, EventArgs e)
		{
			var obj = new frmListaNegra(objControl);
			obj.ShowDialog();
		}
		
		void GrupoÉliteToolStripMenuItemClick(object sender, EventArgs e)
		{
			var obj = new frmGrupoElite(objControl);
			obj.ShowDialog();
		}
		
		void ProspectosToolStripMenuItemClick(object sender, EventArgs e)
		{
			var obj = new frmProspectos(objControl);
			obj.ShowDialog();
		}
		
		void GráficoDeRendimientoToolStripMenuItemClick(object sender, EventArgs e)
		{
			var obj = new frmGraficoRendimiento(objControl);
			obj.ShowDialog();
		}
		
		void NotificacionesPorCorreoToolStripMenuItemClick(object sender, EventArgs e)
		{
			var obj = new frmParamsCorreo(objControl.ListaDomino[objControl.PosListaActual()]);
			obj.ShowDialog();
			GuardarCambios();
		}
		
		void EditarListasDePartidosToolStripMenuItemClick(object sender, EventArgs e)
		{
			var obj = new frmEditarListas(objControl);
			obj.ShowDialog();
			nmPartidos.Maximum = objControl.ListaDomino[objControl.PosListaActual()].partidos.Count;
			nmPartidos.Value = objControl.ListaDomino[objControl.PosListaActual()].cantPartAMostrar;
			ActualizarLstPartidos(0);
		}
	}
}
