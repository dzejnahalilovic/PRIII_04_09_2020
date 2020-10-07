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

namespace cSharpIntroWinForms.ISPIT_PRIII_04_09_2020
{
	public partial class frmPretragaBrojIndeksa : Form
	{
		KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
		public frmPretragaBrojIndeksa()
		{
			InitializeComponent();
			dgvKorisniciPredmeti.AutoGenerateColumns = false;
		}

		private void frmPretragaBrojIndeksa_Load(object sender, EventArgs e)
		{
			UcitajPodatke();
		}

		private void UcitajPodatke(List<KorisniciPredmeti> rezultat = null)
		{
			try
			{
				dgvKorisniciPredmeti.DataSource = null;
				dgvKorisniciPredmeti.DataSource = rezultat ?? konekcijaNaBazu.KorisniciPredmeti.ToList();

				double ocjena = 0;
				int brojac = 0;

				if (rezultat == null)
				{
					foreach (var r in konekcijaNaBazu.KorisniciPredmeti)
					{
						ocjena += r.Ocjena;
						brojac++;
					}
				}
				else
				{
					foreach (var r in rezultat)
					{
						ocjena += r.Ocjena;
						brojac++;
					}
				}
				lbProsjek.Text = (ocjena / brojac).ToString();
			}
			catch(Exception ex)
			{
				MboxHelper.PrikaziGresku(ex);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string filter = txtPretraga.Text.ToLower();
			List<KorisniciPredmeti> rezultat = new List<KorisniciPredmeti>();
			foreach (var r in konekcijaNaBazu.KorisniciPredmeti)
			{
				if (r.Predmet.Naziv.ToLower().Contains(filter))
					rezultat.Add(r);


			}
			UcitajPodatke(rezultat);
		}

		private void btnSumiraj_Click(object sender, EventArgs e)
		{
			var n = int.Parse(txtN.Text);
			var suma = 0;
			var sumaN = Task.Run(() =>
			{
				for (int i = 0; i <= n; i++)
				{
					suma += i;
				}
			});
			var cekanje = sumaN.GetAwaiter();
			cekanje.OnCompleted(() =>
			{
				lbSuma.Text = suma.ToString();
			});
		}

		private void dgvKorisniciPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Korisnik korisnik = dgvKorisniciPredmeti.CurrentRow.Cells[0].Value as Korisnik;
			if (e.ColumnIndex == 4)
			{
				frmPorukeBrojIndeksa forma = new frmPorukeBrojIndeksa(korisnik);
				forma.ShowDialog();
			}
		}
	}
}
