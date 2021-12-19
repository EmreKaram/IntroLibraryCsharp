using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_Switch_Case
{
    public partial class Karar : Form
    {
        public Karar()
        {
            InitializeComponent();
        }
        //Switch-Case:
        //if-else mantiğı ile çalışan bir kontrol mekanizmasıdır. Aradaki Fark if-else yapısı büyüklük-küçüklük gibi durumları kontrol ederken swirtch case yanzlıca eşitliık durumlarını kontrol eder. 
        //Kendisine ait bir indexleme mekanziması varıdır. Bu mekanizma koşulları algılar , siraya koyer ve otomatik olarak yüzlece koşulunuz olsa bile herbirine tek tek bakmadan hangisine uyduğunu bulabilir.
        //Bu da performası direkt etikler. 
        //Switch bloğunuz içerisinde yazdığınız veri tipiniz ne ise case(durum) olarak belirttiğimiz tum veriler aynı veri tipinde olmalıdır.

        //break; =>> Koşul sağlandı ,artık karar yapınsdan kendini direk olarak dışarı atabilrisin mesajını sisteme verir. Ve yapıyı  break kırar ve yapı sonlanır. 

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            string aylar = "";
            switch (txt_GirisAlani.Text)
            {
                case "Kış":
                    aylar = "Aralık-Ocak-Şubat";
                    break;
                case "İlkbahar":
                    aylar = "Mart-Nisan-Mayıs";
                    break;
                case "Yaz":
                    aylar = "Haziran -Temmuz-Agustos";
                    break;
                case "Sonbahar":
                    aylar = "Eylül-Ekim-Kasım";
                    break;
                default:
                    aylar = "Böyle bir mevsim olduğunu sanmıyprum !!!!";
                    break;
            }
            MessageBox.Show(aylar);
        }

        private void btn_Kontrol_Click(object sender, EventArgs e)
        {
            //Eğer ilk textbox'a "Admin","Moderator","Yönetici","Ceo","Başkan" değerleri girilirse "Yönetim paneline yönlendiriliyosunuz."
            //"Uye" girilirse Ana sayfaya yönlendidirliyosunuz.; 
            //harici bir durumda" bu sayfayı görme yetkiniz yok "

            string girilenDeger = txt_GirisAlani.Text.ToLower();
            string mesaj = "";
            switch (girilenDeger)
            {
                case "admin":
                case "moderatör":
                case "ceo":
                case "baskan":
                case "yonetici":
                    mesaj = "Yönetim paneline yönlendiriliyorsunuz ....";
                    break;

                case "uye":
                    mesaj = "Ana sayfaya yönlendirilitosunuz. ";
                    break;
                default:
                    mesaj = "Bu sayfayı görme yetkiniz yok.....";
                    break;
            }
            MessageBox.Show(mesaj);
        }
    }
}
