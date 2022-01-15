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
    public partial class alisverisKaydi : System.Web.UI.Page
    {
        SQLBaglanti connection = new SQLBaglanti();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checker() == true)
            {
                Label3.Visible = false;
                //bu komut ile databasede olusturdugum shopRegisterGB'dan verileri cekip kullan.
                SqlCommand command = new SqlCommand(@"dbo.[shopRegisterDB]", connection.baglanti());

                SqlParameter p_mail = new SqlParameter();
                p_mail.ParameterName = "@p_mail";
                p_mail.Value = TextBox1.Text;

                SqlParameter p_password = new SqlParameter();
                p_password.ParameterName = "@p_password";
                p_password.Value = TextBox2.Text;

                command.Parameters.Add(p_mail);
                command.Parameters.Add(p_password);

                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader revReader = command.ExecuteReader();

                DataList1.DataSource = revReader;
                DataList1.DataBind();
                connection.baglanti().Close();
            }
            else
            {
                Label3.Text = "MAIL YA DA SIFRENIZ HATALI";
                Label3.BackColor = Color.Red;
                Label3.Visible = true;
            }


            /*
            //bu kisim alisveris kaydi bilgilerini getirirken kullanilacak
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
                SqlCommand command = new SqlCommand("SELECT Product_ID,Date FROM ShopRegister WHERE Customer_ID=@customerId",connection.baglanti());

                command.Parameters.AddWithValue("@customerId", customerId);

                SqlDataReader reader = command.ExecuteReader();
                DataList1.DataSource = reader;
                DataList1.DataBind();

                connection.baglanti().Close();
            }
            */
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