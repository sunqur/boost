using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveOdevi
{
    internal class AraToplam
    {

        public int AraTopla(int sayi1, int sayi2)
        {
            int sum = sayi1;
            if (sayi1 < sayi2)
            {
                sayi1++;
                return sum += AraTopla(sayi1, sayi2);
            }

            return sum;
        }

    }
}
