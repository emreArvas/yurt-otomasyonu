using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu1._0.sayfalar
{
    public partial class PersonelAnaSayfa : Form
    {
        Models.yurt_kayit_bilgileriEntities db = new Models.yurt_kayit_bilgileriEntities();
        public PersonelAnaSayfa()
        {

            
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            listeGoster();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void listeGoster()
        {
            // başvuru listesi eklendi
            List<Models.basvuru> basvurular = db.basvuru.ToList();
            basvurular.Reverse();
            foreach(var basvuru in basvurular)
            {
                // kullaniciyi aldik
                Models.kullanici kullanici = db.kullanici.FirstOrDefault(x => x.id == basvuru.kullanici_id);
                Panel panel = new Panel();
                panel.Size = kart.Size;
                panel.BackColor = kart.BackColor;
                
                Label isimLabel = new Label();
                isimLabel.Font = isim.Font;
                isimLabel.Text = kullanici.isim;
                isimLabel.Location = isim.Location;
                isimLabel.Size = isim.Size;
                isimLabel.ForeColor = isim.ForeColor;

                Label soyisimLabel = new Label();
                soyisimLabel.Font = soyisim.Font;
                soyisimLabel.Text = kullanici.soyisim;
                soyisimLabel.Location = soyisim.Location;
                soyisimLabel.Size = soyisim.Size;
                soyisimLabel.ForeColor = soyisim.ForeColor;

                Label kacKisiLabel = new Label();
                kacKisiLabel.Font = odaTipi.Font;
                kacKisiLabel.Text = kullanici.odaTipi.ToString()+" kişilik oda";
                kacKisiLabel.Location = odaTipi.Location;
                kacKisiLabel.Size = odaTipi.Size;
                kacKisiLabel.ForeColor = odaTipi.ForeColor;

                Label onaylandimi = new Label();
                onaylandimi.Font = durum.Font;
                onaylandimi.Text = basvuru.onaylandimi ? "onaylandi" : "onaylanmadi";
                onaylandimi.Location = durum.Location;
                onaylandimi.Size = durum.Size;
                onaylandimi.ForeColor = durum.ForeColor;

                /*  Label onaylandiMi = new Label();
                  onaylandiMi.Font = durum.Font;
                  onaylandiMi.Text = basvuru.onaylandimi ? "ONAYLANDI" : "ONAYLANMADI";
                  onaylandiMi.Location = durum.Location;
                  onaylandiMi.Size = durum.Size;
                  onaylandiMi.ForeColor = durum.ForeColor;*/

                Button onaylaButton = new Button();
                onaylaButton.Font = onayla.Font;
                onaylaButton.Text = onayla.Text;
                onaylaButton.Location = onayla.Location;
                onaylaButton.Size = onayla.Size;
                onaylaButton.ForeColor = onayla.ForeColor;
                onaylaButton.Tag = basvuru.id;
                onaylaButton.Enabled = basvuru.onaylandimi ? false : true;
                

                onaylaButton.Click += onayla_click;

                Button iptalButton = new Button();
                iptalButton.Font = iptal.Font;
                iptalButton.Text = iptal.Text;
                iptalButton.Location = iptal.Location;
                iptalButton.Size = iptal.Size;
                iptalButton.ForeColor = iptal.ForeColor;
                iptalButton.Tag = basvuru.id;
                iptalButton.Click += iptal_click;
                iptalButton.Enabled = basvuru.onaylandimi ? true : false;

                panel.Controls.Add(isimLabel);
                panel.Controls.Add(soyisimLabel);
                panel.Controls.Add(kacKisiLabel);
                panel.Controls.Add(onaylaButton);
                panel.Controls.Add(iptalButton);
                panel.Controls.Add(onaylandimi);
                flowLayoutPanel1.Controls.Add(panel);
            }
          

        }

        private void iptal_click(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                int id = (int)button.Tag;
                Models.basvuru basvuru = db.basvuru.FirstOrDefault(x => x.id == id);
                basvuru.onaylandimi = false;
                db.SaveChanges();
                PersonelAnaSayfa personel = new PersonelAnaSayfa();
                personel.Show();
                this.Hide();


            }
        }

        private void onayla_click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int id = (int)button.Tag;
                Models.basvuru basvuru = db.basvuru.FirstOrDefault(x => x.id == id);
                basvuru.onaylandimi = true;
                db.SaveChanges();
                PersonelAnaSayfa personel = new PersonelAnaSayfa();
                personel.Show();
                this.Hide();

               
                
            }
        }

        private void PersonelAnaSayfa_Load(object sender, EventArgs e)
        {
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void durum_Click(object sender, EventArgs e)
        {

        }
    }
}
