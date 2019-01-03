
namespace ControlDomino
{
	partial class frmActJuego
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActJuego));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nmPartidos = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.lstPartidos = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.eliminarCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmPartidos)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nmPartidos);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lstPartidos);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(699, 320);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Últimos partidos";
			// 
			// nmPartidos
			// 
			this.nmPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nmPartidos.Location = new System.Drawing.Point(121, 27);
			this.nmPartidos.Name = "nmPartidos";
			this.nmPartidos.Size = new System.Drawing.Size(39, 23);
			this.nmPartidos.TabIndex = 31;
			this.nmPartidos.ValueChanged += new System.EventHandler(this.NmPartidosValueChanged);
			this.nmPartidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmPartidosKeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 17);
			this.label1.TabIndex = 30;
			this.label1.Text = "Mostrar últimos             partidos";
			// 
			// lstPartidos
			// 
			this.lstPartidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3});
			this.lstPartidos.ContextMenuStrip = this.contextMenuStrip1;
			this.lstPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstPartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPartidos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lstPartidos.FullRowSelect = true;
			this.lstPartidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstPartidos.Location = new System.Drawing.Point(15, 59);
			this.lstPartidos.MultiSelect = false;
			this.lstPartidos.Name = "lstPartidos";
			this.lstPartidos.ShowItemToolTips = true;
			this.lstPartidos.Size = new System.Drawing.Size(671, 248);
			this.lstPartidos.SmallImageList = this.imgList;
			this.lstPartidos.TabIndex = 29;
			this.lstPartidos.UseCompatibleStateImageBehavior = false;
			this.lstPartidos.View = System.Windows.Forms.View.Details;
			this.lstPartidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmPartidosKeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Fecha";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Parejas";
			this.columnHeader2.Width = 470;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Puntuación";
			this.columnHeader3.Width = 78;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.eliminarCódigoToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
			// 
			// eliminarCódigoToolStripMenuItem
			// 
			this.eliminarCódigoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarCódigoToolStripMenuItem.Image")));
			this.eliminarCódigoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.eliminarCódigoToolStripMenuItem.Name = "eliminarCódigoToolStripMenuItem";
			this.eliminarCódigoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.eliminarCódigoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.eliminarCódigoToolStripMenuItem.Text = "&Eliminar";
			this.eliminarCódigoToolStripMenuItem.Click += new System.EventHandler(this.EliminarCódigoToolStripMenuItemClick);
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "ActionCenterCPL_2.ico");
			this.imgList.Images.SetKeyName(1, "Jen-Birdie-Happy-birdie.ico");
			this.imgList.Images.SetKeyName(2, "screw.ico");
			// 
			// frmActJuego
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 342);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmActJuego";
			this.Text = "Eliminar partidos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmPartidos)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.ToolStripMenuItem eliminarCódigoToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lstPartidos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nmPartidos;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
