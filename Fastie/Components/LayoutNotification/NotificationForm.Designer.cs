namespace Fastie.Components.LayoutNotification
{
    partial class NotificationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureboxDetail = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAssignerName = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 69);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fastie.Properties.Resources.icons8_bell_100;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(79, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 69);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.Controls.Add(this.pictureboxDetail);
            this.panel4.Location = new System.Drawing.Point(307, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 63);
            this.panel4.TabIndex = 2;
            // 
            // pictureboxDetail
            // 
            this.pictureboxDetail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureboxDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxDetail.Image = global::Fastie.Properties.Resources.icons8_menu_23;
            this.pictureboxDetail.Location = new System.Drawing.Point(5, 7);
            this.pictureboxDetail.Name = "pictureboxDetail";
            this.pictureboxDetail.Size = new System.Drawing.Size(24, 50);
            this.pictureboxDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureboxDetail.TabIndex = 0;
            this.pictureboxDetail.TabStop = false;
            this.pictureboxDetail.Click += new System.EventHandler(this.pictureboxDetail_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblAssignerName);
            this.panel3.Controls.Add(this.lblTaskName);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 63);
            this.panel3.TabIndex = 1;
            // 
            // lblAssignerName
            // 
            this.lblAssignerName.AutoSize = true;
            this.lblAssignerName.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignerName.Location = new System.Drawing.Point(3, 36);
            this.lblAssignerName.Name = "lblAssignerName";
            this.lblAssignerName.Size = new System.Drawing.Size(136, 21);
            this.lblAssignerName.TabIndex = 0;
            this.lblAssignerName.Text = "Lương Chí Trung";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(3, 7);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(136, 21);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Lau nhà vệ sinh";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(2000, 75);
            this.MinimumSize = new System.Drawing.Size(425, 75);
            this.Name = "NotificationForm";
            this.Size = new System.Drawing.Size(425, 75);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAssignerName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureboxDetail;
    }
}
