namespace Supermarket
{
    partial class Formpassword
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUsername = new Label();
            label2 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(211, 116);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(152, 38);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username:";
            labelUsername.Click += labelUsername_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 195);
            label2.Name = "label2";
            label2.Size = new Size(145, 38);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(381, 116);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(263, 27);
            textUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(381, 206);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(263, 27);
            textPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ImageKey = "(none)";
            buttonLogin.Location = new Point(310, 312);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(199, 62);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // Formpassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(labelUsername);
            Name = "Formpassword";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label label2;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button buttonLogin;
    }
}
