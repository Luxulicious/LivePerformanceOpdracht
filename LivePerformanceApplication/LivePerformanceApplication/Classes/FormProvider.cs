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
        public static Winkel winkel;

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

        private static Huren _huren;

        public static Huren Huren
        {
            get
            {
                if (_huren == null)
                {
                    _huren = new Huren();
                }
                return _huren;
            }
        }
    }
}
