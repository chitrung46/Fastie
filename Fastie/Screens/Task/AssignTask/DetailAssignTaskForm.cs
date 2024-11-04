using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Task
{
    public partial class DetailAssignTaskForm : Form
    {
        public DetailAssignTaskForm()
        {
            InitializeComponent();
            // Thiết lập định dạng cho DateTimePicker trong form
            dtpTimeCompleted.Format = DateTimePickerFormat.Custom;
            dtpTimeCompleted.CustomFormat = "dd/MM/yyyy";
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            btnUploadFile.ForeColor = Color.FromArgb(59, 171, 201);
            btnUploadImage.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            btnUploadImage.ForeColor = Color.FromArgb(59, 171, 201);
            btnUploadFile.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
