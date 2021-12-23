using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Gamer game = new Gamer();
            Console.WriteLine("Oyun simulasyonuna hoş geldiniz...");
            Console.WriteLine("----------------------------------");
            Console.Write(" Oyuncu 1'in ismini giriniz :");
            string oyuncu1 = Console.ReadLine();
            Console.Write(" Oyuncu 1'in Sağlık değerini giriniz :");
            double pl1H = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Oyuncu 1'in Güç değerini giriniz :");
            double pl1P = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Oyuncu 1'in Defans gücünün değerini giriniz :");
            double pl1D = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Oyuncu 2'nin ismini giriniz :");
            string oyuncu2 = Console.ReadLine();
            Console.Write(" Oyuncu 2'nin Sağlık değerini giriniz :");
            double pl2H = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Oyuncu 2'nin Güç değerini giriniz :");
            double pl2P = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Oyuncu 2'nin defens gücünü giriniz :");
            double pl2D = Convert.ToDouble(Console.ReadLine());
        sec:
            Console.WriteLine("1) Oyuncuların profili \n2) Savaş sonucu ");
            int sec = Convert.ToInt32(Console.ReadLine());

            switch (sec)
            {
                case 1 :
                    Console.WriteLine("Oyuncu Profilleri");
                    Console.WriteLine("*********************");
                    Console.WriteLine("Birinci oyuncu : "+game.Player1(oyuncu1,pl1H,pl1P,pl1D));
                    Console.WriteLine("*********************");
                    Console.WriteLine("İkinci oyuncu : " + game.Player2(oyuncu2,pl2H, pl2P, pl2D));
                    goto sec;
                    break;
                case 2:
                    Console.WriteLine("Savaş sonucu");
                    Console.WriteLine("++++++++++++++++++++");
                    Console.WriteLine(game.Attack(pl1H, pl1P, pl1D, pl2H, pl2P, pl2D));
                    break;
                default:
                    Console.WriteLine("Yanlış bir Karakter girdiniz. Lütfen yeniden deneyiniz");
                    goto sec;
                    break;
            }

            Console.ReadLine();
        }
    }
}
