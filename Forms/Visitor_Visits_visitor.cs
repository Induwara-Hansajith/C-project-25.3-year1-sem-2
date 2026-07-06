using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TempleManagmentSystem;

namespace templemng_Demika
{
    public partial class Visitor_Visits_visitor : Form
    {
        private readonly string connectionString =
           @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;TrustServerCertificate=True;";

        public Visitor_Visits_visitor()
        {
            InitializeComponent();
            LoadEvents(); // populate the Event list box on startup
        }

        private void LoadEvents()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT EventID, EventName FROM dbo.Events ORDER BY EventName", con))
                {
                    DataTable dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);

                    // Add a blank option at the top so guests aren't forced to pick an event
                    DataRow blankRow = dt.NewRow();
                    blankRow["EventID"] = DBNull.Value;
                    blankRow["EventName"] = "-- General Visit (No specific event) --";
                    dt.Rows.InsertAt(blankRow, 0);

                    listBox1.DataSource = dt;
                    listBox1.DisplayMember = "EventName"; // shown to the user
                    listBox1.ValueMember = "EventID";     // the FK we actually store
                    listBox1.SelectedIndex = 0;           // select the blank option initially
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load events: " + ex.Message);
            }
        }

        // --- EMPTY HANDLERS: Do not delete these, they keep the Designer happy! ---
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void txtVisitorID_TextChanged(object sender, EventArgs e) { }
        private void Visitor_Visits_visitor_Load(object sender, EventArgs e) { }


        // --- THE FIXED ADD VISIT BUTTON ---
        private async void btnAddVisit_Click(object sender, EventArgs e)
        {
            // 1. Validate the form 
            if (string.IsNullOrWhiteSpace(txtGuestName.Text))
            {
                MessageBox.Show("Please enter your name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. The Two-Step Queries
            string visitorQuery = @"INSERT INTO Visitors (FullName) OUTPUT INSERTED.VisitorID VALUES (@FullName)";
            string visitQuery = @"INSERT INTO VisitorVisits (VisitorID, EventID, VisitDate, Purpose, CheckInTime, CheckOutTime, Notes) 
                                  VALUES (@NewVisitorID, @EventID, @VisitDate, @Purpose, @CheckInTime, @CheckOutTime, @Notes)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            int generatedVisitorId = 0;

                            // Step A: Insert Visitor to get a new ID
                            using (SqlCommand cmdVisitor = new SqlCommand(visitorQuery, conn, transaction))
                            {
                                cmdVisitor.Parameters.AddWithValue("@FullName", txtGuestName.Text.Trim());
                                generatedVisitorId = (int)await cmdVisitor.ExecuteScalarAsync();
                            }

                            // Step B: Insert the actual Visit
                            using (SqlCommand cmdVisit = new SqlCommand(visitQuery, conn, transaction))
                            {
                                cmdVisit.Parameters.Add("@NewVisitorID", SqlDbType.Int).Value = generatedVisitorId;

                                // Check if they selected an event or the blank option
                                if (listBox1.SelectedValue == null || listBox1.SelectedValue == DBNull.Value)
                                    cmdVisit.Parameters.Add("@EventID", SqlDbType.Int).Value = DBNull.Value;
                                else
                                    cmdVisit.Parameters.Add("@EventID", SqlDbType.Int).Value = listBox1.SelectedValue;

                                cmdVisit.Parameters.Add("@VisitDate", SqlDbType.Date).Value = dtpVisitDate.Value.Date;

                                cmdVisit.Parameters.Add("@Purpose", SqlDbType.NVarChar, 150).Value =
                                    string.IsNullOrWhiteSpace(txtPurpose.Text) ? (object)DBNull.Value : txtPurpose.Text.Trim();

                                cmdVisit.Parameters.Add("@CheckInTime", SqlDbType.Time).Value = dtpCheckIn.Value.TimeOfDay;
                                cmdVisit.Parameters.Add("@CheckOutTime", SqlDbType.Time).Value = dtpCheckOut.Value.TimeOfDay;

                                cmdVisit.Parameters.Add("@Notes", SqlDbType.NVarChar, 255).Value =
                                    string.IsNullOrWhiteSpace(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text.Trim();

                                await cmdVisit.ExecuteNonQueryAsync();
                            }

                            // Commit the transaction to save both!
                            transaction.Commit();
                            MessageBox.Show("Your visit has been successfully booked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the form
                            txtGuestName.Clear();
                            txtPurpose.Clear();
                            txtNotes.Clear();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Booking Failed:\n\n{ex.Message}", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Error: {ex.Message}");
            }
        }

        // --- GUESTS SHOULD NOT BE UPDATING DATA ---
        private void btnUpdateVisit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guest users cannot update past visits.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }
    }
}