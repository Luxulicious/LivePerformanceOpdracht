using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceApplication.Classes.SharedModels;

namespace LivePerformanceApplication.Classes.Controllers
{
    public class HurenController
    {
        public bool AddHuurcontract(string email, string naam, Huurcontract huurcontract)
        {
            return DatabaseManager.AddHuurcontract(email, naam, huurcontract);
        }
    }
}
