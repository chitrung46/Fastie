namespace Fastie
{
    partial class PersonnelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelForm));
            this.customPanel3 = new GUI.TruniControls.CustomPanel();
            this.txtSearch = new GUI.TruniControls.CustomTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPersonnel = new GUI.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPersonnel = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel3
            // 
            this.customPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderColor = System.Drawing.Color.Black;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.BorderSize = 0;
            this.customPanel3.Controls.Add(this.txtSearch);
            this.customPanel3.Controls.Add(this.pictureBox1);
            this.customPanel3.Controls.Add(this.label1);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel3.Location = new System.Drawing.Point(28, 12);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1120, 74);
            this.customPanel3.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.AutoSize = true;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(1004, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.White;
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.Size = new System.Drawing.Size(97, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pictureBox1.Image = global::Fastie.Properties.Resources.icons8_search_100;
            this.pictureBox1.Location = new System.Drawing.Point(960, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân sự";
            // 
            // btnAddPersonnel
            // 
            this.btnAddPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddPersonnel.BorderColor = System.Drawing.Color.White;
            this.btnAddPersonnel.BorderRadius = 15;
            this.btnAddPersonnel.BorderSize = 0;
            this.btnAddPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPersonnel.FlatAppearance.BorderSize = 0;
            this.btnAddPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPersonnel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPersonnel.ForeColor = System.Drawing.Color.White;
            this.btnAddPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPersonnel.Location = new System.Drawing.Point(994, 92);
            this.btnAddPersonnel.Name = "btnAddPersonnel";
            this.btnAddPersonnel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAddPersonnel.Size = new System.Drawing.Size(154, 40);
            this.btnAddPersonnel.TabIndex = 23;
            this.btnAddPersonnel.Text = "Thêm nhân sự";
            this.btnAddPersonnel.UseVisualStyleBackColor = false;
            this.btnAddPersonnel.Click += new System.EventHandler(this.btnAddPersonnel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(31, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 29);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1047, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chi tiết";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(895, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Hành động";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(626, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(732, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(102, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên nhân sự";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(337, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số thứ tự";
            // 
            // flowLayoutPanelPersonnel
            // 
            this.flowLayoutPanelPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPersonnel.AutoScroll = true;
            this.flowLayoutPanelPersonnel.Location = new System.Drawing.Point(31, 183);
            this.flowLayoutPanelPersonnel.Name = "flowLayoutPanelPersonnel";
            this.flowLayoutPanelPersonnel.Size = new System.Drawing.Size(1213, 491);
            this.flowLayoutPanelPersonnel.TabIndex = 21;
            // 
            // PersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1182, 695);
            this.Controls.Add(this.btnAddPersonnel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelPersonnel);
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonnelForm";
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.PersonnelForm_Load);
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GUI.TruniControls.CustomPanel customPanel2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private GUI.TruniControls.CustomPanel customPanel3;
        private System.Windows.Forms.Label label1;
        private GUI.CustomButton btnAddPersonnel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPersonnel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private GUI.TruniControls.CustomTextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}