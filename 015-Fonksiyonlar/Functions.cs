using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_Fonksiyonlar
{
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }
        #region Örnek1
        int ToplamaYap(int s1, int s2, int s3)
        {
            int toplam = s1 + s2 + s3;

            //Bir metottan cıkan sonucu dış dünyaya döndürmek için kullandığımız anahtar kelime ... ,
            return toplam;
        }
        int ToplamaYap(int s1, int s2)
        {
            int toplam = s1 + s2;

            //Bir metottan cıkan sonucu dış dünyaya döndürmek için kullandığımız anahtar kelime ... ,
            return toplam;
        }
        string isimbas(string ad)
        {
            return "merhabalar" + ad;
        }
        #endregion
        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sonuc = ToplamaYap(50, 60, 90);
            //MessageBox.Show(sonuc.ToString());

            this.Text = ToplamaYap(90, 50, 60).ToString();
            MessageBox.Show(ToplamaYap(80, 70, 80).ToString());

            MessageBox.Show(Math.Pow(ToplamaYap(1, 3, 4), 2).ToString());

            // this.Text = isimbas("BilgeAdam");
        }

        private void btnDegerKontrol_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen değerin teklik ciftlik durumuna bakarak ciftse  -1 tekse 1 0'a eşitse 0 olarak geriye değer döndüren metot yazınız
            int gelendeger = TekCiftKontrol(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(gelendeger.ToString());
        }
        int TekCiftKontrol(int girilendeger)
        {
            int sonuc;

            if (girilendeger == 0)
            {
                sonuc = 0;
            }
            else if (girilendeger % 2 == 0)
            {
                sonuc = -1;
            }
            else
            {
                sonuc = 1;
            }
            return sonuc;
        }

        private void btnAdSoyad_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KelimeDegistirici(txtAd.Text, txtSoyad.Text));
        }
        //2 adet textbox ad soyad 
        //Dışarıdan girilen ilk kelimenin ilk iki harfini buyuk geri kalanı kücük aliniz..
        //ikinci kelimeni  içerisinde geçen tüm e'leri a ile değiştiriniz... 
        //ve sonuna @bilgadam.com ekleyerek geri döndürünüz....
        string KelimeDegistirici(string ad, string soyad)
        {
            string degimisAd = ad.Substring(0, 2).ToUpper() + ad.Substring(2, ad.Length - 2).ToLower();
            string degimisSoyad = soyad.Replace('e', 'a');

            // return degimisAd + degimisSoyad + "@bilgeadam.com";

            return $"{degimisAd}{degimisSoyad}@gmail.com";
        }


        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KelimeDegistirici(txtAd.Text, txtSoyad.Text));
        }
        private void btnKarekok_Click(object sender, EventArgs e)
        {
            int[] gonderilecek = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            MessageBox.Show(kar(gonderilecek).ToString());
        }
        //Parametre olarak bir kontrol metot yazınızçBu metot ilgili kontrolün arkaplan rengini (color) geri döndürüsn .
        //daha sonra metottan gelen herhangi bir yere atayabilrisiniz..


        Color ArkaPlandaYakalici(Control ArkaplaniyakalacakolanKontrolOgesi)
        {
            return ArkaplaniyakalacakolanKontrolOgesi.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            private void btnrenkyakalayici_Click(object sender, EventArgs e)
            {
                this.BackColor = ArkaPlandaYakalici(btn);
            }
        }
    }
}
