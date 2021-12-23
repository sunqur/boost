using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region idealkilo
            //Ideal idealK = new Ideal();

            //Console.WriteLine(" doğum yılı girin");
            //double dYili = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(" cinsiyetinizi girin E-K");
            //string cinsiyet = Console.ReadLine();
            //Console.WriteLine(" boy girin (örn 175 ) cm cinsinden");
            //double boy = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(" kilo girin (kilogram cinsinden)");
            //double kilo = Convert.ToDouble(Console.ReadLine());

            //idealK.Kilo(boy, kilo, dYili, cinsiyet);
            #endregion

            #region hacim

            //HacimHesaplama hacim = new HacimHesaplama();

            //Console.Write(hacim.Hacim(5));
            //Console.Write(hacim.Hacim(5, 8.5));
            //Console.Write(hacim.Hacim(5, 8.5, 7));
            //Console.Write(hacim.Hacim(7.2));



            #endregion

            #region random

            SayiUretme uret = new SayiUretme();
            

            Console.Write(uret.SayiTut(1));
            Console.Write(uret.SayiTut(2));

            #endregion

            Console.ReadLine();

        }
    }
}
