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
    public partial class doktorguncelleme : Form
    {
        public doktorguncelleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string doktortc;
        private void doktorgun_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update doktor_tablo set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p7,DoktorSifre=@p5,DoktorCins=@p6,DoktorTel=@p3 where DoktorTc=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", doktoradgun.Text);
            komut.Parameters.AddWithValue("@p2", doktorsoyadgun.Text);
            komut.Parameters.AddWithValue("@p3", doktortelgun.Text);
            komut.Parameters.AddWithValue("@p4", doktortcgun.Text);
            komut.Parameters.AddWithValue("@p5", doktorsifregun.Text);
            komut.Parameters.AddWithValue("@p6", doktorcinsiyetgun.Text);
            komut.Parameters.AddWithValue("@p7", doktorbransgun.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("GÜNCELLENME GERÇEKLEŞTİ !!");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into doktor_tablo(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre,DoktorCins,DoktorTel) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", doktoradgun.Text);
            komut.Parameters.AddWithValue("@p2", doktorsoyadgun.Text);
            komut.Parameters.AddWithValue("@p3", doktortelgun.Text);
            komut.Parameters.AddWithValue("@p4", doktortcgun.Text);
            komut.Parameters.AddWithValue("@p5", doktorsifregun.Text);
            komut.Parameters.AddWithValue("@p6", doktorcinsiyetgun.Text);
            komut.Parameters.AddWithValue("@p7", doktorbransgun.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYDINIZ GERÇEKLEŞTİ !!");
        }

        private void doktorguncelleme_Load(object sender, EventArgs e)
        {
            doktortcgun.Text = doktortc;
            SqlCommand komut1 = new SqlCommand("select * from doktor_tablo where DoktorTc=@p8", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p8", doktortcgun.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                doktoradgun.Text = dr[1].ToString();
                doktorsoyadgun.Text = dr[2].ToString();
                doktortelgun.Text = dr[3].ToString();
                doktorbransgun.Text = dr[7].ToString();
                doktortcgun.Text = dr[4].ToString();
                doktorsifregun.Text = dr[5].ToString();
                doktorcinsiyetgun.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Delete from doktor_tablo where DoktorTc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", doktortcgun.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT SİLİNMİŞTİR !!");
        }
    }
}
