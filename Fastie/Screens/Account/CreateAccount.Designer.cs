namespace Fastie
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cbPosition = new GUI.TruniControls.CustomComboBox();
            this.lblBoPhan = new System.Windows.Forms.Label();
            this.cbDepartment = new GUI.TruniControls.CustomComboBox();
            this.customTextBox1 = new GUI.TruniControls.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cTBName = new GUI.TruniControls.CustomTextBox();
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
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Thông tin tài khoản";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.lblChucVu);
            this.customPanel1.Controls.Add(this.cbPosition);
            this.customPanel1.Controls.Add(this.lblBoPhan);
            this.customPanel1.Controls.Add(this.cbDepartment);
            this.customPanel1.Controls.Add(this.customTextBox1);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.lblName);
            this.customPanel1.Controls.Add(this.cTBName);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.Location = new System.Drawing.Point(19, 84);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(563, 303);
            this.customPanel1.TabIndex = 13;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(299, 201);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(54, 16);
            this.lblChucVu.TabIndex = 35;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // cbPosition
            // 
            this.cbPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPosition.BorderColor = System.Drawing.Color.Black;
            this.cbPosition.BorderRadius = 8;
            this.cbPosition.BorderSize = 1;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPosition.ForeColor = System.Drawing.Color.DimGray;
            this.cbPosition.IconColor = System.Drawing.Color.Black;
            this.cbPosition.ListBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPosition.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPosition.Location = new System.Drawing.Point(302, 232);
            this.cbPosition.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Padding = new System.Windows.Forms.Padding(1);
            this.cbPosition.Size = new System.Drawing.Size(233, 30);
            this.cbPosition.TabIndex = 34;
            this.cbPosition.Texts = "";
            this.cbPosition.OnSelectedIndexChanged += new System.EventHandler(this.cbPosition_OnSelectedIndexChanged);
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.AutoSize = true;
            this.lblBoPhan.ForeColor = System.Drawing.Color.White;
            this.lblBoPhan.Location = new System.Drawing.Point(29, 201);
            this.lblBoPhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(57, 16);
            this.lblBoPhan.TabIndex = 33;
            this.lblBoPhan.Text = "Bộ phận";
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartment.BorderColor = System.Drawing.Color.Black;
            this.cbDepartment.BorderRadius = 8;
            this.cbDepartment.BorderSize = 1;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.cbDepartment.IconColor = System.Drawing.Color.Black;
            this.cbDepartment.ListBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartment.ListTextColor = System.Drawing.Color.DimGray;
            this.cbDepartment.Location = new System.Drawing.Point(24, 232);
            this.cbDepartment.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Padding = new System.Windows.Forms.Padding(1);
            this.cbDepartment.Size = new System.Drawing.Size(233, 30);
            this.cbDepartment.TabIndex = 32;
            this.cbDepartment.Texts = "";
            this.cbDepartment.OnSelectedIndexChanged += new System.EventHandler(this.cbDepartment_OnSelectedIndexChanged);
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.White;
            this.customTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.customTextBox1.BorderRadius = 8;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.customTextBox1.ForeColor = System.Drawing.Color.Black;
            this.customTextBox1.Location = new System.Drawing.Point(24, 132);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.Black;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(511, 36);
            this.customTextBox1.TabIndex = 31;
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mật khẩu";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 16);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Tên tài khoản: ";
            // 
            // cTBName
            // 
            this.cTBName.BackColor = System.Drawing.Color.White;
            this.cTBName.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBName.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBName.BorderRadius = 8;
            this.cTBName.BorderSize = 2;
            this.cTBName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.cTBName.ForeColor = System.Drawing.Color.Black;
            this.cTBName.Location = new System.Drawing.Point(24, 51);
            this.cTBName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBName.Multiline = false;
            this.cTBName.Name = "cTBName";
            this.cTBName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBName.PasswordChar = false;
            this.cTBName.PlaceholderColor = System.Drawing.Color.Black;
            this.cTBName.PlaceholderText = "";
            this.cTBName.Size = new System.Drawing.Size(511, 36);
            this.cTBName.TabIndex = 1;
            this.cTBName.UnderlinedStyle = false;
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
            this.btnCancel.Location = new System.Drawing.Point(374, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnCancel.TabIndex = 12;
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
            this.btnAdd.Location = new System.Drawing.Point(488, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnAdd.Size = new System.Drawing.Size(94, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(607, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fastie - Tạo tài khoản";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private GUI.TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private GUI.TruniControls.CustomTextBox cTBName;
        private GUI.CustomButton btnCancel;
        private GUI.CustomButton btnAdd;
        private GUI.TruniControls.CustomTextBox customTextBox1;
        private System.Windows.Forms.Label lblBoPhan;
        private GUI.TruniControls.CustomComboBox cbDepartment;
        private System.Windows.Forms.Label lblChucVu;
        private GUI.TruniControls.CustomComboBox cbPosition;
    }
}