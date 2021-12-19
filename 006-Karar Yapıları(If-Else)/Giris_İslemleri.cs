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
    public partial class Giris_İslemleri : Form
    {
        public Giris_İslemleri()
        {
            InitializeComponent();
        }
        Random karmasikSayiUret;
        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==lbl_RastgeleKarakterler.Text)
            {
                MessageBox.Show("Başarılı Giriş:");
            }
            else
            {
                int kalanHak = Convert.ToInt32(lbl_KalanHakkımız.Text);
                kalanHak--;
                lbl_KalanHakkımız.Text = kalanHak.ToString();
                if (lbl_KalanHakkımız.Text!="0")
                {
                    karmasikSayiUret = new Random();
                    int gelenSayi = karmasikSayiUret.Next(1000000, 1000000000);
                    lbl_RastgeleKarakterler.Text = Convert.ToString(gelenSayi);
                }
                else
                {
                    btn_GirisYap.Enabled = false;
                    double deger = Convert.ToDouble(lbl_RastgeleKarakterler.Text);
                    double x = deger / 2;
                    MessageBox.Show("Giriş hakkınız kalmaması nedeni ile sistem kendini kapatacaktır!"+x.ToString());
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_GirisYap.Enabled = false;
        }
    }
}
