using System;
using System.Windows.Forms;

namespace TempleManagementSystem.EventManagement
{
    public partial class frmAddEditEvent : Form
    {
        private readonly EventManager _manager;
        private TempleEvent _existingEvent; // null = Add mode, not null = Edit mode
        private bool _isEditMode => _existingEvent != null;

        // ── CONSTRUCTORS ─────────────────────────────────────────────────────

        // Add mode
        public frmAddEditEvent(EventManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        // Edit mode
        public frmAddEditEvent(EventManager manager, TempleEvent existing)
        {
            InitializeComponent();
            _manager       = manager;
            _existingEvent = existing;
        }

        // ── FORM LOAD ────────────────────────────────────────────────────────

        private void frmAddEditEvent_Load(object sender, EventArgs e)
        {
            // Populate event type dropdown
            cmbEventType.Items.Clear();
            cmbEventType.Items.Add(new { Text = "Religious Ceremony", Value = 1 });
            cmbEventType.Items.Add(new { Text = "Meditation Program",  Value = 2 });
            cmbEventType.Items.Add(new { Text = "Dana Program",        Value = 3 });
            cmbEventType.Items.Add(new { Text = "Special Event",       Value = 4 });
            cmbEventType.Items.Add(new { Text = "Dhamma Sermon",       Value = 5 });
            cmbEventType.DisplayMember = "Text";
            cmbEventType.ValueMember   = "Value";
            cmbEventType.SelectedIndex = 0;

            // Status dropdown
            cmbStatus.Items.AddRange(new[] { "Scheduled", "Completed", "Cancelled" });
            cmbStatus.SelectedIndex = 0;

            this.Text = _isEditMode ? "Edit Event" : "Add New Event";
            btnSave.Text = _isEditMode ? "Update Event" : "Save Event";

            if (_isEditMode) PopulateFields();

            ToggleSubclassFields();
        }

        // ── POPULATE (edit mode) ─────────────────────────────────────────────

        private void PopulateFields()
        {
            txtEventName.Text           = _existingEvent.EventName;
            dtpEventDate.Value          = _existingEvent.EventDate;
            txtStartTime.Text           = _existingEvent.StartTime?.ToString(@"hh\:mm") ?? "";
            txtEndTime.Text             = _existingEvent.EndTime?.ToString(@"hh\:mm")   ?? "";
            txtLocation.Text            = _existingEvent.Location;
            txtDescription.Text         = _existingEvent.Description;
            cmbStatus.SelectedItem      = _existingEvent.Status;

            // Set event type dropdown
            for (int i = 0; i < cmbEventType.Items.Count; i++)
            {
                dynamic item = cmbEventType.Items[i];
                if (item.Value == _existingEvent.EventTypeID)
                {
                    cmbEventType.SelectedIndex = i;
                    break;
                }
            }

            // Subclass-specific fields
            if (_existingEvent is CeremonyEvent c)
            {
                txtMonkCount.Text = c.MonkCount.ToString();
                txtOfferings.Text = c.Offerings;
            }
            else if (_existingEvent is DhammaEvent d)
            {
                txtSpeaker.Text = d.Speaker;
                txtTopic.Text   = d.Topic;
            }
            else if (_existingEvent is SpecialEvent s)
            {
                txtSponsor.Text    = s.Sponsor;
                txtGuestCount.Text = s.GuestCount.ToString();
            }
        }

        // ── TOGGLE SUBCLASS PANELS ───────────────────────────────────────────

        private void cmbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleSubclassFields();
        }

        private void ToggleSubclassFields()
        {
            dynamic selected = cmbEventType.SelectedItem;
            if (selected == null) return;

            int typeID = selected.Value;

            pnlCeremony.Visible = typeID == 1;
            pnlDhamma.Visible   = typeID == 5;
            pnlSpecial.Visible  = typeID == 4;
        }

        // ── SAVE ─────────────────────────────────────────────────────────────

        private void btnSave_Click(object sender, EventArgs e)
        {
            TempleEvent ev = BuildEventFromForm();
            if (ev == null) return;

            EventResult result;

            if (_isEditMode)
            {
                ev.EventID = _existingEvent.EventID;
                result     = _manager.UpdateEvent(ev);
            }
            else
            {
                result = _manager.AddEvent(ev);
            }

            MessageBox.Show(result.Message,
                result.Success ? "Success" : "Error",
                MessageBoxButtons.OK,
                result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (result.Success)
                this.DialogResult = DialogResult.OK;
        }

        // ── BUILD EVENT FROM FORM ─────────────────────────────────────────────

        private TempleEvent BuildEventFromForm()
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtEventName.Text))
            {
                MessageBox.Show("Event name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEventName.Focus();
                return null;
            }

            dynamic selected = cmbEventType.SelectedItem;
            int typeID = selected.Value;

            TempleEvent ev;

            if (typeID == 1) // Ceremony
            {
                ev = new CeremonyEvent
                {
                    MonkCount = int.TryParse(txtMonkCount.Text, out int mc) ? mc : 0,
                    Offerings = txtOfferings.Text.Trim()
                };
            }
            else if (typeID == 5) // Dhamma
            {
                ev = new DhammaEvent
                {
                    Speaker = txtSpeaker.Text.Trim(),
                    Topic   = txtTopic.Text.Trim()
                };
            }
            else if (typeID == 4) // Special
            {
                ev = new SpecialEvent
                {
                    Sponsor    = txtSponsor.Text.Trim(),
                    GuestCount = int.TryParse(txtGuestCount.Text, out int gc) ? gc : 0
                };
            }
            else
            {
                ev = new CeremonyEvent();
            }

            // Shared base fields
            ev.EventTypeID  = typeID;
            ev.EventName    = txtEventName.Text.Trim();
            ev.EventDate    = dtpEventDate.Value.Date;
            ev.StartTime    = TimeSpan.TryParse(txtStartTime.Text, out TimeSpan st) ? (TimeSpan?)st : null;
            ev.EndTime      = TimeSpan.TryParse(txtEndTime.Text,   out TimeSpan et) ? (TimeSpan?)et : null;
            ev.Location     = txtLocation.Text.Trim();
            ev.Description  = txtDescription.Text.Trim();
            ev.Status       = cmbStatus.SelectedItem?.ToString() ?? "Scheduled";

            return ev;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
