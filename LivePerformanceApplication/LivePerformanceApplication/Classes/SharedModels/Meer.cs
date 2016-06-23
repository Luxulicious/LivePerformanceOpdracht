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
        public List<IBoot> VerbodenBoten { get; set; }
    }
}
