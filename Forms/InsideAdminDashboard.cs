using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempleManagmentSystem;

namespace TempleManagementSystem.Forms
{
    public partial class InsideAdminDashboard : Form
    {
        public InsideAdminDashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard_Admin dashboardAdmin = new Dashboard_Admin();
            dashboardAdmin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllDanaofferingView allDanaofferingView = new AllDanaofferingView();
            allDanaofferingView.Show();
            this.Hide();
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

        private void button7_Click(object sender, EventArgs e)
        {
            DanaApproval danaApproval = new DanaApproval();
            danaApproval.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AllDonorsView allDonorsView = new AllDonorsView();
            allDonorsView.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AllDanaofferingView allDanaofferingView = new AllDanaofferingView();
            allDanaofferingView.Show();
            this.Hide();
        }

        private void InsideAdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
