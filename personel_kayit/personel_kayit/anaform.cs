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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            textid.Text = "";
            textad.Text = "";
            textsoyad.Text = "";
            combosehir.Text = "";
            textmaas.Text = "";
            radioevli.Checked = false;
            radiobekar.Checked = false;
            textmeslek.Text = "";

        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUT-PC;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.personel_tabloTableAdapter.Fill(this.personelVeriTabaniDataSet1.personel_tablo);
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into personel_tablo(per_ad,per_soyad,per_sehir,per_maas,per_durum,per_meslek) values(@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut.Parameters.AddWithValue("@p2", textad.Text);
            komut.Parameters.AddWithValue("@p3", textsoyad.Text);
            komut.Parameters.AddWithValue("@p4", combosehir.Text);
            komut.Parameters.AddWithValue("@p5", textmaas.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);        
            komut.Parameters.AddWithValue("@p7", textmeslek.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT BAŞARIYLA EKLENMİŞTİR");
        }
        private void radioevli_CheckedChanged(object sender, EventArgs e)
        {
            if(radioevli.Checked==true)
                label8.Text = "True";
        }
        private void radiobekar_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobekar.Checked == true)
                label8.Text = "False";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combosehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text=="True")
            {
                radioevli.Checked = true;
            }
            if(label8.Text=="False")
            {
                radiobekar.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmtsil = new SqlCommand("Delete From personel_tablo Where Personelid=@k1", baglanti);
            kmtsil.Parameters.AddWithValue("@k1",textid.Text);
            kmtsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT BAŞARIYLA SİLİNMİŞTİR");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmtupdate = new SqlCommand("Update personel_tablo set per_ad=@ad,per_soyad=@soyad,per_sehir=@sehir,per_maas=@maas,per_durum=@durum,per_meslek=@meslek where Personelid=@id", baglanti);
            kmtupdate.Parameters.AddWithValue("@id", textid.Text);
            kmtupdate.Parameters.AddWithValue("@ad", textad.Text);
            kmtupdate.Parameters.AddWithValue("@soyad", textsoyad.Text);
            kmtupdate.Parameters.AddWithValue("@sehir", combosehir.Text);
            kmtupdate.Parameters.AddWithValue("@maas", textmaas.Text);
            kmtupdate.Parameters.AddWithValue("@durum", label8.Text);
            kmtupdate.Parameters.AddWithValue("@meslek", textmeslek.Text);
            kmtupdate.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT BAŞARIYLA GÜNCELLENMİŞTİR");
  

        }

        private void btnist_Click(object sender, EventArgs e)
        {
            istatistik ist = new istatistik();
            ist.Show();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            grafikform grf = new grafikform();
            grf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            raporform rpr = new raporform();
            rpr.Show();
        }       
    }
}
