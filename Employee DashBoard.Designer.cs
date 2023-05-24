namespace Employee_Leave_Managment
{
    partial class Employee_DashBoard
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
            this.tbLeaveRq = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvEmpLeaveReport = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label37 = new System.Windows.Forms.Label();
            this.specificLeaveRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMS_DBDataSet = new Employee_Leave_Managment.EMS_DBDataSet();
            this.ofdPassport = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTopName = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.btnEmpSubmit = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dtpTo_Date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFrom_Date = new System.Windows.Forms.DateTimePicker();
            this.label43 = new System.Windows.Forms.Label();
            this.cbEmpType = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tbEmpReason = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbEmpId = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tbAdminLeave = new System.Windows.Forms.TabPage();
            this.label41 = new System.Windows.Forms.Label();
            this.tbAttendenceReport = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbThisMonthDispatch = new System.Windows.Forms.Label();
            this.lbLeaveCount = new System.Windows.Forms.Label();
            this.lbCTCPackage = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEmpDetails = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbRPasswd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbNewPasswd = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbEmpUserID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHome = new System.Windows.Forms.TabPage();
            this.lbDesigPD = new System.Windows.Forms.Label();
            this.lbDesignation = new System.Windows.Forms.Label();
            this.lbEmpDept = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNamePD = new System.Windows.Forms.Label();
            this.lbIdPD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab1Dashboard = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.specific_Leave_RecordTableAdapter = new Employee_Leave_Managment.EMS_DBDataSetTableAdapters.Specific_Leave_RecordTableAdapter();
            this.tbLeaveRq.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpLeaveReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificLeaveRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMS_DBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel12.SuspendLayout();
            this.tbAdminLeave.SuspendLayout();
            this.tbAttendenceReport.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tbEmpDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbHome.SuspendLayout();
            this.tab1Dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLeaveRq
            // 
            this.tbLeaveRq.Controls.Add(this.panel4);
            this.tbLeaveRq.Location = new System.Drawing.Point(4, 25);
            this.tbLeaveRq.Name = "tbLeaveRq";
            this.tbLeaveRq.Size = new System.Drawing.Size(1162, 561);
            this.tbLeaveRq.TabIndex = 2;
            this.tbLeaveRq.Text = "Leave Request Details";
            this.tbLeaveRq.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvEmpLeaveReport);
            this.panel4.Controls.Add(this.label37);
            this.panel4.Location = new System.Drawing.Point(42, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 471);
            this.panel4.TabIndex = 0;
            // 
            // dgvEmpLeaveReport
            // 
            this.dgvEmpLeaveReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpLeaveReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpLeaveReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colLT,
            this.colReason,
            this.colStat,
            this.colName,
            this.colFD,
            this.colTD});
            this.dgvEmpLeaveReport.Location = new System.Drawing.Point(24, 93);
            this.dgvEmpLeaveReport.Name = "dgvEmpLeaveReport";
            this.dgvEmpLeaveReport.ReadOnly = true;
            this.dgvEmpLeaveReport.RowHeadersWidth = 51;
            this.dgvEmpLeaveReport.RowTemplate.Height = 24;
            this.dgvEmpLeaveReport.Size = new System.Drawing.Size(1046, 349);
            this.dgvEmpLeaveReport.TabIndex = 7;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colLT
            // 
            this.colLT.HeaderText = "Leave Type";
            this.colLT.MinimumWidth = 6;
            this.colLT.Name = "colLT";
            this.colLT.ReadOnly = true;
            this.colLT.Width = 125;
            // 
            // colReason
            // 
            this.colReason.HeaderText = "Reason";
            this.colReason.MinimumWidth = 6;
            this.colReason.Name = "colReason";
            this.colReason.ReadOnly = true;
            this.colReason.Width = 125;
            // 
            // colStat
            // 
            this.colStat.HeaderText = "Status";
            this.colStat.MinimumWidth = 6;
            this.colStat.Name = "colStat";
            this.colStat.ReadOnly = true;
            this.colStat.Width = 125;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colFD
            // 
            this.colFD.HeaderText = "From Date";
            this.colFD.MinimumWidth = 6;
            this.colFD.Name = "colFD";
            this.colFD.ReadOnly = true;
            this.colFD.Width = 125;
            // 
            // colTD
            // 
            this.colTD.HeaderText = "To Date";
            this.colTD.MinimumWidth = 6;
            this.colTD.Name = "colTD";
            this.colTD.ReadOnly = true;
            this.colTD.Width = 125;
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(390, 19);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(353, 36);
            this.label37.TabIndex = 6;
            this.label37.Text = "Employee Leave Request";
            // 
            // specificLeaveRecordBindingSource
            // 
            this.specificLeaveRecordBindingSource.DataMember = "Specific_Leave_Record";
            this.specificLeaveRecordBindingSource.DataSource = this.eMS_DBDataSet;
            // 
            // eMS_DBDataSet
            // 
            this.eMS_DBDataSet.DataSetName = "EMS_DBDataSet";
            this.eMS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ofdPassport
            // 
            this.ofdPassport.FileName = "PassPort";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Employee_Leave_Managment.Properties.Resources.angle_circle_left;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 79);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.lbTopName);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(72, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 79);
            this.panel2.TabIndex = 12;
            // 
            // lbTopName
            // 
            this.lbTopName.AutoSize = true;
            this.lbTopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopName.Location = new System.Drawing.Point(885, 22);
            this.lbTopName.Name = "lbTopName";
            this.lbTopName.Size = new System.Drawing.Size(231, 36);
            this.lbTopName.TabIndex = 10;
            this.lbTopName.Text = "Employee Name";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(778, 22);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(91, 36);
            this.label28.TabIndex = 9;
            this.label28.Text = "Hello!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Employee_Leave_Managment.Properties.Resources.id_badge;
            this.pictureBox1.Location = new System.Drawing.Point(90, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee DashBoard";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(405, 30);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(395, 36);
            this.label42.TabIndex = 6;
            this.label42.Text = "Employee Leave Apply Form";
            // 
            // btnEmpSubmit
            // 
            this.btnEmpSubmit.Location = new System.Drawing.Point(543, 326);
            this.btnEmpSubmit.Name = "btnEmpSubmit";
            this.btnEmpSubmit.Size = new System.Drawing.Size(121, 41);
            this.btnEmpSubmit.TabIndex = 34;
            this.btnEmpSubmit.Text = "Submit";
            this.btnEmpSubmit.UseVisualStyleBackColor = true;
            this.btnEmpSubmit.Click += new System.EventHandler(this.btnEmpSubmit_Click);
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel12.Controls.Add(this.dtpTo_Date);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.btnEmpSubmit);
            this.panel12.Controls.Add(this.dtpFrom_Date);
            this.panel12.Controls.Add(this.label43);
            this.panel12.Controls.Add(this.cbEmpType);
            this.panel12.Controls.Add(this.label44);
            this.panel12.Controls.Add(this.tbEmpReason);
            this.panel12.Controls.Add(this.label45);
            this.panel12.Controls.Add(this.tbEmpId);
            this.panel12.Controls.Add(this.label46);
            this.panel12.Location = new System.Drawing.Point(218, 107);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(736, 393);
            this.panel12.TabIndex = 7;
            // 
            // dtpTo_Date
            // 
            this.dtpTo_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo_Date.Location = new System.Drawing.Point(531, 181);
            this.dtpTo_Date.Name = "dtpTo_Date";
            this.dtpTo_Date.Size = new System.Drawing.Size(132, 26);
            this.dtpTo_Date.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "To Date";
            // 
            // dtpFrom_Date
            // 
            this.dtpFrom_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom_Date.Location = new System.Drawing.Point(214, 178);
            this.dtpFrom_Date.Name = "dtpFrom_Date";
            this.dtpFrom_Date.Size = new System.Drawing.Size(132, 26);
            this.dtpFrom_Date.TabIndex = 33;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(51, 175);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(126, 29);
            this.label43.TabIndex = 32;
            this.label43.Text = "From Date";
            // 
            // cbEmpType
            // 
            this.cbEmpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpType.FormattingEnabled = true;
            this.cbEmpType.Items.AddRange(new object[] {
            "Sick",
            "Permission"});
            this.cbEmpType.Location = new System.Drawing.Point(214, 121);
            this.cbEmpType.Name = "cbEmpType";
            this.cbEmpType.Size = new System.Drawing.Size(271, 28);
            this.cbEmpType.TabIndex = 31;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(109, 117);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 29);
            this.label44.TabIndex = 30;
            this.label44.Text = "Type";
            // 
            // tbEmpReason
            // 
            this.tbEmpReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpReason.Location = new System.Drawing.Point(203, 225);
            this.tbEmpReason.Multiline = true;
            this.tbEmpReason.Name = "tbEmpReason";
            this.tbEmpReason.Size = new System.Drawing.Size(461, 83);
            this.tbEmpReason.TabIndex = 29;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(75, 250);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 29);
            this.label45.TabIndex = 28;
            this.label45.Text = "Reason";
            // 
            // tbEmpId
            // 
            this.tbEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpId.Location = new System.Drawing.Point(214, 52);
            this.tbEmpId.Name = "tbEmpId";
            this.tbEmpId.ReadOnly = true;
            this.tbEmpId.Size = new System.Drawing.Size(271, 30);
            this.tbEmpId.TabIndex = 27;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(29, 52);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(148, 29);
            this.label46.TabIndex = 26;
            this.label46.Text = "Employee Id";
            // 
            // tbAdminLeave
            // 
            this.tbAdminLeave.Controls.Add(this.panel12);
            this.tbAdminLeave.Controls.Add(this.label42);
            this.tbAdminLeave.Location = new System.Drawing.Point(4, 25);
            this.tbAdminLeave.Name = "tbAdminLeave";
            this.tbAdminLeave.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdminLeave.Size = new System.Drawing.Size(1162, 561);
            this.tbAdminLeave.TabIndex = 5;
            this.tbAdminLeave.Text = "Leave Form";
            this.tbAdminLeave.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(356, 14);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(403, 36);
            this.label41.TabIndex = 5;
            this.label41.Text = "Employee Attendance Report";
            // 
            // tbAttendenceReport
            // 
            this.tbAttendenceReport.Controls.Add(this.panel11);
            this.tbAttendenceReport.Location = new System.Drawing.Point(4, 25);
            this.tbAttendenceReport.Name = "tbAttendenceReport";
            this.tbAttendenceReport.Size = new System.Drawing.Size(1162, 561);
            this.tbAttendenceReport.TabIndex = 3;
            this.tbAttendenceReport.Text = "Salary Report";
            this.tbAttendenceReport.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.BackColor = System.Drawing.Color.SkyBlue;
            this.panel11.Controls.Add(this.lbThisMonthDispatch);
            this.panel11.Controls.Add(this.lbLeaveCount);
            this.panel11.Controls.Add(this.lbCTCPackage);
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.label41);
            this.panel11.Location = new System.Drawing.Point(21, 11);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1111, 513);
            this.panel11.TabIndex = 0;
            // 
            // lbThisMonthDispatch
            // 
            this.lbThisMonthDispatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThisMonthDispatch.AutoSize = true;
            this.lbThisMonthDispatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThisMonthDispatch.Location = new System.Drawing.Point(534, 277);
            this.lbThisMonthDispatch.Name = "lbThisMonthDispatch";
            this.lbThisMonthDispatch.Size = new System.Drawing.Size(65, 29);
            this.lbThisMonthDispatch.TabIndex = 6;
            this.lbThisMonthDispatch.Text = "9500";
            // 
            // lbLeaveCount
            // 
            this.lbLeaveCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLeaveCount.AutoSize = true;
            this.lbLeaveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeaveCount.Location = new System.Drawing.Point(534, 211);
            this.lbLeaveCount.Name = "lbLeaveCount";
            this.lbLeaveCount.Size = new System.Drawing.Size(26, 29);
            this.lbLeaveCount.TabIndex = 6;
            this.lbLeaveCount.Text = "1";
            // 
            // lbCTCPackage
            // 
            this.lbCTCPackage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCTCPackage.AutoSize = true;
            this.lbCTCPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTCPackage.Location = new System.Drawing.Point(535, 143);
            this.lbCTCPackage.Name = "lbCTCPackage";
            this.lbCTCPackage.Size = new System.Drawing.Size(157, 29);
            this.lbCTCPackage.TabIndex = 6;
            this.lbCTCPackage.Text = "1.2 Laks CTC";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(280, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 29);
            this.label14.TabIndex = 6;
            this.label14.Text = "This Month Dispatch";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(374, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 29);
            this.label12.TabIndex = 6;
            this.label12.Text = "Leave Days";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "Your Salary Package";
            // 
            // tbEmpDetails
            // 
            this.tbEmpDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbEmpDetails.Controls.Add(this.panel3);
            this.tbEmpDetails.Location = new System.Drawing.Point(4, 25);
            this.tbEmpDetails.Name = "tbEmpDetails";
            this.tbEmpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmpDetails.Size = new System.Drawing.Size(1162, 561);
            this.tbEmpDetails.TabIndex = 1;
            this.tbEmpDetails.Text = "Edit info";
            this.tbEmpDetails.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.tbRPasswd);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.tbNewPasswd);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.tbOldPassword);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.tbEmpUserID);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(20, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1126, 525);
            this.panel3.TabIndex = 0;
            // 
            // tbRPasswd
            // 
            this.tbRPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRPasswd.Location = new System.Drawing.Point(519, 303);
            this.tbRPasswd.Name = "tbRPasswd";
            this.tbRPasswd.Size = new System.Drawing.Size(271, 30);
            this.tbRPasswd.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Re-Type Password";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(729, 349);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 43);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbNewPasswd
            // 
            this.tbNewPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPasswd.Location = new System.Drawing.Point(519, 229);
            this.tbNewPasswd.Name = "tbNewPasswd";
            this.tbNewPasswd.Size = new System.Drawing.Size(271, 30);
            this.tbNewPasswd.TabIndex = 36;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(337, 229);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(176, 29);
            this.label26.TabIndex = 33;
            this.label26.Text = "New Password";
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPassword.Location = new System.Drawing.Point(519, 163);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(271, 30);
            this.tbOldPassword.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(348, 163);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(165, 29);
            this.label20.TabIndex = 22;
            this.label20.Text = "Old Password";
            // 
            // tbEmpUserID
            // 
            this.tbEmpUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpUserID.Location = new System.Drawing.Point(519, 100);
            this.tbEmpUserID.Name = "tbEmpUserID";
            this.tbEmpUserID.Size = new System.Drawing.Size(271, 30);
            this.tbEmpUserID.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(423, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 29);
            this.label19.TabIndex = 20;
            this.label19.Text = "User Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(491, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Edit Login Info";
            // 
            // tbHome
            // 
            this.tbHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHome.Controls.Add(this.lbDesigPD);
            this.tbHome.Controls.Add(this.lbDesignation);
            this.tbHome.Controls.Add(this.lbEmpDept);
            this.tbHome.Controls.Add(this.label9);
            this.tbHome.Controls.Add(this.lbNamePD);
            this.tbHome.Controls.Add(this.lbIdPD);
            this.tbHome.Controls.Add(this.label7);
            this.tbHome.Controls.Add(this.label4);
            this.tbHome.Controls.Add(this.label3);
            this.tbHome.Controls.Add(this.label2);
            this.tbHome.Location = new System.Drawing.Point(4, 25);
            this.tbHome.Name = "tbHome";
            this.tbHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbHome.Size = new System.Drawing.Size(1162, 561);
            this.tbHome.TabIndex = 0;
            this.tbHome.Text = "Home";
            this.tbHome.UseVisualStyleBackColor = true;
            // 
            // lbDesigPD
            // 
            this.lbDesigPD.AutoSize = true;
            this.lbDesigPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesigPD.Location = new System.Drawing.Point(186, 290);
            this.lbDesigPD.Name = "lbDesigPD";
            this.lbDesigPD.Size = new System.Drawing.Size(76, 29);
            this.lbDesigPD.TabIndex = 18;
            this.lbDesigPD.Text = "Desig";
            // 
            // lbDesignation
            // 
            this.lbDesignation.AutoSize = true;
            this.lbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesignation.Location = new System.Drawing.Point(36, 290);
            this.lbDesignation.Name = "lbDesignation";
            this.lbDesignation.Size = new System.Drawing.Size(141, 29);
            this.lbDesignation.TabIndex = 17;
            this.lbDesignation.Text = "Designation";
            // 
            // lbEmpDept
            // 
            this.lbEmpDept.AutoSize = true;
            this.lbEmpDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpDept.Location = new System.Drawing.Point(186, 233);
            this.lbEmpDept.Name = "lbEmpDept";
            this.lbEmpDept.Size = new System.Drawing.Size(64, 29);
            this.lbEmpDept.TabIndex = 16;
            this.lbEmpDept.Text = "Dept";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Depatment";
            // 
            // lbNamePD
            // 
            this.lbNamePD.AutoSize = true;
            this.lbNamePD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePD.Location = new System.Drawing.Point(151, 137);
            this.lbNamePD.Name = "lbNamePD";
            this.lbNamePD.Size = new System.Drawing.Size(193, 29);
            this.lbNamePD.TabIndex = 14;
            this.lbNamePD.Text = "Employee Name";
            // 
            // lbIdPD
            // 
            this.lbIdPD.AutoSize = true;
            this.lbIdPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPD.Location = new System.Drawing.Point(151, 188);
            this.lbIdPD.Name = "lbIdPD";
            this.lbIdPD.Size = new System.Drawing.Size(148, 29);
            this.lbIdPD.TabIndex = 14;
            this.lbIdPD.Text = "Employee Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personal Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Welcome Back";
            // 
            // tab1Dashboard
            // 
            this.tab1Dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1Dashboard.Controls.Add(this.tbHome);
            this.tab1Dashboard.Controls.Add(this.tbEmpDetails);
            this.tab1Dashboard.Controls.Add(this.tbAdminLeave);
            this.tab1Dashboard.Controls.Add(this.tbLeaveRq);
            this.tab1Dashboard.Controls.Add(this.tbAttendenceReport);
            this.tab1Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab1Dashboard.Location = new System.Drawing.Point(72, 92);
            this.tab1Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tab1Dashboard.Name = "tab1Dashboard";
            this.tab1Dashboard.SelectedIndex = 0;
            this.tab1Dashboard.Size = new System.Drawing.Size(1170, 590);
            this.tab1Dashboard.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 673);
            this.panel1.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(72, 79);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1190, 10);
            this.panel7.TabIndex = 13;
            // 
            // specific_Leave_RecordTableAdapter
            // 
            this.specific_Leave_RecordTableAdapter.ClearBeforeFill = true;
            // 
            // Employee_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tab1Dashboard);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_DashBoard";
            this.Text = "Employee_DashBoard";
            this.Load += new System.EventHandler(this.Employee_DashBoard_Load);
            this.tbLeaveRq.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpLeaveReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificLeaveRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMS_DBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tbAdminLeave.ResumeLayout(false);
            this.tbAdminLeave.PerformLayout();
            this.tbAttendenceReport.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tbEmpDetails.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tbHome.ResumeLayout(false);
            this.tbHome.PerformLayout();
            this.tab1Dashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbLeaveRq;
        private System.Windows.Forms.OpenFileDialog ofdPassport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTopName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnEmpSubmit;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DateTimePicker dtpFrom_Date;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cbEmpType;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tbEmpReason;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tbEmpId;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TabPage tbAdminLeave;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TabPage tbAttendenceReport;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TabPage tbEmpDetails;
        private System.Windows.Forms.TabPage tbHome;
        private System.Windows.Forms.TabControl tab1Dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbIdPD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbEmpUserID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbNewPasswd;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtpTo_Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvEmpLeaveReport;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lbEmpDept;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRPasswd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDesigPD;
        private System.Windows.Forms.Label lbDesignation;
        private System.Windows.Forms.Label lbNamePD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbThisMonthDispatch;
        private System.Windows.Forms.Label lbLeaveCount;
        private System.Windows.Forms.Label lbCTCPackage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource specificLeaveRecordBindingSource;
        private EMS_DBDataSet eMS_DBDataSet;
        private EMS_DBDataSetTableAdapters.Specific_Leave_RecordTableAdapter specific_Leave_RecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTD;
    }
}