using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceApplication.Classes.SharedModels
{
    public class Meer
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public List<IBoot> VerbodenBoten { get; set; }

        public Meer(int id, string naam, double prijs, List<IBoot> verbodenBoten)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
            VerbodenBoten = verbodenBoten;
        }

        public override string ToString()
        {
            return Naam + " Prijs: " + Prijs;
        }
    }
}
