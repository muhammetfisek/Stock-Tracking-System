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
    public partial class FrmCE : Form
    {
        public FrmCE()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4A60A25\\SQLEXPRESS;Initial Catalog=ÜrünStokTakipSistemi;Integrated Security=True");// sql bağlantı kodu
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_CalisanBilgileri (CalisanTc_No,SicilNo,Ad,Soyad,Cinsiyet) values (@p1,@p2,@p3,@p4,@p5) ", baglanti);// veri tabanında yönetici tablosundan tc yi,sicilnoyu,ad,soyadı ve cinsiyeti alır
            komut.Parameters.AddWithValue("@p1", msk_TC.Text); //// komut nesnesinden gelen tc yi,sicilnoyu,ad,soyadı ve cinsiyeti  değer olarak ekler
            komut.Parameters.AddWithValue("@p2", TXT_SicilNo.Text);
            komut.Parameters.AddWithValue("@p3", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p4", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p5", label6.Text);

            komut.ExecuteNonQuery(); //komut sorgular 
            baglanti.Close();//bağlantıyı kapatır
            MessageBox.Show("Çalışan  eklendi");//çalışan eklendi diye mesaj verir 
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "True") //eğer label6 true olursa
            {
                radioButton1.Checked = true; //erkek seçili olur
            }
            if (label6.Text == "False") //eğer label6 false olursa
            {
                radioButton1.Checked = false; //erkek seçili olmaz
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) //eğer erkek seçili olursa
            {
                label6.Text = "True";        //label6 true olur
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false) //eğer erkek seçili olmazsa
            {
                label6.Text = "False";          //label6 false olur     
            }
        }

        private void FrmCE_Load(object sender, EventArgs e)
        {

        }
    }
}
