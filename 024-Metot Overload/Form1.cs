using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _024_Metot_Overload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Bir metotda overload işlemi (fazla yük)
         * ilgili metodun ayni adla tekrar oluşuturlamsınız.... 
         * metot overload edecekseniz ,metot imzalarına (parametre ,dönüş tipleri ) 
         * diikat ediniz .farklı parametre veya farklı dönüş tipi olmalıdır. 
         * 
         * Eğer metotlariniz açıklamalari ve metot paramtrelenin kısa bilgilendirmeleri olsun isterseniz ,metodun hemen üst satırına gelerek ard arda üc defa slash (/) tuşuna basmanız yeterlidir.Geriye sadece boşlukları doldurmak kalır.. 
         * Açılan alandaki summary alani ,metot özet ; param alani ise parametre açıklamalarıdır.. 
          */

        /// <summary>
        /// İş bu metot kullanarak mail adresi oluşturmanız mümkün : bu metot isimden gelen bilgi ile birlikte isminiz@hotmail.com olarak mesaj göstrebilir. .
        /// </summary>
        /// <param name="ad">isim bilgisinini giriniz</param>
        /// <param name="SunucuAdi">sunucu adını giriniz... </param>
        void MailOlusuturucu(string ad, string SunucuAdi)
        {
            MessageBox.Show(ad + "@" + SunucuAdi);
        }
        void MailOlusuturucu(string ad)
        {
            MessageBox.Show(ad + "@hotmail.com");
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            //Kullanicdan tercih ettiği adi ve tercih ettiği sunucu bilgisini alan birleştirip messagebox ile göstren bir uyuguglama yazınız

            if (comboBox1.SelectedIndex == -1)
            {
                MailOlusuturucu(textBox1.Text);
            }
            else
            {
                MailOlusuturucu(textBox1.Text, comboBox1.SelectedItem.ToString());
            }
        }
    }
}
