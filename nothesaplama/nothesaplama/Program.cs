using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nothesaplama
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
            if (ort == 0)
            {
                ort = 1;
            }
            else if (ort >= 1 && ort < 45)
            {
                ort = 2;
            }
            else if (ort >= 45 && ort < 55)
            {
                ort = 3;
            }
            else if (ort >= 55 && ort < 70)
            {
                ort = 4;
            }
            else if (ort >= 70 && ort < 85)
            {
                ort = 5;
            }
            else if (ort >= 85 && ort < 100)
            {
                ort = 6;
            }
            else
            {
                Console.WriteLine("Yanlış değerler girdiniz!!");
            }
            switch (ort)
            {
                case 1: Console.WriteLine("zayıf"); break;
                case 2: Console.WriteLine("başarısız"); break;
                case 3: Console.WriteLine("geçer"); break;
                case 4: Console.WriteLine("orta"); break;
                case 5: Console.WriteLine("iyi"); break;
                case 6: Console.WriteLine("Pekiyi"); break;

            }

            Console.ReadLine();
        }

    }
}
