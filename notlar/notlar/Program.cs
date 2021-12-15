using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz...");
            Console.WriteLine("------------------");
            Console.WriteLine("1. sınavın notu");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. sınavın notu");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------");
            double ort = (not1 + not2) / 2;
            if (ort>=0 && ort<45)
            {
                Console.WriteLine("Başarısız");
                Console.WriteLine("******************");
                Console.WriteLine("Ortalamanız : "+ort);

            }
            else if (ort >= 45 && ort < 55)
            {
                Console.WriteLine("geçer");
                Console.WriteLine("******************");
                Console.WriteLine("Ortalamanız : " + ort);

            }
            else if (ort >= 55 && ort < 70)
            {
                Console.WriteLine("Orta");
                Console.WriteLine("******************");
                Console.WriteLine("Ortalamanız : " + ort);
            }
            else if (ort >= 70 && ort < 85)
            {
                Console.WriteLine("iyi");
                Console.WriteLine("******************");
                Console.WriteLine("Ortalamanız : " + ort);
            }
            else if (ort >= 85 && ort < 100)
            {
                Console.WriteLine("Çok iyi");
                Console.WriteLine("******************");
                Console.WriteLine("Ortalamanız : " + ort);
            }
            else
            {
                Console.WriteLine("Yanlış değerler girildi!!!");
            }
            Console.ReadLine();
        }
    }
}
