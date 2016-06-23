using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceApplication.Classes.SharedModels;

namespace LivePerformanceApplication.Classes.Controllers
{
    public class OverzichtController
    {
        public bool AddMeer(string naam, double prijs, List<IBoot> boten)
        {
            return DatabaseManager.AddMeer(naam, prijs, boten);
        }
    }
}
