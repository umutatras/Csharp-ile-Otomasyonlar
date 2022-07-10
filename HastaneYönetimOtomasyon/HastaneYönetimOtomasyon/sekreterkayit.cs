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
    public partial class sekreterkayit : Form
    {
        public sekreterkayit()
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

        private void sekreterkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut12 = new SqlCommand("insert into sekreter_tablo(SekreterAd,SekreterSoyad,SekreterTc,SekreterSifre,SekreterTel) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut12.Parameters.Add("@p1", sekreterad.Text);
            komut12.Parameters.Add("@p2", sekretersoyad.Text);
            komut12.Parameters.Add("@p3", sekretertc.Text);
            komut12.Parameters.Add("@p4", sekretersifre.Text);
            komut12.Parameters.Add("@p5", sekretertel.Text);
            komut12.ExecuteNonQuery();
            MessageBox.Show("KAYDINIZ YAPILMIŞTIR !");
            sekreterlogin lgn = new sekreterlogin();
            lgn.Show();
            this.Close();
            bgl.baglanti().Close();
        }
    }
}
