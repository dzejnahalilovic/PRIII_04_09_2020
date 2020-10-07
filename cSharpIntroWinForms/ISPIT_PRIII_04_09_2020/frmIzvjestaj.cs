using cSharpIntroWinForms.ISPIT_PRIII_04_09_2020;
using Microsoft.Reporting.WinForms;
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
	public partial class frmIzvjestaj : Form
	{
		private Korisnik korisnik;

		public frmIzvjestaj()
		{
			InitializeComponent();
		}

		public frmIzvjestaj(Korisnik korisnik) : this()
		{
			this.korisnik = korisnik;
		}

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {

            if (korisnik != null)
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("ImePrezime", $"{korisnik.Ime} {korisnik.Prezime}"));



                DSPoruke.tblPorukeDataTable tbl = new DSPoruke.tblPorukeDataTable();
                int i = 1;

                List<object> list = new List<object>();

                foreach (var poruke in korisnik.Poruke)
                {

                    list.Add(new
                    {
                        Rb = i++,
                        Datum = poruke.Datum,
                        Sadrzaj = poruke.Sadrzaj,
                        Slika = poruke.Slika
                    });
                }



                ReportDataSource rds = new ReportDataSource();
                rds.Name = "Poruke";
                rds.Value = list;

                reportViewer1.LocalReport.SetParameters(rpc);
                reportViewer1.LocalReport.DataSources.Add(rds);
            }

            this.reportViewer1.RefreshReport();
        }
	}
}
