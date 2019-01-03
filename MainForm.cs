
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class MainForm : frmGenerico
	{
		ListaClaseControl objListaDomino;
		
		public MainForm()
		{
			InitializeComponent();
			string msgError = string.Empty;
			try
			{
				Deserializar();
			}
			catch(FileNotFoundException)
			{
				msgError = "El fichero de datos no se encuentra.\n¿Desea generar uno nuevo?";
			}
			catch(SerializationException)
			{
				msgError = "El fichero de datos se encuentra en estado ilegible.\n¿Desea reemplazarlo por uno nuevo?";
			}
			catch(Exception exc)
			{
				msgError = "Ha ocurrido un error y los datos no pueden ser cargados.\nDescripción:\n\n" + exc.Message + "\n\n¿Desea generar un nuevo fichero de datos?";
			}
			finally
			{
				if (msgError != string.Empty)
				{
					if (MiembrosEstaticos.MostrarPregunta(msgError) == DialogResult.Yes)
					{
						objListaDomino = new ListaClaseControl();
						MiembrosEstaticos.SerializarObjeto(objListaDomino, "datos.dom");
						MiembrosEstaticos.MostrarAdvertencia("El fichero de datos ha sido regenerado.\nDebe actualizar nuevamente su contenido\ny crear una contraseña de acceso.");
					}
					else
					{
						MiembrosEstaticos.MostrarError("La aplicación no puede trabajar sin los datos necesarios.");
						Dispose();
					}
				}
			}
		}
		
		private void Deserializar()
		{
			objListaDomino = (ListaClaseControl)MiembrosEstaticos.DeserializarObjeto("datos.dom");
		}
		
		void BtnOkClick(object sender, EventArgs e)
		{
			Autenticar();
		}
		
		private void Autenticar()
		{
			if (objListaDomino.ListaDomino[objListaDomino.PosListaActual()].contrasenna != MiembrosEstaticos.Encriptar(txtPass.Text))
			{
				errProv.SetError(txtPass, "Contraseña incorrecta");
				txtPass.SelectAll();
				txtPass.Focus();
			}
			else
			{
				Hide();
				frmPrincipal obj = new frmPrincipal(objListaDomino, true);
				obj.Show();
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void TxtPassKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Autenticar();
			else if (e.KeyChar == 27)
				Close();
		}
		
		void BtnModoObservClick(object sender, EventArgs e)
		{
			Hide();
			frmPrincipal obj = new frmPrincipal(objListaDomino, false);
			obj.Show();
		}
	}
}
