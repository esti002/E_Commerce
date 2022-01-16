namespace E_Ticaret_Proje_Form_Arayuzu
{
    partial class shopRegistrations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.shopRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet14 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet14();
            this.shopRegisterTableAdapter = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet14TableAdapters.ShopRegisterTableAdapter();
            this.adminID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reviewInfosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet21 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet21();
            this.shoppingDataSet20 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet20();
            this.reviewInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewInfosTableAdapter = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet21TableAdapters.ReviewInfosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shoppingDataSet22 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet22();
            this.reviewInfosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reviewInfosTableAdapter1 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet22TableAdapters.ReviewInfosTableAdapter();
            this.reviewIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shopRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewInfosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewInfosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewInfosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // shopRegisterBindingSource
            // 
            this.shopRegisterBindingSource.DataMember = "ShopRegister";
            this.shopRegisterBindingSource.DataSource = this.shoppingDataSet14;
            // 
            // shoppingDataSet14
            // 
            this.shoppingDataSet14.DataSetName = "ShoppingDataSet14";
            this.shoppingDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopRegisterTableAdapter
            // 
            this.shopRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // adminID
            // 
            this.adminID.AutoSize = true;
            this.adminID.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold);
            this.adminID.Location = new System.Drawing.Point(164, 330);
            this.adminID.Name = "adminID";
            this.adminID.Size = new System.Drawing.Size(27, 22);
            this.adminID.TabIndex = 13;
            this.adminID.Text = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "MANAGER ID :";
            // 
            // reviewInfosBindingSource1
            // 
            this.reviewInfosBindingSource1.DataMember = "ReviewInfos";
            this.reviewInfosBindingSource1.DataSource = this.shoppingDataSet21;
            // 
            // shoppingDataSet21
            // 
            this.shoppingDataSet21.DataSetName = "ShoppingDataSet21";
            this.shoppingDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppingDataSet20
            // 
            this.shoppingDataSet20.DataSetName = "ShoppingDataSet20";
            this.shoppingDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewInfosBindingSource
            // 
            this.reviewInfosBindingSource.DataMember = "ReviewInfos";
            this.reviewInfosBindingSource.DataSource = this.shoppingDataSet20;
            // 
            // reviewInfosTableAdapter
            // 
            this.reviewInfosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reviewIDDataGridViewTextBoxColumn,
            this.reviewerDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.reviewDateDataGridViewTextBoxColumn,
            this.reviewDataGridViewTextBoxColumn,
            this.confirmedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.reviewInfosBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 304);
            this.dataGridView1.TabIndex = 14;
            // 
            // shoppingDataSet22
            // 
            this.shoppingDataSet22.DataSetName = "ShoppingDataSet22";
            this.shoppingDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewInfosBindingSource2
            // 
            this.reviewInfosBindingSource2.DataMember = "ReviewInfos";
            this.reviewInfosBindingSource2.DataSource = this.shoppingDataSet22;
            // 
            // reviewInfosTableAdapter1
            // 
            this.reviewInfosTableAdapter1.ClearBeforeFill = true;
            // 
            // reviewIDDataGridViewTextBoxColumn
            // 
            this.reviewIDDataGridViewTextBoxColumn.DataPropertyName = "Review_ID";
            this.reviewIDDataGridViewTextBoxColumn.HeaderText = "Review_ID";
            this.reviewIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewIDDataGridViewTextBoxColumn.Name = "reviewIDDataGridViewTextBoxColumn";
            this.reviewIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reviewerDataGridViewTextBoxColumn
            // 
            this.reviewerDataGridViewTextBoxColumn.DataPropertyName = "Reviewer";
            this.reviewerDataGridViewTextBoxColumn.HeaderText = "Reviewer";
            this.reviewerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewerDataGridViewTextBoxColumn.Name = "reviewerDataGridViewTextBoxColumn";
            this.reviewerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // reviewDateDataGridViewTextBoxColumn
            // 
            this.reviewDateDataGridViewTextBoxColumn.DataPropertyName = "Review_Date";
            this.reviewDateDataGridViewTextBoxColumn.HeaderText = "Review_Date";
            this.reviewDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewDateDataGridViewTextBoxColumn.Name = "reviewDateDataGridViewTextBoxColumn";
            // 
            // reviewDataGridViewTextBoxColumn
            // 
            this.reviewDataGridViewTextBoxColumn.DataPropertyName = "Review";
            this.reviewDataGridViewTextBoxColumn.HeaderText = "Review";
            this.reviewDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewDataGridViewTextBoxColumn.Name = "reviewDataGridViewTextBoxColumn";
            // 
            // confirmedDataGridViewCheckBoxColumn
            // 
            this.confirmedDataGridViewCheckBoxColumn.DataPropertyName = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.HeaderText = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.confirmedDataGridViewCheckBoxColumn.Name = "confirmedDataGridViewCheckBoxColumn";
            // 
            // shopRegistrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1100, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adminID);
            this.Controls.Add(this.label5);
            this.Name = "shopRegistrations";
            this.Text = "shopRegistrations";
            this.Load += new System.EventHandler(this.shopRegistrations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewInfosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewInfosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewInfosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ShoppingDataSet14 shoppingDataSet14;
        private System.Windows.Forms.BindingSource shopRegisterBindingSource;
        private ShoppingDataSet14TableAdapters.ShopRegisterTableAdapter shopRegisterTableAdapter;
        public System.Windows.Forms.Label adminID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource reviewInfosBindingSource;
        private ShoppingDataSet20 shoppingDataSet20;
        private ShoppingDataSet21 shoppingDataSet21;
        private System.Windows.Forms.BindingSource reviewInfosBindingSource1;
        private ShoppingDataSet21TableAdapters.ReviewInfosTableAdapter reviewInfosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ShoppingDataSet22 shoppingDataSet22;
        private System.Windows.Forms.BindingSource reviewInfosBindingSource2;
        private ShoppingDataSet22TableAdapters.ReviewInfosTableAdapter reviewInfosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmedDataGridViewCheckBoxColumn;
    }
}