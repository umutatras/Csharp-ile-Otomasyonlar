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
    public partial class brans : Form
    {
        public brans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void brans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from brans_tablo", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void doktorgiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into brans_tablo(BransAd) values(@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", bransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("BRANŞ EKLENDİ !!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update brans_tablo set BransAd=@b4,Bransid=@b3",bgl.baglanti());
            kmt.Parameters.AddWithValue("@b3", textBox1.Text);
            kmt.Parameters.AddWithValue("@b4", bransad.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("BAŞARIYLA GÜNCELLENDİ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt1 = new SqlCommand("Delete From brans_tablo where Bransid=@b2", bgl.baglanti());
            kmt1.Parameters.AddWithValue("@b2", textBox1.Text);
            kmt1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("SİLİNDİ !!");
        }
    }
}
