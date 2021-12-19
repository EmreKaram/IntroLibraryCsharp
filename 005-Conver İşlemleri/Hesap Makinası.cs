using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_Conver_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bir veri tipindeki deişkenin diğer bir veri tipine çevirmek için ihtiyacımız olan yardımcı bir sınıf vardır.
            //Bu sınıf adı "Convert" sınıfıdır. 
            //Burada bir istisnadan bahsetmekte fayda var .Dış dunyaya gösterilecek olan ne varsa , bu değerler mutlaka metinsel -string-
            //veri tipinde olmalıdır dolayısı ile bir değeri string'e cevrimek için .net bize bir kolaylık sunar.

            int sayi = 25;
            //Unutulmaması gereken kısım  ,veriyi string'e cevirirseniz ,cevirdiğiniz andan itibaren  üzerindeki bütün matematiksel fonksiyonlarını kaybeder.

            MessageBox.Show(Convert.ToString(sayi));
            MessageBox.Show(sayi.ToString());

            string cevrilecekdeger = "123";
            int cerilendeger = Convert.ToInt32(cevrilecekdeger); //=>int'cevirme
            byte cevrilenİki = Convert.ToByte(cevrilecekdeger);//=>byte'cevirme
            short cevirlenuc = Convert.ToInt16(cevrilecekdeger);//=>short'cevirme
            long cevrilendort = Convert.ToInt64(cevrilecekdeger);//=>long'cevirme

            float cevrilendeger = Convert.ToSingle(cevrilecekdeger);//=>float'cevirme

            bool sonuc = true;
            MessageBox.Show(sonuc.ToString());

            //txtİkinciDeger.Text = "metin1";
            //txtBirinciDeger.Text = "Metin2";
        }

        private void btn_Toplama_Click(object sender, EventArgs e)
        {
            int cevrilenDegerBir = Convert.ToInt32(txt_BirGelenMetin.Text);
            int cevrilenDegerİki = Convert.ToInt32(txt_İkiGelenMetin.Text);

            int MatematikselToplam = cevrilenDegerBir + cevrilenDegerİki;

            MessageBox.Show(MatematikselToplam.ToString());
        }

        private void btn_Cıkartma_Click(object sender, EventArgs e)
        {
            int cevrilenDegerBir = Convert.ToInt32(txt_BirGelenMetin.Text);
            int cevrilenDegerİki = Convert.ToInt32(txt_İkiGelenMetin.Text);

            int MatematikselFark = cevrilenDegerBir - cevrilenDegerİki;

            MessageBox.Show(MatematikselFark.ToString());
        }

        private void btn_Carpma_Click(object sender, EventArgs e)
        {
            int cevrilenDegerBir = Convert.ToInt32(txt_BirGelenMetin.Text);
            int cevrilenDegerİki = Convert.ToInt32(txt_İkiGelenMetin.Text);

            int MatematikselCarpım = cevrilenDegerBir * cevrilenDegerİki;

            MessageBox.Show(MatematikselCarpım.ToString());
        }

        private void btn_Bolme_Click(object sender, EventArgs e)
        {
            int cevrilenDegerBir = Convert.ToInt32(txt_BirGelenMetin.Text);
            int cevrilenDegerİki = Convert.ToInt32(txt_İkiGelenMetin.Text);

            int MatematikselBolme = cevrilenDegerBir / cevrilenDegerİki;

            MessageBox.Show(MatematikselBolme.ToString());
        }
    }
}
