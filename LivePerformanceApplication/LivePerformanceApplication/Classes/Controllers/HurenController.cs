using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceApplication.Classes.SharedModels;

namespace LivePerformanceApplication.Classes.Controllers
{
    /// <summary>
    /// Alle logica van het Huren form staat hierin
    /// </summary>
    public class HurenController
    {
        /// <summary>
        /// Voegt een nieuw huurcontract toe
        /// </summary>
        /// <param name="email"></param>
        /// <param name="naam"></param>
        /// <param name="huurcontract"></param>
        /// <returns></returns>
        public bool AddHuurcontract(string email, string naam, Huurcontract huurcontract)
        {
            return DatabaseManager.AddHuurcontract(email, naam, huurcontract);
        }
    }
}
