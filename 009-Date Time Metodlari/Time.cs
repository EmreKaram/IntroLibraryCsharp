using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_Date_Time_Metodlari
{
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();
        }
        //DateTime: Zamanla ilgili yapabileceğimiz tüm işlemleri ve tüm verileri size teslim eden nesnedir.

        private void btn_DateTime_Click(object sender, EventArgs e)
        {
            //Günün tarhini ve suanki saati alma.
            label1.Text = DateTime.Now.ToString();

            //Günün tarihini almak isterseniz. 
            label1.Text = DateTime.Now.ToLongDateString();
            this.Text = DateTime.Now.ToShortDateString();

            //Tarhi formatlayım.

            label1.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            //Artık yıl kontrolü 
            //bool artıkyilmi  =   DateTime.IsLeapYear(1989);

            //if (artıkyilmi)
            //{
            //    MessageBox.Show("Şubat 29 Çeker");

            //}
            //else
            //{
            //    MessageBox.Show("Değidir");  
            //}

            //Haftanın günününü nasıl alırız.
            string haftanınGunu = DateTime.Now.DayOfWeek.ToString();
            this.Text = haftanınGunu;

            //Yılın kaçıncı günü oldunu nasıl buluruz ?
            string YilinKacıncıGunu = DateTime.Now.DayOfYear.ToString();
            label1.Text = "Bugunun yilin " + YilinKacıncıGunu+ ".gündür.";
        }

        private void btn_TimeSpan_Click(object sender, EventArgs e)
        {
            //İki zaman arasındaki farkı alıp sizlere teslim eden nesnemizdir. 

            //Asağıda yapılan işlem ,anlik zamanda bagımsız yeni bir zaman dilimi olulşturma eylemidir. 

            //Parantez içerisnde sırası ile (yil,ay gün,saat,dakika,saniye)değerleri verilmiştir.

            DateTime yeniZaman = new DateTime(1995, 10, 05, 00, 00, 00);
            DateTime bugun = DateTime.Now;
            TimeSpan fark = bugun - yeniZaman;

            int toplamGun = Convert.ToInt32(fark.TotalDays);
            this.Text = toplamGun.ToString();

            MessageBox.Show(fark.ToString());
        }
    }
}
