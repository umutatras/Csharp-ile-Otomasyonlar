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
    public partial class girisform : Form
    {
        public girisform()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıtolmaform k = new kayıtolmaform();
            k.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(radioButton1.Checked==true)
            {
                SqlCommand kontrol = new SqlCommand("select *from musteritablo where Kuladi=@p1 and Sifre=@p2", bgl.baglanti());
                kontrol.Parameters.AddWithValue("@p1", textBox1.Text);
                kontrol.Parameters.AddWithValue("@p2", textBox2.Text);
                SqlDataReader dr = kontrol.ExecuteReader();
                if (dr.Read()) 
                {
                    musteripaneli mt = new musteripaneli();
                    mt.Show();
                    this.Hide();
                }
            }
                if(radioButton2.Checked==true)
                {
                  
                        SqlCommand kontrol1 = new SqlCommand("select *from lokantatablo where Kuladi=@p11 and Sifre=@p21", bgl.baglanti());
                        kontrol1.Parameters.AddWithValue("@p11", textBox1.Text);
                        kontrol1.Parameters.AddWithValue("@p21", textBox2.Text);
                        SqlDataReader dr1 = kontrol1.ExecuteReader();
                        if (dr1.Read())
                        {
                            lokanta t = new lokanta();
                            t.Show();
                            this.Hide();
                        }                                     
                 }
                
            }
        }
    }

