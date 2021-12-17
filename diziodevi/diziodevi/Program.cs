using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziodevi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = new int[100];
            int[] dizi2 = new int[100];
            int[] kesisen = new int[10000];
            Random rnd = new Random();
            int kesisenIndex=0, adet = 0;

            for (int i = 0; i < 100; i++)
            {
                dizi1[i] = rnd.Next(0, 100);
                dizi2[i] = rnd.Next(0, 100);
            }
            for (int i = 0; i < dizi1.Length; i++)
            {
                for (int j = 0; j < dizi2.Length; j++)
                {
                    if (dizi1[i]==dizi2[j])
                    {
                        adet++;
                        kesisen[kesisenIndex] = dizi1[i];
                        kesisenIndex++;
                    }
                }
            }
            foreach (var item in kesisen)
            {

                Console.Write(item+"\t");
            }
            Console.ReadLine();
        }
    }
}
