﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneYönetimOtomasyon
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=UMUT-PC;Initial Catalog=HastaneOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }  
}
