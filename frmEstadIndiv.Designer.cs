
namespace ControlDomino
{
	partial class frmEstadIndiv
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadIndiv));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbTorneo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lst3 = new System.Windows.Forms.ListView();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.imgList1 = new System.Windows.Forms.ImageList(this.components);
			this.lst2 = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.cmbModo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lst1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbTorneo);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lst3);
			this.groupBox1.Controls.Add(this.lst2);
			this.groupBox1.Controls.Add(this.cmbModo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lst1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(10, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(803, 344);
			this.groupBox1.TabIndex = 3;
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
			this.cmbTorneo.Location = new System.Drawing.Point(77, 20);
			this.cmbTorneo.Name = "cmbTorneo";
			this.cmbTorneo.Size = new System.Drawing.Size(191, 24);
			this.cmbTorneo.TabIndex = 67;
			this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.CmbTorneoSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(13, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 68;
			this.label6.Text = "Torneo:";
			// 
			// lst3
			// 
			this.lst3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader5,
									this.columnHeader6});
			this.lst3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lst3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lst3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lst3.FullRowSelect = true;
			this.lst3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lst3.Location = new System.Drawing.Point(274, 83);
			this.lst3.MultiSelect = false;
			this.lst3.Name = "lst3";
			this.lst3.ShowItemToolTips = true;
			this.lst3.Size = new System.Drawing.Size(255, 248);
			this.lst3.SmallImageList = this.imgList1;
			this.lst3.TabIndex = 32;
			this.lst3.UseCompatibleStateImageBehavior = false;
			this.lst3.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Compañeros";
			this.columnHeader5.Width = 137;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Total";
			this.columnHeader6.Width = 97;
			// 
			// imgList1
			// 
			this.imgList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgList1.ImageSize = new System.Drawing.Size(32, 32);
			this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lst2
			// 
			this.lst2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader3,
									this.columnHeader4});
			this.lst2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lst2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lst2.FullRowSelect = true;
			this.lst2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lst2.Location = new System.Drawing.Point(535, 83);
			this.lst2.MultiSelect = false;
			this.lst2.Name = "lst2";
			this.lst2.ShowItemToolTips = true;
			this.lst2.Size = new System.Drawing.Size(255, 248);
			this.lst2.SmallImageList = this.imgList1;
			this.lst2.TabIndex = 31;
			this.lst2.UseCompatibleStateImageBehavior = false;
			this.lst2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Contrarios";
			this.columnHeader3.Width = 137;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Total";
			this.columnHeader4.Width = 97;
			// 
			// cmbModo
			// 
			this.cmbModo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbModo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbModo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbModo.FormattingEnabled = true;
			this.cmbModo.Items.AddRange(new object[] {
									"Partidos jugados",
									"Partidos ganados",
									"Partidos perdidos",
									"Pollos propinados",
									"Pollos recibidos",
									"Reculillos propinados",
									"Reculillos recibidos",
									"Diferencia G - P",
									"Mejores rachas",
									"Peores rachas",
									"Duelos individuales",
									"Ránking ELO"});
			this.cmbModo.Location = new System.Drawing.Point(77, 50);
			this.cmbModo.Name = "cmbModo";
			this.cmbModo.Size = new System.Drawing.Size(191, 24);
			this.cmbModo.TabIndex = 0;
			this.cmbModo.SelectedIndexChanged += new System.EventHandler(this.CmbModoSelectedIndexChanged);
			this.cmbModo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lst1KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 17);
			this.label1.TabIndex = 30;
			this.label1.Text = "Modo:";
			// 
			// lst1
			// 
			this.lst1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.lst1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lst1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lst1.FullRowSelect = true;
			this.lst1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lst1.Location = new System.Drawing.Point(13, 83);
			this.lst1.MultiSelect = false;
			this.lst1.Name = "lst1";
			this.lst1.ShowItemToolTips = true;
			this.lst1.Size = new System.Drawing.Size(255, 248);
			this.lst1.SmallImageList = this.imgList1;
			this.lst1.TabIndex = 29;
			this.lst1.UseCompatibleStateImageBehavior = false;
			this.lst1.View = System.Windows.Forms.View.Details;
			this.lst1.SelectedIndexChanged += new System.EventHandler(this.Lst1SelectedIndexChanged);
			this.lst1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lst1KeyPress);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Jugador";
			this.columnHeader1.Width = 137;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Total";
			this.columnHeader2.Width = 97;
			// 
			// frmEstadIndiv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(823, 365);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEstadIndiv";
			this.Text = "Estadísticas";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTorneo;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ListView lst3;
		private System.Windows.Forms.ImageList imgList1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ListView lst2;
		private System.Windows.Forms.ComboBox cmbModo;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lst1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
