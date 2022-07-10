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
    public partial class lokanta : Form
    {
        public lokanta()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
       void lokantalistesi()
        {
            SqlCommand komut = new SqlCommand("select Adi  from lokantatablo", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Adi"]);

            }
            bgl.baglanti().Close();
        }
       void verilerigetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from siparistablo", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            SqlCommand komut = new SqlCommand("select İd  from lokantatablo where Adi=@Adi", bgl.baglanti());
            komut.Parameters.AddWithValue("@Adi", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["İd"]);

            }
            bgl.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into yemektablosu(yemekadı,lokantaid)values(@p1,@p2)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", yemekadi.Text);
            ekle.Parameters.AddWithValue("@p2", Convert.ToInt16(comboBox2.Text));
            ekle.ExecuteNonQuery();
            MessageBox.Show("YEMEK EKLENMİŞTİR");
            bgl.baglanti().Close();
        }

        private void lokanta_Load(object sender, EventArgs e)
        {
            lokantalistesi();
            verilerigetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand up = new SqlCommand("update siparistablo set durum=@p1 where MusteriAdi=@p2", bgl.baglanti());
            up.Parameters.AddWithValue("@p1", durum.Text);
            up.Parameters.AddWithValue("@p2", ad.Text);
            up.ExecuteNonQuery();
            MessageBox.Show("BAŞARIYLA TESLİM EDİLDİ");
            SqlCommand ekle = new SqlCommand("insert into teslim(siparisadi,müsteriadi,tarih,lokanta)values(@o1,@o2,@o3,@o4)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@o1", yemek.Text);
            ekle.Parameters.AddWithValue("@o2", ad.Text);
            ekle.Parameters.AddWithValue("@o3", tarih.Text);
            ekle.Parameters.AddWithValue("@o4", lokanta1.Text);
            ekle.ExecuteNonQuery();
            SqlCommand sil = new SqlCommand("delete from siparistablo where MusteriAdi=@m1", bgl.baglanti());
            sil.Parameters.AddWithValue("@m1", ad.Text);
            sil.ExecuteNonQuery();
            verilerigetir();
            bgl.baglanti().Close();
            
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
