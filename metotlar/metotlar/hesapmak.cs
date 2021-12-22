using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class hesapmak
    {


        public double hesapla(double sayi1, double sayi2, string islem)
        {
            double sonuc = 0;

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
            }

            return sonuc;
        }




        //public double sayi1, sayi2;

        //public double toplam()
        //{
        //    return sayi1 + sayi2;
        //}
        //public double cikar()
        //{
        //    return sayi1 - sayi2;
        //}
        //public double carp()
        //{
        //    return sayi1 * sayi2;
        //}
        //public double bol()
        //{
        //    return sayi1 / sayi2;
        //}
    }
}
