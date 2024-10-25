namespace Fastie
{
    partial class CreatePersonnelForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.customButton1 = new GUI.CustomButton();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cTBEmail = new GUI.TruniControls.CustomTextBox();
            this.dTPDayOfWork = new System.Windows.Forms.DateTimePicker();
            this.lblSex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cTBNumberPhone = new GUI.TruniControls.CustomTextBox();
            this.cTBName = new GUI.TruniControls.CustomTextBox();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.dTPBirthday = new System.Windows.Forms.DateTimePicker();
            this.cCBSex = new GUI.TruniControls.CustomComboBox();
            this.customButton2 = new GUI.CustomButton();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thông tin nhân sự";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 8;
            this.customButton1.BorderSize = 2;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(403, 364);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(81, 35);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "Lưu";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.cTBEmail);
            this.customPanel1.Controls.Add(this.dTPDayOfWork);
            this.customPanel1.Controls.Add(this.lblSex);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.lblName);
            this.customPanel1.Controls.Add(this.cTBNumberPhone);
            this.customPanel1.Controls.Add(this.cTBName);
            this.customPanel1.Controls.Add(this.lblBirthDay);
            this.customPanel1.Controls.Add(this.dTPBirthday);
            this.customPanel1.Controls.Add(this.cCBSex);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.Location = new System.Drawing.Point(23, 78);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(563, 266);
            this.customPanel1.TabIndex = 4;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email:";
            // 
            // cTBEmail
            // 
            this.cTBEmail.BackColor = System.Drawing.SystemColors.Window;
            this.cTBEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBEmail.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBEmail.BorderRadius = 8;
            this.cTBEmail.BorderSize = 2;
            this.cTBEmail.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.cTBEmail.ForeColor = System.Drawing.Color.DimGray;
            this.cTBEmail.Location = new System.Drawing.Point(26, 123);
            this.cTBEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBEmail.Multiline = false;
            this.cTBEmail.Name = "cTBEmail";
            this.cTBEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBEmail.PasswordChar = false;
            this.cTBEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTBEmail.PlaceholderText = "";
            this.cTBEmail.Size = new System.Drawing.Size(266, 36);
            this.cTBEmail.TabIndex = 24;
            this.cTBEmail.UnderlinedStyle = false;
            // 
            // dTPDayOfWork
            // 
            this.dTPDayOfWork.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.dTPDayOfWork.Location = new System.Drawing.Point(308, 211);
            this.dTPDayOfWork.Name = "dTPDayOfWork";
            this.dTPDayOfWork.Size = new System.Drawing.Size(226, 27);
            this.dTPDayOfWork.TabIndex = 32;
            this.dTPDayOfWork.Value = new System.DateTime(2024, 10, 24, 1, 12, 8, 0);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.Location = new System.Drawing.Point(29, 179);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(92, 21);
            this.lblSex.TabIndex = 22;
            this.lblSex.Text = "Giới tính: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "SĐT: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ngày sinh: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 21);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Họ tên: ";
            // 
            // cTBNumberPhone
            // 
            this.cTBNumberPhone.BackColor = System.Drawing.SystemColors.Window;
            this.cTBNumberPhone.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBNumberPhone.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBNumberPhone.BorderRadius = 8;
            this.cTBNumberPhone.BorderSize = 2;
            this.cTBNumberPhone.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.cTBNumberPhone.ForeColor = System.Drawing.Color.DimGray;
            this.cTBNumberPhone.Location = new System.Drawing.Point(148, 205);
            this.cTBNumberPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBNumberPhone.Multiline = false;
            this.cTBNumberPhone.Name = "cTBNumberPhone";
            this.cTBNumberPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBNumberPhone.PasswordChar = false;
            this.cTBNumberPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTBNumberPhone.PlaceholderText = "";
            this.cTBNumberPhone.Size = new System.Drawing.Size(144, 36);
            this.cTBNumberPhone.TabIndex = 27;
            this.cTBNumberPhone.UnderlinedStyle = false;
            // 
            // cTBName
            // 
            this.cTBName.BackColor = System.Drawing.SystemColors.Window;
            this.cTBName.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBName.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBName.BorderRadius = 8;
            this.cTBName.BorderSize = 2;
            this.cTBName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.cTBName.ForeColor = System.Drawing.Color.DimGray;
            this.cTBName.Location = new System.Drawing.Point(24, 45);
            this.cTBName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBName.Multiline = false;
            this.cTBName.Name = "cTBName";
            this.cTBName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBName.PasswordChar = false;
            this.cTBName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTBName.PlaceholderText = "";
            this.cTBName.Size = new System.Drawing.Size(511, 36);
            this.cTBName.TabIndex = 31;
            this.cTBName.UnderlinedStyle = false;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.ForeColor = System.Drawing.Color.White;
            this.lblBirthDay.Location = new System.Drawing.Point(311, 180);
            this.lblBirthDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(134, 21);
            this.lblBirthDay.TabIndex = 23;
            this.lblBirthDay.Text = "Ngày vào làm: ";
            // 
            // dTPBirthday
            // 
            this.dTPBirthday.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPBirthday.Location = new System.Drawing.Point(308, 129);
            this.dTPBirthday.Name = "dTPBirthday";
            this.dTPBirthday.Size = new System.Drawing.Size(225, 27);
            this.dTPBirthday.TabIndex = 25;
            this.dTPBirthday.Value = new System.DateTime(2024, 10, 24, 1, 12, 8, 0);
            this.dTPBirthday.ValueChanged += new System.EventHandler(this.dTPBirtday_ValueChanged);
            // 
            // cCBSex
            // 
            this.cCBSex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cCBSex.BorderColor = System.Drawing.Color.Gainsboro;
            this.cCBSex.BorderRadius = 8;
            this.cCBSex.BorderSize = 1;
            this.cCBSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cCBSex.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.cCBSex.ForeColor = System.Drawing.Color.DimGray;
            this.cCBSex.IconColor = System.Drawing.Color.Black;
            this.cCBSex.ListBackColor = System.Drawing.Color.WhiteSmoke;
            this.cCBSex.ListTextColor = System.Drawing.Color.DimGray;
            this.cCBSex.Location = new System.Drawing.Point(26, 207);
            this.cCBSex.MinimumSize = new System.Drawing.Size(100, 30);
            this.cCBSex.Name = "cCBSex";
            this.cCBSex.Padding = new System.Windows.Forms.Padding(1);
            this.cCBSex.Size = new System.Drawing.Size(106, 30);
            this.cCBSex.TabIndex = 26;
            this.cCBSex.Texts = "";
            this.cCBSex.OnSelectedIndexChanged += new System.EventHandler(this.customComboBox1_OnSelectedIndexChanged_2);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customButton2.BorderColor = System.Drawing.Color.White;
            this.customButton2.BorderRadius = 8;
            this.customButton2.BorderSize = 2;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(500, 364);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(81, 35);
            this.customButton2.TabIndex = 7;
            this.customButton2.Text = "Hủy";
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // CreatePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(608, 418);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreatePersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân sự";
            this.Load += new System.EventHandler(this.CreatePersonnel_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GUI.TruniControls.CustomPanel customPanel1;
        private GUI.TruniControls.CustomTextBox cTBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private GUI.TruniControls.CustomTextBox cTBNumberPhone;
        private GUI.TruniControls.CustomComboBox cCBSex;
        private System.Windows.Forms.DateTimePicker dTPBirthday;
        private GUI.TruniControls.CustomTextBox cTBEmail;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dTPDayOfWork;
        private System.Windows.Forms.Label label2;
        private GUI.CustomButton customButton1;
        private GUI.CustomButton customButton2;

        
    }
}