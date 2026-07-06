using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempleManagementSystem.Services;
using TempleManagementSystem.Model;
using TempleManagmentSystem;

namespace TempleManagementSystem.Forms
{
    public partial class DanaApproval : Form
    {
        private int selectedRequestID = 0;
        public DanaApproval()
        {
            InitializeComponent();

            // --- CONFIGURE TOP TABLE (Requests) ---
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            // --- CONFIGURE BOTTOM TABLE (Offerings) ---
            // Make sure the name matches your bottom table (e.g., dataGridView2)
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;
        }
        // A single method to keep both tables synced with the database
        private void RefreshBothTables()
        {
            // Clear current data
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            // Load Requests (Top Table)
            DanaRequestService requestService = new DanaRequestService();
            dataGridView1.DataSource = requestService.GetAllRequests();

            // Load Upcoming Offerings (Bottom Table)
            DanaOfferingService offeringService = new DanaOfferingService();
            dataGridView2.DataSource = offeringService.GetUpcomingDanaOfferings();
        }
        private void DanaApproval_Load(object sender, EventArgs e)
        {
            RefreshBothTables();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the click is on a valid row (prevents crashes if you click column headers)
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Get the value from the RequestID column
                    var cellValue = row.Cells["RequestID"].Value;

                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        selectedRequestID = Convert.ToInt32(cellValue);
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error: Could not find a column named 'RequestID'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllDonorsView allDonorsView = new AllDonorsView();
            allDonorsView.Show();
            this.Hide();
        }

        

        private void Approve_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Request from the top table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Using index 0 grabs the first column regardless of its name
            int requestId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            DanaRequestService service = new DanaRequestService();
            service.RejectRequest(requestId);

            MessageBox.Show("Request Rejected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshBothTables();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           Dashboard_Admin dashboard_Admin = new Dashboard_Admin();
            dashboard_Admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllDanaofferingView allDanaofferingView = new AllDanaofferingView();
            allDanaofferingView.Show();
            this.Hide();
        }

        private void Approve_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Request from the top table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Using index 0 grabs the first column regardless of its name
            int requestId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            DanaRequestService service = new DanaRequestService();
            service.ApproveAndCreateOffering(requestId);  

            MessageBox.Show("Request Approved and moved to Upcoming Offerings!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshBothTables();
        }

        private void Hold_Click(object sender, EventArgs e)
        {

        }

        private void Hold_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Request from the top table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Using index 0 grabs the first column regardless of its name
            int requestId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            DanaRequestService service = new DanaRequestService();
            service.HoldRequest(requestId);

            MessageBox.Show("Request Put On Hold.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshBothTables();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an Upcoming Offering from the bottom table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int danaId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["DanaID"].Value);

            DanaOfferingService service = new DanaOfferingService();
            service.MarkOfferingAsCompleted(danaId); // Ensure this method is in your DanaOfferingService.cs!

            MessageBox.Show("Dana Offering marked as Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshBothTables();
        }
    }
}
