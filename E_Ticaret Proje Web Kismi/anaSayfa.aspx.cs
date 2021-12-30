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
    }
}