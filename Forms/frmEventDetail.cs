using System;
using System.Windows.Forms;

namespace TempleManagementSystem.EventManagement
{
    public partial class frmEventDetail : Form
    {
        private readonly TempleEvent _event;

        public frmEventDetail(TempleEvent ev)
        {
            InitializeComponent();
            _event = ev;
        }

        private void frmEventDetail_Load(object sender, EventArgs e)
        {
            this.Text = _event.EventName;

            lblEventName.Text  = _event.EventName;
            lblType.Text       = _event.GetEventTypeName();
            lblDate.Text       = _event.EventDate.ToString("dddd, dd MMMM yyyy");
            lblTime.Text       = $"{_event.StartTime} – {_event.EndTime}";
            lblLocation.Text   = _event.Location;
            lblStatus.Text     = _event.Status;
            lblDescription.Text = string.IsNullOrEmpty(_event.Description)
                                  ? "No description provided."
                                  : _event.Description;

            // Show subclass-specific details panel
            pnlExtra.Controls.Clear();

            if (_event is CeremonyEvent c)
            {
                AddExtraRow("Monks attending", c.MonkCount.ToString());
                AddExtraRow("Offerings",        c.Offerings);
            }
            else if (_event is DhammaEvent d)
            {
                AddExtraRow("Speaker", d.Speaker);
                AddExtraRow("Topic",   d.Topic);
            }
            else if (_event is SpecialEvent s)
            {
                AddExtraRow("Sponsor",     s.Sponsor);
                AddExtraRow("Guest count", s.GuestCount.ToString());
            }

            // Status label colour
            if (_event.Status == "Completed")
                lblStatus.ForeColor = System.Drawing.Color.Green;
            else if (_event.Status == "Cancelled")
                lblStatus.ForeColor = System.Drawing.Color.Red;
            else
                lblStatus.ForeColor = System.Drawing.Color.DarkOrange;
        }

        private void AddExtraRow(string label, string value)
        {
            Label lbl = new Label
            {
                Text      = $"{label}: {value}",
                AutoSize  = true,
                Font      = new System.Drawing.Font("Segoe UI", 9f),
                ForeColor = System.Drawing.SystemColors.ControlText,
                Margin    = new Padding(0, 4, 0, 0)
            };
            pnlExtra.Controls.Add(lbl);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEventDetail_Load_1(object sender, EventArgs e)
        {

        }
    }
}
