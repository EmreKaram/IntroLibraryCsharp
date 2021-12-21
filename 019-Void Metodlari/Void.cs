using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_Void_Metodlari
{
    public partial class Void : Form
    {
        public Void()
        {
            InitializeComponent();
        }

        void Saydirici()
        {
            for (int i = 0; i < 1000; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnSaydir_Click(object sender, EventArgs e)
        {
            Saydirici();
        }

        void Tadilatci()
        {
            this.BackColor = Color.White;
            this.Size = new Size(400, 400);
            //Size size1 = new Size();
            //size1.Width = 400;
            //size1.Height = 400;
            //this.Size = size1;
        }

        //Buttona bastığımda formun arkaplan rengini ve boyutlarıni değiştirecek bir metot yazını

        //Arkaplan rengi beyaz , formun boyutuda 400,400

        private void btnArkaPlan_Click(object sender, EventArgs e)
        {
            Tadilatci();
        }
    }
}
