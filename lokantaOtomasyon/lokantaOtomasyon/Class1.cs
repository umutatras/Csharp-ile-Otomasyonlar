using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lokantaOtomasyon
{
    class sql
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=UMUT-PC;Initial Catalog=lokantaOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;

        }     
    }
}
