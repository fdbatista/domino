
namespace ControlDomino
{
	partial class frmCompJug
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompJug));
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"Partidos",
			"0"}, 0);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"Ganados",
			"0"}, 0);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"Perdidos",
			"0"}, 0);
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"Pollos a favor",
			"0"}, 0);
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"Pollos en contra",
			"0"}, 0);
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"Reculillos a favor",
			"0"}, 0);
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"Reculillos en contra",
			"0"}, 0);
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"Puntos ELO",
			"0"}, 0);
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"Ranking",
			"0"}, 0);
			System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
			"0",
			"CRG",
			"0"}, 0);
			this.cmbJugador1 = new System.Windows.Forms.ComboBox();
			this.cmbJugador2 = new System.Windows.Forms.ComboBox();
			this.imgJugador1 = new System.Windows.Forms.PictureBox();
			this.imgJugador2 = new System.Windows.Forms.PictureBox();
			this.imgList1 = new System.Windows.Forms.ImageList(this.components);
			this.cmbModo = new System.Windows.Forms.ComboBox();
			this.lstEstad = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbTorneo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.chkTiempo = new System.Windows.Forms.CheckBox();
			this.dtHasta = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtDesde = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgJugador1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgJugador2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbJugador1
			// 
			this.cmbJugador1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbJugador1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbJugador1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbJugador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbJugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbJugador1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbJugador1.FormattingEnabled = true;
			this.cmbJugador1.Location = new System.Drawing.Point(12, 116);
			this.cmbJugador1.Name = "cmbJugador1";
			this.cmbJugador1.Size = new System.Drawing.Size(200, 24);
			this.cmbJugador1.TabIndex = 0;
			this.cmbJugador1.SelectedIndexChanged += new System.EventHandler(this.CmbJugador1SelectedIndexChanged);
			this.cmbJugador1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarTeclado);
			// 
			// cmbJugador2
			// 
			this.cmbJugador2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbJugador2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbJugador2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbJugador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbJugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbJugador2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbJugador2.FormattingEnabled = true;
			this.cmbJugador2.Location = new System.Drawing.Point(452, 116);
			this.cmbJugador2.Name = "cmbJugador2";
			this.cmbJugador2.Size = new System.Drawing.Size(200, 24);
			this.cmbJugador2.TabIndex = 1;
			this.cmbJugador2.SelectedIndexChanged += new System.EventHandler(this.CmbJugador2SelectedIndexChanged);
			this.cmbJugador2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarTeclado);
			// 
			// imgJugador1
			// 
			this.imgJugador1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.imgJugador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgJugador1.Location = new System.Drawing.Point(12, 157);
			this.imgJugador1.Name = "imgJugador1";
			this.imgJugador1.Size = new System.Drawing.Size(200, 200);
			this.imgJugador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgJugador1.TabIndex = 39;
			this.imgJugador1.TabStop = false;
			// 
			// imgJugador2
			// 
			this.imgJugador2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.imgJugador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgJugador2.Location = new System.Drawing.Point(452, 157);
			this.imgJugador2.Name = "imgJugador2";
			this.imgJugador2.Size = new System.Drawing.Size(200, 200);
			this.imgJugador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgJugador2.TabIndex = 40;
			this.imgJugador2.TabStop = false;
			// 
			// imgList1
			// 
			this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
			this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList1.Images.SetKeyName(0, "shell32_44.ico");
			// 
			// cmbModo
			// 
			this.cmbModo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbModo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbModo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbModo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbModo.FormattingEnabled = true;
			this.cmbModo.Items.AddRange(new object[] {
			"General",
			"Como contrarios",
			"Como compañeros"});
			this.cmbModo.Location = new System.Drawing.Point(257, 116);
			this.cmbModo.Name = "cmbModo";
			this.cmbModo.Size = new System.Drawing.Size(150, 24);
			this.cmbModo.TabIndex = 2;
			this.cmbModo.SelectedIndexChanged += new System.EventHandler(this.CmbModoSelectedIndexChanged);
			this.cmbModo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarTeclado);
			// 
			// lstEstad
			// 
			this.lstEstad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2,
			this.columnHeader3});
			this.lstEstad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstEstad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstEstad.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstEstad.FullRowSelect = true;
			this.lstEstad.GridLines = true;
			this.lstEstad.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstEstad.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
			listViewItem1,
			listViewItem2,
			listViewItem3,
			listViewItem4,
			listViewItem5,
			listViewItem6,
			listViewItem7,
			listViewItem8,
			listViewItem9,
			listViewItem10});
			this.lstEstad.Location = new System.Drawing.Point(219, 157);
			this.lstEstad.MultiSelect = false;
			this.lstEstad.Name = "lstEstad";
			this.lstEstad.ShowItemToolTips = true;
			this.lstEstad.Size = new System.Drawing.Size(225, 199);
			this.lstEstad.TabIndex = 3;
			this.lstEstad.UseCompatibleStateImageBehavior = false;
			this.lstEstad.View = System.Windows.Forms.View.Details;
			this.lstEstad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarTeclado);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "CANT";
			this.columnHeader1.Width = 58;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "INDICADOR";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 105;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "CANT";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader3.Width = 58;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(257, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 17);
			this.label2.TabIndex = 53;
			this.label2.Text = "Modo de comparación:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(452, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 17);
			this.label3.TabIndex = 54;
			this.label3.Text = "Jugador 2:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbTorneo);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.chkTiempo);
			this.groupBox1.Controls.Add(this.dtHasta);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtDesde);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(638, 75);
			this.groupBox1.TabIndex = 60;
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
			this.cmbTorneo.Location = new System.Drawing.Point(9, 39);
			this.cmbTorneo.Name = "cmbTorneo";
			this.cmbTorneo.Size = new System.Drawing.Size(150, 24);
			this.cmbTorneo.TabIndex = 65;
			this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.CmbTorneoSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(9, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 66;
			this.label6.Text = "Torneo:";
			// 
			// chkTiempo
			// 
			this.chkTiempo.AutoSize = true;
			this.chkTiempo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chkTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkTiempo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkTiempo.Location = new System.Drawing.Point(203, 17);
			this.chkTiempo.Name = "chkTiempo";
			this.chkTiempo.Size = new System.Drawing.Size(153, 21);
			this.chkTiempo.TabIndex = 64;
			this.chkTiempo.Text = "Por rango de tiempo";
			this.chkTiempo.UseVisualStyleBackColor = true;
			this.chkTiempo.CheckedChanged += new System.EventHandler(this.ChkTiempoCheckedChanged);
			// 
			// dtHasta
			// 
			this.dtHasta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtHasta.Location = new System.Drawing.Point(479, 39);
			this.dtHasta.Name = "dtHasta";
			this.dtHasta.Size = new System.Drawing.Size(144, 21);
			this.dtHasta.TabIndex = 63;
			this.dtHasta.ValueChanged += new System.EventHandler(this.DtHastaValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(424, 44);
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
			this.label5.Location = new System.Drawing.Point(199, 43);
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
			this.dtDesde.Location = new System.Drawing.Point(258, 39);
			this.dtDesde.Name = "dtDesde";
			this.dtDesde.Size = new System.Drawing.Size(144, 21);
			this.dtDesde.TabIndex = 60;
			this.dtDesde.ValueChanged += new System.EventHandler(this.DtDesdeValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(12, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 52;
			this.label1.Text = "Jugador 1:";
			// 
			// frmCompJug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 369);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstEstad);
			this.Controls.Add(this.cmbModo);
			this.Controls.Add(this.imgJugador2);
			this.Controls.Add(this.imgJugador1);
			this.Controls.Add(this.cmbJugador2);
			this.Controls.Add(this.cmbJugador1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCompJug";
			this.Text = "Comparar jugadores";
			((System.ComponentModel.ISupportInitialize)(this.imgJugador1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgJugador2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTorneo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkTiempo;
		private System.Windows.Forms.DateTimePicker dtDesde;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtHasta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstEstad;
		private System.Windows.Forms.ComboBox cmbModo;
		private System.Windows.Forms.ImageList imgList1;
		private System.Windows.Forms.PictureBox imgJugador2;
		private System.Windows.Forms.PictureBox imgJugador1;
		private System.Windows.Forms.ComboBox cmbJugador2;
		private System.Windows.Forms.ComboBox cmbJugador1;
	}
}
