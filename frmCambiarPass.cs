
using System;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmCambiarPass : Form
	{
		ClaseControl objControl;
		
		public frmCambiarPass()
		{
			InitializeComponent();
		}
		
		public frmCambiarPass(ClaseControl objControl)
		{
			InitializeComponent();
			this.objControl = objControl;
		}
		
		void CambiarContrasenna()
		{
			if (txtPassNuevo.Text != "" || MiembrosEstaticos.MostrarPregunta("Una contraseña vacía entraña riesgos de seguridad.\n¿Aun así desea utilizarla?") == DialogResult.Yes)
			{
				if (MiembrosEstaticos.Encriptar(txtPassAct.Text) == objControl.contrasenna)
				{
					if (txtPassNuevo.Text == txtPassConf.Text)
					{
						string nuevoPass = MiembrosEstaticos.Encriptar(txtPassNuevo.Text);
						if (MiembrosEstaticos.MostrarPregunta("¿Confirma que desea modificar la contraseña?") == DialogResult.Yes)
						{
							objControl.contrasenna = nuevoPass;
							MiembrosEstaticos.MostrarInformacion("Contraseña actualizada.");
							Close();
						}
					}
					else
					{
						MiembrosEstaticos.MostrarError("La nueva contraseña no coincide");
						txtPassNuevo.SelectAll();
						txtPassNuevo.Focus();
					}
				}
				else
				{
					MiembrosEstaticos.MostrarError("Contraseña actual incorrecta");
					txtPassAct.SelectAll();
					txtPassAct.Focus();
				}
			}
		}
		
		void BtnOkClick(object sender, EventArgs e)
		{
			CambiarContrasenna();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnRestabClick(object sender, EventArgs e)
		{
			txtPassConf.Clear();
			txtPassNuevo.Clear();
			txtPassAct.Clear();
			txtPassAct.Focus();
		}
		
		void TxtPassActKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				CambiarContrasenna();
			else if (e.KeyChar == 27)
				Close();
		}
	}
}
