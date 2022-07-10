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
    public partial class kayitekleme : Form
    {
        public kayitekleme()
        {
            InitializeComponent();
        }
        SqlBaglan baglan = new SqlBaglan();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into isveren(Adisoyadi,Numarasi,Adres,mail,kullaniciadi,sifre)values(@p1,@p2,@p3,@p4,@p5,@p6)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1", ad.Text);
            ekle.Parameters.AddWithValue("@p2", soyad.Text);
            ekle.Parameters.AddWithValue("@p3", adres.Text);
            ekle.Parameters.AddWithValue("@p4", mail.Text);
            ekle.Parameters.AddWithValue("@p5", kula.Text);
            ekle.Parameters.AddWithValue("@p6", kulsif.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("EKLENDİ");
            baglan.baglanti().Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into isarayan(AdiSoyadi,Numarasi,Adres,Mail,Kullaniciadi,Sifre)values(@p1,@p2,@p3,@p4,@p5,@p6)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1", iad.Text);
            ekle.Parameters.AddWithValue("@p2", ino.Text);
            ekle.Parameters.AddWithValue("@p3", iadres.Text);
            ekle.Parameters.AddWithValue("@p4", imail.Text);
            ekle.Parameters.AddWithValue("@p5", ikul.Text);
            ekle.Parameters.AddWithValue("@p6", isifre.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("EKLENDİ");
            baglan.baglanti().Close();
        }
    }
}
