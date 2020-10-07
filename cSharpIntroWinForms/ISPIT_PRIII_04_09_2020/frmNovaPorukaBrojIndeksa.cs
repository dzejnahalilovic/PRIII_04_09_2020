using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace cSharpIntroWinForms.ISPIT_PRIII_04_09_2020
{
	public partial class frmNovaPorukaBrojIndeksa : Form
	{
		private Korisnik korisnik;

		KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
		private KorisniciPoruke poruka;
		private bool edit;

		public frmNovaPorukaBrojIndeksa()
		{
			InitializeComponent();
		}

		public frmNovaPorukaBrojIndeksa(Korisnik korisnik) : this()
		{
			this.korisnik = korisnik;
		}

		public frmNovaPorukaBrojIndeksa(Korisnik korisnik, KorisniciPoruke poruka, bool edit) : this(korisnik)
		{
			this.poruka = poruka;
			this.edit = edit;
			UcitajPoruku();
		}

		private void UcitajPoruku()
		{
			foreach (var p in korisnik.Poruke)
			{
				if (p.Id == poruka.Id)
				{
					txtSadrzaj.Text = poruka.Sadrzaj;
					txtPrimalac.Text = poruka.Primaoc.ToString();
					pbSlika.Image = ImageHelper.FromByteToImage(poruka.Slika);
				}
			}
		}

		private void frmNovaPorukaBrojIndeksa_Load(object sender, EventArgs e)
		{
			txtPrimalac.Text = korisnik.ToString();
		}

		private void btnSpasi_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtSadrzaj.Text))
			{
				err.SetError(txtSadrzaj, "Obavezan unos!");
				return;
			}
			if (!edit)
			{
				KorisniciPoruke novaPoruka = new KorisniciPoruke();
				novaPoruka.Sadrzaj = txtSadrzaj.Text;
				novaPoruka.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
				novaPoruka.Datum = DateTime.Now.ToString();
				korisnik.Poruke.Add(novaPoruka);
				konekcijaNaBazu.SaveChanges();
			}
			else
			{
				foreach (var p in korisnik.Poruke)
				{

					poruka.Sadrzaj = txtSadrzaj.Text;
					pbSlika.Image = ImageHelper.FromByteToImage(poruka.Slika);
					konekcijaNaBazu.Entry(poruka).State = EntityState.Modified;
					konekcijaNaBazu.SaveChanges();

				}

			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void pbSlika_Click(object sender, EventArgs e)
		{
			try
			{
				if (ofdUcitajSliku.ShowDialog() == DialogResult.OK)
				{
					string putanjaDoSlike = ofdUcitajSliku.FileName;
					Image slika = Image.FromFile(putanjaDoSlike);
					pbSlika.Image = slika;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Greska -> {ex.Message}");
			}
		}
	}
}
