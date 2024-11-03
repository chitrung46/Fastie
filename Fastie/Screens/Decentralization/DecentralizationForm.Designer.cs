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
            this.flowLayoutPanelPersonnel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTabBar = new GUI.TruniControls.CustomPanel();
            this.btnRoleless = new GUI.CustomButton();
            this.btnHaveRole = new GUI.CustomButton();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.btnDelete = new GUI.CustomButton();
            this.btnAdd = new GUI.CustomButton();
            this.cbPosition = new GUI.TruniControls.CustomComboBox();
            this.cbDepartment = new GUI.TruniControls.CustomComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTabBar.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPersonnel
            // 
            this.flowLayoutPanelPersonnel.AutoScroll = true;
            this.flowLayoutPanelPersonnel.Location = new System.Drawing.Point(28, 286);
            this.flowLayoutPanelPersonnel.Name = "flowLayoutPanelPersonnel";
            this.flowLayoutPanelPersonnel.Size = new System.Drawing.Size(1194, 386);
            this.flowLayoutPanelPersonnel.TabIndex = 8;
            // 
            // pnlTabBar
            // 
            this.pnlTabBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pnlTabBar.Location = new System.Drawing.Point(765, 204);
            this.pnlTabBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTabBar.Name = "pnlTabBar";
            this.pnlTabBar.Size = new System.Drawing.Size(383, 65);
            this.pnlTabBar.TabIndex = 9;
            // 
            // btnRoleless
            // 
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
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.pictureBox8);
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.Location = new System.Drawing.Point(28, 12);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1120, 74);
            this.customPanel1.TabIndex = 4;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Fastie.Properties.Resources.icons8_search_100;
            this.pictureBox8.Location = new System.Drawing.Point(963, 22);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1009, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tìm kiếm";
            // 
            // label1
            // 
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
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.BorderColor = System.Drawing.Color.Black;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.btnDelete);
            this.customPanel2.Controls.Add(this.btnAdd);
            this.customPanel2.Controls.Add(this.cbPosition);
            this.customPanel2.Controls.Add(this.cbDepartment);
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Controls.Add(this.label2);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.Location = new System.Drawing.Point(28, 92);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1120, 96);
            this.customPanel2.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::Fastie.Properties.Resources.icons8_delete_23_black;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(969, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnDelete.Size = new System.Drawing.Size(125, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::Fastie.Properties.Resources.icons8_pencil_23_black;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(782, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.btnAdd.Size = new System.Drawing.Size(171, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Phân quyền";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
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
            this.cbPosition.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPosition.Location = new System.Drawing.Point(314, 49);
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
            this.cbDepartment.ListTextColor = System.Drawing.Color.DimGray;
            this.cbDepartment.Location = new System.Drawing.Point(24, 49);
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
            this.label3.Location = new System.Drawing.Point(310, 16);
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
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bộ phận";
            // 
            // DecentralizationBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1182, 695);
            this.Controls.Add(this.pnlTabBar);
            this.Controls.Add(this.flowLayoutPanelPersonnel);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DecentralizationBackupForm";
            this.Text = "DecentralizationBackupForm";
            this.Load += new System.EventHandler(this.DecentralizationBackupForm_Load);
            this.pnlTabBar.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label6;
        private GUI.TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private GUI.CustomButton btnDelete;
        private GUI.CustomButton btnAdd;
        private GUI.TruniControls.CustomComboBox cbPosition;
        private GUI.TruniControls.CustomComboBox cbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private GUI.TruniControls.CustomPanel customPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPersonnel;
        private GUI.TruniControls.CustomPanel pnlTabBar;
        private GUI.CustomButton btnRoleless;
        private GUI.CustomButton btnHaveRole;
    }
}