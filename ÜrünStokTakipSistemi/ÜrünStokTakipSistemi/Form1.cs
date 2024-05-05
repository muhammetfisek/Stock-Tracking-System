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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Yönetici_Click(object sender, EventArgs e)
        {
            FrmYöneticiGiris yeniform = new FrmYöneticiGiris(); //Yönetici butonuna tıkladığımızda 
            yeniform.Show();                                    //Yönetici giriş formuna götürür
            this.Hide();                                        //Bu formu kapatır

        }

        private void btn_Calısan_Click(object sender, EventArgs e)
        {
            FrmCalısanGirisEkranı frm = new FrmCalısanGirisEkranı(); //Çalışan butonuna tıkladığımızda
            frm.Show();                                              //Çalışan giriş formuna götürür
            this.Hide();                                             //Bu formu kapatır

        }


    }
}
