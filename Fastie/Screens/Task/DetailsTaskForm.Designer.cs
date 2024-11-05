namespace Fastie.Screens.Task
{
    partial class DetailsTaskForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.customButton1 = new GUI.CustomButton();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.customTextBox1 = new GUI.TruniControls.CustomTextBox();
            this.dtpTimeCompleted = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.customComboBox1 = new GUI.TruniControls.CustomComboBox();
            this.cTBDescribeTask = new GUI.TruniControls.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTaskName = new GUI.TruniControls.CustomTextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.pnl2 = new GUI.TruniControls.CustomPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbxPersonnel = new GUI.TruniControls.CustomComboBox();
            this.cbxDepartment = new GUI.TruniControls.CustomComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.customButton2 = new GUI.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUploadFile = new GUI.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 32);
            this.label3.TabIndex = 41;
            this.label3.Text = "Chi tiết công việc";
            // 
            // pictureBack
            // 
            this.pictureBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBack.Image = global::Fastie.Properties.Resources.icons8_back_100;
            this.pictureBack.Location = new System.Drawing.Point(35, 16);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(20, 20);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBack.TabIndex = 45;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(57, 14);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(72, 21);
            this.lblBack.TabIndex = 41;
            this.lblBack.Text = "Quay lại";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 15;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(919, 59);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(137, 40);
            this.customButton1.TabIndex = 43;
            this.customButton1.Text = "Công việc gốc";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.customTextBox1);
            this.customPanel1.Controls.Add(this.dtpTimeCompleted);
            this.customPanel1.Controls.Add(this.label4);
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
            this.customPanel1.Location = new System.Drawing.Point(12, 113);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(610, 430);
            this.customPanel1.TabIndex = 40;
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
            this.customTextBox1.Location = new System.Drawing.Point(351, 376);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.Black;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(233, 36);
            this.customTextBox1.TabIndex = 46;
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // dtpTimeCompleted
            // 
            this.dtpTimeCompleted.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.dtpTimeCompleted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeCompleted.Location = new System.Drawing.Point(28, 385);
            this.dtpTimeCompleted.MaximumSize = new System.Drawing.Size(500, 30);
            this.dtpTimeCompleted.Name = "dtpTimeCompleted";
            this.dtpTimeCompleted.Size = new System.Drawing.Size(244, 26);
            this.dtpTimeCompleted.TabIndex = 4;
            this.dtpTimeCompleted.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(347, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số lượng nhân sự chủ động:";
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.White;
            this.customComboBox1.BorderColor = System.Drawing.Color.Black;
            this.customComboBox1.BorderRadius = 8;
            this.customComboBox1.BorderSize = 0;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.customComboBox1.ForeColor = System.Drawing.Color.Black;
            this.customComboBox1.IconColor = System.Drawing.Color.Black;
            this.customComboBox1.ListBackColor = System.Drawing.Color.White;
            this.customComboBox1.ListTextColor = System.Drawing.Color.Black;
            this.customComboBox1.Location = new System.Drawing.Point(28, 132);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(556, 36);
            this.customComboBox1.TabIndex = 2;
            this.customComboBox1.Texts = "";
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
            this.cTBDescribeTask.Location = new System.Drawing.Point(29, 221);
            this.cTBDescribeTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBDescribeTask.Multiline = true;
            this.cTBDescribeTask.Name = "cTBDescribeTask";
            this.cTBDescribeTask.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBDescribeTask.PasswordChar = false;
            this.cTBDescribeTask.PlaceholderColor = System.Drawing.Color.Black;
            this.cTBDescribeTask.PlaceholderText = "";
            this.cTBDescribeTask.Size = new System.Drawing.Size(555, 108);
            this.cTBDescribeTask.TabIndex = 3;
            this.cTBDescribeTask.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Thời hạn hoàn thành: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mô tả công việc: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 96);
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
            this.txbTaskName.Location = new System.Drawing.Point(28, 51);
            this.txbTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTaskName.Multiline = false;
            this.txbTaskName.Name = "txbTaskName";
            this.txbTaskName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbTaskName.PasswordChar = false;
            this.txbTaskName.PlaceholderColor = System.Drawing.Color.Black;
            this.txbTaskName.PlaceholderText = "";
            this.txbTaskName.Size = new System.Drawing.Size(556, 36);
            this.txbTaskName.TabIndex = 1;
            this.txbTaskName.UnderlinedStyle = false;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(28, 17);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(129, 21);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Tên công việc: ";
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnl2.BorderColor = System.Drawing.Color.Black;
            this.pnl2.BorderRadius = 30;
            this.pnl2.BorderSize = 0;
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
            this.pnl2.Location = new System.Drawing.Point(628, 113);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(457, 430);
            this.pnl2.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(33, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(395, 96);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(32, 316);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(396, 96);
            this.dataGridView2.TabIndex = 8;
            // 
            // cbxPersonnel
            // 
            this.cbxPersonnel.BackColor = System.Drawing.Color.White;
            this.cbxPersonnel.BorderColor = System.Drawing.Color.Black;
            this.cbxPersonnel.BorderRadius = 8;
            this.cbxPersonnel.BorderSize = 0;
            this.cbxPersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxPersonnel.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.cbxPersonnel.ForeColor = System.Drawing.Color.Black;
            this.cbxPersonnel.IconColor = System.Drawing.Color.Black;
            this.cbxPersonnel.ListBackColor = System.Drawing.Color.White;
            this.cbxPersonnel.ListTextColor = System.Drawing.Color.Black;
            this.cbxPersonnel.Location = new System.Drawing.Point(32, 257);
            this.cbxPersonnel.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxPersonnel.Name = "cbxPersonnel";
            this.cbxPersonnel.Size = new System.Drawing.Size(396, 36);
            this.cbxPersonnel.TabIndex = 7;
            this.cbxPersonnel.Texts = "";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.BackColor = System.Drawing.Color.White;
            this.cbxDepartment.BorderColor = System.Drawing.Color.Black;
            this.cbxDepartment.BorderRadius = 8;
            this.cbxDepartment.BorderSize = 0;
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxDepartment.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.cbxDepartment.ForeColor = System.Drawing.Color.Black;
            this.cbxDepartment.IconColor = System.Drawing.Color.Black;
            this.cbxDepartment.ListBackColor = System.Drawing.Color.White;
            this.cbxDepartment.ListTextColor = System.Drawing.Color.Black;
            this.cbxDepartment.Location = new System.Drawing.Point(33, 51);
            this.cbxDepartment.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(395, 36);
            this.cbxDepartment.TabIndex = 5;
            this.cbxDepartment.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Người nhận việc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bộ phận nhận việc:";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.BorderColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.customButton2);
            this.customPanel2.Controls.Add(this.pictureBox1);
            this.customPanel2.Controls.Add(this.label10);
            this.customPanel2.Controls.Add(this.lblFileName);
            this.customPanel2.Controls.Add(this.label8);
            this.customPanel2.Controls.Add(this.btnUploadFile);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.Location = new System.Drawing.Point(12, 549);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1073, 262);
            this.customPanel2.TabIndex = 45;
            this.customPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel2_Paint);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.customButton2.BorderColor = System.Drawing.Color.White;
            this.customButton2.BorderRadius = 15;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(351, 19);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(141, 40);
            this.customButton2.TabIndex = 44;
            this.customButton2.Text = "Tải xuống ảnh";
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fastie.Properties.Resources.z5866322563222_7c9b9873ee9ceed252ea45f87aeb13ff;
            this.pictureBox1.Location = new System.Drawing.Point(351, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(666, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 21);
            this.label10.TabIndex = 42;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(162, 29);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(73, 21);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "n2.docx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 29);
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
            this.btnUploadFile.Location = new System.Drawing.Point(28, 19);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(128, 40);
            this.btnUploadFile.TabIndex = 9;
            this.btnUploadFile.Text = "Tải xuống file";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            // 
            // DetailsTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1120, 847);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1120, 573);
            this.Name = "DetailsTaskForm";
            this.Text = "DetailsTaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpTimeCompleted;
        private GUI.TruniControls.CustomComboBox customComboBox1;
        private GUI.TruniControls.CustomTextBox cTBDescribeTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GUI.TruniControls.CustomTextBox txbTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GUI.TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GUI.TruniControls.CustomComboBox cbxDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private GUI.TruniControls.CustomPanel pnl2;
        private GUI.TruniControls.CustomComboBox cbxPersonnel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label8;
        private GUI.TruniControls.CustomPanel customPanel2;
        private System.Windows.Forms.Label label3;
        private GUI.TruniControls.CustomTextBox customTextBox1;
        private System.Windows.Forms.Label label4;
        private GUI.CustomButton customButton1;
        private GUI.CustomButton customButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GUI.CustomButton btnUploadFile;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.Label lblBack;
    }
}