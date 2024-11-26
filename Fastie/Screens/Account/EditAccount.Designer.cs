namespace Fastie
{
    partial class EditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccount));
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.txtPassword = new GUI.TruniControls.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUsername = new GUI.TruniControls.CustomTextBox();
            this.btnCancel = new GUI.CustomButton();
            this.btnAdd = new GUI.CustomButton();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thông tin tài khoản";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.txtPassword);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.lblName);
            this.customPanel1.Controls.Add(this.txtUsername);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.Location = new System.Drawing.Point(26, 77);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(563, 201);
            this.customPanel1.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(24, 130);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(511, 36);
            this.txtPassword.TabIndex = 31;
            this.txtPassword.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mật khẩu";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.lblName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 21);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Tên đăng nhập: ";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.Black;
            this.txtUsername.BorderRadius = 8;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(24, 51);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.Black;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(511, 36);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UnderlinedStyle = false;
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
            this.btnCancel.Location = new System.Drawing.Point(495, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(375, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnAdd.Size = new System.Drawing.Size(114, 40);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Cập nhật";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(608, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fastie - Cập nhật thông tin tài khoản";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private GUI.TruniControls.CustomPanel customPanel1;
        private GUI.TruniControls.CustomTextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private GUI.TruniControls.CustomTextBox txtUsername;
        private GUI.CustomButton btnCancel;
        private GUI.CustomButton btnAdd;
    }
}