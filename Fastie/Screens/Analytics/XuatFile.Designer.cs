namespace Fastie.Screens.Analytics
{
    partial class XuatFile
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
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.dgvFooter = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteFooter = new GUI.CustomButton();
            this.btnAddFooter = new GUI.CustomButton();
            this.txbFooter = new GUI.TruniControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbLabelNumberOfPages = new System.Windows.Forms.CheckBox();
            this.ckbSoftwareVersion = new System.Windows.Forms.CheckBox();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.dgvHeader = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteHeader = new GUI.CustomButton();
            this.btnAddHeader = new GUI.CustomButton();
            this.txbHeader = new GUI.TruniControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbDocumentDate = new System.Windows.Forms.CheckBox();
            this.ckbDocumentNumber = new System.Windows.Forms.CheckBox();
            this.ckbDocumentName = new System.Windows.Forms.CheckBox();
            this.btnCancel = new GUI.CustomButton();
            this.btnSubmit = new GUI.CustomButton();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFooter)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.BorderColor = System.Drawing.Color.Black;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.dgvFooter);
            this.customPanel2.Controls.Add(this.btnDeleteFooter);
            this.customPanel2.Controls.Add(this.btnAddFooter);
            this.customPanel2.Controls.Add(this.txbFooter);
            this.customPanel2.Controls.Add(this.label2);
            this.customPanel2.Controls.Add(this.ckbLabelNumberOfPages);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel2.Location = new System.Drawing.Point(26, 351);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(744, 268);
            this.customPanel2.TabIndex = 21;
            // 
            // dgvFooter
            // 
            this.dgvFooter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFooter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFooter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvFooter.Location = new System.Drawing.Point(15, 112);
            this.dgvFooter.Name = "dgvFooter";
            this.dgvFooter.RowHeadersWidth = 51;
            this.dgvFooter.RowTemplate.Height = 24;
            this.dgvFooter.Size = new System.Drawing.Size(712, 77);
            this.dgvFooter.TabIndex = 16;
            this.dgvFooter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFooter_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // btnDeleteFooter
            // 
            this.btnDeleteFooter.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteFooter.BorderColor = System.Drawing.Color.White;
            this.btnDeleteFooter.BorderRadius = 15;
            this.btnDeleteFooter.BorderSize = 0;
            this.btnDeleteFooter.FlatAppearance.BorderSize = 0;
            this.btnDeleteFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFooter.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFooter.Image = global::Fastie.Properties.Resources.icons8_delete_23;
            this.btnDeleteFooter.Location = new System.Drawing.Point(684, 207);
            this.btnDeleteFooter.Name = "btnDeleteFooter";
            this.btnDeleteFooter.Size = new System.Drawing.Size(43, 34);
            this.btnDeleteFooter.TabIndex = 7;
            this.btnDeleteFooter.UseVisualStyleBackColor = false;
            this.btnDeleteFooter.Click += new System.EventHandler(this.btnDeleteFooter_Click);
            // 
            // btnAddFooter
            // 
            this.btnAddFooter.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddFooter.BorderColor = System.Drawing.Color.White;
            this.btnAddFooter.BorderRadius = 15;
            this.btnAddFooter.BorderSize = 0;
            this.btnAddFooter.FlatAppearance.BorderSize = 0;
            this.btnAddFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFooter.ForeColor = System.Drawing.Color.White;
            this.btnAddFooter.Image = global::Fastie.Properties.Resources.icons8_plus_23;
            this.btnAddFooter.Location = new System.Drawing.Point(629, 207);
            this.btnAddFooter.Name = "btnAddFooter";
            this.btnAddFooter.Size = new System.Drawing.Size(43, 34);
            this.btnAddFooter.TabIndex = 6;
            this.btnAddFooter.UseVisualStyleBackColor = false;
            this.btnAddFooter.Click += new System.EventHandler(this.btnAddFooter_Click);
            // 
            // txbFooter
            // 
            this.txbFooter.BackColor = System.Drawing.SystemColors.Window;
            this.txbFooter.BorderColor = System.Drawing.Color.DarkGray;
            this.txbFooter.BorderFocusColor = System.Drawing.Color.Black;
            this.txbFooter.BorderRadius = 8;
            this.txbFooter.BorderSize = 2;
            this.txbFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFooter.ForeColor = System.Drawing.Color.DimGray;
            this.txbFooter.Location = new System.Drawing.Point(15, 207);
            this.txbFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFooter.Multiline = false;
            this.txbFooter.Name = "txbFooter";
            this.txbFooter.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbFooter.PasswordChar = false;
            this.txbFooter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbFooter.PlaceholderText = "";
            this.txbFooter.Size = new System.Drawing.Size(602, 35);
            this.txbFooter.TabIndex = 5;
            this.txbFooter.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Footer:";
            // 
            // ckbLabelNumberOfPages
            // 
            this.ckbLabelNumberOfPages.AutoSize = true;
            this.ckbLabelNumberOfPages.Checked = true;
            this.ckbLabelNumberOfPages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLabelNumberOfPages.ForeColor = System.Drawing.Color.White;
            this.ckbLabelNumberOfPages.Location = new System.Drawing.Point(28, 74);
            this.ckbLabelNumberOfPages.Name = "ckbLabelNumberOfPages";
            this.ckbLabelNumberOfPages.Size = new System.Drawing.Size(111, 20);
            this.ckbLabelNumberOfPages.TabIndex = 1;
            this.ckbLabelNumberOfPages.Text = "Đánh số trang";
            this.ckbLabelNumberOfPages.UseVisualStyleBackColor = true;
            // 
            // ckbSoftwareVersion
            // 
            this.ckbSoftwareVersion.AutoSize = true;
            this.ckbSoftwareVersion.Checked = true;
            this.ckbSoftwareVersion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSoftwareVersion.ForeColor = System.Drawing.Color.White;
            this.ckbSoftwareVersion.Location = new System.Drawing.Point(28, 126);
            this.ckbSoftwareVersion.Name = "ckbSoftwareVersion";
            this.ckbSoftwareVersion.Size = new System.Drawing.Size(103, 20);
            this.ckbSoftwareVersion.TabIndex = 0;
            this.ckbSoftwareVersion.Text = "Fastie v0.1.4";
            this.ckbSoftwareVersion.UseVisualStyleBackColor = true;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.dgvHeader);
            this.customPanel1.Controls.Add(this.btnDeleteHeader);
            this.customPanel1.Controls.Add(this.btnAddHeader);
            this.customPanel1.Controls.Add(this.txbHeader);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.ckbDocumentDate);
            this.customPanel1.Controls.Add(this.ckbSoftwareVersion);
            this.customPanel1.Controls.Add(this.ckbDocumentNumber);
            this.customPanel1.Controls.Add(this.ckbDocumentName);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.Location = new System.Drawing.Point(26, 32);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(744, 297);
            this.customPanel1.TabIndex = 20;
            // 
            // dgvHeader
            // 
            this.dgvHeader.AllowUserToOrderColumns = true;
            this.dgvHeader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data});
            this.dgvHeader.Location = new System.Drawing.Point(15, 142);
            this.dgvHeader.Name = "dgvHeader";
            this.dgvHeader.RowHeadersWidth = 51;
            this.dgvHeader.RowTemplate.Height = 24;
            this.dgvHeader.Size = new System.Drawing.Size(712, 77);
            this.dgvHeader.TabIndex = 16;
            this.dgvHeader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeader_CellContentClick);
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            // 
            // btnDeleteHeader
            // 
            this.btnDeleteHeader.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteHeader.BorderColor = System.Drawing.Color.White;
            this.btnDeleteHeader.BorderRadius = 15;
            this.btnDeleteHeader.BorderSize = 0;
            this.btnDeleteHeader.FlatAppearance.BorderSize = 0;
            this.btnDeleteHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHeader.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHeader.Image = global::Fastie.Properties.Resources.icons8_delete_23;
            this.btnDeleteHeader.Location = new System.Drawing.Point(684, 235);
            this.btnDeleteHeader.Name = "btnDeleteHeader";
            this.btnDeleteHeader.Size = new System.Drawing.Size(43, 34);
            this.btnDeleteHeader.TabIndex = 7;
            this.btnDeleteHeader.UseVisualStyleBackColor = false;
            this.btnDeleteHeader.Click += new System.EventHandler(this.btnDeleteHeader_Click);
            // 
            // btnAddHeader
            // 
            this.btnAddHeader.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddHeader.BorderColor = System.Drawing.Color.White;
            this.btnAddHeader.BorderRadius = 15;
            this.btnAddHeader.BorderSize = 0;
            this.btnAddHeader.FlatAppearance.BorderSize = 0;
            this.btnAddHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHeader.ForeColor = System.Drawing.Color.White;
            this.btnAddHeader.Image = global::Fastie.Properties.Resources.icons8_plus_23;
            this.btnAddHeader.Location = new System.Drawing.Point(629, 235);
            this.btnAddHeader.Name = "btnAddHeader";
            this.btnAddHeader.Size = new System.Drawing.Size(43, 34);
            this.btnAddHeader.TabIndex = 6;
            this.btnAddHeader.UseVisualStyleBackColor = false;
            this.btnAddHeader.Click += new System.EventHandler(this.btnAddHeader_Click);
            // 
            // txbHeader
            // 
            this.txbHeader.BackColor = System.Drawing.SystemColors.Window;
            this.txbHeader.BorderColor = System.Drawing.Color.DarkGray;
            this.txbHeader.BorderFocusColor = System.Drawing.Color.Black;
            this.txbHeader.BorderRadius = 8;
            this.txbHeader.BorderSize = 2;
            this.txbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHeader.ForeColor = System.Drawing.Color.DimGray;
            this.txbHeader.Location = new System.Drawing.Point(15, 235);
            this.txbHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbHeader.Multiline = false;
            this.txbHeader.Name = "txbHeader";
            this.txbHeader.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbHeader.PasswordChar = false;
            this.txbHeader.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbHeader.PlaceholderText = "";
            this.txbHeader.Size = new System.Drawing.Size(602, 35);
            this.txbHeader.TabIndex = 5;
            this.txbHeader.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Header:";
            // 
            // ckbDocumentDate
            // 
            this.ckbDocumentDate.AutoSize = true;
            this.ckbDocumentDate.Checked = true;
            this.ckbDocumentDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDocumentDate.ForeColor = System.Drawing.Color.White;
            this.ckbDocumentDate.Location = new System.Drawing.Point(28, 100);
            this.ckbDocumentDate.Name = "ckbDocumentDate";
            this.ckbDocumentDate.Size = new System.Drawing.Size(132, 20);
            this.ckbDocumentDate.TabIndex = 2;
            this.ckbDocumentDate.Text = "Ngày: 27/11/2024";
            this.ckbDocumentDate.UseVisualStyleBackColor = true;
            // 
            // ckbDocumentNumber
            // 
            this.ckbDocumentNumber.AutoSize = true;
            this.ckbDocumentNumber.Checked = true;
            this.ckbDocumentNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDocumentNumber.ForeColor = System.Drawing.Color.White;
            this.ckbDocumentNumber.Location = new System.Drawing.Point(28, 74);
            this.ckbDocumentNumber.Name = "ckbDocumentNumber";
            this.ckbDocumentNumber.Size = new System.Drawing.Size(226, 20);
            this.ckbDocumentNumber.TabIndex = 1;
            this.ckbDocumentNumber.Text = "Số tài liệu: BC012_TK0000000003";
            this.ckbDocumentNumber.UseVisualStyleBackColor = true;
            // 
            // ckbDocumentName
            // 
            this.ckbDocumentName.AutoSize = true;
            this.ckbDocumentName.Checked = true;
            this.ckbDocumentName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDocumentName.ForeColor = System.Drawing.Color.White;
            this.ckbDocumentName.Location = new System.Drawing.Point(28, 48);
            this.ckbDocumentName.Name = "ckbDocumentName";
            this.ckbDocumentName.Size = new System.Drawing.Size(343, 20);
            this.ckbDocumentName.TabIndex = 0;
            this.ckbDocumentName.Text = "Tên tài liệu: Báo cáo kết quả công việc tháng 11.2024";
            this.ckbDocumentName.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(691, 635);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.BorderRadius = 15;
            this.btnSubmit.BorderSize = 0;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(564, 636);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 39);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // XuatFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Name = "XuatFile";
            this.Text = "XuatFile";
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFooter)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbDocumentName;
        private System.Windows.Forms.CheckBox ckbDocumentNumber;
        private System.Windows.Forms.CheckBox ckbDocumentDate;
        private System.Windows.Forms.Label label1;
        private GUI.TruniControls.CustomTextBox txbHeader;
        private GUI.CustomButton btnAddHeader;
        private GUI.CustomButton btnDeleteHeader;
        private System.Windows.Forms.DataGridView dgvHeader;
        private GUI.CustomButton btnSubmit;
        private GUI.CustomButton btnCancel;
        private GUI.TruniControls.CustomPanel customPanel1;
        private GUI.TruniControls.CustomPanel customPanel2;
        private System.Windows.Forms.DataGridView dgvFooter;
        private GUI.CustomButton btnDeleteFooter;
        private GUI.CustomButton btnAddFooter;
        private GUI.TruniControls.CustomTextBox txbFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbLabelNumberOfPages;
        private System.Windows.Forms.CheckBox ckbSoftwareVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}