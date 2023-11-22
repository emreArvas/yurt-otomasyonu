using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YurtOtomasyonu1._0.Models;

namespace YurtOtomasyonu1._0.login
{

   
    public partial class öğrenci_giris : Form
    {
        yurt_kayit_bilgileriEntities db = new yurt_kayit_bilgileriEntities();
        public öğrenci_giris()
        {
            InitializeComponent();
        }

       
        private void grsBTN_Click(object sender, EventArgs e)
        {
            string email = emailText.Text;
             
            string sifre = sifreText.Text;
            // eğer emailtext kısmı @ içeriyorsa veritabanında emaile göre kukkanıcıyı arayacak içermiyorsa tc ye göre
            kullanici dbKullanici = email.Contains("@") ? db.kullanici.FirstOrDefault(x => x.gmail == email) : db.kullanici.FirstOrDefault(x=>x.Tc==email);
            if (dbKullanici == null)
            {
                MessageBox.Show("Kullanıcı Bulunamadi");
            }
            else
            {
                if (dbKullanici.şifre != sifre)
                {
                    MessageBox.Show("Şifre Yanlış");
                }
                else
                {
                    sayfalar.OğrenciFormEkrani ekran = new sayfalar.OğrenciFormEkrani(dbKullanici.id);
                    ekran.Show();
                    this.Hide();
                }
            }
            

        }

        private void YNKYT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.öğrenci_kayit kayit = new öğrenci_kayit();
            kayit.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SFRM_UNTM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.SifremiUnuttum s = new SifremiUnuttum();
            s.Show();
            this.Hide();
        }
    }
}
