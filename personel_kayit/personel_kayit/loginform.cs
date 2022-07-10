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
namespace personel_kayit
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUT-PC;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from personel_login_tablo where per_kuladi=@s and per_sifre=@s2", baglanti);
            kmt.Parameters.AddWithValue("@s", textBox1.Text);
            kmt.Parameters.AddWithValue("@s2", textBox2.Text);
            SqlDataReader rd = kmt.ExecuteReader();
            if (rd.Read()) {
                anaform frm = new anaform();
                frm.Show();
                this.Hide();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRESİ ! ", "HATA", MessageBoxButtons.OK,MessageBoxIcon.Error);
                baglanti.Close();
            }

            

           
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }       

        
    }
}
