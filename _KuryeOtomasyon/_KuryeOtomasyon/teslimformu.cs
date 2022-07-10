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
    public partial class teslimformu : Form
    {
        public teslimformu()
        {
            InitializeComponent();
        }
        veritabani bgl = new veritabani();
        void adlar()
        {
            SqlCommand komut = new SqlCommand("select  KuryeAdiSoyadi from kuryetablo", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["KuryeAdiSoyadi"]);

            }
            SqlCommand komut2 = new SqlCommand("select  MusteriAdiSoyadi from musteritablo", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox5.Items.Add(dr2["MusteriAdiSoyadi"]);

            }
            SqlCommand komut3 = new SqlCommand("select  id from paket", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox6.Items.Add(dr3["id"]);

            }
            bgl.baglanti().Close();

        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from teslimedilenler", bgl.baglanti());
            da.Fill(dt);
            dataGridView4.DataSource = dt;

        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox4.Text = "";
            SqlCommand komut = new SqlCommand("select PaketAdi  from paket where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToInt16(comboBox6.Text));
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr["PaketAdi"]);

            }
            bgl.baglanti().Close();
        }

        private void teslimformu_Load(object sender, EventArgs e)
        {
            adlar();
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into teslimedilenler(paketadi,teslimeden,teslimalan,tarih)values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", comboBox4.Text);
            ekle.Parameters.AddWithValue("@p2", comboBox3.Text);
            ekle.Parameters.AddWithValue("@p3", comboBox5.Text);
            ekle.Parameters.AddWithValue("@p4", textBox19.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("PAKET TESLİM EDİLDİ");
            SqlCommand güncelle = new SqlCommand("update paket set paketdurumid='2' where id=@p5", bgl.baglanti());
            güncelle.Parameters.AddWithValue("@p5", Convert.ToInt16(comboBox6.Text));
            güncelle.ExecuteNonQuery();
            SqlCommand sil = new SqlCommand("delete from paket where paketdurumid='2'", bgl.baglanti());
            sil.ExecuteNonQuery();
            SqlCommand sil2 = new SqlCommand("delete from musteritablo where MusteriAdiSoyadi=@p10", bgl.baglanti());
            sil2.Parameters.AddWithValue("@p10", comboBox5.Text);
            sil2.ExecuteNonQuery();
            listele();
            adlar();
            bgl.baglanti().Close(); 
        }
    }
}
