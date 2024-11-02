namespace Fastie.Screens.Task
{
    partial class AssignTaskForm
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
            this.btnDetailAssignTask = new GUI.CustomButton();
            this.btnDetailAssignPositiveTask = new GUI.CustomButton();
            this.btnDetailAssignFastingTask = new GUI.CustomButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 481);
            this.panel1.TabIndex = 0;
            // 
            // btnDetailAssignTask
            // 
            this.btnDetailAssignTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDetailAssignTask.BorderColor = System.Drawing.Color.White;
            this.btnDetailAssignTask.BorderRadius = 15;
            this.btnDetailAssignTask.BorderSize = 0;
            this.btnDetailAssignTask.FlatAppearance.BorderSize = 0;
            this.btnDetailAssignTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailAssignTask.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailAssignTask.ForeColor = System.Drawing.Color.White;
            this.btnDetailAssignTask.Location = new System.Drawing.Point(780, 27);
            this.btnDetailAssignTask.Name = "btnDetailAssignTask";
            this.btnDetailAssignTask.Size = new System.Drawing.Size(104, 47);
            this.btnDetailAssignTask.TabIndex = 1;
            this.btnDetailAssignTask.Text = "Giao việc";
            this.btnDetailAssignTask.UseVisualStyleBackColor = false;
            this.btnDetailAssignTask.Click += new System.EventHandler(this.btnDetailAssignTask_Click);
            // 
            // btnDetailAssignPositiveTask
            // 
            this.btnDetailAssignPositiveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(78)))));
            this.btnDetailAssignPositiveTask.BorderColor = System.Drawing.Color.White;
            this.btnDetailAssignPositiveTask.BorderRadius = 15;
            this.btnDetailAssignPositiveTask.BorderSize = 0;
            this.btnDetailAssignPositiveTask.FlatAppearance.BorderSize = 0;
            this.btnDetailAssignPositiveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailAssignPositiveTask.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailAssignPositiveTask.ForeColor = System.Drawing.Color.White;
            this.btnDetailAssignPositiveTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailAssignPositiveTask.Location = new System.Drawing.Point(1000, 27);
            this.btnDetailAssignPositiveTask.Name = "btnDetailAssignPositiveTask";
            this.btnDetailAssignPositiveTask.Size = new System.Drawing.Size(104, 47);
            this.btnDetailAssignPositiveTask.TabIndex = 3;
            this.btnDetailAssignPositiveTask.Text = "Chủ động";
            this.btnDetailAssignPositiveTask.UseVisualStyleBackColor = false;
            this.btnDetailAssignPositiveTask.Click += new System.EventHandler(this.btnDetailAssignPositiveTask_Click);
            // 
            // btnDetailAssignFastingTask
            // 
            this.btnDetailAssignFastingTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnDetailAssignFastingTask.BorderColor = System.Drawing.Color.White;
            this.btnDetailAssignFastingTask.BorderRadius = 15;
            this.btnDetailAssignFastingTask.BorderSize = 0;
            this.btnDetailAssignFastingTask.FlatAppearance.BorderSize = 0;
            this.btnDetailAssignFastingTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailAssignFastingTask.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailAssignFastingTask.ForeColor = System.Drawing.Color.White;
            this.btnDetailAssignFastingTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailAssignFastingTask.Location = new System.Drawing.Point(890, 27);
            this.btnDetailAssignFastingTask.Name = "btnDetailAssignFastingTask";
            this.btnDetailAssignFastingTask.Size = new System.Drawing.Size(104, 47);
            this.btnDetailAssignFastingTask.TabIndex = 2;
            this.btnDetailAssignFastingTask.Text = "Nhanh";
            this.btnDetailAssignFastingTask.UseVisualStyleBackColor = false;
            this.btnDetailAssignFastingTask.Click += new System.EventHandler(this.btnDetailAssignFastingTask_Click);
            // 
            // AssignTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1120, 587);
            this.Controls.Add(this.btnDetailAssignPositiveTask);
            this.Controls.Add(this.btnDetailAssignFastingTask);
            this.Controls.Add(this.btnDetailAssignTask);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignTaskForm";
            this.Text = "AssignTaskForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GUI.CustomButton btnDetailAssignTask;
        private GUI.CustomButton btnDetailAssignFastingTask;
        private GUI.CustomButton btnDetailAssignPositiveTask;
    }
}