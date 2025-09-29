using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Supermarket
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            this.Load += FormAdmin_Load;

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // اگر میخوای داده‌ها همون اول لود بشه
            LoadCategoryData();
            dataGridViewCategory.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void LoadCategoryData()
        {

            string connectionString = @"Server=.;Database=SupermarketDB;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Category";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewCategory.DataSource = dt; // اسم DataGridView خودت رو اینجا بذار
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // اگه بخوای فقط وقتی تب Category باز شد داده‌ها لود بشه
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Category) // اسم تبت رو درست بذار
            {
                LoadCategoryData();
            }
        }

        private void buttonRefresh1_Click(object sender, EventArgs e)
        {
            LoadCategoryData();
            MessageBox.Show("Refresh");
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=.;Database=SupermarketDB;Trusted_Connection=True;TrustServerCertificate=True;";

            string name = textBoxCategory.Text;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Category (name) VALUES (@name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("yor value added.");
                LoadCategoryData();


            }

        }
        private void dataGridViewCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCategory.CurrentRow != null)
            {
                // مقدار فعلی ستون Name رو میاریم و تو TextBox میذاریم
                textBoxCategory.Text = dataGridViewCategory.CurrentRow.Cells["Name"].Value.ToString();
            }
        }

        private void buttonUpdate1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=.;Database=SupermarketDB;Trusted_Connection=True;TrustServerCertificate=True;";
            if (dataGridViewCategory.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewCategory.CurrentRow.Cells["categoryId"].Value);
                string name = textBoxCategory.Text;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Category SET Name = @Name where CategoryId = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your field update");
                    LoadCategoryData();

                }



            }

        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=.;Database=SupermarketDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string input = textBoxCategory.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter ID or Name to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (int.TryParse(input, out int id))
                {
                    cmd.CommandText = "DELETE FROM Category WHERE CategoryId = @Value";
                    cmd.Parameters.AddWithValue("@Value", id);
                }
                else
                {
                    cmd.CommandText = "DELETE FROM Category WHERE Name = @Value";
                    cmd.Parameters.AddWithValue("@Value", input);
                }
                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Deleted successfully!");
                else
                    MessageBox.Show("No matching record found.");

                LoadCategoryData();
                textBoxCategory.Clear();





            }

        }
    }
}

