using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar3
{
    internal class SayiUretme
    {
        Random rnd = new Random();

        public int SayiTut(bool girilen)
        {
            int sonuc = 0, tekCiftKontrol;
            if (girilen == true)
            {
                do
                {
                    sonuc = rnd.Next(100);
                    tekCiftKontrol = sonuc % 2;
                } while (tekCiftKontrol!=1);
            }
            if (girilen == false)
            {
                do
                {
                    sonuc = rnd.Next(100);
                    tekCiftKontrol = sonuc % 2;
                } while (tekCiftKontrol != 0);
            }
            return sonuc;
        }
    }
}
