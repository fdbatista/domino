
namespace ControlDomino
{
	partial class frmRecords
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecords));
			this.lstRes = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.cmbTorneo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstRes
			// 
			this.lstRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.lstRes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstRes.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstRes.FullRowSelect = true;
			this.lstRes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstRes.Location = new System.Drawing.Point(12, 50);
			this.lstRes.MultiSelect = false;
			this.lstRes.Name = "lstRes";
			this.lstRes.ShowItemToolTips = true;
			this.lstRes.Size = new System.Drawing.Size(658, 350);
			this.lstRes.SmallImageList = this.imgList;
			this.lstRes.TabIndex = 0;
			this.lstRes.UseCompatibleStateImageBehavior = false;
			this.lstRes.View = System.Windows.Forms.View.Details;
			this.lstRes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstResKeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Récord";
			this.columnHeader1.Width = 173;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Valor";
			this.columnHeader2.Width = 72;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Jugador";
			this.columnHeader3.Width = 88;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Fecha";
			this.columnHeader4.Width = 85;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Pareja";
			this.columnHeader5.Width = 99;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Contrarios";
			this.columnHeader6.Width = 135;
			// 
			// imgList
			// 
			this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgList.ImageSize = new System.Drawing.Size(36, 36);
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
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
			// frmRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 412);
			this.Controls.Add(this.cmbTorneo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lstRes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRecords";
			this.Text = "Récords";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTorneo;
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstRes;
	}
}
