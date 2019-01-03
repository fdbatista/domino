
namespace ControlDomino
{
	partial class frmEditarParametros
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarParametros));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.nmVictoria = new System.Windows.Forms.NumericUpDown();
			this.nmInicioRec = new System.Windows.Forms.NumericUpDown();
			this.nmElo = new System.Windows.Forms.NumericUpDown();
			this.nmRecul = new System.Windows.Forms.NumericUpDown();
			this.nmPollona = new System.Windows.Forms.NumericUpDown();
			this.nmPartido = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmVictoria)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmInicioRec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmElo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmRecul)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmPollona)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmPartido)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSalir);
			this.groupBox1.Controls.Add(this.btnOk);
			this.groupBox1.Controls.Add(this.nmVictoria);
			this.groupBox1.Controls.Add(this.nmInicioRec);
			this.groupBox1.Controls.Add(this.nmElo);
			this.groupBox1.Controls.Add(this.nmRecul);
			this.groupBox1.Controls.Add(this.nmPollona);
			this.groupBox1.Controls.Add(this.nmPartido);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(265, 252);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Opciones";
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
			this.btnSalir.Location = new System.Drawing.Point(153, 209);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(97, 26);
			this.btnSalir.TabIndex = 13;
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
			this.btnOk.Location = new System.Drawing.Point(15, 209);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(97, 26);
			this.btnOk.TabIndex = 12;
			this.btnOk.Text = "&Aceptar";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// nmVictoria
			// 
			this.nmVictoria.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nmVictoria.Location = new System.Drawing.Point(168, 167);
			this.nmVictoria.Maximum = new decimal(new int[] {
									300,
									0,
									0,
									0});
			this.nmVictoria.Name = "nmVictoria";
			this.nmVictoria.Size = new System.Drawing.Size(82, 23);
			this.nmVictoria.TabIndex = 11;
			this.nmVictoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmPartidoKeyDown);
			// 
			// nmInicioRec
			// 
			this.nmInicioRec.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nmInicioRec.Location = new System.Drawing.Point(168, 138);
			this.nmInicioRec.Maximum = new decimal(new int[] {
									300,
									0,
									0,
									0});
			this.nmInicioRec.Name = "nmInicioRec";
			this.nmInicioRec.Size = new System.Drawing.Size(82, 23);
			this.nmInicioRec.TabIndex = 10;
			this.nmInicioRec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmPartidoKeyDown);
			// 
			// nmElo
			// 
			this.nmElo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nmElo.DecimalPlaces = 2;
			this.nmElo.Location = new System.Drawing.Point(168, 109);
			this.nmElo.Maximum = new decimal(new int[] {
									100000,
									0,
									0,
									0});
			this.nmElo.Name = "nmElo";
			this.nmElo.Size = new System.Drawing.Size(82, 23);
			this.nmElo.TabIndex = 9;
			this.nmElo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmPartidoKeyDown);
			// 
			// nmRecul
			// 
			this.nmRecul.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nmRecul.DecimalPlaces = 2;
			this.nmRecul.Location = new System.Drawing.Point(168, 80);
			this.nmRecul.Name = "nmRecul";
			this.nmRecul.Size = new System.Drawing.Size(82, 23);
			this.nmRecul.TabIndex = 8;
			this.nmRecul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmPartidoKeyDown);
			// 
			// nmPollona
			// 
			this.nmPollona.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nmPollona.DecimalPlaces = 2;
			this.nmPollona.Location = new System.Drawing.Point(168, 53);
			this.nmPollona.Name = "nmPollona";
			this.nmPollona.Size = new System.Drawing.Size(82, 23);
			this.nmPollona.TabIndex = 7;
			this.nmPollona.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmPartidoKeyDown);
			// 
			// nmPartido
			// 
			this.nmPartido.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nmPartido.DecimalPlaces = 2;
			this.nmPartido.Location = new System.Drawing.Point(168, 24);
			this.nmPartido.Name = "nmPartido";
			this.nmPartido.Size = new System.Drawing.Size(82, 23);
			this.nmPartido.TabIndex = 6;
			this.nmPartido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmPartidoKeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 169);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Puntuación de victoria:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(155, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Puntuación de reculillo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "ELO de nuevo jugador:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Puntos por reculillo:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Puntos por pollona:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Puntos por partido:";
			// 
			// frmEditarParametros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 276);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEditarParametros";
			this.Text = "Parámetros";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmVictoria)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmInicioRec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmElo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmRecul)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmPollona)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmPartido)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.NumericUpDown nmPartido;
		private System.Windows.Forms.NumericUpDown nmPollona;
		private System.Windows.Forms.NumericUpDown nmRecul;
		private System.Windows.Forms.NumericUpDown nmElo;
		private System.Windows.Forms.NumericUpDown nmInicioRec;
		private System.Windows.Forms.NumericUpDown nmVictoria;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
