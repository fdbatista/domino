
namespace ControlDomino
{
	partial class frmParamsCorreo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParamsCorreo));
			this.grpGeneral = new System.Windows.Forms.GroupBox();
			this.chkAutenticar = new System.Windows.Forms.CheckBox();
			this.grpAutentic = new System.Windows.Forms.GroupBox();
			this.txtContrasenna = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.chkHTML = new System.Windows.Forms.CheckBox();
			this.txtRemit2 = new System.Windows.Forms.TextBox();
			this.txtRemit1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbPrioridad = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPuerto = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.chkSSL = new System.Windows.Forms.CheckBox();
			this.txtServidor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAsunto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkHabilitar = new System.Windows.Forms.CheckBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.grpGeneral.SuspendLayout();
			this.grpAutentic.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpGeneral
			// 
			this.grpGeneral.Controls.Add(this.chkAutenticar);
			this.grpGeneral.Controls.Add(this.grpAutentic);
			this.grpGeneral.Controls.Add(this.chkHTML);
			this.grpGeneral.Controls.Add(this.txtRemit2);
			this.grpGeneral.Controls.Add(this.txtRemit1);
			this.grpGeneral.Controls.Add(this.label5);
			this.grpGeneral.Controls.Add(this.cmbPrioridad);
			this.grpGeneral.Controls.Add(this.label4);
			this.grpGeneral.Controls.Add(this.txtPuerto);
			this.grpGeneral.Controls.Add(this.label3);
			this.grpGeneral.Controls.Add(this.chkSSL);
			this.grpGeneral.Controls.Add(this.txtServidor);
			this.grpGeneral.Controls.Add(this.label2);
			this.grpGeneral.Controls.Add(this.txtAsunto);
			this.grpGeneral.Controls.Add(this.label1);
			this.grpGeneral.Location = new System.Drawing.Point(12, 37);
			this.grpGeneral.Name = "grpGeneral";
			this.grpGeneral.Size = new System.Drawing.Size(331, 311);
			this.grpGeneral.TabIndex = 40;
			this.grpGeneral.TabStop = false;
			// 
			// chkAutenticar
			// 
			this.chkAutenticar.AutoSize = true;
			this.chkAutenticar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkAutenticar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkAutenticar.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAutenticar.Location = new System.Drawing.Point(16, 196);
			this.chkAutenticar.Name = "chkAutenticar";
			this.chkAutenticar.Size = new System.Drawing.Size(208, 19);
			this.chkAutenticar.TabIndex = 8;
			this.chkAutenticar.Text = "El &servidor requiere autenticación";
			this.chkAutenticar.UseVisualStyleBackColor = true;
			this.chkAutenticar.CheckedChanged += new System.EventHandler(this.ChkAutenticarCheckedChanged);
			// 
			// grpAutentic
			// 
			this.grpAutentic.Controls.Add(this.txtContrasenna);
			this.grpAutentic.Controls.Add(this.label8);
			this.grpAutentic.Controls.Add(this.txtUsuario);
			this.grpAutentic.Controls.Add(this.label9);
			this.grpAutentic.Enabled = false;
			this.grpAutentic.Location = new System.Drawing.Point(15, 215);
			this.grpAutentic.Name = "grpAutentic";
			this.grpAutentic.Size = new System.Drawing.Size(301, 80);
			this.grpAutentic.TabIndex = 53;
			this.grpAutentic.TabStop = false;
			// 
			// txtContrasenna
			// 
			this.txtContrasenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasenna.Location = new System.Drawing.Point(128, 45);
			this.txtContrasenna.Name = "txtContrasenna";
			this.txtContrasenna.PasswordChar = '|';
			this.txtContrasenna.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtContrasenna.Size = new System.Drawing.Size(155, 20);
			this.txtContrasenna.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(6, 50);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 15);
			this.label8.TabIndex = 45;
			this.label8.Text = "Contraseña:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(128, 19);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtUsuario.Size = new System.Drawing.Size(155, 20);
			this.txtUsuario.TabIndex = 9;
			this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRemitenteKeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(6, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(116, 15);
			this.label9.TabIndex = 41;
			this.label9.Text = "Nombre de usuario:";
			// 
			// chkHTML
			// 
			this.chkHTML.AutoSize = true;
			this.chkHTML.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkHTML.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHTML.Location = new System.Drawing.Point(121, 156);
			this.chkHTML.Name = "chkHTML";
			this.chkHTML.Size = new System.Drawing.Size(159, 19);
			this.chkHTML.TabIndex = 7;
			this.chkHTML.Text = "&Enviar en formato HTML";
			this.chkHTML.UseVisualStyleBackColor = true;
			// 
			// txtRemit2
			// 
			this.txtRemit2.Enabled = false;
			this.txtRemit2.Location = new System.Drawing.Point(218, 104);
			this.txtRemit2.Name = "txtRemit2";
			this.txtRemit2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRemit2.Size = new System.Drawing.Size(97, 20);
			this.txtRemit2.TabIndex = 51;
			// 
			// txtRemit1
			// 
			this.txtRemit1.Location = new System.Drawing.Point(121, 104);
			this.txtRemit1.Name = "txtRemit1";
			this.txtRemit1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRemit1.Size = new System.Drawing.Size(97, 20);
			this.txtRemit1.TabIndex = 5;
			this.txtRemit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRemitenteKeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(6, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 49;
			this.label5.Text = "Remitente:";
			// 
			// cmbPrioridad
			// 
			this.cmbPrioridad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbPrioridad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPrioridad.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.cmbPrioridad.FormattingEnabled = true;
			this.cmbPrioridad.Location = new System.Drawing.Point(121, 74);
			this.cmbPrioridad.Name = "cmbPrioridad";
			this.cmbPrioridad.Size = new System.Drawing.Size(97, 24);
			this.cmbPrioridad.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(6, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 15);
			this.label4.TabIndex = 47;
			this.label4.Text = "Prioridad:";
			// 
			// txtPuerto
			// 
			this.txtPuerto.Location = new System.Drawing.Point(121, 45);
			this.txtPuerto.Name = "txtPuerto";
			this.txtPuerto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPuerto.Size = new System.Drawing.Size(66, 20);
			this.txtPuerto.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(6, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 15);
			this.label3.TabIndex = 45;
			this.label3.Text = "Puerto:";
			// 
			// chkSSL
			// 
			this.chkSSL.AutoSize = true;
			this.chkSSL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkSSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkSSL.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkSSL.Location = new System.Drawing.Point(233, 45);
			this.chkSSL.Name = "chkSSL";
			this.chkSSL.Size = new System.Drawing.Size(78, 19);
			this.chkSSL.TabIndex = 2;
			this.chkSSL.Text = "&Usar SSL";
			this.chkSSL.UseVisualStyleBackColor = true;
			this.chkSSL.CheckedChanged += new System.EventHandler(this.ChkSSLCheckedChanged);
			// 
			// txtServidor
			// 
			this.txtServidor.Location = new System.Drawing.Point(121, 19);
			this.txtServidor.Name = "txtServidor";
			this.txtServidor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtServidor.Size = new System.Drawing.Size(195, 20);
			this.txtServidor.TabIndex = 1;
			this.txtServidor.TextChanged += new System.EventHandler(this.TxtServidorTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(6, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 15);
			this.label2.TabIndex = 41;
			this.label2.Text = "Servidor de correo:";
			// 
			// txtAsunto
			// 
			this.txtAsunto.Location = new System.Drawing.Point(121, 130);
			this.txtAsunto.Name = "txtAsunto";
			this.txtAsunto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAsunto.Size = new System.Drawing.Size(195, 20);
			this.txtAsunto.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(6, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 15);
			this.label1.TabIndex = 39;
			this.label1.Text = "Asunto:";
			// 
			// chkHabilitar
			// 
			this.chkHabilitar.AutoSize = true;
			this.chkHabilitar.Checked = true;
			this.chkHabilitar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkHabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkHabilitar.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHabilitar.Location = new System.Drawing.Point(12, 12);
			this.chkHabilitar.Name = "chkHabilitar";
			this.chkHabilitar.Size = new System.Drawing.Size(201, 19);
			this.chkHabilitar.TabIndex = 0;
			this.chkHabilitar.Text = "&Habilitar notificaciones al correo";
			this.chkHabilitar.UseVisualStyleBackColor = true;
			this.chkHabilitar.CheckedChanged += new System.EventHandler(this.ChkHabilitarCheckedChanged);
			this.chkHabilitar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChkHabilitarKeyDown);
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
			this.btnSalir.Location = new System.Drawing.Point(246, 356);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(97, 31);
			this.btnSalir.TabIndex = 42;
			this.btnSalir.Text = "&Cancelar";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			this.btnSalir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChkHabilitarKeyDown);
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
			this.btnOk.Location = new System.Drawing.Point(12, 356);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(97, 31);
			this.btnOk.TabIndex = 41;
			this.btnOk.Text = "&Aceptar";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			this.btnOk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChkHabilitarKeyDown);
			// 
			// frmParamsCorreo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 399);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.chkHabilitar);
			this.Controls.Add(this.grpGeneral);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmParamsCorreo";
			this.Text = "Notificaciones por correo";
			this.grpGeneral.ResumeLayout(false);
			this.grpGeneral.PerformLayout();
			this.grpAutentic.ResumeLayout(false);
			this.grpAutentic.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtContrasenna;
		private System.Windows.Forms.GroupBox grpAutentic;
		private System.Windows.Forms.CheckBox chkAutenticar;
		private System.Windows.Forms.CheckBox chkHTML;
		private System.Windows.Forms.TextBox txtRemit2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtRemit1;
		private System.Windows.Forms.ComboBox cmbPrioridad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtServidor;
		private System.Windows.Forms.CheckBox chkSSL;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPuerto;
		private System.Windows.Forms.TextBox txtAsunto;
		private System.Windows.Forms.CheckBox chkHabilitar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpGeneral;
	}
}
