using cSharpIntroWinForms.ISPIT_PRIII_04_09_2020;
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

namespace cSharpIntroWinForms
{
	public partial class frmPorukeBrojIndeksa : Form
	{
		private Korisnik korisnik;

		KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
		public bool edit { get; set; }
		public frmPorukeBrojIndeksa()
		{
			InitializeComponent();
			dgvPoruke.AutoGenerateColumns = false;
		}

		public frmPorukeBrojIndeksa(Korisnik korisnik):this()
		{
			this.korisnik = korisnik;
		}

		private void frmPorukeBrojIndeksa_Load(object sender, EventArgs e)
		{
			UcitajPodatke();
			lbPrimaoc.Text = korisnik.ToString();
		}

		private void UcitajPodatke()
		{
			try
			{
				dgvPoruke.DataSource = null;
				dgvPoruke.DataSource = korisnik.Poruke.ToList();
			}
			catch(Exception ex)
			{
				MboxHelper.PrikaziGresku(ex);
			}
		}

		private void btnPrintaj_Click(object sender, EventArgs e)
		{
			frmIzvjestaj forma = new frmIzvjestaj(korisnik);
			forma.ShowDialog();
		}

		private void btnNovaPoruka_Click(object sender, EventArgs e)
		{
			frmNovaPorukaBrojIndeksa forma = new frmNovaPorukaBrojIndeksa(korisnik);
			forma.ShowDialog();
			UcitajPodatke();
		}

		private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 3)
			{
				DialogResult response = MessageBox.Show("Da li želite izbrisati ovu poruku", "Delete",
					 MessageBoxButtons.YesNo,
					 MessageBoxIcon.Question,
					 MessageBoxDefaultButton.Button2);

				if (response == DialogResult.Yes)
				{

					korisnik.Poruke.RemoveAt(dgvPoruke.CurrentCell.RowIndex);
					konekcijaNaBazu.SaveChanges();
					UcitajPodatke();
				}
			}
			else
			{
				try
				{
					KorisniciPoruke poruka = dgvPoruke.SelectedRows[0].DataBoundItem as KorisniciPoruke;
					edit = true;
					frmNovaPorukaBrojIndeksa forma = new frmNovaPorukaBrojIndeksa(korisnik, poruka, edit);
					forma.ShowDialog();
				}
				catch(Exception ex)
				{
					MboxHelper.PrikaziGresku(ex);
				}

			}
		}
	}
}
