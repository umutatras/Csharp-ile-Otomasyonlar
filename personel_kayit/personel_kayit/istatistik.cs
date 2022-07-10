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
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUT-PC;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand say = new SqlCommand("Select Count(*)From personel_tablo", baglanti);
            SqlDataReader dr1 = say.ExecuteReader();
            while(dr1.Read())
            {
                lbltop.Text = dr1[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand say2 = new SqlCommand("Select Count(*)From personel_tablo where per_durum=1", baglanti);
            SqlDataReader dr2 = say2.ExecuteReader();
            while (dr2.Read())
            {
                lblevli.Text = dr2[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand say3 = new SqlCommand("Select Count(*)From personel_tablo where per_durum=0", baglanti);
            SqlDataReader dr3 = say3.ExecuteReader();
            while (dr3.Read())
            {
                lblbekar.Text = dr3[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand say4 = new SqlCommand("Select Count(distinct(per_sehir)) from personel_tablo", baglanti);//distinct farklı olanları sayar.
            SqlDataReader dr4 = say4.ExecuteReader();
            while (dr4.Read())
            {
                lblsehir.Text = dr4[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand say5 = new SqlCommand("Select sum(per_maas) From personel_tablo ", baglanti);
            SqlDataReader dr5 = say5.ExecuteReader();
            while (dr5.Read())
            {
                lblmaas.Text = dr5[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand say6 = new SqlCommand("Select avg(per_maas) From personel_tablo ", baglanti);
            SqlDataReader dr6= say6.ExecuteReader();
            while (dr6.Read())
            {
                lblort.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
