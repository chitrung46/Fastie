﻿namespace Fastie.Screens.Task
{
    partial class DetailAssignFastingTaskForm
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
            this.btnCancel = new GUI.CustomButton();
            this.btnUpdate = new GUI.CustomButton();
            this.pnl2 = new GUI.TruniControls.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.customTextBox1 = new GUI.TruniControls.CustomTextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.dgvAssignTaskFast = new System.Windows.Forms.DataGridView();
            this.typeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUploadFile = new GUI.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTaskFast)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Giao việc nhanh";
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
            this.btnCancel.Location = new System.Drawing.Point(398, 461);
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
            this.btnUpdate.Location = new System.Drawing.Point(298, 461);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnUpdate.Size = new System.Drawing.Size(94, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Lưu";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnl2.BorderColor = System.Drawing.Color.Black;
            this.pnl2.BorderRadius = 30;
            this.pnl2.BorderSize = 0;
            this.pnl2.Controls.Add(this.label1);
            this.pnl2.Controls.Add(this.customTextBox1);
            this.pnl2.Controls.Add(this.lblFileName);
            this.pnl2.Controls.Add(this.dgvAssignTaskFast);
            this.pnl2.Controls.Add(this.btnUploadFile);
            this.pnl2.Controls.Add(this.label6);
            this.pnl2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl2.ForeColor = System.Drawing.Color.Black;
            this.pnl2.GradientAngle = 90F;
            this.pnl2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnl2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnl2.Location = new System.Drawing.Point(24, 62);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(470, 381);
            this.pnl2.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Chọn các cột giá trị tương ứng:";
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.White;
            this.customTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.customTextBox1.BorderRadius = 8;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(184, 18);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.Black;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(65, 36);
            this.customTextBox1.TabIndex = 1;
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(164, 328);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(142, 21);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "Vui lòng chọn file";
            // 
            // dgvAssignTaskFast
            // 
            this.dgvAssignTaskFast.AllowUserToAddRows = false;
            this.dgvAssignTaskFast.AllowUserToDeleteRows = false;
            this.dgvAssignTaskFast.AllowUserToResizeColumns = false;
            this.dgvAssignTaskFast.AllowUserToResizeRows = false;
            this.dgvAssignTaskFast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignTaskFast.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAssignTaskFast.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignTaskFast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignTaskFast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeValue,
            this.Column});
            this.dgvAssignTaskFast.Location = new System.Drawing.Point(30, 106);
            this.dgvAssignTaskFast.Name = "dgvAssignTaskFast";
            this.dgvAssignTaskFast.RowHeadersWidth = 51;
            this.dgvAssignTaskFast.RowTemplate.Height = 24;
            this.dgvAssignTaskFast.Size = new System.Drawing.Size(409, 185);
            this.dgvAssignTaskFast.TabIndex = 42;
            // 
            // typeValue
            // 
            this.typeValue.HeaderText = "Loại giá trị";
            this.typeValue.MinimumWidth = 6;
            this.typeValue.Name = "typeValue";
            this.typeValue.ReadOnly = true;
            // 
            // Column
            // 
            this.Column.HeaderText = "Cột";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
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
            this.btnUploadFile.Location = new System.Drawing.Point(30, 318);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(128, 40);
            this.btnUploadFile.TabIndex = 2;
            this.btnUploadFile.Text = "Upload file";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bắt đầu từ dòng:";
            // 
            // DetailAssignFastingTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(518, 516);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnl2);
            this.Name = "DetailAssignFastingTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao việc nhanh";
            this.Load += new System.EventHandler(this.DetailAssignFastingTaskForm_Load);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTaskFast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFileName;
        private GUI.CustomButton btnUploadFile;
        private System.Windows.Forms.Label label3;
        private GUI.TruniControls.CustomPanel pnl2;
        private System.Windows.Forms.DataGridView dgvAssignTaskFast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private GUI.TruniControls.CustomTextBox customTextBox1;
        private GUI.CustomButton btnCancel;
        private GUI.CustomButton btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
    }
}