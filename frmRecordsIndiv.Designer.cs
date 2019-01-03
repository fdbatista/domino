
namespace ControlDomino
{
	partial class frmRecordsIndiv
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordsIndiv));
			this.lstJugadores = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.imgMini = new System.Windows.Forms.ImageList(this.components);
			this.lstRecords = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.cmbTorneo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstJugadores
			// 
			this.lstJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1});
			this.lstJugadores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstJugadores.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstJugadores.FullRowSelect = true;
			this.lstJugadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstJugadores.Location = new System.Drawing.Point(12, 46);
			this.lstJugadores.MultiSelect = false;
			this.lstJugadores.Name = "lstJugadores";
			this.lstJugadores.ShowItemToolTips = true;
			this.lstJugadores.Size = new System.Drawing.Size(215, 294);
			this.lstJugadores.SmallImageList = this.imgMini;
			this.lstJugadores.TabIndex = 0;
			this.lstJugadores.UseCompatibleStateImageBehavior = false;
			this.lstJugadores.View = System.Windows.Forms.View.Details;
			this.lstJugadores.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			this.lstJugadores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView1KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Jugadores";
			this.columnHeader1.Width = 192;
			// 
			// imgMini
			// 
			this.imgMini.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMini.ImageStream")));
			this.imgMini.TransparentColor = System.Drawing.Color.Transparent;
			this.imgMini.Images.SetKeyName(0, "ActionCenterCPL_2.ico");
			this.imgMini.Images.SetKeyName(1, "ActionCenterCPL_4.ico");
			// 
			// lstRecords
			// 
			this.lstRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7});
			this.lstRecords.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstRecords.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstRecords.FullRowSelect = true;
			this.lstRecords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstRecords.Location = new System.Drawing.Point(233, 46);
			this.lstRecords.MultiSelect = false;
			this.lstRecords.Name = "lstRecords";
			this.lstRecords.ShowItemToolTips = true;
			this.lstRecords.Size = new System.Drawing.Size(541, 294);
			this.lstRecords.SmallImageList = this.imgMini;
			this.lstRecords.TabIndex = 1;
			this.lstRecords.UseCompatibleStateImageBehavior = false;
			this.lstRecords.View = System.Windows.Forms.View.Details;
			this.lstRecords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView1KeyDown);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Récord";
			this.columnHeader2.Width = 140;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Valor";
			this.columnHeader3.Width = 70;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Fecha";
			this.columnHeader5.Width = 85;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Pareja";
			this.columnHeader6.Width = 105;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Contrarios";
			this.columnHeader7.Width = 135;
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
			this.cmbTorneo.Location = new System.Drawing.Point(70, 12);
			this.cmbTorneo.Name = "cmbTorneo";
			this.cmbTorneo.Size = new System.Drawing.Size(190, 24);
			this.cmbTorneo.TabIndex = 79;
			this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.CmbTorneoSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(11, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 80;
			this.label6.Text = "Torneo:";
			// 
			// frmRecordsIndiv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 351);
			this.Controls.Add(this.cmbTorneo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lstRecords);
			this.Controls.Add(this.lstJugadores);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRecordsIndiv";
			this.Text = "Récords individuales";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTorneo;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ListView lstRecords;
		private System.Windows.Forms.ImageList imgMini;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstJugadores;
	}
}
