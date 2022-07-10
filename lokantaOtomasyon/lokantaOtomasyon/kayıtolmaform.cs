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

namespace lokantaOtomasyon
{
    public partial class kayıtolmaform : Form
    {
        public kayıtolmaform()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand ekle = new SqlCommand("insert into musteritablo(Adisoyadi,Numarasi, Adres, Kuladi, Sifre)values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                ekle.Parameters.AddWithValue("@p1", textBox5.Text);
                ekle.Parameters.AddWithValue("@p2", textBox6.Text);
                ekle.Parameters.AddWithValue("@p3", textBox7.Text);
                ekle.Parameters.AddWithValue("@p4", textBox1.Text);
                ekle.Parameters.AddWithValue("@p5", textBox2.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("KAYIT EKLENMİŞTİR");
                bgl.baglanti().Close();
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand ekle = new SqlCommand("insert into lokantatablo(Adi,Numarası, Adres, Kuladi, Sifre)values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                ekle.Parameters.AddWithValue("@p1",firmadi.Text);
                ekle.Parameters.AddWithValue("@p2",firmano.Text);
                ekle.Parameters.AddWithValue("@p3",firmadres.Text);
                ekle.Parameters.AddWithValue("@p4",firmakuladi.Text);
                ekle.Parameters.AddWithValue("@p5",firmasifre.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("KAYIT EKLENMİŞTİR");
                bgl.baglanti().Close();
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }

    }
}
