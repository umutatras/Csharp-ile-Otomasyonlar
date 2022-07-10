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

namespace Okulproje
{
    public partial class ögrencinotları : Form
    {
        public ögrencinotları()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=UMUT-PC;Initial Catalog=okul;Integrated Security=True");
        public string numara;
        private void ögrencinotları_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select dersad,sınav1,sınav2,sınav3,ortalama,durum from notlar INNER JOIN ders ON notlar.dersid=ders.dersid where ogrid=@o1",baglanti);
            komut.Parameters.AddWithValue("@o1", numara);
            this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
