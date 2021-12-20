using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelimebulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            string kelime = "";
            Console.WriteLine("Cümleyi giriniz");
            string cumle = Console.ReadLine();
            Console.WriteLine("Aranacak olan kelimeyi giriniz");
            string aranan = Console.ReadLine();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i]!=' ')
                {
                    kelime += cumle[i];
                }
                else
                {
                    if (kelime == aranan)
                    {
                        sonuc++;
                    }
                    kelime = "";
                }
            }

            Console.WriteLine("Sonuc : {0} ", sonuc.ToString());

            Console.ReadLine();
        }
    }
}
