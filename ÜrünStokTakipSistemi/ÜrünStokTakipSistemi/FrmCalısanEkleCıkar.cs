using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Sql kütüphanesi


namespace ÜrünStokTakipSistemi
{
    public partial class FrmCalısanEkleCıkar : Form
    {
        public FrmCalısanEkleCıkar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP - 4A60A25\\SQLEXPRESS;Initial Catalog = ÜrünStokTakipSistemi; Integrated Security = True");// sql bağlantı kodu
        private void FrmCalısanEkleCıkar_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calısanekle_Click(object sender, EventArgs e)
        {
            FrmCE frm = new FrmCE();//calısanekle butonuna bastığımızda calışan ekle formu açılır
            frm.Show();             //calışan ekle formu açılır
            this.Hide();            //bu formu kapatır

        }

        private void btn_Calısancıkar_Click(object sender, EventArgs e)
        {
            FrmCalısanCıkarma frm = new FrmCalısanCıkarma(); //calısancıkar butonuna bastığımızda calışan cıkarma formu açılır
            frm.Show();                                      //calışan çıkarma formu açılır
            this.Hide();                                      //bu formu kapatır
        } 
    }
}
