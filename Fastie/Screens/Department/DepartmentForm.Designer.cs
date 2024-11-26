namespace Fastie
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanelDepartment = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddDepartment = new GUI.CustomButton();
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.txtSearch = new GUI.TruniControls.CustomTextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(28, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 29);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(897, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hành động";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(141, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên bộ phận";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1035, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chi tiết";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(442, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mô tả";
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
            // flowLayoutPanelDepartment
            // 
            this.flowLayoutPanelDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelDepartment.AutoScroll = true;
            this.flowLayoutPanelDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.flowLayoutPanelDepartment.Location = new System.Drawing.Point(28, 183);
            this.flowLayoutPanelDepartment.MaximumSize = new System.Drawing.Size(3000, 1500);
            this.flowLayoutPanelDepartment.MinimumSize = new System.Drawing.Size(1213, 491);
            this.flowLayoutPanelDepartment.Name = "flowLayoutPanelDepartment";
            this.flowLayoutPanelDepartment.Size = new System.Drawing.Size(1213, 491);
            this.flowLayoutPanelDepartment.TabIndex = 17;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddDepartment.BorderColor = System.Drawing.Color.White;
            this.btnAddDepartment.BorderRadius = 15;
            this.btnAddDepartment.BorderSize = 0;
            this.btnAddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartment.FlatAppearance.BorderSize = 0;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDepartment.Location = new System.Drawing.Point(994, 92);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAddDepartment.Size = new System.Drawing.Size(154, 40);
            this.btnAddDepartment.TabIndex = 20;
            this.btnAddDepartment.Text = "Thêm bộ phận";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderColor = System.Drawing.Color.Black;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.txtSearch);
            this.customPanel2.Controls.Add(this.pictureBox8);
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 0F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.Location = new System.Drawing.Point(28, 12);
            this.customPanel2.MaximumSize = new System.Drawing.Size(3000, 74);
            this.customPanel2.MinimumSize = new System.Drawing.Size(1120, 74);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1120, 74);
            this.customPanel2.TabIndex = 10;
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
            this.txtSearch.TabIndex = 13;
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Fastie.Properties.Resources.icons8_search_100;
            this.pictureBox8.Location = new System.Drawing.Point(960, 21);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
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
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bộ phận";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1182, 695);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelDepartment);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepartmentForm";
            this.Text = "part";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private GUI.TruniControls.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDepartment;
        private GUI.CustomButton btnAddDepartment;
        private GUI.TruniControls.CustomTextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}