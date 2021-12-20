using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Do_While__Extended_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dışarından 1 ile 6 arasında girilen sayı üzerinden bir zar oyununu oynansın.
            //girilen sayı için çift zar kaç denemeden gelecek bunu bulan programı yazmayı çalışalım.

            //12 2-2 buldu
            //tekrar için sorusun.

            //int sayi = Convert.ToInt32(Console.ReadLine());
            do
            {
                Random rnd = new Random();
                int giris = 0;
                int zar1 = 0, zar2 = 0, sayac = 0;
                bool dogrumu = false;
                Console.WriteLine("Lütfen 1-6 arasında bir sayı giriniz.");
                try
                {
                    giris = int.Parse(Console.ReadLine());
                    if (giris < 1 || giris > 6)
                    {
                        throw new ArgumentException("Lütfen 1-6 aralığında sayı veriniz.");
                    }
                    dogrumu = true;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                while (dogrumu)
                {
                    sayac++;
                    zar1 = rnd.Next(1, 7);
                    zar2 = rnd.Next(1, 7);

                    Console.WriteLine(sayac + " .deneme" + zar1 + " - " + zar2);

                    if (zar1 == zar2 && zar1 == giris)
                    {
                        break;
                    }
                }
                if (dogrumu)
                {
                    Console.WriteLine(sayac + ".denemede bulundu.");
                }
                Console.WriteLine("Tekrar Oynamak istiyorsanız <e> tuşuna basınız.");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                {
                    break;
                }

            } while (true);
        }
    }
}

