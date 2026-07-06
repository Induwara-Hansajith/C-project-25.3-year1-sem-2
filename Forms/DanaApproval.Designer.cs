namespace TempleManagementSystem.Forms
{
    partial class DanaApproval
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanaApproval));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templeManagementDBDataSet6 = new TempleManagmentSystem.TempleManagementDBDataSet6();
            this.Approve = new System.Windows.Forms.Button();
            this.Reject = new System.Windows.Forms.Button();
            this.Hold = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.templeManagementDBDataSet5 = new TempleManagmentSystem.TempleManagementDBDataSet5();
            this.danaRequestsTableAdapter = new TempleManagmentSystem.TempleManagementDBDataSet6TableAdapters.DanaRequestsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 123);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(191, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temple Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 927);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(-14, 330);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(92, 76);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 36;
            this.pictureBox9.TabStop = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(88, 330);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 76);
            this.button3.TabIndex = 8;
            this.button3.Text = "Upcoming Dana";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(90, 508);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 81);
            this.button2.TabIndex = 7;
            this.button2.Text = "View Donor ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(95, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 89);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 508);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.donorIDDataGridViewTextBoxColumn,
            this.danaDateDataGridViewTextBoxColumn,
            this.danaTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.mealTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.danaRequestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(750, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 389);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donorIDDataGridViewTextBoxColumn
            // 
            this.donorIDDataGridViewTextBoxColumn.DataPropertyName = "DonorID";
            this.donorIDDataGridViewTextBoxColumn.HeaderText = "DonorID";
            this.donorIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorIDDataGridViewTextBoxColumn.Name = "donorIDDataGridViewTextBoxColumn";
            this.donorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danaDateDataGridViewTextBoxColumn
            // 
            this.danaDateDataGridViewTextBoxColumn.DataPropertyName = "DanaDate";
            this.danaDateDataGridViewTextBoxColumn.HeaderText = "DanaDate";
            this.danaDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.danaDateDataGridViewTextBoxColumn.Name = "danaDateDataGridViewTextBoxColumn";
            this.danaDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danaTypeDataGridViewTextBoxColumn
            // 
            this.danaTypeDataGridViewTextBoxColumn.DataPropertyName = "DanaType";
            this.danaTypeDataGridViewTextBoxColumn.HeaderText = "DanaType";
            this.danaTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.danaTypeDataGridViewTextBoxColumn.Name = "danaTypeDataGridViewTextBoxColumn";
            this.danaTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mealTypeDataGridViewTextBoxColumn
            // 
            this.mealTypeDataGridViewTextBoxColumn.DataPropertyName = "MealType";
            this.mealTypeDataGridViewTextBoxColumn.HeaderText = "MealType";
            this.mealTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mealTypeDataGridViewTextBoxColumn.Name = "mealTypeDataGridViewTextBoxColumn";
            this.mealTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danaRequestsBindingSource
            // 
            this.danaRequestsBindingSource.DataMember = "DanaRequests";
            this.danaRequestsBindingSource.DataSource = this.templeManagementDBDataSet6;
            // 
            // templeManagementDBDataSet6
            // 
            this.templeManagementDBDataSet6.DataSetName = "TempleManagementDBDataSet6";
            this.templeManagementDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Approve
            // 
            this.Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Approve.Location = new System.Drawing.Point(498, 231);
            this.Approve.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(229, 89);
            this.Approve.TabIndex = 7;
            this.Approve.Text = "Approve";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click_1);
            // 
            // Reject
            // 
            this.Reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reject.Location = new System.Drawing.Point(496, 337);
            this.Reject.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Reject.Name = "Reject";
            this.Reject.Size = new System.Drawing.Size(231, 90);
            this.Reject.TabIndex = 8;
            this.Reject.Text = "Reject";
            this.Reject.UseVisualStyleBackColor = true;
            this.Reject.Click += new System.EventHandler(this.button5_Click);
            // 
            // Hold
            // 
            this.Hold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Hold.Location = new System.Drawing.Point(496, 454);
            this.Hold.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Hold.Name = "Hold";
            this.Hold.Size = new System.Drawing.Size(231, 89);
            this.Hold.TabIndex = 9;
            this.Hold.Text = "On Hold ";
            this.Hold.UseVisualStyleBackColor = true;
            this.Hold.Click += new System.EventHandler(this.Hold_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1121, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dana Requests";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // templeManagementDBDataSet5
            // 
            this.templeManagementDBDataSet5.DataSetName = "TempleManagementDBDataSet5";
            this.templeManagementDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danaRequestsTableAdapter
            // 
            this.danaRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1033, 643);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mark Completed Requests";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(750, 691);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(1017, 292);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(496, 794);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 89);
            this.button4.TabIndex = 13;
            this.button4.Text = "Completed";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DanaApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hold);
            this.Controls.Add(this.Reject);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "DanaApproval";
            this.Text = "DanaApproval";
            this.Load += new System.EventHandler(this.DanaApproval_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.Button Reject;
        private System.Windows.Forms.Button Hold;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private TempleManagmentSystem.TempleManagementDBDataSet5 templeManagementDBDataSet5;
        private TempleManagmentSystem.TempleManagementDBDataSet6 templeManagementDBDataSet6;
        private System.Windows.Forms.BindingSource danaRequestsBindingSource;
        private TempleManagmentSystem.TempleManagementDBDataSet6TableAdapters.DanaRequestsTableAdapter danaRequestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
    }
}