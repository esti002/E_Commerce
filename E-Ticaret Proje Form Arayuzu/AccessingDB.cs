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
        public bool loginCheck(string mail, string password, ref int adminID)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT Admin_ID FROM AdminTable WHERE mail = @mail AND Password =@password",_connection);

            command.Parameters.AddWithValue("@mail",mail);
            command.Parameters.AddWithValue("@password", password);

            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                adminID =System.Convert.ToInt32(dr["Admin_ID"]);
            }

            dr.Close();

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

        public void addProduct(string name,string properties,int price,int categoryID,int adderID,string imgAdress)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("INSERT INTO ProductsTable(Name,Properties,Price,Category_ID,Adder_ID,Img) " +
                "VALUES(@name,@properties,@price,@categoryID,@adderID,@imgAdress)",_connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@properties", properties);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            command.Parameters.AddWithValue("@adderID", adderID);
            command.Parameters.AddWithValue("@imgAdress", imgAdress);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void updateProduct(string name,string properties,int price,int categoryID,int productId, string imgAdress)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("UPDATE ProductsTable SET Name = @name,Properties = @properties,Price =@price," +
                "Category_ID=@categoryID,Img=@imgAdress WHERE Product_ID=@productID", _connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@properties", properties);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            command.Parameters.AddWithValue("@productID", productId);
            command.Parameters.AddWithValue("@imgAdress", imgAdress);

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

        public void updateReviews(int reviewID, string review,bool confirmed)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("UPDATE ReviewsTable SET " +
                "Review = @review, Confirmed = @confirmed WHERE Review_ID= @reviewID", _connection);

            command.Parameters.AddWithValue("@review", review);
            command.Parameters.AddWithValue("@confirmed", confirmed);
            command.Parameters.AddWithValue("@reviewID", reviewID); 

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void addNewAdmin(string name,string surname,string mail,string password,string phoneNumber)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("INSERT INTO AdminTable(Name,Surname,Mail,Password,Phone_Number)" +
                "VALUES(@name,@surname,@mail,@password,@phoneNumber)", _connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

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
