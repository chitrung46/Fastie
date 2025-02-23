﻿namespace Fastie.Screens.Task
{
    partial class DetailAssignPositiveTaskForm
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
            this.dtpTimeCompleted = new System.Windows.Forms.DateTimePicker();
            this.customComboBox1 = new GUI.TruniControls.CustomComboBox();
            this.cTBDescribeTask = new GUI.TruniControls.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTaskName = new GUI.TruniControls.CustomTextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.customTextBox1 = new GUI.TruniControls.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDepartment = new GUI.TruniControls.CustomComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl2 = new GUI.TruniControls.CustomPanel();
            this.customButton3 = new GUI.CustomButton();
            this.customButton5 = new GUI.CustomButton();
            this.customButton4 = new GUI.CustomButton();
            this.customButton2 = new GUI.CustomButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbxPersonnel = new GUI.TruniControls.CustomComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUploadImage = new GUI.CustomButton();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUploadFile = new GUI.CustomButton();
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.lblNameOfForm = new System.Windows.Forms.Label();
            this.btnCancel = new GUI.CustomButton();
            this.btnUpdate = new GUI.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpTimeCompleted
            // 
            this.dtpTimeCompleted.CalendarFont = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.dtpTimeCompleted.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpTimeCompleted.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeCompleted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeCompleted.Location = new System.Drawing.Point(227, 346);
            this.dtpTimeCompleted.MaximumSize = new System.Drawing.Size(500, 30);
            this.dtpTimeCompleted.Name = "dtpTimeCompleted";
            this.dtpTimeCompleted.Size = new System.Drawing.Size(365, 27);
            this.dtpTimeCompleted.TabIndex = 4;
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.White;
            this.customComboBox1.BorderColor = System.Drawing.Color.Black;
            this.customComboBox1.BorderRadius = 8;
            this.customComboBox1.BorderSize = 0;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.customComboBox1.ForeColor = System.Drawing.Color.White;
            this.customComboBox1.IconColor = System.Drawing.Color.Black;
            this.customComboBox1.ListBackColor = System.Drawing.Color.White;
            this.customComboBox1.ListTextColor = System.Drawing.Color.Black;
            this.customComboBox1.Location = new System.Drawing.Point(25, 129);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(567, 36);
            this.customComboBox1.TabIndex = 2;
            this.customComboBox1.Texts = "";
            this.customComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.customComboBox1_OnSelectedIndexChanged);
            // 
            // cTBDescribeTask
            // 
            this.cTBDescribeTask.BackColor = System.Drawing.Color.White;
            this.cTBDescribeTask.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBDescribeTask.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBDescribeTask.BorderRadius = 8;
            this.cTBDescribeTask.BorderSize = 2;
            this.cTBDescribeTask.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBDescribeTask.ForeColor = System.Drawing.Color.Black;
            this.cTBDescribeTask.Location = new System.Drawing.Point(26, 218);
            this.cTBDescribeTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBDescribeTask.Multiline = true;
            this.cTBDescribeTask.Name = "cTBDescribeTask";
            this.cTBDescribeTask.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBDescribeTask.PasswordChar = false;
            this.cTBDescribeTask.PlaceholderColor = System.Drawing.Color.Black;
            this.cTBDescribeTask.PlaceholderText = "";
            this.cTBDescribeTask.Size = new System.Drawing.Size(567, 108);
            this.cTBDescribeTask.TabIndex = 3;
            this.cTBDescribeTask.UnderlinedStyle = false;
            this.cTBDescribeTask.Load += new System.EventHandler(this.cTBDescribeTask_Load);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Thời hạn hoàn thành: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mô tả công việc: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Loại công việc: ";
            // 
            // txbTaskName
            // 
            this.txbTaskName.BackColor = System.Drawing.Color.White;
            this.txbTaskName.BorderColor = System.Drawing.Color.DarkGray;
            this.txbTaskName.BorderFocusColor = System.Drawing.Color.Black;
            this.txbTaskName.BorderRadius = 8;
            this.txbTaskName.BorderSize = 2;
            this.txbTaskName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaskName.ForeColor = System.Drawing.Color.Black;
            this.txbTaskName.Location = new System.Drawing.Point(25, 48);
            this.txbTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTaskName.Multiline = false;
            this.txbTaskName.Name = "txbTaskName";
            this.txbTaskName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbTaskName.PasswordChar = false;
            this.txbTaskName.PlaceholderColor = System.Drawing.Color.Black;
            this.txbTaskName.PlaceholderText = "";
            this.txbTaskName.Size = new System.Drawing.Size(568, 36);
            this.txbTaskName.TabIndex = 1;
            this.txbTaskName.UnderlinedStyle = false;
            this.txbTaskName.Load += new System.EventHandler(this.txbTaskName_Load);
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(25, 14);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(129, 21);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Tên công việc: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 109);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.customTextBox1);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.dtpTimeCompleted);
            this.customPanel1.Controls.Add(this.customComboBox1);
            this.customPanel1.Controls.Add(this.cTBDescribeTask);
            this.customPanel1.Controls.Add(this.label7);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.txbTaskName);
            this.customPanel1.Controls.Add(this.lblTaskName);
            this.customPanel1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.Location = new System.Drawing.Point(22, 62);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(624, 442);
            this.customPanel1.TabIndex = 45;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.White;
            this.customTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.customTextBox1.BorderRadius = 8;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.Black;
            this.customTextBox1.Location = new System.Drawing.Point(284, 388);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.Black;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(60, 36);
            this.customTextBox1.TabIndex = 5;
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Số lượng nhân sự chủ động:";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.BackColor = System.Drawing.Color.White;
            this.cbxDepartment.BorderColor = System.Drawing.Color.Black;
            this.cbxDepartment.BorderRadius = 8;
            this.cbxDepartment.BorderSize = 0;
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.cbxDepartment.IconColor = System.Drawing.Color.Black;
            this.cbxDepartment.ListBackColor = System.Drawing.Color.White;
            this.cbxDepartment.ListTextColor = System.Drawing.Color.Black;
            this.cbxDepartment.Location = new System.Drawing.Point(30, 45);
            this.cbxDepartment.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(298, 36);
            this.cbxDepartment.TabIndex = 6;
            this.cbxDepartment.Texts = "";
            this.cbxDepartment.OnSelectedIndexChanged += new System.EventHandler(this.cbxDepartment_OnSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Người nhận việc:";
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnl2.BorderColor = System.Drawing.Color.Black;
            this.pnl2.BorderRadius = 30;
            this.pnl2.BorderSize = 0;
            this.pnl2.Controls.Add(this.customButton3);
            this.pnl2.Controls.Add(this.customButton5);
            this.pnl2.Controls.Add(this.customButton4);
            this.pnl2.Controls.Add(this.customButton2);
            this.pnl2.Controls.Add(this.dataGridView1);
            this.pnl2.Controls.Add(this.dataGridView2);
            this.pnl2.Controls.Add(this.cbxPersonnel);
            this.pnl2.Controls.Add(this.cbxDepartment);
            this.pnl2.Controls.Add(this.label5);
            this.pnl2.Controls.Add(this.label6);
            this.pnl2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl2.ForeColor = System.Drawing.Color.Black;
            this.pnl2.GradientAngle = 90F;
            this.pnl2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnl2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnl2.Location = new System.Drawing.Point(652, 62);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(470, 442);
            this.pnl2.TabIndex = 47;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customButton3.BorderColor = System.Drawing.Color.White;
            this.customButton3.BorderRadius = 15;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Image = global::Fastie.Properties.Resources.icons8_delete_23;
            this.customButton3.Location = new System.Drawing.Point(397, 258);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(42, 36);
            this.customButton3.TabIndex = 47;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            this.customButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.customButton5.BorderColor = System.Drawing.Color.White;
            this.customButton5.BorderRadius = 15;
            this.customButton5.BorderSize = 0;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.ForeColor = System.Drawing.Color.White;
            this.customButton5.Image = global::Fastie.Properties.Resources.icons8_plus_23;
            this.customButton5.Location = new System.Drawing.Point(349, 258);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(42, 36);
            this.customButton5.TabIndex = 46;
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customButton4.BorderColor = System.Drawing.Color.White;
            this.customButton4.BorderRadius = 15;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Image = global::Fastie.Properties.Resources.icons8_delete_23;
            this.customButton4.Location = new System.Drawing.Point(397, 45);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(42, 36);
            this.customButton4.TabIndex = 45;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.customButton2.BorderColor = System.Drawing.Color.White;
            this.customButton2.BorderRadius = 15;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Image = global::Fastie.Properties.Resources.icons8_plus_23;
            this.customButton2.Location = new System.Drawing.Point(349, 45);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(42, 36);
            this.customButton2.TabIndex = 43;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 317);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(410, 107);
            this.dataGridView2.TabIndex = 9;
            // 
            // cbxPersonnel
            // 
            this.cbxPersonnel.BackColor = System.Drawing.Color.White;
            this.cbxPersonnel.BorderColor = System.Drawing.Color.Black;
            this.cbxPersonnel.BorderRadius = 8;
            this.cbxPersonnel.BorderSize = 0;
            this.cbxPersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxPersonnel.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.cbxPersonnel.ForeColor = System.Drawing.Color.DimGray;
            this.cbxPersonnel.IconColor = System.Drawing.Color.Black;
            this.cbxPersonnel.ListBackColor = System.Drawing.Color.White;
            this.cbxPersonnel.ListTextColor = System.Drawing.Color.Black;
            this.cbxPersonnel.Location = new System.Drawing.Point(29, 258);
            this.cbxPersonnel.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxPersonnel.Name = "cbxPersonnel";
            this.cbxPersonnel.Size = new System.Drawing.Size(299, 36);
            this.cbxPersonnel.TabIndex = 8;
            this.cbxPersonnel.Texts = "";
            this.cbxPersonnel.OnSelectedIndexChanged += new System.EventHandler(this.cbxPersonnel_OnSelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bộ phận nhận việc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(630, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 21);
            this.label9.TabIndex = 40;
            this.label9.Text = "objectdiagram.png";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(663, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 21);
            this.label10.TabIndex = 42;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnUploadImage.BorderColor = System.Drawing.Color.White;
            this.btnUploadImage.BorderRadius = 15;
            this.btnUploadImage.BorderSize = 0;
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Location = new System.Drawing.Point(496, 13);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(128, 40);
            this.btnUploadImage.TabIndex = 11;
            this.btnUploadImage.Text = "Upload ảnh";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(159, 23);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(73, 21);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "n2.docx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(195, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 39;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnUploadFile.BorderColor = System.Drawing.Color.White;
            this.btnUploadFile.BorderRadius = 15;
            this.btnUploadFile.BorderSize = 0;
            this.btnUploadFile.FlatAppearance.BorderSize = 0;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.ForeColor = System.Drawing.Color.White;
            this.btnUploadFile.Location = new System.Drawing.Point(25, 13);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(128, 40);
            this.btnUploadFile.TabIndex = 10;
            this.btnUploadFile.Text = "Upload file";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.BorderColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.label9);
            this.customPanel2.Controls.Add(this.label10);
            this.customPanel2.Controls.Add(this.btnUploadImage);
            this.customPanel2.Controls.Add(this.lblFileName);
            this.customPanel2.Controls.Add(this.label8);
            this.customPanel2.Controls.Add(this.btnUploadFile);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.Location = new System.Drawing.Point(22, 509);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1100, 68);
            this.customPanel2.TabIndex = 48;
            // 
            // lblNameOfForm
            // 
            this.lblNameOfForm.AutoSize = true;
            this.lblNameOfForm.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfForm.ForeColor = System.Drawing.Color.White;
            this.lblNameOfForm.Location = new System.Drawing.Point(22, 18);
            this.lblNameOfForm.Name = "lblNameOfForm";
            this.lblNameOfForm.Size = new System.Drawing.Size(247, 32);
            this.lblNameOfForm.TabIndex = 46;
            this.lblNameOfForm.Text = "Giao việc chủ động";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1028, 592);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(928, 592);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnUpdate.Size = new System.Drawing.Size(94, 40);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Lưu";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // DetailAssignPositiveTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1142, 647);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.lblNameOfForm);
            this.Name = "DetailAssignPositiveTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fastie - Giao việc chủ động";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GUI.CustomButton customButton2;
        private System.Windows.Forms.DateTimePicker dtpTimeCompleted;
        private GUI.TruniControls.CustomComboBox customComboBox1;
        private GUI.TruniControls.CustomTextBox cTBDescribeTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GUI.TruniControls.CustomTextBox txbTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private GUI.CustomButton customButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GUI.TruniControls.CustomPanel customPanel1;
        private GUI.TruniControls.CustomComboBox cbxDepartment;
        private System.Windows.Forms.Label label5;
        private GUI.TruniControls.CustomPanel pnl2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private GUI.CustomButton btnUploadImage;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label8;
        private GUI.CustomButton btnUploadFile;
        private GUI.TruniControls.CustomPanel customPanel2;
        private System.Windows.Forms.Label lblNameOfForm;
        private GUI.CustomButton customButton3;
        private GUI.CustomButton customButton5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GUI.TruniControls.CustomComboBox cbxPersonnel;
        private GUI.TruniControls.CustomTextBox customTextBox1;
        private System.Windows.Forms.Label label3;
        private GUI.CustomButton btnCancel;
        private GUI.CustomButton btnUpdate;
    }
}