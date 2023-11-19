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
    public partial class ilk_ekran : Form
    {
        public ilk_ekran()
        {
            InitializeComponent();
        }

        private void ilk_ekran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.öğrenci_giris ogrenci = new öğrenci_giris();
            ogrenci.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelGiris personel = new personelGiris();
            personel.Show();
            this.Hide();
        }
    }
}
