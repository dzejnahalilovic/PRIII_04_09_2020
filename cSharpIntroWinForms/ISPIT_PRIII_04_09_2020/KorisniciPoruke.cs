using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.ISPIT_PRIII_04_09_2020
{
	public class KorisniciPoruke
	{
		public int Id { get; set; }
		public virtual Korisnik Primaoc { get; set; }
		public string Datum { get; set; }
		public string Sadrzaj { get; set; }
		public byte[] Slika { get; set; }
	}
}
