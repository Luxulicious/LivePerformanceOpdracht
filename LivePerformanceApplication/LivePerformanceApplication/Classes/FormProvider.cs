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
        /// <summary>
        /// Statische winkel die over de hele applicatie gebruikt eenmaal opgestart.
        /// </summary>
        public static Winkel winkel;

        /// <summary>
        /// Nodig voor propery Overzicht
        /// </summary>
        private static Overzicht _overzicht;

        /// <summary>
        /// Instantieert een nieuw Overzicht form als die nog niet bestaat.
        /// </summary>
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

        /// <summary>
        /// Nodig voor property huren 
        /// </summary>
        private static Huren _huren;

        /// <summary>
        /// Instantieert een nieuw Huren form als die nog niet bestaat.
        /// </summary>
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
