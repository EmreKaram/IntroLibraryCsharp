using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_Karar_Yapıları_If_Else_
{
    public partial class Reyon_Bul : Form
    {
        public Reyon_Bul()
        {
            InitializeComponent();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            if (txt_Ad.Text=="admin"&&txt_Sifre.Text=="1234")
            {
                MessageBox.Show("Tebrikler, Tüm bilgiler doğru!");
            }
            else
            {
                MessageBox.Show("Kullanıcı adi ve ya Şifre yanlış!");
            }
        }

        private void btn_NotKontrol_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(txt_Not.Text);
            string mesaj = "";

            if (not >= 0 && not <= 30)
            {
                mesaj = "Harf Notnuz: FF";
            }
            else if (not >= 31 && not <= 49)
            {
                mesaj = "Harf Notunuz: DD";
            }
            else if (not >= 50 && not <= 69)
            {
                mesaj = "Harf Notunuz: BB";
            }
            else if (not >= 70 && not <= 100)
            {
                mesaj = "Harf Notunuz: AA";
            }
            else
            {
                mesaj = "Not gerçerli değil!";
            }
            MessageBox.Show(mesaj);
        }

        private void btn_ReyonBul_Click(object sender, EventArgs e)
        {
            string mesaj = "";

            if (txt_Urun.Text == "Domates" || txt_Urun.Text == "Biber" || txt_Urun.Text == "Patlıcan")
            {
                mesaj = "Sebze reyonu reyonu buyrun";

            }
            else if (txt_Urun.Text == "Diş Macunu" || txt_Urun.Text == "Parfüm" || txt_Urun.Text == "Şampuan")
            {
                mesaj = "Kozmetik Ürünleri reyonu buyrun";

            }
            else if (txt_Urun.Text == "Bilgisayar" || txt_Urun.Text == "Cep Telefonu" || txt_Urun.Text == "Ses Sistemleri")
            {
                mesaj = "Teknoloji reyonu buyrun";
            }
            else
            {
                mesaj = "Bu ürün bu markette mevcut değil";

            }
            DialogResult dialog = MessageBox.Show(mesaj, "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            int deger = Convert.ToInt32(dialog);


            if (deger == 6)
            {
                MessageBox.Show("Evete bastınız!");
            }
            else
            {
                MessageBox.Show("Hayır Bastınız!");
            }
        }

        private void btn_Satisİslemi_Click(object sender, EventArgs e)
        {
            double birimFiyat = 5;
            double alinanSiparisMiktari = Convert.ToDouble(txt_Miktar.Text);
            double ToplamOdenenekTutar = 0;

            if (alinanSiparisMiktari > 0 && alinanSiparisMiktari <= 20)
            {
                ToplamOdenenekTutar = (birimFiyat * alinanSiparisMiktari) * 0.95;
            }
            else if (alinanSiparisMiktari >= 21 && alinanSiparisMiktari <= 50)
            {
                ToplamOdenenekTutar = (birimFiyat * alinanSiparisMiktari) * 0.90;
            }
            else if (alinanSiparisMiktari >= 51 && alinanSiparisMiktari <= 100)
            {
                ToplamOdenenekTutar = (birimFiyat * alinanSiparisMiktari) * 0.85;
            }
            else if (alinanSiparisMiktari > 100)
            {
                ToplamOdenenekTutar = (birimFiyat * alinanSiparisMiktari) * 0.75;
            }
            MessageBox.Show("Ödemeniz gereken tutar : " + ToplamOdenenekTutar + " TL");
        }
    }
}
