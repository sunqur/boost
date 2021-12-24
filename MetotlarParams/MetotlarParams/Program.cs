using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarParams
{
    internal class Program
    {
        static int Toplam(params int[] sayilar)
        {
            if (sayilar.Length==0)
            {
                return 0;
            }
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Toplam());
            Console.WriteLine(Toplam(1,2,3,4,5));

            Console.ReadKey();
        }
    }
}
