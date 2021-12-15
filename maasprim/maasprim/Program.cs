using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maasprim
{
    class Program
    {
        static void Main(string[] args)
        {
            double maas = 2850.0;
            int prim;
            Console.WriteLine("Hoşgeldiniz... ");
            Console.WriteLine("--------------------- ");
            Console.WriteLine(" ");
            Console.Write("Toplam maaşı belirlemek için üretilen parça adedini giriniz : ");

            int adet = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < adet; i++)
            {
                if (adet == 1 || adet < 11)
                {
                    prim = 5;
                    maas += prim;
                }
                else if (adet == 11 || adet < 26)
                {
                    prim = 11;
                    maas += prim;
                }
                else if (adet == 26 || adet < 41)
                {
                    prim = 17;
                    maas += prim;
                }
                else if (adet >= 41)
                {
                    prim = 30;
                    maas += prim;
                }
                else
                {
                    Console.WriteLine("Yanlış değerler girilmiştir!!! ");
                }
                
            }
            Console.WriteLine("  ");

            Console.WriteLine("********************** ");

            Console.WriteLine("Primle beraber alınan maaş : " + maas);
            Console.ReadLine();
        }
    }
}
