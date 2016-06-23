﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceApplication.Classes.SharedModels
{
    public class Spierboot : IBoot
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public double Prijs { get; set; }

        public string SoortBoot { get; set; }
    }
}