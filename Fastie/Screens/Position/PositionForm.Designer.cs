namespace Fastie
{
    partial class PositionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.customButton3 = new GUI.CustomButton();
            this.customButton1 = new GUI.CustomButton();
            this.customButton2 = new GUI.CustomButton();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChuvcVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức vụ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::Fastie.Properties.Resources.icons8_back_16;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.customPanel1.Location = new System.Drawing.Point(19, 113);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1145, 566);
            this.customPanel1.TabIndex = 1;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
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
            this.customButton3.Location = new System.Drawing.Point(361, 19);
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
            this.customButton1.Location = new System.Drawing.Point(19, 20);
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
            this.customButton2.Location = new System.Drawing.Point(191, 19);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tenChuvcVu,
            this.moTa});
            this.dgvPosition.Location = new System.Drawing.Point(19, 79);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.RowHeadersWidth = 51;
            this.dgvPosition.RowTemplate.Height = 24;
            this.dgvPosition.Size = new System.Drawing.Size(1108, 468);
            this.dgvPosition.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 58;
            // 
            // tenChuvcVu
            // 
            this.tenChuvcVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenChuvcVu.HeaderText = "Tên Chức vụ";
            this.tenChuvcVu.MinimumWidth = 6;
            this.tenChuvcVu.Name = "tenChuvcVu";
            // 
            // moTa
            // 
            this.moTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moTa.HeaderText = "Mô tả";
            this.moTa.MinimumWidth = 6;
            this.moTa.Name = "moTa";
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1182, 695);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PositionForm";
            this.Text = "Position";
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GUI.TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.DataGridView dgvPosition;
        private GUI.CustomButton customButton3;
        private GUI.CustomButton customButton1;
        private GUI.CustomButton customButton2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChuvcVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
    }
}