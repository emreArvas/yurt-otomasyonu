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
    public partial class KoduDogrula : Form
    {
        private int id;
        Models.yurt_kayit_bilgileriEntities db = new Models.yurt_kayit_bilgileriEntities();
        public KoduDogrula(int _id)
        {
            id = _id;
            InitializeComponent();
        }

        private void grsBTN_Click(object sender, EventArgs e)
        {
            Models.kullanici k = db.kullanici.FirstOrDefault(x => x.id == id);
            if (KOD.Text != k.aktivasyon)
            {
                MessageBox.Show("hatali kod girdiniz lütfen mail adresinizi kontrol edin");
            }
            else
            {
                login.Dogrula d = new Dogrula(k.id);
                d.Show();
                this.Hide();
            }
        }
    }
}
