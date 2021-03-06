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
    public partial class reviwForm : Form
    {
        AccessingDB access = new AccessingDB();

        public reviwForm()
        {
            InitializeComponent();
        }

        private void reviwForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shoppingDataSet19.ReviewsTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.reviewsTableTableAdapter3.Fill(this.shoppingDataSet19.ReviewsTable);

            idTB.Text = reviewDGW.Rows[0].Cells[0].Value.ToString();
            reviewTB.Text = reviewDGW.Rows[0].Cells[4].Value.ToString();
            confirmedCB.Checked = System.Convert.ToBoolean(reviewDGW.Rows[0].Cells[5].Value);
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            access.updateReviews
                (
                System.Convert.ToInt32(idTB.Text),
                reviewTB.Text,
                confirmedCB.Checked
                );

            MessageBox.Show("CHANGES SAVED");
            this.reviewsTableTableAdapter2.Fill(this.shoppingDataSet18.ReviewsTable);
        }

        private void reviewDGW_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            idTB.Text = reviewDGW.CurrentRow.Cells[0].Value.ToString();
            reviewTB.Text = reviewDGW.CurrentRow.Cells[4].Value.ToString();
            confirmedCB.Checked = System.Convert.ToBoolean(reviewDGW.CurrentRow.Cells[5].Value);
        }
    }
}