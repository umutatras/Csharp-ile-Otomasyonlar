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
    public partial class kuryekleformu : Form
    {
        public kuryekleformu()
        {
            InitializeComponent();
        }
        veritabani bgl = new veritabani();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from kuryetablo", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
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
            bgl.baglanti().Close();
        }

        private void kuryekleformu_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
