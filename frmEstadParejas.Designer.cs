
namespace ControlDomino
{
	partial class frmEstadParejas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadParejas));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbTorneo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbJugadores = new System.Windows.Forms.ComboBox();
			this.lst2 = new System.Windows.Forms.ListView();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.cmbModo = new System.Windows.Forms.ComboBox();
			this.lst1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.lblMostrarUltimos = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbTorneo);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cmbJugadores);
			this.groupBox1.Controls.Add(this.lst2);
			this.groupBox1.Controls.Add(this.cmbModo);
			this.groupBox1.Controls.Add(this.lst1);
			this.groupBox1.Controls.Add(this.lblMostrarUltimos);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(653, 311);
			this.groupBox1.TabIndex = 4;
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
			this.cmbTorneo.Location = new System.Drawing.Point(82, 19);
			this.cmbTorneo.Name = "cmbTorneo";
			this.cmbTorneo.Size = new System.Drawing.Size(242, 24);
			this.cmbTorneo.TabIndex = 69;
			this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.CmbTorneoSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(18, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 70;
			this.label6.Text = "Torneo:";
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
			this.cmbJugadores.Location = new System.Drawing.Point(496, 19);
			this.cmbJugadores.Name = "cmbJugadores";
			this.cmbJugadores.Size = new System.Drawing.Size(143, 24);
			this.cmbJugadores.TabIndex = 35;
			this.cmbJugadores.SelectedIndexChanged += new System.EventHandler(this.CmbJugadoresSelectedIndexChanged);
			// 
			// lst2
			// 
			this.lst2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader5,
									this.columnHeader6});
			this.lst2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lst2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lst2.FullRowSelect = true;
			this.lst2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lst2.Location = new System.Drawing.Point(330, 49);
			this.lst2.MultiSelect = false;
			this.lst2.Name = "lst2";
			this.lst2.ShowItemToolTips = true;
			this.lst2.Size = new System.Drawing.Size(309, 248);
			this.lst2.TabIndex = 32;
			this.lst2.UseCompatibleStateImageBehavior = false;
			this.lst2.View = System.Windows.Forms.View.Details;
			this.lst2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEstadParejasKeyDown);
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Contrarios";
			this.columnHeader5.Width = 229;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Total";
			this.columnHeader6.Width = 59;
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
									"Diferencia G - P"});
			this.cmbModo.Location = new System.Drawing.Point(330, 19);
			this.cmbModo.Name = "cmbModo";
			this.cmbModo.Size = new System.Drawing.Size(142, 24);
			this.cmbModo.TabIndex = 0;
			this.cmbModo.SelectedIndexChanged += new System.EventHandler(this.CmbModoSelectedIndexChanged);
			this.cmbModo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEstadParejasKeyDown);
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
			this.lst1.Location = new System.Drawing.Point(15, 49);
			this.lst1.MultiSelect = false;
			this.lst1.Name = "lst1";
			this.lst1.ShowItemToolTips = true;
			this.lst1.Size = new System.Drawing.Size(309, 248);
			this.lst1.TabIndex = 29;
			this.lst1.UseCompatibleStateImageBehavior = false;
			this.lst1.View = System.Windows.Forms.View.Details;
			this.lst1.SelectedIndexChanged += new System.EventHandler(this.Lst1SelectedIndexChanged);
			this.lst1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEstadParejasKeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Pareja";
			this.columnHeader1.Width = 229;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Total";
			this.columnHeader2.Width = 59;
			// 
			// lblMostrarUltimos
			// 
			this.lblMostrarUltimos.AutoSize = true;
			this.lblMostrarUltimos.Location = new System.Drawing.Point(473, 22);
			this.lblMostrarUltimos.Name = "lblMostrarUltimos";
			this.lblMostrarUltimos.Size = new System.Drawing.Size(24, 17);
			this.lblMostrarUltimos.TabIndex = 34;
			this.lblMostrarUltimos.Text = "de";
			// 
			// frmEstadParejas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 334);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEstadParejas";
			this.Text = "Por parejas";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEstadParejasKeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTorneo;
		private System.Windows.Forms.Label lblMostrarUltimos;
		private System.Windows.Forms.ComboBox cmbJugadores;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lst1;
		private System.Windows.Forms.ComboBox cmbModo;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ListView lst2;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
