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
using System.Runtime.InteropServices;

namespace kuryeOtomasyonu
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        sqlbaglantisi bgl = new sqlbaglantisi();       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from personelogin where PerKuladi=@s and Sifre=@s2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@s", textBox1.Text);
            kmt.Parameters.AddWithValue("@s2", textBox2.Text);
            SqlDataReader rd = kmt.ExecuteReader();
            if (rd.Read())
            {
                personelpanel p = new personelpanel();
                p.Show();
                this.Hide();
                bgl.baglanti().Close();

            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRESİ ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bgl.baglanti().Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelkayit k = new personelkayit();
            k.Show();
        }
    }
}
