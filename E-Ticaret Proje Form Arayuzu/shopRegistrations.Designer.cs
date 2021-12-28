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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shoppingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reachedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shopRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet14 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet14();
            this.shopRegisterTableAdapter = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet14TableAdapters.ShopRegisterTableAdapter();
            this.adminID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shoppingIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.reachedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.shopRegisterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // shoppingIDDataGridViewTextBoxColumn
            // 
            this.shoppingIDDataGridViewTextBoxColumn.DataPropertyName = "Shopping ID";
            this.shoppingIDDataGridViewTextBoxColumn.HeaderText = "Shopping ID";
            this.shoppingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shoppingIDDataGridViewTextBoxColumn.Name = "shoppingIDDataGridViewTextBoxColumn";
            this.shoppingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // reachedDataGridViewCheckBoxColumn
            // 
            this.reachedDataGridViewCheckBoxColumn.DataPropertyName = "Reached";
            this.reachedDataGridViewCheckBoxColumn.HeaderText = "Reached";
            this.reachedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.reachedDataGridViewCheckBoxColumn.Name = "reachedDataGridViewCheckBoxColumn";
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
            // shopRegistrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1100, 361);
            this.Controls.Add(this.adminID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "shopRegistrations";
            this.Text = "shopRegistrations";
            this.Load += new System.EventHandler(this.shopRegistrations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ShoppingDataSet14 shoppingDataSet14;
        private System.Windows.Forms.BindingSource shopRegisterBindingSource;
        private ShoppingDataSet14TableAdapters.ShopRegisterTableAdapter shopRegisterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reachedDataGridViewCheckBoxColumn;
        public System.Windows.Forms.Label adminID;
        private System.Windows.Forms.Label label5;
    }
}