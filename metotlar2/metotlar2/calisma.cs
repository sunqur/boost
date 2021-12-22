using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar2
{
    internal class calisma
    {
        public double bakiye;
        
        public void  yemek()
        {
            string[] yemekler = { "Çorba", "Kuru Fasulye", "Pilav", "Kebap", "Tavuk Dürüm" };
            int[] fiyat = { 5, 30, 16, 19, 35 };
            Console.WriteLine("Yemek Menüsü" + " Fiyat Bilgisi");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ") " + yemekler[i] + "   =    " + fiyat[i]);
            }
            sec:
            Console.Write(" Almak istediğiniz yemeği seçiniz : ");
            int sec = Convert.ToInt32(Console.ReadLine());

            if (sec == 1)
            {
                bakiye -= fiyat[0];
            }
            else if (sec == 2)
            {
                bakiye -= fiyat[1];
            }
            else if (sec == 3)
            {
                bakiye -= fiyat[2];
            }
            else if (sec == 4)
            {
                bakiye -= fiyat[3];
            }
            else if (sec == 5)
            {
                bakiye -= fiyat[3];
            }
            else
            {
                Console.Write("Yanlış bir seçim yaptınız. Lütfen tekrar deneyin ");
                goto sec;
            }

        }

        public void tatlı()
        {
            string[] tatlılar = { "Sütlaç", "Kazandibi", "Supangle", "Kadayıf", "Baklava" };
            int[] fiyat = { 5, 30, 16, 19, 35 };
            Console.WriteLine("Tatlı Menüsü" + " Fiyat Bilgisi");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ") " + tatlılar[i] + "   =    " + fiyat[i]);
            }
        sec:
            Console.Write(" Almak istediğiniz yemeği seçiniz : ");
            int sec = Convert.ToInt32(Console.ReadLine());

            if (sec == 1)
            {
                bakiye -= fiyat[0];
            }
            else if (sec == 2)
            {
                bakiye -= fiyat[1];
            }
            else if (sec == 3)
            {
                bakiye -= fiyat[2];
            }
            else if (sec == 4)
            {
                bakiye -= fiyat[3];
            }
            else if (sec == 5)
            {
                bakiye -= fiyat[3];
            }
            else
            {
                Console.Write("Yanlış bir seçim yaptınız. Lütfen tekrar deneyin ");
                goto sec;
            }
        }
        public void icecek()
        {
            string[] icecek = { "Kola", "Gazoz", "Soda", "Ayran", "Su" };
            int[] fiyat = { 5, 30, 16, 19, 35 };
            Console.WriteLine("İçecek Menüsü" + " Fiyat Bilgisi");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ") " + icecek[i] + "   =    " + fiyat[i]);
            }
        sec:
            Console.Write(" Almak istediğiniz yemeği seçiniz : ");
            int sec = Convert.ToInt32(Console.ReadLine());

            if (sec == 1)
            {
                bakiye -= fiyat[0];
            }
            else if (sec == 2)
            {
                bakiye -= fiyat[1];
            }
            else if (sec == 3)
            {
                bakiye -= fiyat[2];
            }
            else if (sec == 4)
            {
                bakiye -= fiyat[3];
            }
            else if (sec == 5)
            {
                bakiye -= fiyat[3];
            }
            else
            {
                Console.Write("Yanlış bir seçim yaptınız. Lütfen tekrar deneyin ");
                goto sec;
            }
        }

        public void hesapode()
        {
            Console.Write("Kalan bakiyeniz : " + bakiye);
        }
    }
}
