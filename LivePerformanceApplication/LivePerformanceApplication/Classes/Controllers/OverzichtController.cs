using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceApplication.Classes.SharedModels;

namespace LivePerformanceApplication.Classes.Controllers
{
    /// <summary>
    /// Alle logica van het Overzicht form staat hierin
    /// </summary>
    public class OverzichtController
    {
        /// <summary>
        /// Voegt een nieuw meer/vaargebied toe.
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="prijs"></param>
        /// <param name="boten"></param>
        /// <returns></returns>
        public bool AddMeer(string naam, double prijs, List<IBoot> boten)
        {
            return DatabaseManager.AddMeer(naam, prijs, boten);
        }

        /// <summary>
        /// Haalt alle huurcontracten op.
        /// </summary>
        /// <returns>test data</returns>
        public List<Huurcontract> GetHuurcontracten()
        {
            //Met testdata gedaan wegens database problemen...
            var huurcontracten = new List<Huurcontract>();
            var boten = new List<IBoot>();
            boten.Add(new Motorboot(0, "Motorbootje", 5.00, "kruiser", 10.25));
            var meren = new List<Meer>();
            meren.Add(new Meer(0, "Zoetermeer", 2.00, new List<IBoot>()));
            var artikel = new List<Artikel>();
            artikel.Add(new Artikel(0, "Roeispaan", 2.00));
            huurcontracten.Add(new Huurcontract(1, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), boten, meren,  artikel));
            return huurcontracten;
        }
    }
}
