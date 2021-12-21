using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Lab_Operatörleri
{
    class Lab
    {
        static void Main(string[] args)
        {
            #region Çalışma
            //Console.WriteLine("Lütfen birinci sayıyı giriniz.;: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int topla = sayi1 + sayi2;
            //Console.WriteLine("Toplama işlemi sonucu : " + topla);
            //string a = "50";
            //int b = 40;
            //int aduzelnemis = Convert.ToInt32(a);
            //int sonuc = aduzelnemis + b;
            //string yenideger = Convert.ToString(b);
            //string yanyanabastır = a + yenideger;
            //Console.WriteLine(sonuc);
            //Console.WriteLine(yanyanabastır);
            //string ondalıkdeger = "20.50";

            //double deger5 = Convert.ToDouble(ondalıkdeger);
            //Console.WriteLine(deger5);
            //Console.ReadLine();
            #endregion

            #region Örnek1
            //Dışardan alinan iki sayinin toplamı ile farkının birbirlerine bolümunden kalanın sonucu kaçtır (Farkın toplama bolümünden kalan kaçtır..)

            //Console.WriteLine("Lüffen birinici sayı giriniz : ");
            //int sayi1 =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Lütfen ikinici sayııy girebilirmisiniz ");
            //int sayi2 =Convert.ToInt32 ( Console.ReadLine());

            //int toplam = sayi1 + sayi2;
            //int fark = sayi1 - sayi2;
            //int bolumundenkalan = toplam % fark;
            //Console.WriteLine("İşlemin Sonucu: " + bolumundenkalan);
            #endregion

            #region Örnek2
            //Dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının 2ye bölümünden kalanın karesi kaçtır ??
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //double sayi=   Convert.ToDouble(Console.ReadLine());
            //double sonuc = (sayi - 10 + 20) % 2;
            //double karesi = sonuc * sonuc;
            ////double karesi = Math.Pow(sonuc, 2);
            //Console.WriteLine("İşlemin Sonucu : "+karesi);
            #endregion

            #region Örnek3
            //Dışarıdan girilen iki sayının karelerinin toplami ile karalerinin farkı toplamı kaçtır..
            //Console.Write("Lütfen birinci sayıyı giriniz : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz.");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());


            //int birinciKare = sayi1 * sayi1;
            //int ikinciKare = sayi2 * sayi2;

            //int toplam = birinciKare + ikinciKare;
            //int Fark = birinciKare - ikinciKare;


            //int result = toplam + Fark;
            //Console.WriteLine("İşlem Sonucu  "+ result);
            #endregion

            #region Örnek4
            //Vize notu 'nun  %30'nu final notunun %70'ini alıp öğrencinin not ortalamasını cıkaran uygulamayı yazınız.. =>=>Dikkat: Notlar Ondalikli olabilir.. 

            //Console.WriteLine("Lütfen vize notunuzu giriniz . ");
            //double vizenot = Convert.ToDouble( Console.ReadLine());
            //Console.WriteLine("Lütfen   final notunu giriniz. ");
            //double Finalnot = Convert.ToDouble(Console.ReadLine());
            //double sonuc = (vizenot * 0.30) + (Finalnot * 0.70);
            //Console.WriteLine("Öğrencinin not ortalamasi : " +sonuc);
            #endregion

            #region Örnek5
            //Dışarıdan kullanıci adını ve soyadını ayrı ayrı olacak şekilde alınız ve adi.soyadi@bilgeadam.com şeklinde mail adresi oluşturuo kullanıcıya gösteriniz..

            Console.WriteLine("Lütfen Adnınızı giriniz ");
            string adi = Console.ReadLine();
            Console.WriteLine("LütFen soyadı giriniz ");
            string soyad = Console.ReadLine();

            Console.WriteLine("Oluşturulan mail adresiniz:  " + adi + "." + soyad + "@bilgeadam.com");
            #endregion

            Console.ReadLine();
        }
    }
}
