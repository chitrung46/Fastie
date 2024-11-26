namespace Fastie
{
    partial class TaskForm
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
            this.mainLayout = new System.Windows.Forms.Panel();
            this.pnlTabBar = new GUI.TruniControls.CustomPanel();
            this.btnReloadData = new GUI.CustomButton();
            this.btnAdjustTask = new GUI.CustomButton();
            this.btnReportTask = new GUI.CustomButton();
            this.btnAcceptTask = new GUI.CustomButton();
            this.btnAssignTask = new GUI.CustomButton();
            this.btnTaskTable = new GUI.CustomButton();
            this.pnlTabBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayout.AutoScroll = true;
            this.mainLayout.AutoSize = true;
            this.mainLayout.Location = new System.Drawing.Point(28, 95);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(4);
            this.mainLayout.MaximumSize = new System.Drawing.Size(3000, 1500);
            this.mainLayout.MinimumSize = new System.Drawing.Size(1120, 573);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Size = new System.Drawing.Size(1120, 573);
            this.mainLayout.TabIndex = 2;
            // 
            // pnlTabBar
            // 
            this.pnlTabBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.BorderColor = System.Drawing.Color.Black;
            this.pnlTabBar.BorderRadius = 50;
            this.pnlTabBar.BorderSize = 0;
            this.pnlTabBar.Controls.Add(this.btnReloadData);
            this.pnlTabBar.Controls.Add(this.btnAdjustTask);
            this.pnlTabBar.Controls.Add(this.btnReportTask);
            this.pnlTabBar.Controls.Add(this.btnAcceptTask);
            this.pnlTabBar.Controls.Add(this.btnAssignTask);
            this.pnlTabBar.Controls.Add(this.btnTaskTable);
            this.pnlTabBar.ForeColor = System.Drawing.Color.Black;
            this.pnlTabBar.GradientAngle = 90F;
            this.pnlTabBar.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.Location = new System.Drawing.Point(28, 12);
            this.pnlTabBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTabBar.Name = "pnlTabBar";
            this.pnlTabBar.Size = new System.Drawing.Size(1120, 75);
            this.pnlTabBar.TabIndex = 1;
            // 
            // btnReloadData
            // 
            this.btnReloadData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReloadData.BackColor = System.Drawing.Color.IndianRed;
            this.btnReloadData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnReloadData.BorderRadius = 40;
            this.btnReloadData.BorderSize = 0;
            this.btnReloadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReloadData.FlatAppearance.BorderSize = 0;
            this.btnReloadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadData.ForeColor = System.Drawing.Color.White;
            this.btnReloadData.Location = new System.Drawing.Point(1013, 11);
            this.btnReloadData.Margin = new System.Windows.Forms.Padding(2);
            this.btnReloadData.Name = "btnReloadData";
            this.btnReloadData.Size = new System.Drawing.Size(95, 54);
            this.btnReloadData.TabIndex = 8;
            this.btnReloadData.Text = "Tải lại";
            this.btnReloadData.UseVisualStyleBackColor = false;
            this.btnReloadData.Click += new System.EventHandler(this.btnReloadData_Click);
            // 
            // btnAdjustTask
            // 
            this.btnAdjustTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdjustTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAdjustTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnAdjustTask.BorderRadius = 40;
            this.btnAdjustTask.BorderSize = 0;
            this.btnAdjustTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjustTask.FlatAppearance.BorderSize = 0;
            this.btnAdjustTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjustTask.ForeColor = System.Drawing.Color.White;
            this.btnAdjustTask.Location = new System.Drawing.Point(636, 11);
            this.btnAdjustTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdjustTask.Name = "btnAdjustTask";
            this.btnAdjustTask.Size = new System.Drawing.Size(229, 54);
            this.btnAdjustTask.TabIndex = 7;
            this.btnAdjustTask.Text = "Điều chỉnh phân công";
            this.btnAdjustTask.UseVisualStyleBackColor = false;
            this.btnAdjustTask.Click += new System.EventHandler(this.btnAdjustTask_Click);
            // 
            // btnReportTask
            // 
            this.btnReportTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReportTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnReportTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnReportTask.BorderRadius = 40;
            this.btnReportTask.BorderSize = 0;
            this.btnReportTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportTask.FlatAppearance.BorderSize = 0;
            this.btnReportTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportTask.ForeColor = System.Drawing.Color.White;
            this.btnReportTask.Location = new System.Drawing.Point(439, 11);
            this.btnReportTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportTask.Name = "btnReportTask";
            this.btnReportTask.Size = new System.Drawing.Size(192, 54);
            this.btnReportTask.TabIndex = 6;
            this.btnReportTask.Text = "Báo cáo công việc";
            this.btnReportTask.UseVisualStyleBackColor = false;
            this.btnReportTask.Click += new System.EventHandler(this.btnReportTask_Click);
            // 
            // btnAcceptTask
            // 
            this.btnAcceptTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAcceptTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAcceptTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnAcceptTask.BorderRadius = 40;
            this.btnAcceptTask.BorderSize = 0;
            this.btnAcceptTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptTask.FlatAppearance.BorderSize = 0;
            this.btnAcceptTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptTask.ForeColor = System.Drawing.Color.White;
            this.btnAcceptTask.Location = new System.Drawing.Point(312, 11);
            this.btnAcceptTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptTask.Name = "btnAcceptTask";
            this.btnAcceptTask.Size = new System.Drawing.Size(122, 54);
            this.btnAcceptTask.TabIndex = 5;
            this.btnAcceptTask.Text = "Nhận việc";
            this.btnAcceptTask.UseVisualStyleBackColor = false;
            this.btnAcceptTask.Click += new System.EventHandler(this.btnAcceptTask_Click);
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAssignTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAssignTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnAssignTask.BorderRadius = 40;
            this.btnAssignTask.BorderSize = 0;
            this.btnAssignTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignTask.FlatAppearance.BorderSize = 0;
            this.btnAssignTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTask.ForeColor = System.Drawing.Color.White;
            this.btnAssignTask.Location = new System.Drawing.Point(185, 11);
            this.btnAssignTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(122, 54);
            this.btnAssignTask.TabIndex = 4;
            this.btnAssignTask.Text = "Giao việc";
            this.btnAssignTask.UseVisualStyleBackColor = false;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // btnTaskTable
            // 
            this.btnTaskTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTaskTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnTaskTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnTaskTable.BorderRadius = 40;
            this.btnTaskTable.BorderSize = 0;
            this.btnTaskTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaskTable.FlatAppearance.BorderSize = 0;
            this.btnTaskTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskTable.ForeColor = System.Drawing.Color.White;
            this.btnTaskTable.Location = new System.Drawing.Point(10, 11);
            this.btnTaskTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaskTable.Name = "btnTaskTable";
            this.btnTaskTable.Size = new System.Drawing.Size(171, 54);
            this.btnTaskTable.TabIndex = 3;
            this.btnTaskTable.Text = "Bảng công việc";
            this.btnTaskTable.UseVisualStyleBackColor = false;
            this.btnTaskTable.Click += new System.EventHandler(this.btnTaskTable_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1182, 695);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.pnlTabBar);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskForm";
            this.Text = "Work";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.pnlTabBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GUI.TruniControls.CustomPanel pnlTabBar;
        private GUI.CustomButton btnTaskTable;
        private GUI.CustomButton btnAcceptTask;
        private GUI.CustomButton btnAssignTask;
        private GUI.CustomButton btnAdjustTask;
        private GUI.CustomButton btnReportTask;
        private System.Windows.Forms.Panel mainLayout;
        private GUI.CustomButton btnReloadData;
    }
}