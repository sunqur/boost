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
            Console.WriteLine("Hoşgeldiniz...");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Sipariş adede göre indirimler : \n20-50 arası %5 \n50-100 arası %10 \n100-200 arası ve fazlası %25 ");

            Console.WriteLine("Sipariş etmek istediğiniz adedi giriniz ");

            int adet = Convert.ToInt32(Console.ReadLine());
            double bfiyat = 100;
            double fiyat = 0;
            Console.WriteLine("Birim fiyatı : " + bfiyat);

            if (adet < 20 && adet>0)
            {
                Console.WriteLine(" Siparişlerin toplamı : {0}", fiyat = (bfiyat*adet));
            }
            else if (adet >= 20 && adet < 50)
            {
                Console.WriteLine(" Siparişlerin toplamı : {0}", fiyat = (bfiyat * adet - (bfiyat * adet * 0.05)));
            }
            else if (adet >= 50 && adet < 100)
            {
                Console.WriteLine(" Siparişlerin toplamı : {0}", fiyat = (bfiyat * adet - (bfiyat * adet * 0.1)));
            }
            else if (adet >= 100)
            {
                Console.WriteLine(" Siparişlerin toplamı : {0}", fiyat = (bfiyat * adet - (bfiyat * adet * 2.5)));
            }
            Console.WriteLine(" Siparişiniz için teşekkürler...  Birim fiyatımız : {0} Sipariş adediniz : {1} Toplam fiyatınız : {2}   ", bfiyat, adet, fiyat);

            Console.ReadLine();
        }
    }
}
