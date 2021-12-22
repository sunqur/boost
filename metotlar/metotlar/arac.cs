using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class arac
    {
        // yol = hız * zaman
        public double yol,  zaman;
        public void metot1()
        {
            Console.WriteLine(yol/zaman);
        }

        public void metot2(double x, double t)
        {
            Console.WriteLine(x/t);
        }

        public double metot3()
        {
            return  yol / zaman;
        }

        public double metot4(double x, double t)
        {
            return  x/ t;
        }

    }
}
