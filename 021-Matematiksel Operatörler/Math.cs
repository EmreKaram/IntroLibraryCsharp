using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_Matematiksel_Operatörler
{
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }

        private void Math_Load(object sender, EventArgs e)
        {

        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba Dünya","Mesaj",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            int sayiBir = 102;
            int sayiİki = 25;
            int toplam = sayiBir + sayiİki;

            MessageBox.Show("Toplamanın Sonucu :  " + toplam);
            //Aşağıdaki  toplam değişenn, string'e cevirmeden yazdığımız halde derleyicinin bize kızmasının sebebi "imlicit convert" dediğimiz işlemdir. 

            //Yani ,eğer bir toplam işleminde string varsa ,geriye kalan tüm değerler otomatik olarak string'e dönüştürülür. 

            MessageBox.Show("Toplam sonuc: " + (sayiBir + sayiİki));
            MessageBox.Show("Toplam Sonuc: " + sayiBir + sayiİki);//10225
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int sayiBir = 102;
            int sayiİki = 25;

            int carpma = sayiBir * sayiİki;
            MessageBox.Show("Carpma Sonucu : " + carpma);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            double sayiBir = 102;
            double sayiİki = 10;
            double Bol = sayiBir / sayiİki;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int sayi1 = 15;
            int sayi2 = 4;

            int kalan = sayi1 % sayi2;
            MessageBox.Show("Kalan: " + kalan);
            MessageBox.Show(sayi1 + "'in " + sayi2 + "'e bölümünden kalanı:" + kalan + "'dır.");
        }

        private void btnBirBir_Click(object sender, EventArgs e)
        {
            int sayi = 15;

            sayi++;
            MessageBox.Show("Sayının bir artmış hali : " + sayi);

            sayi = 15;
            sayi--;
            MessageBox.Show("sayının bir azaltılmış hali " + sayi);
        }
    }
}
