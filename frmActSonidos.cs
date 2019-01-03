using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	
	public partial class frmActSonidos : frmGenerico
	{
		ListaClaseControl objControl;
		
		public frmActSonidos(ListaClaseControl objControl)
		{
			InitializeComponent();
			this.objControl = objControl;
			ActualizarTxtsSonidos();
		}
		
		void ActualizarTxtsSonidos()
		{
			List<Sonido> sonidos = objControl.sonidos;
			for (int i = 0; i < sonidos.Count; i++)
			{
				if (sonidos[i].Nombre.StartsWith("gelite_"))
					txtElite.Text = sonidos[i].Nombre + ".mp3";
				else if (sonidos[i].Nombre.StartsWith("prosp_"))
					txtProspectos.Text = sonidos[i].Nombre + ".mp3";
				else if (sonidos[i].Nombre.StartsWith("listaneg_"))
					txtListaNegra.Text = sonidos[i].Nombre + ".mp3";
				else if (sonidos[i].Nombre.StartsWith("acercade_"))
					txtAcercaDe.Text = sonidos[i].Nombre + ".mp3";
			}
		}
		
		void GuardarCambios()
		{
			try
			{
				MiembrosEstaticos.SerializarObjeto(objControl, "datos.dom");
				MiembrosEstaticos.MostrarInformacion("Audio actualizado.");
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message, exc.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void GuardarCambiosToolStripMenuItemClick(object sender, EventArgs e)
		{
			GuardarCambios();
		}
		
		void ActualizarSonido(string nombreFormulario, string prefijo)
		{
			try
			{
				dlgAbrir.FileName = "";
				dlgAbrir.Title = "Actualizar audio para " + nombreFormulario;
				if (dlgAbrir.ShowDialog() == DialogResult.OK)
				{
					string rutaFichero = dlgAbrir.FileName;
					List<Sonido> sonidos = objControl.sonidos;
					
					int posSonido = -1;
					for (int i = 0; i < sonidos.Count; i++)
					{
						if (sonidos[i].Nombre.StartsWith(prefijo))
					    {
					    	posSonido = i;
					    	break;
					    }
					}
					
					Stream pp = new FileStream(rutaFichero, FileMode.Open);
					int cant = (int)pp.Length;
					var buffer = new byte[cant];
					pp.Read(buffer, 0, cant);
					pp.Close();
					
					int inicioNombre = rutaFichero.LastIndexOf("\\") + 1, finNombre = rutaFichero.LastIndexOf(".") - inicioNombre;
					string nombre = rutaFichero.Substring(inicioNombre, finNombre);
					nombre = (nombre.StartsWith(prefijo) ? "" : prefijo) + nombre;
					
					if (posSonido == -1)
						objControl.sonidos.Add(new Sonido(nombre, buffer));
					else
						objControl.sonidos[posSonido] = new Sonido(nombre, buffer);
					
					ActualizarTxtsSonidos();
					GuardarCambios();
				}
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void ExportarSonido(string nombreFormulario, string prefijo)
		{
			try
			{
				List<Sonido> sonidos = objControl.sonidos;
				int posSonido = -1;
				for (int i = 0; i < sonidos.Count; i++)
				{
					if (sonidos[i].Nombre.StartsWith(prefijo))
				    {
				    	posSonido = i;
				    	break;
				    }
				}
				
				string nombreFichero = (sonidos[posSonido].Nombre.StartsWith(prefijo) ? "" : prefijo) + sonidos[posSonido].Nombre + ".mp3";
				dlgGuardar.FileName = nombreFichero;
				dlgGuardar.Title = "Exportar audio de " + nombreFormulario;
				
				if (dlgGuardar.ShowDialog() == DialogResult.OK)
				{
					string rutaFichero = dlgGuardar.FileName;
					Stream pp = new FileStream(rutaFichero, FileMode.Create);
					pp.Write(sonidos[posSonido].Bytes, 0, sonidos[posSonido].Bytes.Length);
					pp.Close();
					MiembrosEstaticos.MostrarInformacion("Archivo exportado.");
				}
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		} 
		
		void BtnEliteDescClick(object sender, EventArgs e)
		{
			ExportarSonido("<Grupo élite>", "gelite_");
		}
		
		void BtnProspDescClick(object sender, EventArgs e)
		{
			ExportarSonido("<Prospectos>", "prosp_");
		}
		
		void BtnListaNegraDescClick(object sender, EventArgs e)
		{
			ExportarSonido("<Lista negra>", "listaneg_");
		}
		
		void BtnAcercaDeDescClick(object sender, EventArgs e)
		{
			ExportarSonido("<Acerca de>", "acercade_");
		}
		
		void BtnEliteActClick(object sender, EventArgs e)
		{
			ActualizarSonido("<Grupo élite>", "gelite_");
		} 
		
		void BtnProspActClick(object sender, EventArgs e)
		{
			ActualizarSonido("<Prospectos>", "prosp_");
		}
		void BtnListaNegraActClick(object sender, EventArgs e)
		{
			ActualizarSonido("<Lista negra>", "listaneg_");
		}
		
		void BtnAcercaDeActClick(object sender, EventArgs e)
		{
			ActualizarSonido("<Acerca de>", "acercade_");
		}
		
	}
}
