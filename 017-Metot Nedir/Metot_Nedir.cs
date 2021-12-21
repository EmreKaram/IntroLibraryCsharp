using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_Metot_Nedir
{
    public partial class Metot_Nedir : Form
    {
        public Metot_Nedir()
        {
            InitializeComponent();
        }
        //Geriye deger döndürmeyen yanlızca üzerine düşen işi yapan ,islemlerle void metotlar yada subrutinler nedir ?

        //1)Tekrarlı kodun önüne geçmek engellemk
        //2)Kod kalabalığının önüne geçer daha esnek kodlar yazmanıza olanak sağlar.
        //3)Merkeziyetçi kod yapısnın hedef haline getirebilmek .Yani herhangi bir problem yada değişiklik durumunda birden fazla yer
        //kotnrol etmek yerine ,merkez yapıda mudahale ederek en kısa ve en net şekilde sorunları çözmek.


        void temizle()
        {
            textBox1.Clear();
            textBox2.Text = "";
            textBox3.Text = string.Empty;
            textBox4.Text = null;
            textBox5.Text = default(string);
        }
            
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

    }
}
