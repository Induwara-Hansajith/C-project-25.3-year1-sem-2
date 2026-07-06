namespace TempleManagementSystem.Forms
{
    partial class MyDanaRequestAndMyDanaOffering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDanaRequestAndMyDanaOffering));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaRequestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.templeManagementDBDataSet8 = new TempleManagmentSystem.TempleManagementDBDataSet8();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.danaOfferingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.templeManagementDBDataSet7 = new TempleManagmentSystem.TempleManagementDBDataSet7();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.templeManagementDBDataSet3 = new TempleManagmentSystem.TempleManagementDBDataSet3();
            this.danaRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danaRequestsTableAdapter = new TempleManagmentSystem.TempleManagementDBDataSet3TableAdapters.DanaRequestsTableAdapter();
            this.templeManagementDBDataSet4 = new TempleManagmentSystem.TempleManagementDBDataSet4();
            this.danaOfferingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danaOfferingsTableAdapter = new TempleManagmentSystem.TempleManagementDBDataSet4TableAdapters.DanaOfferingsTableAdapter();
            this.danaOfferingsTableAdapter1 = new TempleManagmentSystem.TempleManagementDBDataSet7TableAdapters.DanaOfferingsTableAdapter();
            this.danaRequestsTableAdapter1 = new TempleManagmentSystem.TempleManagementDBDataSet8TableAdapters.DanaRequestsTableAdapter();
            this.danaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaRequestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaOfferingsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaOfferingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.danaRequestsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(386, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(854, 259);
            this.dataGridView1.TabIndex = 4;
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
            // 
            // danaDateDataGridViewTextBoxColumn
            // 
            this.danaDateDataGridViewTextBoxColumn.DataPropertyName = "DanaDate";
            this.danaDateDataGridViewTextBoxColumn.HeaderText = "DanaDate";
            this.danaDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.danaDateDataGridViewTextBoxColumn.Name = "danaDateDataGridViewTextBoxColumn";
            // 
            // danaTypeDataGridViewTextBoxColumn
            // 
            this.danaTypeDataGridViewTextBoxColumn.DataPropertyName = "DanaType";
            this.danaTypeDataGridViewTextBoxColumn.HeaderText = "DanaType";
            this.danaTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.danaTypeDataGridViewTextBoxColumn.Name = "danaTypeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            // 
            // mealTypeDataGridViewTextBoxColumn
            // 
            this.mealTypeDataGridViewTextBoxColumn.DataPropertyName = "MealType";
            this.mealTypeDataGridViewTextBoxColumn.HeaderText = "MealType";
            this.mealTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mealTypeDataGridViewTextBoxColumn.Name = "mealTypeDataGridViewTextBoxColumn";
            // 
            // danaRequestsBindingSource1
            // 
            this.danaRequestsBindingSource1.DataMember = "DanaRequests";
            this.danaRequestsBindingSource1.DataSource = this.templeManagementDBDataSet8;
            // 
            // templeManagementDBDataSet8
            // 
            this.templeManagementDBDataSet8.DataSetName = "TempleManagementDBDataSet8";
            this.templeManagementDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.danaIDDataGridViewTextBoxColumn,
            this.donorIDDataGridViewTextBoxColumn1,
            this.danaDateDataGridViewTextBoxColumn1,
            this.mealTypeDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.createdDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.danaOfferingsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(386, 484);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(854, 278);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // danaOfferingsBindingSource1
            // 
            this.danaOfferingsBindingSource1.DataMember = "DanaOfferings";
            this.danaOfferingsBindingSource1.DataSource = this.templeManagementDBDataSet7;
            // 
            // templeManagementDBDataSet7
            // 
            this.templeManagementDBDataSet7.DataSetName = "TempleManagementDBDataSet7";
            this.templeManagementDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(621, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "My Dana Request ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(623, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "My Dana Offering ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 91);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(116, 99);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temple Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 683);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(97, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 55);
            this.button3.TabIndex = 8;
            this.button3.Text = "Dana Request";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(97, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "My Request & My Dana";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(97, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // templeManagementDBDataSet3
            // 
            this.templeManagementDBDataSet3.DataSetName = "TempleManagementDBDataSet3";
            this.templeManagementDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danaRequestsBindingSource
            // 
            this.danaRequestsBindingSource.DataMember = "DanaRequests";
            this.danaRequestsBindingSource.DataSource = this.templeManagementDBDataSet3;
            // 
            // danaRequestsTableAdapter
            // 
            this.danaRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // templeManagementDBDataSet4
            // 
            this.templeManagementDBDataSet4.DataSetName = "TempleManagementDBDataSet4";
            this.templeManagementDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danaOfferingsBindingSource
            // 
            this.danaOfferingsBindingSource.DataMember = "DanaOfferings";
            this.danaOfferingsBindingSource.DataSource = this.templeManagementDBDataSet4;
            // 
            // danaOfferingsTableAdapter
            // 
            this.danaOfferingsTableAdapter.ClearBeforeFill = true;
            // 
            // danaOfferingsTableAdapter1
            // 
            this.danaOfferingsTableAdapter1.ClearBeforeFill = true;
            // 
            // danaRequestsTableAdapter1
            // 
            this.danaRequestsTableAdapter1.ClearBeforeFill = true;
            // 
            // danaIDDataGridViewTextBoxColumn
            // 
            this.danaIDDataGridViewTextBoxColumn.DataPropertyName = "DanaID";
            this.danaIDDataGridViewTextBoxColumn.HeaderText = "DanaID";
            this.danaIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.danaIDDataGridViewTextBoxColumn.Name = "danaIDDataGridViewTextBoxColumn";
            this.danaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donorIDDataGridViewTextBoxColumn1
            // 
            this.donorIDDataGridViewTextBoxColumn1.DataPropertyName = "DonorID";
            this.donorIDDataGridViewTextBoxColumn1.HeaderText = "DonorID";
            this.donorIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.donorIDDataGridViewTextBoxColumn1.Name = "donorIDDataGridViewTextBoxColumn1";
            // 
            // danaDateDataGridViewTextBoxColumn1
            // 
            this.danaDateDataGridViewTextBoxColumn1.DataPropertyName = "DanaDate";
            this.danaDateDataGridViewTextBoxColumn1.HeaderText = "DanaDate";
            this.danaDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.danaDateDataGridViewTextBoxColumn1.Name = "danaDateDataGridViewTextBoxColumn1";
            // 
            // mealTypeDataGridViewTextBoxColumn1
            // 
            this.mealTypeDataGridViewTextBoxColumn1.DataPropertyName = "MealType";
            this.mealTypeDataGridViewTextBoxColumn1.HeaderText = "MealType";
            this.mealTypeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.mealTypeDataGridViewTextBoxColumn1.Name = "mealTypeDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            // 
            // MyDanaRequestAndMyDanaOffering
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1285, 774);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "MyDanaRequestAndMyDanaOffering";
            this.Load += new System.EventHandler(this.MyDanaRequestAndMyDanaOffering_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaRequestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaOfferingsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danaOfferingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private TempleManagmentSystem.TempleManagementDBDataSet3 templeManagementDBDataSet3;
        private System.Windows.Forms.BindingSource danaRequestsBindingSource;
        private TempleManagmentSystem.TempleManagementDBDataSet3TableAdapters.DanaRequestsTableAdapter danaRequestsTableAdapter;
        private TempleManagmentSystem.TempleManagementDBDataSet4 templeManagementDBDataSet4;
        private System.Windows.Forms.BindingSource danaOfferingsBindingSource;
        private TempleManagmentSystem.TempleManagementDBDataSet4TableAdapters.DanaOfferingsTableAdapter danaOfferingsTableAdapter;
        private TempleManagmentSystem.TempleManagementDBDataSet7 templeManagementDBDataSet7;
        private System.Windows.Forms.BindingSource danaOfferingsBindingSource1;
        private TempleManagmentSystem.TempleManagementDBDataSet7TableAdapters.DanaOfferingsTableAdapter danaOfferingsTableAdapter1;
        private TempleManagmentSystem.TempleManagementDBDataSet8 templeManagementDBDataSet8;
        private System.Windows.Forms.BindingSource danaRequestsBindingSource1;
        private TempleManagmentSystem.TempleManagementDBDataSet8TableAdapters.DanaRequestsTableAdapter danaRequestsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    }
}