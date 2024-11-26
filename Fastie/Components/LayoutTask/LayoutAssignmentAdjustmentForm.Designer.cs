namespace Fastie.Components.LayoutTask
{
    partial class LayoutAssignmentAdjustmentForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTaskStatus = new GUI.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblJobAssigner = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReason = new GUI.CustomButton();
            this.btnRefuse = new GUI.CustomButton();
            this.btnApprove = new GUI.CustomButton();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(19, 19);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(171, 21);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Sửa chữa bồn vệ sinh";
            // 
            // lblTaskTime
            // 
            this.lblTaskTime.AutoSize = true;
            this.lblTaskTime.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTime.Location = new System.Drawing.Point(7, 16);
            this.lblTaskTime.Name = "lblTaskTime";
            this.lblTaskTime.Size = new System.Drawing.Size(82, 21);
            this.lblTaskTime.TabIndex = 0;
            this.lblTaskTime.Text = "9/12/2024";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTaskStatus);
            this.panel3.Location = new System.Drawing.Point(411, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 54);
            this.panel3.TabIndex = 8;
            // 
            // btnTaskStatus
            // 
            this.btnTaskStatus.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTaskStatus.BorderColor = System.Drawing.Color.White;
            this.btnTaskStatus.BorderRadius = 15;
            this.btnTaskStatus.BorderSize = 0;
            this.btnTaskStatus.FlatAppearance.BorderSize = 0;
            this.btnTaskStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskStatus.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskStatus.ForeColor = System.Drawing.Color.White;
            this.btnTaskStatus.Location = new System.Drawing.Point(3, 7);
            this.btnTaskStatus.Name = "btnTaskStatus";
            this.btnTaskStatus.Size = new System.Drawing.Size(168, 40);
            this.btnTaskStatus.TabIndex = 0;
            this.btnTaskStatus.Text = "Không hoàn thành";
            this.btnTaskStatus.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTaskTime);
            this.panel2.Location = new System.Drawing.Point(267, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 54);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTaskName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 54);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblJobAssigner);
            this.panel4.Location = new System.Drawing.Point(589, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 54);
            this.panel4.TabIndex = 11;
            // 
            // lblJobAssigner
            // 
            this.lblJobAssigner.AutoSize = true;
            this.lblJobAssigner.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobAssigner.Location = new System.Drawing.Point(13, 16);
            this.lblJobAssigner.Name = "lblJobAssigner";
            this.lblJobAssigner.Size = new System.Drawing.Size(137, 21);
            this.lblJobAssigner.TabIndex = 0;
            this.lblJobAssigner.Text = "Lương Chí Trung";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnReason);
            this.panel6.Controls.Add(this.btnRefuse);
            this.panel6.Controls.Add(this.btnApprove);
            this.panel6.Location = new System.Drawing.Point(783, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 54);
            this.panel6.TabIndex = 13;
            // 
            // btnReason
            // 
            this.btnReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnReason.BorderColor = System.Drawing.Color.White;
            this.btnReason.BorderRadius = 15;
            this.btnReason.BorderSize = 0;
            this.btnReason.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReason.FlatAppearance.BorderSize = 0;
            this.btnReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReason.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReason.ForeColor = System.Drawing.Color.White;
            this.btnReason.Location = new System.Drawing.Point(225, 6);
            this.btnReason.Name = "btnReason";
            this.btnReason.Size = new System.Drawing.Size(97, 40);
            this.btnReason.TabIndex = 2;
            this.btnReason.Text = "Lý do";
            this.btnReason.UseVisualStyleBackColor = false;
            this.btnReason.Click += new System.EventHandler(this.btnReason_Click);
            // 
            // btnRefuse
            // 
            this.btnRefuse.BackColor = System.Drawing.Color.Red;
            this.btnRefuse.BorderColor = System.Drawing.Color.White;
            this.btnRefuse.BorderRadius = 15;
            this.btnRefuse.BorderSize = 0;
            this.btnRefuse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefuse.FlatAppearance.BorderSize = 0;
            this.btnRefuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefuse.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefuse.ForeColor = System.Drawing.Color.White;
            this.btnRefuse.Location = new System.Drawing.Point(116, 6);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(97, 40);
            this.btnRefuse.TabIndex = 1;
            this.btnRefuse.Text = "Từ chối";
            this.btnRefuse.UseVisualStyleBackColor = false;
            this.btnRefuse.Click += new System.EventHandler(this.btnRefuse_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnApprove.BorderColor = System.Drawing.Color.White;
            this.btnApprove.BorderRadius = 15;
            this.btnApprove.BorderSize = 0;
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(9, 7);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(97, 40);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Phê duyệt";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // LayoutAssignmentAdjustmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Name = "LayoutAssignmentAdjustmentForm";
            this.Size = new System.Drawing.Size(1117, 60);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskTime;
        private System.Windows.Forms.Panel panel3;
        private GUI.CustomButton btnTaskStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblJobAssigner;
        private System.Windows.Forms.Panel panel6;
        private GUI.CustomButton btnApprove;
        private GUI.CustomButton btnRefuse;
        private GUI.CustomButton btnReason;
    }
}
