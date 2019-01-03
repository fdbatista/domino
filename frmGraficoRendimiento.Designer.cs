
namespace ControlDomino
{
	partial class frmGraficoRendimiento
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraficoRendimiento));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbTorneo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbGraf = new System.Windows.Forms.ComboBox();
			this.chtGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.lstJugadores = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.imgList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnAdic = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbJugadores = new System.Windows.Forms.ComboBox();
			this.chkTiempo = new System.Windows.Forms.CheckBox();
			this.dtHasta = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtDesde = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chtGraf)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.cmbTorneo);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cmbGraf);
			this.groupBox1.Controls.Add(this.chtGraf);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnEliminar);
			this.groupBox1.Controls.Add(this.btnLimpiar);
			this.groupBox1.Controls.Add(this.lstJugadores);
			this.groupBox1.Controls.Add(this.btnAdic);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbJugadores);
			this.groupBox1.Controls.Add(this.chkTiempo);
			this.groupBox1.Controls.Add(this.dtHasta);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtDesde);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(633, 436);
			this.groupBox1.TabIndex = 61;
			this.groupBox1.TabStop = false;
			// 
			// cmbTorneo
			// 
			this.cmbTorneo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbTorneo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbTorneo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTorneo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbTorneo.FormattingEnabled = true;
			this.cmbTorneo.Location = new System.Drawing.Point(74, 43);
			this.cmbTorneo.Name = "cmbTorneo";
			this.cmbTorneo.Size = new System.Drawing.Size(159, 24);
			this.cmbTorneo.TabIndex = 73;
			this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.CmbTorneoSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(15, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 74;
			this.label6.Text = "Torneo:";
			// 
			// cmbGraf
			// 
			this.cmbGraf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbGraf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbGraf.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbGraf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGraf.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbGraf.FormattingEnabled = true;
			this.cmbGraf.Location = new System.Drawing.Point(74, 126);
			this.cmbGraf.Name = "cmbGraf";
			this.cmbGraf.Size = new System.Drawing.Size(159, 24);
			this.cmbGraf.TabIndex = 72;
			this.cmbGraf.SelectedIndexChanged += new System.EventHandler(this.CmbGrafSelectedIndexChanged);
			this.cmbGraf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChtGrafKeyDown);
			// 
			// chtGraf
			// 
			this.chtGraf.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.Name = "ChartArea1";
			this.chtGraf.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chtGraf.Legends.Add(legend1);
			this.chtGraf.Location = new System.Drawing.Point(15, 156);
			this.chtGraf.Name = "chtGraf";
			this.chtGraf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chtGraf.PaletteCustomColors = new System.Drawing.Color[] {
						System.Drawing.Color.Red};
			this.chtGraf.Size = new System.Drawing.Size(602, 261);
			this.chtGraf.TabIndex = 71;
			this.chtGraf.Text = "Rendimiento";
			this.chtGraf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChtGrafKeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(15, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 17);
			this.label2.TabIndex = 71;
			this.label2.Text = "Tipo:";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(239, 98);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(138, 26);
			this.btnEliminar.TabIndex = 70;
			this.btnEliminar.Text = "&Eliminar gráfico";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			this.btnEliminar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChtGrafKeyDown);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
			this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpiar.Location = new System.Drawing.Point(239, 126);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(138, 26);
			this.btnLimpiar.TabIndex = 69;
			this.btnLimpiar.Text = "&Borrar gráficos";
			this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			this.btnLimpiar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChtGrafKeyDown);
			// 
			// lstJugadores
			// 
			this.lstJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1});
			this.lstJugadores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstJugadores.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstJugadores.FullRowSelect = true;
			this.lstJugadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstJugadores.Location = new System.Drawing.Point(383, 22);
			this.lstJugadores.MultiSelect = false;
			this.lstJugadores.Name = "lstJugadores";
			this.lstJugadores.ShowItemToolTips = true;
			this.lstJugadores.Size = new System.Drawing.Size(234, 128);
			this.lstJugadores.SmallImageList = this.imgList1;
			this.lstJugadores.TabIndex = 68;
			this.lstJugadores.UseCompatibleStateImageBehavior = false;
			this.lstJugadores.View = System.Windows.Forms.View.Details;
			this.lstJugadores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstJugadoresKeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Jugador";
			this.columnHeader1.Width = 210;
			// 
			// imgList1
			// 
			this.imgList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgList1.ImageSize = new System.Drawing.Size(32, 32);
			this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btnAdic
			// 
			this.btnAdic.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdic.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnAdic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdic.Image = ((System.Drawing.Image)(resources.GetObject("btnAdic.Image")));
			this.btnAdic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdic.Location = new System.Drawing.Point(239, 70);
			this.btnAdic.Name = "btnAdic";
			this.btnAdic.Size = new System.Drawing.Size(138, 26);
			this.btnAdic.TabIndex = 67;
			this.btnAdic.Text = "&Adicionar gráfico";
			this.btnAdic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdic.UseVisualStyleBackColor = true;
			this.btnAdic.Click += new System.EventHandler(this.BtnAdicClick);
			this.btnAdic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChtGrafKeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(213, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 17);
			this.label1.TabIndex = 66;
			this.label1.Text = "Jugadores:";
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
			this.cmbJugadores.Location = new System.Drawing.Point(239, 43);
			this.cmbJugadores.Name = "cmbJugadores";
			this.cmbJugadores.Size = new System.Drawing.Size(138, 24);
			this.cmbJugadores.TabIndex = 65;
			this.cmbJugadores.SelectedIndexChanged += new System.EventHandler(this.CmbJugadoresSelectedIndexChanged);
			this.cmbJugadores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChtGrafKeyDown);
			// 
			// chkTiempo
			// 
			this.chkTiempo.AutoSize = true;
			this.chkTiempo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chkTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkTiempo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkTiempo.Location = new System.Drawing.Point(15, 16);
			this.chkTiempo.Name = "chkTiempo";
			this.chkTiempo.Size = new System.Drawing.Size(153, 21);
			this.chkTiempo.TabIndex = 64;
			this.chkTiempo.Text = "Por rango de tiempo";
			this.chkTiempo.UseVisualStyleBackColor = true;
			this.chkTiempo.CheckedChanged += new System.EventHandler(this.ChkTiempoCheckedChanged);
			this.chkTiempo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChtGrafKeyDown);
			// 
			// dtHasta
			// 
			this.dtHasta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtHasta.Location = new System.Drawing.Point(74, 101);
			this.dtHasta.Name = "dtHasta";
			this.dtHasta.Size = new System.Drawing.Size(159, 21);
			this.dtHasta.TabIndex = 63;
			this.dtHasta.ValueChanged += new System.EventHandler(this.DtHastaValueChanged);
			this.dtHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChtGrafKeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(15, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 17);
			this.label4.TabIndex = 62;
			this.label4.Text = "Hasta:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(15, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 17);
			this.label5.TabIndex = 61;
			this.label5.Text = "Desde:";
			// 
			// dtDesde
			// 
			this.dtDesde.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDesde.Location = new System.Drawing.Point(74, 73);
			this.dtDesde.Name = "dtDesde";
			this.dtDesde.Size = new System.Drawing.Size(159, 21);
			this.dtDesde.TabIndex = 60;
			this.dtDesde.ValueChanged += new System.EventHandler(this.DtDesdeValueChanged);
			this.dtDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChtGrafKeyDown);
			// 
			// frmGraficoRendimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(655, 458);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmGraficoRendimiento";
			this.Text = "Gráfico de rendimiento";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chtGraf)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTorneo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbGraf;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.ImageList imgList1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstJugadores;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnAdic;
		private System.Windows.Forms.ComboBox cmbJugadores;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtDesde;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtHasta;
		private System.Windows.Forms.CheckBox chkTiempo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chtGraf;
	}
}
