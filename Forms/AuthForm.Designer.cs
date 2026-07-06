namespace TempleManagmentSystem
{
    partial class AuthForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 1007);
            this.Name = "AuthForm";
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}