namespace Fastie.Components.LayoutDepartmen
{
    partial class LayoutDepartmentForm
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
            this.btnEditDepartment = new GUI.CustomButton();
            this.btnDeleteDepartment = new GUI.CustomButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnDetailsDepartment = new GUI.CustomButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEditDepartment.BorderColor = System.Drawing.Color.White;
            this.btnEditDepartment.BorderRadius = 15;
            this.btnEditDepartment.BorderSize = 0;
            this.btnEditDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDepartment.FlatAppearance.BorderSize = 0;
            this.btnEditDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDepartment.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDepartment.ForeColor = System.Drawing.Color.White;
            this.btnEditDepartment.Image = global::Fastie.Properties.Resources.icons8_pencil_23;
            this.btnEditDepartment.Location = new System.Drawing.Point(3, 7);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(40, 40);
            this.btnEditDepartment.TabIndex = 20;
            this.btnEditDepartment.UseVisualStyleBackColor = false;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDeleteDepartment.BorderColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.BorderRadius = 15;
            this.btnDeleteDepartment.BorderSize = 0;
            this.btnDeleteDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDepartment.FlatAppearance.BorderSize = 0;
            this.btnDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.Image = global::Fastie.Properties.Resources.icons8_delete_23;
            this.btnDeleteDepartment.Location = new System.Drawing.Point(48, 7);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteDepartment.TabIndex = 19;
            this.btnDeleteDepartment.UseVisualStyleBackColor = false;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.Controls.Add(this.btnDeleteDepartment);
            this.panel3.Controls.Add(this.btnEditDepartment);
            this.panel3.Location = new System.Drawing.Point(894, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 54);
            this.panel3.TabIndex = 20;
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(19, 16);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(85, 21);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Số thứ tự";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5.Controls.Add(this.lblNumber);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 54);
            this.panel5.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Location = new System.Drawing.Point(432, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 54);
            this.panel2.TabIndex = 16;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(55, 21);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Mô tả";
            // 
            // btnDetailsDepartment
            // 
            this.btnDetailsDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetailsDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnDetailsDepartment.BorderColor = System.Drawing.Color.White;
            this.btnDetailsDepartment.BorderRadius = 15;
            this.btnDetailsDepartment.BorderSize = 0;
            this.btnDetailsDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailsDepartment.FlatAppearance.BorderSize = 0;
            this.btnDetailsDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsDepartment.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDetailsDepartment.Image = global::Fastie.Properties.Resources.icons8_document_24;
            this.btnDetailsDepartment.Location = new System.Drawing.Point(11, 6);
            this.btnDetailsDepartment.Name = "btnDetailsDepartment";
            this.btnDetailsDepartment.Size = new System.Drawing.Size(40, 40);
            this.btnDetailsDepartment.TabIndex = 1;
            this.btnDetailsDepartment.UseVisualStyleBackColor = false;
            this.btnDetailsDepartment.Click += new System.EventHandler(this.btnDetailsDepartment_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.Controls.Add(this.btnDetailsDepartment);
            this.panel4.Location = new System.Drawing.Point(1026, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(88, 54);
            this.panel4.TabIndex = 19;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(19, 16);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(107, 21);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "Tên chức vụ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.lblDepartmentName);
            this.panel1.Location = new System.Drawing.Point(124, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 54);
            this.panel1.TabIndex = 17;
            // 
            // LayoutDepartmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(3000, 59);
            this.MinimumSize = new System.Drawing.Size(1117, 59);
            this.Name = "LayoutDepartmentForm";
            this.Size = new System.Drawing.Size(1117, 59);
            this.Load += new System.EventHandler(this.LayoutDepartmentForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.CustomButton btnEditDepartment;
        private GUI.CustomButton btnDeleteDepartment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDescription;
        private GUI.CustomButton btnDetailsDepartment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Panel panel1;
    }
}
