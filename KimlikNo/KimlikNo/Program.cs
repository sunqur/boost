using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimlikNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(TcNoUret());

            Console.ReadKey();
        }

        static string TcNoUret()
        {
            string tc = "";
            Random rnd = new Random();
            tc += rnd.Next(1, 10);

            for (int i = 0; i < 8; i++)
            {
                tc += rnd.Next(10);
            }

            int tekToplam = Convert.ToInt32(tc[0].ToString()) +
                Convert.ToInt32(tc[2].ToString()) + Convert.ToInt32(tc[4].ToString()) +
                Convert.ToInt32(tc[6].ToString()) + Convert.ToInt32(tc[8].ToString());
            int ciftToplam = Convert.ToInt32(tc[0].ToString()) +
                Convert.ToInt32(tc[1].ToString()) + Convert.ToInt32(tc[3].ToString()) +
                Convert.ToInt32(tc[5].ToString()) + Convert.ToInt32(tc[7].ToString());

            int hane10 = (tekToplam * 7 - ciftToplam) % 10;
            tc += hane10;

            int ilk10HaneToplam = 0;
            for (int i = 0; i < tc.Length; i++)
            {
                ilk10HaneToplam += Convert.ToInt32(tc[i].ToString());
            }

            tc += ilk10HaneToplam % 10;
            return tc;
        }
    }
}
