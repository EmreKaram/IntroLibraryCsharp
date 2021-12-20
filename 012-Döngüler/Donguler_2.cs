using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_Döngüler
{
    public partial class Donguler_2 : Form
    {
        public Donguler_2()
        {
            InitializeComponent();
        }

        private void btn_Ornek1_Click(object sender, EventArgs e)
        {
            string[] takimlar = { "Galatasaray", "Fenerbahçe","Beşiktaş","Trabzonspor","Bursaspor","Eskişehir",
                "Manisaspor","AnkaraGücü","Denizlispor","NiğdeSpor" };

            for (int i = 0; i < takimlar.Length; i++)
            {
                listBox1.Items.Add(takimlar[i]);
            }
        }

        private void btn_Ornek2_Click(object sender, EventArgs e)
        {
            //sayilsa bir dizi tanımı aşağıda verilmiştir .Array sınıfını kullanmadan bu dizinin en büyük elmanını bulup gösteriniz.
            int[] sayisal = { 12, 55, 23, 85, 7119, 25, 654, 321, 87, 98, 25, 21, 54, 54, 56, 87, 21, 694524 };
            int maxSayi = 0;

            for (int i = 0; i < sayisal.Length; i++)
            {
                if (maxSayi < sayisal[i])
                {
                    maxSayi = sayisal[i];
                }
            }
            MessageBox.Show("En bütük eleman =>" + maxSayi);
            MessageBox.Show(string.Format("En büyük deger: {0}", maxSayi));
        }

        private void btn_Ornek3_Click(object sender, EventArgs e)
        {
            //Aşağıdaki dizide kaç tane çift  kaç tane tek sayi varıdr .Kullanıcıya iletiniz.
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
            int tek = 0;
            int cift = 0;

            for (int i = 0; i < sayisal.Length; i++)
            {
                if (sayisal[i] % 2 == 0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }

            }
            //MessageBox.Show(string.Format("bu dizide toplamda {0} adet çift  sayi,{1}adet tek sayı bulunmaktadır", cift,tek));

            MessageBox.Show($"Bu dizide toplam{cift} adet sayi,{tek}adet sayı bulunamktadır.");
        }

        private void btn_Ornek4_Click(object sender, EventArgs e)
        {
            //Aşağıdaki metin değişkeninde yer alan metni tersen yazdırınız.
            //isterseniz.formun tepesine isterseniz mbox yazdırın.

            //Not :==>> Stringler birer char dizileridir. 

            string metin = "bilgeadam";
            string terstenyaz = "";
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                terstenyaz += metin[i];
            }
            //MessageBox.Show("Tersten Yazim =>" + terstenyaz);
            MessageBox.Show($"Tersten Yazim =>  {terstenyaz}");
        }

        private void btn_Ornek5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                int rasgelesayi = new Random().Next(0, 101);
                listBox1.Items.Add(rasgelesayi);
            }

            listBox1.Items.Clear();
            //Rastgele 10 adet sayii listboox içerisne ekleyiniz. 
        }

        private void btn_Ornek6_Click(object sender, EventArgs e)
        {
            //Form üzerinde yer alan butuonalrın arka plan renkleri kırmızı  yazi renkleri sari olsun.
            //Eğer karar  yapılarında bir tip kontrolü yapıyorsanız ==,1= gibi operatörler size cevap vermezler.
            //Yapmanız gereken bu operetorlerin yeine is anahtar kelimesini kullanmanız gerek.

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.Red;
                    this.Controls[i].ForeColor = Color.Yellow;
                }
                else if (this.Controls[i] is ListBox)
                {

                    Font dx = new Font("Tahoma", 13);
                    this.Controls[i].BackColor = Color.DarkBlue;
                    this.Controls[i].ForeColor = Color.Orange;
                    this.Controls[i].Font = dx;


                    //listBox1.Font = new Font("Arial", 15);
                }
                // listbox =>>BackColor DarkBlue;
                //Listbox =>>ForeColor= orange
                //listbox)>> font =>>Tahoma 13 em
            }
        }

        private void btn_Ornek7_Click(object sender, EventArgs e)
        {
            //DIŞARDAN (TEXTBOX'DAN) ALDĞINIZ SAYISAL BİR İFADENİN RAKAMLARLARINI TOPLAYIP GÖSTERİNİZ
            //Ornek =>123 => 1+2+3 =>6

            int Toplamdeger = 0;

            for (int i = 0; i < txt_GirisAlani.Text.Length; i++)
            {
                //Char'ı int'e cevirdiğimizde zaman  bize ascıı değeri verecektir. Bu nedenle oncelikle stringe cevirip daha sonra int'e cevirmelisiniz.
                int cevrilendeger = Convert.ToInt32(txt_GirisAlani.Text[i].ToString());
                Toplamdeger += cevrilendeger;
            }
            MessageBox.Show(Toplamdeger.ToString());
        }
    }
}
