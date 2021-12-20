using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_Diziler_Part1
{
    public partial class Diziler : Form
    {
        public Diziler()
        {
            InitializeComponent();
        }
        //Array Dizi 

        //Birden Fazla aynı tipteki veriyi bir arada tutmanızı sağlayan yapılarıdır.

        //Index was outside the bound of the array.==>> dizini botutulraını biyerde aşıyorsunuz ve kontrol etmelisiniz.

        //Eleme ekleme adımlarını kontrol etmek gereklidir.

        private void Diziler_Load(object sender, EventArgs e)
        {
            //1.Tanımlama 
            //veritipi[] diziadi = new veritipi[elemansayisi]

            int[] dizi = new int[3];
            dizi[0] = 54;
            dizi[2] = 5421;
            dizi[1] = 4541;
            //  dizi[3] = 231312; ,==>> dizi 3 elemanlı olduğu için hata vericektir.

            for (int i = 0; i < dizi.Length; i++)
            {
                MessageBox.Show("dizi eleman=  " + dizi[i]);
            }

            //2.Tanımlama
            //veritipi [] Diziadi = new veritpi [dizinin elemansayısı] {}

            string[] sehirler = new string[4] { "Ankara", "İzmir", "Deger", "deger1" };


            //3.Tanımlama
            //veritip[] diziadi={dizi elemanlar}
            char[] karakterler = { 'a', 'b', 'c', 'd' };

            foreach (var item in karakterler)
            {
                MessageBox.Show(item.ToString()); ;
            }
        }

        private void btn_Ornek_Click(object sender, EventArgs e)
        {
            //YAZILIMIZ  ÇALLŞTIRILIĞINDA EKRANDA BİR DOKTORUN RANDEVÜ SAATLERİNİ YAZAN PROGRAM 15'ER DAKİKA ARA İLE BU SAATLERİ BASACAK.
            //MESAİ =>>>09:00 -16:30 ARASI OLACAK VE 12:00-13-00 ÖĞLE TATİİLİ OLACAK 

            for (int saat = 9; saat <= 16; saat++)
            {
                if (saat == 12)
                {
                    listBox1.Items.Add("Öğle tatili");
                    continue;
                }

                for (int dakika = 0; dakika <= 45; dakika += 15)
                {
                    if (saat == 16 && dakika == 45)
                    {
                        break;
                    }
                    else
                    {
                        listBox1.Items.Add(saat.ToString("00") + "." + dakika.ToString("00"));
                    }
                }

            }
        }

        private void btn_TimeSpan_Click(object sender, EventArgs e)
        {
            TimeSpan basla = new TimeSpan(8, 45, 0);
            TimeSpan bitis = new TimeSpan(16, 30, 0);
            TimeSpan sure = new TimeSpan(0, 15, 0);

            for (TimeSpan i = basla; i < bitis; i += sure)
            {
                basla = basla.Add(sure);
                if (basla.Hours == 12)
                {
                    continue;
                }

                listBox1.Items.Add("\n" + basla.ToString());
            }
        }
    }
}

