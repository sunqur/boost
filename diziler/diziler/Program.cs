using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[500];
            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                int sayi = rnd.Next(1, 50);
                dizi[i] = sayi;
                
            }
            Array.Sort(dizi); // küçükten büyüğe
            Array.Reverse(dizi);// büyükten küçüğe
            for (int i = 0; i < 500; i++)
            {
                Console.Write(dizi[i] + "\t");
            }
            Console.ReadLine();

        }
    }
}
