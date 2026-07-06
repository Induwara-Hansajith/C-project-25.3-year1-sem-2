using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempleManagementSystem.EventManagement;
using TempleManagementSystem.Forms;

namespace TempleManagmentSystem
{
    public partial class Reminder_Delete : Form
    {
        public Reminder_Delete()
        {
            InitializeComponent();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Get the ID from your textbox
            string inputId = txtDeleteID.Text;

            if (string.IsNullOrWhiteSpace(inputId))
            {
                MessageBox.Show("Please enter the SacredDayID of the record you want to delete.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ask for confirmation so you don't delete something by mistake
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this record? This cannot be undone.",
                                                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No) return;

            // 3. Database connection and query
            string connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            string query = "DELETE FROM SacredDays WHERE SacredDayID = @ID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // 4. Securely pass the ID
                        command.Parameters.AddWithValue("@ID", inputId);

                        await connection.OpenAsync();
                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDeleteID.Clear(); // Clear the input
                                                 // Optional: Call your Load method here to refresh the grid instantly!
                        }
                        else
                        {
                            MessageBox.Show("No record found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not delete the record: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard_Admin dashboard_Admin = new Dashboard_Admin();
            dashboard_Admin.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InsideAdminDashboard insideAdmin = new InsideAdminDashboard();
            insideAdmin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Day_Reminder day_Reminder = new Day_Reminder();
            day_Reminder.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Reminder_Delete_Load(object sender, EventArgs e)
{
    // This tells the form to fetch the data the moment it opens
    await LoadGridDataAsync(); 
}

private async Task LoadGridDataAsync()
{
    // Your exact connection string
    string connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
    
    // The query to pull exactly what your columns are asking for
    string query = "SELECT Description, DayName, SacredDayID, SacredDate FROM SacredDays ORDER BY SacredDate ASC;";

    try
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable table = new DataTable();
                await connection.OpenAsync();
                
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    table.Load(reader);
                }

                // Make sure your grid's name matches this! (e.g., dataGridView1)
                dataGridView2.AutoGenerateColumns = false; 
                dataGridView2.DataSource = table;
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Could not load the Sacred Days: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void button10_Click(object sender, EventArgs e)
        {
            new TempleManagementSystem.EventManagement.frmEventList(DBConfig.ConnectionString).Show();
            this.Hide();
        }
    }
}
