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
    public partial class hastanguncelleme : Form
    {
        public hastanguncelleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcno;
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunbtn_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update hasta_tablo set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1",gunad.Text);
            guncelle.Parameters.AddWithValue("@p2", gunsoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", guntel.Text);
            guncelle.Parameters.AddWithValue("@p4", gunsifre.Text);
            guncelle.Parameters.AddWithValue("@p5", guncinsiyet.Text);
            guncelle.Parameters.AddWithValue("@p6", guntc.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("BİLGİLERİNİ GÜNCELLENMİŞTİR !");

        }

        private void hastanguncelleme_Load(object sender, EventArgs e)
        {
            guntc.Text = tcno;
            SqlCommand komut = new SqlCommand("select* from hasta_tablo where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.Add("@p1", guntc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                gunad.Text = dr[1].ToString();
                gunsoyad.Text = dr[2].ToString();
                guntel.Text = dr[4].ToString();
                gunsifre.Text = dr[5].ToString();
                guncinsiyet.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
        }
    }
}
