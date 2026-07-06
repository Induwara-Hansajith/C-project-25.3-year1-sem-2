using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using templemng_Demika;

namespace TempleManagmentSystem
{
    public partial class AuthForm : Form
    {
        // ─── Database Connection ───
        private readonly string _connectionString = @"Data Source=HANSAJITH\SQLEXPRESS;Initial Catalog=TempleManagementDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        // ─── Theme Colors ───
        private readonly Color _maroon = Color.FromArgb(80, 0, 0);
        private readonly Color _white = Color.White;
        private readonly Color _textDark = Color.FromArgb(40, 40, 40);

        // ─── UI Panels ───
        private Panel pnlRightBase;
        private Panel pnlLogin;
        private Panel pnlRegister;
        private Panel pnlReset;

        // ─── Login Controls ───
        private TextBox txtLogUser;
        private TextBox txtLogPass;

        // ─── Register Controls ───
        private TextBox txtRegFull;
        private TextBox txtRegUser;
        private TextBox txtRegEmail;
        private TextBox txtRegPass;
        private TextBox txtRegContact;
        private ComboBox cmbRegRole;

        // ─── Reset Password Controls ───
        private TextBox txtResetPhone;
        private TextBox txtResetNewPass;

        public AuthForm()
        {
            InitializeComponent();
            BuildBeautifulUI();
            //this.Load += async (s, e) => await LoadRolesAsync();
        }

