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
    public partial class personelGiris : Form
    {
        Models.yurt_kayit_bilgileriEntities db = new Models.yurt_kayit_bilgileriEntities();

        public personelGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = email.Text;
            string sifre = sifreText.Text;
            Models.personel personel = db.personel.FirstOrDefault(x=>x.gmail==mail);
            if (mail != null)
            {
                if (sifre != personel.sifre)
                    MessageBox.Show("şifre yanlış");
                else
                {
                    MessageBox.Show("Giriş Başarılı");
                    sayfalar.PersonelAnaSayfa anasayfa = new sayfalar.PersonelAnaSayfa();
                    anasayfa.Show();
                    this.Hide();
                }           
                
                    
                
            }
            else
            {
                MessageBox.Show("personel kayıtlı değil");
            }



            
        }

        private void personelGiris_Load(object sender, EventArgs e)
        {
            Models.yurt_kayit_bilgileriEntities db = new Models.yurt_kayit_bilgileriEntities();
            Models.personel personel = new Models.personel();
            Models.personel kontrol = db.personel.FirstOrDefault(x => x.gmail == "yurtadmin@arvas.edu.tr");
            if (kontrol != null)
            {

            }
            else
            {  personel.gmail = "yurtadmin@arvas.edu.tr";
            personel.sifre = "Arvas652023.";
            db.personel.Add(personel);
            db.SaveChanges();

            }
          
         
        }
    }
}
