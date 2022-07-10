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

namespace lokantaOtomasyon
{
    public partial class musteripaneli : Form
    {
        public musteripaneli()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        public void lokantalistesi()
        {
            SqlCommand komut = new SqlCommand("select Adi  from lokantatablo", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               lokanta1.Items.Add(dr["Adi"]);

            }
            bgl.baglanti().Close();
        }
        public void verilerigetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from siparistablo", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            no.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            adres.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            lokanta1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            yemek.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            adet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fiyat.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            tarih.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            durum.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void musteripaneli_Load(object sender, EventArgs e)
        {
            verilerigetir();
            lokantalistesi();
        }

        private void lokanta1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id.Items.Clear();
            id.Text = "";
            SqlCommand komut = new SqlCommand("select İd  from lokantatablo where Adi=@Adi", bgl.baglanti());
            komut.Parameters.AddWithValue("@Adi", lokanta1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                id.Items.Add(dr["İd"]);

            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fiyat.Text = (15 * Convert.ToInt32(adet.Text)).ToString();
            SqlCommand ekle = new SqlCommand("insert into siparistablo(MusteriAdi,MusteriNumarası,Adresi,Lokanta,yemek,Adet,Fiyat,tarih,durum)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", ad.Text);
            ekle.Parameters.AddWithValue("@p2", no.Text);
            ekle.Parameters.AddWithValue("@p3", adres.Text);
            ekle.Parameters.AddWithValue("@p4", lokanta1.Text);
            ekle.Parameters.AddWithValue("@p5", yemek.Text);
            ekle.Parameters.AddWithValue("@p6", adet.Text);
            ekle.Parameters.AddWithValue("@p7", fiyat.Text);
            ekle.Parameters.AddWithValue("@p8", tarih.Text);
            ekle.Parameters.AddWithValue("@p9", durum.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("SİPARİŞİNİZ ALINMIŞTIR ");
            verilerigetir();
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fiyat.Text = (15 * Convert.ToInt32(adet.Text)).ToString();
            SqlCommand up = new SqlCommand("update siparistablo set yemek=@y1,Adet=@y2,Fiyat=@y3 where MusteriAdi=@y4 ", bgl.baglanti());
            up.Parameters.AddWithValue("@y4", ad.Text);
            up.Parameters.AddWithValue("@y1", yemek.Text);
            up.Parameters.AddWithValue("@y2",adet.Text);
            up.Parameters.AddWithValue("@y3", fiyat.Text);
            up.ExecuteNonQuery();
            MessageBox.Show("SİPARİŞİNİZ GÜNCELLENDİ");
            verilerigetir();
            bgl.baglanti().Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from siparistablo where MusteriAdi=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", ad.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("SİPARİŞ SİLİNDİ");
            verilerigetir();
            bgl.baglanti().Close();
        }

        private void id_SelectedIndexChanged(object sender, EventArgs e)
        {
            yemek.Items.Clear();
            yemek.Text = "";
            SqlCommand komut = new SqlCommand("select yemekadı  from yemektablosu where lokantaid=@id", bgl.baglanti());
            komut.Parameters.AddWithValue("@id", id.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                yemek.Items.Add(dr["yemekadı"]);

            }
            bgl.baglanti().Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
