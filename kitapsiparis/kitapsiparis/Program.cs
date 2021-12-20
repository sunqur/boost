using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitapsiparis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hoşgeldiniz...");
            //Console.WriteLine(" ");
            //Console.WriteLine("---------------------");
            //Console.WriteLine(" ");

            //Console.WriteLine("Sipariş adede göre indirimler : \n20-50 arası %5 \n50-100 arası %10 \n100-200 arası ve fazlası %25 ");

            //Console.WriteLine("Sipariş etmek istediğiniz adedi giriniz ");

            //int adet = Convert.ToInt32(Console.ReadLine());
            //double bfiyat = 100;
            //double fiyat = 0;
            //Console.WriteLine("Birim fiyatı : " + bfiyat);

            //if (adet < 20 && adet>0)
            //{
            //    Console.WriteLine(" Siparişlerin toplamı : {0}", fiyat = (bfiyat*adet));
            //}
            //else if (adet >= 20 && adet < 50)
            //{
            //    Console.WriteLine(" Siparişlerin toplamı : {0}", fiyat = (bfiyat * adet - (bfiyat * adet * 0.05)));
            //}
            //else if (adet >= 50 && adet < 100)
            //{
            //    Console.WriteLine(" Siparişlerin toplamı : {0}", fiyat = (bfiyat * adet - (bfiyat * adet * 0.1)));
            //}
            //else if (adet >= 100)
            //{
            //    Console.WriteLine(" Siparişlerin toplamı : {0}", fiyat = (bfiyat * adet - (bfiyat * adet * 2.5)));
            //}
            //Console.WriteLine(" Siparişiniz için teşekkürler...  Birim fiyatımız : {0} Sipariş adediniz : {1} Toplam fiyatınız : {2}   ", bfiyat, adet, fiyat);

            //Console.ReadLine();

            //Console.WriteLine("Lütfen bakiyenizi girin:");
            //double bakiye = Convert.ToDouble(Console.ReadLine());
            //int git = 0;
            //if (bakiye > 100)
            //{

            //    if (bakiye >= 100 && bakiye < 200)
            //    {
            //        git = 1;

            //    }
            //    else if (bakiye >= 200 && bakiye < 300)
            //    {
            //        git = 2;

            //    }
            //    else if (bakiye >= 300 && bakiye < 400)
            //    {
            //        git = 3;

            //    }
            //    else if (bakiye >= 400 && bakiye < 500)
            //    {
            //        git = 4;

            //    }
            //    else if (bakiye >= 500 && bakiye < 600)
            //    {
            //        git = 5;

            //    }
            //    else if (bakiye >= 600)
            //    {
            //        git = 6;

            //    }

            //}
            //switch (git)
            //{
            //    case 1:
            //        Console.WriteLine("Alabildiğin ürünler\n1: Kalem \n2:Kağıt");
            //        int miktar1 = 100;
            //        bakiye -= miktar1;
            //        Console.WriteLine("Aldığınız ürünlerden sonra kalan bakiyeniz : "+bakiye);
            //        break;

            //    case 2:
            //        Console.WriteLine("Alabildiğin ürünler\n1: bardak \n2:mouse");
            //        int miktar2 = 200;
            //        bakiye -= miktar2;
            //        Console.WriteLine("Aldığınız ürünlerden sonra kalan bakiyeniz : " + bakiye);

            //        break;

            //    case 3:
            //        Console.WriteLine("Alabildiğin ürünler\n1: tütsü \n2:saat");
            //        int miktar3 = 300;
            //        bakiye -= miktar3;
            //        Console.WriteLine("Aldığınız ürünlerden sonra kalan bakiyeniz : " + bakiye);

            //        break;

            //    case 4:
            //        Console.WriteLine("Alabildiğin ürünler\n1: parlatıcı \n2:renkli kalem");
            //        int miktar4 = 400;
            //        bakiye -= miktar4;
            //        Console.WriteLine("Aldığınız ürünlerden sonra kalan bakiyeniz : " + bakiye);

            //        break;

            //    case 5:
            //        Console.WriteLine("Alabildiğin ürünler\n1: silgi \n2:defter");
            //        int miktar5 = 500;
            //        bakiye -= miktar5;
            //        Console.WriteLine("Aldığınız ürünlerden sonra kalan bakiyeniz : " + bakiye);

            //        break;

            //    case 6:
            //        Console.WriteLine("Alabildiğin ürünler\n1: kupa \n2:çakmak");
            //        int miktar6 = 600;
            //        bakiye -= miktar6;
            //        Console.WriteLine("Aldığınız ürünlerden sonra kalan bakiyeniz : " + bakiye);

            //        break;
            //}
            int secim;
            double adet, toplam = 0;
            double tutar = 0;
            double bakiye;
            string cevap = " ";

            Console.WriteLine("*      ürünler     **      ürün kodu");
            Console.WriteLine("*      1)gözlük    20tl       1");
            Console.WriteLine("*      2)şapka     25tl       2");
            Console.WriteLine("*      3)çanta     30 tl      3");
            Console.WriteLine("*      3)bere      45 tl      4");
            Console.WriteLine("*      3)ayakkabı  70 tl      5");

            Console.WriteLine("lütfen bakiye bilginizi giriniz : ");
            bakiye = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");


            while (bakiye > tutar)
            {


                Console.Write("seçeceğiniz ürünün kodunu giriniz ");
                secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("lütfen kaç adet alacağınızı giriniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 20;
                    tutar = tutar + toplam;
                    bakiye = bakiye - tutar;


                }

                else if (secim == 2)
                {
                    Console.Write("lütfen kaç adet alacağınızı giriniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 25;
                    tutar = tutar + toplam;
                    bakiye = bakiye - tutar;

                }
                else if (secim == 3 && bakiye >= tutar)
                {
                    Console.Write("lütfen kaç adet alacağınızı giriniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 30;
                    tutar = tutar + toplam;
                    bakiye = bakiye - tutar;

                }
                else if (secim == 4 && bakiye >= tutar)
                {
                    Console.Write("lütfen kaç adet alacağınızı giriniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 45;
                    tutar = tutar + toplam;
                    bakiye = bakiye - tutar;

                }
                else if (secim == 5 && bakiye >= tutar)
                {
                    Console.Write("lütfen kaç adet alacağınızı giriniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 25;
                    tutar = tutar + toplam;
                    bakiye = bakiye - tutar;

                }
                else
                {
                    Console.WriteLine("böyle bir ürün yok!");
                    Console.WriteLine(" ");
                }
                Console.WriteLine("toplam tutar = {0}", tutar);
                Console.WriteLine("kalan bakiyeniz= {0}", bakiye);

                Console.WriteLine("başka bir ürün eklemek ister misiniz? e/h");
                cevap = Console.ReadLine();
                if (cevap == "h" || cevap == "H")
                    break;

            }
            Console.WriteLine("bakiyeniz yetersizdir");
            Console.WriteLine("toplam tutar : ", tutar);

            Console.ReadLine();
            Console.ReadKey();




        }
    }
}