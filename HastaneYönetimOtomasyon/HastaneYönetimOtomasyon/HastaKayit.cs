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
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void HastaKayit_Load(object sender, EventArgs e)
        {
            hastaad.Focus();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hastakaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into hasta_tablo(HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet)values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",hastaad.Text);
            komut.Parameters.AddWithValue("@p2",hastasoyad.Text);
            komut.Parameters.AddWithValue("@p3",hastatckayıt.Text);
            komut.Parameters.AddWithValue("@p4",hastatel.Text);
            komut.Parameters.AddWithValue("@p5",hastasifretext.Text);
            komut.Parameters.AddWithValue("@p6",hastacins.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT BAŞARILI !\nŞİFRENİZ : "+hastasifretext.Text,"BİLGİ", MessageBoxButtons.OK,MessageBoxIcon.Information);
            

        }
    }
}
