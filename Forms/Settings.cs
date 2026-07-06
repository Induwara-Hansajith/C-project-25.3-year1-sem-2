using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempleManagmentSystem
{
    public partial class Settings : UserControl
    {
        // ── Database Connection ──────────────────────────────────────────
        // Make sure this string exactly matches the one you use on your other pages!
        private readonly string _connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        // ── Class-Level UI Controls ──────────────────────────────────────
        // We declare these here so the Save button can "see" them to grab the text!
        private TextBox txtProfileName;
        private TextBox txtProfileEmail;
        private TextBox txtProfileAddress;
        private TextBox txtProfileContact;

        private Label lblTempleNameValue;
        private Label lblReminderValue;
        private Label lblThresholdValue;

        // Theme colors (extracted from Dashboard_Admin)
        private readonly Color _settingsNavyBg = Color.White;
        private readonly Color _settingsCardBg = Color.White;
        private readonly Color _settingsCardBorder = Color.LightGray;
        private readonly Color _settingsOrange = Color.FromArgb(210, 100, 10);
        private readonly Color _settingsTextLight = Color.Black;
        private readonly Color _settingsTextMuted = Color.DimGray;

        public Settings()
        {
            InitializeComponent();
            InitializeSettingsUI();

            // This tells the control to load the database information as soon as it opens!
            this.Load += async (s, e) => await LoadSettingsDataAsync();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.BackColor = _settingsNavyBg;
            this.Name = "Settings";
            this.ResumeLayout(false);
        }

        private void InitializeSettingsUI()
        {
            // ── Header bar ──────────────────────────────────────────────────
            Panel headerBar = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Top,
                Height = 54
            };
            Label lblSettingsTitle = new Label
            {
                Text = "  Settings",
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Padding = new Padding(16, 0, 0, 0)
            };
            headerBar.Controls.Add(lblSettingsTitle);
            this.Controls.Add(headerBar);

            // ── Scrollable content area ──────────────────────────────────────
            Panel scrollArea = new Panel
            {
                AutoScroll = true,
                BackColor = _settingsNavyBg,
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 20, 24, 20)
            };
            this.Controls.Add(scrollArea);

            const int padding = 24;
            const int gap = 18;
            int availW = 900 - padding * 2 - gap;
            int cardW = availW / 2;
            if (cardW < 380) cardW = 380;

            const int topMargin = 24;

            // ════════════════════════════════════════════════════════════════
            // ADMIN CARD (left)
            // ════════════════════════════════════════════════════════════════
            Panel adminCard = SettingsCard(padding, topMargin, cardW, 290);

            adminCard.Controls.Add(new Label
            {
                Text = "ADMIN",
                Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold),
                ForeColor = _settingsTextLight,
                Location = new Point(18, 14),
                AutoSize = true
            });

            // ── Manage Donor Accounts ────────────────────────────────────────
            adminCard.Controls.Add(SettingsSep(18, 40, cardW - 36));
            adminCard.Controls.Add(SettingsSectionLabel("Manage Donor Accounts", 18, 50));

            Button btnUpdateDonor = SettingsItemBtn("Update", 18, 72, 110);
            btnUpdateDonor.Click += BtnUpdateDonor_Click;
            adminCard.Controls.Add(btnUpdateDonor);

            Button btnDeleteDonor = SettingsItemBtn("Delete", 138, 72, 110);
            btnDeleteDonor.Click += BtnDeleteDonor_Click;
            adminCard.Controls.Add(btnDeleteDonor);

            // ── Manage Visitor Accounts ──────────────────────────────────────
            adminCard.Controls.Add(SettingsSep(18, 116, cardW - 36));
            adminCard.Controls.Add(SettingsSectionLabel("Manage Visitor Accounts", 18, 126));

            Button btnViewVisitor = SettingsItemBtn("View", 18, 148, 110);
            btnViewVisitor.Click += BtnViewVisitor_Click;
            adminCard.Controls.Add(btnViewVisitor);

            Button btnUpdateVisitor = SettingsItemBtn("Update", 138, 148, 110);
            btnUpdateVisitor.Click += BtnUpdateVisitor_Click;
            adminCard.Controls.Add(btnUpdateVisitor);

            Button btnDeleteVisitor = SettingsItemBtn("Delete", 258, 148, 110);
            btnDeleteVisitor.Click += BtnDeleteVisitor_Click;
            adminCard.Controls.Add(btnDeleteVisitor);

            // ── System Configuration ─────────────────────────────────────────
            adminCard.Controls.Add(SettingsSep(18, 192, cardW - 36));
            adminCard.Controls.Add(SettingsSectionLabel("System Configuration", 18, 202));

            // Dynamic Labels that will be filled by the Database
            lblTempleNameValue = new Label { Text = "Temple Name: Loading...", Font = new Font("Microsoft Sans Serif", 9F), ForeColor = _settingsTextMuted, Location = new Point(28, 222), AutoSize = true };
            lblReminderValue = new Label { Text = "Reminder Days Before: Loading...", Font = new Font("Microsoft Sans Serif", 9F), ForeColor = _settingsTextMuted, Location = new Point(28, 244), AutoSize = true };
            lblThresholdValue = new Label { Text = "Low Stock Threshold: Loading...", Font = new Font("Microsoft Sans Serif", 9F), ForeColor = _settingsTextMuted, Location = new Point(28, 266), AutoSize = true };

            adminCard.Controls.Add(lblTempleNameValue);
            adminCard.Controls.Add(lblReminderValue);
            adminCard.Controls.Add(lblThresholdValue);

            scrollArea.Controls.Add(adminCard);

            // ════════════════════════════════════════════════════════════════
            // DONOR CARD (right)
            // ════════════════════════════════════════════════════════════════
            Panel donorCard = SettingsCard(padding + cardW + gap, topMargin, cardW, 390);

            donorCard.Controls.Add(new Label
            {
                Text = "DONOR",
                Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold),
                ForeColor = _settingsTextLight,
                Location = new Point(18, 14),
                AutoSize = true
            });

            // ── Update Profile ───────────────────────────────────────────────
            donorCard.Controls.Add(SettingsSep(18, 40, cardW - 36));
            donorCard.Controls.Add(SettingsSectionLabel("Update Profile", 18, 50));

            // Explicitly creating TextBoxes so we can query them later
            int fieldY = 72;

            // Name Field
            donorCard.Controls.Add(new Label { Text = "Name", Font = new Font("Microsoft Sans Serif", 9F), ForeColor = _settingsTextLight, Location = new Point(18, fieldY + 4), Size = new Size(120, 22) });
            txtProfileName = new TextBox { Location = new Point(145, fieldY), Size = new Size(cardW - 175, 24), BackColor = Color.White, ForeColor = _settingsTextLight, BorderStyle = BorderStyle.FixedSingle, Font = new Font("Microsoft Sans Serif", 9F) };
            donorCard.Controls.Add(txtProfileName);
            fieldY += 34;

            // Email Field
            donorCard.Controls.Add(new Label { Text = "Email", Font = new Font("Microsoft Sans Serif", 9F), ForeColor = _settingsTextLight, Location = new Point(18, fieldY + 4), Size = new Size(120, 22) });
            txtProfileEmail = new TextBox { Location = new Point(145, fieldY), Size = new Size(cardW - 175, 24), BackColor = Color.White, ForeColor = _settingsTextLight, BorderStyle = BorderStyle.FixedSingle, Font = new Font("Microsoft Sans Serif", 9F) };
            donorCard.Controls.Add(txtProfileEmail);
            fieldY += 34;

            // Address Field
            donorCard.Controls.Add(new Label { Text = "Address", Font = new Font("Microsoft Sans Serif", 9F), ForeColor = _settingsTextLight, Location = new Point(18, fieldY + 4), Size = new Size(120, 22) });
            txtProfileAddress = new TextBox { Location = new Point(145, fieldY), Size = new Size(cardW - 175, 24), BackColor = Color.White, ForeColor = _settingsTextLight, BorderStyle = BorderStyle.FixedSingle, Font = new Font("Microsoft Sans Serif", 9F) };
            donorCard.Controls.Add(txtProfileAddress);
            fieldY += 34;

            // Contact Number Field
            donorCard.Controls.Add(new Label { Text = "Contact Number", Font = new Font("Microsoft Sans Serif", 9F), ForeColor = _settingsTextLight, Location = new Point(18, fieldY + 4), Size = new Size(120, 22) });
            txtProfileContact = new TextBox { Location = new Point(145, fieldY), Size = new Size(cardW - 175, 24), BackColor = Color.White, ForeColor = _settingsTextLight, BorderStyle = BorderStyle.FixedSingle, Font = new Font("Microsoft Sans Serif", 9F) };
            donorCard.Controls.Add(txtProfileContact);
            fieldY += 34;

            Button btnSaveProfile = new Button
            {
                Text = "Save Changes",
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = _settingsOrange,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(145, fieldY + 8),
                Size = new Size(130, 30),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btnSaveProfile.FlatAppearance.BorderSize = 0;
            btnSaveProfile.Click += BtnSaveProfile_Click;
            donorCard.Controls.Add(btnSaveProfile);

            // ── Security ─────────────────────────────────────────────────────
            int secY = fieldY + 54;
            donorCard.Controls.Add(SettingsSep(18, secY, cardW - 36));
            donorCard.Controls.Add(SettingsSectionLabel("Security", 18, secY + 10));

            Button btnChangePassword = SettingsItemBtn("Change Password", 18, secY + 34, 150);
            btnChangePassword.Click += BtnChangePassword_Click;
            donorCard.Controls.Add(btnChangePassword);

            Button btnChangeProfileImage = SettingsItemBtn("Change Profile Image", 178, secY + 34, 170);
            btnChangeProfileImage.Click += BtnChangeProfileImage_Click;
            donorCard.Controls.Add(btnChangeProfileImage);

            donorCard.Height = secY + 80;

            scrollArea.Controls.Add(donorCard);

            this.Resize += (s, e) =>
            {
                int newAvailW = scrollArea.Width - padding * 2 - gap;
                int newCardW = newAvailW / 2;
                if (newCardW < 380) newCardW = 380;

                adminCard.Width = newCardW;
                donorCard.Width = newCardW;
                donorCard.Location = new Point(padding + newCardW + gap, topMargin);

                adminCard.Invalidate();
                donorCard.Invalidate();
            };
        }

        // ── Settings helpers ─────────────────────────────────────────────────
        private Panel SettingsCard(int x, int y, int w, int h)
        {
            Panel card = new Panel { BackColor = _settingsCardBg, Location = new Point(x, y), Size = new Size(w, h), BorderStyle = BorderStyle.None };
            card.Paint += SettingsCard_Paint;
            return card;
        }

        private void SettingsCard_Paint(object sender, PaintEventArgs e)
        {
            Panel card = (Panel)sender;
            using (System.Drawing.Pen pen = new System.Drawing.Pen(_settingsCardBorder, 1))
                e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
        }

        private Label SettingsSectionLabel(string text, int x, int y)
        {
            return new Label { Text = text, Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold), ForeColor = _settingsTextMuted, Location = new Point(x, y), AutoSize = true };
        }

        private Button SettingsItemBtn(string text, int x, int y, int w)
        {
            Button btn = new Button { Text = text, Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold), ForeColor = Color.White, BackColor = Color.FromArgb(130, 30, 10), FlatStyle = FlatStyle.Flat, Location = new Point(x, y), Size = new Size(w, 30), Cursor = Cursors.Hand, UseVisualStyleBackColor = false };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private Panel SettingsSep(int x, int y, int w)
        {
            return new Panel { BackColor = _settingsCardBorder, Location = new Point(x, y), Size = new Size(w, 1) };
        }

        // ── Database Fetching Method ────────────────────────────────────────
        public async Task LoadSettingsDataAsync()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();

                    // 1. Fetch System Settings from the database
                    string sysQuery = "SELECT SettingKey, SettingValue FROM SystemSettings";
                    using (SqlCommand cmd = new SqlCommand(sysQuery, conn))
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string key = reader["SettingKey"].ToString();
                            string val = reader["SettingValue"].ToString();

                            // Populate the Admin Card dynamically
                            if (key == "TempleName") lblTempleNameValue.Text = "Temple Name: " + val;
                            else if (key == "ReminderDaysBefore") lblReminderValue.Text = "Reminder Days Before: " + val;
                            else if (key == "LowStockThreshold") lblThresholdValue.Text = "Low Stock Threshold: " + val;
                        }
                    }

                    // 2. Fetch User Profile Data (Assuming UserID 1 is logged in for now)
                    string userQuery = "SELECT FullName, Email, Address, ContactNumber FROM Users WHERE UserID = 1";
                    using (SqlCommand cmd = new SqlCommand(userQuery, conn))
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            // Fill the Donor Card TextBoxes dynamically
                            txtProfileName.Text = reader["FullName"]?.ToString();
                            txtProfileEmail.Text = reader["Email"]?.ToString();
                            txtProfileAddress.Text = reader["Address"]?.ToString();
                            txtProfileContact.Text = reader["ContactNumber"]?.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not connect to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Save Profile Database Method ─────────────────────────────────────
        private async void BtnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();

                    // The SQL Query to actually update the user's information
                    string updateQuery = @"
                        UPDATE Users 
                        SET FullName = @name, 
                            Email = @email, 
                            Address = @address, 
                            ContactNumber = @contact 
                        WHERE UserID = 1"; // Assuming User 1 is logged in

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Attach the text box contents to our SQL query parameters safely
                        cmd.Parameters.AddWithValue("@name", txtProfileName.Text);
                        cmd.Parameters.AddWithValue("@email", txtProfileEmail.Text);
                        cmd.Parameters.AddWithValue("@address", txtProfileAddress.Text);
                        cmd.Parameters.AddWithValue("@contact", txtProfileContact.Text);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                MessageBox.Show("Profile updated successfully in the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Other Button Clicks ──────────────────────────────────────────────
        private void BtnUpdateDonor_Click(object sender, EventArgs e)
        {
            TempleManagementSystem.Forms.AllDonorsView frm = new TempleManagementSystem.Forms.AllDonorsView();
            frm.Show();
            Form parent = this.FindForm();
            if (parent != null) parent.Hide();
        }

        private void BtnDeleteDonor_Click(object sender, EventArgs e)
        {
            TempleManagementSystem.Forms.AllDonorsView frm = new TempleManagementSystem.Forms.AllDonorsView();
            frm.Show();
            Form parent = this.FindForm();
            if (parent != null) parent.Hide();
        }

        private void BtnViewVisitor_Click(object sender, EventArgs e) { MessageBox.Show("Visitors module coming soon."); }
        private void BtnUpdateVisitor_Click(object sender, EventArgs e) { MessageBox.Show("Visitors module coming soon."); }
        private void BtnDeleteVisitor_Click(object sender, EventArgs e) { MessageBox.Show("Visitors module coming soon."); }
        private void BtnChangePassword_Click(object sender, EventArgs e) { MessageBox.Show("Password change feature coming soon."); }
        private void BtnChangeProfileImage_Click(object sender, EventArgs e) { MessageBox.Show("Profile image change coming soon."); }
    }
}