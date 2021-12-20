using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikiboyutluilkornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz....");
            Console.WriteLine("---------------");
            //Console.WriteLine("Kaç satırla oynamak istersiniz");
            //Random rnd = new Random();
            //int str = Convert.ToInt32(Console.ReadLine());
            //int tutar=0, adet=0, stn = 6;

            //int[,] dizi = new int[str, stn];

            //for (int i = 0; i < str; i++)
            //{
            //    adet++;
            //    for (int j = 0; j < stn; j++)
            //    {

            //        dizi[i, j] = rnd.Next(1, 50);
            //        Console.Write(dizi[i,j]+"\t");
            //    }
            //    Console.WriteLine();

            //}
            //tutar = adet * 3;
            //Console.WriteLine("Ödemeniz gerek tutar : "+ tutar);
            //int stoplam = 0, stoplam2 = 0, stoplam3 = 0, stoplam4 = 0, stoplam5 = 0;
            //int ocak = 0, subat = 0, mart = 0, gtop = 0;
            //int[,] mfiyat = new int[5, 3];
            //mfiyat[0, 0] = 700;
            //mfiyat[0, 1] = 600;
            //mfiyat[0, 2] = 650;
            //mfiyat[1, 0] = 900;
            //mfiyat[1, 1] = 800;
            //mfiyat[1, 2] = 700;
            //mfiyat[2, 0] = 300;
            //mfiyat[2, 1] = 400;
            //mfiyat[2, 2] = 350;
            //mfiyat[3, 0] = 500;
            //mfiyat[3, 1] = 450;
            //mfiyat[3, 2] = 470;
            //mfiyat[4, 0] = 600;
            //mfiyat[4, 1] = 500;
            //mfiyat[4, 2] = 480;

            //for (int i = 0; i < 5; i++)
            //{
            //    ocak += mfiyat[i, 0];
            //    subat += mfiyat[i, 1];
            //    mart += mfiyat[i, 2];
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    stoplam += mfiyat[0, i];
            //    stoplam2 += mfiyat[1, i];
            //    stoplam3 += mfiyat[2, i];
            //    stoplam4 += mfiyat[3, i];
            //    stoplam5 += mfiyat[4, i];

            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        gtop += mfiyat[i, j];
            //    }
            //    Console.WriteLine();
            //}
            ////gtop = ocak + subat + mart;

            //Console.WriteLine(" Markaların 3 aylık satış toplamları ");
            //Console.WriteLine(" ----------------------------------- ");
            //Console.WriteLine(" Fİat : " + stoplam);
            //Console.WriteLine(" Renault : " + stoplam2);
            //Console.WriteLine(" VW : " + stoplam3);
            //Console.WriteLine(" opel : " + stoplam4);
            //Console.WriteLine(" ford : " + stoplam5);
            //Console.WriteLine(" ----------------------------------- ");
            //Console.WriteLine(" 3 aylık bilanço ");
            //Console.WriteLine(" *********************************** ");
            //Console.WriteLine(" Ocak Ayı : "+ocak);
            //Console.WriteLine(" Subat Ayı : "+subat);
            //Console.WriteLine(" Mart Ayı : "+mart);
            //Console.WriteLine(" *********************************** ");
            //Console.WriteLine(" Genel toplam :  "+gtop);

            Console.WriteLine(" ders giriniz");
            
            string[] dersler = new string[6];
            string[,] program = new string[8, 5];
            Random rnd = new Random();
            for (int i = 0; i < dersler.Length; i++)
            {
                string ders = Console.ReadLine();
                dersler[i] = ders;
            }
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    program[i, j] = dersler[rnd.Next(0,6)];
                    Console.Write(program[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
