using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret_Proje_Form_Arayuzu
{
    public partial class customerForm : Form
    {
        AccessingDB access = new AccessingDB();

        public customerForm()
        {
            InitializeComponent();
        }

        private void customerForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shoppingDataSet3.CustomersTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.customersTableTableAdapter3.Fill(this.shoppingDataSet3.CustomersTable);

            idTB.Text = customerDGW.Rows[0].Cells[0].Value.ToString();
            nameTB.Text = customerDGW.Rows[0].Cells[1].Value.ToString();
            surnameTB.Text = customerDGW.Rows[0].Cells[2].Value.ToString();
            mailTB.Text = customerDGW.Rows[0].Cells[3].Value.ToString();
            recordDateTB.Text = customerDGW.Rows[0].Cells[4].Value.ToString();
            bannedCB.Checked = System.Convert.ToBoolean(customerDGW.Rows[0].Cells[5].Value);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            access.updateCustomerData(System.Convert.ToInt32(idTB.Text), nameTB.Text, surnameTB.Text, mailTB.Text,
                System.Convert.ToBoolean(bannedCB.Checked)); 
            this.customersTableTableAdapter3.Fill(this.shoppingDataSet3.CustomersTable);
        }

        private void customerDGW_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            idTB.Text = customerDGW.CurrentRow.Cells[0].Value.ToString();
            nameTB.Text = customerDGW.CurrentRow.Cells[1].Value.ToString();
            surnameTB.Text = customerDGW.CurrentRow.Cells[2].Value.ToString();
            mailTB.Text = customerDGW.CurrentRow.Cells[3].Value.ToString();
            recordDateTB.Text = customerDGW.CurrentRow.Cells[4].Value.ToString();
            bannedCB.Checked = System.Convert.ToBoolean(customerDGW.CurrentRow.Cells[5].Value);
        }
    }
}
