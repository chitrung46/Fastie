﻿namespace Fastie
{
    partial class CreateDepartmentForm
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
            this.customButton2 = new GUI.CustomButton();
            this.customButton1 = new GUI.CustomButton();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cTBEmailGroup = new GUI.TruniControls.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cTBDescribe = new GUI.TruniControls.CustomTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cTBName = new GUI.TruniControls.CustomTextBox();
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
            this.label2.Size = new System.Drawing.Size(284, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Thông tin bộ phận";
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
            this.customButton2.Location = new System.Drawing.Point(501, 406);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(81, 35);
            this.customButton2.TabIndex = 16;
            this.customButton2.Text = "Hủy";
            this.customButton2.UseVisualStyleBackColor = false;
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
            this.customButton1.Location = new System.Drawing.Point(404, 406);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(81, 35);
            this.customButton1.TabIndex = 15;
            this.customButton1.Text = "Lưu";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.cTBEmailGroup);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.cTBDescribe);
            this.customPanel1.Controls.Add(this.lblName);
            this.customPanel1.Controls.Add(this.cTBName);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.Location = new System.Drawing.Point(23, 78);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(563, 310);
            this.customPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Email nhóm bộ phận : ";
            // 
            // cTBEmailGroup
            // 
            this.cTBEmailGroup.BackColor = System.Drawing.SystemColors.Window;
            this.cTBEmailGroup.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBEmailGroup.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBEmailGroup.BorderRadius = 8;
            this.cTBEmailGroup.BorderSize = 2;
            this.cTBEmailGroup.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBEmailGroup.ForeColor = System.Drawing.Color.DimGray;
            this.cTBEmailGroup.Location = new System.Drawing.Point(26, 134);
            this.cTBEmailGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBEmailGroup.Multiline = false;
            this.cTBEmailGroup.Name = "cTBEmailGroup";
            this.cTBEmailGroup.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBEmailGroup.PasswordChar = false;
            this.cTBEmailGroup.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTBEmailGroup.PlaceholderText = "";
            this.cTBEmailGroup.Size = new System.Drawing.Size(511, 36);
            this.cTBEmailGroup.TabIndex = 33;
            this.cTBEmailGroup.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mô tả bộ phận:";
            // 
            // cTBDescribe
            // 
            this.cTBDescribe.BackColor = System.Drawing.SystemColors.Window;
            this.cTBDescribe.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBDescribe.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBDescribe.BorderRadius = 8;
            this.cTBDescribe.BorderSize = 2;
            this.cTBDescribe.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBDescribe.ForeColor = System.Drawing.Color.DimGray;
            this.cTBDescribe.Location = new System.Drawing.Point(26, 216);
            this.cTBDescribe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBDescribe.Multiline = true;
            this.cTBDescribe.Name = "cTBDescribe";
            this.cTBDescribe.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBDescribe.PasswordChar = false;
            this.cTBDescribe.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTBDescribe.PlaceholderText = "";
            this.cTBDescribe.Size = new System.Drawing.Size(509, 72);
            this.cTBDescribe.TabIndex = 24;
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
            this.lblName.Size = new System.Drawing.Size(124, 21);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Tên bộ phận: ";
            // 
            // cTBName
            // 
            this.cTBName.BackColor = System.Drawing.SystemColors.Window;
            this.cTBName.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBName.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBName.BorderRadius = 8;
            this.cTBName.BorderSize = 2;
            this.cTBName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBName.ForeColor = System.Drawing.Color.DimGray;
            this.cTBName.Location = new System.Drawing.Point(24, 51);
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
            // CreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(608, 465);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "CreateDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm bộ phận";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.CustomButton customButton2;
        private System.Windows.Forms.Label label4;
        private GUI.TruniControls.CustomTextBox cTBDescribe;
        private GUI.CustomButton customButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private GUI.TruniControls.CustomTextBox cTBName;
        private GUI.TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private GUI.TruniControls.CustomTextBox cTBEmailGroup;
    }
}