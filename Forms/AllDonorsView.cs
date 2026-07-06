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
using TempleManagmentSystem;

namespace TempleManagementSystem.Forms
{
    public partial class AllDonorsView : Form
    {
        public AllDonorsView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            try
            {
                // 1. Create the service
                TempleManagementSystem.Services.DonorService service = new TempleManagementSystem.Services.DonorService();

                // 2. Fetch the data and attach it to the grid
                dataGridView1.DataSource = service.GetAllDonors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading donors: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard_Admin dashboard_Admin = new Dashboard_Admin();
            dashboard_Admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllDanaofferingView allDanaoffering_View = new AllDanaofferingView();
            allDanaoffering_View.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DanaApproval danaApproval = new DanaApproval();
            danaApproval.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DonorService service = new DonorService();

            dataGridView1.DataSource = service.SearchDonor(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
