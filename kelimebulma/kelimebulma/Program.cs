using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelimebulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sonuc = 0;
            //string kelime = "";
            //Console.WriteLine("Cümleyi giriniz");
            //string cumle = Console.ReadLine();
            //Console.WriteLine("Aranacak olan kelimeyi giriniz");
            //string aranan = Console.ReadLine();

            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    if (cumle[i]!=' ')
            //    {
            //        kelime += cumle[i];
            //    }
            //    else
            //    {
            //        if (kelime == aranan)
            //        {
            //            sonuc++;
            //        }
            //        kelime = "";
            //    }
            //}

            //Console.WriteLine("Sonuc : {0} ", sonuc.ToString());



            //Random rnd = new Random();
            //int[] dizi = new int[5];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(100);
            //}
            //Array.Sort(dizi);
            //Array.Reverse(dizi);

            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item + "\t");
            //}

            //char[] alf = new char[26];
            //int sira = 0;

            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    alf[sira] = i;
            //    Console.Write(alf[sira] +"\t");
            //    sira++;
            //}

            //Console.WriteLine("hoş geldiniz... Lütfen 10 adet sayı giriniz");

            //double[] dizi = new double[10];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    sayi:
            //    double sayi = Convert.ToDouble(Console.ReadLine());
            //    if (sayi>=100)
            //    {
            //        dizi[i] = sayi;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı 100den büyük olmalıdır");
            //        goto sayi;

            //    }
            //}

            //foreach (var item in dizi)
            //{
            //    Console.Write(item + "\t");
            //}


            
            char[] sesli = {'a','e','ı','i', 'o', 'ö', 'u', 'ü' };
            Console.WriteLine("bir cümle giriniz:"); //dışarıdan cümlemizi giriyoruz
            string cumle = Console.ReadLine(); //cümlemizi değişkene aktarıyoruz
            double  sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (cumle[i] == sesli[j]) 
                    {
                        sayac++; 
                    }
                }

            }
            double oran = sayac/(cumle.Length);
            Console.WriteLine("Sesli harfin sayısı : {0} ve Oranı : {1} ", sayac.ToString(),oran);
            Console.ReadLine();
        }
    }
}
