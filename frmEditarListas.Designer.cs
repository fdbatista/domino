
namespace ControlDomino
{
	partial class frmEditarListas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarListas));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.lstTorneos = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnOk);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(320, 68);
			this.groupBox1.TabIndex = 61;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Adicionar nuevo torneo";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(74, 28);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(142, 23);
			this.txtNombre.TabIndex = 62;
			this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNombreKeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(6, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 17);
			this.label5.TabIndex = 61;
			this.label5.Text = "Nombre:";
			// 
			// btnOk
			// 
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.Location = new System.Drawing.Point(222, 26);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(83, 26);
			this.btnOk.TabIndex = 62;
			this.btnOk.Text = "&Aceptar";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// lstTorneos
			// 
			this.lstTorneos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1});
			this.lstTorneos.ContextMenuStrip = this.contextMenuStrip1;
			this.lstTorneos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstTorneos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstTorneos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstTorneos.FullRowSelect = true;
			this.lstTorneos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstTorneos.Location = new System.Drawing.Point(12, 93);
			this.lstTorneos.MultiSelect = false;
			this.lstTorneos.Name = "lstTorneos";
			this.lstTorneos.ShowItemToolTips = true;
			this.lstTorneos.Size = new System.Drawing.Size(320, 159);
			this.lstTorneos.SmallImageList = this.imgList;
			this.lstTorneos.TabIndex = 64;
			this.lstTorneos.UseCompatibleStateImageBehavior = false;
			this.lstTorneos.View = System.Windows.Forms.View.Details;
			this.lstTorneos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstTorneosKeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Torneos";
			this.columnHeader1.Width = 279;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cambiarNombreToolStripMenuItem,
									this.eliminarTorneoToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(184, 70);
			// 
			// cambiarNombreToolStripMenuItem
			// 
			this.cambiarNombreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarNombreToolStripMenuItem.Image")));
			this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
			this.cambiarNombreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.cambiarNombreToolStripMenuItem.Text = "Cambiar nombre";
			this.cambiarNombreToolStripMenuItem.Click += new System.EventHandler(this.CambiarNombreToolStripMenuItemClick);
			// 
			// eliminarTorneoToolStripMenuItem
			// 
			this.eliminarTorneoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarTorneoToolStripMenuItem.Image")));
			this.eliminarTorneoToolStripMenuItem.Name = "eliminarTorneoToolStripMenuItem";
			this.eliminarTorneoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.eliminarTorneoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.eliminarTorneoToolStripMenuItem.Text = "&Eliminar";
			this.eliminarTorneoToolStripMenuItem.Click += new System.EventHandler(this.EliminarTorneoToolStripMenuItemClick);
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "bookmark_toolbar.ico");
			// 
			// frmEditarListas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 263);
			this.Controls.Add(this.lstTorneos);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEditarListas";
			this.Text = "Editar torneos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem;
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.ToolStripMenuItem eliminarTorneoToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstTorneos;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
