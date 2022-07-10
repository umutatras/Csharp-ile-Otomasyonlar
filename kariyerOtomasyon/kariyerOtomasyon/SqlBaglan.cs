using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kariyerOtomasyon
{
    class SqlBaglan
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=UMUT-PC;Initial Catalog=KariyerOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
