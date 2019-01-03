
namespace ControlDomino
{
	partial class frmAcercaDe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
			this.imgAcercaDe = new System.Windows.Forms.PictureBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.txtHistCamb = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblDesarroll = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgAcercaDe)).BeginInit();
			this.SuspendLayout();
			// 
			// imgAcercaDe
			// 
			this.imgAcercaDe.BackColor = System.Drawing.Color.Transparent;
			this.imgAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("imgAcercaDe.Image")));
			this.imgAcercaDe.Location = new System.Drawing.Point(239, 12);
			this.imgAcercaDe.Name = "imgAcercaDe";
			this.imgAcercaDe.Size = new System.Drawing.Size(135, 102);
			this.imgAcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgAcercaDe.TabIndex = 0;
			this.imgAcercaDe.TabStop = false;
			this.imgAcercaDe.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.Color.Crimson;
			this.lblNombre.Location = new System.Drawing.Point(12, 7);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 18);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "DominARTE";
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.ForeColor = System.Drawing.Color.Green;
			this.lblVersion.Location = new System.Drawing.Point(12, 22);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(53, 18);
			this.lblVersion.TabIndex = 2;
			this.lblVersion.Text = "v3.0.1";
			// 
			// txtHistCamb
			// 
			this.txtHistCamb.BackColor = System.Drawing.Color.Black;
			this.txtHistCamb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtHistCamb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHistCamb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHistCamb.ForeColor = System.Drawing.Color.LimeGreen;
			this.txtHistCamb.Location = new System.Drawing.Point(12, 137);
			this.txtHistCamb.Multiline = true;
			this.txtHistCamb.Name = "txtHistCamb";
			this.txtHistCamb.ReadOnly = true;
			this.txtHistCamb.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtHistCamb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHistCamb.Size = new System.Drawing.Size(362, 116);
			this.txtHistCamb.TabIndex = 4;
			this.txtHistCamb.Text = resources.GetString("txtHistCamb.Text");
			this.txtHistCamb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmAcercaDeKeyPress);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(150, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "btnCerrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblDesarroll
			// 
			this.lblDesarroll.AutoEllipsis = true;
			this.lblDesarroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDesarroll.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDesarroll.Location = new System.Drawing.Point(12, 48);
			this.lblDesarroll.Name = "lblDesarroll";
			this.lblDesarroll.Size = new System.Drawing.Size(277, 110);
			this.lblDesarroll.TabIndex = 5;
			this.lblDesarroll.Text = "Desarrollado en C# TodoPoderoso\r\ncon .NET Framework 4.0\r\n(bien compilado sea su c" +
	"ódigo).\r\n\r\nFélix Daniel Batista (fdbatista@gmail.com)";
			// 
			// frmAcercaDe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(386, 265);
			this.Controls.Add(this.imgAcercaDe);
			this.Controls.Add(this.txtHistCamb);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblDesarroll);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAcercaDe";
			this.Text = "Acerca de DominArte";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcercaDeFormClosing);
			this.Click += new System.EventHandler(this.FrmAcercaDeClick);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAcercaDeKeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmAcercaDeKeyPress);
			((System.ComponentModel.ISupportInitialize)(this.imgAcercaDe)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label lblDesarroll;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtHistCamb;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.PictureBox imgAcercaDe;
	}
}
