using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar3
{
    internal class HacimHesaplama
    {
        public double Hacim(double kenar1, double kenar2, double kenar3)
        {
            return kenar1 * kenar2 * kenar3;
        }

        public double Hacim( int kenar)
        {
            return Math.Pow(kenar, 3);
        }
        public double Hacim(double yaricap)
        {
            return Math.PI * Math.Pow(yaricap, 3) * 4 / 3;
        }

        public double Hacim(double yukseklik,double yaricap)
        {
            return Math.PI * Math.Pow(yaricap, 2) * yukseklik;
        }
    }
}
