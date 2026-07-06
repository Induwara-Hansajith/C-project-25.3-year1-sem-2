using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempleManagmentSystem
{
    public partial class Resources : Form
    {
        // Your rock-solid connection string
        private readonly string _connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public Resources()
        {
            InitializeComponent();
        }

        private async void Resources_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();
            await LoadGridDataAsync();
        }

        private async Task LoadGridDataAsync()
        {
            string query = @"
                SELECT 
                    r.ResourceID, 
                    r.CategoryID, 
                    c.CategoryName, 
                    r.ResourceName, 
                    r.Unit, 
                    r.QuantityAvailable, 
                    r.MinimumThreshold, 
                    r.Description
                FROM Resources r
                INNER JOIN ResourceCategories c ON r.CategoryID = c.CategoryID
                ORDER BY r.ResourceName ASC;";

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable table = new DataTable();
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            table.Load(reader);
                        }
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading resources: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCategoriesAsync()
        {
            string query = "SELECT CategoryID, CategoryName FROM ResourceCategories ORDER BY CategoryName ASC;";
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable table = new DataTable();
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            table.Load(reader);
                        }

                        cmbCategory.DisplayMember = "CategoryName";
                        cmbCategory.ValueMember = "CategoryID";
                        cmbCategory.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResourceName.Text))
            {
                MessageBox.Show("Please enter a Resource Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                INSERT INTO Resources (CategoryID, ResourceName, Unit, QuantityAvailable, MinimumThreshold, Description) 
                VALUES (@CatID, @Name, @Unit, @Qty, @Min, @Desc);";

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CatID", cmbCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Name", txtResourceName.Text);
                        cmd.Parameters.AddWithValue("@Unit", string.IsNullOrWhiteSpace(txtUnit.Text) ? "pcs" : txtUnit.Text);
                        cmd.Parameters.AddWithValue("@Qty", numQuantity.Value);
                        cmd.Parameters.AddWithValue("@Min", numThreshold.Value);
                        cmd.Parameters.AddWithValue("@Desc", string.IsNullOrWhiteSpace(txtDescription.Text) ? (object)DBNull.Value : txtDescription.Text);

                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                MessageBox.Show("Resource added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await LoadGridDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding resource: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResourceID.Text))
            {
                MessageBox.Show("Please select a resource to update or enter a Resource ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                UPDATE Resources 
                SET CategoryID = @CatID, ResourceName = @Name, Unit = @Unit, 
                    QuantityAvailable = @Qty, MinimumThreshold = @Min, Description = @Desc
                WHERE ResourceID = @ID;";

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtResourceID.Text);
                        cmd.Parameters.AddWithValue("@CatID", cmbCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Name", txtResourceName.Text);
                        cmd.Parameters.AddWithValue("@Unit", string.IsNullOrWhiteSpace(txtUnit.Text) ? "pcs" : txtUnit.Text);
                        cmd.Parameters.AddWithValue("@Qty", numQuantity.Value);
                        cmd.Parameters.AddWithValue("@Min", numThreshold.Value);
                        cmd.Parameters.AddWithValue("@Desc", string.IsNullOrWhiteSpace(txtDescription.Text) ? (object)DBNull.Value : txtDescription.Text);

                        await conn.OpenAsync();
                        int rows = await cmd.ExecuteNonQueryAsync();
                        if (rows > 0)
                        {
                            MessageBox.Show("Resource updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            await LoadGridDataAsync();
                        }
                        else
                        {
                            MessageBox.Show("Resource ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating resource: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResourceID.Text))
            {
                MessageBox.Show("Please enter the Resource ID to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this resource? This will fail if there are transactions tied to it.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            string query = "DELETE FROM Resources WHERE ResourceID = @ID;";

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtResourceID.Text);
                        await conn.OpenAsync();
                        int rows = await cmd.ExecuteNonQueryAsync();
                        if (rows > 0)
                        {
                            MessageBox.Show("Resource deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            await LoadGridDataAsync();
                        }
                        else
                        {
                            MessageBox.Show("Resource ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting resource. It might be linked to existing transactions.\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard_Admin dashboard = new Dashboard_Admin();
            dashboard.Show();
            this.Hide();
        }

        private void ClearForm()
        {
            txtResourceID.Clear();
            txtResourceName.Clear();
            txtUnit.Clear();
            txtDescription.Clear();
            numQuantity.Value = 0;
            numThreshold.Value = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resource Transactions page coming soon!", "Info");
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}