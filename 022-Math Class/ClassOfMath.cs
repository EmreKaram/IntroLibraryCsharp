using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_Math_Class
{
    public partial class ClassOfMath : Form
    {
        public ClassOfMath()
        {
            InitializeComponent();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            this.Text = Math.PI.ToString();
            string deger = Math.PI.ToString();
            deger = deger.Substring(0, 4);
            this.Text = deger;
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            //Mutlak değer alıyormus..
            int mutlakdeger = Math.Abs(-50);
            this.Text = mutlakdeger.ToString();
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            //Floor =>>Verilen değeri ,bir alt değere tamamlar
            double deger = Math.Floor(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            // Ceiling =>> Verilen değeri ,bir alt değere tamamlar
            double deger = Math.Ceiling(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //Round =>>Sayinin yarsınından fazlasını bir üste, yarısından azini ise bir alt tam sayıya yuvarlar.
            //Not: .'dan önceki sayı çift ise bir alt değere ,tek ise bir üst değere tamamlar.
            double deger = Math.Round(12.50);
            MessageBox.Show(deger.ToString());
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            //Truncate=>sayının ondalıklı kısmına bakmaz ,yanlızca tam kismini size teslim eder.
            double deger = Math.Truncate(13.98);
            MessageBox.Show(deger.ToString());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int maksimumsayi = Math.Max(45, 65);
            MessageBox.Show(maksimumsayi.ToString());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int minimumsayi = Math.Min(45, 65);
            MessageBox.Show(minimumsayi.ToString());
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            //Pow =>> Kuvvet alma işlemlerini gerçekleştirir. İlk Paramtrede hangi sayının kuvveti alinacak,ikinci paramtrede ise üsttü (Kaçıncı kuvvetini alıcağını)size sorar
            double kuvvet = Math.Pow(3, 4);
            MessageBox.Show(kuvvet.ToString());
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            //sqrt =>> Bir sayının karekokunu hesaplamak için kullanılır..
            double deger = Math.Sqrt(16);
            MessageBox.Show(deger.ToString());
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            //Sign=>> Bir sayının negatif pozitif yada 0' aeşit olup olmadığıbna ilgili size bildirim verir. 
            //Eğer say negatif ise -1 ,pozitifse +1 0 ise 0 olarak değerini döner
            int sonuc = Math.Sign(-50);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnMinDegerHesapla_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen 3 sayidan en küçüğügünü tek satırda gösteriniz...

            int birincideger = Convert.ToInt32(textBox1.Text);
            int ikincideger = Convert.ToInt32(textBox2.Text);
            int ucuncuDeger = Convert.ToInt32(textBox3.Text);

            int mindeger = Math.Min(Math.Min(birincideger, ikincideger), ucuncuDeger);

            this.Text = "En Küçük deger ; " + mindeger;
            this.Text = $"En küçük değer {mindeger}";
        }
    }
}
