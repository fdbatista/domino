
using System;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmAcercaDe : frmGenerico
	{
		ListaClaseControl objControl;
		public frmAcercaDe(ListaClaseControl objControl)
		{
			InitializeComponent();
			this.objControl = objControl;
			try
			{
				objControl.ReproducirSonido("acercade_", true);
			}
			catch (Exception) {}
		}
		
		void FrmAcercaDeClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void FrmAcercaDeKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27)
				Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void FrmAcercaDeFormClosing(object sender, FormClosingEventArgs e)
		{
			objControl.DetenerReproduccion();
		}
		
		void FrmAcercaDeKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
				Close();
		}
	}
}
