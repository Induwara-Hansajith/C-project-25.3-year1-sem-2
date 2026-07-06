namespace TempleManagementSystem.EventManagement
{
    partial class frmEventList
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader      = new System.Windows.Forms.Panel();
            this.lblTitle       = new System.Windows.Forms.Label();
            this.lblSubtitle    = new System.Windows.Forms.Label();
            this.pnlSidebar     = new System.Windows.Forms.Panel();
            this.btnSideAdd     = new System.Windows.Forms.Button();
            this.btnSideAll     = new System.Windows.Forms.Button();
            this.btnSideUpcoming   = new System.Windows.Forms.Button();
            this.btnSideScheduled  = new System.Windows.Forms.Button();
            this.btnSideCompleted  = new System.Windows.Forms.Button();
            this.btnSideCancelled  = new System.Windows.Forms.Button();
            this.pnlMain        = new System.Windows.Forms.Panel();
            this.pnlSearch      = new System.Windows.Forms.Panel();
            this.txtSearch      = new System.Windows.Forms.TextBox();
            this.lblSearch      = new System.Windows.Forms.Label();
            this.dgvEvents      = new System.Windows.Forms.DataGridView();
            this.pnlBottom      = new System.Windows.Forms.Panel();
            this.btnBack        = new System.Windows.Forms.Button();
            this.btnView        = new System.Windows.Forms.Button();
            this.btnEdit        = new System.Windows.Forms.Button();
            this.btnDelete      = new System.Windows.Forms.Button();
            this.lblCount       = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.Text          = "Event Management";
            this.Size          = new System.Drawing.Size(1100, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor     = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font          = new System.Drawing.Font("Segoe UI", 9f);

            // Header
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 110;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(100, 0, 0);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { lblTitle, lblSubtitle });

            this.lblTitle.Text      = "Temple Management System";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 22f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize  = false;
            this.lblTitle.Size      = new System.Drawing.Size(1100, 55);
            this.lblTitle.Location  = new System.Drawing.Point(0, 15);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubtitle.Text      = "Event Management";
            this.lblSubtitle.Font      = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(255, 200, 200);
            this.lblSubtitle.AutoSize  = false;
            this.lblSubtitle.Size      = new System.Drawing.Size(1100, 30);
            this.lblSubtitle.Location  = new System.Drawing.Point(0, 68);
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Sidebar
            this.pnlSidebar.Dock      = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width     = 200;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(120, 0, 0);
            this.pnlSidebar.Controls.AddRange(new System.Windows.Forms.Control[]
                { btnSideAdd, btnSideAll, btnSideUpcoming, btnSideScheduled, btnSideCompleted, btnSideCancelled });

            int sy = 20;
            foreach (System.Windows.Forms.Button btn in new System.Windows.Forms.Button[]
                { btnSideAdd, btnSideAll, btnSideUpcoming, btnSideScheduled, btnSideCompleted, btnSideCancelled })
            {
                btn.Size      = new System.Drawing.Size(160, 50);
                btn.Location  = new System.Drawing.Point(20, sy);
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 30, 30);
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
                btn.Cursor    = System.Windows.Forms.Cursors.Hand;
                btn.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
                sy += 60;
            }

            this.btnSideAdd.Text       = "+ Add Event";
            this.btnSideAdd.BackColor  = System.Drawing.Color.FromArgb(80, 0, 0);
            this.btnSideAll.Text       = "All Events";
            this.btnSideUpcoming.Text  = "Upcoming";
            this.btnSideScheduled.Text = "Scheduled";
            this.btnSideCompleted.Text = "Completed";
            this.btnSideCancelled.Text = "Cancelled";

            // Main Panel
            this.pnlMain.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMain.Padding   = new System.Windows.Forms.Padding(16);
            this.pnlMain.Controls.AddRange(new System.Windows.Forms.Control[] { pnlSearch, dgvEvents, pnlBottom });

            // Search bar
            this.pnlSearch.Height    = 50;
            this.pnlSearch.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlSearch.Controls.AddRange(new System.Windows.Forms.Control[] { lblSearch, txtSearch });

            this.lblSearch.Text     = "Search:";
            this.lblSearch.Font     = new System.Drawing.Font("Segoe UI", 10f);
            this.lblSearch.Location = new System.Drawing.Point(16, 14);
            this.lblSearch.AutoSize = true;

            this.txtSearch.Location    = new System.Drawing.Point(75, 10);
            this.txtSearch.Size        = new System.Drawing.Size(300, 28);
            this.txtSearch.Font        = new System.Drawing.Font("Segoe UI", 10f);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // DataGridView
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;

            // Bottom panel — back button on LEFT, action buttons on RIGHT
            this.pnlBottom.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height    = 60;
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlBottom.Controls.AddRange(new System.Windows.Forms.Control[]
                { btnBack, btnView, btnEdit, btnDelete, lblCount });

            // Back to Dashboard — far left
            this.btnBack.Text      = "← Dashboard";
            this.btnBack.Size      = new System.Drawing.Size(150, 38);
            this.btnBack.Location  = new System.Drawing.Point(10, 11);
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(80, 0, 0);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Cursor    = System.Windows.Forms.Cursors.Hand;

            // View, Edit, Delete — right side
            this.btnView.Text     = "View";
            this.btnView.Size     = new System.Drawing.Size(110, 38);
            this.btnView.Location = new System.Drawing.Point(500, 11);

            this.btnEdit.Text     = "Edit";
            this.btnEdit.Size     = new System.Drawing.Size(110, 38);
            this.btnEdit.Location = new System.Drawing.Point(620, 11);

            this.btnDelete.Text     = "Delete";
            this.btnDelete.Size     = new System.Drawing.Size(110, 38);
            this.btnDelete.Location = new System.Drawing.Point(740, 11);

            foreach (System.Windows.Forms.Button btn in new System.Windows.Forms.Button[] { btnView, btnEdit, btnDelete })
            {
                btn.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor    = System.Windows.Forms.Cursors.Hand;
            }

            this.lblCount.AutoSize  = true;
            this.lblCount.Location  = new System.Drawing.Point(870, 20);
            this.lblCount.Font      = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // Wire events
            this.btnSideAdd.Click       += (s, e) => btnAdd_Click(s, e);
            this.btnSideAll.Click       += (s, e) => btnAll_Click(s, e);
            this.btnSideUpcoming.Click  += (s, e) => btnUpcoming_Click(s, e);
            this.btnSideScheduled.Click += (s, e) => btnScheduled_Click(s, e);
            this.btnSideCompleted.Click += (s, e) => btnCompleted_Click(s, e);
            this.btnSideCancelled.Click += (s, e) => btnCancelled_Click(s, e);
            this.btnView.Click          += new System.EventHandler(this.btnView_Click);
            this.btnEdit.Click          += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click        += new System.EventHandler(this.btnDelete_Click);
            this.btnBack.Click          += new System.EventHandler(this.btnBack_Click);
            this.txtSearch.TextChanged  += new System.EventHandler(this.txtSearch_TextChanged);
            this.Load                   += new System.EventHandler(this.frmEventList_Load);

            // Add to form
            this.Controls.AddRange(new System.Windows.Forms.Control[]
                { pnlMain, pnlSidebar, pnlHeader });

            this.pnlHeader.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel   pnlHeader, pnlSidebar, pnlMain, pnlSearch, pnlBottom;
        private System.Windows.Forms.Label   lblTitle, lblSubtitle, lblSearch, lblCount;
        private System.Windows.Forms.Button  btnSideAdd, btnSideAll, btnSideUpcoming, btnSideScheduled,
                                             btnSideCompleted, btnSideCancelled,
                                             btnView, btnEdit, btnDelete, btnBack;
        private System.Windows.Forms.TextBox       txtSearch;
        private System.Windows.Forms.DataGridView  dgvEvents;
    }
}
