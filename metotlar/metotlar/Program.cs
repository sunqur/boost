using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{

    internal class Program
    {
        static void Main(string[] args)
        {

            arac a = new arac();
            Console.Write("yol giriniz : ");
            a.yol = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zaman giriniz : ");
            a.zaman = Convert.ToDouble(Console.ReadLine());


            a.metot1();
            a.metot2(a.yol,a.zaman);

            Console.WriteLine(a.metot3());

            Console.WriteLine(a.metot4(a.yol, a.zaman));




            //Console.WriteLine("Yarıçap giriniz : ");
            //double r = Convert.ToDouble(Console.ReadLine());

            //daire d = new daire();

            //Console.WriteLine("Dairenin alanı = " + d.alan(r)+"\n"+ "Dairenin çevresi = "+ d.cevre(r));
            //hesapmak h = new hesapmak();

            //Console.Write("1. sayıyı giriniz : ");
            //double s1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz : ");
            //double s2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İşlem seçiniz (+ - * /)");
            //string secim = Console.ReadLine();

            //Console.WriteLine(h.hesapla(s1,s2,secim));


            //if (secim == "+")
            //{
            //    Console.WriteLine("Sayıların toplam : "+h.toplam());
            //}
            //else if (secim == "-")
            //{
            //    Console.WriteLine("Sayıların çıkarma işlemi : " + h.cikar());
            //}
            //else if (secim == "*")
            //{
            //    Console.WriteLine("Sayıların çarpma işlemi : " + h.carp());
            //}
            //else if (secim == "/")
            //{
            //    Console.WriteLine("Sayıların bölme işlemi : " + h.bol());
            //}
            Console.ReadKey();
        }
    }
}
