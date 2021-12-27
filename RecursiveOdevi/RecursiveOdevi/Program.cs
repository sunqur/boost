using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int secim = 0;
                Console.WriteLine("Hoşgeldiniz... Lütfen Yapmak İstediğiniz işlemi seçiniz");
                secim:
                Console.WriteLine("**************************** \n1--> Üs Alma \n2--> Tribonacci Hesaplama " +
                    "\n3--> İki sayının arasındaki Sayıları topla");
                secim = Convert.ToByte(Console.ReadLine());

                if (secim==1)
                {
                    UsAlma usal = new UsAlma();

                    Console.WriteLine();
                    Console.WriteLine("Üs alma bölümüne hoş geldiniz.");

                    Console.WriteLine("Lütfen taban değerini girin :");
                    int taban = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Lütfen üs değerini girin :");
                    int us = Convert.ToInt32(Console.ReadLine());



                    Console.WriteLine("{0} üzeri {1} {2} olarak hesaplanmıştır.", taban, us, usal.UsAl(taban, us));
                }
                else if (secim==2)
                {
                    Tribonacci Tribo = new Tribonacci();
                    Console.WriteLine();
                    Console.WriteLine("Tribonacci hesaplama bölümüne hoş geldiniz.");

                    Console.WriteLine("Kaçıncı sıradaki tribonacci değerini görmek istiyorsunuz?");
                    int sira = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("{0}. sıradaki tribonacci değeri {1} olarak hesaplanmıştır.", sira, Tribo.Tribo(sira));
                }
                else if (secim == 3)
                {
                    AraToplam toplam = new AraToplam();
                    Console.WriteLine("Lütfen 1. Sayıyı küçük 2. Sayıyı büyük giriniz...");
                    Console.WriteLine("1. sayıyı giriniz: ");
                    int sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. sayıyı giriniz: ");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("{0}. sayı ile  {1} . sayının arasındaki sayıların toplam  {2} : .", sayi1, sayi2, toplam.AraTopla(sayi1,sayi2));

                }
                else
                {
                    Console.WriteLine("Yanlış seçim yaptınız lütfen yeniden deneyiniz :");
                    goto secim;
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("Geçersiz giriş yaoptınız"+ex.Message);
            }
            Console.ReadLine();

        }
    }
}
