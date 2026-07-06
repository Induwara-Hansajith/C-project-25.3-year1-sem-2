using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TempleManagmentSystem;

namespace templemng_Demika
{
    public partial class Visitor_Management_Admin : Form
    {
        private readonly string connectionString =
            @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;TrustServerCertificate=True;";

        public Visitor_Management_Admin()
        {
            InitializeComponent();

            LoadAllVisits();
        }

        private void Visitor_Management_Admin_Load(object sender, EventArgs e)
        {
            // Call our brand new method to load the data the second the form opens!
            
        }

        // --- NEW METHOD TO LOAD DATA ---
        private void LoadAllVisits()
        {
            // 1. SAFETY NET: Force the grid to auto-create the columns perfectly!
            dataGridView1.AutoGenerateColumns = true;

            // 2. SAFETY NET: Use a LEFT JOIN so no visits ever get hidden!
            string query = @"
                SELECT 
                    vv.VisitID, 
                    ISNULL(v.FullName, 'Unknown Guest') AS [Guest Name], 
                    vv.VisitDate AS [Date], 
                    vv.Purpose, 
                    vv.CheckInTime AS [Check In], 
                    vv.CheckOutTime AS [Check Out], 
                    vv.Notes
                FROM dbo.VisitorVisits vv
                LEFT JOIN dbo.Visitors v ON vv.VisitorID = v.VisitorID
                ORDER BY vv.VisitDate DESC";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    DataTable dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);

                    // 3. SAFETY NET: Check if the database is actually empty
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("The database connection worked, but there are 0 visits saved in the database right now! Try booking a guest visit first.", "Database Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading visits: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtSearch.Text.Trim();

            // If the search box is empty, load all records back into the grid
            if (string.IsNullOrEmpty(input))
            {
                LoadAllVisits();
                return;
            }

            // Notice we removed the "int.TryParse" here because we are searching for text now!

            // Updated Search Query to search by Name using LIKE
            string sql = @"
        SELECT 
            vv.VisitID, 
            v.FullName AS [Guest Name], 
            vv.VisitDate AS [Date], 
            vv.Purpose, 
            vv.CheckInTime AS [Check In], 
            vv.CheckOutTime AS [Check Out], 
            vv.Notes
        FROM dbo.VisitorVisits vv
        LEFT JOIN dbo.Visitors v ON vv.VisitorID = v.VisitorID
        WHERE v.FullName LIKE @SearchName
        ORDER BY vv.VisitDate DESC";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Adding '%' before and after the input means "find this text anywhere in the name"
                    cmd.Parameters.Add("@SearchName", SqlDbType.NVarChar).Value = "%" + input + "%";

                    DataTable dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No visits found for that Guest Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard_Admin dashboard_Admin = new Dashboard_Admin();
            dashboard_Admin.Show();
            this.Hide();
        }

        // --- EMPTY HANDLERS FOR DESIGNER ---
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}