using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceApplication.Classes.SharedModels
{
    public interface IBoot
    {
        int Id { get; set; }
        string Naam { get; set; }
        string SoortBoot { get; set; }
        double Prijs { get; set; }
    }
}
