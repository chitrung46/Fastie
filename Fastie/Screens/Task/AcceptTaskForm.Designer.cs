namespace Fastie.Screens.Task
{
    partial class AcceptTaskForm
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
            this.flowLayoutPanelTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTabBar = new GUI.TruniControls.CustomPanel();
            this.btnAssignTask = new GUI.CustomButton();
            this.btnInitialtiveTask = new GUI.CustomButton();
            this.lblShowNoTask = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTabBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTasks
            // 
            this.flowLayoutPanelTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTasks.AutoScroll = true;
            this.flowLayoutPanelTasks.AutoSize = true;
            this.flowLayoutPanelTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.flowLayoutPanelTasks.Location = new System.Drawing.Point(1, 118);
            this.flowLayoutPanelTasks.Name = "flowLayoutPanelTasks";
            this.flowLayoutPanelTasks.Size = new System.Drawing.Size(1175, 461);
            this.flowLayoutPanelTasks.TabIndex = 3;
            this.flowLayoutPanelTasks.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelTasks_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 29);
            this.panel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(893, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hành động";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1040, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chi tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(634, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Người giao việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(466, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên công việc";
            // 
            // pnlTabBar
            // 
            this.pnlTabBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.BorderColor = System.Drawing.Color.Black;
            this.pnlTabBar.BorderRadius = 50;
            this.pnlTabBar.BorderSize = 0;
            this.pnlTabBar.Controls.Add(this.btnAssignTask);
            this.pnlTabBar.Controls.Add(this.btnInitialtiveTask);
            this.pnlTabBar.ForeColor = System.Drawing.Color.Black;
            this.pnlTabBar.GradientAngle = 90F;
            this.pnlTabBar.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.Location = new System.Drawing.Point(755, 7);
            this.pnlTabBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTabBar.Name = "pnlTabBar";
            this.pnlTabBar.Size = new System.Drawing.Size(364, 65);
            this.pnlTabBar.TabIndex = 6;
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAssignTask.BackColor = System.Drawing.Color.Transparent;
            this.btnAssignTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnAssignTask.BorderRadius = 40;
            this.btnAssignTask.BorderSize = 0;
            this.btnAssignTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignTask.FlatAppearance.BorderSize = 0;
            this.btnAssignTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTask.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssignTask.ForeColor = System.Drawing.Color.White;
            this.btnAssignTask.Location = new System.Drawing.Point(207, 9);
            this.btnAssignTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(146, 47);
            this.btnAssignTask.TabIndex = 4;
            this.btnAssignTask.Text = "Được giao việc";
            this.btnAssignTask.UseVisualStyleBackColor = false;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // btnInitialtiveTask
            // 
            this.btnInitialtiveTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnInitialtiveTask.BackColor = System.Drawing.Color.IndianRed;
            this.btnInitialtiveTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnInitialtiveTask.BorderRadius = 40;
            this.btnInitialtiveTask.BorderSize = 0;
            this.btnInitialtiveTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitialtiveTask.FlatAppearance.BorderSize = 0;
            this.btnInitialtiveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialtiveTask.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialtiveTask.ForeColor = System.Drawing.Color.White;
            this.btnInitialtiveTask.Location = new System.Drawing.Point(9, 9);
            this.btnInitialtiveTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitialtiveTask.Name = "btnInitialtiveTask";
            this.btnInitialtiveTask.Size = new System.Drawing.Size(188, 47);
            this.btnInitialtiveTask.TabIndex = 3;
            this.btnInitialtiveTask.Text = "Nhận việc chủ động";
            this.btnInitialtiveTask.UseVisualStyleBackColor = false;
            this.btnInitialtiveTask.Click += new System.EventHandler(this.btnInitialtiveTask_Click);
            // 
            // lblShowNoTask
            // 
            this.lblShowNoTask.AutoSize = true;
            this.lblShowNoTask.BackColor = System.Drawing.Color.Transparent;
            this.lblShowNoTask.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNoTask.ForeColor = System.Drawing.Color.White;
            this.lblShowNoTask.Location = new System.Drawing.Point(350, 304);
            this.lblShowNoTask.Name = "lblShowNoTask";
            this.lblShowNoTask.Size = new System.Drawing.Size(420, 28);
            this.lblShowNoTask.TabIndex = 8;
            this.lblShowNoTask.Text = "Không có công việc nào dành cho bạn";
            this.lblShowNoTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowNoTask.Visible = false;
            // 
            // AcceptTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1120, 573);
            this.Controls.Add(this.lblShowNoTask);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTabBar);
            this.Controls.Add(this.flowLayoutPanelTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcceptTaskForm";
            this.Load += new System.EventHandler(this.AcceptTaskForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTabBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTasks;
        private GUI.TruniControls.CustomPanel pnlTabBar;
        private GUI.CustomButton btnAssignTask;
        private GUI.CustomButton btnInitialtiveTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblShowNoTask;
    }
}