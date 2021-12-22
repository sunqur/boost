using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class daire
    {
    
        public double alan(double yaricap)
        {
            return Math.PI * Math.Pow(yaricap, 2);
        }
        public double cevre(double yaricap)
        {
            return Math.PI*2*yaricap;
        }

    }
}
