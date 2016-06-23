using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceApplication.Classes.SharedModels;

namespace LivePerformanceApplication.Classes
{
    public class FormProvider
    {
        public static Winkel winkel = new Winkel();

        private static Overzicht _overzicht;

        public static Overzicht Overzicht
        {
            get
            {
                if (_overzicht == null)
                {
                    _overzicht = new Overzicht();
                }
                return _overzicht;
            }
        }
    }
}
