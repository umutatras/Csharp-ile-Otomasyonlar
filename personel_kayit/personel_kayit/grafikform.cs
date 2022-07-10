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
    public partial class grafikform : Form
    {
        public grafikform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUT-PC;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void grafikform_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt1 = new SqlCommand("Select per_sehir,count(*) from personel_tablo Group By per_sehir", baglanti);
            SqlDataReader dr = kmt1.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(dr[0], dr[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("Select per_meslek,Avg(per_maas) from personel_tablo Group By per_meslek", baglanti);
            SqlDataReader dr1 = kmt2.ExecuteReader();
            while (dr1.Read())
            {
                chart2.Series["Maaşlar"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();
        }
    }
}
