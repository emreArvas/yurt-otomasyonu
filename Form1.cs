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

namespace YurtOtomasyonu1._0
{
    public partial class Form1 : Form
    {
        yurt_kayit_bilgileriEntities entites = new yurt_kayit_bilgileriEntities();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
