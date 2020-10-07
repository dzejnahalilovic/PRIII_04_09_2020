namespace cSharpIntroWinForms.ISPIT_PRIII_04_09_2020
{
	partial class frmNovaPorukaBrojIndeksa
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
			this.pbSlika = new System.Windows.Forms.PictureBox();
			this.txtPrimalac = new System.Windows.Forms.TextBox();
			this.btnSpasi = new System.Windows.Forms.Button();
			this.ofdUcitajSliku = new System.Windows.Forms.OpenFileDialog();
			this.err = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Primalac:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sadržaj:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(282, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Slika:";
			// 
			// txtSadrzaj
			// 
			this.txtSadrzaj.Location = new System.Drawing.Point(16, 119);
			this.txtSadrzaj.Name = "txtSadrzaj";
			this.txtSadrzaj.Size = new System.Drawing.Size(240, 146);
			this.txtSadrzaj.TabIndex = 4;
			this.txtSadrzaj.Text = "";
			// 
			// pbSlika
			// 
			this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbSlika.Location = new System.Drawing.Point(285, 49);
			this.pbSlika.Name = "pbSlika";
			this.pbSlika.Size = new System.Drawing.Size(175, 216);
			this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbSlika.TabIndex = 5;
			this.pbSlika.TabStop = false;
			this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
			// 
			// txtPrimalac
			// 
			this.txtPrimalac.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtPrimalac.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.txtPrimalac.Location = new System.Drawing.Point(16, 49);
			this.txtPrimalac.Name = "txtPrimalac";
			this.txtPrimalac.Size = new System.Drawing.Size(240, 20);
			this.txtPrimalac.TabIndex = 6;
			// 
			// btnSpasi
			// 
			this.btnSpasi.Location = new System.Drawing.Point(380, 271);
			this.btnSpasi.Name = "btnSpasi";
			this.btnSpasi.Size = new System.Drawing.Size(80, 23);
			this.btnSpasi.TabIndex = 7;
			this.btnSpasi.Text = "Spasi";
			this.btnSpasi.UseVisualStyleBackColor = true;
			this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
			// 
			// ofdUcitajSliku
			// 
			this.ofdUcitajSliku.FileName = "openFileDialog1";
			// 
			// err
			// 
			this.err.ContainerControl = this;
			// 
			// frmNovaPorukaBrojIndeksa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 313);
			this.Controls.Add(this.btnSpasi);
			this.Controls.Add(this.txtPrimalac);
			this.Controls.Add(this.pbSlika);
			this.Controls.Add(this.txtSadrzaj);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "frmNovaPorukaBrojIndeksa";
			this.Text = "Nova poruka";
			this.Load += new System.EventHandler(this.frmNovaPorukaBrojIndeksa_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox txtSadrzaj;
		private System.Windows.Forms.PictureBox pbSlika;
		private System.Windows.Forms.TextBox txtPrimalac;
		private System.Windows.Forms.Button btnSpasi;
		private System.Windows.Forms.OpenFileDialog ofdUcitajSliku;
		private System.Windows.Forms.ErrorProvider err;
	}
}