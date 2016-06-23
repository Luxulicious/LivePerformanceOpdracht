using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceApplication.Classes.SharedModels
{
    public class Motorboot : IBoot
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public double Prijs { get; set; }

        public string SoortBoot { get; set; }

        public double Tankinhoud { get; set; }

        public Motorboot(int id, string naam, double prijs, string soortBoot, double tankinhoud)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
            SoortBoot = soortBoot;
            Tankinhoud = tankinhoud;
        }

        public float BerekenActieRadius(double tankInhoud)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Naam + " " + Prijs + " " + SoortBoot + " " + Tankinhoud;
        }
    }
}
