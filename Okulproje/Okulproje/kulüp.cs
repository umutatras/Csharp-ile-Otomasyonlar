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
    public partial class kulüp : Form
    {
        public kulüp()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=UMUT-PC;Initial Catalog=okul;Integrated Security=True");

        private void kulüp_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from kulupler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
