using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Değişkenler
{
    class Değişkenler
    {
        //Değişken Nedir ?

        //Değişkenleri en sabit şekilde verilerin depolandığı yerler olarak tanımlayabiliriz.
        //Değişkenler içerisindeki verilerimizi C# programlama dili içerisindeki işlemlerimizde kullanabiliriz.

        //1) Asla kullanmayacağınız bir değişken tanımlamayınız.
        //2) Değer aralıklarına göre veri tiplerini seçmeye özen gösteriniz.
        //(Değişken Yöntemi Başarısı = Başarılı Bir Performans Yöntemi)
        //3) Bir değişkenin adı asla iki kelimeden oluşmaz.
        //Eğer iki kelime ise mutlaka izin verilen özel bir karakter ile birbirlerine bağlamanız gerekmektedir (_)
        //4) Değişken adları asla sayı ile başlamaz.
        
        #region Sayisal Veri Tipleri:
        static void Main(string[] args)
        {
            //Sayisal veri tipleri: 

            //Değişken tanımlama Formati 

            //Veritipi degiskenadi = değişkendeğeri;

            //sbyte =>> 8 bit
            //Min Value =>> -128
            //Max Value=>> 127
            sbyte o1 = 40;

            //byte =>> 8bit 
            //Max Value =>> 255
            //Min Value =>> 0
            byte o2 = 40;

            //short =>> 16 bit
            //MaxValue =>> 32767
            //Min Value =>> -32768
            short o3 = 80;

            //ushort =>> 16 bit
            //Max Value =>> 65535 
            //Min Value =>> 00;
            ushort o4 = 564;

            //int => 32 bit 
            //Max Value =>> 2.1 MİLYAR
            //Min Value =>>-2.1 mİLYAR 
            int o5 = 32;

            //uint =>> 32bit 
            //Max Value =>> 4.2 Milyar
            //Min value =>> 0
            uint o6 = 60;

            //long =>>64 Bit
            //Max Value =>> 9Katrilyon
            //Min Value =>> -9Katrilyon
            long o7 = 3243242323233243234;

            //ulong =>> 64 bit 
            //Max Value =>> 9.katrilyon*2
            //Min Value =>> 0 
            ulong o8 = 3239042112341231234;
        }
        #endregion
        #region Ondalık Veri Tipleri:
        static void Main2(string[] args)
        {
            //float => .'dan sonra 7 haneye kadar değer alabilir. =>> 32 bit 
            float ondalikbir = 1.854F;

            //double =>> .'dan sonra 13-14 hane desteği  vardır. =>> 64 bit
            double ondalikiki = 2.545454;

            //decimal =>> .'dan sonra 27-28 hane desteği mevcuttur. ==> 128 bit 
            decimal ondalikUc = 6.5454524454M;
        }
        #endregion
        #region Metinsel Veri Tipleri:
        static void Main3(string[] args)
        {
            //Char =>> Uzerinde tek bir karakteri barındırabilen veritipimizdir. 
            char Basharf = 'o'; // 16 bit =>> Unicode Karakter.
            char ozelKarakterim = '$';

            //string  =>> üzerinde  ansiklopedik verilerden tutun da iki  üç karajterlik verilere
            //kadar tüm metinsel ifadeler  üzerinde kullanılabilir. 
            string bosMetin = "";
            string uzunMetin = "Buraya çok uzun metinler yazılablir.Alan olarak sınırı yoktur..";

            // /n=>> ondalikbir alt satıra geçmek için kullanılan kaçışkarakteri.
            string ikisatirlikmetin = "Burası birinci satır \n Burası ikinci satır ";
            Console.WriteLine(ikisatirlikmetin);

            // \t =>> Metin arasında bir tablık boşluk bırakmak için kullanılır.
            string tabliMetin = "Merhaba Dünya.\t Nasılsın Dünya";
            Console.WriteLine(tabliMetin);

            Console.ReadKey();
        }
        #endregion
        #region Mantıksal Veri Tipleri:
        static void Main4(string[] args) 
        { 
        bool bugunTatilmi = false;
        bool dersKaydiVarmi = true;
        bool buyukmu = 10 > 2;
        }
        #endregion
    }
}
