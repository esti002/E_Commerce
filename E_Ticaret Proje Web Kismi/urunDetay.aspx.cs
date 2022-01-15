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
            connection.baglanti().Close();

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checker() == true)
            {
                Label14.Visible = false;

                //bu kisim calisiyor ancak asagidakini tekrar dene calisirsa githuba oyle yukle
                int customerId = -1;

                SqlCommand checkId = new SqlCommand("SELECT * FROM CustomersTable WHERE Mail=@mail AND Password=@password", connection.baglanti());

                checkId.Parameters.AddWithValue("@mail", TextBox1.Text);
                checkId.Parameters.AddWithValue("@password", TextBox2.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(checkId);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                customerId = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                connection.baglanti().Close();

                if (customerId > 0)
                {
                    SqlCommand saveReview = new SqlCommand("INSERT INTO ReviewsTable(Reviwer_ID,Product_ID,Review) " +
                        "VALUES(@ReviewerId,@ProductId,@Review)", connection.baglanti());

                    saveReview.Parameters.AddWithValue("@ReviewerId", customerId);
                    saveReview.Parameters.AddWithValue("@ProductId", productId);
                    saveReview.Parameters.AddWithValue("@Review", TextBox3.Text);

                    saveReview.ExecuteNonQuery();
                    connection.baglanti().Close();
                }
            }
            else
            {
                Label14.Visible = true;
            }


            //bu kisim calismiyor istersen gozden gecir istersen burayi bosver musteri bilgilerini
            //ayri kontrol ettirip ardindan yorumlar tablosuna atama yap
            /*SqlCommand saveReview = new SqlCommand(@"dbo.[saveReview]", connection.baglanti());

            SqlParameter p_mail = new SqlParameter();
            p_mail.ParameterName = "@p_mail";
            p_mail.SqlDbType = SqlDbType.NVarChar;
            p_mail.Value = TextBox1.Text;
            saveReview.Parameters.Add(p_mail);

            SqlParameter p_password = new SqlParameter();
            p_password.ParameterName = "@p_password";
            p_password.SqlDbType = SqlDbType.NVarChar;
            p_password.Value = TextBox2.Text;
            saveReview.Parameters.Add(p_password);

            SqlParameter p_review = new SqlParameter();
            p_review.ParameterName = "@p_review";
            p_review.SqlDbType = SqlDbType.NVarChar;
            p_review.Value = TextBox3.Text;
            saveReview.Parameters.Add(p_review);

            SqlParameter p_productId = new SqlParameter();
            p_productId.ParameterName = "@p_productId";
            p_productId.SqlDbType = SqlDbType.Int;
            p_productId.Value = productId;
            saveReview.Parameters.Add(p_productId);

            saveReview.CommandType = CommandType.StoredProcedure;

            saveReview.ExecuteNonQuery();

            connection.baglanti().Close();*/

        }
        private bool checker()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CustomersTable WHERE Mail=@mail AND Password=@password", connection.baglanti());

            command.Parameters.AddWithValue("@mail", TextBox1.Text);
            command.Parameters.AddWithValue("@password", TextBox2.Text);

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