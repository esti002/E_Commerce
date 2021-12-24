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
        public customerForm()
        {
            InitializeComponent();
        }

        private void customerForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shoppingDataSet.CustomersTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.customersTableTableAdapter.Fill(this.shoppingDataSet.CustomersTable);

        }


        private void customerDGW_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
