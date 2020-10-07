namespace cSharpIntroWinForms
{
	partial class frmPorukeBrojIndeksa
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
			this.label1 = new System.Windows.Forms.Label();
			this.lbPrimaoc = new System.Windows.Forms.Label();
			this.btnNovaPoruka = new System.Windows.Forms.Button();
			this.btnPrintaj = new System.Windows.Forms.Button();
			this.dgvPoruke = new System.Windows.Forms.DataGridView();
			this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
			this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Komunikacija sa:";
			// 
			// lbPrimaoc
			// 
			this.lbPrimaoc.AutoSize = true;
			this.lbPrimaoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPrimaoc.Location = new System.Drawing.Point(126, 13);
			this.lbPrimaoc.Name = "lbPrimaoc";
			this.lbPrimaoc.Size = new System.Drawing.Size(0, 20);
			this.lbPrimaoc.TabIndex = 1;
			// 
			// btnNovaPoruka
			// 
			this.btnNovaPoruka.Location = new System.Drawing.Point(366, 18);
			this.btnNovaPoruka.Name = "btnNovaPoruka";
			this.btnNovaPoruka.Size = new System.Drawing.Size(96, 23);
			this.btnNovaPoruka.TabIndex = 2;
			this.btnNovaPoruka.Text = "Nova poruka";
			this.btnNovaPoruka.UseVisualStyleBackColor = true;
			this.btnNovaPoruka.Click += new System.EventHandler(this.btnNovaPoruka_Click);
			// 
			// btnPrintaj
			// 
			this.btnPrintaj.Location = new System.Drawing.Point(366, 233);
			this.btnPrintaj.Name = "btnPrintaj";
			this.btnPrintaj.Size = new System.Drawing.Size(96, 23);
			this.btnPrintaj.TabIndex = 3;
			this.btnPrintaj.Text = "Printaj";
			this.btnPrintaj.UseVisualStyleBackColor = true;
			this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
			// 
			// dgvPoruke
			// 
			this.dgvPoruke.AllowUserToAddRows = false;
			this.dgvPoruke.AllowUserToDeleteRows = false;
			this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Sadrzaj,
            this.Slika,
            this.Brisi});
			this.dgvPoruke.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvPoruke.Location = new System.Drawing.Point(16, 55);
			this.dgvPoruke.Name = "dgvPoruke";
			this.dgvPoruke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPoruke.Size = new System.Drawing.Size(446, 167);
			this.dgvPoruke.TabIndex = 4;
			this.dgvPoruke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruke_CellContentClick);
			// 
			// Datum
			// 
			this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Datum.DataPropertyName = "Datum";
			this.Datum.HeaderText = "Datum";
			this.Datum.Name = "Datum";
			// 
			// Sadrzaj
			// 
			this.Sadrzaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Sadrzaj.DataPropertyName = "Sadrzaj";
			this.Sadrzaj.HeaderText = "Sadrzaj";
			this.Sadrzaj.Name = "Sadrzaj";
			// 
			// Slika
			// 
			this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Slika.DataPropertyName = "Slika";
			this.Slika.HeaderText = "Slika";
			this.Slika.Name = "Slika";
			// 
			// Brisi
			// 
			this.Brisi.HeaderText = "Briši";
			this.Brisi.Name = "Brisi";
			this.Brisi.Text = "Briši";
			this.Brisi.UseColumnTextForButtonValue = true;
			// 
			// frmPorukeBrojIndeksa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 268);
			this.Controls.Add(this.dgvPoruke);
			this.Controls.Add(this.btnPrintaj);
			this.Controls.Add(this.btnNovaPoruka);
			this.Controls.Add(this.lbPrimaoc);
			this.Controls.Add(this.label1);
			this.Name = "frmPorukeBrojIndeksa";
			this.Text = "Poruke";
			this.Load += new System.EventHandler(this.frmPorukeBrojIndeksa_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbPrimaoc;
		private System.Windows.Forms.Button btnNovaPoruka;
		private System.Windows.Forms.Button btnPrintaj;
		private System.Windows.Forms.DataGridView dgvPoruke;
		private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
		private System.Windows.Forms.DataGridViewImageColumn Slika;
		private System.Windows.Forms.DataGridViewButtonColumn Brisi;
	}
}