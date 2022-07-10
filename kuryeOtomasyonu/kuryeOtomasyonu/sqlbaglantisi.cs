using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace kuryeOtomasyonu
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=UMUT-PC;Initial Catalog=kuryeOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;

        }     
            
       }
    }

