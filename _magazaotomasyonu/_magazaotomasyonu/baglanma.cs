using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _magazaotomasyonu
{
    class baglanma
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=ikram/desktop-PC;Initial Catalog=magazaOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
