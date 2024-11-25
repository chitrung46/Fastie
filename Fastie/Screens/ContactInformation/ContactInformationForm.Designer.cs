namespace Fastie.Screens.ContactInformation
{
    partial class ContactInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactInformationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTypeRequest = new GUI.TruniControls.CustomComboBox();
            this.btnSend = new GUI.CustomButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescribe = new GUI.TruniControls.CustomTextBox();
            this.txtNumberphone = new GUI.TruniControls.CustomTextBox();
            this.txtEmail = new GUI.TruniControls.CustomTextBox();
            this.txtName = new GUI.TruniControls.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cbTypeRequest);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescribe);
            this.panel1.Controls.Add(this.txtNumberphone);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 624);
            this.panel1.TabIndex = 0;
            // 
            // cbTypeRequest
            // 
            this.cbTypeRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTypeRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cbTypeRequest.BorderColor = System.Drawing.Color.Transparent;
            this.cbTypeRequest.BorderRadius = 0;
            this.cbTypeRequest.BorderSize = 1;
            this.cbTypeRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTypeRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTypeRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTypeRequest.ForeColor = System.Drawing.Color.White;
            this.cbTypeRequest.IconColor = System.Drawing.Color.White;
            this.cbTypeRequest.Items.AddRange(new object[] {
            "Góp ý tính năng",
            "Lỗi phần mềm",
            "Hướng dẫn sử dụng",
            "Vấn đề tài khoản",
            "Khác"});
            this.cbTypeRequest.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cbTypeRequest.ListTextColor = System.Drawing.Color.White;
            this.cbTypeRequest.Location = new System.Drawing.Point(520, 256);
            this.cbTypeRequest.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTypeRequest.Name = "cbTypeRequest";
            this.cbTypeRequest.Padding = new System.Windows.Forms.Padding(1);
            this.cbTypeRequest.Size = new System.Drawing.Size(286, 36);
            this.cbTypeRequest.TabIndex = 4;
            this.cbTypeRequest.Texts = "Chọn";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnSend.BorderRadius = 15;
            this.btnSend.BorderSize = 0;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(354, 548);
            this.btnSend.Name = "btnSend";
            this.btnSend.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnSend.Size = new System.Drawing.Size(286, 40);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Gửi yêu cầu";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(516, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Mô tả chi tiết";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(516, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Loại yêu cầu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(163, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Số điện thoại";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(163, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(163, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên người dùng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescribe
            // 
            this.txtDescribe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtDescribe.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDescribe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.txtDescribe.BorderRadius = 15;
            this.txtDescribe.BorderSize = 1;
            this.txtDescribe.Font = new System.Drawing.Font("Montserrat Alternates Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescribe.ForeColor = System.Drawing.Color.White;
            this.txtDescribe.Location = new System.Drawing.Point(520, 354);
            this.txtDescribe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtDescribe.PasswordChar = false;
            this.txtDescribe.PlaceholderColor = System.Drawing.Color.White;
            this.txtDescribe.PlaceholderText = "";
            this.txtDescribe.Size = new System.Drawing.Size(286, 129);
            this.txtDescribe.TabIndex = 5;
            this.txtDescribe.UnderlinedStyle = false;
            // 
            // txtNumberphone
            // 
            this.txtNumberphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumberphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtNumberphone.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNumberphone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.txtNumberphone.BorderRadius = 15;
            this.txtNumberphone.BorderSize = 1;
            this.txtNumberphone.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberphone.ForeColor = System.Drawing.Color.White;
            this.txtNumberphone.Location = new System.Drawing.Point(167, 447);
            this.txtNumberphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberphone.Multiline = false;
            this.txtNumberphone.Name = "txtNumberphone";
            this.txtNumberphone.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtNumberphone.PasswordChar = false;
            this.txtNumberphone.PlaceholderColor = System.Drawing.Color.White;
            this.txtNumberphone.PlaceholderText = "";
            this.txtNumberphone.Size = new System.Drawing.Size(286, 36);
            this.txtNumberphone.TabIndex = 3;
            this.txtNumberphone.UnderlinedStyle = false;
            this.txtNumberphone._TextChanged += new System.EventHandler(this.txtNumberphone__TextChanged);
            this.txtNumberphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberphone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(167, 354);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.White;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(286, 36);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.txtName.BorderRadius = 15;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(167, 256);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.White;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(286, 36);
            this.txtName.TabIndex = 1;
            this.txtName.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(965, 42);
            this.label3.TabIndex = 20;
            this.label3.Text = "Chúng tôi luôn sẵn sàng lắng nghe và hỗ trợ bạn! Vui lòng cung cấp đầy đủ thông t" +
    "in dưới đây để giúp chúng tôi xử lý\r\n yêu cầu của bạn một cách nhanh chóng và hi" +
    "ệu quả.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.panel2.Location = new System.Drawing.Point(447, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 5);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Liên hệ với chúng tôi để được hỗ trợ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(419, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "ĐỘI NGŨ FIRON";
            // 
            // ContactInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1164, 648);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fastie - Thông tin liên hệ";
            this.Load += new System.EventHandler(this.ContactInformationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GUI.TruniControls.CustomComboBox cbTypeRequest;
        private GUI.CustomButton btnSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private GUI.TruniControls.CustomTextBox txtDescribe;
        private GUI.TruniControls.CustomTextBox txtNumberphone;
        private GUI.TruniControls.CustomTextBox txtEmail;
        private GUI.TruniControls.CustomTextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}