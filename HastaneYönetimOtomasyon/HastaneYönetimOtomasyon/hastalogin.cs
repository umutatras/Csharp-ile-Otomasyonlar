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
    public partial class hastalogin : Form
    {
        public hastalogin()
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

        private void hastalogin_Load(object sender, EventArgs e)
        {
            hastatc.Focus();
        }

        private void hastauye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayit hskayit = new HastaKayit();
            hskayit.Show();
           
        }

        private void hastagiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from hasta_tablo where HastaTc=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hastatc.Text);
            komut.Parameters.AddWithValue("@p2", hastasifrelogin.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                randevu rv = new randevu();
                rv.tc = hastatc.Text;
                rv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI KİMLİK NUMARASI VEYA ŞİFRE !");
            }
            bgl.baglanti().Close();
            
          
            
        }
    }
}
