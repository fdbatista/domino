
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmAdicJug : frmGenerico
	{
		ClaseControl objControl;
		Jugador nuevoJugador;
		
		public frmAdicJug()
		{
			InitializeComponent();
		}
		
		public frmAdicJug(ClaseControl objControl)
		{
			InitializeComponent();
			this.objControl = objControl;
			this.nuevoJugador = new Jugador();
			ActualizarJugadores();
		}
		
		void ActualizarJugadores()
		{
			listView1.Items.Clear();
			imageList2.Images.Clear();
			for (int i = 0; i < objControl.jugadores.Count; i++)
			{
				imageList2.Images.Add(objControl.jugadores[i].Avatar);
				listView1.Items.Add((i + 1).ToString() + ". " + objControl.jugadores[i].nombre, imageList2.Images.Count - 1);
			}
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void CmbSexoSelectedIndexChanged(object sender, EventArgs e)
		{
			nuevoJugador.SetAvatar(imageList1.Images[cmbSexo.SelectedIndex]);
			imgAvatar.Image = nuevoJugador.Avatar;
			btnAvatar.Focus();
			imgAvatar.Show();
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
					nuevoJugador.SetAvatar(Image.FromStream(dlgAbrir.OpenFile()));
					imgAvatar.Image = nuevoJugador.Avatar;
					imgAvatar.Show();
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
				objControl.AdicionarJugador(new Jugador(txtNombre.Text, cmbSexo.SelectedItem.ToString(), nuevoJugador.Avatar, 0, txtCorreo.Text));
				ActualizarJugadores();
				MiembrosEstaticos.MostrarInformacion("Jugador registrado.");
				txtNombre.Clear();
				txtNombre.Focus();
				imgAvatar.Hide();
			}
			catch (NullReferenceException)
			{
				MiembrosEstaticos.MostrarError("Seleccione los valores correctamente.");
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
				txtNombre.SelectAll();
				txtNombre.Focus();
			}
		}
		
		void ActualizarToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmActJug obj = new frmActJug(objControl, listView1.SelectedIndices[0]);
			obj.ShowDialog();
			ActualizarJugadores();
		}
		
		void CambiarnombreToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				string nuevoNombre = listView1.SelectedItems[0].Text.Substring(listView1.SelectedItems[0].Text.IndexOf(" ") + 1);
				if (MiembrosEstaticos.InputBox("Nuevo nombre:", "Nuevo nombre:", ref nuevoNombre) == DialogResult.OK)
				{
					objControl.CambiarNombre(listView1.SelectedIndices[0], nuevoNombre);
					objControl.OrdenarJugadores();
					ActualizarJugadores();
					MiembrosEstaticos.MostrarInformacion("Nombre actualizado.");
				}
			}
			catch (ArgumentException) {}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void TxtNombreKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
				Close();
		}
	}
}
