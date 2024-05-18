using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                          ||Zar Atma Oynuna Hoşgeldin!||");


            string isim; string soyisim; int ay;
            Console.Write("Merhaba ! , İsmini yazabilir misin? :");
            isim = Console.ReadLine();
            Console.Write("Soyismini yazabilir misin? :");
            soyisim = Console.ReadLine();
            Console.Write("Doğum ayınızı yazabilir misiniz? (Sayılar ile) :");
            ay = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
            int puan = 0;
            int i;
            for (i = 1; i < 11;)
            {

                Random zar = new Random(Guid.NewGuid().GetHashCode());
                int sayi = zar.Next(1, 7);
                Console.WriteLine("Zar:{0}", sayi);
                if (sayi == 6)
                {
                    i++;
                    Console.WriteLine("*Tebrikler 100 puan kazandınız");
                    //puan ekleme +100//
                    puan = puan + 100;
                }
                if (sayi == 1)
                {
                    i++;
                    Console.WriteLine("*Kötü zar 75 puan kaybettiniz");
                    //puan silme 75//
                    puan = puan - 75;
                }

                toplam += sayi;

            }


            /*karakter sayısı ile puan kod bloğu */
            int a = isim.Length;
            int b = soyisim.Length;
            if (a > b)
            {
                /*50*/
                puan = puan + 50;
            }
            else if (b > a)
            {
                /*-10*/
                puan -= 10;
            }
            else
            {
                /*25*/
                puan += 25;
            }

            /*Doğum ayı ile ilg. puan kod bloğu */
            if (ay > 6)
            {
                /*-20*/
                puan -= 20;

            }
            else if (ay <= 6)
            {
                /*30 */
                puan += 30;

            }
            if (puan >= 500)
            {
                Console.WriteLine("Tebrikler oyunu kazandınız Puanınız : {0} ", puan);
            }
            else
            {
                Console.WriteLine("Tekrar deneyin oyunu kaybettiniz Puanınız : {0} ", puan);
            }

            Console.WriteLine("Attığın zar toplamı: " + toplam);

            Console.ReadLine();
        }
    }
}
