using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _026_Parametreli_Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Paramterli Metotlar
        //Dışarıdan gelecek olan degerlere gore islem yonunu değistiricek olan metotlardır. .
        //paramtredeki değişkene ,iceride deger atanmaz
        //metot prensipleri gereği paramtrenin nerden geleceği söylenmez...

        #region Örnek1 
        void ParametreliSaydir(int KacaKadarSayayim)
        {
            //  listBox1.Items.Clear();

            ///   KacaKadarSayayim = 100;  =>>>>Yanlışşş!!!!!!!!!
            ///   KacaKadarSayayım=convert.toint32(textbox1.text) =>>Yanlış


            for (int i = 0; i < KacaKadarSayayim; i++)
            {
                listBox1.Items.Add(i);
            }

        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            ParametreliSaydir(Convert.ToInt32(textBox1.Text));
        }
        #endregion
        #region Örnek2
        void HesapMakinesi(int sayiBir, int sayiIki)
        {
            int toplam = sayiBir + sayiIki;
            int genelSonuc = Convert.ToInt32(Math.Pow(toplam, 3));
            MessageBox.Show(genelSonuc.ToString());
        }
        private void btnOrnekiki_Click(object sender, EventArgs e)
        {
            HesapMakinesi(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

            //Dışarıdan girilen iki sayının toplamının kupunu messageboxle gösterecek olan bir metot yazınız.. 

        }
        #endregion
        #region Örnek3

        void RenkDegistir(string RenkAdi)
        {
            this.BackColor = Color.FromName(RenkAdi);
        }

        private void btnArkaPlanDegistir_Click(object sender, EventArgs e)
        {
            //Combobox'da seçilen rengi formun arkapaln rengine arayan bir metot yazınız..
            RenkDegistir(comboBox1.SelectedItem.ToString());
        }


        #endregion
        #region Örnek4
        void SonUcHarfKesici(string hangiKelime)
        {
            if (hangiKelime.Length <= 3)
            {
                MessageBox.Show(hangiKelime);

            }
            else
            {
                string sonuc = hangiKelime.Substring(hangiKelime.Length - 3, 3);
                MessageBox.Show(sonuc);
            }
        }

        private void btnKirp_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen değerin son 3 harfinin messageboxla bir metot yazınız .
            //ancak girilen değer 3 harften azsa yada üç harfe eşittse direkt olarak tamamını göstersin..

            SonUcHarfKesici(txtDeger1.Text);

        }


        #endregion
        #region Örnek5
        //Dışarıdan girilen mailleri ;, + gordüğü yerden ayrıp listbox'a dolduran metot yazınız..

        //Split

        void Ayristirici(string MailAdresleri)
        {
            string[] adresler = MailAdresleri.Split(';', ',', '+');
            foreach (string str in adresler)
            {
                listBox1.Items.Add(str);
            }
        }
        private void btnlistboxDoldur_Click(object sender, EventArgs e)
        {
            Ayristirici(txtDeger1.Text);
        }

        #endregion
        #region MyRegion
        void SesliKontrol(string gelenMetin)
        {
            char[] karakterler = gelenMetin.ToLower().ToCharArray();

            for (int index = 0; index < karakterler.Length; index++)
            {
                switch (karakterler[index])
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'o':
                    case 'ö':
                    case 'u':
                    case 'ü':
                        listBox1.Items.Add(karakterler[index]);
                        break;
                    default:
                        listBox2.Items.Add(karakterler[index]);
                        break;
                }
            }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Sesli harf bulunmamaktadır");
            }
            else
            {
                MessageBox.Show("Sesli harf sayisi ;" + listBox1.Items.Count);
            }
        }

        private void btnSesliKontrol_Click(object sender, EventArgs e)
        {
            //Textbox'tan gelen  degeğerde eğer sesli bir harf varsa ,o harfleri ,1.listbox'a attın. ve kaç adet olduğunu msgboxta gösterin ,eğer yoksa bu  kümede sesli harf bulunmamaktadır uyarısını veriniz...
            ////girilen metinde sessiz harfleride listbox2 ye attınız. 
            ///Kullanıcı bütük küçük harf gözetmeksizin giriş yapabilir. ancak siz içeride herbiri küçük olarak değerlendir.
            ///A,E,I,İ,O,Ö,U,Ü
            ///
            listBox1.Items.Clear();
            //SesliKontrol(gelenMetin.Text.ToLower());
            //seslikontrolFarkli(gelenMetin.Text.ToLower());
            ContainsKelime(gelenMetin.Text.ToLower());
        }
        void seslikontrolFarkli(string gelenMetin)
        {
            char[] sesliler = { 'a', 'e', 'i', 'ı', 'o', 'u', 'ö', 'u', 'ü' };
            char[] karakterler = gelenMetin.ToCharArray();
            int seslisayisi = 0;
            for (int i = 0; i < karakterler.Length; i++)
            {
                bool seslivarmi = false;
                for (int z = 0; z < sesliler.Length; z++)
                {
                    if (karakterler[i] == sesliler[z])
                    {
                        seslisayisi++;
                        listBox1.Items.Add(karakterler[i]);
                        seslivarmi = true;
                        break;
                    }
                }
                if (!seslivarmi)
                {
                    listBox2.Items.Add(karakterler[i]);
                }
            }
            MessageBox.Show(seslisayisi == 0 ? "Bu kelime sesli harf bulunmamaktadır!" : "Bu kelime toplam " + seslisayisi + " tane sesli harf vardır.. ");
        }

        #endregion

        void ContainsKelime(string gelenMetin)
        {
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            char[] karakterler = gelenMetin.ToCharArray();


            for (int i = 0; i < karakterler.Length; i++)
            {
                if (sesliler.Contains(karakterler[i]))
                {
                    listBox1.Items.Add(karakterler[i]);
                }
                else
                {
                    listBox2.Items.Add(karakterler[i]);
                }
            }
        }

    }
}
