using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu1._0.login
{
    public partial class Dogrula : Form
    {
        private Models.yurt_kayit_bilgileriEntities db = new Models.yurt_kayit_bilgileriEntities();
        private int _id;
        public Dogrula(int id)
        {
           
            InitializeComponent();
            _id = id;
        }

        private void Dogrula_Load(object sender, EventArgs e)
        {

        }

        private void grsBTN_Click(object sender, EventArgs e)
        {
            Models.kullanici k = db.kullanici.FirstOrDefault(x =>x.id==_id);
            string sifre = sifreText.Text;
            if(sifre=="" || sifre.Length < 5)
            {
                MessageBox.Show("Lütfen şifreyi doğru biçimde giriniz");
            }
            else
            {
                k.şifre = sifre;
                db.SaveChanges();
                MessageBox.Show("Şifreniz değiştirildi");
                login.öğrenci_giris o = new login.öğrenci_giris();
                o.Show();
                this.Hide();
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sifreText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
