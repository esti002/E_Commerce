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
    public partial class Form2 : Form
    {
        customerForm customers = new customerForm();
        productForm prducts = new productForm();
        reviwForm reviews = new reviwForm();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           customers.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prducts.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reviews.ShowDialog();
        }
    }
}
