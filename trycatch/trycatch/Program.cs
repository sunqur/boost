using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double alan,cevre;
            try
            {
                Console.WriteLine("Yarı çapı giriniz"); 
                double yaricap = Convert.ToSingle(Console.ReadLine());
                alan = Math.PI * Math.Pow(yaricap, 2);
                cevre = 2 * Math.PI * yaricap;
                Console.WriteLine("çevre : " + cevre);
                Console.WriteLine("alan : " + alan);
            }
            catch (Exception me)
            {
                Console.Write(me);
            }

            Console.ReadLine();
        }
    }
}
