namespace E_Ticaret_Proje_Form_Arayuzu
{
    partial class addProductPanel
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.categoriesTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet6 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet6();
            this.categoriesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDataSet5 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet5();
            this.categoriesTableTableAdapter = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet5TableAdapters.CategoriesTableTableAdapter();
            this.categoriesTableTableAdapter1 = new E_Ticaret_Proje_Form_Arayuzu.ShoppingDataSet6TableAdapters.CategoriesTableTableAdapter();
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(93, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(93, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(93, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRICE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(93, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "CATEGORY :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(399, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "PROPERTIES :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(402, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(316, 185);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(739, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 76);
            this.button1.TabIndex = 15;
            this.button1.Text = "ADD PRODUCT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // categoriesTableBindingSource1
            // 
            this.categoriesTableBindingSource1.DataMember = "CategoriesTable";
            this.categoriesTableBindingSource1.DataSource = this.shoppingDataSet6;
            // 
            // shoppingDataSet6
            // 
            this.shoppingDataSet6.DataSetName = "ShoppingDataSet6";
            this.shoppingDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableBindingSource
            // 
            this.categoriesTableBindingSource.DataMember = "CategoriesTable";
            this.categoriesTableBindingSource.DataSource = this.shoppingDataSet5;
            // 
            // shoppingDataSet5
            // 
            this.shoppingDataSet5.DataSetName = "ShoppingDataSet5";
            this.shoppingDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableTableAdapter
            // 
            this.categoriesTableTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableTableAdapter1
            // 
            this.categoriesTableTableAdapter1.ClearBeforeFill = true;
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriesTableBindingSource1, "Name", true));
            this.CategoriesCB.DataSource = this.categoriesTableBindingSource1;
            this.CategoriesCB.DisplayMember = "Name";
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(212, 155);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(150, 24);
            this.CategoriesCB.TabIndex = 16;
            this.CategoriesCB.ValueMember = "Category ID";
            // 
            // addProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::E_Ticaret_Proje_Form_Arayuzu.Properties.Resources.rect8463;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.CategoriesCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "addProductPanel";
            this.Size = new System.Drawing.Size(900, 270);
            this.Load += new System.EventHandler(this.addProductPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource categoriesTableBindingSource;
        private ShoppingDataSet5 shoppingDataSet5;
        private ShoppingDataSet5TableAdapters.CategoriesTableTableAdapter categoriesTableTableAdapter;
        private System.Windows.Forms.BindingSource categoriesTableBindingSource1;
        private ShoppingDataSet6 shoppingDataSet6;
        private ShoppingDataSet6TableAdapters.CategoriesTableTableAdapter categoriesTableTableAdapter1;
        private System.Windows.Forms.ComboBox CategoriesCB;
    }
}
