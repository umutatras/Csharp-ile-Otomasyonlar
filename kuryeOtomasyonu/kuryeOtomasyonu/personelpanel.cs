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
    public partial class personelpanel : Form
    {
        public personelpanel()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        sqlbaglantisi bgl = new sqlbaglantisi();  
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void textclear(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item.Controls.Count > 0)
                {
                    textclear(item);
                }
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand ekle = new SqlCommand("insert into paket(PaketAdi,PaketAgirligi,paketuruid,paketdurumid)values(@p1,@p2,@p3,@p4)", bgl.baglanti());
                ekle.Parameters.AddWithValue("@p1", textBox1.Text);
                ekle.Parameters.AddWithValue("@p2", Convert.ToInt16(textBox2.Text));
                ekle.Parameters.AddWithValue("@p3", Convert.ToInt16(textBox3.Text));
                ekle.Parameters.AddWithValue("@p4", Convert.ToInt16(textBox4.Text));
                ekle.ExecuteNonQuery();
                MessageBox.Show("PAKET EKLENMİŞTİR ");
                textclear(this);
                data1listele();
                comboBox6.Items.Clear();
                adlistele();                
                bgl.baglanti().Close();
                
            }
            catch
            {
                MessageBox.Show("DÜZGÜN DEĞER ARALIĞI GİRİNİZ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try {            
            SqlCommand ekle=new SqlCommand("insert into teslimedilenler(paketadi,teslimeden,teslimalan,tarih)values(@p1,@p2,@p3,@p4)",bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1",comboBox4.Text);
            ekle.Parameters.AddWithValue("@p2",comboBox3.Text);
            ekle.Parameters.AddWithValue("@p3",comboBox5.Text);
            ekle.Parameters.AddWithValue("@p4",textBox19.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("PAKET TESLİM EDİLDİ");
            SqlCommand güncelle = new SqlCommand("update paket set paketdurumid='2' where id=@p5",bgl.baglanti());
            güncelle.Parameters.AddWithValue("@p5",Convert.ToInt16(comboBox6.Text));
            güncelle.ExecuteNonQuery();
            SqlCommand sil = new SqlCommand("delete from paket where paketdurumid='2'", bgl.baglanti());
            sil.ExecuteNonQuery();
            SqlCommand sil2 = new SqlCommand("delete from musteritablo where MusteriAdiSoyadi=@p10",bgl.baglanti());
            sil2.Parameters.AddWithValue("@p10", comboBox5.Text);
            sil2.ExecuteNonQuery();
            data1listele();
            adlistele();
            bgl.baglanti().Close(); 
            }
            catch
            {
                MessageBox.Show("BEKLENMEDİK BİR HATA");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into kuryetablo(KuryeAdiSoyadi,TC,Numara,Telefon,Adres)values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", textBox5.Text);
            ekle.Parameters.AddWithValue("@p2", textBox6.Text);
            ekle.Parameters.AddWithValue("@p3", textBox7.Text);
            ekle.Parameters.AddWithValue("@p4", textBox8.Text);
            ekle.Parameters.AddWithValue("@p5", textBox9.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("KURYE BAŞARIYLA EKLENDİ");
            data1listele();
            textclear(this);
            bgl.baglanti().Close();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

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
            data1listele();
            MessageBox.Show("MÜŞTERİ BAŞARIYLA EKLENDİ");
            textclear(this);
            comboBox1.Text = "";
            comboBox2.Text = "";
            bgl.baglanti().Close();
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select sehir  from iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
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
        void data1listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from paket", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;           
         
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select*from kuryetablo", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

       
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3= new SqlDataAdapter("select*from musteritablo", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;

            DataTable dt4= new DataTable();
            SqlDataAdapter da4= new SqlDataAdapter("select*from teslimedilenler", bgl.baglanti());
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;
        }
        void adlistele()
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
        private void personelpanel_Load(object sender, EventArgs e)
        {
            sehirlistesi();
            data1listele();            
            adlistele();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
