using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _031_Mayın_Tarlası_App
{
    public partial class MayinTarlasi : Form
    {
        public MayinTarlasi()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void MayinTarlasi_Load(object sender, EventArgs e)
        {
            List<int> mayinlar = new List<int>();
            //oluşturlan tüm butonlar özelinde 20 adet mayın belirlemeye çalıştık.
            //Rasgele berlirlenen 20 sayıyı ,oluşan numaraları picbox'lara mayın olarak atayayacağız
            for (int i = 0; i < 20; i++)
            {
                int mayin = rnd.Next(0, 160);
                if (!mayinlar.Contains(mayin))
                {
                    mayinlar.Add(mayin);
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < 169; i++)
            {
                PictureBox pcb = new PictureBox();
                pcb.Name = "pcb" + i;
                pcb.Width = 30;
                pcb.Height = 30;
                pcb.Margin = new Padding(1);
                pcb.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                if (mayinlar.Contains(i))
                {
                    pcb.Tag = true;

                }
                else
                {
                    pcb.Tag = false;
                }
                pcb.Click += Pcb_Click;
                flowLayoutPanel1.Controls.Add(pcb);

            }
            timer1.Start();
        }

        private void Pcb_Click(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;

            Color background = pcb.BackColor;

            if ((bool)pcb.Tag)
            {
                timer1.Stop();
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    pcb = (PictureBox)item;
                    pcb.BackColor = background;
                }
                MessageBox.Show("Mayın'a BASTINIZ!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                //panel içerisinde sadece picturebox yer aldığından ,kontrol etmemize gerek yoktur.
                PictureBox pcb = (PictureBox)item;
                pcb.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            }
        }
    }
}

