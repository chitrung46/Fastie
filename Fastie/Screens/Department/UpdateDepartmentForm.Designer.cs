namespace Fastie
{
    partial class UpdateDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDepartmentForm));
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cTBDescribe = new GUI.TruniControls.CustomTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cTBName = new GUI.TruniControls.CustomTextBox();
            this.btnCancel = new GUI.CustomButton();
            this.btnUpdate = new GUI.CustomButton();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thông tin bộ phận";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.cTBDescribe);
            this.customPanel1.Controls.Add(this.lblName);
            this.customPanel1.Controls.Add(this.cTBName);
            this.customPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.Location = new System.Drawing.Point(22, 78);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(562, 240);
            this.customPanel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mô tả bộ phận:";
            // 
            // cTBDescribe
            // 
            this.cTBDescribe.AutoScroll = true;
            this.cTBDescribe.AutoSize = true;
            this.cTBDescribe.BackColor = System.Drawing.Color.White;
            this.cTBDescribe.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBDescribe.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBDescribe.BorderRadius = 8;
            this.cTBDescribe.BorderSize = 2;
            this.cTBDescribe.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.cTBDescribe.ForeColor = System.Drawing.Color.Black;
            this.cTBDescribe.Location = new System.Drawing.Point(26, 138);
            this.cTBDescribe.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cTBDescribe.Multiline = true;
            this.cTBDescribe.Name = "cTBDescribe";
            this.cTBDescribe.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.cTBDescribe.PasswordChar = false;
            this.cTBDescribe.PlaceholderColor = System.Drawing.Color.Black;
            this.cTBDescribe.PlaceholderText = "";
            this.cTBDescribe.Size = new System.Drawing.Size(509, 72);
            this.cTBDescribe.TabIndex = 2;
            this.cTBDescribe.UnderlinedStyle = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 18);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Tên bộ phận: ";
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
            this.cTBName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cTBName.Multiline = false;
            this.cTBName.Name = "cTBName";
            this.cTBName.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.cTBName.PasswordChar = false;
            this.cTBName.PlaceholderColor = System.Drawing.Color.Black;
            this.cTBName.PlaceholderText = "";
            this.cTBName.Size = new System.Drawing.Size(511, 38);
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
            this.btnCancel.Location = new System.Drawing.Point(488, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(358, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnUpdate.Size = new System.Drawing.Size(121, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(608, 391);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fastie - Cập nhật thông tin bộ phận";
            this.Load += new System.EventHandler(this.UpdateDepartmentForm_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private GUI.TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label label4;
        private GUI.TruniControls.CustomTextBox cTBDescribe;
        private System.Windows.Forms.Label lblName;
        private GUI.TruniControls.CustomTextBox cTBName;
        private GUI.CustomButton btnCancel;
        private GUI.CustomButton btnUpdate;
    }
}