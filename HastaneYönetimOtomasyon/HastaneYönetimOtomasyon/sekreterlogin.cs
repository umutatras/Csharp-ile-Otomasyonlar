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
    public partial class sekreterlogin : Form
    {
        public sekreterlogin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sekreteruyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sekreterkayit sekreterkayit = new sekreterkayit();
            sekreterkayit.Show();
            this.Hide();
        }

        private void sekretergiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from sekreter_tablo where SekreterTc=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sekretertc.Text);
            komut.Parameters.AddWithValue("@p2", sekretersifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                sekreterdetay skt = new sekreterdetay();
                skt.tcsekreter= sekretertc.Text;
                skt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KİMLİK NUMARASI VEYA ŞİFRE YANLIŞ !");
            }
        }
    }
}
