
namespace ControlDomino
{
	partial class frmActJug
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActJug));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.chkInactivo = new System.Windows.Forms.CheckBox();
			this.btnAvatar = new System.Windows.Forms.Button();
			this.imgAvatar = new System.Windows.Forms.PictureBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.eliminarCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbSexo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtCorreo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.chkInactivo);
			this.groupBox1.Controls.Add(this.btnAvatar);
			this.groupBox1.Controls.Add(this.imgAvatar);
			this.groupBox1.Controls.Add(this.btnSalir);
			this.groupBox1.Controls.Add(this.btnOk);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(342, 237);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Opciones";
			// 
			// cmbSexo
			// 
			this.cmbSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSexo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
									"M",
									"F"});
			this.cmbSexo.Location = new System.Drawing.Point(12, 87);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(54, 24);
			this.cmbSexo.TabIndex = 30;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 17);
			this.label1.TabIndex = 31;
			this.label1.Text = "Sexo:";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreo.Location = new System.Drawing.Point(12, 131);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(157, 21);
			this.txtCorreo.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 17);
			this.label3.TabIndex = 33;
			this.label3.Text = "Correo:";
			// 
			// chkInactivo
			// 
			this.chkInactivo.AutoSize = true;
			this.chkInactivo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkInactivo.Location = new System.Drawing.Point(12, 159);
			this.chkInactivo.Name = "chkInactivo";
			this.chkInactivo.Size = new System.Drawing.Size(75, 21);
			this.chkInactivo.TabIndex = 3;
			this.chkInactivo.Text = "Inactivo";
			this.chkInactivo.UseVisualStyleBackColor = true;
			// 
			// btnAvatar
			// 
			this.btnAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAvatar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAvatar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAvatar.Image = ((System.Drawing.Image)(resources.GetObject("btnAvatar.Image")));
			this.btnAvatar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAvatar.Location = new System.Drawing.Point(12, 27);
			this.btnAvatar.Name = "btnAvatar";
			this.btnAvatar.Size = new System.Drawing.Size(157, 37);
			this.btnAvatar.TabIndex = 0;
			this.btnAvatar.Text = "&Avatar";
			this.btnAvatar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAvatar.UseVisualStyleBackColor = true;
			this.btnAvatar.Click += new System.EventHandler(this.BtnAvatarClick);
			this.btnAvatar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnAvatarKeyPress);
			// 
			// imgAvatar
			// 
			this.imgAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.imgAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgAvatar.Location = new System.Drawing.Point(179, 27);
			this.imgAvatar.Name = "imgAvatar";
			this.imgAvatar.Size = new System.Drawing.Size(150, 150);
			this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgAvatar.TabIndex = 26;
			this.imgAvatar.TabStop = false;
			// 
			// btnSalir
			// 
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(203, 195);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(126, 26);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "&Cancelar";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			this.btnSalir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnAvatarKeyPress);
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
			this.btnOk.Location = new System.Drawing.Point(12, 195);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(114, 26);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "&Aceptar";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			this.btnOk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnAvatarKeyPress);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "silueta_m.png");
			this.imageList1.Images.SetKeyName(1, "silueta_f.png");
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.actualizarToolStripMenuItem,
									this.toolStripMenuItem1,
									this.eliminarCódigoToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(146, 54);
			// 
			// actualizarToolStripMenuItem
			// 
			this.actualizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarToolStripMenuItem.Image")));
			this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
			this.actualizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.actualizarToolStripMenuItem.Text = "&Actualizar";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
			// 
			// eliminarCódigoToolStripMenuItem
			// 
			this.eliminarCódigoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarCódigoToolStripMenuItem.Image")));
			this.eliminarCódigoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.eliminarCódigoToolStripMenuItem.Name = "eliminarCódigoToolStripMenuItem";
			this.eliminarCódigoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.eliminarCódigoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.eliminarCódigoToolStripMenuItem.Text = "&Eliminar";
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "imageres_1029.ico");
			// 
			// frmActJug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 258);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmActJug";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Actualizar jugador";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.CheckBox chkInactivo;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ToolStripMenuItem eliminarCódigoToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.OpenFileDialog dlgAbrir;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button btnAvatar;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.PictureBox imgAvatar;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
