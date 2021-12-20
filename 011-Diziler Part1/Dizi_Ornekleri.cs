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
    public partial class Dizi_Ornekleri : Form
    {
        public Dizi_Ornekleri()
        {
            InitializeComponent();
        }

        private void btn_En_Click(object sender, EventArgs e)
        {
            //İçeriğini sizin karar vereeğiniz bir sayılsa dizi oluşuturun ve bu dizinin en küçük - en büyük elemanlarını messagebox' ile gösterin.
            int[] dizi = { 53, 765, 2165, 8, 321, 65, 851, 876, 98, 34276, 453 };
            Array.Sort(dizi);
            int enkucukeleman = dizi[0];
            int enbüyükeleman = dizi[dizi.Length - 1];
            MessageBox.Show("En küçük eleman = " + enkucukeleman + "\n en bütük eleman = " + enbüyükeleman);
        }

        string[] kayitlar = new string[0];
        int index = 0;

        //Textbox'tan girilen veri "kayitlar "adli diziye eklensin. Her yeni kayıtta dizinin boyutu bir artırılsın.
        //Eleman eklendikten hemen sonra ise aşagıdaki formatta kayıtları listeleyin. 
        //0.index => kayıt 

        private void btn_Kayıtlar_Click(object sender, EventArgs e)
        {
            Array.Resize(ref kayitlar, kayitlar.Length + 1);
            kayitlar[index] = textBox1.Text;
            listBox1.Items.Add(string.Format("{0}.eleman=>>>{1}", index, kayitlar[index]));
            //c# 6.0 ile gelen bir özelliktir. Alt sürümler bunu desteklemezler. 
            //listBox1.Items.Add($"{index}.eleman =>>{kayitlar[index]}");
            index++;
        }
    }
}
