using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sænk1
{
    class B
    {

        public B()
        {
            //constructor
        }


        public double KmPerHourToKnots(double kmPerHour)
        {
            return kmPerHour / 1.852; // Konverter km/t til knob: 1 km/t er lig med 1/1.852 knob
        }
    }
}