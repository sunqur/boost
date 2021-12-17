using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] sehir = new string[5];
            //Console.WriteLine("Şehirlerin isimlerini giriniz...");

            //for (int i = 0; i < sehir.Length; i++)
            //{
            //    Console.Write(i + 1 + ". Şehir : ");
            //    string ekle = Console.ReadLine();
            //    sehir[i] = ekle;
            //}

            //Console.WriteLine("Aranacak Şehir");
            //string ara = Console.ReadLine();
            //Console.Write(Array.IndexOf(sehir, ara) + 1 + ". Elemanıdır");

            //int[] sayilar = new int[50];
            //Random rnd = new Random();

            //for (int i = 0; i < 50; i++)
            //{
            //    sayilar[i] = rnd.Next(1, 51);
            //    for (int k = 0; k < i; k++)
            //    {
            //        if (sayilar[k] == sayilar[i])
            //        {
            //            i--;
            //        }
            //    }
            //}
            //Array.Sort(sayilar);
            //for (int a = 0; a < 50; a++)
            //{
            //    Console.Write(sayilar[a] + "\t");
            //}

            Console.WriteLine("Hoşgeldiniz....");
            Console.WriteLine("Kayıt sayısını giriniz....");

            int kaysayi = int.Parse(Console.ReadLine());
            string[] uadi = new string[kaysayi];
            string[] uno = new string[kaysayi];
            double[] ufiyat = new double[kaysayi];
            double zam;
            for (int i = 0; i < kaysayi; i++)
            {
                Console.Write((i + 1) + ". Ürünü giriniz : ");
                string adi = Console.ReadLine();
                uadi[i] = adi;
                Console.Write((i + 1) + ". Ürünü numarasını : ");
                string no = Console.ReadLine();
                uno[i] = no;
                Console.Write((i + 1) + ". Ürünü Fİyatını : ");
                double fiyat = Convert.ToDouble(Console.ReadLine());
                ufiyat[i] = fiyat;
            }
            Console.WriteLine("Yapmak istediğni işlemi seçiniz : \n1) Fiyatı en yüksek ürünü bul \n2) Fiyatı en düşük ürünü bul \n3)fiyat ortalamasını hesapla \n4) Ürünlere zam yap");
            
            for (int i = 0; i < kaysayi; i++)
            {
                ufiyat[i] *= 1.15;
            }
            int sec = int.Parse(Console.ReadLine());

            switch (sec)
            {
                case 1:
                    Console.WriteLine("--------------");
                    Console.WriteLine("En pahalı ürün : \t" + uadi[Array.IndexOf(ufiyat,ufiyat.Max())]);
                    break;
                case 2:
                    Console.WriteLine("--------------");
                    Console.WriteLine("En ucuz ürünün fiyatı : \t" + uadi[Array.IndexOf(ufiyat, ufiyat.Min())]);
                    break;
                case 3:
                    
                    Console.WriteLine("--------------");
                    Console.WriteLine("Ürünlerin ortalaması : \t"+ ufiyat.Average());
                    break;
                case 4:
                    Console.WriteLine("--------------");
                    for (int i = 0; i < kaysayi; i++)
                    {
                        Console.WriteLine(" Ürünün adı : " + uadi[i] + " Ürünün numarası : " + "\t" + uno[i] + "\t" + " Ürünün Fiyatı : " + ufiyat[i] + "\t");

                    }
                    break;
            }




            //foreach (var fiyat in ufiyat)
            //{
            //    Array.Sort(ufiyat);
            //    Array.Reverse(ufiyat);
            //    Console.Write("En yüksek fiyatlı ürün" + ufiyat[0]);
            //}
            //foreach (var fiyat in ufiyat)
            //{
            //    Array.Sort(ufiyat);
            //    Console.Write("En düşük fiyatlı ürün" + ufiyat[0]);
            //}







            Console.ReadKey();


        }
    }
}
