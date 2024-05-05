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
    public partial class FrmUrunEkrani : Form
    {
        public FrmUrunEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4A60A25\\SQLEXPRESS;Initial Catalog=ÜrünStokTakipSistemi;Integrated Security=True");// sql bağlantı kodu
        private void listele()
        {
            //ürün_ekle tablosunu seçti ve bağlandık
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_Urun", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            //ilk model_no olan satırsan doldurmaya başladık
            da.Fill(ds, "model_no");
            dataGridView1.DataSource = ds.Tables["model_no"];
            baglanti.Close();
        }
        
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();// bağlantıyı açar
            string sil = "UPDATE tbl_Urun SET  ModelNo= '" + txt_ModelNo.Text + "',UrunRengi='" + txt_UrunRengi.Text + "',ToplamHacim='" + txt_ToplamHacim.Text + "',EnerjiSınıfı='" + txt_EnerjiSınıfı.Text + "' WHERE ModelNo='" + txt_ModelNo.Text + "'";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            komut.Parameters.AddWithValue("@ModelNo", txt_ModelNo.Text);// komut nesnesinden gelen modelno değer olarak ekler
            komut.ExecuteNonQuery();//sorguyu çalıştırır
            baglanti.Close();//bağlantıyı kapatır
            MessageBox.Show("Başarıyla güncellendi."); //başarıyla güncellendi mesajı verir
            
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();//bağlantıyı açar
            SqlCommand komut = new SqlCommand("insert into tbl_Urun (ModelNo,UrunRengi,ToplamHacim,EnerjiSınıfı) values (@p1,@p2,@p3,@p4) ", baglanti);// veri tabanında urun tablosundan modelno,urunrengi,toplamhacim ve enerji sınıfını alır
            komut.Parameters.AddWithValue("@p1", txt_ModelNo.Text);// komut nesnesinden gelen modelno,urunrengi,toplamhacim ve enerji sınıfını değer olarak ekler
            komut.Parameters.AddWithValue("@p2", txt_UrunRengi.Text);
            komut.Parameters.AddWithValue("@p3", txt_ToplamHacim.Text);
            komut.Parameters.AddWithValue("@p4", txt_EnerjiSınıfı.Text);
           

            komut.ExecuteNonQuery();//sorguyu çalıştırır
            baglanti.Close();//bağlantıyı kapatır
            MessageBox.Show("Ürün Eklendi");// ürün eklendi diye mesaj verir
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ModelNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //datagredview de gelen bilgileri gösterir
            txt_ToplamHacim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_UrunRengi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          txt_EnerjiSınıfı.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //txtmdln.text 'ine modelno yu yazıp öyle siliyoruz 
            baglanti.Open();//bağlantıyı açar
            SqlCommand komutsil = new SqlCommand("Delete From tbl_Urun Where ModelNo=@k1 ", baglanti);//// veri tabanında yönetici tablosundan modelno yu  alır
            komutsil.Parameters.AddWithValue("@k1", txtmdln.Text);// komut nesnesinden gelen modelno yu değer olarak ekler
            komutsil.ExecuteNonQuery(); //sorguyu çalıştırır
            baglanti.Close();//bağlantıyı kapatır
            MessageBox.Show("kayıt silindi");// kayıt silindi diye mesaj verir
        }

        private void FrmUrunEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
           
            listele(); //Tüm ürünleri datagridview de listeler

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            //Burda tabloda ki model noyu kayit string değişkneine atıyıyoruz
            string kayit = "Select * From tbl_Urun Where ModelNo=@c1";
            //Aratma işlemi için
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            //textboxa model noyu yazarak tablodan aratıyoruz
            komut.Parameters.AddWithValue("@c1", txtmdln.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            //Tabloyu aradaığımız değerle Dolduruyoruz - tabi veri tabanında varsa
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
        }
    }
}
