using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveOdevi
{
    internal class Tribonacci
    {
        public int Tribo(int sayi)
        {
            if (sayi == 0)
            {
                return 0;

            }
            if (sayi == 1 || sayi == 2)
            {
                return 1;

            }
            else
            {
                return Tribo(sayi - 1) + Tribo(sayi - 2) + Tribo(sayi - 3);
            }
        }
    }
}
