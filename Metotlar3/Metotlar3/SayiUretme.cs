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
        int sonuc=0;
        public int SayiTut(int girilen)
        {
            if (girilen==1)
            {
                int rastgele = rnd.Next(100);
                if (rastgele%2==1)
                {
                    sonuc = rastgele;
                }
            }
            else
            {
                int rastgele = rnd.Next(100);
                if (rastgele % 2 == 0)
                {
                    sonuc = rastgele;
                }
            }
            return sonuc;
        }
    }
}
