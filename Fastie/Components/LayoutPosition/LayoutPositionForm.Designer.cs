namespace Fastie.Components.LayoutDepartment
{
    partial class LayoutPositionForm
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
            this.lblPositionName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeletePosition = new GUI.CustomButton();
            this.btnEditPosition = new GUI.CustomButton();
            this.btnDetailsPosition = new GUI.CustomButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPositionName
            // 
            this.lblPositionName.AutoSize = true;
            this.lblPositionName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionName.Location = new System.Drawing.Point(19, 16);
            this.lblPositionName.Name = "lblPositionName";
            this.lblPositionName.Size = new System.Drawing.Size(107, 21);
            this.lblPositionName.TabIndex = 0;
            this.lblPositionName.Text = "Tên chức vụ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(55, 21);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Mô tả";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Location = new System.Drawing.Point(433, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 54);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPositionName);
            this.panel1.Location = new System.Drawing.Point(125, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 54);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDetailsPosition);
            this.panel4.Location = new System.Drawing.Point(1027, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(91, 54);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblNumber);
            this.panel5.Location = new System.Drawing.Point(4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 54);
            this.panel5.TabIndex = 11;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(19, 16);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(85, 21);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Số thứ tự";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeletePosition);
            this.panel3.Controls.Add(this.btnEditPosition);
            this.panel3.Location = new System.Drawing.Point(895, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 54);
            this.panel3.TabIndex = 15;
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDeletePosition.BorderColor = System.Drawing.Color.White;
            this.btnDeletePosition.BorderRadius = 15;
            this.btnDeletePosition.BorderSize = 0;
            this.btnDeletePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePosition.FlatAppearance.BorderSize = 0;
            this.btnDeletePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePosition.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePosition.ForeColor = System.Drawing.Color.White;
            this.btnDeletePosition.Image = global::Fastie.Properties.Resources.icons8_delete_23;
            this.btnDeletePosition.Location = new System.Drawing.Point(48, 7);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(40, 40);
            this.btnDeletePosition.TabIndex = 19;
            this.btnDeletePosition.UseVisualStyleBackColor = false;
            this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
            // 
            // btnEditPosition
            // 
            this.btnEditPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEditPosition.BorderColor = System.Drawing.Color.White;
            this.btnEditPosition.BorderRadius = 15;
            this.btnEditPosition.BorderSize = 0;
            this.btnEditPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPosition.FlatAppearance.BorderSize = 0;
            this.btnEditPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPosition.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPosition.ForeColor = System.Drawing.Color.White;
            this.btnEditPosition.Image = global::Fastie.Properties.Resources.icons8_pencil_23;
            this.btnEditPosition.Location = new System.Drawing.Point(3, 7);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new System.Drawing.Size(40, 40);
            this.btnEditPosition.TabIndex = 20;
            this.btnEditPosition.UseVisualStyleBackColor = false;
            this.btnEditPosition.Click += new System.EventHandler(this.btnEditPosition_Click);
            // 
            // btnDetailsPosition
            // 
            this.btnDetailsPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.btnDetailsPosition.BorderColor = System.Drawing.Color.White;
            this.btnDetailsPosition.BorderRadius = 15;
            this.btnDetailsPosition.BorderSize = 0;
            this.btnDetailsPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailsPosition.FlatAppearance.BorderSize = 0;
            this.btnDetailsPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsPosition.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsPosition.ForeColor = System.Drawing.Color.White;
            this.btnDetailsPosition.Image = global::Fastie.Properties.Resources.icons8_document_24;
            this.btnDetailsPosition.Location = new System.Drawing.Point(11, 6);
            this.btnDetailsPosition.Name = "btnDetailsPosition";
            this.btnDetailsPosition.Size = new System.Drawing.Size(40, 40);
            this.btnDetailsPosition.TabIndex = 1;
            this.btnDetailsPosition.UseVisualStyleBackColor = false;
            // 
            // LayoutPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LayoutPositionForm";
            this.Size = new System.Drawing.Size(1121, 59);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPositionName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private GUI.CustomButton btnDetailsPosition;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Panel panel3;
        private GUI.CustomButton btnDeletePosition;
        private GUI.CustomButton btnEditPosition;
    }
}
