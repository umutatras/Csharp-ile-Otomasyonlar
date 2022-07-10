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
    public partial class isarayanpanel : Form
    {
        public isarayanpanel()
        {
            InitializeComponent();
        }
        SqlBaglan baglan = new SqlBaglan();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ilanadi,meslek,pozisyon,ilanveren,Maas,adres,mail from ilanlar", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand ekle = new SqlCommand("insert into ilansonuc(ilanadi,meslek,pozisyon,ilanveren,Maas,adres,mail,Basvuran,Sonuc)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1", textBox1.Text);
            ekle.Parameters.AddWithValue("@p2", textBox2.Text);
            ekle.Parameters.AddWithValue("@p3", textBox3.Text);
            ekle.Parameters.AddWithValue("@p4", textBox4.Text);
            ekle.Parameters.AddWithValue("@p5", textBox5.Text);
            ekle.Parameters.AddWithValue("@p6", textBox6.Text);
            ekle.Parameters.AddWithValue("@p7", textBox7.Text);
            ekle.Parameters.AddWithValue("@p9", label2.Text);
            ekle.Parameters.AddWithValue("@p8", textBox8.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("İLAN VERİLDİ");
            baglan.baglanti().Close();
        }

        private void isarayanpanel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
