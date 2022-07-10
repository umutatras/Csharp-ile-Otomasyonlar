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
    public partial class paketekleformu : Form
    {
        public paketekleformu()
        {
            InitializeComponent();
        }
        veritabani bgl = new veritabani();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from paket", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into paket(PaketAdi,PaketAgirligi,paketuruid,paketdurumid)values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", textBox1.Text);
            ekle.Parameters.AddWithValue("@p2", Convert.ToInt16(textBox2.Text));
            ekle.Parameters.AddWithValue("@p3", Convert.ToInt16(textBox3.Text));
            ekle.Parameters.AddWithValue("@p4", Convert.ToInt16(textBox4.Text));
            ekle.ExecuteNonQuery();
            MessageBox.Show("PAKET EKLENMİŞTİR ");
            listele();
            bgl.baglanti().Close();
        }

        private void paketekleformu_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
