using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ufiyat = new double[10];
            Random rnd = new Random();
            Console.WriteLine("Hoşgeldiniz....");

            for (int i = 0; i < ufiyat.Length; i++)
            {
                ufiyat[i] = rnd.Next(100, 500);
            }
            Console.WriteLine(" Zamdan önceki fiyatlar...");
            foreach (var item in ufiyat)
            {
                Console.Write(item+"\t");
            }
            for (int i = 0; i < ufiyat.Length; i++)
            {
                if (ufiyat[i]>=100 && ufiyat[i]<200)
                {
                    ufiyat[i] *= 1.05;
                }
                else if (ufiyat[i] >= 200 && ufiyat[i] < 300)
                {
                    ufiyat[i] *= 1.10;
                }
                else if (ufiyat[i] >= 300 && ufiyat[i] < 500)
                {
                    ufiyat[i] *= 1.15;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(" Zamdan sonraki fiyatlar ");

            foreach (var item in ufiyat)
            {
                Console.Write(item + "\t");
            }

            Console.ReadLine();
        }
    }
}
