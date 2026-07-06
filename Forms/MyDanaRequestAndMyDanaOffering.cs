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
    public partial class MyDanaRequestAndMyDanaOffering : Form
    {
        public MyDanaRequestAndMyDanaOffering()
        {
            InitializeComponent();
        }

        private void MyDanaRequestAndMyDanaOffering_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DonorInsideDashboard donorInsideDashboard = new DonorInsideDashboard();
            donorInsideDashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanaRequest danaRequest = new DanaRequest();
            danaRequest.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDanaRequestAndMyDanaOffering myDanaRequest = new MyDanaRequestAndMyDanaOffering();
            myDanaRequest.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyDanaRequestAndMyDanaOffering_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'templeManagementDBDataSet8.DanaRequests' table. You can move, or remove it, as needed.
            this.danaRequestsTableAdapter1.Fill(this.templeManagementDBDataSet8.DanaRequests);
            // TODO: This line of code loads data into the 'templeManagementDBDataSet7.DanaOfferings' table. You can move, or remove it, as needed.
            this.danaOfferingsTableAdapter1.Fill(this.templeManagementDBDataSet7.DanaOfferings);
            // TODO: This line of code loads data into the 'templeManagementDBDataSet4.DanaOfferings' table. You can move, or remove it, as needed.
            this.danaOfferingsTableAdapter.Fill(this.templeManagementDBDataSet4.DanaOfferings);
            // TODO: This line of code loads data into the 'templeManagementDBDataSet3.DanaRequests' table. You can move, or remove it, as needed.
            this.danaRequestsTableAdapter.Fill(this.templeManagementDBDataSet3.DanaRequests);

        }
    }
}
