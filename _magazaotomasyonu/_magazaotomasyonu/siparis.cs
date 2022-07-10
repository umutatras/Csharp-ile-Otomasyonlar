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

namespace _magazaotomasyonu
{
    public partial class siparis : Form
    {
        public siparis()
        {
            InitializeComponent();
        }
        baglanma baglan = new baglanma();
        public void siparisgoster()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from siparis where teslimtarihi='BEKLEMEDE'", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void siparis_Load(object sender, EventArgs e)
        {
            siparisgoster();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand ekle=new SqlCommand("insert into KiyafetTuru(ID,kıyafetürü)values(@p1,@p2)",baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1",Convert.ToInt16(textBox16.Text));
            ekle.Parameters.AddWithValue("@p2", textBox10.Text);
            ekle.ExecuteNonQuery();
            SqlCommand ekle1 = new SqlCommand("insert into Kıyafetler(kıyafetadı,turid,fiyatı)values(@o1,@o2,@o3)", baglan.baglanti());
            ekle1.Parameters.AddWithValue("@o1", textBox1.Text);
            ekle1.Parameters.AddWithValue("@o2",Convert.ToInt16(textBox16.Text));
            ekle1.Parameters.AddWithValue("@o3", textBox4.Text);
            ekle1.ExecuteNonQuery();
            MessageBox.Show("ürün eklendi");
            baglan.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand tarihver = new SqlCommand("update siparis set teslimtarihi=@p1 where Numarası=@p2", baglan.baglanti());
            tarihver.Parameters.AddWithValue("@p1", textBox15.Text);
            tarihver.Parameters.AddWithValue("@p2", textBox12.Text);
            tarihver.ExecuteNonQuery();
            MessageBox.Show("TARİH VERİLDİ");
            siparisgoster();
            baglan.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox11.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox12.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox13.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox14.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }
    }
}
