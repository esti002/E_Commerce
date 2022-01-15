using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace E_Ticaret_Proje_Web_Kismi
{
    public partial class kayitOl : System.Web.UI.Page
    {
        SQLBaglanti connection = new SQLBaglanti();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checker() == false)
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

                    Label5.Text = "KAIT BASARILI";
                    Label5.BackColor = Color.LightGreen;
                    Label5.Visible = true;

                }
                else
                {
                    Label5.Text = "LUTFEN ALANDAKI TUM BOSLUKLARI DOLDURUN";
                    Label5.BackColor = Color.Aqua;
                    Label5.Visible = true;
                }
            }
            else
            {
                Label5.Text = "BU MAIL ILE ZATEN KAYIT OLUNMUS";
                Label5.BackColor = Color.Red;
                Label5.Visible = true;
            }
        }
        private bool checker()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CustomersTable WHERE Mail=@mail", connection.baglanti());

            command.Parameters.AddWithValue("@mail", TextBox3.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.NewRow();

            connection.baglanti().Close();

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;

        }
    }
}