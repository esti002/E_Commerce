using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace E_Ticaret_Proje_Web_Kismi
{
    public class SQLBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Shopping;integrated security=true");
            connection.Open();
            return connection;
        }
    }
}