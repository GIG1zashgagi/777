using System;
using System.Collections.Generic;

namespace GalaxiesDebugDemo
{
    public class Galaxy
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double DistanceLightYears { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Type}) - {DistanceLightYears} св. лет";
        }
    }
}