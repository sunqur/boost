using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[50];
            Random rnd = new Random();
            Console.WriteLine("Dizinin içinden sayıyı tahmin ediniz...");
            Console.WriteLine("---------------------------------------");
            int cevap = Convert.ToInt32(Console.ReadLine());
            int adet = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                int sayi = rnd.Next(1, 50);
                dizi[i] = sayi;
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (cevap == dizi[i])
                {
                    adet++;
                }
            }
            if (adet > 0)
            {
                Console.WriteLine("Tahmin ettiğiniz sayının dizideki adedi : " + adet);
            }
            else
            {
                Console.WriteLine("Maalesef girdiğiniz sayıdan bulunmuyor...");
            }

            Console.WriteLine("bilinen sayının adedi : " + adet);




            //string[] isim = { "a", "b", "c", "d","e" };
            //string[] tel = { "1", "2", "3", "4", "5" };
            //string[] mail = { "@a", "@b", "@c", "@d", "@e" };

            //Console.WriteLine("Kaçıncı personeli görmek istiyorsunuz? (1-5)");

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //switch (sayi)
            //{
            //    case 1: Console.WriteLine(isim[sayi - 1]+"\t"+ tel[sayi - 1] + "\t"+ mail[sayi - 1] + "\t");
            //        break;
            //    case 2:
            //        Console.WriteLine(isim[sayi - 1] + "\t" + tel[sayi - 1] + "\t" + mail[sayi - 1] + "\t");
            //        break;
            //    case 3:
            //        Console.WriteLine(isim[sayi - 1] + "\t" + tel[sayi - 1] + "\t" + mail[sayi - 1] + "\t");
            //        break;
            //    case 4:
            //        Console.WriteLine(isim[sayi - 1] + "\t" + tel[sayi - 1] + "\t" + mail[sayi - 1] + "\t");
            //        break;
            //    case 5:
            //        Console.WriteLine(isim[sayi - 1] + "\t" + tel[sayi - 1] + "\t" + mail[sayi - 1] + "\t");
            //        break;
            //}
            Console.ReadLine();
        }
    }
}
