using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimOtomasyon
{
    public partial class genellogin : Form
    {
        public genellogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastalogin hastalgn = new hastalogin();
            hastalgn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktorlogin logindoktor = new doktorlogin();
            logindoktor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sekreterlogin sklogin = new sekreterlogin();
            sklogin.Show();
            this.Hide();
        }
    }
}
