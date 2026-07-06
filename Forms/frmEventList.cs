using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TempleManagmentSystem;

namespace TempleManagementSystem.EventManagement
{
    public partial class frmEventList : Form
    {
        private readonly EventManager _manager;

        public frmEventList(string connectionString)
        {
            InitializeComponent();
            _manager = new EventManager(connectionString);
        }

        private void frmEventList_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            try
            {
                LoadEvents();
            }
            catch
            {
                lblCount.Text = "DB not connected — UI preview mode";
            }
        }

        private void SetupDataGridView()
        {
            dgvEvents.AutoGenerateColumns = false;
            dgvEvents.Columns.Clear();
            dgvEvents.SelectionMode         = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.ReadOnly              = true;
            dgvEvents.AllowUserToAddRows    = false;
            dgvEvents.AllowUserToDeleteRows = false;

            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "EventID",   HeaderText = "ID",       DataPropertyName = "EventID",   Width = 40  });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "EventName", HeaderText = "Event",    DataPropertyName = "EventName", Width = 220 });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "EventDate", HeaderText = "Date",     DataPropertyName = "EventDate", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" } });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "StartTime", HeaderText = "Time",     DataPropertyName = "StartTime", Width = 80  });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "Location",  HeaderText = "Location", DataPropertyName = "Location",  Width = 140 });
            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status",    HeaderText = "Status",   DataPropertyName = "Status",    Width = 100 });
        }

        private void LoadEvents(List<TempleEvent> events = null)
        {
            try
            {
                List<TempleEvent> list = events ?? _manager.GetAllEvents();
                dgvEvents.DataSource = null;
                dgvEvents.DataSource = list;
                lblCount.Text = list.Count + " event(s) found";
                ColourStatusRows();
            }
            catch
            {
                lblCount.Text = "DB not connected — UI preview mode";
            }
        }

        private void ColourStatusRows()
        {
            foreach (DataGridViewRow row in dgvEvents.Rows)
            {
                string status = row.Cells["Status"].Value != null ? row.Cells["Status"].Value.ToString() : "";
                if (status == "Completed") row.DefaultCellStyle.BackColor = Color.FromArgb(230, 245, 238);
                if (status == "Cancelled") row.DefaultCellStyle.BackColor = Color.FromArgb(252, 235, 235);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditEvent form = new frmAddEditEvent(_manager);
            form.ShowDialog();
            LoadEvents();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TempleEvent selected = GetSelectedEvent();
            if (selected == null) return;
            frmAddEditEvent form = new frmAddEditEvent(_manager, selected);
            form.ShowDialog();
            LoadEvents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TempleEvent selected = GetSelectedEvent();
            if (selected == null) return;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete '" + selected.EventName + "'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool success = false;
                string message = "";
                try
                {
                    var result = _manager.DeleteEvent(selected.EventID);
                    success = result.Success;
                    message = result.Message;
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                MessageBox.Show(message, success ? "Success" : "Error",
                    MessageBoxButtons.OK,
                    success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (success) LoadEvents();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TempleEvent selected = GetSelectedEvent();
            if (selected == null) return;
            frmEventDetail form = new frmEventDetail(selected);
            form.ShowDialog();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void btnUpcoming_Click(object sender, EventArgs e)
        {
            try { LoadEvents(_manager.GetUpcomingEvents()); }
            catch { lblCount.Text = "DB not connected"; }
        }

        private void btnScheduled_Click(object sender, EventArgs e)
        {
            try { LoadEvents(_manager.GetEventsByStatus("Scheduled")); }
            catch { lblCount.Text = "DB not connected"; }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            try { LoadEvents(_manager.GetEventsByStatus("Completed")); }
            catch { lblCount.Text = "DB not connected"; }
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            try { LoadEvents(_manager.GetEventsByStatus("Cancelled")); }
            catch { lblCount.Text = "DB not connected"; }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            try
            {
                if (string.IsNullOrEmpty(keyword))
                    LoadEvents();
                else
                    LoadEvents(_manager.SearchEvents(keyword));
            }
            catch { }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Dashboard_Admin dashboard_Admin = new Dashboard_Admin();
            dashboard_Admin.Show();
            this.Hide();
        }

        private TempleEvent GetSelectedEvent()
        {
            if (dgvEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return dgvEvents.SelectedRows[0].DataBoundItem as TempleEvent;
        }
    }
}
