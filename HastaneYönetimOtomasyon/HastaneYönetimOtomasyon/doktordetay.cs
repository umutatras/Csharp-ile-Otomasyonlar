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
    public partial class doktordetay : Form
    {
        public doktordetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string doktorrtc;
        private void randevubilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            doktorguncelleme drgun = new doktorguncelleme();
            drgun.doktortc = doktorbilgitc.Text;
            drgun.Show();
            
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void doktordetay_Load(object sender, EventArgs e)
        {
            doktorbilgitc.Text = doktorrtc;
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from doktor_tablo where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", doktorbilgitc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                doktorbilgiad.Text = dr[0] +" "+ dr[1];
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from randevu_tablo where RandevuDoktor='" + doktorbilgiad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            randevulist.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            duyuru dy = new duyuru();
            dy.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            wb.Navigate("www.google.com");
            wb.Visible = true;
            wb.Show();
        }

        private void randevulist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = randevulist.SelectedCells[0].RowIndex;
            sikayetric.Text = randevulist.Rows[secilen].Cells[7].Value.ToString();
        }

        

        
    }
}
