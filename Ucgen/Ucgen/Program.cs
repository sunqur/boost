using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UcgenCagirma
            //Console.WriteLine("Hoşgeldiniz... Oluşturmak istediğiniz üçgenin 1. Kenarını giriniz");
            //double kenar1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Oluşturmak istediğiniz üçgenin 2. Kenarını giriniz");
            //double kenar2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Oluşturmak istediğiniz üçgenin 3. Kenarını giriniz");
            //double kenar3 = Convert.ToDouble(Console.ReadLine());

            //Bul(kenar1,kenar2,kenar3);
            #endregion
            #region ParamsEnbuyuksayi
            //int sonuc = EnBuyukSayiyiBul(10, 5, 7, 99, 1531, 22, 331313);
            //Console.WriteLine("En büyük sayı : "+sonuc);

            //Console.ReadKey();
            #endregion


            #region Fibonacci
            /* 
            Fibonacci Dizisi'ni oluşturmak için şu formül uygulanmaktadır: 
            F(n) = F(n - 1) + F(n - 2). 
            İşte bu formül Fibonacci Dizisi algoritmasıdır. 
            
            Console.WriteLine("değeri girin : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n" + fibonacci(i));
            }

            Console.ReadKey();
            */
            #endregion

        }
        #region UcgenBulmaMetot
        //static void Bul(double kenar1, double kenar2, double kenar3)
        //{
        //    if ((kenar1 > 0 && kenar2 > 0 && kenar3 > 0) &&
        //       Math.Abs(kenar3 - kenar2) < kenar1 && kenar1 < (kenar2 + kenar3) &&
        //       Math.Abs(kenar1 - kenar3) < kenar2 && kenar2 < (kenar1 + kenar3) &&
        //       Math.Abs(kenar1 - kenar2) < kenar3 && kenar3 < (kenar1 + kenar2)
        //      )
        //    {
        //        if (kenar1 == kenar2 && kenar1 == kenar3 && kenar3 == kenar2)
        //        {
        //            Console.WriteLine("Üçgenimiz eşkenar üçgendir");

        //        }
        //        else if (
        //            (kenar1 == kenar2 && kenar2 != kenar3) ||
        //            (kenar1 == kenar3 && kenar2 != kenar3) ||
        //            (kenar3 == kenar2 && kenar1 != kenar3))
        //        {
        //            Console.WriteLine("Üçgenimiz ikizkenar üçgendir");

        //        }
        //        else
        //        {
        //            Console.WriteLine("Üçgenimiz çeşitkenar üçgendir");

        //        }
        //    }

        //    else
        //        Console.WriteLine("verilen bilgilerle üçgenin çizilmesi mümkün değildir!!!");


        //}

        #endregion
        #region ParamsEnbüyüksayıyıBulma
        //static int EnBuyukSayiyiBul(params int[] sayilar)
        //{
        //    int enBuyukSayi = -1;

        //    if (sayilar.Length > 0)
        //    {
        //        enBuyukSayi = sayilar[0];
        //    }

        //    foreach (int sayi in sayilar)
        //    {
        //        if (enBuyukSayi < sayi)
        //        {
        //            enBuyukSayi = sayi;
        //        }
        //    }
        //    return enBuyukSayi;
        //}
        #endregion

        #region FibonacciMetot

        //static int fibonacci(int sayi)
        //{
        //    if (sayi == 0)
        //    {
        //        return 0;

        //    }
        //    else if (sayi == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return fibonacci(sayi - 1) + fibonacci(sayi - 2);
        //    }
        //}
        #endregion

    }
}
