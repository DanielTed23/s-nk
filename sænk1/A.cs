using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sænk1
{
    class A
    {
        public static double KnotsToKmPerHour(double knots)
        {
            return knots * 1.852; // Konverter knob til km/t: 1 knob er lig med 1.852 km/t
        }
    }
}