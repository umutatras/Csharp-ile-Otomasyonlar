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
    public partial class yetkilikayıt : Form
    {
        public yetkilikayıt()
        {
            InitializeComponent();
        }
        veritabani bgl = new veritabani();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into login(PerKuladi,Sifre,mail,telefonno)values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", textBox1.Text);
            ekle.Parameters.AddWithValue("@p2", textBox2.Text);
            ekle.Parameters.AddWithValue("@p3", textBox3.Text);
            ekle.Parameters.AddWithValue("@p4", textBox4.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("KAYIT BAŞARILI");
            bgl.baglanti().Close();
        }
    }
}
