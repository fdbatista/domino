
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmJuegoNuevo : frmGenerico
	{
		ClaseControl objControl;
		Pareja parejaGanadora, parejaPerdedora;
		bool parejaGanOK, parejaPerOK;
		HiloEjecucion hiloSec;
		string mensajeCorreo, resEnvioCorreo;
		Partido partidoTmp;
		
		public frmJuegoNuevo()
		{
			InitializeComponent();
		}
		
		public frmJuegoNuevo(ClaseControl objControl)
		{
			InitializeComponent();
			this.objControl = objControl;
			this.parejaGanadora = new Pareja();
			this.parejaPerdedora = new Pareja();
			for (int i = 0; i < objControl.jugadores.Count; i++)
			{
				if (!objControl.jugadores[i].Eliminado)
				{
					cmbJugador1.Items.Add(objControl.jugadores[i].nombre);
					cmbJugador2.Items.Add(objControl.jugadores[i].nombre);
				}
				imgList.Images.Add(objControl.jugadores[i].Avatar);
			}
			parejaGanOK = false;
			parejaPerOK = false;
			int maxPunt = objControl.Parametros().PuntosParaGanar;
			for (int i = 0; i <= maxPunt; i++)
				cmbPunt.Items.Add(i);
			cmbPunt.SelectedIndex = maxPunt;
		}
		
		void RegistrarPareja()
		{
			try
			{
				if (chkGanadora.Checked)
				{
					parejaGanadora = new Pareja(objControl.jugadores[objControl.IndiceEnLista(cmbJugador1.SelectedItem.ToString())], objControl.jugadores[objControl.IndiceEnLista(cmbJugador2.SelectedItem.ToString())], cmbPunt.SelectedIndex, true, chkPollo.Checked, chkRecul.Checked);
					lstGanadores.Items.Clear();
					lstGanadores.Items.Add(parejaGanadora.nombreJugador1, objControl.IndiceEnLista(parejaGanadora.nombreJugador1));
					lstGanadores.Items.Add(parejaGanadora.nombreJugador2, objControl.IndiceEnLista(parejaGanadora.nombreJugador2));
					parejaGanOK = true;
				}
				else
				{
					parejaPerdedora = new Pareja(objControl.jugadores[objControl.IndiceEnLista(cmbJugador1.SelectedItem.ToString())], objControl.jugadores[objControl.IndiceEnLista(cmbJugador2.SelectedItem.ToString())], cmbPunt.SelectedIndex, false, chkPollo.Checked, chkRecul.Checked);
					lstPerdedores.Items.Clear();
					lstPerdedores.Items.Add(parejaPerdedora.nombreJugador1, objControl.IndiceEnLista(parejaPerdedora.nombreJugador1));
					lstPerdedores.Items.Add(parejaPerdedora.nombreJugador2, objControl.IndiceEnLista(parejaPerdedora.nombreJugador2));
					parejaPerOK = true;
				}
				cmbPunt.SelectedIndex = 0;
				chkGanadora.Checked = !chkGanadora.Checked;
				cmbJugador1.SelectedIndex = -1;
				cmbJugador2.SelectedIndex = -1;
				cmbJugador1.Focus();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, exc.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnParGanClick(object sender, EventArgs e)
		{
			RegistrarPareja();
		}
		
		void CmbJugador1SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbJugador2.Focus();
		}
		
		void CmbJugador2SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbPunt.Focus();
			cmbPunt.SelectAll();
		}
		
		void RestablecerControles()
		{
			cmbPunt.SelectedIndex = objControl.Parametros().PuntosParaGanar;
			cmbPunt.Enabled = false;
			chkGanadora.Checked = true;
			lstGanadores.Items.Clear();
			lstPerdedores.Items.Clear();
			parejaGanadora = null;
			parejaPerdedora = null;
			cmbJugador1.ResetText();
			cmbJugador2.ResetText();
			cmbJugador1.Focus();
			parejaGanOK = false;
			parejaPerOK = false;
		}
		
		void RegistrarPartido()
		{
			try
			{
				if (parejaGanOK && parejaPerOK)
				{
					partidoTmp = new Partido(parejaGanadora, parejaPerdedora, dtFecha.Value, txtComent.Text.Trim(), objControl.Parametros());
					mensajeCorreo = objControl.RegistrarPartido(partidoTmp);
					RestablecerControles();
					MiembrosEstaticos.MostrarInformacion(mensajeCorreo);
					if (objControl.correoHabilitado && mensajeCorreo.Length > 20)
					{
						string polloRecul = (partidoTmp.parejaGan.dioReculillo) ? " (RECULILLO)" : (partidoTmp.parejaGan.dioZapato) ? " (POLLONA)" : "";
						mensajeCorreo = "Fecha: " + partidoTmp.fecha.ToShortDateString() + "</br></br>Ganadores: " + partidoTmp.parejaGan.IdPareja()
							+ "</br>Perdedores: " + partidoTmp.parejaPerd.IdPareja() + "</br>Puntuación: " + partidoTmp.parejaGan.puntuacion.ToString()
							+ " a " + partidoTmp.parejaPerd.puntuacion.ToString() + polloRecul + "</br>" + mensajeCorreo.Replace("\n", "</br>");
						LevantarHilo();
					}
				}
				else
					MiembrosEstaticos.MostrarInformacion("Escoge bien las parejas, socotroco...");
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, exc.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbJugador1.SelectAll();
				cmbJugador1.Focus();
			}
		}
		
		void BtnPartClick(object sender, EventArgs e)
		{	
			RegistrarPartido();
		}
		
		void ChkGanadoraCheckedChanged(object sender, EventArgs e)
		{
			if (chkGanadora.Checked)
			{
				chkPollo.Enabled = true;
				chkRecul.Enabled = true;
				cmbPunt.Enabled = false;
				cmbPunt.SelectedIndex = objControl.Parametros().PuntosParaGanar;
			}
			else
			{
				cmbPunt.Enabled = !chkPollo.Checked;
				chkPollo.Checked = false;
				chkRecul.Checked = false;
				chkPollo.Enabled = false;
				chkRecul.Enabled = false;
				cmbPunt.SelectedIndex = 0;
			}
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			RestablecerControles();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void ChkPolloCheckedChanged(object sender, EventArgs e)
		{
			if (chkPollo.Checked)
				chkRecul.Checked = false;
		}
		
		void ChkReculCheckedChanged(object sender, EventArgs e)
		{
			if (chkRecul.Checked)
				chkPollo.Checked = false;
		}
		
		void CmbJugador1KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}
		
		void Label1Enter(object sender, EventArgs e)
		{
			cmbJugador1.Focus();
		}
		
		void CmbPuntKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				RegistrarPareja();
		}
		
		void LevantarHilo()
		{
			Thread nHilo = new Thread(EnviarCorreo);
			hiloSec = new HiloEjecucion(nHilo);
			hiloSec.avance = 1;
			hiloSec.hilo.Start();
			timer1.Enabled = true;
			grpGeneral.Enabled = false;
			progressBar1.Visible = true;
		}
		
		void EnviarCorreo()
		{
			resEnvioCorreo = objControl.EnviarCorreo(mensajeCorreo, partidoTmp);
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (hiloSec.hilo.ThreadState == ThreadState.Stopped)
			{
				timer1.Enabled = false;
				progressBar1.Visible = false;
				grpGeneral.Enabled = true;
				MiembrosEstaticos.MostrarInformacion(resEnvioCorreo);
			}
			else
				progressBar1.Value = hiloSec.avance;
		}
	}
}
