
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmActJug : frmGenerico
	{
		ClaseControl objControl;
		Image nuevoAvatar;
		int posJugador;
		
		public frmActJug()
		{
			InitializeComponent();
		}
		
		public frmActJug(ClaseControl objControl, int posJugador)
		{
			InitializeComponent();
			this.objControl = objControl;
			this.posJugador = posJugador;
			nuevoAvatar = objControl.jugadores[posJugador].Avatar;
			imgAvatar.Image = nuevoAvatar;
			chkInactivo.Checked = objControl.jugadores[posJugador].Eliminado;
			txtCorreo.Text = objControl.jugadores[posJugador].correo;
			cmbSexo.SelectedItem = objControl.jugadores[posJugador].sexo;
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnAvatarClick(object sender, EventArgs e)
		{
			AbrirDlgAvatar();
		}
		
		void AbrirDlgAvatar()
		{
			try
			{
				if (dlgAbrir.ShowDialog() == DialogResult.OK)
				{
					nuevoAvatar = Image.FromStream(dlgAbrir.OpenFile());
					imgAvatar.Image = nuevoAvatar;
				}
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void BtnOkClick(object sender, EventArgs e)
		{
			try
			{
				objControl.jugadores[posJugador].SetAvatar(nuevoAvatar);
				objControl.jugadores[posJugador].Eliminado = chkInactivo.Checked;
				objControl.jugadores[posJugador].correo = txtCorreo.Text;
				objControl.jugadores[posJugador].sexo = cmbSexo.SelectedItem.ToString();
				MiembrosEstaticos.MostrarInformacion("Jugador actualizado.");
				Close();
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
		
		void BtnAvatarKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Close();
		}
	}
}
