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
    public partial class Reminder_Add : Form
    {
        public Reminder_Add()
        {
            InitializeComponent();
        } // <-- Make sure this closing bracket is here!

        private void Reminder_Add_Load(object sender, EventArgs e)
        {
            // The designer just needs this to exist to stay happy!
        } // <-- Make sure this closing bracket is here, too!


        private async void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Gently gather the input from your form controls (Checkbox is gone now)
            string dayName = txtName.Text;
            DateTime sacredDate = dtpSacredDate.Value.Date;
            string description = txtDescription.Text;

            // 2. A soft check to make sure the name isn't left blank
            if (string.IsNullOrWhiteSpace(dayName))
            {
                MessageBox.Show("Please enter the name of the Sacred Day!","Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Your perfectly reliable connection string
            string connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            // 4. The SQL Query for the SacredDays table
            string query = @"
        INSERT INTO SacredDays (DayName, SacredDate, Description, IsRecurringAnnually) 
        VALUES (@DayName, @SacredDate, @Description, @IsRecurringAnnually);";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // 5. Securely attach the values to the parameters
                        command.Parameters.AddWithValue("@DayName", dayName);
                        command.Parameters.AddWithValue("@SacredDate", sacredDate);

                        // If the description is empty, we gently provide some default text
                        string finalDescription = string.IsNullOrWhiteSpace(description) ? "No description provided." : description;
                        command.Parameters.AddWithValue("@Description", finalDescription);

                        // 6. We quietly set the recurring value to true in the background
                        command.Parameters.AddWithValue("@IsRecurringAnnually", true);

                        // 7. Open the connection and execute the insert safely
                        await connection.OpenAsync();
                        await command.ExecuteNonQueryAsync();

                        MessageBox.Show("Sacred Day added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 8. Clear the form so it is fresh and ready for the next entry
                        txtName.Clear();
                        txtDescription.Clear();
                        dtpSacredDate.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not save the Sacred Day: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard_Admin dashboard_Admin = new Dashboard_Admin();
            dashboard_Admin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Day_Reminder day_Reminder = new Day_Reminder();
            day_Reminder.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InsideAdminDashboard insideAdmin = new InsideAdminDashboard();
            insideAdmin.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new TempleManagementSystem.EventManagement.frmEventList(DBConfig.ConnectionString).Show();
            this.Hide();
        }
    }
}
