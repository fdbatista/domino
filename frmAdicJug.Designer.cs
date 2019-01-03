
namespace ControlDomino
{
	partial class frmAdicJug
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicJug));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAvatar = new System.Windows.Forms.Button();
			this.imgAvatar = new System.Windows.Forms.PictureBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cambiarnombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCorreo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbSexo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnAvatar);
			this.groupBox1.Controls.Add(this.imgAvatar);
			this.groupBox1.Controls.Add(this.btnSalir);
			this.groupBox1.Controls.Add(this.btnOk);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(258, 266);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Adicionar jugador";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(87, 56);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(155, 23);
			this.txtCorreo.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 17);
			this.label3.TabIndex = 31;
			this.label3.Text = "Correo:";
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
			this.cmbSexo.Location = new System.Drawing.Point(87, 87);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(71, 24);
			this.cmbSexo.TabIndex = 2;
			this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.CmbSexoSelectedIndexChanged);
			this.cmbSexo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNombreKeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 17);
			this.label1.TabIndex = 29;
			this.label1.Text = "Sexo:";
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
			this.btnAvatar.Location = new System.Drawing.Point(16, 129);
			this.btnAvatar.Name = "btnAvatar";
			this.btnAvatar.Size = new System.Drawing.Size(97, 38);
			this.btnAvatar.TabIndex = 3;
			this.btnAvatar.Text = "A&vatar";
			this.btnAvatar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAvatar.UseVisualStyleBackColor = true;
			this.btnAvatar.Click += new System.EventHandler(this.BtnAvatarClick);
			// 
			// imgAvatar
			// 
			this.imgAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.imgAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgAvatar.Location = new System.Drawing.Point(122, 129);
			this.imgAvatar.Name = "imgAvatar";
			this.imgAvatar.Size = new System.Drawing.Size(120, 120);
			this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
			this.btnSalir.Location = new System.Drawing.Point(16, 223);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(97, 26);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "&Cancelar";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
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
			this.btnOk.Location = new System.Drawing.Point(16, 181);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(97, 26);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "&Aceptar";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(87, 26);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(155, 23);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNombreKeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 17);
			this.label2.TabIndex = 24;
			this.label2.Text = "Nombre:";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "silueta_m.png");
			this.imageList1.Images.SetKeyName(1, "silueta_f.png");
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(285, 22);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new System.Drawing.Size(303, 256);
			this.listView1.SmallImageList = this.imageList2;
			this.listView1.TabIndex = 6;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNombreKeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Jugadores";
			this.columnHeader1.Width = 272;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cambiarnombreToolStripMenuItem,
									this.actualizarToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(184, 70);
			// 
			// cambiarnombreToolStripMenuItem
			// 
			this.cambiarnombreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarnombreToolStripMenuItem.Image")));
			this.cambiarnombreToolStripMenuItem.Name = "cambiarnombreToolStripMenuItem";
			this.cambiarnombreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.cambiarnombreToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.cambiarnombreToolStripMenuItem.Text = "Cambiar &nombre";
			this.cambiarnombreToolStripMenuItem.Click += new System.EventHandler(this.CambiarnombreToolStripMenuItemClick);
			// 
			// actualizarToolStripMenuItem
			// 
			this.actualizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarToolStripMenuItem.Image")));
			this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
			this.actualizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.actualizarToolStripMenuItem.Text = "&Actualizar";
			this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.ActualizarToolStripMenuItemClick);
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "imageres_1029.ico");
			// 
			// frmAdicJug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 291);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAdicJug";
			this.Text = "Actualizar jugadores";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.ToolStripMenuItem cambiarnombreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.OpenFileDialog dlgAbrir;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button btnAvatar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.PictureBox imgAvatar;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
