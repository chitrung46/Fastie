using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.DepartmentBLL;
using Fastie.Components.Toastify;

namespace Fastie
{
    public partial class CreateDepartmentForm : Form
    {
        DepartmentBLL departmentBLL = new DepartmentBLL();
        DepartmentForm departmentForm ;

        public CreateDepartmentForm(DepartmentForm departmentForm)
        {
            InitializeComponent();
            this.departmentForm= departmentForm;    
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                showMessage("Vui lòng nhập đầy đủ thông tin", "error");
                return;
            }
            try
            {
                Department newBoPhan = new Department
                {
                    Ten = cTBName.Text,
                    MoTa = cTBDescribe.Text
                };
                departmentBLL.InsertDepartment(newBoPhan);
                showMessage("Thêm Bộ phận mới thành công!", "success");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
            departmentForm.LoadDataDepartment();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
