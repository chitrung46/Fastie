﻿namespace Fastie
{
    partial class Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dTPBirthday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.cbAnalytics = new GUI.TruniControls.CustomComboBox();
            this.cbPersonnel = new GUI.TruniControls.CustomComboBox();
            this.cbPosition = new GUI.TruniControls.CustomComboBox();
            this.cbDepartment = new GUI.TruniControls.CustomComboBox();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportFile = new GUI.CustomButton();
            this.btnExportWorđ = new GUI.CustomButton();
            this.btnExportPDF = new GUI.CustomButton();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonnel.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnel.ForeColor = System.Drawing.Color.White;
            this.lblPersonnel.Location = new System.Drawing.Point(558, 110);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(73, 21);
            this.lblPersonnel.TabIndex = 18;
            this.lblPersonnel.Text = "Nhân sự";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(289, 110);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 21);
            this.lblPosition.TabIndex = 14;
            this.lblPosition.Text = "Chức vụ";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(24, 110);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(74, 21);
            this.lblDepartment.TabIndex = 15;
            this.lblDepartment.Text = "Bộ phận";
            // 
            // dTPBirthday
            // 
            this.dTPBirthday.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.dTPBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPBirthday.Location = new System.Drawing.Point(28, 221);
            this.dTPBirthday.Name = "dTPBirthday";
            this.dTPBirthday.Size = new System.Drawing.Size(233, 27);
            this.dTPBirthday.TabIndex = 20;
            this.dTPBirthday.Value = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thời gian bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(289, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Thời gian kết thúc";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 27);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(558, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dạng biểu đồ";
            // 
            // PanelChart
            // 
            this.PanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart.AutoScroll = true;
            this.PanelChart.Location = new System.Drawing.Point(28, 273);
            this.PanelChart.MaximumSize = new System.Drawing.Size(3000, 1500);
            this.PanelChart.MinimumSize = new System.Drawing.Size(1094, 622);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(1094, 622);
            this.PanelChart.TabIndex = 27;
            // 
            // cbAnalytics
            // 
            this.cbAnalytics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAnalytics.BorderColor = System.Drawing.Color.Black;
            this.cbAnalytics.BorderRadius = 8;
            this.cbAnalytics.BorderSize = 1;
            this.cbAnalytics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbAnalytics.ForeColor = System.Drawing.Color.Black;
            this.cbAnalytics.IconColor = System.Drawing.Color.Black;
            this.cbAnalytics.ListBackColor = System.Drawing.Color.White;
            this.cbAnalytics.ListTextColor = System.Drawing.Color.Black;
            this.cbAnalytics.Location = new System.Drawing.Point(562, 219);
            this.cbAnalytics.MaximumSize = new System.Drawing.Size(400, 30);
            this.cbAnalytics.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbAnalytics.Name = "cbAnalytics";
            this.cbAnalytics.Padding = new System.Windows.Forms.Padding(1);
            this.cbAnalytics.Size = new System.Drawing.Size(233, 30);
            this.cbAnalytics.TabIndex = 26;
            this.cbAnalytics.Texts = "";
            this.cbAnalytics.OnSelectedIndexChanged += new System.EventHandler(this.cbAnalytics_OnSelectedIndexChanged);
            // 
            // cbPersonnel
            // 
            this.cbPersonnel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPersonnel.BorderColor = System.Drawing.Color.Black;
            this.cbPersonnel.BorderRadius = 8;
            this.cbPersonnel.BorderSize = 1;
            this.cbPersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPersonnel.ForeColor = System.Drawing.Color.White;
            this.cbPersonnel.IconColor = System.Drawing.Color.Black;
            this.cbPersonnel.ListBackColor = System.Drawing.Color.White;
            this.cbPersonnel.ListTextColor = System.Drawing.Color.Black;
            this.cbPersonnel.Location = new System.Drawing.Point(562, 143);
            this.cbPersonnel.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPersonnel.Name = "cbPersonnel";
            this.cbPersonnel.Padding = new System.Windows.Forms.Padding(1);
            this.cbPersonnel.Size = new System.Drawing.Size(233, 30);
            this.cbPersonnel.TabIndex = 19;
            this.cbPersonnel.Texts = "";
            this.cbPersonnel.OnSelectedIndexChanged += new System.EventHandler(this.cbPersonnel_SelectedIndexChanged);
            // 
            // cbPosition
            // 
            this.cbPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPosition.BorderColor = System.Drawing.Color.Black;
            this.cbPosition.BorderRadius = 8;
            this.cbPosition.BorderSize = 1;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPosition.ForeColor = System.Drawing.Color.Black;
            this.cbPosition.IconColor = System.Drawing.Color.Black;
            this.cbPosition.ListBackColor = System.Drawing.Color.White;
            this.cbPosition.ListTextColor = System.Drawing.Color.Black;
            this.cbPosition.Location = new System.Drawing.Point(293, 143);
            this.cbPosition.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Padding = new System.Windows.Forms.Padding(1);
            this.cbPosition.Size = new System.Drawing.Size(233, 30);
            this.cbPosition.TabIndex = 16;
            this.cbPosition.Texts = "";
            this.cbPosition.OnSelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartment.BorderColor = System.Drawing.Color.Black;
            this.cbDepartment.BorderRadius = 8;
            this.cbDepartment.BorderSize = 1;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbDepartment.ForeColor = System.Drawing.Color.Black;
            this.cbDepartment.IconColor = System.Drawing.Color.Black;
            this.cbDepartment.ListBackColor = System.Drawing.Color.White;
            this.cbDepartment.ListTextColor = System.Drawing.Color.Black;
            this.cbDepartment.Location = new System.Drawing.Point(28, 143);
            this.cbDepartment.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Padding = new System.Windows.Forms.Padding(1);
            this.cbDepartment.Size = new System.Drawing.Size(233, 30);
            this.cbDepartment.TabIndex = 17;
            this.cbDepartment.Texts = "";
            this.cbDepartment.OnSelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.AutoScroll = true;
            this.customPanel1.AutoSize = true;
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customPanel1.Location = new System.Drawing.Point(28, 12);
            this.customPanel1.MaximumSize = new System.Drawing.Size(3000, 74);
            this.customPanel1.MinimumSize = new System.Drawing.Size(1094, 74);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1094, 74);
            this.customPanel1.TabIndex = 5;
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
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            // 
            // btnExportFile
            // 
            this.btnExportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnExportFile.BorderColor = System.Drawing.Color.White;
            this.btnExportFile.BorderRadius = 15;
            this.btnExportFile.BorderSize = 0;
            this.btnExportFile.FlatAppearance.BorderSize = 0;
            this.btnExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportFile.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.ForeColor = System.Drawing.Color.White;
            this.btnExportFile.Image = global::Fastie.Properties.Resources.icons8_print_24;
            this.btnExportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportFile.Location = new System.Drawing.Point(994, 125);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnExportFile.Size = new System.Drawing.Size(128, 48);
            this.btnExportFile.TabIndex = 12;
            this.btnExportFile.Text = "Xuất file";
            this.btnExportFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportFile.UseVisualStyleBackColor = false;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // btnExportWorđ
            // 
            this.btnExportWorđ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportWorđ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnExportWorđ.BorderColor = System.Drawing.Color.White;
            this.btnExportWorđ.BorderRadius = 15;
            this.btnExportWorđ.BorderSize = 0;
            this.btnExportWorđ.FlatAppearance.BorderSize = 0;
            this.btnExportWorđ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportWorđ.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportWorđ.ForeColor = System.Drawing.Color.White;
            this.btnExportWorđ.Image = global::Fastie.Properties.Resources.icons8_word_24;
            this.btnExportWorđ.Location = new System.Drawing.Point(994, 191);
            this.btnExportWorđ.Name = "btnExportWorđ";
            this.btnExportWorđ.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnExportWorđ.Size = new System.Drawing.Size(54, 48);
            this.btnExportWorđ.TabIndex = 28;
            this.btnExportWorđ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportWorđ.UseVisualStyleBackColor = false;
            this.btnExportWorđ.Click += new System.EventHandler(this.btnExportWorđ_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnExportPDF.BorderColor = System.Drawing.Color.White;
            this.btnExportPDF.BorderRadius = 15;
            this.btnExportPDF.BorderSize = 0;
            this.btnExportPDF.FlatAppearance.BorderSize = 0;
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Image = global::Fastie.Properties.Resources.icons8_pdf_24;
            this.btnExportPDF.Location = new System.Drawing.Point(1054, 191);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnExportPDF.Size = new System.Drawing.Size(54, 48);
            this.btnExportPDF.TabIndex = 29;
            this.btnExportPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportPDF.UseVisualStyleBackColor = false;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1164, 907);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnExportWorđ);
            this.Controls.Add(this.PanelChart);
            this.Controls.Add(this.cbAnalytics);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExportFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTPBirthday);
            this.Controls.Add(this.cbPersonnel);
            this.Controls.Add(this.lblPersonnel);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(3000, 1600);
            this.MinimumSize = new System.Drawing.Size(1164, 695);
            this.Name = "Analytics";
            this.Text = "Analytics";
            this.Load += new System.EventHandler(this.Analytics_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private GUI.TruniControls.CustomComboBox cbPersonnel;
        private System.Windows.Forms.Label lblPersonnel;
        private GUI.TruniControls.CustomComboBox cbPosition;
        private GUI.TruniControls.CustomComboBox cbDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.DateTimePicker dTPBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private GUI.CustomButton btnExportFile;
        private GUI.TruniControls.CustomComboBox cbAnalytics;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelChart;
        private GUI.CustomButton btnExportWorđ;
        private GUI.CustomButton btnExportPDF;
    }
}