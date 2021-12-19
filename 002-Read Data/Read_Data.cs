using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Read_Data
{
    class Read_Data
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen isminizi ve soyisminizi giriniz:");

            string GelenMetin = Console.ReadLine();

            Console.WriteLine("Hoşgeldiniz " + GelenMetin + "\nÇıkmak için herhangi bir tuşa basınız");

            // \n metini bir alt satıra geçirmek için kullanılan kaçış karakterimizdir.

            //İşlem sonucunda çıkmak için herhangi bir tuşa basmanız yeterli olacaktır.

            Console.ReadKey();
                
           

        }
    }
}
