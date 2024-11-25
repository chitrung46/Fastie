using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.Toastify
{
    public partial class LayoutToastify : Form
    {
        private Timer closeTimer;
        public LayoutToastify()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int x = screenWidth - this.Width - 10; 
            int y = 10; 

            this.Location = new Point(x, y);
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetMessage(string message, string type)
        {
            lblMessage.Text = message;
            switch (type)
            {
                case "success":
                    lblStatus.Text = "Thành công";
                    pnlBar.BackColor = Color.FromArgb(76, 175, 80);
                    pictureBoxError.Image = Properties.Resources.icons8_check_240;
                    break;
                case "error" :
                    lblStatus.Text = "Thất bại";
                    pnlBar.BackColor = Color.FromArgb(244, 67, 54);
                    pictureBoxError.Image = Properties.Resources.icons8_error_144;
                    break;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            closeTimer = new Timer();
            closeTimer.Interval = 4000;
            closeTimer.Tick += CloseTimer_Tick;
            closeTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            this.Close();
        }

        private void lblCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