        // ==========================================
        // 1. UI GENERATION
        // ==========================================
        private void BuildBeautifulUI()
        {
            this.Size = new Size(850, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = _white;

            // ─── LEFT SIDEBAR ───
            Panel pnlLeft = new Panel { Dock = DockStyle.Left, Width = 300, BackColor = _maroon };
            pnlLeft.Controls.Add(new Label { Text = "Temple\nManagement\nSystem", Font = new Font("Segoe UI", 22F, FontStyle.Bold), ForeColor = _white, AutoSize = true, Location = new Point(30, 150) });
            pnlLeft.Controls.Add(new Label { Text = "Welcome to the portal.\nPlease log in or register.", Font = new Font("Segoe UI", 10F), ForeColor = Color.LightGray, AutoSize = true, Location = new Point(34, 280) });
            this.Controls.Add(pnlLeft);

            pnlRightBase = new Panel { Location = new Point(300, 0), Size = new Size(550, 550), BackColor = _white };
            this.Controls.Add(pnlRightBase);

            // ─── LOGIN PANEL ───
            pnlLogin = new Panel { Dock = DockStyle.Fill, Visible = true };
            pnlLogin.Controls.Add(new Label { Text = "Sign In", Font = new Font("Segoe UI", 24F, FontStyle.Bold), ForeColor = _maroon, AutoSize = true, Location = new Point(60, 60) });

            pnlLogin.Controls.Add(CreateLabel("Username", 65, 140));
            txtLogUser = CreateTextBox(65, 165);
            pnlLogin.Controls.Add(txtLogUser);

            pnlLogin.Controls.Add(CreateLabel("Password", 65, 215));
            txtLogPass = CreateTextBox(65, 240, true);
            pnlLogin.Controls.Add(txtLogPass);

            Button btnLogin = CreateButton("LOGIN", 65, 300);
            btnLogin.Click += BtnLogin_Click;
            pnlLogin.Controls.Add(btnLogin);

            Label lblGoToReg = new Label { Text = "Don't have an account? Register here.", ForeColor = _maroon, Font = new Font("Segoe UI", 9F, FontStyle.Underline), Cursor = Cursors.Hand, AutoSize = true, Location = new Point(65, 360) };
            lblGoToReg.Click += (s, e) => SwitchPanel(pnlRegister);
            pnlLogin.Controls.Add(lblGoToReg);

            Label lblGoToReset = new Label { Text = "Forgot Password?", ForeColor = _maroon, Font = new Font("Segoe UI", 9F, FontStyle.Underline), Cursor = Cursors.Hand, AutoSize = true, Location = new Point(340, 360) };
            lblGoToReset.Click += (s, e) => SwitchPanel(pnlReset);
            pnlLogin.Controls.Add(lblGoToReset);

            // --- NEW GUEST BUTTON ---
            Button btnGuest = CreateButton("CONTINUE AS GUEST", 65, 410);
            btnGuest.BackColor = Color.DimGray; // A sleek gray to show it's a secondary option
            btnGuest.Click += BtnGuest_Click;
            pnlLogin.Controls.Add(btnGuest);

            // ─── REGISTER PANEL ───
            pnlRegister = new Panel { Dock = DockStyle.Fill, Visible = false };
            pnlRegister.Controls.Add(new Label { Text = "Create Account", Font = new Font("Segoe UI", 20F, FontStyle.Bold), ForeColor = _maroon, AutoSize = true, Location = new Point(40, 30) });

            pnlRegister.Controls.Add(CreateLabel("Full Name", 45, 90));
            txtRegFull = CreateTextBox(45, 110, false, 200);
            pnlRegister.Controls.Add(txtRegFull);

            pnlRegister.Controls.Add(CreateLabel("Username", 275, 90));
            txtRegUser = CreateTextBox(275, 110, false, 200);
            pnlRegister.Controls.Add(txtRegUser);

            pnlRegister.Controls.Add(CreateLabel("Email", 45, 155));
            txtRegEmail = CreateTextBox(45, 175, false, 200);
            pnlRegister.Controls.Add(txtRegEmail);

            pnlRegister.Controls.Add(CreateLabel("Contact Number", 275, 155));
            txtRegContact = CreateTextBox(275, 175, false, 200);
            pnlRegister.Controls.Add(txtRegContact);

            pnlRegister.Controls.Add(CreateLabel("Password", 45, 220));
            txtRegPass = CreateTextBox(45, 240, true, 200);
            pnlRegister.Controls.Add(txtRegPass);

            Button btnRegister = CreateButton("REGISTER", 45, 310, 430);
            btnRegister.Click += BtnRegister_Click;
            pnlRegister.Controls.Add(btnRegister);

            Label lblBackToLog = new Label { Text = "Already have an account? Sign in.", ForeColor = _maroon, Font = new Font("Segoe UI", 9F, FontStyle.Underline), Cursor = Cursors.Hand, AutoSize = true, Location = new Point(160, 370) };
            lblBackToLog.Click += (s, e) => SwitchPanel(pnlLogin);
            pnlRegister.Controls.Add(lblBackToLog);

            // ─── RESET PASSWORD PANEL ───
            pnlReset = new Panel { Dock = DockStyle.Fill, Visible = false };
            pnlReset.Controls.Add(new Label { Text = "Reset Password", Font = new Font("Segoe UI", 24F, FontStyle.Bold), ForeColor = _maroon, AutoSize = true, Location = new Point(60, 80) });
            pnlReset.Controls.Add(new Label { Text = "Enter your registered phone number to reset your password.", Font = new Font("Segoe UI", 9F), ForeColor = _textDark, AutoSize = true, Location = new Point(65, 130) });

            pnlReset.Controls.Add(CreateLabel("Registered Contact Number", 65, 170));
            txtResetPhone = CreateTextBox(65, 195);
            pnlReset.Controls.Add(txtResetPhone);

            pnlReset.Controls.Add(CreateLabel("New Password", 65, 245));
            txtResetNewPass = CreateTextBox(65, 270, true);
            pnlReset.Controls.Add(txtResetNewPass);

            Button btnReset = CreateButton("RESET PASSWORD", 65, 340);
            btnReset.Click += BtnResetPassword_Click;
            pnlReset.Controls.Add(btnReset);

            Label lblCancelReset = new Label { Text = "Cancel and go back to Login", ForeColor = _maroon, Font = new Font("Segoe UI", 9F, FontStyle.Underline), Cursor = Cursors.Hand, AutoSize = true, Location = new Point(160, 400) };
            lblCancelReset.Click += (s, e) => SwitchPanel(pnlLogin);
            pnlReset.Controls.Add(lblCancelReset);

            // ─── ADD ALL PANELS ───
            pnlRightBase.Controls.Add(pnlLogin);
            pnlRightBase.Controls.Add(pnlRegister);
            pnlRightBase.Controls.Add(pnlReset);
        }

        private Label CreateLabel(string text, int x, int y) { return new Label { Text = text, Location = new Point(x, y), Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = _textDark, AutoSize = true }; }
        private TextBox CreateTextBox(int x, int y, bool isPassword = false, int width = 380) { return new TextBox { Location = new Point(x, y), Size = new Size(width, 30), Font = new Font("Segoe UI", 11F), PasswordChar = isPassword ? '●' : '\0', BorderStyle = BorderStyle.FixedSingle }; }
        private Button CreateButton(string text, int x, int y, int width = 380) { Button btn = new Button { Text = text, Location = new Point(x, y), Size = new Size(width, 45), BackColor = _maroon, ForeColor = _white, Font = new Font("Segoe UI", 11F, FontStyle.Bold), FlatStyle = FlatStyle.Flat, Cursor = Cursors.Hand }; btn.FlatAppearance.BorderSize = 0; return btn; }

        private void SwitchPanel(Panel target)
        {
            pnlLogin.Visible = false;
            pnlRegister.Visible = false;
            pnlReset.Visible = false;
            target.Visible = true;
        }

        // ==========================================
        // 2. DATABASE & NAVIGATION LOGIC
        // ==========================================
        //private async Task LoadRolesAsync()
        //{
        //    string query = "SELECT RoleID, RoleName FROM Roles ORDER BY RoleID ASC;";
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(_connectionString))
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            DataTable table = new DataTable();
        //            await conn.OpenAsync();
        //            using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) table.Load(reader);
        //            cmbRegRole.DisplayMember = "RoleName";
        //            cmbRegRole.ValueMember = "RoleID";
        //            cmbRegRole.DataSource = table;
        //        }
        //    }
        //    catch (Exception) { }
        //}

