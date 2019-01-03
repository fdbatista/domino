
using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmParamsCorreo : frmGenerico
	{
		ClaseControl objControl;
		
		public frmParamsCorreo(ClaseControl objControl)
		{
			InitializeComponent();
			this.objControl = objControl;
			Array arrPrior = Enum.GetValues(typeof(MailPriority));
			foreach(MailPriority prior in arrPrior)
				cmbPrioridad.Items.Add(prior.ToString());
			ActualizarInterfaz();
		}
		
		void ActualizarInterfaz()
		{
			txtServidor.Text = objControl.correoServidor;
			txtAsunto.Text = objControl.correoAsunto;
			txtContrasenna.Text = objControl.correoContrasenna;
			chkAutenticar.Checked = objControl.correoCredencPredet;
			txtUsuario.Text = objControl.correoCuenta;
			chkHabilitar.Checked = objControl.correoHabilitado;
			chkHTML.Checked = objControl.correoHTML;
			cmbPrioridad.SelectedItem = objControl.correoPrioridad.ToString();
			txtPuerto.Text = objControl.correoPuerto.ToString();
			txtRemit1.Text = objControl.correoRemitente.Substring(0, objControl.correoRemitente.IndexOf('@'));
			chkSSL.Checked = objControl.correoSSL;
		}
		
		void ChkHabilitarCheckedChanged(object sender, EventArgs e)
		{
			grpGeneral.Enabled = chkHabilitar.Checked;
			txtServidor.Focus();
		}
		
		void ChkSSLCheckedChanged(object sender, EventArgs e)
		{
			txtPuerto.Text = (chkSSL.Checked) ? (465).ToString() : (25).ToString();
		}
		
		void TxtRemitenteKeyPress(object sender, KeyPressEventArgs e)
		{
			string caracter = e.KeyChar.ToString();
			if (caracter == "@" || caracter == " ")
				e.Handled = true;
		}
		
		void TxtServidorTextChanged(object sender, EventArgs e)
		{
			txtRemit2.Text = "@" + txtServidor.Text;
		}
		
		void ChkAutenticarCheckedChanged(object sender, EventArgs e)
		{
			grpAutentic.Enabled = chkAutenticar.Checked;
			txtUsuario.Focus();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ChkHabilitarKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
				Close();
		}
		
		void BtnOkClick(object sender, EventArgs e)
		{
			try
			{
				objControl.correoAsunto = txtAsunto.Text;
				objControl.correoContrasenna = txtContrasenna.Text;
				objControl.correoCredencPredet = chkAutenticar.Checked;
				objControl.correoCuenta = txtUsuario.Text;
				objControl.correoHabilitado = chkHabilitar.Checked;
				objControl.correoHTML = chkHTML.Checked;
				objControl.correoPrioridad = (MailPriority)cmbPrioridad.SelectedIndex;
				objControl.correoPuerto = int.Parse(txtPuerto.Text);
				objControl.correoRemitente = txtRemit1.Text + txtRemit2.Text;
				objControl.correoServidor = txtServidor.Text;
				objControl.correoSSL = chkSSL.Checked;
				MiembrosEstaticos.MostrarInformacion("Configuración actualizada.");
				Close();
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarInformacion(exc.Message);
			}
		}
	}
}
