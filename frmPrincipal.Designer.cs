
namespace ControlDomino
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.mnuPrinc = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarPartidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.actualizarPartidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calcularELOGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.actualizarSonidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.notificacionesPorCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editarListasDePartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.personalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.estadIndivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rércordsIndividualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
			this.compararJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gráficoDeRendimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.grupoÉliteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prospectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaNegraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.porParejasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbTipoPartido = new System.Windows.Forms.ComboBox();
			this.chkInactivos = new System.Windows.Forms.CheckBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.chkFecha = new System.Windows.Forms.CheckBox();
			this.dtHasta = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtDesde = new System.Windows.Forms.DateTimePicker();
			this.cmbJugadores = new System.Windows.Forms.ComboBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.nmPartidos = new System.Windows.Forms.NumericUpDown();
			this.lblMostrarUltimos = new System.Windows.Forms.Label();
			this.lstPartidos = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dlgCarpeta = new System.Windows.Forms.FolderBrowserDialog();
			this.mnuPrinc.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmPartidos)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuPrinc
			// 
			this.mnuPrinc.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.mnuPrinc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem,
			this.administrarToolStripMenuItem1,
			this.reportesToolStripMenuItem,
			this.ayudaToolStripMenuItem});
			this.mnuPrinc.Location = new System.Drawing.Point(0, 0);
			this.mnuPrinc.Name = "mnuPrinc";
			this.mnuPrinc.ShowItemToolTips = true;
			this.mnuPrinc.Size = new System.Drawing.Size(834, 27);
			this.mnuPrinc.TabIndex = 1;
			this.mnuPrinc.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.guardarCambiosToolStripMenuItem,
			this.toolStripMenuItem1,
			this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// guardarCambiosToolStripMenuItem
			// 
			this.guardarCambiosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarCambiosToolStripMenuItem.Image")));
			this.guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
			this.guardarCambiosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.guardarCambiosToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
			this.guardarCambiosToolStripMenuItem.Text = "&Guardar cambios";
			this.guardarCambiosToolStripMenuItem.Click += new System.EventHandler(this.GuardarCambiosToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(230, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
			this.salirToolStripMenuItem.Text = "&Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// administrarToolStripMenuItem1
			// 
			this.administrarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.registrarPartidoToolStripMenuItem,
			this.actualizarPartidoToolStripMenuItem,
			this.toolStripMenuItem6,
			this.cambiarContraseñaToolStripMenuItem,
			this.administrarToolStripMenuItem,
			this.calcularELOGeneralToolStripMenuItem,
			this.toolStripMenuItem5,
			this.adicionarToolStripMenuItem,
			this.actualizarSonidosToolStripMenuItem,
			this.toolStripMenuItem2,
			this.notificacionesPorCorreoToolStripMenuItem,
			this.editarListasDePartidosToolStripMenuItem});
			this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
			this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(92, 23);
			this.administrarToolStripMenuItem1.Text = "A&dministrar";
			// 
			// registrarPartidoToolStripMenuItem
			// 
			this.registrarPartidoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarPartidoToolStripMenuItem.Image")));
			this.registrarPartidoToolStripMenuItem.Name = "registrarPartidoToolStripMenuItem";
			this.registrarPartidoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.registrarPartidoToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
			this.registrarPartidoToolStripMenuItem.Text = "Registrar &partidos";
			this.registrarPartidoToolStripMenuItem.Click += new System.EventHandler(this.RegistrarPartidoToolStripMenuItemClick);
			// 
			// actualizarPartidoToolStripMenuItem
			// 
			this.actualizarPartidoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarPartidoToolStripMenuItem.Image")));
			this.actualizarPartidoToolStripMenuItem.Name = "actualizarPartidoToolStripMenuItem";
			this.actualizarPartidoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.actualizarPartidoToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
			this.actualizarPartidoToolStripMenuItem.Text = "E&liminar partidos";
			this.actualizarPartidoToolStripMenuItem.Click += new System.EventHandler(this.ActualizarPartidoToolStripMenuItemClick);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(272, 6);
			// 
			// cambiarContraseñaToolStripMenuItem
			// 
			this.cambiarContraseñaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarContraseñaToolStripMenuItem.Image")));
			this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
			this.cambiarContraseñaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
			this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
			this.cambiarContraseñaToolStripMenuItem.Text = "Cam&biar contraseña";
			this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.CambiarContraseñaToolStripMenuItemClick);
			// 
			// administrarToolStripMenuItem
			// 
			this.administrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administrarToolStripMenuItem.Image")));
			this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
			this.administrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.administrarToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
			this.administrarToolStripMenuItem.Text = "E&ditar parámetros";
			this.administrarToolStripMenuItem.Click += new System.EventHandler(this.AdministrarToolStripMenuItemClick);
			// 
			// calcularELOGeneralToolStripMenuItem
			// 
			this.calcularELOGeneralToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calcularELOGeneralToolStripMenuItem.Image")));
			this.calcularELOGeneralToolStripMenuItem.Name = "calcularELOGeneralToolStripMenuItem";
			this.calcularELOGeneralToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.calcularELOGeneralToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
			this.calcularELOGeneralToolStripMenuItem.Text = "Recalcular &estadísticas";
			this.calcularELOGeneralToolStripMenuItem.Click += new System.EventHandler(this.CalcularELOGeneralToolStripMenuItemClick);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(272, 6);
			// 
			// adicionarToolStripMenuItem
			// 
			this.adicionarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarToolStripMenuItem.Image")));
			this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
			this.adicionarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
			this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
			this.adicionarToolStripMenuItem.Text = "Actualizar &jugadores";
			this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.AdicionarToolStripMenuItemClick);
			// 
			// actualizarSonidosToolStripMenuItem
			// 
			this.actualizarSonidosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarSonidosToolStripMenuItem.Image")));
			this.actualizarSonidosToolStripMenuItem.Name = "actualizarSonidosToolStripMenuItem";
			this.actualizarSonidosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.actualizarSonidosToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
			this.actualizarSonidosToolStripMenuItem.Text = "Actualizar &sonidos";
			this.actualizarSonidosToolStripMenuItem.Click += new System.EventHandler(this.ActualizarSonidosToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(272, 6);
			// 
			// notificacionesPorCorreoToolStripMenuItem
			// 
			this.notificacionesPorCorreoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notificacionesPorCorreoToolStripMenuItem.Image")));
			this.notificacionesPorCorreoToolStripMenuItem.Name = "notificacionesPorCorreoToolStripMenuItem";
			this.notificacionesPorCorreoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.notificacionesPorCorreoToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
			this.notificacionesPorCorreoToolStripMenuItem.Text = "&Notificaciones de correo";
			this.notificacionesPorCorreoToolStripMenuItem.Click += new System.EventHandler(this.NotificacionesPorCorreoToolStripMenuItemClick);
			// 
			// editarListasDePartidosToolStripMenuItem
			// 
			this.editarListasDePartidosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarListasDePartidosToolStripMenuItem.Image")));
			this.editarListasDePartidosToolStripMenuItem.Name = "editarListasDePartidosToolStripMenuItem";
			this.editarListasDePartidosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.editarListasDePartidosToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
			this.editarListasDePartidosToolStripMenuItem.Text = "Editar torneos";
			this.editarListasDePartidosToolStripMenuItem.Click += new System.EventHandler(this.EditarListasDePartidosToolStripMenuItemClick);
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.personalesToolStripMenuItem,
			this.generalesToolStripMenuItem,
			this.toolStripMenuItem4,
			this.porParejasToolStripMenuItem});
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
			this.reportesToolStripMenuItem.Text = "&Estadísticas";
			// 
			// personalesToolStripMenuItem
			// 
			this.personalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.estadIndivToolStripMenuItem,
			this.rércordsIndividualesToolStripMenuItem,
			this.toolStripMenuItem8,
			this.compararJugadoresToolStripMenuItem,
			this.gráficoDeRendimientoToolStripMenuItem});
			this.personalesToolStripMenuItem.Name = "personalesToolStripMenuItem";
			this.personalesToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
			this.personalesToolStripMenuItem.Text = "&Individuales";
			// 
			// estadIndivToolStripMenuItem
			// 
			this.estadIndivToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("estadIndivToolStripMenuItem.Image")));
			this.estadIndivToolStripMenuItem.Name = "estadIndivToolStripMenuItem";
			this.estadIndivToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.estadIndivToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
			this.estadIndivToolStripMenuItem.Text = "&Individuales";
			this.estadIndivToolStripMenuItem.Click += new System.EventHandler(this.EstadIndivToolStripMenuItemClick);
			// 
			// rércordsIndividualesToolStripMenuItem
			// 
			this.rércordsIndividualesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rércordsIndividualesToolStripMenuItem.Image")));
			this.rércordsIndividualesToolStripMenuItem.Name = "rércordsIndividualesToolStripMenuItem";
			this.rércordsIndividualesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.rércordsIndividualesToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
			this.rércordsIndividualesToolStripMenuItem.Text = "Récords";
			this.rércordsIndividualesToolStripMenuItem.Click += new System.EventHandler(this.RércordsIndividualesToolStripMenuItemClick);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(263, 6);
			// 
			// compararJugadoresToolStripMenuItem
			// 
			this.compararJugadoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compararJugadoresToolStripMenuItem.Image")));
			this.compararJugadoresToolStripMenuItem.Name = "compararJugadoresToolStripMenuItem";
			this.compararJugadoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.compararJugadoresToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
			this.compararJugadoresToolStripMenuItem.Text = "&Comparación";
			this.compararJugadoresToolStripMenuItem.Click += new System.EventHandler(this.CompararJugadoresToolStripMenuItemClick);
			// 
			// gráficoDeRendimientoToolStripMenuItem
			// 
			this.gráficoDeRendimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gráficoDeRendimientoToolStripMenuItem.Image")));
			this.gráficoDeRendimientoToolStripMenuItem.Name = "gráficoDeRendimientoToolStripMenuItem";
			this.gráficoDeRendimientoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.gráficoDeRendimientoToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
			this.gráficoDeRendimientoToolStripMenuItem.Text = "Grá&fico de rendimiento";
			this.gráficoDeRendimientoToolStripMenuItem.Click += new System.EventHandler(this.GráficoDeRendimientoToolStripMenuItemClick);
			// 
			// generalesToolStripMenuItem
			// 
			this.generalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.recordsToolStripMenuItem,
			this.toolStripMenuItem7,
			this.grupoÉliteToolStripMenuItem,
			this.prospectosToolStripMenuItem,
			this.listaNegraToolStripMenuItem});
			this.generalesToolStripMenuItem.Name = "generalesToolStripMenuItem";
			this.generalesToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
			this.generalesToolStripMenuItem.Text = "&Generales";
			// 
			// recordsToolStripMenuItem
			// 
			this.recordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recordsToolStripMenuItem.Image")));
			this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
			this.recordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.recordsToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
			this.recordsToolStripMenuItem.Text = "&Récords";
			this.recordsToolStripMenuItem.Click += new System.EventHandler(this.RecordsToolStripMenuItemClick);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(194, 6);
			// 
			// grupoÉliteToolStripMenuItem
			// 
			this.grupoÉliteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("grupoÉliteToolStripMenuItem.Image")));
			this.grupoÉliteToolStripMenuItem.Name = "grupoÉliteToolStripMenuItem";
			this.grupoÉliteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.grupoÉliteToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
			this.grupoÉliteToolStripMenuItem.Text = "Gr&upo élite";
			this.grupoÉliteToolStripMenuItem.Click += new System.EventHandler(this.GrupoÉliteToolStripMenuItemClick);
			// 
			// prospectosToolStripMenuItem
			// 
			this.prospectosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prospectosToolStripMenuItem.Image")));
			this.prospectosToolStripMenuItem.Name = "prospectosToolStripMenuItem";
			this.prospectosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.prospectosToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
			this.prospectosToolStripMenuItem.Text = "Pr&ospectos";
			this.prospectosToolStripMenuItem.Click += new System.EventHandler(this.ProspectosToolStripMenuItemClick);
			// 
			// listaNegraToolStripMenuItem
			// 
			this.listaNegraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaNegraToolStripMenuItem.Image")));
			this.listaNegraToolStripMenuItem.Name = "listaNegraToolStripMenuItem";
			this.listaNegraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.listaNegraToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
			this.listaNegraToolStripMenuItem.Text = "Lis&ta negra";
			this.listaNegraToolStripMenuItem.Click += new System.EventHandler(this.ListaNegraToolStripMenuItemClick);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(193, 6);
			// 
			// porParejasToolStripMenuItem
			// 
			this.porParejasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("porParejasToolStripMenuItem.Image")));
			this.porParejasToolStripMenuItem.Name = "porParejasToolStripMenuItem";
			this.porParejasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.porParejasToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
			this.porParejasToolStripMenuItem.Text = "Por p&arejas";
			this.porParejasToolStripMenuItem.Click += new System.EventHandler(this.PorParejasToolStripMenuItemClick);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.acercaDeToolStripMenuItem});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
			this.ayudaToolStripMenuItem.Text = "Ay&uda";
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
			this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbTipoPartido);
			this.groupBox1.Controls.Add(this.chkInactivos);
			this.groupBox1.Controls.Add(this.lblTotal);
			this.groupBox1.Controls.Add(this.chkFecha);
			this.groupBox1.Controls.Add(this.dtHasta);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtDesde);
			this.groupBox1.Controls.Add(this.cmbJugadores);
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Controls.Add(this.nmPartidos);
			this.groupBox1.Controls.Add(this.lblMostrarUltimos);
			this.groupBox1.Controls.Add(this.lstPartidos);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(12, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(811, 379);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Últimos partidos";
			// 
			// cmbTipoPartido
			// 
			this.cmbTipoPartido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbTipoPartido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbTipoPartido.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbTipoPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipoPartido.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbTipoPartido.FormattingEnabled = true;
			this.cmbTipoPartido.Items.AddRange(new object[] {
			"partidos",
			"victorias",
			"derrotas"});
			this.cmbTipoPartido.Location = new System.Drawing.Point(193, 23);
			this.cmbTipoPartido.Name = "cmbTipoPartido";
			this.cmbTipoPartido.Size = new System.Drawing.Size(103, 24);
			this.cmbTipoPartido.TabIndex = 72;
			this.cmbTipoPartido.SelectedIndexChanged += new System.EventHandler(this.CmbTipoPartidoSelectedIndexChanged);
			// 
			// chkInactivos
			// 
			this.chkInactivos.AutoSize = true;
			this.chkInactivos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chkInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkInactivos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkInactivos.Location = new System.Drawing.Point(326, 53);
			this.chkInactivos.Name = "chkInactivos";
			this.chkInactivos.Size = new System.Drawing.Size(143, 21);
			this.chkInactivos.TabIndex = 71;
			this.chkInactivos.Text = "Mostrar eli&minados";
			this.chkInactivos.UseVisualStyleBackColor = true;
			this.chkInactivos.CheckedChanged += new System.EventHandler(this.ChkInactivosCheckedChanged);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(15, 55);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(87, 17);
			this.lblTotal.TabIndex = 70;
			this.lblTotal.Text = "Resultados: ";
			// 
			// chkFecha
			// 
			this.chkFecha.AutoSize = true;
			this.chkFecha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chkFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkFecha.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkFecha.Location = new System.Drawing.Point(489, 24);
			this.chkFecha.Name = "chkFecha";
			this.chkFecha.Size = new System.Drawing.Size(85, 21);
			this.chkFecha.TabIndex = 69;
			this.chkFecha.Text = "Por &fecha";
			this.chkFecha.UseVisualStyleBackColor = true;
			this.chkFecha.CheckedChanged += new System.EventHandler(this.ChkFechaCheckedChanged);
			// 
			// dtHasta
			// 
			this.dtHasta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtHasta.Location = new System.Drawing.Point(635, 52);
			this.dtHasta.Name = "dtHasta";
			this.dtHasta.Size = new System.Drawing.Size(162, 21);
			this.dtHasta.TabIndex = 68;
			this.dtHasta.ValueChanged += new System.EventHandler(this.DtHastaValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(580, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 17);
			this.label4.TabIndex = 67;
			this.label4.Text = "Hasta:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(580, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 17);
			this.label5.TabIndex = 66;
			this.label5.Text = "Desde:";
			// 
			// dtDesde
			// 
			this.dtDesde.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDesde.Location = new System.Drawing.Point(635, 21);
			this.dtDesde.Name = "dtDesde";
			this.dtDesde.Size = new System.Drawing.Size(162, 21);
			this.dtDesde.TabIndex = 65;
			this.dtDesde.ValueChanged += new System.EventHandler(this.DtDesdeValueChanged);
			// 
			// cmbJugadores
			// 
			this.cmbJugadores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbJugadores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbJugadores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbJugadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbJugadores.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbJugadores.FormattingEnabled = true;
			this.cmbJugadores.Location = new System.Drawing.Point(326, 23);
			this.cmbJugadores.Name = "cmbJugadores";
			this.cmbJugadores.Size = new System.Drawing.Size(143, 24);
			this.cmbJugadores.TabIndex = 33;
			this.cmbJugadores.SelectedIndexChanged += new System.EventHandler(this.CmbJugadoresSelectedIndexChanged);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(280, 178);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(255, 23);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 32;
			this.progressBar1.Visible = false;
			// 
			// nmPartidos
			// 
			this.nmPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nmPartidos.Location = new System.Drawing.Point(121, 24);
			this.nmPartidos.Maximum = new decimal(new int[] {
			0,
			232,
			0,
			0});
			this.nmPartidos.Name = "nmPartidos";
			this.nmPartidos.Size = new System.Drawing.Size(63, 23);
			this.nmPartidos.TabIndex = 31;
			this.nmPartidos.Value = new decimal(new int[] {
			999999,
			0,
			0,
			0});
			this.nmPartidos.ValueChanged += new System.EventHandler(this.NmPartidosValueChanged);
			// 
			// lblMostrarUltimos
			// 
			this.lblMostrarUltimos.AutoSize = true;
			this.lblMostrarUltimos.Location = new System.Drawing.Point(15, 26);
			this.lblMostrarUltimos.Name = "lblMostrarUltimos";
			this.lblMostrarUltimos.Size = new System.Drawing.Size(308, 17);
			this.lblMostrarUltimos.TabIndex = 30;
			this.lblMostrarUltimos.Text = "Mostrar últimos                                               de";
			// 
			// lstPartidos
			// 
			this.lstPartidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2,
			this.columnHeader3,
			this.columnHeader4});
			this.lstPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstPartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPartidos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstPartidos.FullRowSelect = true;
			this.lstPartidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstPartidos.Location = new System.Drawing.Point(15, 85);
			this.lstPartidos.MultiSelect = false;
			this.lstPartidos.Name = "lstPartidos";
			this.lstPartidos.ShowItemToolTips = true;
			this.lstPartidos.Size = new System.Drawing.Size(782, 280);
			this.lstPartidos.SmallImageList = this.imgList;
			this.lstPartidos.TabIndex = 29;
			this.lstPartidos.UseCompatibleStateImageBehavior = false;
			this.lstPartidos.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Ganadores";
			this.columnHeader1.Width = 300;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Perdedores";
			this.columnHeader2.Width = 300;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Marcador";
			this.columnHeader3.Width = 76;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Fecha";
			this.columnHeader4.Width = 85;
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "messenger.ico");
			this.imgList.Images.SetKeyName(1, "Jen-Birdie-Happy-birdie.ico");
			this.imgList.Images.SetKeyName(2, "ieframe_31077.ico");
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 419);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.mnuPrinc);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPrincipal";
			this.ShowInTaskbar = true;
			this.Text = "DominArte";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipalFormClosing);
			this.mnuPrinc.ResumeLayout(false);
			this.mnuPrinc.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmPartidos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripMenuItem editarListasDePartidosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem notificacionesPorCorreoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem gráficoDeRendimientoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prospectosToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem generalesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem personalesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem grupoÉliteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listaNegraToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem porParejasToolStripMenuItem;
		private System.Windows.Forms.FolderBrowserDialog dlgCarpeta;
		private System.Windows.Forms.ToolStripMenuItem actualizarSonidosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
		private System.Windows.Forms.ComboBox cmbTipoPartido;
		private System.Windows.Forms.CheckBox chkInactivos;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.DateTimePicker dtDesde;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtHasta;
		private System.Windows.Forms.CheckBox chkFecha;
		private System.Windows.Forms.ComboBox cmbJugadores;
		private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rércordsIndividualesToolStripMenuItem;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ToolStripMenuItem calcularELOGeneralToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem compararJugadoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem actualizarPartidoToolStripMenuItem;
		private System.Windows.Forms.Label lblMostrarUltimos;
		private System.Windows.Forms.NumericUpDown nmPartidos;
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstPartidos;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStripMenuItem registrarPartidoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem estadIndivToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarCambiosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mnuPrinc;
	}
}
