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
using templemng_Demika;

namespace TempleManagmentSystem
{
    public partial class Dashboard_Admin : Form
    {

        private async Task RefreshTotalEventsAsync()
        {
            // 1. Define your connection string (Replace with your actual database details)
            string connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";            // 2. Define your SQL query to count the events
            

            try
            {
                string query = "SELECT COUNT(*) FROM Events;"; // Replace 'Events' with your actual table name
                // 3. Establish connection and command using 'using' statements for proper resource cleanup
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Open connection asynchronously
                        await connection.OpenAsync();

                        // ExecuteScalar is perfect here because we only expect a single value back
                        object result = await command.ExecuteScalarAsync();

                        if (result != null && result != DBNull.Value)
                        {
                            // 4. Update the Label's Text safely on the UI thread
                            lblTotalEvents.Text = result.ToString();
                        }
                        else
                        {
                            lblTotalEvents.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors (connection issues, SQL syntax errors, etc.)
                MessageBox.Show($"Error loading total events: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTotalEvents.Text = "Error";
            }

            
        }

        private async Task RefreshTotalDaanaAsync() {

            // 1. Define your connection string (Replace with your actual database details)
            string connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";            // 2. Define your SQL query to count the events


            try
            {
                string query = "SELECT COUNT(*) FROM DanaRequests;"; // Replace 'DanaRequests' with your actual table name
                // 3. Establish connection and command using 'using' statements for proper resource cleanup
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Open connection asynchronously
                        await connection.OpenAsync();

                        // ExecuteScalar is perfect here because we only expect a single value back
                        object result = await command.ExecuteScalarAsync();

                        if (result != null && result != DBNull.Value)
                        {
                            // 4. Update the Label's Text safely on the UI thread
                            lblDanaRequest.Text = result.ToString();
                        }
                        else
                        {
                            lblDanaRequest.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors (connection issues, SQL syntax errors, etc.)
                MessageBox.Show($"Error loading total events: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDanaRequest.Text = "Error";
            }

        }

        private async Task RefreshTotalResoursesAsync()
        {

            // 1. Define your connection string (Replace with your actual database details)
            string connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";            // 2. Define your SQL query to count the events


            try
            {
                string query = "SELECT COUNT(*) FROM Resources;"; // Replace 'Resources' with your actual table name
                // 3. Establish connection and command using 'using' statements for proper resource cleanup
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Open connection asynchronously
                        await connection.OpenAsync();

                        // ExecuteScalar is perfect here because we only expect a single value back
                        object result = await command.ExecuteScalarAsync();

                        if (result != null && result != DBNull.Value)
                        {
                            // 4. Update the Label's Text safely on the UI thread
                            lblResources.Text = result.ToString();
                        }
                        else
                        {
                            lblResources.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors (connection issues, SQL syntax errors, etc.)
                MessageBox.Show($"Error loading total events: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResources.Text = "Error";
            }

        }


        private async Task RefreshTotalVisitorAsync()
        {

            // 1. Define your connection string (Replace with your actual database details)
            string connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";            // 2. Define your SQL query to count the events


            try
            {
                string query = "SELECT COUNT(*) FROM Visitors;"; // Replace 'Visitor' with your actual table name
                // 3. Establish connection and command using 'using' statements for proper resource cleanup
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Open connection asynchronously
                        await connection.OpenAsync();

                        // ExecuteScalar is perfect here because we only expect a single value back
                        object result = await command.ExecuteScalarAsync();

                        if (result != null && result != DBNull.Value)
                        {
                            // 4. Update the Label's Text safely on the UI thread
                            lblVisitor.Text = result.ToString();
                        }
                        else
                        {
                            lblVisitor.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors (connection issues, SQL syntax errors, etc.)
                MessageBox.Show($"Error loading total events: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblVisitor.Text = "Error";
            }

        }

        public Dashboard_Admin()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Dashboard_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'templeManagementDBDataSet1.SacredDays' table. You can move, or remove it, as needed.
            this.sacredDaysTableAdapter.Fill(this.templeManagementDBDataSet1.SacredDays);
            // TODO: This line of code loads data into the 'templeManagementDBDataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.templeManagementDBDataSet.Events);


            // Existing data loading tasks
            this.sacredDaysTableAdapter.Fill(this.templeManagementDBDataSet1.SacredDays);
            this.eventsTableAdapter.Fill(this.templeManagementDBDataSet.Events);

            // 3. Trigger the asynchronous refresh when the window loads
              await RefreshTotalEventsAsync();
              await RefreshTotalDaanaAsync();
              await RefreshTotalResoursesAsync();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblDanaRequest_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

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

        private void button10_Click(object sender, EventArgs e)
        {
            new TempleManagementSystem.EventManagement.frmEventList(DBConfig.ConnectionString).Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Visitor_Management_Admin visitor_Management = new Visitor_Management_Admin();
            visitor_Management.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Create a new blank form to act as the "frame"
            Form settingsWindow = new Form();
            settingsWindow.Size = new Size(1000, 700);
            settingsWindow.Text = "System Settings";
            settingsWindow.StartPosition = FormStartPosition.CenterScreen;

            // Create Settings UserControl
            Settings mySettingsPage = new Settings();
            mySettingsPage.Dock = DockStyle.Fill; // Makes it fill the whole frame

            // Add the painting to the frame and show it!
            settingsWindow.Controls.Add(mySettingsPage);
            settingsWindow.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Resources resources = new Resources();
            resources.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }

        private void lblResources_Click(object sender, EventArgs e)
        {

        }
    }
}
