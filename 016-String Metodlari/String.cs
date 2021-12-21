using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_String_Metodlari
{
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();
        }
        //Sahip olduğunuz metinsel değerlerin özelliklerini değiştirmek için kullanılan hazır metotlardır. 
        //Örneğin: Kelimeleri parçalamak,eklemek,harflerin yerlerini değiştirmek ,boşluk temizlek.

        string ornekMetin;
        private void btnMetin_Click(object sender, EventArgs e)
        {
            // Compareto: Metodu kullandığınız string değerle metoda verdiğiniz paramteredeki string değeri sözlük mantığı ile kar5şılaşitırması beklenir.
            // Eğer sözlükde aynı lokasyonda ise 0 parametredeki değer ,ana değerimizden önceki sözlükte ise -1 sonra ise 1  döndürmesi beklenir.

            ornekMetin = txtGirisAlani.Text;

            int sonuc = ornekMetin.CompareTo("bilgeadam");

            //0,1,-1; 
            string mesaj = "";
            switch (sonuc)
            {
                case -1:
                    mesaj = "Kelime diğer kelime ile eşleşmemektedir.. eksik karakter olabilir..";
                    break;

                case 0:
                    mesaj = "Tebrikler Kelimeler Eşleşmektedir.";
                    break;
                case 1:
                    mesaj = "Kelime diğer kelime ile eşlememektedir. Fazla Karakter Olabilir.. .";
                    break;
                default:
                    break;
            }
            MessageBox.Show(mesaj);
        }

        private void brnContains_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            bool varmi = ornekMetin.Contains("adam");
            MessageBox.Show("Aradığınız değer" + (varmi ? " bulunmaktadır" : " bulunmamaktadır."));
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //İndexOf
            //sTRİNGLERDE Birer char dizileridir.
            //indexof =>> dizilerde gördüğümüz metodun aynı prensibi ile çalışır.
            //Eğer harf varsa harfin indexini ,yokse -1değerini ,harf birden fazla ise ilk index değerini döndüdür.

            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.IndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            //StartWith =>> kelimenizin parametrede gönderdiğiniz değerle başlayıp başlamadığını size "bool" olarak döndüdür.
            
            ornekMetin = txtGirisAlani.Text;
            //ornekMetin.StartsWith("bil");
            MessageBox.Show(ornekMetin.StartsWith("bil") ? "Kelime\"bil\" ile başlamaktadır." : "Kelime \"bil\" ile başlamamaktadır.");
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            //StartWith =>> kelimenizin parametrede gönderdiğiniz değerle bittiğini size "bool" olarak döndürür.
           
            ornekMetin = txtGirisAlani.Text;
            MessageBox.Show(ornekMetin.EndsWith("bil") ? "Kelime\"bil\" ile başlamaktadır." : "Kelime \"bil\" ile başlamamaktadır.");
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            //LasrİndexOf
            //sTRİNGLERDE Birer char dizileridir.
            //Lastindexof =>> dizilerde gördüğümüz metodun aynı prensibi ile çalışır.
            //Eğer harf varsa harfin indexini ,yokse -1değerini ,harf birden fazla ise son index değerini döndüdür.

            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.LastIndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            //Not:Bir string üzerinde yaptuğınız  değişiklikler o string'i değiştirmez,size yeni bir kopyasını teslim eder. 
            //1.kullanım =>> verdiğiniz index numarası dahil ,o indeksiteki ve sonraki tüm karakterleri ortandan kaldırcaktır.
            //2.kullanımm =>> verdiğiniz index numarasi dahil ,o indexktei elemadan başlayaral,ikinci parametrede gönderdiğiniz değere kadar elemanları silecektir.

            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Remove(5);//Birinci kullanım
            ornekMetin = ornekMetin.Remove(3, 2);
            MessageBox.Show(ornekMetin);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Replace("adam", "kadın");
            MessageBox.Show(ornekMetin);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            //split=>> Metninizi özel bir karakterden birden fazla parçaya ayırmanızı olanak sağlayan metotdur.

            string mailadresleri = txtGirisAlani.Text;
            string[] adresler = mailadresleri.Split(';', ',');
            foreach (string item in adresler)
            {
                MessageBox.Show(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Insert =>>bir metinsel değerin herhangi bir pozisyonunda (index)yeni bir değeri iliştirmek istiyorsanız bu metodu kullanabilirisiniz. ..
            //ilkparametre kacıncı indexden sonra ekleyeceiğini ikinci paramtre ise sizden değeri bekeleyecektir.. .

            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Insert(5, "cik");
            MessageBox.Show(ornekMetin);
        }

        private void brnLoweToUpper_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            this.Text = ornekMetin.ToLower();
            MessageBox.Show(ornekMetin.ToUpper());
        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;//=>1.kullanım
            ornekMetin = ornekMetin.Substring(3, 2);//=>2.kullanım
            MessageBox.Show(ornekMetin);
        }

        private void btnToCharArray_Click(object sender, EventArgs e)
        {
            //btnToCharArray =>>Stringlerinizi charlarırna ayırarak char dizi siz verir. ..

            ornekMetin = txtGirisAlani.Text;
            char[] Karakterleri = ornekMetin.ToCharArray();

            //disarıdan girilen metindeki her bir karaktrein ascıı değerlerlerinin toplamı kaçtır ??
            int havuz = 0;

            for (int index = 0; index < Karakterleri.Length; index++)
            {
                havuz += Karakterleri[index];
            }

            MessageBox.Show(havuz.ToString());
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            //Trim metnizi sağından solundan tüm boşukları temizler.... 

            ornekMetin = txtGirisAlani.Text;
            string yenimetin = ornekMetin.Trim();
            MessageBox.Show(string.Format("Boşluklarla hesaplalan karakter sayısı : {0}\n Boşuklardan temizlenip hesaplanan karaktersayı:{1}"
            , ornekMetin.Length, yenimetin.Length));
        }
    }
}
