using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _026_Out_Params_Ref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Out Anahtar kelimesi 
        //bir metot içerisinde disariya birden fazla değer döndürmek isterseniz..return anahtar kelimesi fonksiyonlarda size yetmeyecektir.
        //Void metotlar ise zaten geriye değer döndürenez.
        //bu bililenler yıkabilmek için kullanduğımız anahtar kelime out anahtar kelimesidir.


        #region OutBir
        void geriyeDegerDonduren(int sayi, out double firlatınSonuc)
        {
            firlatınSonuc = Math.Pow(sayi, 2);
        }
        #endregion 
        #region outİki
        void ListBoxunElemanlariniTemizle(ListBox hangilistbox, out int kacElemanSildim)
        {
            kacElemanSildim = hangilistbox.Items.Count;
            hangilistbox.Items.Clear();
        }
        private void btnOutiki_Click(object sender, EventArgs e)
        {
            int silinecekdeger;
            ListBoxunElemanlariniTemizle(listBox1, out silinecekdeger);
            MessageBox.Show("Listbox'dan toplam silinen " + silinecekdeger + "eleman silinmiştir..");
        }
        #endregion
        #region outUc
        void Hesapla(int sayiBir, int sayiIki, out int toplam, out int fark, out long carpim, out double bolum, out byte mod)
        {
            toplam = sayiBir + sayiIki;
            fark = sayiBir - sayiIki;
            carpim = sayiBir * sayiIki;
            bolum = sayiBir / sayiIki;
            mod = (byte)(sayiBir % sayiIki);
        }
        #endregion  
        #region Ref
        void MailListeliyici(ref string[] hangidiziyeEklensin, string verilerneredengeliyor)
        {
            string[] gelenDeger = verilerneredengeliyor.Split(';');
            for (int i = 0; i < gelenDeger.Length; i++)
            {
                Array.Resize<string>(ref hangidiziyeEklensin, hangidiziyeEklensin.Length + 1);

                hangidiziyeEklensin[i] = gelenDeger[i];
            }
        }
        #endregion
        private void btnOut_Click(object sender, EventArgs e)
        {
            double yakalananSonuc;
            geriyeDegerDonduren(12, out yakalananSonuc);
            MessageBox.Show(yakalananSonuc.ToString());
        }
        private void btnoutuc_Click(object sender, EventArgs e)
        {
            int toplamSonucu;
            int farkSonucu;
            long carpımSonucu;
            double bolumSonucu;
            byte modSonucu;

            Hesapla(9, 4, out toplamSonucu, out farkSonucu, out carpımSonucu, out bolumSonucu, out modSonucu);

            MessageBox.Show(string.Format("Toplama işleminin sonucu: {0}\nÇıkartma işleminin Sonucu: {1}\nÇarpma işlemin Sonucu: " +
                "{2}\nBölme işleminin sonucu: {3}\nMod alma işleminin sonucu: {4}", toplamSonucu, farkSonucu, carpımSonucu, bolumSonucu, modSonucu));
        }

        //Params keyword
        double FiyatlariHesapla(params double[] fiyatlar)
        {
            double toplamfiyat = 0;
            foreach (double fiyat in fiyatlar)
            {
                toplamfiyat += fiyat;
            }
            return toplamfiyat;
        }
        private void btnParams_Click(object sender, EventArgs e)
        {
            //double[] secililer = { 119.20, 24.60, 12.50, 42.99 };
            //double odenecekTutar = FiyatlariHesapla(secililer);

            double odenecekturar = FiyatlariHesapla(199.90, 24.60, 12.50, 42.99);
            MessageBox.Show("Ödememiz gereken tutar : " + odenecekturar + "TL");
        }
        //params ile kullanıcdan sürekli değer alan bir metot yaznız .yazmış olduğunuz bu metot neticesinde elinizde sayı dizninin medyanını bullunuz.

        /*
         * Ref anahatar kelimesi 
         * ref parametre niteliyiceisi c# 'ın "değer olarak çağrı yerine " "referans olarak çağrı oluşturmasını sağlar ".
         * Ref kullanakrak ,void tipli metotlardan değer alabilrisiniz.. üstelik bu değrleri alabilmek için yeni bir değişken atamanıza gerek yoktur.
         * ref ,metotda parametre olarak soktuğunuz elinizdeki varolan değişkeni değiştirebilir. 
         */
        private void btn_Ref_Click(object sender, EventArgs e)
        {
            string[] elemanlar = new string[0];
            MailListeliyici(ref elemanlar, txtmailadresleri.Text);

            foreach (string eleman in elemanlar)
            {
                listBox1.Items.Add(eleman);
            }

        }

    }
}
