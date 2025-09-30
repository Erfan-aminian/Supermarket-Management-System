namespace Supermarket
{
    partial class FormAdmin
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
            tabControl1 = new TabControl();
            tabPageProduct = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            buttonRefresh0 = new Button();
            buttonDelete0 = new Button();
            buttonUpdate0 = new Button();
            buttonAdd0 = new Button();
            textBoxCategoryId = new TextBox();
            label1 = new Label();
            dataGridViewProduct = new DataGridView();
            Category = new TabPage();
            textBoxCategory = new TextBox();
            labelCategory = new Label();
            buttonRefresh1 = new Button();
            buttonDelete1 = new Button();
            buttonUpdate1 = new Button();
            buttonAdd1 = new Button();
            dataGridViewCategory = new DataGridView();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProduct);
            tabControl1.Controls.Add(Category);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(80, 25);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(941, 523);
            tabControl1.TabIndex = 0;
            // 
            // tabPageProduct
            // 
            tabPageProduct.Controls.Add(label4);
            tabPageProduct.Controls.Add(label3);
            tabPageProduct.Controls.Add(label2);
            tabPageProduct.Controls.Add(textBoxPrice);
            tabPageProduct.Controls.Add(textBoxName);
            tabPageProduct.Controls.Add(buttonRefresh0);
            tabPageProduct.Controls.Add(buttonDelete0);
            tabPageProduct.Controls.Add(buttonUpdate0);
            tabPageProduct.Controls.Add(buttonAdd0);
            tabPageProduct.Controls.Add(textBoxCategoryId);
            tabPageProduct.Controls.Add(label1);
            tabPageProduct.Controls.Add(dataGridViewProduct);
            tabPageProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageProduct.Location = new Point(4, 29);
            tabPageProduct.Name = "tabPageProduct";
            tabPageProduct.Padding = new Padding(3);
            tabPageProduct.Size = new Size(933, 490);
            tabPageProduct.TabIndex = 0;
            tabPageProduct.Text = "Products";
            tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(583, 295);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 247);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(565, 190);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 9;
            label2.Text = "Category Id";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(685, 295);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(231, 34);
            textBoxPrice.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(685, 244);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(231, 34);
            textBoxName.TabIndex = 7;
            // 
            // buttonRefresh0
            // 
            buttonRefresh0.Location = new Point(780, 418);
            buttonRefresh0.Name = "buttonRefresh0";
            buttonRefresh0.Size = new Size(110, 50);
            buttonRefresh0.TabIndex = 6;
            buttonRefresh0.Text = "Refresh";
            buttonRefresh0.UseVisualStyleBackColor = true;
            buttonRefresh0.Click += buttonRefresh0_Click;
            // 
            // buttonDelete0
            // 
            buttonDelete0.Location = new Point(611, 418);
            buttonDelete0.Name = "buttonDelete0";
            buttonDelete0.Size = new Size(110, 50);
            buttonDelete0.TabIndex = 5;
            buttonDelete0.Text = "Delete";
            buttonDelete0.UseVisualStyleBackColor = true;
            buttonDelete0.Click += buttonDelete0_Click;
            // 
            // buttonUpdate0
            // 
            buttonUpdate0.Location = new Point(780, 353);
            buttonUpdate0.Name = "buttonUpdate0";
            buttonUpdate0.Size = new Size(110, 50);
            buttonUpdate0.TabIndex = 4;
            buttonUpdate0.Text = "Update";
            buttonUpdate0.UseVisualStyleBackColor = true;
            // 
            // buttonAdd0
            // 
            buttonAdd0.Location = new Point(611, 353);
            buttonAdd0.Name = "buttonAdd0";
            buttonAdd0.Size = new Size(110, 50);
            buttonAdd0.TabIndex = 3;
            buttonAdd0.Text = "Add";
            buttonAdd0.UseVisualStyleBackColor = true;
            buttonAdd0.Click += buttonAdd0_Click;
            // 
            // textBoxCategoryId
            // 
            textBoxCategoryId.Location = new Point(685, 187);
            textBoxCategoryId.Name = "textBoxCategoryId";
            textBoxCategoryId.Size = new Size(231, 34);
            textBoxCategoryId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(590, 33);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(3, 6);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.Size = new Size(552, 478);
            dataGridViewProduct.TabIndex = 0;
            // 
            // Category
            // 
            Category.Controls.Add(textBoxCategory);
            Category.Controls.Add(labelCategory);
            Category.Controls.Add(buttonRefresh1);
            Category.Controls.Add(buttonDelete1);
            Category.Controls.Add(buttonUpdate1);
            Category.Controls.Add(buttonAdd1);
            Category.Controls.Add(dataGridViewCategory);
            Category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category.Location = new Point(4, 29);
            Category.Name = "Category";
            Category.Size = new Size(933, 490);
            Category.TabIndex = 3;
            Category.Text = "Cateory";
            Category.UseVisualStyleBackColor = true;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(642, 233);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(243, 34);
            textBoxCategory.TabIndex = 6;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(642, 17);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(65, 28);
            labelCategory.TabIndex = 5;
            labelCategory.Text = "label1";
            // 
            // buttonRefresh1
            // 
            buttonRefresh1.Location = new Point(791, 406);
            buttonRefresh1.Name = "buttonRefresh1";
            buttonRefresh1.Size = new Size(94, 44);
            buttonRefresh1.TabIndex = 4;
            buttonRefresh1.Text = "Refresh";
            buttonRefresh1.UseVisualStyleBackColor = true;
            buttonRefresh1.Click += buttonRefresh1_Click;
            // 
            // buttonDelete1
            // 
            buttonDelete1.Location = new Point(655, 406);
            buttonDelete1.Name = "buttonDelete1";
            buttonDelete1.Size = new Size(94, 44);
            buttonDelete1.TabIndex = 3;
            buttonDelete1.Text = "Delete";
            buttonDelete1.UseVisualStyleBackColor = true;
            buttonDelete1.Click += buttonDelete1_Click;
            // 
            // buttonUpdate1
            // 
            buttonUpdate1.Location = new Point(791, 318);
            buttonUpdate1.Name = "buttonUpdate1";
            buttonUpdate1.Size = new Size(94, 44);
            buttonUpdate1.TabIndex = 2;
            buttonUpdate1.Text = "Update";
            buttonUpdate1.UseVisualStyleBackColor = true;
            buttonUpdate1.Click += buttonUpdate1_Click;
            // 
            // buttonAdd1
            // 
            buttonAdd1.Location = new Point(655, 318);
            buttonAdd1.Name = "buttonAdd1";
            buttonAdd1.Size = new Size(94, 44);
            buttonAdd1.TabIndex = 1;
            buttonAdd1.Text = "Add";
            buttonAdd1.UseVisualStyleBackColor = true;
            buttonAdd1.Click += buttonAdd1_Click;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.AllowUserToDeleteRows = false;
            dataGridViewCategory.AllowUserToResizeRows = false;
            dataGridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCategory.BackgroundColor = Color.Gainsboro;
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.Dock = DockStyle.Left;
            dataGridViewCategory.GridColor = Color.White;
            dataGridViewCategory.Location = new Point(0, 0);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.ReadOnly = true;
            dataGridViewCategory.RowHeadersWidth = 51;
            dataGridViewCategory.Size = new Size(600, 490);
            dataGridViewCategory.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(933, 490);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cart";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(933, 490);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cart Item";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 540);
            Controls.Add(tabControl1);
            Name = "FormAdmin";
            Text = "FormAdmin";
            tabControl1.ResumeLayout(false);
            tabPageProduct.ResumeLayout(false);
            tabPageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            Category.ResumeLayout(false);
            Category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageProduct;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage Category;
        private DataGridView dataGridViewCategory;
        private Button buttonRefresh1;
        private Button buttonDelete1;
        private Button buttonUpdate1;
        private Button buttonAdd1;
        private Label labelCategory;
        private TextBox textBoxCategory;
        private TextBox textBoxCategoryId;
        private Label label1;
        private DataGridView dataGridViewProduct;
        private Button buttonRefresh0;
        private Button buttonDelete0;
        private Button buttonUpdate0;
        private Button buttonAdd0;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}