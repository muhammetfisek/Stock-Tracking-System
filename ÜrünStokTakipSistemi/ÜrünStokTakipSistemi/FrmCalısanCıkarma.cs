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
    public partial class FrmCalısanCıkarma : Form
    {
        public FrmCalısanCıkarma()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4A60A25\\SQLEXPRESS;Initial Catalog=ÜrünStokTakipSistemi;Integrated Security=True");// sql bağlantı kodu
        public void getir() // getir adında 
        {
            baglanti.Open();//bağlantıyı açar
            string getir = "select * from tbl_CalisanBilgileri "; // sql de çalısanbilgileri adındaki tablodan değer getirir
            SqlCommand komut = new SqlCommand(getir, baglanti);//komut nesnesi ile bağlantıyı açar
            SqlDataAdapter ad = new SqlDataAdapter(komut);//verileri almak ve kaydetmek için ve SQL Server arasında bir DataSet köprü görevi görür
            DataTable dt = new DataTable();//Satırlar datayı, sütunlar da veri alanlarını temsil eder
            ad.Fill(dt);
            dataGridView1.DataSource = dt;//databaseden çekilen verilerin veya geçici olarak oluşturulan dataların saklandığı verilerin gösterilmesine yarar
            baglanti.Close();//bağlantıyı kapatır
        }
        
        private void FrmCalısanCıkarma_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            //Burda tabloda ki model noyu kayit string değişkenine atıyıyoruz
            string kayit = "Select * From tbl_CalisanBilgileri Where CalisanTc_No=@c1";
            //Aratma işlemi için
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            //textboxa model noyu yazarak tablodan aratıyoruz
            komut.Parameters.AddWithValue("@c1", msktc.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            //Tabloyu aradaığımız değerle Dolduruyoruz - tabi veri tabanında varsa
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
        }

        private void btn_CalısanCıkar_Click(object sender, EventArgs e)
        {
            baglanti.Open();//bağlantıyı açar
            SqlCommand komutsil = new SqlCommand("Delete From tbl_CalisanBilgileri Where CalisanTc_No=@k1 ", baglanti);// veri tabanında yönetici tablosundan tc yi alır
            komutsil.Parameters.AddWithValue("@k1", msktc.Text);// komut nesnesinden gelen tc yi  değer olarak ekler
            komutsil.ExecuteNonQuery();//sorguyu çalıştırır
            baglanti.Close(); //bağlantıyı kapatır
            MessageBox.Show("Çalışan çıkarıldı "); // çalışan çıkarıldı şeklinde mesaj verir
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
