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
    public partial class musteriekleformu : Form
    {
        public musteriekleformu()
        {
            InitializeComponent();
        }
        veritabani bgl = new veritabani();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from musteritablo", bgl.baglanti());
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        void sehirler()
        {
            SqlCommand komut = new SqlCommand("select sehir  from iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into musteritablo(MusteriAdiSoyadi,MusteriTc,MusteriTel,MusteriMail,Musteril,Musterilce,MusteriAdres)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", textBox10.Text);
            ekle.Parameters.AddWithValue("@p2", textBox11.Text);
            ekle.Parameters.AddWithValue("@p3", textBox12.Text);
            ekle.Parameters.AddWithValue("@p4", textBox13.Text);
            ekle.Parameters.AddWithValue("@p5", comboBox1.Text);
            ekle.Parameters.AddWithValue("@p6", comboBox2.Text);
            ekle.Parameters.AddWithValue("@p7", textBox14.Text);
            ekle.ExecuteNonQuery();
            listele();
            MessageBox.Show("MÜŞTERİ BAŞARIYLA EKLENDİ");
            bgl.baglanti().Close();
        }

        private void musteriekleformu_Load(object sender, EventArgs e)
        {
            listele();
            sehirler();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            SqlCommand komut = new SqlCommand("select ilce  from ilceler where sehir=@sehir", bgl.baglanti());
            komut.Parameters.AddWithValue("@sehir", comboBox1.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }
    }
}
