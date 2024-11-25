namespace Fastie.Screens.Decentralization
{
    partial class DecentralizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecentralizationForm));
            this.flowLayoutPanelPersonnel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTabBar = new GUI.TruniControls.CustomPanel();
            this.btnRoleless = new GUI.CustomButton();
            this.btnHaveRole = new GUI.CustomButton();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.txtSearch = new GUI.TruniControls.CustomTextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosition = new GUI.TruniControls.CustomComboBox();
            this.cbDepartment = new GUI.TruniControls.CustomComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTabBar.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPersonnel
            // 
            this.flowLayoutPanelPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPersonnel.AutoScroll = true;
            this.flowLayoutPanelPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.flowLayoutPanelPersonnel.Location = new System.Drawing.Point(28, 222);
            this.flowLayoutPanelPersonnel.MaximumSize = new System.Drawing.Size(3000, 1500);
            this.flowLayoutPanelPersonnel.MinimumSize = new System.Drawing.Size(1194, 450);
            this.flowLayoutPanelPersonnel.Name = "flowLayoutPanelPersonnel";
            this.flowLayoutPanelPersonnel.Size = new System.Drawing.Size(1194, 450);
            this.flowLayoutPanelPersonnel.TabIndex = 8;
            // 
            // pnlTabBar
            // 
            this.pnlTabBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.BorderColor = System.Drawing.Color.Black;
            this.pnlTabBar.BorderRadius = 50;
            this.pnlTabBar.BorderSize = 0;
            this.pnlTabBar.Controls.Add(this.btnRoleless);
            this.pnlTabBar.Controls.Add(this.btnHaveRole);
            this.pnlTabBar.ForeColor = System.Drawing.Color.Black;
            this.pnlTabBar.GradientAngle = 90F;
            this.pnlTabBar.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTabBar.Location = new System.Drawing.Point(765, 108);
            this.pnlTabBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTabBar.Name = "pnlTabBar";
            this.pnlTabBar.Size = new System.Drawing.Size(383, 65);
            this.pnlTabBar.TabIndex = 9;
            // 
            // btnRoleless
            // 
            this.btnRoleless.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoleless.BackColor = System.Drawing.Color.Transparent;
            this.btnRoleless.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnRoleless.BorderRadius = 40;
            this.btnRoleless.BorderSize = 0;
            this.btnRoleless.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoleless.FlatAppearance.BorderSize = 0;
            this.btnRoleless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleless.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnRoleless.ForeColor = System.Drawing.Color.White;
            this.btnRoleless.Location = new System.Drawing.Point(196, 9);
            this.btnRoleless.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoleless.Name = "btnRoleless";
            this.btnRoleless.Size = new System.Drawing.Size(171, 47);
            this.btnRoleless.TabIndex = 4;
            this.btnRoleless.Text = "Chưa phân quyền";
            this.btnRoleless.UseVisualStyleBackColor = false;
            this.btnRoleless.Click += new System.EventHandler(this.btnRoleless_Click);
            // 
            // btnHaveRole
            // 
            this.btnHaveRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHaveRole.BackColor = System.Drawing.Color.IndianRed;
            this.btnHaveRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnHaveRole.BorderRadius = 40;
            this.btnHaveRole.BorderSize = 0;
            this.btnHaveRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHaveRole.FlatAppearance.BorderSize = 0;
            this.btnHaveRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaveRole.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaveRole.ForeColor = System.Drawing.Color.White;
            this.btnHaveRole.Location = new System.Drawing.Point(9, 9);
            this.btnHaveRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnHaveRole.Name = "btnHaveRole";
            this.btnHaveRole.Size = new System.Drawing.Size(171, 47);
            this.btnHaveRole.TabIndex = 3;
            this.btnHaveRole.Text = "Đã phân quyền";
            this.btnHaveRole.UseVisualStyleBackColor = false;
            this.btnHaveRole.Click += new System.EventHandler(this.btnHaveRole_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.txtSearch);
            this.customPanel1.Controls.Add(this.pictureBox8);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.Location = new System.Drawing.Point(28, 12);
            this.customPanel1.MaximumSize = new System.Drawing.Size(3000, 74);
            this.customPanel1.MinimumSize = new System.Drawing.Size(1120, 74);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1120, 74);
            this.customPanel1.TabIndex = 4;
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
            this.txtSearch.TabIndex = 11;
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Fastie.Properties.Resources.icons8_search_100;
            this.pictureBox8.Location = new System.Drawing.Point(959, 21);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân quyền";
            // 
            // cbPosition
            // 
            this.cbPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPosition.BorderColor = System.Drawing.Color.Black;
            this.cbPosition.BorderRadius = 8;
            this.cbPosition.BorderSize = 1;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPosition.ForeColor = System.Drawing.Color.DimGray;
            this.cbPosition.IconColor = System.Drawing.Color.Black;
            this.cbPosition.ListBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPosition.ListTextColor = System.Drawing.Color.Black;
            this.cbPosition.Location = new System.Drawing.Point(293, 131);
            this.cbPosition.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Padding = new System.Windows.Forms.Padding(1);
            this.cbPosition.Size = new System.Drawing.Size(233, 30);
            this.cbPosition.TabIndex = 1;
            this.cbPosition.Texts = "";
            this.cbPosition.OnSelectedIndexChanged += new System.EventHandler(this.cbPosition_OnSelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartment.BorderColor = System.Drawing.Color.Black;
            this.cbDepartment.BorderRadius = 8;
            this.cbDepartment.BorderSize = 1;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.cbDepartment.IconColor = System.Drawing.Color.Black;
            this.cbDepartment.ListBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartment.ListTextColor = System.Drawing.Color.Black;
            this.cbDepartment.Location = new System.Drawing.Point(28, 131);
            this.cbDepartment.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Padding = new System.Windows.Forms.Padding(1);
            this.cbDepartment.Size = new System.Drawing.Size(233, 30);
            this.cbDepartment.TabIndex = 1;
            this.cbDepartment.Texts = "";
            this.cbDepartment.OnSelectedIndexChanged += new System.EventHandler(this.cbDepartment_OnSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(289, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bộ phận";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(31, 185);
            this.panel1.MaximumSize = new System.Drawing.Size(3000, 29);
            this.panel1.MinimumSize = new System.Drawing.Size(1117, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 29);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(135, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên nhân sự";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(865, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hành động";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(651, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên chức vụ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(425, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên bộ phận";
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
            // DecentralizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1182, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.pnlTabBar);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.flowLayoutPanelPersonnel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecentralizationForm";
            this.Text = "DecentralizationBackupForm";
            this.Load += new System.EventHandler(this.DecentralizationBackupForm_Load);
            this.pnlTabBar.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private GUI.TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private GUI.TruniControls.CustomComboBox cbPosition;
        private GUI.TruniControls.CustomComboBox cbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPersonnel;
        private GUI.TruniControls.CustomPanel pnlTabBar;
        private GUI.CustomButton btnRoleless;
        private GUI.CustomButton btnHaveRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private GUI.TruniControls.CustomTextBox txtSearch;
    }
}