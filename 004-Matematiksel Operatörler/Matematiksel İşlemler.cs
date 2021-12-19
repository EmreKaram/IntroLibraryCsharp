using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Matematiksel_Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematiksel İşlemler");

            Console.WriteLine("----------------------------\n");
            int sayiBir = 102;
            int sayiiki = 25;

            Console.WriteLine("-------------------------------------------");

            #region Toplama İşlemi:
            int toplam = sayiBir + sayiiki;

            Console.WriteLine("Toplama işleminin sonucu : " + toplam);
            Console.WriteLine("Toplama işleminin Sonucu : " + sayiBir + sayiiki);
            Console.WriteLine("Toplama işleminin Sonucu : " + (sayiBir + sayiiki));
            #endregion

            Console.WriteLine("-------------------------------------------");

            #region Çıkartma İşlemi:
            int fark = sayiBir - sayiiki;

            Console.WriteLine("Çıkartma işleminin sonucu : " + fark);
            Console.WriteLine("Çıkarma işleminin sonucu : " + (sayiBir - sayiiki));
            #endregion

            Console.WriteLine("-------------------------------------------");

            #region Çarpma İşlemi:
            int carpim = sayiBir * sayiiki;

            Console.WriteLine("Çarpma İşleminin sonucu : " + carpim);
            Console.WriteLine("Çarpma işleminin sonuc : " + (sayiiki * sayiBir));
            #endregion

            Console.WriteLine("-------------------------------------------");

            #region Bölme İşlemi:
            double bolum = sayiBir / sayiiki;

            Console.WriteLine("Bölme İşlemi Sonucu : " + bolum);
            Console.WriteLine("Bölme İşleminin Sonucu : " + (sayiBir / sayiiki));
            #endregion

            Console.WriteLine("-------------------------------------------");

            #region ModAlma İşlemi: 

            int mod = sayiBir % sayiiki;
            Console.WriteLine("Mod işleminin sonucu : " + mod);
            Console.WriteLine("Mod işleminin Sonucu : " + (sayiBir % sayiiki));
            #endregion

            Console.WriteLine("-------------------------------------------");

            #region Sayıyı Bir Attrıma:
            int sayi = 15;
            Console.WriteLine("Sayın ilk değeri : "+ sayi);
            sayi = sayi + 1;
            Console.WriteLine("Sayıyın bir üst değeri : "+ sayi);
            sayi += 1;
            Console.WriteLine("Sayının bir üst değerine atanmış hali : "+ sayi);
            sayi++;
            Console.WriteLine("Sayının bir üst değere atanmış hali : "+sayi);


            #endregion

            #region Sayiyi Bir eksiltme:
            int sayi0 = 15;
            Console.WriteLine("Sayının ilk değeri " + sayi0);
            sayi0 = sayi0 - 1;
            Console.WriteLine("Sayının bir alt değere inmiş hali : " + sayi0);
            sayi0 -= 1;
            Console.WriteLine("Sayının bir alt değere inmis hali : " + sayi0);
            sayi0--;
            Console.WriteLine("Sayının bir alt değere inmiş hali :" + sayi0);
            #endregion

            Console.ReadLine();
        }
    }
}
