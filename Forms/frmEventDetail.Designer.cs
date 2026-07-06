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
            this.SuspendLayout();
            // 
            // frmEventDetail
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmEventDetail";
            this.Load += new System.EventHandler(this.frmEventDetail_Load_1);
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
