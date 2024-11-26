namespace Fastie.Screens.Task
{
    partial class TaskTableForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTaskTable = new GUI.TruniControls.CustomPanel();
            this.lblShowNoTask = new System.Windows.Forms.Label();
            this.flowLayoutPanelTask = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.lblShowNoNotification = new System.Windows.Forms.Label();
            this.flowLayoutPanelNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTaskTable.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.pnlTaskTable);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(4000, 2000);
            this.panel1.MinimumSize = new System.Drawing.Size(1123, 615);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 615);
            this.panel1.TabIndex = 0;
            // 
            // pnlTaskTable
            // 
            this.pnlTaskTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTaskTable.AutoScroll = true;
            this.pnlTaskTable.BackColor = System.Drawing.Color.White;
            this.pnlTaskTable.BorderColor = System.Drawing.Color.Black;
            this.pnlTaskTable.BorderRadius = 30;
            this.pnlTaskTable.BorderSize = 0;
            this.pnlTaskTable.Controls.Add(this.lblShowNoTask);
            this.pnlTaskTable.Controls.Add(this.flowLayoutPanelTask);
            this.pnlTaskTable.Controls.Add(this.label2);
            this.pnlTaskTable.ForeColor = System.Drawing.Color.Black;
            this.pnlTaskTable.GradientAngle = 90F;
            this.pnlTaskTable.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTaskTable.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTaskTable.Location = new System.Drawing.Point(4, -3);
            this.pnlTaskTable.MaximumSize = new System.Drawing.Size(4000, 2000);
            this.pnlTaskTable.MinimumSize = new System.Drawing.Size(620, 573);
            this.pnlTaskTable.Name = "pnlTaskTable";
            this.pnlTaskTable.Size = new System.Drawing.Size(622, 573);
            this.pnlTaskTable.TabIndex = 4;
            // 
            // lblShowNoTask
            // 
            this.lblShowNoTask.BackColor = System.Drawing.Color.Transparent;
            this.lblShowNoTask.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNoTask.ForeColor = System.Drawing.Color.White;
            this.lblShowNoTask.Location = new System.Drawing.Point(104, 272);
            this.lblShowNoTask.Name = "lblShowNoTask";
            this.lblShowNoTask.Size = new System.Drawing.Size(420, 28);
            this.lblShowNoTask.TabIndex = 2;
            this.lblShowNoTask.Text = "Không có công việc nào dành cho bạn";
            this.lblShowNoTask.Visible = false;
            // 
            // flowLayoutPanelTask
            // 
            this.flowLayoutPanelTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTask.AutoScroll = true;
            this.flowLayoutPanelTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.flowLayoutPanelTask.Location = new System.Drawing.Point(26, 83);
            this.flowLayoutPanelTask.MaximumSize = new System.Drawing.Size(4000, 2000);
            this.flowLayoutPanelTask.MinimumSize = new System.Drawing.Size(625, 484);
            this.flowLayoutPanelTask.Name = "flowLayoutPanelTask";
            this.flowLayoutPanelTask.Size = new System.Drawing.Size(627, 484);
            this.flowLayoutPanelTask.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Công việc";
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.AutoScroll = true;
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderColor = System.Drawing.Color.Black;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.lblShowNoNotification);
            this.customPanel2.Controls.Add(this.flowLayoutPanelNotification);
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.Location = new System.Drawing.Point(638, 2);
            this.customPanel2.MinimumSize = new System.Drawing.Size(482, 573);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(482, 573);
            this.customPanel2.TabIndex = 3;
            // 
            // lblShowNoNotification
            // 
            this.lblShowNoNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblShowNoNotification.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNoNotification.ForeColor = System.Drawing.Color.White;
            this.lblShowNoNotification.Location = new System.Drawing.Point(111, 269);
            this.lblShowNoNotification.Name = "lblShowNoNotification";
            this.lblShowNoNotification.Size = new System.Drawing.Size(276, 28);
            this.lblShowNoNotification.TabIndex = 3;
            this.lblShowNoNotification.Text = "Không có thông báo mới";
            this.lblShowNoNotification.Visible = false;
            // 
            // flowLayoutPanelNotification
            // 
            this.flowLayoutPanelNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelNotification.AutoScroll = true;
            this.flowLayoutPanelNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.flowLayoutPanelNotification.Location = new System.Drawing.Point(25, 83);
            this.flowLayoutPanelNotification.MaximumSize = new System.Drawing.Size(497, 3000);
            this.flowLayoutPanelNotification.MinimumSize = new System.Drawing.Size(497, 487);
            this.flowLayoutPanelNotification.Name = "flowLayoutPanelNotification";
            this.flowLayoutPanelNotification.Size = new System.Drawing.Size(497, 487);
            this.flowLayoutPanelNotification.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông báo";
            // 
            // TaskTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1120, 573);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(3000, 1500);
            this.MinimumSize = new System.Drawing.Size(1120, 573);
            this.Name = "TaskTableForm";
            this.Text = "TaskTableForm";
            this.Load += new System.EventHandler(this.TaskTableForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.pnlTaskTable.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GUI.TruniControls.CustomPanel customPanel2;
        private System.Windows.Forms.Label lblShowNoNotification;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNotification;
        private System.Windows.Forms.Label label1;
        private GUI.TruniControls.CustomPanel pnlTaskTable;
        private System.Windows.Forms.Label lblShowNoTask;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTask;
        private System.Windows.Forms.Label label2;
    }
}