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
    public partial class AllDanaofferingView : Form
    {
        public AllDanaofferingView()
        {
            InitializeComponent();
        }

        private void AllDanaofferingView_Load(object sender, EventArgs e)
        {
            // Set the ComboBox to "All" by default when the page opens.
            // This will automatically trigger comboBox1_SelectedIndexChanged and load the table.
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                // Fallback just in case the items aren't set in the designer
                GetAllDanaOfferings();
            }
        }

        private void HideUnwantedColumns()
        {
            // Check if the column exists first so the program doesn't crash, then hide it
            if (dataGridView2.Columns["EventID"] != null)
                dataGridView2.Columns["EventID"].Visible = false;

            if (dataGridView2.Columns["CreatedDate"] != null)
                dataGridView2.Columns["CreatedDate"].Visible = false;

            if (dataGridView2.Columns["NumberOfPeople"] != null)
                dataGridView2.Columns["NumberOfPeople"].Visible = false;

            if (dataGridView2.Columns["Description"] != null)
                dataGridView2.Columns["Description"].Visible = false;

            // Tip: You can add more columns here if you want to hide things like "DonorID"
        }

        private void GetAllDanaOfferings()
        {
            DanaOfferingService service = new DanaOfferingService();
            dataGridView2.DataSource = service.GetAllDanaOfferings();
            HideUnwantedColumns();
        }

        private void GetUpcomingDanaOfferings()
        {
            DanaOfferingService service = new DanaOfferingService();
            dataGridView2.DataSource = service.GetUpcomingDanaOfferings();
            HideUnwantedColumns();
        }

        private void GetCompletedDanaOfferings()
        {
            DanaOfferingService service = new DanaOfferingService();
            dataGridView2.DataSource = service.GetCompletedDanaOfferings();
            HideUnwantedColumns();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "All":
                    GetAllDanaOfferings();
                    break;
                case "Upcoming":
                    GetUpcomingDanaOfferings();
                    break;
                case "Completed":
                    GetCompletedDanaOfferings();
                    break;
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllDonorsView allDonorsView = new AllDonorsView();
            allDonorsView.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DanaApproval danaApproval = new DanaApproval();
            danaApproval.Show();
            this.Hide();
        }

        //private void AllDanaofferingView_Load(object sender, EventArgs e)
        //{

        //}
    }
}
