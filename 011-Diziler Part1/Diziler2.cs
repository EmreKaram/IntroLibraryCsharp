using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_Diziler_Part1
{
    public partial class Diziler2 : Form
    {
        public Diziler2()
        {
            InitializeComponent();
        }

        string[] arabalar = { "Mercedes", "Ferrari", "Bugatti", "Lamborghini", "Audi", "Seat", "Honda", "Alfa Romeo" };

        private void btn_Ornek1_Click(object sender, EventArgs e)
        {
            //Dizininin eleman sayısını bilmiyoruz ,ancak bizden istenen son  elemanı kullanıcaya nasıl gösterirdiniz.
            string sonElaman = arabalar[arabalar.Length - 1];
            MessageBox.Show("Son Eleman =>" + sonElaman);
        }

        private void btn_Ornek2_Click(object sender, EventArgs e)
        {
            //Rastgele olarak bir dizi'nin elemanını formun tepesine yazdırırn.
            Random rnd = new Random();
            int karmasıkindex = rnd.Next(0, arabalar.Length);
            this.Text = arabalar[karmasıkindex];
        }

        int[] sayilar = { 10, 20, 30, 40, 50 };
        int index = 0;
        int havuz = 0;

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            //buttona her bastiğimde , ilk elemdan başlayarak sirasi ile dizinin tüm elemanlarını listbox'a ekleyiniz. 
            //ancak eklediğiniz her elemani da bir  havuzda toplarak anlık olarak elemanların toplam değerlerini gösteriniz.

            if (index < sayilar.Length)
            {
                ElemanListele.Items.Add(sayilar[index]);
                havuz += sayilar[index];
                this.Text = "Şuana denk toplam değerimiz => " + havuz;
                index++;
            }
            else
            {
                MessageBox.Show("Dizinin son elemanına geldik haberin olsun:");
            }
        }
    }
}
