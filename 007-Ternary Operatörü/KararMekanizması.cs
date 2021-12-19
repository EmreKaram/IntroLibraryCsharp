using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_Ternary_Operatörü
{
    public partial class KararMekanizması : Form
    {
        public KararMekanizması()
        {
            InitializeComponent();
        }

        //Terary Operatoru:
        //Tek satırda ufak bir karar mekanizması ile yolunuza devam etmek istiyorsunuz, ? ile birlikte kullanılır.
        //Yazim Formati : 
        //(KarsıalaştırmaOperatorü) ? Durumun olumlu olması durumunda çalışması gerekn kod :"Durumun olumsuz olması durumunda çalıştıracak kodlar."
        private void KararMekanizması_Load(object sender, EventArgs e)
        {
            string girilenDeger = "Bilge Adam";

            MessageBox.Show(girilenDeger=="Bilge Adam"?"Doğru":"Yanlış");

            string sonuc = 10 < 0 ? "Küçüktür" : "Büyüktür";
        }

        private void btn_Ternary_Click(object sender, EventArgs e)
        {
            //Eğer kullanıcı bir değer girdiyse MessageBox'la göster.Girmemiş ise defaulr bir değer göster.

            string girilenDeger = txt_DegerAl.Text.Length > 0 ? txt_DegerAl.Text : "Default deger.";

            MessageBox.Show(girilenDeger);
        }
    }
}
