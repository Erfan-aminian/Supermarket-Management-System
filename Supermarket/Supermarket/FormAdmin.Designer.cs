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
            tabPage1 = new TabPage();
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
            Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
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
            // tabPage1
            // 
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(933, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            tabPage1.UseVisualStyleBackColor = true;
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
            Category.ResumeLayout(false);
            Category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
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
    }
}