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
    public partial class productForm : Form
    {
        AccessingDB access = new AccessingDB();
        int buttonMemory = 0;
        public productForm()
        {
            InitializeComponent();
        }

        private void productForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shoppingDataSet10.ProductsTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.productsTableTableAdapter2.Fill(this.shoppingDataSet10.ProductsTable);
            if (buttonMemory != 0)
            {
                idTB.Text = productsDGW.Rows[0].Cells[0].Value.ToString();
            }
            nameTB.Text = productsDGW.Rows[0].Cells[1].Value.ToString();
            priceTB.Text = productsDGW.Rows[0].Cells[3].Value.ToString();
            CategoriesCB.Text = productsDGW.Rows[0].Cells[5].Value.ToString();
            propertiesTB.Text = productsDGW.Rows[0].Cells[2].Value.ToString();


            paintButton(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonMemory == 0)
            {
                access.addProduct(nameTB.Text, propertiesTB.Text,System.Convert.ToInt32(priceTB.Text),
                    System.Convert.ToInt32(CategoriesCB.Text), System.Convert.ToInt32(adminID.Text),imgAdress.Text);
                MessageBox.Show("Product added.");
                this.productsTableTableAdapter2.Fill(this.shoppingDataSet10.ProductsTable);
            }
            if (buttonMemory == 1)
            {
                access.updateProduct(nameTB.Text, propertiesTB.Text, System.Convert.ToInt32(priceTB.Text),
                    System.Convert.ToInt32(CategoriesCB.Text), System.Convert.ToInt32(idTB.Text),imgAdress.Text);
                MessageBox.Show("Product updated.");
                this.productsTableTableAdapter2.Fill(this.shoppingDataSet10.ProductsTable);
            }
            if (buttonMemory == 2)
            {
                access.deleteProduct(System.Convert.ToInt32(idTB.Text));
                MessageBox.Show("Product deleted.");
                this.productsTableTableAdapter2.Fill(this.shoppingDataSet10.ProductsTable);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paintButton(0);
            idTB.Text = "";
            processButton.Text = "ADD PRODUCT";
            processButton.BackColor = Color.ForestGreen;
        }

        private void updateTab_Click(object sender, EventArgs e)
        {
            paintButton(1);
            processButton.Text = "UPDATE PRODUCT";
            processButton.BackColor = Color.PeachPuff;
        }

        private void deleteTab_Click(object sender, EventArgs e)
        {
            paintButton(2);
            processButton.Text = "DELETE PRODUCT";
            processButton.BackColor = Color.Firebrick;
        }

        private void paintButton(int buttonNo)
        {
            rePaintButton(buttonMemory);
            buttonMemory = buttonNo;

            switch (buttonNo)
            {
                case 0:
                    addTab.BackColor = Color.ForestGreen;
                    break;
                case 1:
                    updateTab.BackColor = Color.PeachPuff;
                    break;
                case 2:
                    deleteTab.BackColor = Color.Firebrick;
                    break;
            }
        }

        private void rePaintButton(int buttonNo)
        {
            switch (buttonNo)
            {
                case 0:
                    addTab.BackColor = Color.White;
                    break;
                case 1:
                    updateTab.BackColor = Color.White;
                    break;
                case 2:
                    deleteTab.BackColor = Color.White;
                    break;
            }
        }

        private void productsDGW_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (buttonMemory != 0)
            {
                idTB.Text = productsDGW.CurrentRow.Cells[0].Value.ToString();
            }
            nameTB.Text = productsDGW.CurrentRow.Cells[1].Value.ToString();
            priceTB.Text = productsDGW.CurrentRow.Cells[3].Value.ToString();
            CategoriesCB.Text = productsDGW.CurrentRow.Cells[5].Value.ToString();
            propertiesTB.Text = productsDGW.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
