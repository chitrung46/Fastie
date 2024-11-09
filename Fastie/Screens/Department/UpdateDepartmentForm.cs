using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.DepartmentBLL;
using DTO;
using Fastie.Components.LayoutDepartmen;
using Fastie.Components.Toastify;
namespace Fastie
{
    public partial class UpdateDepartmentForm : Form
    {
        private readonly Department needEdit;
        DepartmentBLL departmentBLL = new DepartmentBLL();  
        private LayoutDepartmentForm departmentForm;

        public UpdateDepartmentForm(LayoutDepartmentForm layoutDepartmentForm, Department editDepartment)  //DepartmentForm departmentForm, Department editDepartment
        {
            InitializeComponent();
            this.needEdit = editDepartment;
            this.departmentForm = layoutDepartmentForm;
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void UpdateDepartmentForm_Load(object sender, EventArgs e)
        {
            cTBName.Text = needEdit.Ten;
            cTBDescribe.Text = needEdit.MoTa;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                showMessage("Vui lòng nhập đầy đủ thông tin cho Tên bộ phận.", "error");
                return;
            }
            needEdit.Ten = cTBName.Text;
            needEdit.MoTa = cTBDescribe.Text;
            departmentBLL.UpdateDepartment(needEdit);
            showMessage("Sửa Bộ phận thành công!", "success");
            departmentForm.loadDataDepartment();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
