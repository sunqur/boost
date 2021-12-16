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
            int[] dizi = new int[20];
            Random rnd = new Random();
            int nesay = 0;
            int posay = 0;
            int sifsay = 0;
            for (int i = 0; i < 20; i++)
            {
                int sayi = rnd.Next(-100, 100);
                dizi[i] = sayi;

                if (dizi[i] < 0)
                {

                    nesay++;
                    
                    Console.WriteLine(dizi[i] + "\t");
                }
                else if (dizi[i] > 0)
                {
                    
                    posay++;
                   
                    Console.WriteLine(dizi[i] + "\t");
                }
                else
                {
                    sifsay++;
                   
                    Console.WriteLine(dizi[i] + "\t");
                }
            }
           

            Console.WriteLine("negatif sayıların adedi : " + nesay);
            Console.WriteLine("0 sayıların adedi : " + sifsay);
            Console.WriteLine("pozitif sayıların adedi : " + posay);
            


            //Array.Sort(dizi); // küçükten büyüğe
            //Array.Reverse(dizi);// büyükten küçüğe
            //for (int i = 0; i < 500; i++)
            //{
            //    Console.Write(dizi[i] + "\t");
            //}
            Console.ReadLine();

        }
    }
}
