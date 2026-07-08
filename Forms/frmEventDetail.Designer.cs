namespace TempleManagementSystem.EventManagement
{
    partial class frmEventDetail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader    = new System.Windows.Forms.Panel();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblType      = new System.Windows.Forms.Label();
            this.pnlBody      = new System.Windows.Forms.Panel();
            this.pnlCards     = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDate      = new System.Windows.Forms.Panel();
            this.lblDateLbl   = new System.Windows.Forms.Label();
            this.lblDate      = new System.Windows.Forms.Label();
            this.pnlTime      = new System.Windows.Forms.Panel();
            this.lblTimeLbl   = new System.Windows.Forms.Label();
            this.lblTime      = new System.Windows.Forms.Label();
            this.pnlLoc       = new System.Windows.Forms.Panel();
            this.lblLocLbl    = new System.Windows.Forms.Label();
            this.lblLocation  = new System.Windows.Forms.Label();
            this.pnlStat      = new System.Windows.Forms.Panel();
            this.lblStatLbl   = new System.Windows.Forms.Label();
            this.lblStatus    = new System.Windows.Forms.Label();
            this.lblDescLbl   = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlExtra     = new System.Windows.Forms.FlowLayoutPanel();
            this.lblExtraHead = new System.Windows.Forms.Label();
            this.pnlBottom    = new System.Windows.Forms.Panel();
            this.btnClose     = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();

            // ── Form ─────────────────────────────────────────────────────────
            this.Text          = "Event Details";
            this.Size          = new System.Drawing.Size(600, 540);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor     = System.Drawing.Color.FromArgb(245, 245, 245);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox   = false;

            // ── Header ───────────────────────────────────────────────────────
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 90;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(100, 0, 0);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { lblEventName, lblType });

            this.lblEventName.Text      = "Event Name";
            this.lblEventName.Font      = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.AutoSize  = false;
            this.lblEventName.Size      = new System.Drawing.Size(600, 50);
            this.lblEventName.Location  = new System.Drawing.Point(0, 10);
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblType.Text      = "Event Type";
            this.lblType.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Italic);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(255, 200, 200);
            this.lblType.AutoSize  = false;
            this.lblType.Size      = new System.Drawing.Size(600, 28);
            this.lblType.Location  = new System.Drawing.Point(0, 58);
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Body ─────────────────────────────────────────────────────────
            this.pnlBody.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlBody.Padding   = new System.Windows.Forms.Padding(20, 16, 20, 0);
            this.pnlBody.AutoScroll = true;

            // Info cards row
            this.pnlCards.Location      = new System.Drawing.Point(20, 16);
            this.pnlCards.Size          = new System.Drawing.Size(560, 90);
            
            
            this.pnlCards.BackColor     = System.Drawing.Color.Transparent;
            this.pnlCards.Controls.AddRange(new System.Windows.Forms.Control[]
                { pnlDate, pnlTime, pnlLoc, pnlStat });

            // Helper for info cards
            void MakeCard(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label lbl,
                          System.Windows.Forms.Label val, string labelText)
            {
                pnl.Size      = new System.Drawing.Size(128, 76);
                pnl.BackColor = System.Drawing.Color.White;
                pnl.Margin    = new System.Windows.Forms.Padding(0, 0, 8, 0);
                pnl.Padding   = new System.Windows.Forms.Padding(10, 8, 10, 8);

                lbl.Text      = labelText;
                lbl.Font      = new System.Drawing.Font("Segoe UI", 8f);
                lbl.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
                lbl.AutoSize  = false;
                lbl.Size      = new System.Drawing.Size(108, 16);
                lbl.Location  = new System.Drawing.Point(10, 8);

                val.Text      = "—";
                val.Font      = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
                val.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
                val.AutoSize  = false;
                val.Size      = new System.Drawing.Size(108, 44);
                val.Location  = new System.Drawing.Point(10, 26);
                val.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                pnl.Controls.AddRange(new System.Windows.Forms.Control[] { lbl, val });
            }

            MakeCard(pnlDate, lblDateLbl, lblDate,     "Date");
            MakeCard(pnlTime, lblTimeLbl, lblTime,     "Time");
            MakeCard(pnlLoc,  lblLocLbl,  lblLocation, "Location");
            MakeCard(pnlStat, lblStatLbl, lblStatus,   "Status");

            // Description
            this.lblDescLbl.Text      = "DESCRIPTION";
            this.lblDescLbl.Font      = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblDescLbl.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.lblDescLbl.Location  = new System.Drawing.Point(20, 120);
            this.lblDescLbl.AutoSize  = true;

            this.lblDescription.Text      = "";
            this.lblDescription.Font      = new System.Drawing.Font("Segoe UI", 10f);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblDescription.Location  = new System.Drawing.Point(20, 140);
            this.lblDescription.Size      = new System.Drawing.Size(560, 56);

            // Extra details (subclass fields)
            this.lblExtraHead.Text      = "ADDITIONAL DETAILS";
            this.lblExtraHead.Font      = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblExtraHead.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.lblExtraHead.Location  = new System.Drawing.Point(20, 210);
            this.lblExtraHead.AutoSize  = true;

            this.pnlExtra.Location      = new System.Drawing.Point(20, 232);
            this.pnlExtra.Size          = new System.Drawing.Size(560, 120);
            
            this.pnlExtra.BackColor     = System.Drawing.Color.Transparent;

            this.pnlBody.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                pnlCards, lblDescLbl, lblDescription, lblExtraHead, pnlExtra
            });

            // ── Bottom ───────────────────────────────────────────────────────
            this.pnlBottom.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height    = 56;
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(100, 0, 0);
            this.pnlBottom.Controls.Add(btnClose);

            this.btnClose.Text      = "Close";
            this.btnClose.Size      = new System.Drawing.Size(120, 36);
            this.btnClose.Location  = new System.Drawing.Point(460, 10);
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(100, 0, 0);
            this.btnClose.Font      = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Cursor    = System.Windows.Forms.Cursors.Hand;

            // ── Wire events ──────────────────────────────────────────────────
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.Load           += new System.EventHandler(this.frmEventDetail_Load);

            // ── Add to form ──────────────────────────────────────────────────
            this.Controls.AddRange(new System.Windows.Forms.Control[]
                { pnlBody, pnlBottom, pnlHeader });

            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel          pnlHeader, pnlBody, pnlBottom, pnlCards;
        private System.Windows.Forms.Panel          pnlDate, pnlTime, pnlLoc, pnlStat;
        private System.Windows.Forms.FlowLayoutPanel pnlExtra;
        private System.Windows.Forms.Label          lblEventName, lblType, lblDateLbl, lblDate,
                                                    lblTimeLbl, lblTime, lblLocLbl, lblLocation,
                                                    lblStatLbl, lblStatus, lblDescLbl,
                                                    lblDescription, lblExtraHead;
        private System.Windows.Forms.Button         btnClose;
    }
}
