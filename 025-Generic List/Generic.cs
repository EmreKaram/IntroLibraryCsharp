using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _025_Generic_List
{
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
        }

        //list<> içerisinde (<t>) verilen tipe bürünerek ,o tipte bir kolleksiyon oluşturmanıza olanak sağlar dizi çeşididir.
        //Daha önce diziler gibi boyut arttırma işlemine gerek duymadan  eleman ekleyebilrisiniz ve array sınıfını kullanmanıza gerek yoktur.

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);

            foreach (int item in sayilar)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Edirne");
            sehirler.Add("İstanbul");
            sehirler.Add("Manisa");
            sehirler.Add("Bursa");

            foreach (var item in sehirler)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Edirne");
            sehirler.Add("İstanbul");
            sehirler.Add("Manisa");
            sehirler.Add("Bursa");


            //dizi elemanların küçükten büyüğe sıralar. .. 
            sehirler.Sort();

            //linq sınıfı kullanarak list<t> içerisinde gelişmiş metotları kullananabilrisiniz. ...
            sehirler.ForEach(x => MessageBox.Show(x));
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Edirne");
            sehirler.Add("İstanbul");
            sehirler.Add("Manisa");
            sehirler.Add("Bursa");

            MessageBox.Show(sehirler.Contains("Edirne") ? "serhirler dizi içerisnde edirne ili yer almaktadır. " : "Aradığınız il yoktur.");
        }
    }
}
