using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Proje_Form_Arayuzu
{
    internal class AccessingDB
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Shopping;integrated security=true");

        public bool loginCheck(string mail, string password)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT Mail FROM AdminTable WHERE mail = @mail AND Password =@password",_connection);

            command.Parameters.AddWithValue("@mail",mail);
            command.Parameters.AddWithValue("@password", password);

            bool a =  command.ExecuteScalar() != null;

            _connection.Close();

            return a;

        }



        private void ConnectionControl()
        {
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }


    }
}
