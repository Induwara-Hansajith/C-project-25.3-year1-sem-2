namespace TempleManagementSystem.EventManagement
{
    partial class frmAddEditEvent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventType = new System.Windows.Forms.Label();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();

            // Subclass panels
            this.pnlCeremony = new System.Windows.Forms.Panel();
            this.lblMonkCount = new System.Windows.Forms.Label();
            this.txtMonkCount = new System.Windows.Forms.TextBox();
            this.lblOfferings = new System.Windows.Forms.Label();
            this.txtOfferings = new System.Windows.Forms.TextBox();

            this.pnlDhamma = new System.Windows.Forms.Panel();
            this.lblSpeaker = new System.Windows.Forms.Label();
            this.txtSpeaker = new System.Windows.Forms.TextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();

            this.pnlSpecial = new System.Windows.Forms.Panel();
            this.lblSponsor = new System.Windows.Forms.Label();
            this.txtSponsor = new System.Windows.Forms.TextBox();
            this.lblGuestCount = new System.Windows.Forms.Label();
            this.txtGuestCount = new System.Windows.Forms.TextBox();

            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();

            // ── Form ─────────────────────────────────────────────────────────
            this.Text = "Add New Event";
            this.Size = new System.Drawing.Size(680, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // ── Header ───────────────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(100, 0, 0);
            this.pnlHeader.Controls.Add(lblTitle);

            this.lblTitle.Text = "Add New Event";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(680, 70);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Body Panel ───────────────────────────────────────────────────
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 16, 24, 0);

            // Row 1: Event Name + Event Type
            StyleLabel(lblEventName, "Event Name *", 24, 16);
            StyleInput(txtEventName, 24, 36, 360);
            StyleLabel(lblEventType, "Event Type *", 404, 16);
            StyleInput(cmbEventType, 404, 36, 220);

            // Row 2: Date + Start + End
            StyleLabel(lblDate, "Date *", 24, 80);
            dtpEventDate.Location = new System.Drawing.Point(24, 100);
            dtpEventDate.Size = new System.Drawing.Size(180, 28);
            dtpEventDate.Font = new System.Drawing.Font("Segoe UI", 10f);
            dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            StyleLabel(lblStartTime, "Start Time (HH:mm)", 220, 80);
            StyleInput(txtStartTime, 220, 100, 140);

            StyleLabel(lblEndTime, "End Time (HH:mm)", 380, 80);
            StyleInput(txtEndTime, 380, 100, 140);

            StyleLabel(lblStatus, "Status", 540, 80);
            StyleInput(cmbStatus, 540, 100, 120);

            // Row 3: Location
            StyleLabel(lblLocation, "Location", 24, 146);
            StyleInput(txtLocation, 24, 166, 636);

            // Row 4: Description
            StyleLabel(lblDescription, "Description", 24, 210);
            txtDescription.Location = new System.Drawing.Point(24, 230);
            txtDescription.Size = new System.Drawing.Size(636, 72);
            txtDescription.Multiline = true;
            txtDescription.Font = new System.Drawing.Font("Segoe UI", 10f);
            txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ── Ceremony subpanel ─────────────────────────────────────────────
            this.pnlCeremony.Location = new System.Drawing.Point(24, 316);
            this.pnlCeremony.Size = new System.Drawing.Size(636, 80);
            this.pnlCeremony.BackColor = System.Drawing.Color.FromArgb(255, 240, 240);
            this.pnlCeremony.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            StyleLabel(lblMonkCount, "Monks Attending", 10, 8);
            StyleInput(txtMonkCount, 10, 28, 140);
            StyleLabel(lblOfferings, "Offerings", 170, 8);
            StyleInput(txtOfferings, 170, 28, 456);
            pnlCeremony.Controls.AddRange(new System.Windows.Forms.Control[]
                { lblMonkCount, txtMonkCount, lblOfferings, txtOfferings });

            // ── Dhamma subpanel ───────────────────────────────────────────────
            this.pnlDhamma.Location = new System.Drawing.Point(24, 316);
            this.pnlDhamma.Size = new System.Drawing.Size(636, 80);
            this.pnlDhamma.BackColor = System.Drawing.Color.FromArgb(240, 255, 245);
            this.pnlDhamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDhamma.Visible = false;

            StyleLabel(lblSpeaker, "Speaker", 10, 8);
            StyleInput(txtSpeaker, 10, 28, 300);
            StyleLabel(lblTopic, "Topic", 326, 8);
            StyleInput(txtTopic, 326, 28, 300);
            pnlDhamma.Controls.AddRange(new System.Windows.Forms.Control[]
                { lblSpeaker, txtSpeaker, lblTopic, txtTopic });

            // ── Special subpanel ──────────────────────────────────────────────
            this.pnlSpecial.Location = new System.Drawing.Point(24, 316);
            this.pnlSpecial.Size = new System.Drawing.Size(636, 80);
            this.pnlSpecial.BackColor = System.Drawing.Color.FromArgb(255, 248, 235);
            this.pnlSpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpecial.Visible = false;

            StyleLabel(lblSponsor, "Sponsor", 10, 8);
            StyleInput(txtSponsor, 10, 28, 380);
            StyleLabel(lblGuestCount, "Guest Count", 406, 8);
            StyleInput(txtGuestCount, 406, 28, 220);
            pnlSpecial.Controls.AddRange(new System.Windows.Forms.Control[]
                { lblSponsor, txtSponsor, lblGuestCount, txtGuestCount });

            // Add all to body
            this.pnlBody.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblEventName, txtEventName, lblEventType, cmbEventType,
                lblDate, dtpEventDate, lblStartTime, txtStartTime,
                lblEndTime, txtEndTime, lblStatus, cmbStatus,
                lblLocation, txtLocation,
                lblDescription, txtDescription,
                pnlCeremony, pnlDhamma, pnlSpecial
            });

            // ── Bottom Buttons ────────────────────────────────────────────────
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height = 60;
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(100, 0, 0);
            this.pnlBottom.Controls.AddRange(new System.Windows.Forms.Control[] { btnSave, btnCancel });

            this.btnSave.Text = "Save Event";
            this.btnSave.Size = new System.Drawing.Size(160, 38);
            this.btnSave.Location = new System.Drawing.Point(320, 11);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.Location = new System.Drawing.Point(496, 11);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(80, 0, 0);

            // Safely initializing the buttons without using an inline loop that crashes the designer!
            StyleButton(this.btnSave, true);
            StyleButton(this.btnCancel, false);

            // ── Wire events ──────────────────────────────────────────────────
            this.cmbEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEventType_SelectedIndexChanged);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.Load += new System.EventHandler(this.frmAddEditEvent_Load);

            // ── Add to form ──────────────────────────────────────────────────
            this.Controls.AddRange(new System.Windows.Forms.Control[]
                { pnlBody, pnlBottom, pnlHeader });

            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // --- HELPER METHODS MOVED OUTSIDE INITIALIZECOMPONENT ---

        private void StyleLabel(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            System.Drawing.Font lf = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            System.Drawing.Color lc = System.Drawing.Color.FromArgb(80, 0, 0);

            lbl.Text = text;
            lbl.Font = lf;
            lbl.ForeColor = lc;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.AutoSize = true;
        }

        private void StyleInput(System.Windows.Forms.Control ctl, int x, int y, int w, int h = 28)
        {
            ctl.Location = new System.Drawing.Point(x, y);
            ctl.Size = new System.Drawing.Size(w, h);
            ctl.Font = new System.Drawing.Font("Segoe UI", 10f);

            if (ctl is System.Windows.Forms.TextBox tb)
                tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            if (ctl is System.Windows.Forms.ComboBox cb)
                cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void StyleButton(System.Windows.Forms.Button btn, bool isSaveButton)
        {
            btn.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;

            if (isSaveButton)
            {
                btn.BackColor = System.Drawing.Color.White;
                btn.ForeColor = System.Drawing.Color.FromArgb(100, 0, 0);
            }
            else
            {
                btn.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
                btn.ForeColor = System.Drawing.Color.White;
            }
        }

        private System.Windows.Forms.Panel pnlHeader, pnlBody, pnlBottom;
        private System.Windows.Forms.Panel pnlCeremony, pnlDhamma, pnlSpecial;
        private System.Windows.Forms.Label lblTitle, lblEventName, lblEventType, lblDate,
                                                 lblStartTime, lblEndTime, lblLocation, lblStatus,
                                                 lblDescription, lblMonkCount, lblOfferings,
                                                 lblSpeaker, lblTopic, lblSponsor, lblGuestCount;
        private System.Windows.Forms.TextBox txtEventName, txtStartTime, txtEndTime,
                                                 txtLocation, txtDescription, txtMonkCount,
                                                 txtOfferings, txtSpeaker, txtTopic,
                                                 txtSponsor, txtGuestCount;
        private System.Windows.Forms.ComboBox cmbEventType, cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button btnSave, btnCancel;
    }
}