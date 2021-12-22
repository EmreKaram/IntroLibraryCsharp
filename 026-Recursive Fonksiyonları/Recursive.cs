using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _026_Recursive_Fonksiyonları
{
    public partial class Recursive : Form
    {
        public Recursive()
        {
            InitializeComponent();
        }

        #region Örnek1
        private int Faktoriyel(int sayi)
        {
            int fakt = 1;

            for (int i = 1; i <= sayi; i++)
            {
                fakt = fakt * i;
            }
            return fakt;
        }
        #endregion
        #region Örnek2
        private int faktoriyel_recursive(int sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }
            else
            {
                return sayi * faktoriyel_recursive(sayi - 1);
            }
        }
        #endregion
        #region Örnek3

        void clean(Control.ControlCollection cls)
        {
            foreach (Control item in cls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is ListBox)
                {
                    ((ListBox)item).Items.Clear();
                }
            }
        }
        void Temizle(Control.ControlCollection cls)
        {

            foreach (Control item in cls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is GroupBox)
                {
                    GroupBox grb = (GroupBox)item;

                    Temizle(grb.Controls);
                }
            }

        }
        #endregion
        #region Örnek4
        private void txtClean_Click(object sender, EventArgs e)
        {
            clean(this.Controls);
            clean(groupBox1.Controls);
        }
        #endregion

        private void btnFak_Click(object sender, EventArgs e)
        {
            int result = Faktoriyel(5);
            MessageBox.Show("işlem Sonucu : " + result);
        }

        private void btnRecursive_Click(object sender, EventArgs e)
        {
            int result = faktoriyel_recursive(5);
            MessageBox.Show("işlem sonucumuz: " + result);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clean(this.Controls);
            clean(groupBox1.Controls);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle(this.Controls);
        }
    }
}
