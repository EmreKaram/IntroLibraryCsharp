using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_Do_While
{
    public partial class Do_While : Form
    {
        public Do_While()
        {
            InitializeComponent();
        }

        private void btn_While_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i < 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void btn_Do_While_Click(object sender, EventArgs e)
        {
            int i = 100;

            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i < 100);
        }

        private void btn_While2_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int i = 0;
            while (i > 0)
            {
                faktoriyel = faktoriyel * i;
                i--;

            }
        }

        private void btn_DoWhile2_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int i = 0;
            do
            {
                faktoriyel = faktoriyel * i;
                i--;
            } while (i > 0);
            MessageBox.Show(faktoriyel.ToString());
        }
    }
}
