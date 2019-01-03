
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ControlDomino.Clases;

namespace ControlDomino
{
	public partial class frmGraficoRendimiento : frmGenerico
	{
		string nombreJugador;
		List<Color> colores;
		int ultimoColor;
		SeriesChartType tipoSerie;
		ListaClaseControl objListaDomino;
		ClaseControl objControl;
		
		public frmGraficoRendimiento(ListaClaseControl objListaDomino)
		{
			InitializeComponent();
			this.objListaDomino = objListaDomino;
			int cantListas = objListaDomino.CantidadListas();
			for (int i = 0; i < cantListas; i++)
				cmbTorneo.Items.Add(objListaDomino.NombreLista(i));
			objControl = objListaDomino.ListaDomino[objListaDomino.PosListaActual()];
			this.colores = objControl.GetListaColores();
			ultimoColor = -1;
			nombreJugador = "";
			LlenarComboJugadores();
			cmbGraf.Items.Add("Curvas");
			cmbGraf.Items.Add("Columnas");
			cmbGraf.Items.Add("Líneas rectas");
			cmbGraf.Items.Add("Puntos");
			cmbGraf.Items.Add("Áreas");
			tipoSerie = SeriesChartType.Spline;
		}
		
		void LlenarComboJugadores()
		{
			cmbJugadores.Items.Clear();
			imgList1.Images.Clear();
			for (int i = 0; i < objControl.jugadores.Count; i++)
			{
				if (!objControl.jugadores[i].Eliminado)
				{
					cmbJugadores.Items.Add(objControl.jugadores[i].nombre);
					imgList1.Images.Add(objControl.jugadores[i].Avatar);
				}
			}
			cmbJugadores.Focus();
		}
		
		void BtnAdicClick(object sender, EventArgs e)
		{
			RecuperarHistorial();
		}
		
		void RecuperarHistorial()
		{
			try
			{
				nombreJugador = cmbJugadores.SelectedItem.ToString();
				List<HistorialELO> historial = objControl.GetHistorialELOJugador(nombreJugador, chkTiempo.Checked, dtDesde.Value.Date, dtHasta.Value.Date);
				if (historial.Count > 0)
				{
					lstJugadores.Items.Add(nombreJugador, /*objControl.IndiceEnLista(nombreJugador)*/cmbJugadores.SelectedIndex);
					cmbJugadores.Items.RemoveAt(cmbJugadores.SelectedIndex);
					cmbJugadores.SelectedIndex = -1;
					cmbJugadores.Focus();
					var nueva = new Series(nombreJugador);
					nueva.ChartType = tipoSerie;
					for (int i = 0; i < historial.Count; i++)
						nueva.Points.Add(historial[i].Elo - 1000);
					nueva.Color = GetColor();
					chtGraf.Series.Add(nueva);
				}
				else
				{
					MiembrosEstaticos.MostrarAdvertencia("El jugador no tiene partidos\nregistrados en este período.");
					lstJugadores.Items.RemoveAt(lstJugadores.Items.Count - 1);
				}
			}
			catch (Exception){}
		}
		
		void ActualizarSeries()
		{
			try
			{
				for (int i = 0; i < chtGraf.Series.Count; i++)
				{
					List<HistorialELO> historial = objControl.GetHistorialELOJugador(chtGraf.Series[i].Name, chkTiempo.Checked, dtDesde.Value.Date, dtHasta.Value.Date);
					chtGraf.Series[i].Points.Clear();
					for (int j = 0; j < historial.Count; j++)
						chtGraf.Series[i].Points.Add(historial[j].Elo - 1000);
				}
			}
			catch (Exception){}
		}
		
		Color GetColor()
		{
			ultimoColor++;
			ultimoColor = (ultimoColor < colores.Count) ? ultimoColor : 0;
			return colores[ultimoColor];
		}
		
		void AdicionarSerie(Series nueva)
		{
			bool existe = false;
			for (int i = 0; i < chtGraf.Series.Count; i++)
			{
				if (chtGraf.Series[i].Name == nueva.Name)
				{
					existe = true;
					Color colorTmp = chtGraf.Series[i].Color;
					chtGraf.Series[i] = nueva;
					chtGraf.Series[i].Color = colorTmp;
				}
			}
			if (!existe)
			{
				nueva.Color = GetColor();
				chtGraf.Series.Add(nueva);
			}
		}
		
		void CmbJugadoresSelectedIndexChanged(object sender, EventArgs e)
		{
			btnAdic.Focus();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			ResetearGraficos();
		}
		
		void ResetearGraficos()
		{
			this.colores = objControl.GetListaColores();
			lstJugadores.Items.Clear();
			chtGraf.Series.Clear();
			ultimoColor = -1;
			LlenarComboJugadores();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			EliminarJugador();
		}
		
		void EliminarJugador()
		{
			try
			{
				nombreJugador = lstJugadores.Items[lstJugadores.SelectedIndices[0]].Text;
				chtGraf.Series.RemoveAt(lstJugadores.SelectedIndices[0]);
				lstJugadores.Items.RemoveAt(lstJugadores.SelectedIndices[0]);
				cmbJugadores.Items.Add(nombreJugador);
			}
			catch (Exception) {}
		}
		
		void LstJugadoresKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
				EliminarJugador();
		}
		
		void ChkTiempoCheckedChanged(object sender, EventArgs e)
		{
			RecuperarHistorial();
			ActualizarSeries();
		}
		
		void DtDesdeValueChanged(object sender, EventArgs e)
		{
			RecuperarHistorial();
			ActualizarSeries();
		}
		
		void DtHastaValueChanged(object sender, EventArgs e)
		{
			RecuperarHistorial();
			ActualizarSeries();
		}
		
		void CmbGrafSelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				switch (cmbGraf.SelectedItem.ToString())
				{
					case "Curvas":
					{
						tipoSerie = SeriesChartType.Spline;
					}
					break;
					case "Líneas rectas":
					{
						tipoSerie = SeriesChartType.Line;
					}
					break;
					case "Puntos":
					{
						tipoSerie = SeriesChartType.Point;
					}
					break;
					case "Columnas":
					{
						tipoSerie = SeriesChartType.Column;
					}
					break;
					case "Áreas":
					{
						tipoSerie = SeriesChartType.SplineArea;
					}
					break;
					default:
					{
						tipoSerie = SeriesChartType.Spline;
					}
					break;
				}
				
				for (int i = 0; i < chtGraf.Series.Count; i++)
					chtGraf.Series[i].ChartType = tipoSerie;
			}
			catch (Exception) {}
		}
		
		void ChtGrafKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
				Close();
		}
		
		void CmbTorneoSelectedIndexChanged(object sender, EventArgs e)
		{
			objControl = objListaDomino.ListaEnPosicion(cmbTorneo.SelectedIndex);
			ResetearGraficos();
		}
	}
}
