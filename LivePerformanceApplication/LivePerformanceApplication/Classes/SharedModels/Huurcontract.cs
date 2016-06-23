using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformanceApplication.Classes.SharedModels
{
    public class Huurcontract
    {
        public int Id { get; set; }
        public DateTime DatumVan { get; set; }
        public DateTime DatumTot { get; set; }
        public List<IBoot> Boten { get; set; }
        public List<Meer> Meren { get; set; }
        public List<Artikel> Artikelen { get; set; }

        public Huurcontract(int id, DateTime datumVan, DateTime datumTot, List<IBoot> boten, List<Meer> meren, List<Artikel> artikelen)
        {
            Id = id;
            DatumVan = datumVan;
            DatumTot = datumTot;
            Boten = boten;
            Meren = meren;
            Artikelen = artikelen;
        }

        public bool AddBoot(IBoot boot)
        {
            throw new NotImplementedException();
        }

        public bool AddArtikel(Artikel artikel)
        {
            throw new NotImplementedException();
        }

        public bool AddMeer(Meer meer)
        {
            throw new NotImplementedException();
        }

        public double BerekenPrijs()
        {
            throw new NotImplementedException();
        }

        public int BerekenAantalMeren(bool ijsselmeer, bool noordZee, double budget, List<IBoot> boten, List<Artikel> artikelen)
        {
            throw new NotImplementedException();
        }

        public float GenereerGevoelsTemperatuur(DateTime datumVan, DateTime datumTot)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string botenstring = string.Empty;
            foreach (var boot in Boten)
                botenstring += boot + " ";

            string merenstring = string.Empty;
            foreach (var meer in Meren)
                merenstring += meer + " ";

            string artikelenstring = string.Empty;
            foreach (var artikel in Artikelen)
                artikelenstring += artikel + " ";

            return "Datum: " + DatumVan + " - " + DatumTot + " Boten:" + botenstring + " Meren:" + merenstring + " Artikelen:" + artikelenstring;
        }
    }
}
