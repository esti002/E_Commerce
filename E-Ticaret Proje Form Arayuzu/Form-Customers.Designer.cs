namespace E_Ticaret_Proje_Form_Arayuzu
{
    partial class Form_Customers
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
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameNchar20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bannedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customersTableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet2 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet2();
            this.customersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet();
            this.customersTableTableAdapter = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSetTableAdapters.CustomersTableTableAdapter();
            this.shoppingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet1 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet1();
            this.customersTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableTableAdapter1 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet1TableAdapters.CustomersTableTableAdapter();
            this.shoppingDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableTableAdapter2 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet2TableAdapters.CustomersTableTableAdapter();
            this.shoppingDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet2BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.nameNchar20DataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.recordDateDataGridViewTextBoxColumn,
            this.bannedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.customersTableBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "Customer Id";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Customer Id";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameNchar20DataGridViewTextBoxColumn
            // 
            this.nameNchar20DataGridViewTextBoxColumn.DataPropertyName = "Name nchar(20)";
            this.nameNchar20DataGridViewTextBoxColumn.HeaderText = "Name nchar(20)";
            this.nameNchar20DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameNchar20DataGridViewTextBoxColumn.Name = "nameNchar20DataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // recordDateDataGridViewTextBoxColumn
            // 
            this.recordDateDataGridViewTextBoxColumn.DataPropertyName = "Record Date";
            this.recordDateDataGridViewTextBoxColumn.HeaderText = "Record Date";
            this.recordDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recordDateDataGridViewTextBoxColumn.Name = "recordDateDataGridViewTextBoxColumn";
            // 
            // bannedDataGridViewCheckBoxColumn
            // 
            this.bannedDataGridViewCheckBoxColumn.DataPropertyName = "Banned";
            this.bannedDataGridViewCheckBoxColumn.HeaderText = "Banned";
            this.bannedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.bannedDataGridViewCheckBoxColumn.Name = "bannedDataGridViewCheckBoxColumn";
            // 
            // customersTableBindingSource4
            // 
            this.customersTableBindingSource4.DataMember = "CustomersTable";
            this.customersTableBindingSource4.DataSource = this.shoppingDataSet2;
            // 
            // shoppingDataSet2
            // 
            this.shoppingDataSet2.DataSetName = "ShoppingDataSet2";
            this.shoppingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableBindingSource
            // 
            this.customersTableBindingSource.DataMember = "CustomersTable";
            this.customersTableBindingSource.DataSource = this.shoppingDataSet;
            // 
            // shoppingDataSet
            // 
            this.shoppingDataSet.DataSetName = "ShoppingDataSet";
            this.shoppingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableTableAdapter
            // 
            this.customersTableTableAdapter.ClearBeforeFill = true;
            // 
            // shoppingDataSetBindingSource
            // 
            this.shoppingDataSetBindingSource.DataSource = this.shoppingDataSet;
            this.shoppingDataSetBindingSource.Position = 0;
            // 
            // customersTableBindingSource1
            // 
            this.customersTableBindingSource1.DataMember = "CustomersTable";
            this.customersTableBindingSource1.DataSource = this.shoppingDataSetBindingSource;
            // 
            // shoppingDataSet1
            // 
            this.shoppingDataSet1.DataSetName = "ShoppingDataSet1";
            this.shoppingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableBindingSource2
            // 
            this.customersTableBindingSource2.DataMember = "CustomersTable";
            this.customersTableBindingSource2.DataSource = this.shoppingDataSet1;
            // 
            // customersTableTableAdapter1
            // 
            this.customersTableTableAdapter1.ClearBeforeFill = true;
            // 
            // shoppingDataSet1BindingSource
            // 
            this.shoppingDataSet1BindingSource.DataSource = this.shoppingDataSet1;
            this.shoppingDataSet1BindingSource.Position = 0;
            // 
            // customersTableBindingSource3
            // 
            this.customersTableBindingSource3.DataMember = "CustomersTable";
            this.customersTableBindingSource3.DataSource = this.shoppingDataSetBindingSource;
            // 
            // customersTableTableAdapter2
            // 
            this.customersTableTableAdapter2.ClearBeforeFill = true;
            // 
            // shoppingDataSet2BindingSource
            // 
            this.shoppingDataSet2BindingSource.DataSource = this.shoppingDataSet2;
            this.shoppingDataSet2BindingSource.Position = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(220, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CUSTOMER ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(28, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 239);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UPDATE DATA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "BANNED :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(220, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(52, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "MAIL :";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(220, 135);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SURNAME :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(220, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "NAME :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(220, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(378, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update User Data";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(378, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 68);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete User ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Customers";
            this.Text = "Form_Customers";
            this.Load += new System.EventHandler(this.Form_Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet2BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customersTableBindingSource;
        private System.Windows.Forms.BindingSource shoppingDataSetBindingSource;
        private System.Windows.Forms.BindingSource customersTableBindingSource1;
        private System.Windows.Forms.BindingSource customersTableBindingSource2;
        private System.Windows.Forms.BindingSource customersTableBindingSource3;
        private System.Windows.Forms.BindingSource shoppingDataSet1BindingSource;
        private System.Windows.Forms.BindingSource customersTableBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNchar20DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bannedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource shoppingDataSet2BindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}