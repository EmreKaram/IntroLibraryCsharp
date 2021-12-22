using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _029_Array_List
{
    public partial class ArrayList : Form
    {
        public ArrayList()
        {
            InitializeComponent();
        }

        /*Array List
           * 
           * Bu zamana kadar gördüğünüz ilkel dizilerin (veritipi[] olarak tanımlamamaları olan) en büyük farkı tip bağımlılığı ve eleman adeti zorunluluğunun olmasıdır.
           * 
           * Ancak arraylist nesnesiyle birlikte bu bağımlıklar ortandan kalktı.Bir arraylist meydana gelirken 
           * ne eleman sayısı vermek zorundasınız nede veri tipi velirmek zorundasınız.
           * 
           * Dezavantajları nedir ?
           * Arraylist içerisindeki elemanları otomatik object veri tipinde döndürme ozelliğine sahiptir.(unbox..)
           * Dolayısı ile bu verileri geri almak istediğinizde mecburen "cast" yada "Convert"işlemine gerek duyulur..
           * Buda ekstradan maliyet ekstra iş demektir.
           * (object: unboxing işlemi )
           **/

        System.Collections.ArrayList yenidizi = new System.Collections.ArrayList();

        private void btnObject_Click(object sender, EventArgs e)
        {
            //object tipinmde der aldığı için herşeyi arraylistte saklayabilrisiniz... 

            yenidizi.Add("ylz3451");
            yenidizi.Add(123456);
            yenidizi.Add(true);
            yenidizi.Add(new DateTime());
            yenidizi.Add(new Form());

            yenidizi.Add("İİstanbul");

            yenidizi.Add("Ankara");

            yenidizi.Add("Manisa");

            yenidizi.Add("İzmir");
            yenidizi.Add("Eskişehir");
            yenidizi.Add("Antalya");
            yenidizi.Add("GaziAntep");

            foreach (var item in yenidizi)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnMetod_Click(object sender, EventArgs e)
        {
            this.Text = (string)yenidizi[0];

            //dizinin eleman sayısına ulşama
            this.Text = yenidizi.Count.ToString();
            //Elman dizide varmı yok mu bakar 
            this.Text = yenidizi.Contains("Eskişehir") ? "Bu sehir var" : "Bu sehir yok ";
            //dizideki elemanın iğndexini alma
            this.Text = yenidizi.IndexOf("İzmir").ToString();
            this.Text = yenidizi.LastIndexOf("İzmir").ToString();

            yenidizi.Insert(3, "Ankara");

            //verilen elemanı listeden kaldırır.
            yenidizi.Remove("İzmir");
            yenidizi.Sort();
            yenidizi.Reverse();
            // O anki kapasiteyi o anki eleman sayısında eşitler 

            yenidizi.TrimToSize();

            yenidizi.Clear();
        }
    }
}
