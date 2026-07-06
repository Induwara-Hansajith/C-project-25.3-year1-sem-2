using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempleManagementSystem.EventManagement;
using TempleManagementSystem.Forms;

namespace TempleManagmentSystem
{
    public partial class Donor_dashboard : Form
    {
        public Donor_dashboard()
        {
            InitializeComponent();
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Donor_dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'templeManagementDBDataSet2.DanaOfferings' table. You can move, or remove it, as needed.
            this.danaOfferingsTableAdapter.Fill(this.templeManagementDBDataSet2.DanaOfferings);
            // TODO: This line of code loads data into the 'templeManagementDBDataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.templeManagementDBDataSet.Events);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eventsTableAdapter.FillBy(this.templeManagementDBDataSet.Events);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.danaOfferingsTableAdapter.FillBy(this.templeManagementDBDataSet2.DanaOfferings);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lblTotalEvents_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DonorInsideDashboard donorInsideDashboard = new DonorInsideDashboard();
            donorInsideDashboard.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new TempleManagementSystem.EventManagement.frmEventList(DBConfig.ConnectionString).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Donor_dashboard donorDashboard = new Donor_dashboard();
            donorDashboard.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
