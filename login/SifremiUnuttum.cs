using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu1._0.login
{
    public partial class SifremiUnuttum : Form
    {
        Models.yurt_kayit_bilgileriEntities db = new Models.yurt_kayit_bilgileriEntities();
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void grsBTN_Click(object sender, EventArgs e)
        {
            string email = emailText.Text;
            Models.kullanici kullanici = db.kullanici.FirstOrDefault(x=>x.gmail==email);
            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı kayıtlı değil lütfen geçerli bir mail adresi giriniz");
            }
            else
            {
                Random r = new Random();
                string kod = r.Next(1000, 9999).ToString();
                kullanici.aktivasyon = kod;
                db.SaveChanges();
                emailMesajGonder(email,kod);
                MessageBox.Show("Mail adresinize kod gönderildi");
                login.KoduDogrula K = new KoduDogrula(kullanici.id);
                K.Show();
                this.Hide();
              
            }
       
        }
        public static void emailMesajGonder(string email, string kod)

        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("odev075@gmail.com", "tozi yrmw kewk komy"),
                    EnableSsl = true,
                };

                MailMessage mesaj = new MailMessage
                {
                    From = new MailAddress("your-email@example.com"),
                    Subject = "Doğrulama Kodu",
                    Body = $"Kodunuz: {kod}",
                    IsBodyHtml = true,
                };

                mesaj.To.Add(email);

                smtpClient.Send(mesaj);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata);

            }
        }
    }
}
