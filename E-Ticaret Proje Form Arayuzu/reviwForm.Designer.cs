namespace E_Ticaret_Proje_Form_Arayuzu
{
    partial class reviwForm
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
            this.reviewsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet11 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet11();
            this.reviewsTableTableAdapter = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet11TableAdapters.ReviewsTableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processButton = new System.Windows.Forms.Button();
            this.confirmedCB = new System.Windows.Forms.CheckBox();
            this.reviewTB = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.reviewsTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet12 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet12();
            this.reviewsTableTableAdapter1 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet12TableAdapters.ReviewsTableTableAdapter();
            this.reviewsTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet18 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet18();
            this.adminID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reviewsTableTableAdapter2 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet18TableAdapters.ReviewsTableTableAdapter();
            this.reviewDGW = new System.Windows.Forms.DataGridView();
            this.reviewIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviwerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reviewsTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet19 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet19();
            this.reviewsTableTableAdapter3 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet19TableAdapters.ReviewsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewsTableBindingSource
            // 
            this.reviewsTableBindingSource.DataMember = "ReviewsTable";
            this.reviewsTableBindingSource.DataSource = this.shoppingDataSet11;
            // 
            // shoppingDataSet11
            // 
            this.shoppingDataSet11.DataSetName = "ShoppingDataSet11";
            this.shoppingDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewsTableTableAdapter
            // 
            this.reviewsTableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.processButton);
            this.groupBox1.Controls.Add(this.confirmedCB);
            this.groupBox1.Controls.Add(this.reviewTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.idTB);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Location = new System.Drawing.Point(31, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.BackColor = System.Drawing.Color.ForestGreen;
            this.processButton.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(848, 78);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(287, 69);
            this.processButton.TabIndex = 36;
            this.processButton.Text = "SAVE CHANGES";
            this.processButton.UseVisualStyleBackColor = false;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // confirmedCB
            // 
            this.confirmedCB.AutoSize = true;
            this.confirmedCB.Location = new System.Drawing.Point(153, 128);
            this.confirmedCB.Name = "confirmedCB";
            this.confirmedCB.Size = new System.Drawing.Size(18, 17);
            this.confirmedCB.TabIndex = 34;
            this.confirmedCB.UseVisualStyleBackColor = true;
            // 
            // reviewTB
            // 
            this.reviewTB.Location = new System.Drawing.Point(380, 43);
            this.reviewTB.Name = "reviewTB";
            this.reviewTB.Size = new System.Drawing.Size(448, 185);
            this.reviewTB.TabIndex = 35;
            this.reviewTB.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(377, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "REVIEW :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(34, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "CONFIRMED :";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(153, 90);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(184, 22);
            this.idTB.TabIndex = 29;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.idLabel.Location = new System.Drawing.Point(34, 96);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(93, 16);
            this.idLabel.TabIndex = 28;
            this.idLabel.Text = "REVIEW ID :";
            // 
            // reviewsTableBindingSource1
            // 
            this.reviewsTableBindingSource1.DataMember = "ReviewsTable";
            this.reviewsTableBindingSource1.DataSource = this.shoppingDataSet12;
            // 
            // shoppingDataSet12
            // 
            this.shoppingDataSet12.DataSetName = "ShoppingDataSet12";
            this.shoppingDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewsTableTableAdapter1
            // 
            this.reviewsTableTableAdapter1.ClearBeforeFill = true;
            // 
            // reviewsTableBindingSource2
            // 
            this.reviewsTableBindingSource2.DataMember = "ReviewsTable";
            this.reviewsTableBindingSource2.DataSource = this.shoppingDataSet18;
            // 
            // shoppingDataSet18
            // 
            this.shoppingDataSet18.DataSetName = "ShoppingDataSet18";
            this.shoppingDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminID
            // 
            this.adminID.AutoSize = true;
            this.adminID.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold);
            this.adminID.Location = new System.Drawing.Point(164, 502);
            this.adminID.Name = "adminID";
            this.adminID.Size = new System.Drawing.Size(27, 22);
            this.adminID.TabIndex = 13;
            this.adminID.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "MANAGER ID :";
            // 
            // reviewsTableTableAdapter2
            // 
            this.reviewsTableTableAdapter2.ClearBeforeFill = true;
            // 
            // reviewDGW
            // 
            this.reviewDGW.AutoGenerateColumns = false;
            this.reviewDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reviewDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reviewIDDataGridViewTextBoxColumn,
            this.reviwerIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.reviewDateDataGridViewTextBoxColumn,
            this.reviewDataGridViewTextBoxColumn,
            this.confirmedDataGridViewCheckBoxColumn});
            this.reviewDGW.DataSource = this.reviewsTableBindingSource3;
            this.reviewDGW.Location = new System.Drawing.Point(16, 12);
            this.reviewDGW.Name = "reviewDGW";
            this.reviewDGW.RowHeadersWidth = 51;
            this.reviewDGW.RowTemplate.Height = 24;
            this.reviewDGW.Size = new System.Drawing.Size(1197, 201);
            this.reviewDGW.TabIndex = 14;
            this.reviewDGW.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.reviewDGW_CellMouseClick_1);
            // 
            // reviewIDDataGridViewTextBoxColumn
            // 
            this.reviewIDDataGridViewTextBoxColumn.DataPropertyName = "Review_ID";
            this.reviewIDDataGridViewTextBoxColumn.HeaderText = "Review_ID";
            this.reviewIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewIDDataGridViewTextBoxColumn.Name = "reviewIDDataGridViewTextBoxColumn";
            this.reviewIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reviwerIDDataGridViewTextBoxColumn
            // 
            this.reviwerIDDataGridViewTextBoxColumn.DataPropertyName = "Reviwer_ID";
            this.reviwerIDDataGridViewTextBoxColumn.HeaderText = "Reviwer_ID";
            this.reviwerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviwerIDDataGridViewTextBoxColumn.Name = "reviwerIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
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
            // reviewsTableBindingSource3
            // 
            this.reviewsTableBindingSource3.DataMember = "ReviewsTable";
            this.reviewsTableBindingSource3.DataSource = this.shoppingDataSet19;
            // 
            // shoppingDataSet19
            // 
            this.shoppingDataSet19.DataSetName = "ShoppingDataSet19";
            this.shoppingDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewsTableTableAdapter3
            // 
            this.reviewsTableTableAdapter3.ClearBeforeFill = true;
            // 
            // reviwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1262, 533);
            this.Controls.Add(this.reviewDGW);
            this.Controls.Add(this.adminID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "reviwForm";
            this.Text = "reviwForm";
            this.Load += new System.EventHandler(this.reviwForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reviewsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ShoppingDataSet11 shoppingDataSet11;
        private System.Windows.Forms.BindingSource reviewsTableBindingSource;
        private ShoppingDataSet11TableAdapters.ReviewsTableTableAdapter reviewsTableTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox reviewTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.CheckBox confirmedCB;
        private System.Windows.Forms.Button processButton;
        private ShoppingDataSet12 shoppingDataSet12;
        private System.Windows.Forms.BindingSource reviewsTableBindingSource1;
        private ShoppingDataSet12TableAdapters.ReviewsTableTableAdapter reviewsTableTableAdapter1;
        public System.Windows.Forms.Label adminID;
        private System.Windows.Forms.Label label1;
        private ShoppingDataSet18 shoppingDataSet18;
        private System.Windows.Forms.BindingSource reviewsTableBindingSource2;
        private ShoppingDataSet18TableAdapters.ReviewsTableTableAdapter reviewsTableTableAdapter2;
        private System.Windows.Forms.DataGridView reviewDGW;
        private ShoppingDataSet19 shoppingDataSet19;
        private System.Windows.Forms.BindingSource reviewsTableBindingSource3;
        private ShoppingDataSet19TableAdapters.ReviewsTableTableAdapter reviewsTableTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviwerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmedDataGridViewCheckBoxColumn;
    }
}