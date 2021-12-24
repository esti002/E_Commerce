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
    public partial class Form_Customers : Form
    {
        public Form_Customers()
        {
            InitializeComponent();
        }

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shoppingDataSet2.CustomersTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.customersTableTableAdapter2.Fill(this.shoppingDataSet2.CustomersTable);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            checkBox1.Checked = System.Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value);
        }
    }
}
