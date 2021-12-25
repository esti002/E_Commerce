namespace E_Ticaret_Proje_Form_Arayuzu
{
    partial class productForm
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
            this.productsDGW = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet4 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet4();
            this.productsTableTableAdapter = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet4TableAdapters.ProductsTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDGW
            // 
            this.productsDGW.AutoGenerateColumns = false;
            this.productsDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.propertiesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.addDateDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.adderIDDataGridViewTextBoxColumn});
            this.productsDGW.DataSource = this.productsTableBindingSource;
            this.productsDGW.Location = new System.Drawing.Point(0, 0);
            this.productsDGW.Name = "productsDGW";
            this.productsDGW.RowHeadersWidth = 51;
            this.productsDGW.RowTemplate.Height = 24;
            this.productsDGW.Size = new System.Drawing.Size(1261, 191);
            this.productsDGW.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // propertiesDataGridViewTextBoxColumn
            // 
            this.propertiesDataGridViewTextBoxColumn.DataPropertyName = "Properties";
            this.propertiesDataGridViewTextBoxColumn.HeaderText = "Properties";
            this.propertiesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propertiesDataGridViewTextBoxColumn.Name = "propertiesDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // addDateDataGridViewTextBoxColumn
            // 
            this.addDateDataGridViewTextBoxColumn.DataPropertyName = "Add Date";
            this.addDateDataGridViewTextBoxColumn.HeaderText = "Add Date";
            this.addDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addDateDataGridViewTextBoxColumn.Name = "addDateDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category ID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category ID";
            this.categoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // adderIDDataGridViewTextBoxColumn
            // 
            this.adderIDDataGridViewTextBoxColumn.DataPropertyName = "Adder ID";
            this.adderIDDataGridViewTextBoxColumn.HeaderText = "Adder ID";
            this.adderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adderIDDataGridViewTextBoxColumn.Name = "adderIDDataGridViewTextBoxColumn";
            // 
            // productsTableBindingSource
            // 
            this.productsTableBindingSource.DataMember = "ProductsTable";
            this.productsTableBindingSource.DataSource = this.shoppingDataSet4;
            // 
            // shoppingDataSet4
            // 
            this.shoppingDataSet4.DataSetName = "ShoppingDataSet4";
            this.shoppingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableTableAdapter
            // 
            this.productsTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD PRODUCT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "UPDATE PRODUCT";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "DELETE PRODUCT";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 535);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productsDGW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "productForm";
            this.Text = "PRODUCT OPERATIONS";
            this.Load += new System.EventHandler(this.productForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDGW;
        private ShoppingDataSet4 shoppingDataSet4;
        private System.Windows.Forms.BindingSource productsTableBindingSource;
        private ShoppingDataSet4TableAdapters.ProductsTableTableAdapter productsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}