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
    public partial class doktorkayit : Form
    {
        public doktorkayit()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktorguncelleme drr = new doktorguncelleme();
            drr.Show();            
        }

        private void doktorkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into doktor_tablo(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre,DoktorCins,DoktorTel) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",doktorad.Text);
            komut.Parameters.AddWithValue("@p2",doktorsoyad.Text);
            komut.Parameters.AddWithValue("@p3",doktortel.Text);
            komut.Parameters.AddWithValue("@p4",doktortc.Text);
            komut.Parameters.AddWithValue("@p5",doktorsifre.Text);
            komut.Parameters.AddWithValue("@p6",doktorcinsiyet.Text);
            komut.Parameters.AddWithValue("@p7",doktorbrans.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYDINIZ GERÇEKLEŞTİ !!");
        }

        private void doktorkayit_Load(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select BransAd from brans_tablo", bgl.baglanti());
            SqlDataReader dr2 = kmt.ExecuteReader();
            while (dr2.Read())
            {
                doktorbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }
    }
}
