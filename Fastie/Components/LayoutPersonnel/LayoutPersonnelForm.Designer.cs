namespace Fastie.Components.LayoutPersonnel
{
    partial class LayoutPersonnelForm
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
            this.lblPersonnelName = new System.Windows.Forms.Label();
            this.lblNumberPhone = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customButton1 = new GUI.CustomButton();
            this.btnDeletePersonnel = new GUI.CustomButton();
            this.btnEditPersonnel = new GUI.CustomButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDetailsPosition = new GUI.CustomButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPersonnelName
            // 
            this.lblPersonnelName.AutoSize = true;
            this.lblPersonnelName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnelName.Location = new System.Drawing.Point(2, 16);
            this.lblPersonnelName.Name = "lblPersonnelName";
            this.lblPersonnelName.Size = new System.Drawing.Size(102, 21);
            this.lblPersonnelName.TabIndex = 0;
            this.lblPersonnelName.Text = "Tên nhân sự";
            // 
            // lblNumberPhone
            // 
            this.lblNumberPhone.AutoSize = true;
            this.lblNumberPhone.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPhone.Location = new System.Drawing.Point(7, 16);
            this.lblNumberPhone.Name = "lblNumberPhone";
            this.lblNumberPhone.Size = new System.Drawing.Size(109, 21);
            this.lblNumberPhone.TabIndex = 0;
            this.lblNumberPhone.Text = "Số điện thoại";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNumberPhone);
            this.panel2.Location = new System.Drawing.Point(729, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 54);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPersonnelName);
            this.panel1.Location = new System.Drawing.Point(100, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 54);
            this.panel1.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblNumber);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(91, 54);
            this.panel5.TabIndex = 23;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(16, 16);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(16, 21);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customButton1);
            this.panel3.Controls.Add(this.btnDeletePersonnel);
            this.panel3.Controls.Add(this.btnEditPersonnel);
            this.panel3.Location = new System.Drawing.Point(893, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 54);
            this.panel3.TabIndex = 25;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 15;
            this.customButton1.BorderSize = 0;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Image = global::Fastie.Properties.Resources.add_user__2_;
            this.customButton1.Location = new System.Drawing.Point(98, 7);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(40, 40);
            this.customButton1.TabIndex = 21;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // btnDeletePersonnel
            // 
            this.btnDeletePersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDeletePersonnel.BorderColor = System.Drawing.Color.White;
            this.btnDeletePersonnel.BorderRadius = 15;
            this.btnDeletePersonnel.BorderSize = 0;
            this.btnDeletePersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePersonnel.FlatAppearance.BorderSize = 0;
            this.btnDeletePersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePersonnel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePersonnel.ForeColor = System.Drawing.Color.White;
            this.btnDeletePersonnel.Image = global::Fastie.Properties.Resources.icons8_delete_23;
            this.btnDeletePersonnel.Location = new System.Drawing.Point(53, 7);
            this.btnDeletePersonnel.Name = "btnDeletePersonnel";
            this.btnDeletePersonnel.Size = new System.Drawing.Size(40, 40);
            this.btnDeletePersonnel.TabIndex = 19;
            this.btnDeletePersonnel.UseVisualStyleBackColor = false;
            this.btnDeletePersonnel.Click += new System.EventHandler(this.btnDeletePersonnel_Click);
            // 
            // btnEditPersonnel
            // 
            this.btnEditPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEditPersonnel.BorderColor = System.Drawing.Color.White;
            this.btnEditPersonnel.BorderRadius = 15;
            this.btnEditPersonnel.BorderSize = 0;
            this.btnEditPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPersonnel.FlatAppearance.BorderSize = 0;
            this.btnEditPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPersonnel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPersonnel.ForeColor = System.Drawing.Color.White;
            this.btnEditPersonnel.Image = global::Fastie.Properties.Resources.icons8_pencil_23;
            this.btnEditPersonnel.Location = new System.Drawing.Point(8, 7);
            this.btnEditPersonnel.Name = "btnEditPersonnel";
            this.btnEditPersonnel.Size = new System.Drawing.Size(40, 40);
            this.btnEditPersonnel.TabIndex = 20;
            this.btnEditPersonnel.UseVisualStyleBackColor = false;
            this.btnEditPersonnel.Click += new System.EventHandler(this.btnEditPersonnel_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblEmail);
            this.panel6.Location = new System.Drawing.Point(339, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 54);
            this.panel6.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(-1, 17);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblGender);
            this.panel7.Location = new System.Drawing.Point(623, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 54);
            this.panel7.TabIndex = 24;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(5, 16);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 21);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Giới tính";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDetailsPosition);
            this.panel4.Location = new System.Drawing.Point(1037, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(77, 54);
            this.panel4.TabIndex = 26;
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
            this.btnDetailsPosition.Location = new System.Drawing.Point(12, 6);
            this.btnDetailsPosition.Name = "btnDetailsPosition";
            this.btnDetailsPosition.Size = new System.Drawing.Size(40, 40);
            this.btnDetailsPosition.TabIndex = 1;
            this.btnDetailsPosition.UseVisualStyleBackColor = false;
            this.btnDetailsPosition.Click += new System.EventHandler(this.btnDetailsPosition_Click);
            // 
            // LayoutPersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Name = "LayoutPersonnelForm";
            this.Size = new System.Drawing.Size(1117, 59);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPersonnelName;
        private System.Windows.Forms.Label lblNumberPhone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Panel panel3;
        private GUI.CustomButton btnDeletePersonnel;
        private GUI.CustomButton btnEditPersonnel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel panel4;
        private GUI.CustomButton btnDetailsPosition;
        private GUI.CustomButton customButton1;
    }
}
