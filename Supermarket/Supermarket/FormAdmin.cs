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

    }
}

