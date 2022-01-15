using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace E_Ticaret_Proje_Web_Kismi
{
    public partial class anaSayfa : System.Web.UI.Page
    {
        SQLBaglanti connection = new SQLBaglanti();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ProductsTable", connection.baglanti());

            SqlDataReader reader = command.ExecuteReader();

            DataList1.DataSource = reader;

            DataList1.DataBind();

            connection.baglanti().Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ProductsTable WHERE Category_ID=@categoryId AND Price BETWEEN @priceMin AND @priceMax", connection.baglanti());

            if(TextBox1.Text==""&& TextBox2.Text == "")
            {
                TextBox1.Text = "0";
                TextBox2.Text = "99999999";
            }

            command.Parameters.AddWithValue("@priceMin", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@priceMax", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@categoryId", Convert.ToInt32(DropDownList1.SelectedItem.Value));

            SqlDataReader reader = command.ExecuteReader();

            DataList1.DataSource = reader;

            DataList1.DataBind();

            connection.baglanti().Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ProductsTable WHERE (Name LIKE '%' + @search + '%')", connection.baglanti());

            command.Parameters.AddWithValue("@search", TextBox3.Text);

            SqlDataReader reader = command.ExecuteReader();

            DataList1.DataSource = reader;

            DataList1.DataBind();

            connection.baglanti().Close();
        }

    }
}