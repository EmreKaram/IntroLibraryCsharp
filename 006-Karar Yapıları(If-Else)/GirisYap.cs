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
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void btn_AdminKontrol_Click(object sender, EventArgs e)
        {
            if (txt_GirisAlani.Text=="bilgeadam")
            {
                MessageBox.Show("Hoş geldin admin");
            }
            else
            {
                MessageBox.Show("Tanıyamadım");
            }
        }

        private void btn_NotKontrol_Click(object sender, EventArgs e)
        {
            //Eğer girilen not 0'dan kucukse "0'dan kucuk bir not girişi yapmamalısın" 100'den buyukse "100'den buyuk bir not girişi yapmamalısın"

            int not = Convert.ToInt32(txt_GirisAlani.Text);
            if (not<0)
            {
                MessageBox.Show("0'dan kucuk bir not girisi yapamazsınız.");
            }
            else if (not>100)
            {
                MessageBox.Show("100'den buyuk bir not girisi yapamazsın.");
            }
            else
            {
                MessageBox.Show("Hatasız Not Girişi.");
            }
        }

        private void brn_CiftOrTek_Click(object sender, EventArgs e)
        {
            //txtGirisAlano 'kısmından girilen sayi çift ise sayı çifttir mesajı versin ,tek ise sayı tektitr desin.

            int GirilenDeger = Convert.ToInt32(txt_GirisAlani.Text);
            if (GirilenDeger%2==0)
            {
                MessageBox.Show("Çift");
            }
            else
            {
                MessageBox.Show("Tek");
            }
        }

        private void btn_DegerKontrolu_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen kelimenin uzunluğu 8 karaktere eşit yada buyük ise  kayıt onaylandı ,
            //değilse daha uzun bir şifre giriniz.

            if (txt_GirisAlani.Text.Length>=8)
            {
                MessageBox.Show("Kayıt Onaylandi");
            }
            else
            {
                MessageBox.Show("Daha uzun bir şifre yazınız.");
            }

        }
        /* 
         Uygulamamzın çalışması esnasında farklı senaryolara göre farklı yönlendirmeler yapmamız gerekbilir.
        //Örneğin kullanıcıdan gelen değerin aralığına göre uygulamadaki mantkısal işlemleriniz sonuçlarına göre yönlendirmeler yapılabilir.

        1)== (Karşılık olarak iki değerin bibiri ile eşit olması durumu )
        2)!= (Karşııklı iki değerin biribiyyle eşit olma durumu )
        3)< (Soldaki deperin sağdaki değernde küçük olması)
        4)> (soldaki değerin sağdaki değerden büyük olması)
        5)<= (soldaki değerin sağdaki değerden küçük yada eşit olması durumu)
        6)>= (soldaki değerin sağdaki değerden büyük yada eşit olması durumu)

         */
    }
}
