using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _KuryeOtomasyon
{
    class veritabani
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=abdullah;Initial Catalog=KuryeOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }     
    }
}
