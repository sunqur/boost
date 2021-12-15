using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double kenar1, kenar2, kenar3, cevre, alan, taban,s;
            Console.WriteLine("Hoşgeldiniz... Hesaplamak istediğiniz üçgenin 1. Kenarını giriniz");
            kenar1 = Convert.ToDouble(Console.ReadLine());
            ///
            Console.WriteLine("Hesaplamak istediğiniz üçgenin 2. Kenarını giriniz");
            kenar2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hesaplamak istediğiniz üçgenin 3. Kenarını giriniz");
            kenar3 = Convert.ToDouble(Console.ReadLine());
            cevre = kenar1 + kenar2 + kenar3;
            taban = kenar1;
            /*üçgenin alanını hesaplayabilmek için çizilecek olan üçgenin yüksekliğini bilmemiz lazım.
              heron metodunu kullanarak çizilmiş üçgenin yüksekliğine ihtiyacımız olamayacaktır.
              çevrenin ikiye bölümünü bie değişkende tutarak, bu değişkeni formül içerisinde kenarların farkıyla
              çarpıp sonucu elde ederiz.
             */
            s = cevre / 2;
            alan = Math.Sqrt(s*(s-kenar1) * (s - kenar2) * (s - kenar3));
            // üçgenin oluşabilmesi için kenar uzunlukları arasında ki ilişkileri belirlemek gerekmektedir. 

            if ((kenar1 > 0 && kenar2 > 0 && kenar3 > 0) &&
                Math.Abs(kenar3 - kenar2) < kenar1 && kenar1 < (kenar2 + kenar3) &&
                Math.Abs(kenar1 - kenar3) < kenar2 && kenar2 < (kenar1 + kenar3) &&
                Math.Abs(kenar1 - kenar2) < kenar3 && kenar3 < (kenar1 + kenar2)
               )
            {
                if (kenar1 == kenar2 && kenar1 == kenar3 && kenar3 == kenar2)
                {
                    Console.WriteLine("Üçgenimiz eşkenar üçgendir");
                    Console.WriteLine("Üçgenin çevresi :  " + cevre);
                    Console.WriteLine("Üçgenin alanı :  " + alan);
                }
                else if (
                    (kenar1 == kenar2 && kenar2 != kenar3) ||
                    (kenar1 == kenar3 && kenar2 != kenar3) ||
                    (kenar3 == kenar2 && kenar1 != kenar3))
                {
                    Console.WriteLine("Üçgenimiz ikizkenar üçgendir");
                    Console.WriteLine("Üçgenin çevresi :  " + cevre);
                    Console.WriteLine("Üçgenin alanı :  " + alan);
                }
                else
                {
                    Console.WriteLine("Üçgenimiz çeşitkenar üçgendir");
                    Console.WriteLine("Üçgenin çevresi :  " + cevre);
                    Console.WriteLine("Üçgenin alanı :  " + alan);
                }
            }

            else
                Console.WriteLine("verilen bilgilerle üçgenin çizilmesi mümkün değildir!!!");


            Console.ReadKey();
        }
    }
}
