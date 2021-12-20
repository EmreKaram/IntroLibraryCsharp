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
    public partial class Donguler_3 : Form
    {
        public Donguler_3()
        {
            InitializeComponent();
        }

        private void btn_Ornek1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                lblyazialani.Text += "X\n ";

            }
        }

        private void btn_Ornek2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    lblyazialani.Text += " X ";
                    //Ali veli 
                }
                lblyazialani.Text += "\n";
            }
        }

        private void btn_Ornek3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < i; x++)
                {

                    lblyazialani.Text += " X ";

                }
                lblyazialani.Text += "\n";
            }
        }

        private void btn_Ornek4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    listBox1.Items.Add($"{i}X{x}= {i * x}");
                }
            }
        }
    }
}
