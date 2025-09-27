using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace Supermarket
{
    public partial class FormLogin : Form
    {
        public string connectionString = @"Server=.;Database=SupermarketDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public FormLogin()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrWhiteSpace(textUsername.Text) || string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MessageBox.Show("Please enter all fileds.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Admin Form 
                    string adminQuery = "SELECT COUNT(1) FROM  Users where Username=@username and PasswordHash=@password";
                    using (SqlCommand cmdAdmin = new SqlCommand(adminQuery, conn))
                    {
                        cmdAdmin.Parameters.AddWithValue("@username", textUsername.Text.Trim());
                        cmdAdmin.Parameters.AddWithValue("@password", textPassword.Text.Trim());
                        int adminCount = Convert.ToInt32(cmdAdmin.ExecuteScalar());
                        if (adminCount > 0)
                        {
                            FormAdmin adminForm = new FormAdmin();
                            adminForm.Show();
                            this.Hide();
                            return;
                        }
                    }
                    //Customer Form
                    string custQuery = "SELECT CustomerId From Customers WHERE Username=@username AND PasswordHash=@password";
                    using (SqlCommand cmdCust = new SqlCommand(custQuery, conn))
                    {
                        cmdCust.Parameters.AddWithValue("@username", textUsername.Text.Trim());
                        cmdCust.Parameters.AddWithValue("@password", textPassword.Text.Trim());

                        using (SqlDataReader reader = cmdCust.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int customerId = Convert.ToInt32(reader["CustomerId"]);
                                //string fullname = reader["Fullname"].ToString();
                                FormCustomer customerForm = new FormCustomer();
                                customerForm.Show();
                                this.Hide(); 
                                return;
                            }
                        }

                    }
                    //Database check
                    MessageBox.Show("Username or password is incorrect.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
