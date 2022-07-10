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
    public partial class isverenpanel : Form
    {
        public isverenpanel()
        {
            InitializeComponent();
        }
        SqlBaglan baglan = new SqlBaglan();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from ilansonuc", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.Text;
            SqlCommand ekle = new SqlCommand("insert into ilanlar(ilanadi,meslek,pozisyon,ilanveren,Maas,adres,mail)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1", textBox1.Text);
            ekle.Parameters.AddWithValue("@p2", textBox2.Text);
            ekle.Parameters.AddWithValue("@p3", textBox3.Text);
            ekle.Parameters.AddWithValue("@p4", textBox4.Text);
            ekle.Parameters.AddWithValue("@p5", textBox5.Text);
            ekle.Parameters.AddWithValue("@p6", textBox6.Text);
            ekle.Parameters.AddWithValue("@p7", textBox7.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("İLAN VERİLDİ");
            baglan.baglanti().Close();
        }
        public void meslek()
        {
            SqlCommand komut = new SqlCommand("select MESLEK  from meslek", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["MESLEK"]);

            }
            baglan.baglanti().Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            SqlCommand komut = new SqlCommand("select ID  from meslek where MESLEK=@Adi", baglan.baglanti());
            komut.Parameters.AddWithValue("@Adi", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["ID"]);

            }
            baglan.baglanti().Close();
           
        }

        private void isverenpanel_Load(object sender, EventArgs e)
        {
            meslek();
            listele();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            SqlCommand komut = new SqlCommand("select İsadı  from isler where meslekid=@id", baglan.baglanti());
            komut.Parameters.AddWithValue("@id", Convert.ToInt16(comboBox2.Text));
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["İsadı"]);

            }
            baglan.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update ilansonuc set sonuc=@p2", baglan.baglanti());
            update.Parameters.AddWithValue("@p2", label11.Text);
            update.ExecuteNonQuery();
            MessageBox.Show("İŞE ALINDI");
            listele();
            baglan.baglanti().Close();
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
