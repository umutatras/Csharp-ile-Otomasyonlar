using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _magazaotomasyonu
{
    public partial class müsteri : Form
    {
        public müsteri()
        {
            InitializeComponent();
        }
        baglanma baglan = new baglanma();
        public void siparisgoster()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from siparis where teslimtarihi='BEKLEMEDE'", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void kıyafet()
        {
            SqlCommand komut = new SqlCommand("select kıyafetürü  from KiyafetTuru", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox5.Items.Add(dr["kıyafetürü"]);

            }
            baglan.baglanti().Close();
        }
        void kıyafet2()
        {
            SqlCommand komut = new SqlCommand("select kıyafetadı  from Kıyafetler", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["kıyafetadı"]);

            }
            baglan.baglanti().Close();
        }
        void model()
        {

            SqlCommand komut = new SqlCommand("select model  from model", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["model"]);

            }
            baglan.baglanti().Close();
        }
        private void müsteri_Load(object sender, EventArgs e)
        {
            kıyafet();
            kıyafet2();
            model();
            siparisgoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fıyat = Convert.ToInt16(textBox8.Text) * Convert.ToInt16(textBox9.Text);
            textBox9.Text = fıyat.ToString();
            SqlCommand ekle = new SqlCommand("insert into siparis(MusteriAdi,Numarası,Adres,eposta,urunadı,urunmodel,adet,fiyat,teslimtarihi)values(@p1,@p2,@p3,@p4,@p5,@p7,@p8,@p9,@p10)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1", textBox1.Text);
            ekle.Parameters.AddWithValue("@p2", textBox2.Text);
            ekle.Parameters.AddWithValue("@p3", textBox3.Text);
            ekle.Parameters.AddWithValue("@p4", textBox4.Text);
            ekle.Parameters.AddWithValue("@p5", comboBox1.Text);
            ekle.Parameters.AddWithValue("@p7", comboBox3.Text);
            ekle.Parameters.AddWithValue("@p8", Convert.ToInt16(textBox8.Text));
            ekle.Parameters.AddWithValue("@p9", Convert.ToInt16(textBox9.Text));
            ekle.Parameters.AddWithValue("@p10", label14.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("EKLENDİ");
            baglan.baglanti().Close();


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            textBox9.Text = "";
            SqlCommand komut = new SqlCommand("select fiyatı  from Kıyafetler where kıyafetadı=@Adi", baglan.baglanti());
            komut.Parameters.AddWithValue("@Adi", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox9.Text = dr["fiyatı"].ToString();

            }
            baglan.baglanti().Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();           
            textBox8.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from siparis where MusteriAdi=@p1", baglan.baglanti());
            sil.Parameters.AddWithValue("@p1", textBox1.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("SİPARİŞ SİLİNDİ");
            siparisgoster();
            baglan.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fıyat = Convert.ToInt16(textBox8.Text) * Convert.ToInt16(textBox9.Text);
            textBox9.Text = fıyat.ToString();
            SqlCommand up = new SqlCommand("update siparis set fiyat=@p2 ", baglan.baglanti());
            up.Parameters.AddWithValue("@p2", Convert.ToInt16(textBox9.Text));
            up.ExecuteNonQuery();
            MessageBox.Show("SİPARİŞİNİZ GÜNCELLENDİ");
            siparisgoster();
            baglan.baglanti().Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * from siparis where Numarası like '" + textBox2.Text + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglan.baglanti());
            DataSet ds = new DataSet();
            adap.Fill(ds, "siparis");
            this.dataGridView1.DataSource = ds.Tables["Numarası"];
            baglan.baglanti().Close();
        }
    }
}
