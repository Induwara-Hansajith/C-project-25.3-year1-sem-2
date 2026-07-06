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
    public partial class Day_Reminder : Form
    {
        // Safely updated to your exact database server name
        private readonly string connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public Day_Reminder()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard_Admin dashboard_Admin = new Dashboard_Admin();
            dashboard_Admin.Show();
            this.Hide();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private async void Day_Reminder_Load(object sender, EventArgs e)
        {
            await LoadRemindersAsync();
        }

        // This method now purely focuses on Sacred Days and General Reminders
        // This method now perfectly matches your visual grid columns
        private async Task LoadRemindersAsync()
        {
            // We update the query to select exactly what the grid is expecting
            string query = @"
        SELECT 
            Description, 
            DayName, 
            SacredDayID, 
            SacredDate, 
            IsRecurringAnnually 
        FROM 
            SacredDays 
        ORDER BY 
            SacredDate ASC;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable sacredDaysTable = new DataTable();

                        await connection.OpenAsync();

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            sacredDaysTable.Load(reader);
                        }

                        if (dataGridView2 != null)
                        {
                            // This tells the grid to use the exact columns you designed manually
                            dataGridView2.AutoGenerateColumns = false;
                            dataGridView2.DataSource = sacredDaysTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load the Sacred Days: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Reminder_Add reminder_Add = new Reminder_Add();
            reminder_Add.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            Reminder_Delete reminder_Delete = new Reminder_Delete();
            reminder_Delete.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new TempleManagementSystem.EventManagement.frmEventList(DBConfig.ConnectionString).Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}