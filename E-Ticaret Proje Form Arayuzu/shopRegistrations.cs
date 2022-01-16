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
    public partial class shopRegistrations : Form
    {
        public shopRegistrations()
        {
            InitializeComponent();
        }

        private void shopRegistrations_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'shoppingDataSet22.ReviewInfos' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.reviewInfosTableAdapter1.Fill(this.shoppingDataSet22.ReviewInfos);

        }
    }
}
