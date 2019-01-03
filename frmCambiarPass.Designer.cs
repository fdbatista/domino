
namespace ControlDomino
{
	partial class frmCambiarPass
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarPass));
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtPassAct = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassNuevo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassConf = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRestab = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(105, 114);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(86, 27);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnOk
			// 
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(12, 114);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(87, 27);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "&Aceptar";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// txtPassAct
			// 
			this.txtPassAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassAct.ForeColor = System.Drawing.Color.DarkGreen;
			this.txtPassAct.Location = new System.Drawing.Point(145, 15);
			this.txtPassAct.Name = "txtPassAct";
			this.txtPassAct.PasswordChar = '•';
			this.txtPassAct.Size = new System.Drawing.Size(136, 24);
			this.txtPassAct.TabIndex = 0;
			this.txtPassAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassActKeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(12, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Contraseña actual:";
			// 
			// txtPassNuevo
			// 
			this.txtPassNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassNuevo.ForeColor = System.Drawing.Color.DarkGreen;
			this.txtPassNuevo.Location = new System.Drawing.Point(145, 44);
			this.txtPassNuevo.Name = "txtPassNuevo";
			this.txtPassNuevo.PasswordChar = '•';
			this.txtPassNuevo.Size = new System.Drawing.Size(136, 24);
			this.txtPassNuevo.TabIndex = 1;
			this.txtPassNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassActKeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(12, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Contraseña nueva:";
			// 
			// txtPassConf
			// 
			this.txtPassConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassConf.ForeColor = System.Drawing.Color.DarkGreen;
			this.txtPassConf.Location = new System.Drawing.Point(145, 73);
			this.txtPassConf.Name = "txtPassConf";
			this.txtPassConf.PasswordChar = '•';
			this.txtPassConf.Size = new System.Drawing.Size(136, 24);
			this.txtPassConf.TabIndex = 2;
			this.txtPassConf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassActKeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(12, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Confirmación:";
			// 
			// btnRestab
			// 
			this.btnRestab.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRestab.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnRestab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestab.Location = new System.Drawing.Point(197, 114);
			this.btnRestab.Name = "btnRestab";
			this.btnRestab.Size = new System.Drawing.Size(84, 27);
			this.btnRestab.TabIndex = 5;
			this.btnRestab.Text = "&Limpiar";
			this.btnRestab.UseVisualStyleBackColor = true;
			this.btnRestab.Click += new System.EventHandler(this.BtnRestabClick);
			// 
			// frmCambiarPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 153);
			this.Controls.Add(this.btnRestab);
			this.Controls.Add(this.txtPassConf);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPassNuevo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtPassAct);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCambiarPass";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cambiar contraseña";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRestab;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassConf;
		private System.Windows.Forms.TextBox txtPassNuevo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassAct;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label1;
	}
}
