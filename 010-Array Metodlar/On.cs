using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_Array_Metodlar
{
    public partial class On : Form
    {
        public On()
        {
            InitializeComponent();
        }
        
        //Array Sınıfı:(class)
        //Su ana dek görmüş olduğunuz ilkel diziler ,bize uzerinde çok fazla islem yapma olanağı saglamamaktadır. Eğer diziyi yeniden
        //boyutlandırmak ,temizlemek,sıralamak,tersine cevirmek  gibi temel islemleri yapabilrisiniz.
        //Bu konuda array sınıfı size yardımcı olur.
        string[] OrnekDizi = { "İstanbul", "Eskişehir", "Ankara", "İzmir", "Bursa", "Manisa", "Konya", "Trabzon", "Sivas", "Eskişehir" };

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //1.Parametre kaynak dizi.
            //2.Parametre başlanılacak index değeri. 
            //3.parametre silenecek eleman sayısı.
            Array.Clear(OrnekDizi, 2, 3);

            //Dizinin tamamını silin. 
            Array.Clear(OrnekDizi, 0, OrnekDizi.Length);
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            //Array.Copy()=>> Bir diziden başka diziye eleman kopyalamak için kullanılır.
            string[] yeniSehirler = new string[4];

            Array.Copy(OrnekDizi, yeniSehirler, 4);

            //1 ve 2  overload 

            //1.parametre kaynak dizi. 
            //2.parametre hedef dizi. 
            //3.parametre kaynak diziden hedef diziye kaç adet eleman kopyalanacak.


            Array.Copy(OrnekDizi, 3, yeniSehirler, 1, 1);

            //3ve 4  overload 

            //1.parametre kaynak dizi. 
            //2.parametre kaynak dizinin kaçıncı index değerinden kopyalama başlayacak.
            //3.parametre hedef dizi. 

            // 4.parametere hedef dizinin kaçıncı index değerine eklemeye başlıyacak.
            //5.parametere diziye kaç eleman toplanacak 
        }

        private void btn_IndexOf_Click(object sender, EventArgs e)
        {
            //    Array.IndexOf() =>> dizide aradığımız elemanın index numarasını döndüren metodun adıdıdır. 
            //Array aradığıız değer dizi içerisinde mevcut değilse -1 döndüdür. 
            //Eğer eleman dizi içerisinde birden fazla kez geçiyor ise ilk elemanın indexi dçnecektir.

            //  int index = Array.IndexOf(OrnekDizi, txtGelenDeger.Text);

            //1.parametre kaynak dizi 
            //2.parametere  aranılacak nesne (object tipinde veri ister ,dizinin tipi ne ise ,o tipde değer verebilrisiniz.
            //Örn: int ise sayı ,string ise metinsel gibi 
            //3.Parametre aramaya kaçıncı indexden başlayalım. 
            //MessageBox.Show(index<0 ? "Aradığınız eleman dizi içerisinde yer almamaktadir..":"Aradığınız elemanın index değeri : "+index);

            int index = Array.IndexOf(OrnekDizi, textBox1.Text, 5);
            MessageBox.Show(index < 0 ? "Aradığınız eleman dizi içerisinde yer almamaktadir.." : "Aradığınız elemanın index değeri : " + index);
        }

        private void btn_LastIndexOf_Click(object sender, EventArgs e)
        {
            //Array.LastİndexOf() =>> Dizide aradığınız eleman birden fazla defa geçiyor ise ,size son geçtiği yerin index'ini teslim eder.
            //Eğer Bu eleman hiç yokse ,yine -1 dönecektir...
            //int aradığımızindex= Array.LastIndexOf(OrnekDizi, "Eskişehir");
            //   MessageBox.Show("Arağınız elemanın son indexi =>"+ aradığımızindex);

            //Bir dizide bir değerden birden fazla olup olmadığını kontrol etme
            if (Array.IndexOf(OrnekDizi, "Eskişehir") == Array.LastIndexOf(OrnekDizi, "Eskişehir"))
            {
                this.Text = "Bu dizide aradığınız elemdandan bir adet bulunmaktadır!";
            }
            else
            {
                this.Text = "Bu dizide aradığınız eleman birden fazla defa geçmektedir.";
            }
        }

        private void btn_Resize_Click(object sender, EventArgs e)
        {
            //Array.resize=>> ilkel dizinin eleman sayısını arttırmak -azaltmak için kullandığımız metottur. 

            //tip bakımından güvenli.
            Array.Resize<string>(ref OrnekDizi, 23);
            //birinci kullanımla ikinci kullanım arasındaki tek fark sizden öncelikle bir dizi tipi istenmesi
            //ve daha sonra sadece o tipteki dizileri resize edebilme yeteneğine kabileyetine kavuşabilmesi.
            //Kısaca tip güvenliği sağlar. 
            //Array.Resize(ref OrnekDizi, 21);
        }

        private void btn_Sıralama_Click(object sender, EventArgs e)
        {
            // Array.Sort(OrnekDizi);=>> Dizinin siralamak için kullanacağı metoddur.
            //elemnetlerin yerleri değiştirildiği için , index'leride değişir.
            //Sıralama A'dan Z'ye (Küçükten-*Büyüğe )gerçekleşir.
            //1.overload 
            //  Array.Sort(OrnekDizi);
            //  Array.Sort(OrnekDizi, 4, 5);
            //1.Parametre Kaynak dizi 
            //2.parametere Başlangı. index değeri 
            //3.Paremtere Başlangıc index değerinden sonra kaç eleman sıralanaca.
        }

        private void btn_TersCevir_Click(object sender, EventArgs e)
        {
            //Array.reverse() =>> dizinin resine cevirmeye yarayn metotdur .Kesinlikle sıralama yapmaz.
            Array.Reverse(OrnekDizi);
            Array.Reverse(OrnekDizi, 5, 4);
            //1.Parametre kaynak dizi 
            //2.parametere  Başlangıc index değeri 
            //3.parametere başlangıc index değerinden sonra kaç eleman terse çevirilecek  
        }
    }
}
