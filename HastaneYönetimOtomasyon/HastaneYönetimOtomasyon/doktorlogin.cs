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
    public partial class doktorlogin : Form
    {
        public doktorlogin()
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

     

        private void doktorgiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from doktor_tablo where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", doktortc.Text);
            komut.Parameters.AddWithValue("@p2", doktorsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                doktordetay drdetay = new doktordetay();
                drdetay.doktorrtc = doktortc.Text;
                drdetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("YANLIŞ TCNO VEYA ŞİFRE !!");
            }
        }

        private void hastauye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            doktorkayit dr = new doktorkayit();
            dr.Show();
        }
    }
}
