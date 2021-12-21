using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_Foreach
{
    public partial class Foreach : Form
    {
        public Foreach()
        {
            InitializeComponent();
        }

        string[] sehirler = { "Ankara", "İzmir", "İstanbul", "Manisa", "Eskişehir", "Trabzon", "Sivas", "Adana", "Malatya" };

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            foreach (var item in sehirler)
            {
                //item diye isimlendirilen değişkenin ,döngü devam edebilmesi için yardımcı aractır. 
                //Herhangi bir değeri yoktur 
                //(Foreach İterator)

                listBox1.Items.Add(item.ToString());
            }
        }

        int[] dizi = { 125, 64, 64, 8, 75, 12, 75, 15, 431, 87, 123, 5, 1, 5415, 41521, 54, 1, 3421, 543, 53 };

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            // ikiye bölünenleri listbox'1 e bölünmeyenleri  listbox2 'e attın.
            //Hem ikiye hemde uce bölünenlerin kaç tane olduğunu messagebox ile gösteriniz.

            int tabBolunenHavuz = 0;
            foreach (var sayi in dizi)
            {
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    tabBolunenHavuz++;
                }
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }
            }
            MessageBox.Show($"Bu dizinin hem iki hemde üçe tam bölünen  {tabBolunenHavuz} adet sayı varıdır.");

        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //lİSTbox1'deki seçili tüm elemanların (birden fazla seçim şansı olmalıdır.) listbox2'ye ekleyin.
            foreach (string eleman in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(eleman))
                {
                    listBox2.Items.Add(eleman);
                }
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Orange;
                    item.ForeColor = Color.Red;
                }
            }
        }
    }
}
