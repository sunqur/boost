using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation
{
    internal class Gamer
    {

        public string Player1(string name,double health, double power, double defance)
        {
            string profile = " Oyuncu 1'in proifi Adı : " + name;
            return profile + "   Sağlık : " + health + " Güç : " + power + " Defans : " + defance;

        }
        public string Player2(string name,double health, double power, double defance)
        {
            string profile = " Oyuncu 2'in proifi Adı : "+ name;
            
            return profile + "   Sağlık : " + health + " Güç : " + power + " Defans : " + defance;

        }
        public double Attack(double pl1H, double pl1P, double pl1D, double pl2H, double pl2P, double pl2D)
        {
            
            double pl1,pl2;
            do
            {
                pl1 = pl1H + pl1D - pl2P;
                pl2 = pl2H + pl2D - pl1P;

            } while (pl1H <= 0 && pl2H <= 0);

            if (pl1H>pl2H)
            {
                Console.WriteLine("1. Oyuncu kazandı ");
                return pl1;
            }
            else
            {
                Console.WriteLine("2. Oyuncu kazandı ");
                return pl2;
            }

        }
    }
}
