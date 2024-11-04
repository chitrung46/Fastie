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

        private void UpdateDepartmentForm_Load(object sender, EventArgs e)
        {
            cTBName.Text = needEdit.Ten;
            cTBDescribe.Text = needEdit.MoTa;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho Tên bộ phận.", "Thông báo");
                return;
            }
            needEdit.Ten = cTBName.Text;
            needEdit.MoTa = cTBDescribe.Text;
            departmentBLL.UpdateDepartment(needEdit);
            MessageBox.Show("Sửa Bộ phận thành công!", "Success");
            departmentForm.loadDataDepartment();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
