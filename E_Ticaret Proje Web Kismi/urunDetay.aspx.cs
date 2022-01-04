using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace E_Ticaret_Proje_Web_Kismi
{
    public partial class urunDetay : System.Web.UI.Page
    {
        SQLBaglanti connection = new SQLBaglanti();

        string productId = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            productId = Request.QueryString["productId"];

            SqlCommand command1 = new SqlCommand("SELECT * FROM ProductsTable WHERE Product_ID=@parameter1", connection.baglanti());

            command1.Parameters.AddWithValue("@parameter1", productId);

            SqlDataReader reader1 = command1.ExecuteReader();

            DataList1.DataSource = reader1;

            DataList1.DataBind();
            /*
            SqlCommand command2 = new SqlCommand("SELECT * FROM ReviewsTable WHERE Product_ID=@parameter2 AND Confirmed=1",connection.baglanti());

            command2.Parameters.AddWithValue("@parameter2", productId);

            SqlDataReader reader2 = command2.ExecuteReader();

            DataList3.DataSource = reader2;

            DataList3.DataBind();

            connection.baglanti().Close();*/

            SqlCommand reviewCom = new SqlCommand(@"dbo.[ReviewDB]", connection.baglanti());

            SqlParameter p_productId = new SqlParameter();
            p_productId.ParameterName = "@p_reviewId";
            p_productId.SqlDbType = SqlDbType.Int;
            p_productId.Value = productId;

            reviewCom.Parameters.Add(p_productId);

            reviewCom.CommandType = CommandType.StoredProcedure;

            SqlDataReader revReader = reviewCom.ExecuteReader();

            DataList3.DataSource = revReader;

            DataList3.DataBind();

            connection.baglanti().Close();
        }
    }
}