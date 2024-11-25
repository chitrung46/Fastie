using BLL;
using Fastie.Components.Toastify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Screens.Task.Components
{
    public partial class ReasonAdjustmentForm : Form
    {
        private string idTaiKhoan;
        private string idTask;

        TaskBLL taskBLL = new TaskBLL();
        public ReasonAdjustmentForm(string idTaiKhoan, string idTask)
        {
            InitializeComponent();
            this.idTaiKhoan = idTaiKhoan;
            this.idTask = idTask;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                string reason = txtReason.Text;
                if (string.IsNullOrEmpty(reason))
                {
                    showMessage("Vui lòng nhập lý do điều chỉnh.", "error");
                    return;
                }
                bool result = taskBLL.TaoDonXinDieuChinhPhanCong(this.idTask, this.idTaiKhoan, reason);
                if(result)                 
                {
                    showMessage("Tạo đơn xin điều chỉnh thành công.", "success");
                    this.Close();
                }
                else
                {
                    showMessage("Tạo đơn xin điều chỉnh thất bại.", "error");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                showMessage(ex.Message, "error");
            }
        }

        private void ReasonAdjustmentForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnConfirm;
        }
    }
}
