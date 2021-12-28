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
        shopRegistrations shopRegistration = new shopRegistrations();
        n adminManagers = new n();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customers.adminID.Text = this.adminID.Text;
            customers.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prducts.adminID.Text = this.adminID.Text;
            prducts.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reviews.adminID.Text = this.adminID.Text;
            reviews.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shopRegistration.adminID.Text = this.adminID.Text;
            shopRegistration.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminManagers.adminID.Text = this.adminID.Text;
            adminManagers.ShowDialog();
        }
    }
}
