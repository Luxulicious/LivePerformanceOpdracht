using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceApplication.Classes.SharedModels
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Naam { get; set; }
        public List<Huurcontract> Huurcontracten { get; set; }
        public bool IsAdmin { get; set; }

        public List<Huurcontract> GetHuurcontracten(int huurderId)
        {
            throw new NotImplementedException();
        }

        public bool AddHuurcontract(Huurcontract huurcontract)
        {
            throw new NotImplementedException();
        }


    }
}
