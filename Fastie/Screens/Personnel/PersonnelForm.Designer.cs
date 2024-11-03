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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.customButton3 = new GUI.CustomButton();
            this.customButton1 = new GUI.CustomButton();
            this.customButton2 = new GUI.CustomButton();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel3 = new GUI.TruniControls.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPersonnel = new GUI.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPersonnel = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.customPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.customButton3);
            this.customPanel1.Controls.Add(this.customButton1);
            this.customPanel1.Controls.Add(this.customButton2);
            this.customPanel1.Controls.Add(this.dgvPosition);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))));
            this.customPanel1.Location = new System.Drawing.Point(28, 92);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1120, 194);
            this.customPanel1.TabIndex = 5;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.Black;
            this.customButton3.BorderColor = System.Drawing.Color.White;
            this.customButton3.BorderRadius = 40;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(366, 18);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(150, 40);
            this.customButton3.TabIndex = 12;
            this.customButton3.Text = "Sửa";
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Black;
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(24, 19);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 10;
            this.customButton1.Text = "Thêm";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Black;
            this.customButton2.BorderColor = System.Drawing.Color.White;
            this.customButton2.BorderRadius = 40;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(196, 18);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(150, 40);
            this.customButton2.TabIndex = 11;
            this.customButton2.Text = "Xóa";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // dgvPosition
            // 
            this.dgvPosition.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tenNhanSu,
            this.email,
            this.gioiTinh,
            this.ngaySinh,
            this.ngayVaoLam,
            this.sdt});
            this.dgvPosition.Location = new System.Drawing.Point(18, 78);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.RowHeadersWidth = 51;
            this.dgvPosition.RowTemplate.Height = 24;
            this.dgvPosition.Size = new System.Drawing.Size(1070, 492);
            this.dgvPosition.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 53;
            // 
            // tenNhanSu
            // 
            this.tenNhanSu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhanSu.HeaderText = "Tên Nhân sự";
            this.tenNhanSu.MinimumWidth = 6;
            this.tenNhanSu.Name = "tenNhanSu";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 125;
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 125;
            // 
            // ngayVaoLam
            // 
            this.ngayVaoLam.HeaderText = "Ngày vào làm";
            this.ngayVaoLam.MinimumWidth = 6;
            this.ngayVaoLam.Name = "ngayVaoLam";
            this.ngayVaoLam.Width = 125;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderColor = System.Drawing.Color.Black;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.BorderSize = 0;
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
            // label1
            // 
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
            this.btnAddPersonnel.Location = new System.Drawing.Point(994, 297);
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
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(31, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 29);
            this.panel1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1023, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Hành động";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(727, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ngày vào làm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(620, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(527, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(887, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // label5
            // 
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
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(273, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email";
            // 
            // label10
            // 
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
            this.flowLayoutPanelPersonnel.AutoScroll = true;
            this.flowLayoutPanelPersonnel.Location = new System.Drawing.Point(31, 388);
            this.flowLayoutPanelPersonnel.Name = "flowLayoutPanelPersonnel";
            this.flowLayoutPanelPersonnel.Size = new System.Drawing.Size(1213, 230);
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
            this.Controls.Add(this.customPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonnelForm";
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.PersonnelForm_Load);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GUI.TruniControls.CustomPanel customPanel1;
        private GUI.CustomButton customButton3;
        private GUI.CustomButton customButton1;
        private GUI.CustomButton customButton2;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}