
namespace ControlDomino
{
	partial class frmJuegoNuevo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuegoNuevo));
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.grpGeneral = new System.Windows.Forms.GroupBox();
			this.cmbPunt = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.txtComent = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.chkGanadora = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnPart = new System.Windows.Forms.Button();
			this.lstPerdedores = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.lstGanadores = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.btnPareja = new System.Windows.Forms.Button();
			this.chkRecul = new System.Windows.Forms.CheckBox();
			this.chkPollo = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbJugador2 = new System.Windows.Forms.ComboBox();
			this.cmbJugador1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grpGeneral.SuspendLayout();
			this.SuspendLayout();
			// 
			// imgList
			// 
			this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgList.ImageSize = new System.Drawing.Size(48, 48);
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(152, 156);
			this.progressBar1.Maximum = 5;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(216, 23);
			this.progressBar1.Step = 1;
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 38;
			this.progressBar1.Visible = false;
			// 
			// grpGeneral
			// 
			this.grpGeneral.Controls.Add(this.progressBar1);
			this.grpGeneral.Controls.Add(this.cmbPunt);
			this.grpGeneral.Controls.Add(this.label3);
			this.grpGeneral.Controls.Add(this.dtFecha);
			this.grpGeneral.Controls.Add(this.txtComent);
			this.grpGeneral.Controls.Add(this.button1);
			this.grpGeneral.Controls.Add(this.chkGanadora);
			this.grpGeneral.Controls.Add(this.btnCancel);
			this.grpGeneral.Controls.Add(this.btnPart);
			this.grpGeneral.Controls.Add(this.lstPerdedores);
			this.grpGeneral.Controls.Add(this.lstGanadores);
			this.grpGeneral.Controls.Add(this.btnPareja);
			this.grpGeneral.Controls.Add(this.chkRecul);
			this.grpGeneral.Controls.Add(this.chkPollo);
			this.grpGeneral.Controls.Add(this.label2);
			this.grpGeneral.Controls.Add(this.label5);
			this.grpGeneral.Controls.Add(this.cmbJugador2);
			this.grpGeneral.Controls.Add(this.cmbJugador1);
			this.grpGeneral.Controls.Add(this.label1);
			this.grpGeneral.Location = new System.Drawing.Point(12, 12);
			this.grpGeneral.Name = "grpGeneral";
			this.grpGeneral.Size = new System.Drawing.Size(515, 328);
			this.grpGeneral.TabIndex = 39;
			this.grpGeneral.TabStop = false;
			// 
			// cmbPunt
			// 
			this.cmbPunt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbPunt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbPunt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbPunt.DropDownHeight = 180;
			this.cmbPunt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPunt.Enabled = false;
			this.cmbPunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPunt.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbPunt.FormattingEnabled = true;
			this.cmbPunt.IntegralHeight = false;
			this.cmbPunt.ItemHeight = 16;
			this.cmbPunt.Location = new System.Drawing.Point(89, 76);
			this.cmbPunt.Name = "cmbPunt";
			this.cmbPunt.Size = new System.Drawing.Size(55, 24);
			this.cmbPunt.TabIndex = 55;
			this.cmbPunt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbPuntKeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(18, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 54;
			this.label3.Text = "&Fecha:";
			// 
			// dtFecha
			// 
			this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFecha.Location = new System.Drawing.Point(89, 103);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(166, 21);
			this.dtFecha.TabIndex = 41;
			// 
			// txtComent
			// 
			this.txtComent.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.txtComent.Location = new System.Drawing.Point(18, 156);
			this.txtComent.Multiline = true;
			this.txtComent.Name = "txtComent";
			this.txtComent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtComent.Size = new System.Drawing.Size(237, 48);
			this.txtComent.TabIndex = 45;
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(152, 282);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 29);
			this.button1.TabIndex = 51;
			this.button1.Text = "&Cancelar";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// chkGanadora
			// 
			this.chkGanadora.AutoSize = true;
			this.chkGanadora.Checked = true;
			this.chkGanadora.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkGanadora.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkGanadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkGanadora.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkGanadora.Location = new System.Drawing.Point(18, 129);
			this.chkGanadora.Name = "chkGanadora";
			this.chkGanadora.Size = new System.Drawing.Size(87, 19);
			this.chkGanadora.TabIndex = 42;
			this.chkGanadora.Text = "&Ganadores";
			this.chkGanadora.UseVisualStyleBackColor = true;
			this.chkGanadora.CheckedChanged += new System.EventHandler(this.ChkGanadoraCheckedChanged);
			// 
			// btnCancel
			// 
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(18, 282);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(126, 29);
			this.btnCancel.TabIndex = 50;
			this.btnCancel.Text = "&Restablecer";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnPart
			// 
			this.btnPart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPart.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnPart.Image = ((System.Drawing.Image)(resources.GetObject("btnPart.Image")));
			this.btnPart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPart.Location = new System.Drawing.Point(18, 247);
			this.btnPart.Name = "btnPart";
			this.btnPart.Size = new System.Drawing.Size(237, 29);
			this.btnPart.TabIndex = 48;
			this.btnPart.Text = "Registrar par&tido";
			this.btnPart.UseVisualStyleBackColor = true;
			this.btnPart.Click += new System.EventHandler(this.BtnPartClick);
			// 
			// lstPerdedores
			// 
			this.lstPerdedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader2});
			this.lstPerdedores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstPerdedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPerdedores.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstPerdedores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstPerdedores.Location = new System.Drawing.Point(262, 177);
			this.lstPerdedores.MultiSelect = false;
			this.lstPerdedores.Name = "lstPerdedores";
			this.lstPerdedores.ShowItemToolTips = true;
			this.lstPerdedores.Size = new System.Drawing.Size(236, 134);
			this.lstPerdedores.SmallImageList = this.imgList;
			this.lstPerdedores.TabIndex = 53;
			this.lstPerdedores.UseCompatibleStateImageBehavior = false;
			this.lstPerdedores.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Perdedores";
			this.columnHeader2.Width = 228;
			// 
			// lstGanadores
			// 
			this.lstGanadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1});
			this.lstGanadores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstGanadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstGanadores.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstGanadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstGanadores.Location = new System.Drawing.Point(262, 24);
			this.lstGanadores.MultiSelect = false;
			this.lstGanadores.Name = "lstGanadores";
			this.lstGanadores.ShowItemToolTips = true;
			this.lstGanadores.Size = new System.Drawing.Size(236, 133);
			this.lstGanadores.SmallImageList = this.imgList;
			this.lstGanadores.TabIndex = 52;
			this.lstGanadores.UseCompatibleStateImageBehavior = false;
			this.lstGanadores.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Ganadores";
			this.columnHeader1.Width = 228;
			// 
			// btnPareja
			// 
			this.btnPareja.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPareja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPareja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPareja.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnPareja.Image = ((System.Drawing.Image)(resources.GetObject("btnPareja.Image")));
			this.btnPareja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPareja.Location = new System.Drawing.Point(18, 212);
			this.btnPareja.Name = "btnPareja";
			this.btnPareja.Size = new System.Drawing.Size(237, 29);
			this.btnPareja.TabIndex = 46;
			this.btnPareja.Text = "Registrar &pareja";
			this.btnPareja.UseVisualStyleBackColor = true;
			this.btnPareja.Click += new System.EventHandler(this.BtnParGanClick);
			// 
			// chkRecul
			// 
			this.chkRecul.AutoSize = true;
			this.chkRecul.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkRecul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkRecul.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkRecul.Location = new System.Drawing.Point(181, 129);
			this.chkRecul.Name = "chkRecul";
			this.chkRecul.Size = new System.Drawing.Size(74, 19);
			this.chkRecul.TabIndex = 44;
			this.chkRecul.Text = "R&eculillo";
			this.chkRecul.UseVisualStyleBackColor = true;
			this.chkRecul.CheckedChanged += new System.EventHandler(this.ChkReculCheckedChanged);
			// 
			// chkPollo
			// 
			this.chkPollo.AutoSize = true;
			this.chkPollo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkPollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkPollo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkPollo.Location = new System.Drawing.Point(113, 129);
			this.chkPollo.Name = "chkPollo";
			this.chkPollo.Size = new System.Drawing.Size(54, 19);
			this.chkPollo.TabIndex = 43;
			this.chkPollo.Text = "P&ollo";
			this.chkPollo.UseVisualStyleBackColor = true;
			this.chkPollo.CheckedChanged += new System.EventHandler(this.ChkPolloCheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(18, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 15);
			this.label2.TabIndex = 49;
			this.label2.Text = "Jugador &2:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(18, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 15);
			this.label5.TabIndex = 47;
			this.label5.Text = "P&untos:";
			// 
			// cmbJugador2
			// 
			this.cmbJugador2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbJugador2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbJugador2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbJugador2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbJugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbJugador2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbJugador2.FormattingEnabled = true;
			this.cmbJugador2.Location = new System.Drawing.Point(89, 50);
			this.cmbJugador2.Name = "cmbJugador2";
			this.cmbJugador2.Size = new System.Drawing.Size(166, 23);
			this.cmbJugador2.TabIndex = 40;
			this.cmbJugador2.SelectedIndexChanged += new System.EventHandler(this.CmbJugador2SelectedIndexChanged);
			this.cmbJugador2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbJugador1KeyDown);
			// 
			// cmbJugador1
			// 
			this.cmbJugador1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbJugador1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbJugador1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbJugador1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbJugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbJugador1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbJugador1.FormattingEnabled = true;
			this.cmbJugador1.Location = new System.Drawing.Point(89, 24);
			this.cmbJugador1.Name = "cmbJugador1";
			this.cmbJugador1.Size = new System.Drawing.Size(166, 23);
			this.cmbJugador1.TabIndex = 38;
			this.cmbJugador1.SelectedIndexChanged += new System.EventHandler(this.CmbJugador1SelectedIndexChanged);
			this.cmbJugador1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbJugador1KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(18, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 15);
			this.label1.TabIndex = 39;
			this.label1.Text = "Jugador &1:";
			// 
			// frmJuegoNuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 353);
			this.Controls.Add(this.grpGeneral);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmJuegoNuevo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Registrar partido";
			this.grpGeneral.ResumeLayout(false);
			this.grpGeneral.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox grpGeneral;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ComboBox cmbPunt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtFecha;
		private System.Windows.Forms.TextBox txtComent;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox chkGanadora;
		private System.Windows.Forms.Button btnPart;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ListView lstPerdedores;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstGanadores;
		private System.Windows.Forms.Button btnPareja;
		private System.Windows.Forms.CheckBox chkRecul;
		private System.Windows.Forms.CheckBox chkPollo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbJugador2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbJugador1;
		private System.Windows.Forms.Label label1;
	}
}
