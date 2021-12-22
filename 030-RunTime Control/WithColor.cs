using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _030_RunTime_Control
{
    public partial class WithColor : Form
    {
        public WithColor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 288; i++)
            {
                PictureBox pcb = new PictureBox();
                pcb.Width = 30;
                pcb.Height = 30;

                //pcb.Size = new Size(50, 50);

                pcb.Margin = new Padding(1);//dış kenar uzunluğu
                                            //
                pcb.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

                flowLayoutPanel1.Controls.Add(pcb);
            }
        }
    }
}
