namespace cSharpIntroWinForms.ISPIT_PRIII_04_09_2020
{
	partial class frmPretragaBrojIndeksa
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
			this.txtPretraga = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvKorisniciPredmeti = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.lbProsjek = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbSuma = new System.Windows.Forms.Label();
			this.btnSumiraj = new System.Windows.Forms.Button();
			this.txtN = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPredmeti)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPretraga
			// 
			this.txtPretraga.Location = new System.Drawing.Point(130, 12);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(344, 20);
			this.txtPretraga.TabIndex = 0;
			this.txtPretraga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Naziv predmeta:";
			// 
			// dgvKorisniciPredmeti
			// 
			this.dgvKorisniciPredmeti.AllowUserToAddRows = false;
			this.dgvKorisniciPredmeti.AllowUserToDeleteRows = false;
			this.dgvKorisniciPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKorisniciPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Poruke});
			this.dgvKorisniciPredmeti.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvKorisniciPredmeti.Location = new System.Drawing.Point(12, 38);
			this.dgvKorisniciPredmeti.Name = "dgvKorisniciPredmeti";
			this.dgvKorisniciPredmeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKorisniciPredmeti.Size = new System.Drawing.Size(462, 150);
			this.dgvKorisniciPredmeti.TabIndex = 2;
			this.dgvKorisniciPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisniciPredmeti_CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Prosjek prikazanih ocjena:";
			// 
			// lbProsjek
			// 
			this.lbProsjek.AutoSize = true;
			this.lbProsjek.Location = new System.Drawing.Point(158, 200);
			this.lbProsjek.Name = "lbProsjek";
			this.lbProsjek.Size = new System.Drawing.Size(0, 13);
			this.lbProsjek.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbSuma);
			this.groupBox1.Controls.Add(this.btnSumiraj);
			this.groupBox1.Controls.Add(this.txtN);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(230, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(244, 100);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Threading";
			// 
			// lbSuma
			// 
			this.lbSuma.AutoSize = true;
			this.lbSuma.Location = new System.Drawing.Point(6, 76);
			this.lbSuma.Name = "lbSuma";
			this.lbSuma.Size = new System.Drawing.Size(0, 13);
			this.lbSuma.TabIndex = 3;
			// 
			// btnSumiraj
			// 
			this.btnSumiraj.Location = new System.Drawing.Point(147, 18);
			this.btnSumiraj.Name = "btnSumiraj";
			this.btnSumiraj.Size = new System.Drawing.Size(91, 23);
			this.btnSumiraj.TabIndex = 2;
			this.btnSumiraj.Text = "Sumiraj";
			this.btnSumiraj.UseVisualStyleBackColor = true;
			this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
			// 
			// txtN
			// 
			this.txtN.Location = new System.Drawing.Point(7, 20);
			this.txtN.Name = "txtN";
			this.txtN.Size = new System.Drawing.Size(134, 20);
			this.txtN.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Suma:";
			// 
			// ImePrezime
			// 
			this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ImePrezime.DataPropertyName = "Korisnik";
			this.ImePrezime.HeaderText = "Ime i prezime";
			this.ImePrezime.Name = "ImePrezime";
			// 
			// Predmet
			// 
			this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Predmet.DataPropertyName = "Predmet";
			this.Predmet.HeaderText = "Predmet";
			this.Predmet.Name = "Predmet";
			// 
			// Datum
			// 
			this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Datum.DataPropertyName = "Datum";
			this.Datum.HeaderText = "Datum";
			this.Datum.Name = "Datum";
			// 
			// Ocjena
			// 
			this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ocjena.DataPropertyName = "Ocjena";
			this.Ocjena.HeaderText = "Ocjena";
			this.Ocjena.Name = "Ocjena";
			// 
			// Poruke
			// 
			this.Poruke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Poruke.HeaderText = "Poruke";
			this.Poruke.Name = "Poruke";
			this.Poruke.Text = "Poruke";
			this.Poruke.UseColumnTextForButtonValue = true;
			// 
			// frmPretragaBrojIndeksa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 316);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lbProsjek);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvKorisniciPredmeti);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPretraga);
			this.Name = "frmPretragaBrojIndeksa";
			this.Text = "Pretraga";
			this.Load += new System.EventHandler(this.frmPretragaBrojIndeksa_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPredmeti)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvKorisniciPredmeti;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbProsjek;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbSuma;
		private System.Windows.Forms.Button btnSumiraj;
		private System.Windows.Forms.TextBox txtN;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
		private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
		private System.Windows.Forms.DataGridViewButtonColumn Poruke;
	}
}