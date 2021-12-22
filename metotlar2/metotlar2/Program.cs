using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region örnek 1
            //tekcift t = new tekcift();
            //Console.Write("Bir sayı giriniz : ");
            //double s = Convert.ToDouble(Console.ReadLine());

            //t.sayi(s);
            #endregion

            #region ornek 2
            //tekcift t = new tekcift();
            //Console.Write("1. Sayıyı giriniz");
            //double s1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("2. Sayıyı giriniz");
            //double s2 = Convert.ToDouble(Console.ReadLine());
            //#endregion

            //t.buyuk(s1, s2);


            #endregion


            #region calisma
            calisma c = new calisma();
            Console.Write(" Restoranımıza Hoşgeldiniz... \nLütfen Bakiyenizi giriniz : ");
            c.bakiye = Convert.ToDouble(Console.ReadLine());
            if (c.bakiye>50)
            {
                do
                {
                    sec:
                    Console.WriteLine("Menümüz  \n************* \n1) Yiyecekler \n2) İçecekler \n3) Tatlılar \n4) Hesap Öde : ");
                    int sec = Convert.ToInt32(Console.ReadLine());



                    switch (sec)
                    {
                        case 1:
                            c.yemek();
                            break;
                        case 2:
                            c.icecek();
                            break;
                        case 3:
                            c.tatlı();
                            break;
                        case 4:
                            c.hesapode();
                            break;
                        default:
                            Console.WriteLine("Yanlış bir seçim yaptınız. Lütfen yeniden seçiniz : ");
                            goto sec;
                            break;
                    }
                } while (c.bakiye < 50);
                Console.Write("Kalan bakiyeniz : " + c.bakiye);
            }
            else
            {
                Console.WriteLine("Üzgünüm bakiyeniz restoranımızdan yemek yemeniz için yetersizdir..");
            }

            

            #endregion

            Console.ReadKey();
        }
    }
}
