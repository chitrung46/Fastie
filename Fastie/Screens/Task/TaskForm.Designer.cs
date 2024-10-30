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
            this.pnlTask = new System.Windows.Forms.Panel();
            this.pnlTabBar = new GUI.TruniControls.CustomPanel();
            this.btnAdjustTask = new GUI.CustomButton();
            this.btnReportTask = new GUI.CustomButton();
            this.btnAcceptTask = new GUI.CustomButton();
            this.btnAssignTask = new GUI.CustomButton();
            this.btnTaskTable = new GUI.CustomButton();
            this.pnlTabBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTask
            // 
            this.pnlTask.Location = new System.Drawing.Point(9, 118);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(1160, 550);
            this.pnlTask.TabIndex = 2;
            // 
            // pnlTabBar
            // 
            this.pnlTabBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.BorderColor = System.Drawing.Color.Black;
            this.pnlTabBar.BorderRadius = 50;
            this.pnlTabBar.BorderSize = 0;
            this.pnlTabBar.Controls.Add(this.btnAdjustTask);
            this.pnlTabBar.Controls.Add(this.btnReportTask);
            this.pnlTabBar.Controls.Add(this.btnAcceptTask);
            this.pnlTabBar.Controls.Add(this.btnAssignTask);
            this.pnlTabBar.Controls.Add(this.btnTaskTable);
            this.pnlTabBar.ForeColor = System.Drawing.Color.Black;
            this.pnlTabBar.GradientAngle = 90F;
            this.pnlTabBar.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.Location = new System.Drawing.Point(7, 8);
            this.pnlTabBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTabBar.Name = "pnlTabBar";
            this.pnlTabBar.Size = new System.Drawing.Size(929, 61);
            this.pnlTabBar.TabIndex = 1;
            // 
            // btnAdjustTask
            // 
            this.btnAdjustTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAdjustTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnAdjustTask.BorderRadius = 40;
            this.btnAdjustTask.BorderSize = 0;
            this.btnAdjustTask.FlatAppearance.BorderSize = 0;
            this.btnAdjustTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjustTask.ForeColor = System.Drawing.Color.White;
            this.btnAdjustTask.Location = new System.Drawing.Point(509, 9);
            this.btnAdjustTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdjustTask.Name = "btnAdjustTask";
            this.btnAdjustTask.Size = new System.Drawing.Size(183, 43);
            this.btnAdjustTask.TabIndex = 7;
            this.btnAdjustTask.Text = "Điều chỉnh phân công";
            this.btnAdjustTask.UseVisualStyleBackColor = false;
            this.btnAdjustTask.Click += new System.EventHandler(this.btnAdjustTask_Click);
            // 
            // btnReportTask
            // 
            this.btnReportTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnReportTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnReportTask.BorderRadius = 40;
            this.btnReportTask.BorderSize = 0;
            this.btnReportTask.FlatAppearance.BorderSize = 0;
            this.btnReportTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportTask.ForeColor = System.Drawing.Color.White;
            this.btnReportTask.Location = new System.Drawing.Point(351, 9);
            this.btnReportTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportTask.Name = "btnReportTask";
            this.btnReportTask.Size = new System.Drawing.Size(154, 43);
            this.btnReportTask.TabIndex = 6;
            this.btnReportTask.Text = "Báo cáo công việc";
            this.btnReportTask.UseVisualStyleBackColor = false;
            this.btnReportTask.Click += new System.EventHandler(this.btnReportTask_Click);
            // 
            // btnAcceptTask
            // 
            this.btnAcceptTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAcceptTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnAcceptTask.BorderRadius = 40;
            this.btnAcceptTask.BorderSize = 0;
            this.btnAcceptTask.FlatAppearance.BorderSize = 0;
            this.btnAcceptTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptTask.ForeColor = System.Drawing.Color.White;
            this.btnAcceptTask.Location = new System.Drawing.Point(250, 9);
            this.btnAcceptTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcceptTask.Name = "btnAcceptTask";
            this.btnAcceptTask.Size = new System.Drawing.Size(98, 43);
            this.btnAcceptTask.TabIndex = 5;
            this.btnAcceptTask.Text = "Nhận việc";
            this.btnAcceptTask.UseVisualStyleBackColor = false;
            this.btnAcceptTask.Click += new System.EventHandler(this.btnAcceptTask_Click);
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAssignTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnAssignTask.BorderRadius = 40;
            this.btnAssignTask.BorderSize = 0;
            this.btnAssignTask.FlatAppearance.BorderSize = 0;
            this.btnAssignTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTask.ForeColor = System.Drawing.Color.White;
            this.btnAssignTask.Location = new System.Drawing.Point(148, 9);
            this.btnAssignTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(98, 43);
            this.btnAssignTask.TabIndex = 4;
            this.btnAssignTask.Text = "Giao việc";
            this.btnAssignTask.UseVisualStyleBackColor = false;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // btnTaskTable
            // 
            this.btnTaskTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnTaskTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnTaskTable.BorderRadius = 40;
            this.btnTaskTable.BorderSize = 0;
            this.btnTaskTable.FlatAppearance.BorderSize = 0;
            this.btnTaskTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskTable.ForeColor = System.Drawing.Color.White;
            this.btnTaskTable.Location = new System.Drawing.Point(8, 9);
            this.btnTaskTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaskTable.Name = "btnTaskTable";
            this.btnTaskTable.Size = new System.Drawing.Size(137, 43);
            this.btnTaskTable.TabIndex = 3;
            this.btnTaskTable.Text = "Bảng công việc";
            this.btnTaskTable.UseVisualStyleBackColor = false;
            this.btnTaskTable.Click += new System.EventHandler(this.btnTaskTable_Click);
            // 
            // panel1
            // 

            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1182, 695);
            this.Controls.Add(this.pnlTask);
            this.Controls.Add(this.pnlTabBar);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskForm";
            this.Text = "Work";
            this.pnlTabBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GUI.TruniControls.CustomPanel pnlTabBar;
        private GUI.CustomButton btnTaskTable;
        private GUI.CustomButton btnAcceptTask;
        private GUI.CustomButton btnAssignTask;
        private GUI.CustomButton btnAdjustTask;
        private GUI.CustomButton btnReportTask;
        private System.Windows.Forms.Panel pnlTask;

    }
}