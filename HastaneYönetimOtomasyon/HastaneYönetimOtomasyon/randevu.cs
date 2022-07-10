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

namespace HastaneYönetimOtomasyon
{
    public partial class randevu : Form
    {
        public randevu()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void randevual_Click(object sender, EventArgs e)
        {
            SqlCommand kmtt = new SqlCommand("update randevu_tablo set RandevuDurum=1,RandevuSikayet=@p2,HastaTc=@p3 where Randevuid=@p4", bgl.baglanti());
            kmtt.Parameters.AddWithValue("@p2", randevusikayet.Text);
            kmtt.Parameters.AddWithValue("@p3", randevutc.Text);
            kmtt.Parameters.AddWithValue("@p4", textBox1.Text);
            kmtt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("RANDEVUNUZ ALINMIŞTIR.");

        }

        private void randevubilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hastanguncelleme hstgn = new hastanguncelleme();
            hstgn.tcno = randevutc.Text;
            hstgn.Show();
            
        }

        private void randevu_Load(object sender, EventArgs e)
        {
            //ad soyad çekme
            randevutc.Text = tc;
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from hasta_tablo where HastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", randevutc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                randevuad.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();
            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevu_tablo where HastaTc="+tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            bgl.baglanti().Close();     
            //brans
            SqlCommand kmt = new SqlCommand("select BransAd from brans_tablo", bgl.baglanti());
            SqlDataReader dr2 = kmt.ExecuteReader();
            while (dr2.Read())
            {
                randevubrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

       
      

        private void randevubrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevudoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from doktor_tablo where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", randevubrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                randevudoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void randevudoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from randevu_tablo where RandevuBrans='"+randevubrans.Text+"'"+"and RandevuDoktor='"+randevudoktor.Text+"'and RandevuDurum=0",bgl.baglanti());
            da2.Fill(dt2);
            randevuaktif.DataSource = dt2;
            bgl.baglanti().Close();
        }

       
        private void randevuaktif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = randevuaktif.SelectedCells[0].RowIndex;
            textBox1.Text = randevuaktif.Rows[secilen].Cells[0].Value.ToString();
        }

    }
}
