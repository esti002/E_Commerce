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
    public partial class n : Form
    {
        AccessingDB access = new AccessingDB();

        public n()
        {
            InitializeComponent();
        }

        private void adminManager_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shoppingDataSet17.AdminTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableTableAdapter2.Fill(this.shoppingDataSet17.AdminTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            access.addNewAdmin
                (
                nameTB.Text,
                surnameTB.Text,
                mailTB.Text,
                passwordTB.Text,
                phoneTB.Text
                );

            MessageBox.Show("ADMIN ADDED.");
        }
    }
}
