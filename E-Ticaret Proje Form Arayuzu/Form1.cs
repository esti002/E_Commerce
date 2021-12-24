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
    public partial class Form1 : Form
    {
        AccessingDB access = new AccessingDB();
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (access.loginCheck(textBox1.Text, textBox2.Text)==true)
            {
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                label4.Visible = true;
            }
        }
    }
}
