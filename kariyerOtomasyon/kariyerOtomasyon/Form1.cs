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

namespace kariyerOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglan baglan = new SqlBaglan();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                SqlCommand kontrol = new SqlCommand("select *from isarayan where Kullaniciadi=@p1 and Sifre=@p2", baglan.baglanti());
                kontrol.Parameters.AddWithValue("@p1", textBox1.Text);
                kontrol.Parameters.AddWithValue("@p2", textBox2.Text);
                SqlDataReader dr = kontrol.ExecuteReader();
                if (dr.Read())
                {
                    isarayanpanel iss=new isarayanpanel();
                    iss.Show();
                    this.Hide();
                }
            }
            if (radioButton2.Checked == true)
            {

                SqlCommand kontrol1 = new SqlCommand("select *from isveren where kullaniciadi=@p11 and sifre=@p21", baglan.baglanti());
                kontrol1.Parameters.AddWithValue("@p11", textBox1.Text);
                kontrol1.Parameters.AddWithValue("@p21", textBox2.Text);
                SqlDataReader dr1 = kontrol1.ExecuteReader();
                if (dr1.Read())
                {
                    isverenpanel isveren = new isverenpanel();
                    isveren.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitekleme ek = new kayitekleme();
            ek.Show();

        }
    }
}
