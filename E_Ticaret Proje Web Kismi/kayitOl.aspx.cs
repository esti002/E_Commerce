using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace E_Ticaret_Proje_Web_Kismi
{
    public partial class kayitOl : System.Web.UI.Page
    {
        SQLBaglanti connection = new SQLBaglanti();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "")
            {
                SqlCommand command = new SqlCommand("INSERT INTO CustomersTable(Name,Surname,Mail,Password) VALUES(@name,@surname,@mail,@password)", connection.baglanti());

                command.Parameters.AddWithValue("@name", TextBox1.Text);
                command.Parameters.AddWithValue("@surname", TextBox2.Text);
                command.Parameters.AddWithValue("@mail", TextBox3.Text);
                command.Parameters.AddWithValue("@password", TextBox4.Text);

                command.ExecuteNonQuery();
                connection.baglanti().Close();

            }
        }
    }
}