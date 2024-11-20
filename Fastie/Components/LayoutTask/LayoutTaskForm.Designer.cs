namespace Fastie.Components.LayoutTask
{
    partial class LayoutTaskForm
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
            this.lblTitleTask = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStatus = new GUI.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGetInformation = new GUI.CustomButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleTask
            // 
            this.lblTitleTask.AutoSize = true;
            this.lblTitleTask.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTask.Location = new System.Drawing.Point(19, 19);
            this.lblTitleTask.Name = "lblTitleTask";
            this.lblTitleTask.Size = new System.Drawing.Size(182, 21);
            this.lblTitleTask.TabIndex = 0;
            this.lblTitleTask.Text = "Sửa chữa bồn vệ sinh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnStatus);
            this.panel3.Location = new System.Drawing.Point(262, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 54);
            this.panel3.TabIndex = 3;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStatus.BorderColor = System.Drawing.Color.White;
            this.btnStatus.BorderRadius = 15;
            this.btnStatus.BorderSize = 0;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(3, 7);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(145, 40);
            this.btnStatus.TabIndex = 0;
            this.btnStatus.Text = "Đang thực hiện";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitleTask);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 54);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnGetInformation);
            this.panel5.Location = new System.Drawing.Point(423, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 54);
            this.panel5.TabIndex = 6;
            // 
            // btnGetInformation
            // 
            this.btnGetInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnGetInformation.BorderColor = System.Drawing.Color.White;
            this.btnGetInformation.BorderRadius = 15;
            this.btnGetInformation.BorderSize = 0;
            this.btnGetInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetInformation.FlatAppearance.BorderSize = 0;
            this.btnGetInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetInformation.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetInformation.ForeColor = System.Drawing.Color.White;
            this.btnGetInformation.Location = new System.Drawing.Point(3, 7);
            this.btnGetInformation.Name = "btnGetInformation";
            this.btnGetInformation.Size = new System.Drawing.Size(133, 40);
            this.btnGetInformation.TabIndex = 0;
            this.btnGetInformation.Text = "Xem chi tiết";
            this.btnGetInformation.UseVisualStyleBackColor = false;
            this.btnGetInformation.Click += new System.EventHandler(this.btnGetInformation_Click);
            // 
            // LayoutTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "LayoutTaskForm";
            this.Size = new System.Drawing.Size(565, 60);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitleTask;
        private System.Windows.Forms.Panel panel3;
        private GUI.CustomButton btnStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private GUI.CustomButton btnGetInformation;
    }
}
