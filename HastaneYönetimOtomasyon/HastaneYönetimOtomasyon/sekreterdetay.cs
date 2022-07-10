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
    public partial class sekreterdetay : Form
    {
        public sekreterdetay()
        {
            InitializeComponent();
        }
        public string tcsekreter;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void doktorbilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sekreterguncelleme sekretergun = new sekreterguncelleme();
            sekretergun.sktrtc = sekretertc.Text;
            sekretergun.Show();
            this.Hide();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void sekreterdetay_Load(object sender, EventArgs e)
        {
            sekretertc.Text = tcsekreter;
            SqlCommand komut = new SqlCommand("select SekreterAd,SekreterSoyad from sekreter_tablo where SekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sekretertc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                sekreterad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from brans_tablo ", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' '+DoktorSoyad)as 'Doktorlar',DoktorBrans From doktor_tablo ", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            SqlCommand komut1 = new SqlCommand("select BransAd from brans_tablo", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                comboBox1.Items.Add(dr1[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktorkayit dr = new doktorkayit();
            dr.Show();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brans br = new brans();
            br.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            randevulist rs = new randevulist();
            rs.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into randevu_tablo(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", maskedTextBox2.Text);
            kmt.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            kmt.Parameters.AddWithValue("@p3", comboBox1.Text);
            kmt.Parameters.AddWithValue("@p4", comboBox2.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("RANDEVU OLUŞTURULDU !");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlCommand komut2 = new SqlCommand("select DoktorAd,DoktorSoyad from doktor_tablo where DoktorBrans=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2[0]+" "+dr2[1]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt1 = new SqlCommand("insert into duyur_tablo(Duyuru) values(@d1)", bgl.baglanti());
            kmt1.Parameters.AddWithValue("@d1", sikayetric.Text);
            kmt1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("DUYURUNUZ OLUŞTURULDU !");
        }

    }
}
