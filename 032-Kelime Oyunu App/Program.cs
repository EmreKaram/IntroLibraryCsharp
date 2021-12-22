using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_Kelime_Oyunu_App
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                string[] kelimeler = { "istanbul", "ankara", "manisa", "izmir", "bursa", "afyon", "adana" };
                int sayac = 5, tahminsayac = 0;
                double puan = 0;
                bool dogruMu = false;
                string secilenKelime = "";

                secilenKelime = kelimeler[rnd.Next(kelimeler.Length)];
                string[] oyun = new string[secilenKelime.Length];
                puan = secilenKelime.Length * 100;
                Console.WriteLine("Hakkınız: {0} \npuanınız: {1}", sayac, puan);

                for (int i = 0; i < oyun.Length; i++)
                {
                    oyun[i] = "-";
                    Console.WriteLine(oyun[i] + " ");
                }
                do
                {
                    Console.WriteLine("\n\nTahmininizi yazınız: ");
                    string tahmin = Console.ReadLine();
                    dogruMu = false;
                    if (tahmin.Length == 1)
                    {
                        for (int j = 0; j < secilenKelime.Length; j++)
                        {
                            if (tahmin.ToLower() == secilenKelime[j].ToString())
                            {
                                oyun[j] = tahmin.ToLower();
                                tahminsayac++;
                                dogruMu = true;
                            }
                            Console.WriteLine(oyun[j] + " ");
                        }
                        if (tahminsayac == secilenKelime.Length)
                        {
                            Console.WriteLine("\nTebrekler kazandınız...");
                            break;
                        }
                    }
                    if (tahmin.Length == secilenKelime.Length)
                    {
                        if (tahmin == secilenKelime)
                        {
                            Console.WriteLine("\n tebrikler kazandınız..");
                            break;
                        }
                        else
                        {
                            dogruMu = false;
                        }
                    }
                    if (!dogruMu)
                    {
                        sayac--;
                        puan = puan - (puan * 0.15);
                        Console.WriteLine("\n\nKalan hakkınız: {0}\n kalan puanınız {1}", sayac, puan);
                    }
                    if (sayac == 0)
                    {
                        Console.WriteLine("Hakkkınız bitti bilemediniz.");
                    }
                } while (sayac > 0);
                Console.WriteLine("lütfen tekrar oynamak isterseniz <e>basınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                {
                    break;
                }
            } while (true);
        }
    }
}
