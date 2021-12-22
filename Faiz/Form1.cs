using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            for (double yilpara = Convert.ToInt32(txtPara.Text); yilpara>1000000 ; yilpara++)
            {
                double yil = Convert.ToInt32(txtGun.Text);
                double faizRatio = 14.5;
                double  annen = (yilpara  + (yilpara / 100) * faizRatio);
                MessageBox.Show(annen.ToString());
            }
            




        }
    }
}
