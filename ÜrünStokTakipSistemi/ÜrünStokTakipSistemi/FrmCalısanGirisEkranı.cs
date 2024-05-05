using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜrünStokTakipSistemi
{
    public partial class FrmCalısanGirisEkranı : Form
    {
        public FrmCalısanGirisEkranı()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            FrmUrunEkrani frm = new FrmUrunEkrani(); // giriş butonuna tıkladığımızda 
            frm.Show();                              // urun ekrani formunu açar
            this.Hide();                             // bu formu kapatır
        }
    }
}
