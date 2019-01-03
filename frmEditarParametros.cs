
using System;
using System.Drawing;
using System.Windows.Forms;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmEditarParametros : frmGenerico
	{
		ClaseControl objControl;
		
		public frmEditarParametros()
		{
			InitializeComponent();
		}
		
		public frmEditarParametros(ClaseControl objControl)
		{
			InitializeComponent();
			this.objControl = objControl;
			Parametros tmp = objControl.Parametros();
			nmPartido.Value = (decimal)tmp.ValorPartido;
			nmPollona.Value = (decimal)tmp.ValorPollo;
			nmRecul.Value = (decimal)tmp.ValorReculillo;
			nmElo.Value = (decimal)tmp.EloInicial;
			nmInicioRec.Value = tmp.InicioReculillo;
			nmVictoria.Value = tmp.PuntosParaGanar;
		}
		
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnOkClick(object sender, EventArgs e)
		{
			try
			{
				ActualizarParametros();
				Close();
			}
			catch (Exception exc)
			{
				MiembrosEstaticos.MostrarError(exc.Message);
			}
		}
		
		void ActualizarParametros()
		{
			objControl.ActualizarParametros((double)nmPartido.Value, (double)nmPollona.Value, (double)nmRecul.Value, (double)nmElo.Value, (int)nmInicioRec.Value, (int)nmVictoria.Value);
		}
		
		void NmPartidoKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
				Close();
			else if (e.KeyData == Keys.Enter)
				ActualizarParametros();
		}
	}
}
