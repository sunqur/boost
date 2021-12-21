using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacimhesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hacim hesaplama programına hoşgeldiniz...");
                Console.Write("Hangi şeklin hacmini hesaplamak istersiniz \n1) Dikdörtgen prizma \n2) Küp \n3) küre \n4) Silindir \n5) Koni \n6) Kare piramid");
                Console.WriteLine();
                int sec = int.Parse(Console.ReadLine());
                Console.WriteLine("Oluşacak dizi kaç elamanlı olsun : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                double[] dik = new double[sayi];
                double[] küp = new double[sayi];
                double[] küre = new double[sayi];
                double[] sil = new double[sayi];
                double[] koni = new double[sayi];
                double[] kpira = new double[sayi];
                double hacim = 0;
                for (int x = 0; x < sayi; x++)
                {
                    switch (sec)
                    {
                        case 1:
                            Console.WriteLine("Lütfen dikdörtgenin kenar uzunluklarını giriniz");
                            double k1 = Convert.ToDouble(Console.ReadLine());
                            double k2 = Convert.ToDouble(Console.ReadLine());
                            double k3 = Convert.ToDouble(Console.ReadLine());
                            hacim = k1 * k2 * k3;

                            for (int i = 0; i < dik.Length; i++)
                            {
                                dik[i] = hacim;
                            }

                            foreach (var item in dik)
                            {
                                Console.WriteLine("Dikdörgen dizisinde ki hacim sonuçları : " + item);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Lütfen küpün 1 kenar uzunluğunu giriniz");
                            double a = Convert.ToDouble(Console.ReadLine());
                            hacim = Math.Pow(a, 3);
                            for (int i = 0; i < küp.Length; i++)
                            {
                                küp[i] = hacim;
                            }
                            foreach (var item in küp)
                            {
                                Console.WriteLine("Küp dizisinde ki hacim sonuçları : " + item);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Lütfen küreni yarıçapını giriniz");
                            double yaric = Convert.ToDouble(Console.ReadLine());
                            hacim = (Math.PI * Math.Pow(yaric, 3)) * 4 / 3;
                            for (int i = 0; i < küre.Length; i++)
                            {
                                küre[i] = hacim;
                            }
                            foreach (var item in küre)
                            {
                                Console.WriteLine("Küre dizisinde ki hacim sonuçları : " + item);
                            }
                            break;

                        case 4:
                            Console.WriteLine("Lütfen silindirin yarıçapını giriniz");
                            yaric = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Lütfen silindirin yüksekliğini giriniz");
                            double h = Convert.ToDouble(Console.ReadLine());
                            hacim = Math.PI * Math.Pow(yaric, 2) * h;
                            for (int i = 0; i < sil.Length; i++)
                            {
                                sil[i] = hacim;
                            }
                            foreach (var item in sil)
                            {
                                Console.WriteLine("Silindir dizisinde ki hacim sonuçları : " + item);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Lütfen Koninin yarıçapını giriniz");
                            yaric = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Lütfen koninin yüksekliğini giriniz");
                            h = Convert.ToDouble(Console.ReadLine());
                            hacim = (Math.PI * Math.Pow(yaric, 2) * h) / 3;
                            for (int i = 0; i < koni.Length; i++)
                            {
                                koni[i] = hacim;
                            }
                            foreach (var item in koni)
                            {
                                Console.WriteLine("Silindir dizisinde ki hacim sonuçları : " + item);
                            }
                            break;
                        case 6:
                            Console.WriteLine("Lütfen Kare piramidin tabanını giriniz");
                            k1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Lütfen Kare piramidin yüksekliğini giriniz");
                            h = Convert.ToDouble(Console.ReadLine());
                            hacim = (Math.Pow(k1, 2) * h) / 3;
                            for (int i = 0; i < kpira.Length; i++)
                            {
                                kpira[i] = hacim;
                            }
                            foreach (var item in kpira)
                            {
                                Console.WriteLine("Silindir dizisinde ki hacim sonuçları : " + item);
                            }
                            break;
                    }
                }
                
            }
            catch (Exception me)
            {

                Console.WriteLine(me.Message);
            }



            Console.ReadLine();
        }
    }
}
