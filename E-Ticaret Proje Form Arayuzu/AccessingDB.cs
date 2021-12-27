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

        //sistemin ilk acilirken admin kimlik dogrulamasi
        public bool loginCheck(string mail, string password)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM AdminTable WHERE mail = @mail AND Password =@password",_connection);

            command.Parameters.AddWithValue("@mail",mail);
            command.Parameters.AddWithValue("@password", password);

            bool a =  command.ExecuteScalar() != null;

            _connection.Close();

            return a;
        }

        //bir musterinin verilerini gunceller
        public void updateCustomerData(int customerID,string name,string surname,string mail,bool banned)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("UPDATE CustomersTable SET Name = @name,Surname = @surname" +
                ",Mail = @mail, Banned = @banned WHERE CustomerID = @customerID",_connection);

            command.Parameters.AddWithValue("@customerID", customerID);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@mail", mail);
            if (banned == true)
            {
                command.Parameters.AddWithValue("@banned", 1);
            }
            else
            {
                command.Parameters.AddWithValue("@banned", 0);
            }

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void addProduct(string name,string properties,int price,int categoryID,int adderID)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("INSERT INTO ProductsTable(Name,Properties,Price,Category_ID,Adder_ID) " +
                "VALUES(@name,@properties,@price,@categoryID,@adderID)",_connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@properties", properties);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            command.Parameters.AddWithValue("@adderID", adderID);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void updateProduct(string name,string properties,int price,int categoryID,int productId)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("UPDATE ProductsTable SET Name = @name,Properties = @properties,Price =@price," +
                "Category_ID=@categoryID WHERE Product_ID=@productID", _connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@properties", properties);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            command.Parameters.AddWithValue("@productID", productId);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void deleteProduct(int productID)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("DELETE FROM ProductsTable WHERE Product_ID = @productID", _connection);

            command.Parameters.AddWithValue("@productID", productID);

            command.ExecuteNonQuery();

            _connection.Close();
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
