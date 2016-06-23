using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceApplication.Classes.SharedModels
{
    public class Artikel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }

        public Artikel(int id, string naam, double prijs)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return Naam + " Prijs: " + Prijs;
        }
    }
}
