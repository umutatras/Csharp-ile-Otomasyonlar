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
namespace _KuryeOtomasyon
{
    public partial class girisformu : Form
    {
        public girisformu()
        {
            InitializeComponent();
        }
        veritabani bgl = new veritabani();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from login where PerKuladi=@s and Sifre=@s2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@s", textBox1.Text);
            kmt.Parameters.AddWithValue("@s2", textBox2.Text);
            SqlDataReader rd = kmt.ExecuteReader();
            if (rd.Read())
            {
                yetkiliformu y = new yetkiliformu();
                y.Show();
                this.Hide();
                bgl.baglanti().Close();

            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRESİ");
                bgl.baglanti().Close();
            }

        }
    }
}
