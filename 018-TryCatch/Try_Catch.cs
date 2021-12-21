using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_TryCatch
{
    public partial class Try_Catch : Form
    {
        public Try_Catch()
        {
            InitializeComponent();
        }
        //İstisnai Tipler:

        //Çalışma zamanlı hatalar (Runtime excaption)=>> Çoğunlukl akullanıcı kaynaklı hatalardır.(verilerin yanlış ,eksik yada boş girilmesinden kaynaklı olabilir.
        //Çözüm yolu ise bu gibi durumlarda try-catch ile hataları ele ababilrisiniz.)

        //Derlama zamani hatalar  (Compile excapiton)
        //Tamamen yazılımcı kayanklıdır.Yazim hataları meydana geldiğinde devreye girer.
        //En kolay yakalabildiğiniz hata türleridir.  visual studio sizi uyarır (Aşağıdaki errorlist'de takip edebilmenizi sağlar ).İlgili hataya çift tıklarayark
        //hatanın bulunduğu mevciut konuma gidebilrisiniz.

        //Mantiksal hatalar =>> Tamamen programcı kaynakli hatalardır.Uygulamanın algoritmasında  meydana gelen bir problemdir.
        //Örğneğin bir alanda bölme işlemi unutlmuş  ,yada değeri yanlış değler değiştirmiş. 
        //Çözülmesi en zor hatalardır.Anlik olarak derleme aşmasında takip edilmeli ve değerleri gözlemlemelisiniz.Bu konuda visual studio sizlere
        //sağlmış olduğu araçlar ile yardımcı olur (watch , Breakpoint)

        //BreakPoint=>> Derleme aşamasında  adim adim dahil olmak için kullandığımız yardımcı tooldur .Yapmanız gereken tek şey hangi satırdan derleme a
        //nina dahil olmak istiyor iseniz  ,ilgili satırın eb sol kısmına gelerek (giri alan) farenin sol tuşuna basılır bir kırmızı top yerleştirilir.
        //.Artık derleyici bu satıra geldiğinde zaman sizi olaya o aşamadan sonra dahil edecektir.
        //F11 ile adım ileryebilrisiniiz .Değişken nesnelerin üzerine gelip o an ki değerlerini kontrol edebilrisiniz. Bunu aynı zaman  watch pencersinden de izleyebilrisiniz.
        //F5 basıp breakpointden çıakabilrisiniz. ve işlemin akışında devam etmesini sağlayabilrisiniz 
        //Derleme esnasında sol tarafta oluşan sarı ok size derleme esnasında bulunduğu satır gösterecektir. 
        
        //Watch:
        //bu bir  penceredir. 
        //Yanlızca run time -çalışma zmanında kullanabileceğimiz bir araçtır.Dolayı ile sadece debug işlemi esnasında görünür. Başlangıçda ilk kurulum sonrası 
        //watch pencersi kapalıdır.ctrl+alt+w ardindan 1'e basınız.
        //Run time 'da elinizde olan değerleri(kontrol,değşken değerleri değiştirmenize veya izlemenize   olanak sağlar )
        //Name paramtersi altında ctrl+space kombinasoyunu kullanılarak intelesinse üzerinden işlemler yapılablir.Çoğu zaman kendi otomatik tanımlar.
        //Bu araada öğrendiğin tum kurallar bu pencerede geçerlidir.


        //Eğer dışardan bir veri alıyrosanız ,verinin tutarlığından emin olmalıosınız.emin değilseniz mutlaka  hata riski ortada vardır.Bunuda göz ardı edemezsiniz.
        private void btnOnay_Click(object sender, EventArgs e)
        {
            //Telefon numarası

            int gelendeger = Convert.ToInt32(txtGirisAlani.Text);
            MessageBox.Show("Tebrikler doğru telefon numarsı girdniz. ");
        }

        private void btnHata_Click(object sender, EventArgs e)
        {
            try
            {
                int gelendeger = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler doğru telefon numarsı girdniz. ");
                //Bu alan hata riski olan kodlar içidir. .
            }
            catch (Exception)
            {
                MessageBox.Show("Telefon numran yanlış..");
                //Try Bloğu içerisnde yazmıiş olduğunuz olası hata meydana geldğinde catch bloğu devreye girer..
            }
        }

        private void btnDetaylıOnay_Click(object sender, EventArgs e)
        {
            try
            {
                int gelendeger = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler doğru telefon numarsı girdniz. ");
                //Bu alan hata riski olan kodlar içidir. .
            }
            catch (Exception hata)
            {
                //catch ifadesinin yanındaki excaption kelime anlami =>> "istisna"
                ////Ugulamamızın karlılığını bozan istisnai durumla ilgili size detayları teslim eder 

                MessageBox.Show(hata.Message);

                //Hatanın sistem tarafından atanan mesajı size teslim ederi.
            }
        }

        private void btnFinally_Click(object sender, EventArgs e)
        {
            try
            {
                int gelendeger = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler Doğru telefon giridniz.");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            finally
            {
                //Hata olsada olmasada çalışmasını isdeğiniz kodları yazdıgınız alandır.
                //Try-Catch-Finally üclüsünde en son çalışan kısımdır..
            }
        }

        private void btnHataTipler_Click(object sender, EventArgs e)
        {
            try
            {
                byte gelen = Convert.ToByte(txtGirisAlani.Text);
                int a = 5;
            }
            catch (FormatException ex) //Format hatası
            {
                MessageBox.Show("Format Excaption:  " + ex.Message);
            }
            catch (DivideByZeroException ex)//Sıfara bülünme hata tipi
            {
                MessageBox.Show("DivedByZeroExcapiton: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                //Veri tipin  boyutunu aşılması durumda alınan hata tipidir.
                MessageBox.Show("OverFlowExcaption: " + ex.Message);
            }
            catch (Exception ex)
            {
                //excation sınıfı tanımlı olan hatalar harcinde bir hata ile karşılarısa fırlatırlır 
                MessageBox.Show("Excaption: " + ex.Message);
            }
        }
    }
}
