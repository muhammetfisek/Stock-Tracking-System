using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql kütüphanesi

namespace ÜrünStokTakipSistemi
{
    public partial class FrmYöneticiGiris : Form
    {
        public FrmYöneticiGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4A60A25\\SQLEXPRESS;Initial Catalog=ÜrünStokTakipSistemi;Integrated Security=True");// sql bağlantı kodu
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();// bağlantıyı açar
            SqlCommand komut = new SqlCommand("Select * From tbl_Yonetici where Tc_no=@p1 and Sifre=@p2", baglanti);// veri tabanında yönetici tablosundan tc ve şifreyi alır
            komut.Parameters.AddWithValue("@p1", msk_YoneticiTc.Text);// komut nesnesinden gelen tc yi  değer olarak ekler
            komut.Parameters.AddWithValue("@p2", txt_Sifre.Text);     // komut nesnesinden gelen şifre yi  değer olarak ekler
            SqlDataReader dr = komut.ExecuteReader();      //komut sorgular           
            if (dr.Read()) // eğer okursa
            {
                FrmCalısanEkleCıkar frm = new FrmCalısanEkleCıkar();// çalısaneklecıkar formunu açar
                frm.Show();
                this.Hide();                                        // bu formu kapatır
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre ");  //okumazsa messagebox ile mesaj verir
            }
            baglanti.Close(); //bağlantıyı kapatır


        }

        private void FrmYöneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