        // --- THE NEW GUEST BUTTON LOGIC ---
        private void BtnGuest_Click(object sender, EventArgs e)
        {
            // Open the visitor form directly
            Visitor_Visits_visitor guestForm = new Visitor_Visits_visitor();
            guestForm.Show();

            // Hide the login screen
            this.Hide();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogUser.Text) || string.IsNullOrWhiteSpace(txtLogPass.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                SELECT u.UserID, u.IsActive, r.RoleName 
                FROM Users u
                INNER JOIN Roles r ON u.RoleID = r.RoleID
                WHERE u.Username = @User AND u.PasswordHash = @Pass";

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@User", txtLogUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@Pass", HashPassword(txtLogPass.Text));

                    await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            if (!Convert.ToBoolean(reader["IsActive"]))
                            {
                                MessageBox.Show("Your account has been disabled.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string roleName = reader["RoleName"].ToString();

                            // Route based on role
                            if (roleName == "Admin" || roleName == "System Administrator")
                            {
                                Dashboard_Admin adminDash = new Dashboard_Admin();
                                adminDash.Show();
                            }
                            else
                            {
                                Donor_dashboard userDash = new Donor_dashboard();
                                userDash.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegFull.Text) ||
                string.IsNullOrWhiteSpace(txtRegUser.Text) ||
                string.IsNullOrWhiteSpace(txtRegPass.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roleId = 2; // Hardcoded Donor role

            string userQuery = @"INSERT INTO Users (FullName, Username, Email, PasswordHash, ContactNumber, RoleID) 
                         OUTPUT INSERTED.UserID 
                         VALUES (@Full, @User, @Email, @Pass, @Contact, @RoleID)";

            string donorQuery = @"INSERT INTO Donors (FullName, ContactNumber, Email, UserID) 
                          VALUES (@Full, @Contact, @Email, @UserID)";

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            int newUserId = 0;

                            using (SqlCommand cmd = new SqlCommand(userQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Full", txtRegFull.Text.Trim());
                                cmd.Parameters.AddWithValue("@User", txtRegUser.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", txtRegEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@Pass", HashPassword(txtRegPass.Text));
                                cmd.Parameters.AddWithValue("@Contact", txtRegContact.Text.Trim());
                                cmd.Parameters.AddWithValue("@RoleID", roleId);

                                newUserId = (int)await cmd.ExecuteScalarAsync();
                            }

                            using (SqlCommand donorCmd = new SqlCommand(donorQuery, conn, transaction))
                            {
                                donorCmd.Parameters.AddWithValue("@Full", txtRegFull.Text.Trim());
                                donorCmd.Parameters.AddWithValue("@Contact", txtRegContact.Text.Trim());
                                donorCmd.Parameters.AddWithValue("@Email", txtRegEmail.Text.Trim());
                                donorCmd.Parameters.AddWithValue("@UserID", newUserId);

                                await donorCmd.ExecuteNonQueryAsync();
                            }

                            transaction.Commit();

                            MessageBox.Show("Account created successfully! You can now log in.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtRegFull.Clear();
                            txtRegUser.Clear();
                            txtRegEmail.Clear();
                            txtRegPass.Clear();
                            txtRegContact.Clear();

                            SwitchPanel(pnlLogin);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Database Insert Failed:\n\n{ex.Message}", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) MessageBox.Show("That Username or Email is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show($"Connection Error: {ex.Message}");
            }
        }

        private async void BtnResetPassword_Click(object sender, EventArgs e)
        {
            string phone = txtResetPhone.Text.Trim();
            string newPass = txtResetNewPass.Text;

            if (string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(newPass))
            { MessageBox.Show("Please enter your phone number and a new password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    string checkQuery = "SELECT COUNT(1) FROM Users WHERE ContactNumber = @Phone";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Phone", phone);
                        if (Convert.ToInt32(await checkCmd.ExecuteScalarAsync()) == 0)
                        { MessageBox.Show("No account found with that phone number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    }

                    string updateQuery = "UPDATE Users SET PasswordHash = @NewPassHash WHERE ContactNumber = @Phone";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@Phone", phone);
                        updateCmd.Parameters.AddWithValue("@NewPassHash", HashPassword(newPass));
                        if (await updateCmd.ExecuteNonQueryAsync() > 0)
                        {
                            MessageBox.Show("Password reset successfully! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SwitchPanel(pnlLogin);
                            txtResetPhone.Clear(); txtResetNewPass.Clear();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }

        // ==========================================
        // 3. SECURITY LOGIC
        // ==========================================
        private string HashPassword(string rawPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawPassword));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes) builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            // This is just here to keep the Visual Studio Designer happy!
        }
    }
}