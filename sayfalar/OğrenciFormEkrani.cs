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
    public partial class OğrenciFormEkrani : Form
    {
        private int _id;
        Models.yurt_kayit_bilgileriEntities db = new Models.yurt_kayit_bilgileriEntities();
        public OğrenciFormEkrani(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OğrenciFormEkrani_Load(object sender, EventArgs e)
        {
            Models.kullanici users = db.kullanici.FirstOrDefault(x => x.id == _id);
            Models.basvuru basvuru = db.basvuru.FirstOrDefault(x => x.kullanici_id == _id);

            isim.Text = users.isim;
            soyisim.Text = users.soyisim;
            tc.Text = users.Tc;
            odatipi.Text = users.odaTipi.ToString()+" kişilik oda";
            onaylandimi.Text = basvuru.onaylandimi ? "ONAYLANDI" : "ONAYLANMADI";
            
        }

        private void isim_Click(object sender, EventArgs e)
        {

        }
    }
}
