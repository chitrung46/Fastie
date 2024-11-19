namespace Fastie.Screens.Task.ReportTask
{
    partial class DoReportForm
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
            this.btnCancel = new GUI.CustomButton();
            this.btnReport = new GUI.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.chkCompleteTask = new System.Windows.Forms.CheckBox();
            this.lblImageName = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnUploadImage = new GUI.CustomButton();
            this.btnUploadFile = new GUI.CustomButton();
            this.txtReportContent = new GUI.TruniControls.CustomTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(488, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnReport.BorderRadius = 15;
            this.btnReport.BorderSize = 0;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(376, 447);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnReport.Size = new System.Drawing.Size(106, 40);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "Báo cáo công việc";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.chkCompleteTask);
            this.customPanel1.Controls.Add(this.lblImageName);
            this.customPanel1.Controls.Add(this.lblFileName);
            this.customPanel1.Controls.Add(this.btnUploadImage);
            this.customPanel1.Controls.Add(this.btnUploadFile);
            this.customPanel1.Controls.Add(this.txtReportContent);
            this.customPanel1.Controls.Add(this.lblName);
            this.customPanel1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.Location = new System.Drawing.Point(19, 69);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(563, 359);
            this.customPanel1.TabIndex = 18;
            // 
            // chkCompleteTask
            // 
            this.chkCompleteTask.AutoSize = true;
            this.chkCompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCompleteTask.ForeColor = System.Drawing.Color.White;
            this.chkCompleteTask.Location = new System.Drawing.Point(33, 313);
            this.chkCompleteTask.Name = "chkCompleteTask";
            this.chkCompleteTask.Size = new System.Drawing.Size(195, 25);
            this.chkCompleteTask.TabIndex = 24;
            this.chkCompleteTask.Text = "Hoàn thành công việc";
            this.chkCompleteTask.UseVisualStyleBackColor = true;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageName.ForeColor = System.Drawing.Color.White;
            this.lblImageName.Location = new System.Drawing.Point(429, 261);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(85, 21);
            this.lblImageName.TabIndex = 22;
            this.lblImageName.Text = "image.jpg";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(167, 261);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(69, 21);
            this.lblFileName.TabIndex = 22;
            this.lblFileName.Text = "n2.docx";
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
            this.btnUploadImage.Location = new System.Drawing.Point(295, 251);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(128, 40);
            this.btnUploadImage.TabIndex = 3;
            this.btnUploadImage.Text = "Upload ảnh";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
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
            this.btnUploadFile.Location = new System.Drawing.Point(33, 251);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(128, 40);
            this.btnUploadFile.TabIndex = 2;
            this.btnUploadFile.Text = "Upload file";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // txtReportContent
            // 
            this.txtReportContent.BackColor = System.Drawing.Color.White;
            this.txtReportContent.BorderColor = System.Drawing.Color.DarkGray;
            this.txtReportContent.BorderFocusColor = System.Drawing.Color.Black;
            this.txtReportContent.BorderRadius = 8;
            this.txtReportContent.BorderSize = 2;
            this.txtReportContent.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportContent.ForeColor = System.Drawing.Color.Black;
            this.txtReportContent.Location = new System.Drawing.Point(33, 54);
            this.txtReportContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReportContent.Multiline = true;
            this.txtReportContent.Name = "txtReportContent";
            this.txtReportContent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReportContent.PasswordChar = false;
            this.txtReportContent.PlaceholderColor = System.Drawing.Color.Black;
            this.txtReportContent.PlaceholderText = "";
            this.txtReportContent.Size = new System.Drawing.Size(488, 174);
            this.txtReportContent.TabIndex = 1;
            this.txtReportContent.UnderlinedStyle = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 21);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Nội dung báo cáo";
            // 
            // DoReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(601, 499);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.Name = "DoReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fastie - Báo cáo công việc";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.CustomButton btnCancel;
        private GUI.CustomButton btnReport;
        private System.Windows.Forms.Label label2;
        private GUI.TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label lblName;
        private GUI.TruniControls.CustomTextBox txtReportContent;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Label lblFileName;
        private GUI.CustomButton btnUploadImage;
        private GUI.CustomButton btnUploadFile;
        private System.Windows.Forms.CheckBox chkCompleteTask;
    }
}