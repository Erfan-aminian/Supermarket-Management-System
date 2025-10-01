namespace Supermarket
{
    partial class FormCustomer
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
            tabControlCustomer = new TabControl();
            Products0 = new TabPage();
            buttonProductAdd = new Button();
            label1 = new Label();
            dataGridViewProducts = new DataGridView();
            tabPageCart = new TabPage();
            tabControlCustomer.SuspendLayout();
            Products0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // tabControlCustomer
            // 
            tabControlCustomer.Controls.Add(Products0);
            tabControlCustomer.Controls.Add(tabPageCart);
            tabControlCustomer.Location = new Point(12, 12);
            tabControlCustomer.Name = "tabControlCustomer";
            tabControlCustomer.SelectedIndex = 0;
            tabControlCustomer.Size = new Size(879, 470);
            tabControlCustomer.TabIndex = 0;
            // 
            // Products0
            // 
            Products0.Controls.Add(buttonProductAdd);
            Products0.Controls.Add(label1);
            Products0.Controls.Add(dataGridViewProducts);
            Products0.Location = new Point(4, 29);
            Products0.Name = "Products0";
            Products0.Padding = new Padding(3);
            Products0.Size = new Size(871, 437);
            Products0.TabIndex = 0;
            Products0.Text = "Products";
            Products0.UseVisualStyleBackColor = true;
            // 
            // buttonProductAdd
            // 
            buttonProductAdd.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProductAdd.Location = new Point(638, 324);
            buttonProductAdd.Name = "buttonProductAdd";
            buttonProductAdd.Size = new Size(198, 74);
            buttonProductAdd.TabIndex = 2;
            buttonProductAdd.Text = "Add to cart";
            buttonProductAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(622, 60);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Dock = DockStyle.Left;
            dataGridViewProducts.Location = new Point(3, 3);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(589, 431);
            dataGridViewProducts.TabIndex = 0;
            // 
            // tabPageCart
            // 
            tabPageCart.Location = new Point(4, 29);
            tabPageCart.Name = "tabPageCart";
            tabPageCart.Padding = new Padding(3);
            tabPageCart.Size = new Size(871, 437);
            tabPageCart.TabIndex = 1;
            tabPageCart.Text = "Cart";
            tabPageCart.UseVisualStyleBackColor = true;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 494);
            Controls.Add(tabControlCustomer);
            Name = "FormCustomer";
            Text = "FormCustomer";
            tabControlCustomer.ResumeLayout(false);
            Products0.ResumeLayout(false);
            Products0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCustomer;
        private TabPage Products0;
        private DataGridView dataGridViewProducts;
        private TabPage tabPageCart;
        private Button buttonProductAdd;
        private Label label1;
    }
}