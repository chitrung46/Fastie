namespace Fastie.Components.Toastify
{
    partial class LayoutToastify
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
            this.lblCancel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCancel
            // 
            this.lblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.Location = new System.Drawing.Point(317, 5);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(20, 21);
            this.lblCancel.TabIndex = 9;
            this.lblCancel.Text = "X";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(61, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 21);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Thất bại";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(61, 30);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(266, 21);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Email hoặc mật khẩu không đúng";
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.pnlBar.Location = new System.Drawing.Point(-9, 61);
            this.pnlBar.MaximumSize = new System.Drawing.Size(430, 7);
            this.pnlBar.MinimumSize = new System.Drawing.Size(354, 7);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(370, 7);
            this.pnlBar.TabIndex = 5;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Image = global::Fastie.Properties.Resources.icons8_error_1441;
            this.pictureBoxError.Location = new System.Drawing.Point(3, 5);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(52, 50);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 6;
            this.pictureBoxError.TabStop = false;
            // 
            // LayoutToastifyFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 68);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pictureBoxError);
            this.Controls.Add(this.pnlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(430, 68);
            this.MinimumSize = new System.Drawing.Size(354, 68);
            this.Name = "LayoutToastifyFail";
            this.Text = "LayoutToastifyFail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Panel pnlBar;
    }
}