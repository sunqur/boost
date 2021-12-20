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
            int[] kesisen = new int[100];
            Random rnd = new Random();
            int  adet = 0;

            for (int i = 0; i < 100; i++)
            {
                dizi1[i] = rnd.Next(0, 100);

                
                for (int j = 0; j < i; j++)
                {
                    
                    if (dizi1[j]==dizi1[i])
                    {
                        i--;
                    }
                }
            }
            for (int i = 0; i < 100; i++)
            {
                dizi2[i] = rnd.Next(0, 100);


                for (int j = 0; j < i; j++)
                {

                    if (dizi2[j] == dizi2[i])
                    {
                        i--;
                    }
                }
            }

            for (int i = 0; i < dizi1.Length; i++)
            {
                for (int j = 0; j < dizi2.Length; j++)
                {
                    if (dizi1[i]==dizi2[j])
                    {
                        adet++;
                        kesisen[i] = dizi1[i];
                    }
                }
            }
            foreach (var item in kesisen)
            {
                Console.Write(item +"\t");
            }
            Console.Write("kesişen sayıların adedi : " + adet);
            Console.ReadLine();
        }
    }
}
