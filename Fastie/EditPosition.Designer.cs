namespace Fastie
{
    partial class EditPosition
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
            this.customButton2 = new GUI.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cTBDescription = new GUI.TruniControls.CustomTextBox();
            this.customButton1 = new GUI.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cTBNamePosition = new GUI.TruniControls.CustomTextBox();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.customButton2.Location = new System.Drawing.Point(500, 299);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(81, 35);
            this.customButton2.TabIndex = 16;
            this.customButton2.Text = "Hủy";
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mô tả chức vụ:";
            // 
            // cTBDescription
            // 
            this.cTBDescription.BackColor = System.Drawing.SystemColors.Window;
            this.cTBDescription.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBDescription.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBDescription.BorderRadius = 8;
            this.cTBDescription.BorderSize = 2;
            this.cTBDescription.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBDescription.ForeColor = System.Drawing.Color.DimGray;
            this.cTBDescription.Location = new System.Drawing.Point(26, 131);
            this.cTBDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBDescription.Multiline = true;
            this.cTBDescription.Name = "cTBDescription";
            this.cTBDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBDescription.PasswordChar = false;
            this.cTBDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTBDescription.PlaceholderText = "";
            this.cTBDescription.Size = new System.Drawing.Size(509, 35);
            this.cTBDescription.TabIndex = 24;
            this.cTBDescription.UnderlinedStyle = false;
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
            this.customButton1.Location = new System.Drawing.Point(403, 299);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(81, 35);
            this.customButton1.TabIndex = 15;
            this.customButton1.Text = "Lưu";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Thông tin chức vụ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 21);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Tên chức vụ: ";
            // 
            // cTBNamePosition
            // 
            this.cTBNamePosition.BackColor = System.Drawing.SystemColors.Window;
            this.cTBNamePosition.BorderColor = System.Drawing.Color.DarkGray;
            this.cTBNamePosition.BorderFocusColor = System.Drawing.Color.Black;
            this.cTBNamePosition.BorderRadius = 8;
            this.cTBNamePosition.BorderSize = 2;
            this.cTBNamePosition.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBNamePosition.ForeColor = System.Drawing.Color.DimGray;
            this.cTBNamePosition.Location = new System.Drawing.Point(24, 51);
            this.cTBNamePosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cTBNamePosition.Multiline = false;
            this.cTBNamePosition.Name = "cTBNamePosition";
            this.cTBNamePosition.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTBNamePosition.PasswordChar = false;
            this.cTBNamePosition.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTBNamePosition.PlaceholderText = "";
            this.cTBNamePosition.Size = new System.Drawing.Size(511, 36);
            this.cTBNamePosition.TabIndex = 31;
            this.cTBNamePosition.UnderlinedStyle = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.cTBDescription);
            this.customPanel1.Controls.Add(this.lblName);
            this.customPanel1.Controls.Add(this.cTBNamePosition);
            this.customPanel1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.Location = new System.Drawing.Point(19, 73);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(563, 207);
            this.customPanel1.TabIndex = 13;
            // 
            // EditPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(602, 353);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.Name = "EditPosition";
            this.Text = "Cập nhật thông tin chức vụ";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.CustomButton customButton2;
        private System.Windows.Forms.Label label4;
        private GUI.TruniControls.CustomTextBox cTBDescription;
        private GUI.CustomButton customButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private GUI.TruniControls.CustomTextBox cTBNamePosition;
        private GUI.TruniControls.CustomPanel customPanel1;
    }
}