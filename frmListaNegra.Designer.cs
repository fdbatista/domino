
namespace ControlDomino
{
	partial class frmListaNegra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaNegra));
			this.imgMini = new System.Windows.Forms.ImageList(this.components);
			this.imgOn = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.imgOff = new System.Windows.Forms.PictureBox();
			this.lstJugadores = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.cmbTorneo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgOn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgOff)).BeginInit();
			this.SuspendLayout();
			// 
			// imgMini
			// 
			this.imgMini.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgMini.ImageSize = new System.Drawing.Size(32, 32);
			this.imgMini.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imgOn
			// 
			this.imgOn.Image = ((System.Drawing.Image)(resources.GetObject("imgOn.Image")));
			this.imgOn.Location = new System.Drawing.Point(323, 105);
			this.imgOn.Name = "imgOn";
			this.imgOn.Size = new System.Drawing.Size(100, 100);
			this.imgOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgOn.TabIndex = 31;
			this.imgOn.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// imgOff
			// 
			this.imgOff.Image = ((System.Drawing.Image)(resources.GetObject("imgOff.Image")));
			this.imgOff.Location = new System.Drawing.Point(323, 105);
			this.imgOff.Name = "imgOff";
			this.imgOff.Size = new System.Drawing.Size(100, 100);
			this.imgOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgOff.TabIndex = 32;
			this.imgOff.TabStop = false;
			this.imgOff.Visible = false;
			// 
			// lstJugadores
			// 
			this.lstJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.lstJugadores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstJugadores.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstJugadores.FullRowSelect = true;
			this.lstJugadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstJugadores.Location = new System.Drawing.Point(12, 42);
			this.lstJugadores.MultiSelect = false;
			this.lstJugadores.Name = "lstJugadores";
			this.lstJugadores.ShowItemToolTips = true;
			this.lstJugadores.Size = new System.Drawing.Size(291, 227);
			this.lstJugadores.SmallImageList = this.imgMini;
			this.lstJugadores.TabIndex = 33;
			this.lstJugadores.UseCompatibleStateImageBehavior = false;
			this.lstJugadores.View = System.Windows.Forms.View.Details;
			this.lstJugadores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmListaNegraKeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Jugador";
			this.columnHeader1.Width = 208;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ELO";
			this.columnHeader2.Width = 62;
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
			this.cmbTorneo.Location = new System.Drawing.Point(71, 12);
			this.cmbTorneo.Name = "cmbTorneo";
			this.cmbTorneo.Size = new System.Drawing.Size(232, 24);
			this.cmbTorneo.TabIndex = 77;
			this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.CmbTorneoSelectedIndexChanged);
			this.cmbTorneo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmListaNegraKeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(12, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 78;
			this.label6.Text = "Torneo:";
			// 
			// frmListaNegra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(435, 281);
			this.Controls.Add(this.cmbTorneo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lstJugadores);
			this.Controls.Add(this.imgOff);
			this.Controls.Add(this.imgOn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmListaNegra";
			this.Text = "Lista negra";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaNegraFormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmListaNegraKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.imgOn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgOff)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTorneo;
		private System.Windows.Forms.PictureBox imgOff;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox imgOn;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstJugadores;
		private System.Windows.Forms.ImageList imgMini;
	}
}
