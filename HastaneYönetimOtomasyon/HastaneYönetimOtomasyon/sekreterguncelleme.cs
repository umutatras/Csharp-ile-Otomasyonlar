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
    public partial class sekreterguncelleme : Form
    {
        public sekreterguncelleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string sktrtc;
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void sekretergun_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update sekreter_tablo set SekreterAd=@p1,SekreterSoyad=@p2,SekreterSifre=@p3,SekreterTel=@p4 where SekreterTc=@p6", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1",sekreteradgun.Text );
            guncelle.Parameters.AddWithValue("@p2",sekretersoyadgun.Text);
            guncelle.Parameters.AddWithValue("@p3",sekretersifregun.Text );
            guncelle.Parameters.AddWithValue("@p4",sekretertelgun.Text );
            guncelle.Parameters.AddWithValue("@p6",sekretertcgun.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("BİLGİLERİNİZ GÜNCELLENMİŞTİR !");
            sekreteradgun.Text = "";
            sekretersoyadgun.Text = "";
            sekretersifregun.Text = "";
            sekretertcgun.Text = "";
            sekretertelgun.Text = "";
        }
        private void sekreterguncelleme_Load(object sender, EventArgs e)
        {
            sekretertcgun.Text = sktrtc;
            SqlCommand komut = new SqlCommand("select* from sekreter_tablo where SekreterTc=@p7", bgl.baglanti());
            komut.Parameters.Add("@p7",sekretertcgun.Text );
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                sekretertcgun.Text=dr[3].ToString();
                sekreteradgun.Text=dr[1].ToString();
                sekretersoyadgun.Text=dr[2].ToString();
                sekretersifregun.Text=dr[4].ToString();
                sekretertelgun.Text=dr[5].ToString();            
            }
            bgl.baglanti().Close();
        }
    }
}
