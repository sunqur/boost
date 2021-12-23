using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar3
{
    internal class Ideal
    {
        double k, ideal;

        public double Kilo(double boy, double kilo, double dogumYili, string cinsiyet)
        {

            double yas = DateTime.Now.Year - dogumYili;

            if (cinsiyet == "E" || cinsiyet == "e")
            {
                k = 0.9;
            }
            else if (cinsiyet == "K" || cinsiyet == "k")
            {
                k = 0.8;
            }
            else { k = 0; }

            ideal = (boy - 100 + yas / 10) * k;

            if (ideal == kilo)
            {
                Console.Write("Kilonuz ideal : " + ideal);
            }
            else if (ideal < kilo)
            {
                Console.WriteLine("Kilonuz ideal kilodan fazla : " + ideal + "  Sizin kilonuz : " + kilo);
            }
            else
            {
                Console.WriteLine("Kilonuz ideal kilonun altında : " + ideal + "  Sizin kilonuz : " + kilo);

            }
            return ideal;
        }
    }
}
