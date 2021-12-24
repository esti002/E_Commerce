namespace E_Ticaret_Proje_Form_Arayuzu
{
    partial class customerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bannedCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recordDateTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerDGW = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameNchar20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bannedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet();
            this.customersTableTableAdapter = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSetTableAdapters.CustomersTableTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bannedCB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.recordDateTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mailTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.surnameTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(59, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUSTOMER DATA";
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idTB.Location = new System.Drawing.Point(175, 40);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(224, 22);
            this.idTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID :";
            // 
            // bannedCB
            // 
            this.bannedCB.AutoSize = true;
            this.bannedCB.Location = new System.Drawing.Point(175, 183);
            this.bannedCB.Name = "bannedCB";
            this.bannedCB.Size = new System.Drawing.Size(18, 17);
            this.bannedCB.TabIndex = 9;
            this.bannedCB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "BANNED :";
            // 
            // recordDateTB
            // 
            this.recordDateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recordDateTB.Location = new System.Drawing.Point(175, 152);
            this.recordDateTB.Name = "recordDateTB";
            this.recordDateTB.Size = new System.Drawing.Size(224, 22);
            this.recordDateTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "RECORD DATE :";
            // 
            // mailTB
            // 
            this.mailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailTB.Location = new System.Drawing.Point(175, 124);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(224, 22);
            this.mailTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "MAIL :";
            // 
            // surnameTB
            // 
            this.surnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTB.Location = new System.Drawing.Point(175, 96);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(224, 22);
            this.surnameTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SURNAME :";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTB.Location = new System.Drawing.Point(175, 68);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(224, 22);
            this.nameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME :";
            // 
            // customerDGW
            // 
            this.customerDGW.AutoGenerateColumns = false;
            this.customerDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.nameNchar20DataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.recordDateDataGridViewTextBoxColumn,
            this.bannedDataGridViewCheckBoxColumn});
            this.customerDGW.DataSource = this.customersTableBindingSource;
            this.customerDGW.Location = new System.Drawing.Point(21, 12);
            this.customerDGW.Name = "customerDGW";
            this.customerDGW.RowHeadersWidth = 51;
            this.customerDGW.RowTemplate.Height = 24;
            this.customerDGW.Size = new System.Drawing.Size(767, 150);
            this.customerDGW.TabIndex = 0;
            this.customerDGW.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDGW_CellMouseClick);
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
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerDGW);
            this.Controls.Add(this.groupBox1);
            this.Name = "customerForm";
            this.Text = "customerForm";
            this.Load += new System.EventHandler(this.customerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customerDGW;
        private System.Windows.Forms.CheckBox bannedCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox recordDateTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private ShoppingDataSet shoppingDataSet;
        private System.Windows.Forms.BindingSource customersTableBindingSource;
        private ShoppingDataSetTableAdapters.CustomersTableTableAdapter customersTableTableAdapter;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNchar20DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bannedDataGridViewCheckBoxColumn;
    }
}