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
    public partial class öğrenci_kayit : Form
    {
        // entity frameworkun bize sağlamış olduğu bir servis bunun sayesinde güncelleiveri tabanına kaydetme silme işlemlerini kolaylaştırır
        yurt_kayit_bilgileriEntities db = new yurt_kayit_bilgileriEntities();
        public öğrenci_kayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanici kullanici = new kullanici();
            kullanici.isim = isimTextBox.Text;
            kullanici.soyisim = soyadTextBox.Text;
            kullanici.Tc = tcMaskedTextBox.Text;
            kullanici.gmail = emailTextBox.Text;
            kullanici.şifre = sifreTextBox.Text;
            kullanici.odaTipi = odatypeComboBox.SelectedItem ==null ? 0 : int.Parse(odatypeComboBox.SelectedItem.ToString());
            Boolean duzgunMailMi= emailTextBox.Text.Contains("@");
            // veritabanında aynı maili kullanmış başka bir kullanıcı var mı diye kontrol ettik
            kullanici dbKullanici = db.kullanici.FirstOrDefault(x=>x.gmail==emailTextBox.Text);
            bool tcKontrol = db.kullanici.Any(x => x.Tc == tcMaskedTextBox.Text);
            if (odatypeComboBox.SelectedItem==null || isimTextBox.Text == "" || soyadTextBox.Text == "" || sifreTextBox.Text == "" || tcMaskedTextBox.Text == "" || emailTextBox.Text=="" || !duzgunMailMi) {
                MessageBox.Show("Hatali veya eksik bilgi var lütfen tekrar deneyiniz");
            }
            else if (dbKullanici != null || tcKontrol)
            {
                MessageBox.Show("BU KULLANICI ZATEN KAYITLI");
            }
            else
            {
                db.kullanici.Add(kullanici);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarili");
                login.öğrenci_giris giris = new öğrenci_giris();
                basvuru b = new basvuru();
                b.kullanici_id = kullanici.id;
                db.basvuru.Add(b);
                db.SaveChanges();
                
                giris.Show();
                this.Hide();
            }

            
        }
    }
}
