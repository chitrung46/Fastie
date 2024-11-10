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
using BLL.DecentralizationBLL;
using BLL.DepartmentBLL;
using BLL.PermissionBLL;
using DAL;
using DTO;
using Fastie.Components.LayoutDepartmen;
using Fastie.Components.Toastify;
using GUI.TruniControls;
namespace Fastie
{
    public partial class DepartmentForm : Form
    {
        DepartmentBLL departmentBLL = new DepartmentBLL();
        PermissionBLL permissionBLL = new PermissionBLL();
        private string idTaiKhoan;
        private string idChucVu;

        public DepartmentForm(string idTaiKhoan, string idChucVu)
        {
            InitializeComponent();
            this.idChucVu = idChucVu;
            this.idTaiKhoan = idTaiKhoan;
        }

        public string IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public string IdChucVu { get => idChucVu; set => idChucVu = value; }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            List<Department> departmentList = departmentBLL.GetDepartmentList();
            loadDataDepartment(departmentList);
        }
        public void LoadDataDepartment()
        {
            List<Department> departmentList = departmentBLL.GetDepartmentList();
            loadDataDepartment(departmentList);
        }

        private void loadDataDepartment(List<Department> departmentList)
        {
            flowLayoutPanelDepartment.Controls.Clear();
            int i = 0;
            foreach (Department department in departmentList)
            {
                var layoutDepartmentForm = new LayoutDepartmentForm(this)
                {
                    Number = (i + 1).ToString(),
                    NameDepartment = department.Ten,
                    Description = department.MoTa,
                    IdDepartment = department.Id
                };
                flowLayoutPanelDepartment.Controls.Add(layoutDepartmentForm);
                i++;
            }
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0007");
            if (checkPermission)
            {
                CreateDepartmentForm createDepartmentForm = new CreateDepartmentForm(this);
                createDepartmentForm.Show();
            } else
            {
                showMessage("Bạn không có quyền thêm bộ phận", "error");
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (searchValue == "")
            {
                List<Department> departmentList = departmentBLL.GetDepartmentList();
                loadDataDepartment(departmentList);
            }
            else
            {
                List<Department> departments = departmentBLL.TimKiemBoPhan(searchValue);
                loadDataDepartment(departments);
            }
        }
    }
}
