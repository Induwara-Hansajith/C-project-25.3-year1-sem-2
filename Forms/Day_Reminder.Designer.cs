namespace TempleManagmentSystem
{
    public partial class Day_Reminder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Day_Reminder));
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templeManagementDBDataSet = new TempleManagmentSystem.TempleManagementDBDataSet();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SacredDayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SacredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRecurringAnnually = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sacredDaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templeManagementDBDataSet1 = new TempleManagmentSystem.TempleManagementDBDataSet1();
            this.eventsTableAdapter = new TempleManagmentSystem.TempleManagementDBDataSetTableAdapters.EventsTableAdapter();
            this.sacredDaysTableAdapter = new TempleManagmentSystem.TempleManagementDBDataSet1TableAdapters.SacredDaysTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacredDaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet1)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.templeManagementDBDataSet;
            // 
            // templeManagementDBDataSet
            // 
            this.templeManagementDBDataSet.DataSetName = "TempleManagementDBDataSet";
            this.templeManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.label2);
            this.panel14.Controls.Add(this.dataGridView2);
            this.panel14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel14.Location = new System.Drawing.Point(639, 281);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(928, 495);
            this.panel14.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(298, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Scared Day Reminders";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.DayName,
            this.SacredDayID,
            this.SacredDate,
            this.IsRecurringAnnually});
            this.dataGridView2.DataSource = this.sacredDaysBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(27, 47);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(874, 416);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // DayName
            // 
            this.DayName.DataPropertyName = "DayName";
            this.DayName.HeaderText = "DayName";
            this.DayName.MinimumWidth = 6;
            this.DayName.Name = "DayName";
            this.DayName.ReadOnly = true;
            // 
            // SacredDayID
            // 
            this.SacredDayID.DataPropertyName = "SacredDayID";
            this.SacredDayID.HeaderText = "SacredDayID";
            this.SacredDayID.MinimumWidth = 6;
            this.SacredDayID.Name = "SacredDayID";
            this.SacredDayID.ReadOnly = true;
            // 
            // SacredDate
            // 
            this.SacredDate.DataPropertyName = "SacredDate";
            this.SacredDate.HeaderText = "SacredDate";
            this.SacredDate.MinimumWidth = 6;
            this.SacredDate.Name = "SacredDate";
            this.SacredDate.ReadOnly = true;
            // 
            // IsRecurringAnnually
            // 
            this.IsRecurringAnnually.DataPropertyName = "IsRecurringAnnually";
            this.IsRecurringAnnually.HeaderText = "IsRecurringAnnually";
            this.IsRecurringAnnually.MinimumWidth = 6;
            this.IsRecurringAnnually.Name = "IsRecurringAnnually";
            this.IsRecurringAnnually.ReadOnly = true;
            // 
            // sacredDaysBindingSource
            // 
            this.sacredDaysBindingSource.DataMember = "SacredDays";
            this.sacredDaysBindingSource.DataSource = this.templeManagementDBDataSet1;
            // 
            // templeManagementDBDataSet1
            // 
            this.templeManagementDBDataSet1.DataSetName = "TempleManagementDBDataSet1";
            this.templeManagementDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // sacredDaysTableAdapter
            // 
            this.sacredDaysTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(316, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(630, 54);
            this.label10.TabIndex = 8;
            this.label10.Text = "Temple Managment System";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(341, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(577, 33);
            this.label11.TabIndex = 9;
            this.label11.Text = "Welcome to the temple managment system";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Maroon;
            this.panel15.Controls.Add(this.label10);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Location = new System.Drawing.Point(438, -1);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1277, 226);
            this.panel15.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox14);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.pictureBox13);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(5, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 976);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(27, 887);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(69, 57);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 39;
            this.pictureBox11.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Brown;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(120, 887);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(292, 57);
            this.button8.TabIndex = 38;
            this.button8.Text = "Logout";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(27, 805);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(69, 57);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 37;
            this.pictureBox10.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Brown;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(120, 805);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(292, 57);
            this.button7.TabIndex = 36;
            this.button7.Text = "Settings";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(24, 720);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(69, 57);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 35;
            this.pictureBox9.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Brown;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(117, 720);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(292, 57);
            this.button6.TabIndex = 34;
            this.button6.Text = "Day Reminder";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(27, 638);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(69, 57);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 33;
            this.pictureBox8.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Brown;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(120, 638);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(292, 57);
            this.button5.TabIndex = 32;
            this.button5.Text = "Visitors";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(27, 554);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(69, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(120, 554);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(292, 57);
            this.button4.TabIndex = 30;
            this.button4.Text = "Resources";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(27, 473);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(69, 57);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 29;
            this.pictureBox14.TabStop = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Brown;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(117, 473);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(292, 57);
            this.button11.TabIndex = 28;
            this.button11.Text = "Dana Offerings";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(27, 389);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(69, 57);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 27;
            this.pictureBox13.TabStop = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Brown;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(117, 389);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(292, 57);
            this.button10.TabIndex = 26;
            this.button10.Text = "Events";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(27, 306);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(69, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(119, 306);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 57);
            this.button3.TabIndex = 12;
            this.button3.Text = "Dashboard";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Brown;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(1210, 841);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(331, 57);
            this.button9.TabIndex = 42;
            this.button9.Text = "Delete a day reminder";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Brown;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(667, 852);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(292, 57);
            this.button12.TabIndex = 43;
            this.button12.Text = "Add a day reminder";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Day_Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 960);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel1);
            this.Name = "Day_Reminder";
            this.Text = "Day_Reminder";
            this.Load += new System.EventHandler(this.Day_Reminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacredDaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeManagementDBDataSet1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private TempleManagementDBDataSet templeManagementDBDataSet;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SacredDayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SacredDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsRecurringAnnually;
        private System.Windows.Forms.BindingSource sacredDaysBindingSource;
        private TempleManagementDBDataSet1 templeManagementDBDataSet1;
        private TempleManagementDBDataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private TempleManagementDBDataSet1TableAdapters.SacredDaysTableAdapter sacredDaysTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
    }
}