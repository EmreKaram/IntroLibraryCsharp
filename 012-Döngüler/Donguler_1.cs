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
    public partial class Donguler_1 : Form
    {
        public Donguler_1()
        {
            InitializeComponent();
        }
        
        //Donguler-Loops:
        //Bir başlangıc değer olan ,belirli bir koşul gerçekleşene dek süren bu sürec içerisinde bir takım işlemleri
        //tekrarlı olarak gerçekleştirmenize olanak sağlayan nesneleere döngü denir.
        //For-While *Foreach /Do -while

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Döngüye ilk giriş anında derleyici başlangıc değerine bakar ve bir asla bu değerin olduğu bloğa uğramaz.
            //bundan sonraki işlemler once arttır daha sonra koşula bak şeklinde yürür. 
            //koşul uygunsa dongunun kod bloğunu harekete geçirir. Uygun değilse çikar.
            //For(başlangıcdeğeri;bitisKoşulu ;artış veya azalış-miktari)
            for (int deger = 1; deger <= 1000; deger++)
            {
                listBox1.Items.Add(deger);
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            for (int i = 1000; i >= 1; i = i - 1)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 1000; i += 2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //"A-Z" OLAN ARALIKTAKİ BÜTÜN HARFLERİN ASCII KODUNU LİSTBOX'A' BASTIRNIZ 
            for (char a = 'A'; a <= 'Z'; a++)
            {
                //listBox1.Items.Add(a + "--" + Convert.ToInt32(a));

                listBox1.Items.Add($"{a}-{Convert.ToInt32(a)}");
            }
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //1-ile 1000 arasındaki sayıların toplamını bulun ve ekrana yazdırın. 


            int ToplamKutusu = 0;
            for (int i = 1; i <= 1000; i++)
            {
                ToplamKutusu += i;

            }
            MessageBox.Show("Toplam =>>> " + ToplamKutusu);
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            //1-100 sayıları arasında çift sayıların toplami ile ,tek sayilarin toplamiının karelerinin farkı kaçtır ?

            int ciftlerinToplami = 0;
            int teklerintoplami = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftlerinToplami += i;
                }
                else
                {
                    teklerintoplami += i;
                }
            }

            int sonuc = (ciftlerinToplami - teklerintoplami) * (ciftlerinToplami - teklerintoplami);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            //1945-günümüz yılları arasındaki yıllar listbox'eklensin.
            //ancak 1990 ve 1992 yılları eklenmesin.


            for (int i = 1945; i <= DateTime.Now.Year; i++)
            {
                if (i != 1990 && i != 1992)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
