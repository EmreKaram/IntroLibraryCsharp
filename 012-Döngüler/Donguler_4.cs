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
    public partial class Donguler_4 : Form
    {
        public Donguler_4()
        {
            InitializeComponent();
        }

        private void btn_OrnekBir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                //   Thread.Sleep(1000);

                listBox1.Items.Add(new Random().Next(1, 10).ToString());

            }
            //Thread th1 = new Thread(new ThreadStart(uret));
            //Thread th2 = new Thread(new ThreadStart(uret1));
            //th1.Start();
            //th2.Start();
        }

        //static void  uret1()

        //{
        //    for (int i = 0; i < 10; i+=2)
        //    {
        //        Thread.Sleep(500);
        //        MessageBox.Show(new Random().Next(1, 10).ToString());
        //    }
        //}

    }
}
