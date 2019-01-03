/*
 * Created by SharpDevelop.
 * User: FD
 * Date: 18/11/2014
 * Time: 9:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ControlDomino
{
	partial class frmActSonidos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox grpGeneral;
		private System.Windows.Forms.PictureBox imgListaNegra;
		private System.Windows.Forms.PictureBox imgProspectos;
		private System.Windows.Forms.PictureBox imgElite;
		private System.Windows.Forms.Label lblElite;
		private System.Windows.Forms.OpenFileDialog dlgAbrir;
		private System.Windows.Forms.Button btnListaNegraAct;
		private System.Windows.Forms.TextBox txtListaNegra;
		private System.Windows.Forms.Button btnProspAct;
		private System.Windows.Forms.TextBox txtProspectos;
		private System.Windows.Forms.Button btnEliteAct;
		private System.Windows.Forms.TextBox txtElite;
		private System.Windows.Forms.Label lblListaNegra;
		private System.Windows.Forms.Label lblProspectos;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.Button btnListaNegraDesc;
		private System.Windows.Forms.Button btnProspDesc;
		private System.Windows.Forms.Button btnEliteDesc;
		private System.Windows.Forms.ToolStripMenuItem guardarCambiosToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.Button btnListaNegraElim;
		private System.Windows.Forms.Button btnProspElim;
		private System.Windows.Forms.Button btnEliteElim;
		private System.Windows.Forms.SaveFileDialog dlgGuardar;
		private System.Windows.Forms.Button btnAcercaDeElim;
		private System.Windows.Forms.Button btnAcercaDeDesc;
		private System.Windows.Forms.Button btnAcercaDeAct;
		private System.Windows.Forms.TextBox txtAcercaDe;
		private System.Windows.Forms.Label lblAcercaDe;
		private System.Windows.Forms.PictureBox imgAcercaDe;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActSonidos));
			this.grpGeneral = new System.Windows.Forms.GroupBox();
			this.btnAcercaDeElim = new System.Windows.Forms.Button();
			this.btnAcercaDeDesc = new System.Windows.Forms.Button();
			this.btnAcercaDeAct = new System.Windows.Forms.Button();
			this.txtAcercaDe = new System.Windows.Forms.TextBox();
			this.lblAcercaDe = new System.Windows.Forms.Label();
			this.imgAcercaDe = new System.Windows.Forms.PictureBox();
			this.btnListaNegraElim = new System.Windows.Forms.Button();
			this.btnProspElim = new System.Windows.Forms.Button();
			this.btnEliteElim = new System.Windows.Forms.Button();
			this.btnListaNegraDesc = new System.Windows.Forms.Button();
			this.btnProspDesc = new System.Windows.Forms.Button();
			this.btnEliteDesc = new System.Windows.Forms.Button();
			this.btnListaNegraAct = new System.Windows.Forms.Button();
			this.txtListaNegra = new System.Windows.Forms.TextBox();
			this.btnProspAct = new System.Windows.Forms.Button();
			this.txtProspectos = new System.Windows.Forms.TextBox();
			this.btnEliteAct = new System.Windows.Forms.Button();
			this.txtElite = new System.Windows.Forms.TextBox();
			this.lblListaNegra = new System.Windows.Forms.Label();
			this.lblProspectos = new System.Windows.Forms.Label();
			this.lblElite = new System.Windows.Forms.Label();
			this.imgListaNegra = new System.Windows.Forms.PictureBox();
			this.imgProspectos = new System.Windows.Forms.PictureBox();
			this.imgElite = new System.Windows.Forms.PictureBox();
			this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.dlgGuardar = new System.Windows.Forms.SaveFileDialog();
			this.grpGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgAcercaDe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgListaNegra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgProspectos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgElite)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpGeneral
			// 
			this.grpGeneral.Controls.Add(this.btnAcercaDeElim);
			this.grpGeneral.Controls.Add(this.btnAcercaDeDesc);
			this.grpGeneral.Controls.Add(this.btnAcercaDeAct);
			this.grpGeneral.Controls.Add(this.txtAcercaDe);
			this.grpGeneral.Controls.Add(this.lblAcercaDe);
			this.grpGeneral.Controls.Add(this.imgAcercaDe);
			this.grpGeneral.Controls.Add(this.btnListaNegraElim);
			this.grpGeneral.Controls.Add(this.btnProspElim);
			this.grpGeneral.Controls.Add(this.btnEliteElim);
			this.grpGeneral.Controls.Add(this.btnListaNegraDesc);
			this.grpGeneral.Controls.Add(this.btnProspDesc);
			this.grpGeneral.Controls.Add(this.btnEliteDesc);
			this.grpGeneral.Controls.Add(this.btnListaNegraAct);
			this.grpGeneral.Controls.Add(this.txtListaNegra);
			this.grpGeneral.Controls.Add(this.btnProspAct);
			this.grpGeneral.Controls.Add(this.txtProspectos);
			this.grpGeneral.Controls.Add(this.btnEliteAct);
			this.grpGeneral.Controls.Add(this.txtElite);
			this.grpGeneral.Controls.Add(this.lblListaNegra);
			this.grpGeneral.Controls.Add(this.lblProspectos);
			this.grpGeneral.Controls.Add(this.lblElite);
			this.grpGeneral.Controls.Add(this.imgListaNegra);
			this.grpGeneral.Controls.Add(this.imgProspectos);
			this.grpGeneral.Controls.Add(this.imgElite);
			this.grpGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpGeneral.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.grpGeneral.Location = new System.Drawing.Point(12, 27);
			this.grpGeneral.Name = "grpGeneral";
			this.grpGeneral.Size = new System.Drawing.Size(522, 192);
			this.grpGeneral.TabIndex = 3;
			this.grpGeneral.TabStop = false;
			this.grpGeneral.Text = "Sonidos";
			// 
			// btnAcercaDeElim
			// 
			this.btnAcercaDeElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAcercaDeElim.Image = ((System.Drawing.Image)(resources.GetObject("btnAcercaDeElim.Image")));
			this.btnAcercaDeElim.Location = new System.Drawing.Point(470, 147);
			this.btnAcercaDeElim.Name = "btnAcercaDeElim";
			this.btnAcercaDeElim.Size = new System.Drawing.Size(38, 26);
			this.btnAcercaDeElim.TabIndex = 96;
			this.btnAcercaDeElim.UseVisualStyleBackColor = true;
			// 
			// btnAcercaDeDesc
			// 
			this.btnAcercaDeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAcercaDeDesc.Image = ((System.Drawing.Image)(resources.GetObject("btnAcercaDeDesc.Image")));
			this.btnAcercaDeDesc.Location = new System.Drawing.Point(429, 147);
			this.btnAcercaDeDesc.Name = "btnAcercaDeDesc";
			this.btnAcercaDeDesc.Size = new System.Drawing.Size(38, 26);
			this.btnAcercaDeDesc.TabIndex = 95;
			this.btnAcercaDeDesc.UseVisualStyleBackColor = true;
			this.btnAcercaDeDesc.Click += new System.EventHandler(this.BtnAcercaDeDescClick);
			// 
			// btnAcercaDeAct
			// 
			this.btnAcercaDeAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAcercaDeAct.Image = ((System.Drawing.Image)(resources.GetObject("btnAcercaDeAct.Image")));
			this.btnAcercaDeAct.Location = new System.Drawing.Point(388, 147);
			this.btnAcercaDeAct.Name = "btnAcercaDeAct";
			this.btnAcercaDeAct.Size = new System.Drawing.Size(38, 26);
			this.btnAcercaDeAct.TabIndex = 94;
			this.btnAcercaDeAct.UseVisualStyleBackColor = true;
			this.btnAcercaDeAct.Click += new System.EventHandler(this.BtnAcercaDeActClick);
			// 
			// txtAcercaDe
			// 
			this.txtAcercaDe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtAcercaDe.Enabled = false;
			this.txtAcercaDe.Location = new System.Drawing.Point(147, 150);
			this.txtAcercaDe.Name = "txtAcercaDe";
			this.txtAcercaDe.ReadOnly = true;
			this.txtAcercaDe.Size = new System.Drawing.Size(235, 23);
			this.txtAcercaDe.TabIndex = 93;
			// 
			// lblAcercaDe
			// 
			this.lblAcercaDe.AutoSize = true;
			this.lblAcercaDe.Location = new System.Drawing.Point(58, 153);
			this.lblAcercaDe.Name = "lblAcercaDe";
			this.lblAcercaDe.Size = new System.Drawing.Size(76, 17);
			this.lblAcercaDe.TabIndex = 92;
			this.lblAcercaDe.Text = "Acerca de:";
			// 
			// imgAcercaDe
			// 
			this.imgAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("imgAcercaDe.Image")));
			this.imgAcercaDe.Location = new System.Drawing.Point(17, 144);
			this.imgAcercaDe.Name = "imgAcercaDe";
			this.imgAcercaDe.Size = new System.Drawing.Size(35, 35);
			this.imgAcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgAcercaDe.TabIndex = 91;
			this.imgAcercaDe.TabStop = false;
			// 
			// btnListaNegraElim
			// 
			this.btnListaNegraElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListaNegraElim.Image = ((System.Drawing.Image)(resources.GetObject("btnListaNegraElim.Image")));
			this.btnListaNegraElim.Location = new System.Drawing.Point(470, 107);
			this.btnListaNegraElim.Name = "btnListaNegraElim";
			this.btnListaNegraElim.Size = new System.Drawing.Size(38, 26);
			this.btnListaNegraElim.TabIndex = 90;
			this.btnListaNegraElim.UseVisualStyleBackColor = true;
			// 
			// btnProspElim
			// 
			this.btnProspElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProspElim.Image = ((System.Drawing.Image)(resources.GetObject("btnProspElim.Image")));
			this.btnProspElim.Location = new System.Drawing.Point(471, 66);
			this.btnProspElim.Name = "btnProspElim";
			this.btnProspElim.Size = new System.Drawing.Size(38, 26);
			this.btnProspElim.TabIndex = 89;
			this.btnProspElim.UseVisualStyleBackColor = true;
			// 
			// btnEliteElim
			// 
			this.btnEliteElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliteElim.Image = ((System.Drawing.Image)(resources.GetObject("btnEliteElim.Image")));
			this.btnEliteElim.Location = new System.Drawing.Point(471, 25);
			this.btnEliteElim.Name = "btnEliteElim";
			this.btnEliteElim.Size = new System.Drawing.Size(38, 26);
			this.btnEliteElim.TabIndex = 88;
			this.btnEliteElim.UseVisualStyleBackColor = true;
			// 
			// btnListaNegraDesc
			// 
			this.btnListaNegraDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListaNegraDesc.Image = ((System.Drawing.Image)(resources.GetObject("btnListaNegraDesc.Image")));
			this.btnListaNegraDesc.Location = new System.Drawing.Point(429, 107);
			this.btnListaNegraDesc.Name = "btnListaNegraDesc";
			this.btnListaNegraDesc.Size = new System.Drawing.Size(38, 26);
			this.btnListaNegraDesc.TabIndex = 87;
			this.btnListaNegraDesc.UseVisualStyleBackColor = true;
			this.btnListaNegraDesc.Click += new System.EventHandler(this.BtnListaNegraDescClick);
			// 
			// btnProspDesc
			// 
			this.btnProspDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProspDesc.Image = ((System.Drawing.Image)(resources.GetObject("btnProspDesc.Image")));
			this.btnProspDesc.Location = new System.Drawing.Point(430, 66);
			this.btnProspDesc.Name = "btnProspDesc";
			this.btnProspDesc.Size = new System.Drawing.Size(38, 26);
			this.btnProspDesc.TabIndex = 86;
			this.btnProspDesc.UseVisualStyleBackColor = true;
			this.btnProspDesc.Click += new System.EventHandler(this.BtnProspDescClick);
			// 
			// btnEliteDesc
			// 
			this.btnEliteDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliteDesc.Image = ((System.Drawing.Image)(resources.GetObject("btnEliteDesc.Image")));
			this.btnEliteDesc.Location = new System.Drawing.Point(430, 25);
			this.btnEliteDesc.Name = "btnEliteDesc";
			this.btnEliteDesc.Size = new System.Drawing.Size(38, 26);
			this.btnEliteDesc.TabIndex = 85;
			this.btnEliteDesc.UseVisualStyleBackColor = true;
			this.btnEliteDesc.Click += new System.EventHandler(this.BtnEliteDescClick);
			// 
			// btnListaNegraAct
			// 
			this.btnListaNegraAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListaNegraAct.Image = ((System.Drawing.Image)(resources.GetObject("btnListaNegraAct.Image")));
			this.btnListaNegraAct.Location = new System.Drawing.Point(388, 107);
			this.btnListaNegraAct.Name = "btnListaNegraAct";
			this.btnListaNegraAct.Size = new System.Drawing.Size(38, 26);
			this.btnListaNegraAct.TabIndex = 84;
			this.btnListaNegraAct.UseVisualStyleBackColor = true;
			this.btnListaNegraAct.Click += new System.EventHandler(this.BtnListaNegraActClick);
			// 
			// txtListaNegra
			// 
			this.txtListaNegra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtListaNegra.Enabled = false;
			this.txtListaNegra.Location = new System.Drawing.Point(147, 110);
			this.txtListaNegra.Name = "txtListaNegra";
			this.txtListaNegra.ReadOnly = true;
			this.txtListaNegra.Size = new System.Drawing.Size(235, 23);
			this.txtListaNegra.TabIndex = 83;
			// 
			// btnProspAct
			// 
			this.btnProspAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProspAct.Image = ((System.Drawing.Image)(resources.GetObject("btnProspAct.Image")));
			this.btnProspAct.Location = new System.Drawing.Point(389, 66);
			this.btnProspAct.Name = "btnProspAct";
			this.btnProspAct.Size = new System.Drawing.Size(38, 26);
			this.btnProspAct.TabIndex = 82;
			this.btnProspAct.UseVisualStyleBackColor = true;
			this.btnProspAct.Click += new System.EventHandler(this.BtnProspActClick);
			// 
			// txtProspectos
			// 
			this.txtProspectos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtProspectos.Enabled = false;
			this.txtProspectos.Location = new System.Drawing.Point(148, 69);
			this.txtProspectos.Name = "txtProspectos";
			this.txtProspectos.ReadOnly = true;
			this.txtProspectos.Size = new System.Drawing.Size(235, 23);
			this.txtProspectos.TabIndex = 81;
			// 
			// btnEliteAct
			// 
			this.btnEliteAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliteAct.Image = ((System.Drawing.Image)(resources.GetObject("btnEliteAct.Image")));
			this.btnEliteAct.Location = new System.Drawing.Point(389, 25);
			this.btnEliteAct.Name = "btnEliteAct";
			this.btnEliteAct.Size = new System.Drawing.Size(38, 26);
			this.btnEliteAct.TabIndex = 80;
			this.btnEliteAct.UseVisualStyleBackColor = true;
			this.btnEliteAct.Click += new System.EventHandler(this.BtnEliteActClick);
			// 
			// txtElite
			// 
			this.txtElite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtElite.Enabled = false;
			this.txtElite.Location = new System.Drawing.Point(148, 28);
			this.txtElite.Name = "txtElite";
			this.txtElite.ReadOnly = true;
			this.txtElite.Size = new System.Drawing.Size(235, 23);
			this.txtElite.TabIndex = 79;
			// 
			// lblListaNegra
			// 
			this.lblListaNegra.AutoSize = true;
			this.lblListaNegra.Location = new System.Drawing.Point(58, 113);
			this.lblListaNegra.Name = "lblListaNegra";
			this.lblListaNegra.Size = new System.Drawing.Size(83, 17);
			this.lblListaNegra.TabIndex = 78;
			this.lblListaNegra.Text = "Lista negra:";
			// 
			// lblProspectos
			// 
			this.lblProspectos.AutoSize = true;
			this.lblProspectos.Location = new System.Drawing.Point(58, 72);
			this.lblProspectos.Name = "lblProspectos";
			this.lblProspectos.Size = new System.Drawing.Size(83, 17);
			this.lblProspectos.TabIndex = 77;
			this.lblProspectos.Text = "Prospectos:";
			// 
			// lblElite
			// 
			this.lblElite.AutoSize = true;
			this.lblElite.Location = new System.Drawing.Point(58, 31);
			this.lblElite.Name = "lblElite";
			this.lblElite.Size = new System.Drawing.Size(82, 17);
			this.lblElite.TabIndex = 76;
			this.lblElite.Text = "Grupo élite:";
			// 
			// imgListaNegra
			// 
			this.imgListaNegra.Image = ((System.Drawing.Image)(resources.GetObject("imgListaNegra.Image")));
			this.imgListaNegra.Location = new System.Drawing.Point(17, 104);
			this.imgListaNegra.Name = "imgListaNegra";
			this.imgListaNegra.Size = new System.Drawing.Size(35, 35);
			this.imgListaNegra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgListaNegra.TabIndex = 75;
			this.imgListaNegra.TabStop = false;
			// 
			// imgProspectos
			// 
			this.imgProspectos.Image = ((System.Drawing.Image)(resources.GetObject("imgProspectos.Image")));
			this.imgProspectos.Location = new System.Drawing.Point(17, 63);
			this.imgProspectos.Name = "imgProspectos";
			this.imgProspectos.Size = new System.Drawing.Size(35, 35);
			this.imgProspectos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgProspectos.TabIndex = 74;
			this.imgProspectos.TabStop = false;
			// 
			// imgElite
			// 
			this.imgElite.Image = ((System.Drawing.Image)(resources.GetObject("imgElite.Image")));
			this.imgElite.Location = new System.Drawing.Point(17, 22);
			this.imgElite.Name = "imgElite";
			this.imgElite.Size = new System.Drawing.Size(35, 35);
			this.imgElite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgElite.TabIndex = 73;
			this.imgElite.TabStop = false;
			// 
			// dlgAbrir
			// 
			this.dlgAbrir.Filter = "Archivos de música (*.mp3)|*.mp3";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(545, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.guardarCambiosToolStripMenuItem,
			this.toolStripMenuItem1,
			this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// guardarCambiosToolStripMenuItem
			// 
			this.guardarCambiosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarCambiosToolStripMenuItem.Image")));
			this.guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
			this.guardarCambiosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.guardarCambiosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.guardarCambiosToolStripMenuItem.Text = "&Guardar cambios";
			this.guardarCambiosToolStripMenuItem.Click += new System.EventHandler(this.GuardarCambiosToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.salirToolStripMenuItem.Text = "&Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "folder_green_backup.png");
			this.imgList.Images.SetKeyName(1, "button_blue_fastforward.png");
			// 
			// dlgGuardar
			// 
			this.dlgGuardar.Filter = "Archivos de música (*.mp3)|*.mp3";
			// 
			// frmActSonidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 233);
			this.Controls.Add(this.grpGeneral);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmActSonidos";
			this.Text = "Actualizar sonidos";
			this.grpGeneral.ResumeLayout(false);
			this.grpGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgAcercaDe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgListaNegra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgProspectos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgElite)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
