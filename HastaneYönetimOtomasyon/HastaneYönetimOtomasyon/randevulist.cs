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

namespace HastaneYönetimOtomasyon
{
    public partial class randevulist : Form
    {
        public randevulist()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
        private void randevulist_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from randevu_tablo", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
    }
}
