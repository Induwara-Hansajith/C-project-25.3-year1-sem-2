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
            this.SuspendLayout();
            // 
            // frmAddEditEvent
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmAddEditEvent";
            this.Load += new System.EventHandler(this.frmAddEditEvent_Load_1);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel       pnlHeader, pnlBody, pnlBottom;
        private System.Windows.Forms.Panel       pnlCeremony, pnlDhamma, pnlSpecial;
        private System.Windows.Forms.Label       lblTitle, lblEventName, lblEventType, lblDate,
                                                 lblStartTime, lblEndTime, lblLocation, lblStatus,
                                                 lblDescription, lblMonkCount, lblOfferings,
                                                 lblSpeaker, lblTopic, lblSponsor, lblGuestCount;
        private System.Windows.Forms.TextBox     txtEventName, txtStartTime, txtEndTime,
                                                 txtLocation, txtDescription, txtMonkCount,
                                                 txtOfferings, txtSpeaker, txtTopic,
                                                 txtSponsor, txtGuestCount;
        private System.Windows.Forms.ComboBox    cmbEventType, cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button      btnSave, btnCancel;
    }
}
