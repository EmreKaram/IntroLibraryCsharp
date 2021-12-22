using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _027_System_IO
{
    public partial class ıo : Form
    {
        public ıo()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            // File: statik bir dosya kontrol sınıfıdır. directory ile aynı metotlara sahip olmasına ragmen ..
            // file =>> dosyalarda kullanılır. 
            //directory ==> klasörlerde kullanılır..

            #region Dosya Yazma ve okuma işlemleri
            FileStream fi = File.Create(@"C:\\IO\\txt.text"); //Dosya oluşturma .Bu işlem dosyayı yazmaya yarayn filestream sınıfı ile yapılır... 
            string name = fi.Name; //oluşturlan dosyanın isim bilgisini getir .
            Byte[] info = new UTF8Encoding(true).GetBytes("Merhaba bilge adam öğrencileri nasısılsınız... .");

            //Dışarıdan oluşturduğumuz yazıyı getbytes ile ascci kodları haline dönüştürüyoruz ve bir byte dizisine atıyoruz .burada kullandığımız utf8Encoding (true ) ile turkçe karakterlere destek versin diye kullanıyourz..

            fi.Write(info, 0, info.Length);
            //byte şeklinde olan yazımız (aslında asci  kodları) write metodu ile dosyamıza yazılır..
            fi.Close(); //yapılan yazma işlmei yada oluşturma işlemi kesinlikle kapatılmalıdır..
                        //yoksa yazılma işlemi yapılmaz..

            //  File.Delete(@"C:\\IO\\txt.text"); //Dosyayı siler
            #endregion

            #region Append
            List<string> deger = new List<string>();
            File.AppendAllLines(@"C:\\IO\\txt.text", deger, UTF8Encoding.UTF8);
            //satırları bir dosya ekler ve sonra dosyayı kapatır .Belirtilen dosya mevcut değil ise bu yoöntem bir dosya oluşturur, stırları belirtilen dosyaya yazar ve sonra dosyayı kapatır....... 

            var deger2 = from line in File.ReadLines(@"C:\\IO\\txt.text")
                         where line.StartsWith("merhaba") &&
                         line.Contains("ahmet")
                         select line;
            File.WriteAllText(@"C:\\IO\\test.text", deger2.ToString());

            string yazi = File.ReadAllText(@"C:\\IO\\test.text");
            //Dosya okuma işlemi 
            #endregion
        }

        static void CreateSampleFile()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\\IO\\test.text"))
            {
                DateTime TİMESPAN = new DateTime(1700, 1, 1);
                for (int i = 0; i < 500; i++)
                {
                    DateTime TS1 = TİMESPAN.AddDays(i);
                    DateTime ts2 = TS1.AddMonths(i);
                    DateTime ts3 = ts2.AddDays(i);
                    sw.WriteLine(ts3.ToLongDateString());
                }
            }
        }
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            CreateSampleFile();
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\\YeniProjeler"))
            {
                Directory.Delete(@"C:\\YeniProjeler"); //kLASÖR BOŞSSA SİLİNİR... 
            }
            // Directory.CreateDirectory(@"C:\\YeniProjeler"); //Boş bir klasör eklemesinde bulunuyor

            string[] dizi = Directory.GetDirectories(@"c:\\YeniProjeler");//verilen yoldaki bulan klasörleri getir.

            string[] file = Directory.GetFiles(@"C:\\YeniProjeler");//verilen yoldaki dosyaları döner.

            Directory.GetDirectoryRoot(@"C:\\YeniProjeler");//ana dizini döner.

            Directory.Move(@"C:\\YeniProjeler", "C:\\IO");
            //VAR OLAN DOSYA YOLUNDAKİ DOSYAYI SİLİYOR..
            //VERİLEN DOSYAYI EKLER
        }

        private void btnDrive_Click(object sender, EventArgs e)
        {
            //driveınfo:Sürücü bilgilerine erişim sağlayan sınıftır...
            DriveInfo[] tumsuruculer = DriveInfo.GetDrives();
            //collection

            foreach (var item in tumsuruculer)  // her ayrı sürücünün tek tek ismine ,toplan alına boş alına bakma imkanı elde edicez...
            {
                MessageBox.Show(item.Name);//isim
                MessageBox.Show(item.TotalFreeSpace.ToString());//boş alan bilgisi 
                MessageBox.Show(item.TotalSize.ToString());//toplam alan
                MessageBox.Show(item.VolumeLabel);//ön ad
            }
        }
    }
}
