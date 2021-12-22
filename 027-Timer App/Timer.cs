using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _027_Timer_App
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbResim.Image = imglist.Images[0];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbResim.Image = imglist.Images[imglist.Images.Count - 1];
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int index = Convert.ToInt32(pcbResim.Tag);
            index--;
            if (index < 0)
            {
                index = imglist.Images.Count - 1;
            }
            else
            {
                pcbResim.Image = imglist.Images[index];
            }
            pcbResim.Tag = index;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int index = Convert.ToInt32(pcbResim.Tag);

            if (index < imglist.Images.Count)
            {
                pcbResim.Image = imglist.Images[index];
                index++;
            }
            else
            {
                index = 0;
            }
            pcbResim.Tag = index;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = rnd.Next(0, imglist.Images.Count);
            pcbResim.Image = imglist.Images[index];

            //anlık olarak  index değerini tag property'si üzerinde tutalımm.

            pcbResim.Tag = index;
        }
    }
}
