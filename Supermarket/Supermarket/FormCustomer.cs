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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            this.Load += FormCustomer_Load;
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadProductsData();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCustomer.SelectedTab == Products0) // اسم تبت رو درست بذار
            {
                LoadProductsData();
            }
        }

        private void LoadProductsData()
        {
            string connectionString = @"Server=.;Database=SupermarketDB;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Products";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewProducts.DataSource = dt;
                    //MessageBox.Show("connect !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
