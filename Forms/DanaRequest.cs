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
    public partial class DanaRequest : Form
    {
        public DanaRequest()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                    string.IsNullOrWhiteSpace(comboBox2.Text) ||
                    string.IsNullOrWhiteSpace(comboBox4.Text))
                {
                    MessageBox.Show("Please fill all the required fields.");
                    return;
                }

                // Check whether the donor exists
                DonorService donorService = new DonorService();

                if (donorService.GetDonorById(Convert.ToInt32(comboBox1.Text)) == null)
                {
                    MessageBox.Show("Invalid Donor ID.");
                    return;
                }

                // Create Dana Request object
                TempleManagementSystem.Model.DanaRequest request =
                    new TempleManagementSystem.Model.DanaRequest();

                request.DonorID = Convert.ToInt32(comboBox1.Text);
                request.DanaDate = dateTimePicker1.Value;
                request.DanaType = comboBox2.Text;
                request.MealType = comboBox4.Text;

                // Automatically set the status to Pending
                request.Status = "Pending";

                // Automatically set the request date to today
                request.RequestDate = DateTime.Now;

                DanaRequestService service = new DanaRequestService();
                service.SubmitRequest(request);

                MessageBox.Show("Dana Request Submitted Successfully!");

                // Clear controls
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;

                dateTimePicker1.Value = DateTime.Today;
                dateTimePicker2.Value = DateTime.Today;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please select a valid Donor ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DonorInsideDashboard donorInsideDashboard = new DonorInsideDashboard();
            donorInsideDashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDanaRequestAndMyDanaOffering myDanaRequest = new MyDanaRequestAndMyDanaOffering();
            myDanaRequest.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DanaRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
