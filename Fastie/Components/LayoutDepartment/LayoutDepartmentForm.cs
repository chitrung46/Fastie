using BLL.DepartmentBLL;
using BLL.PermissionBLL;
using DAL.PermissionDAL;
using DTO;
using Fastie.Screens.Department;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutDepartmen
{
    public partial class LayoutDepartmentForm : UserControl
    {
        private string number;
        private string nameDepartment;
        private string description;
        private string idDepartment;
        private DepartmentForm departmentForm;
        PermissionBLL permissionBLL = new PermissionBLL();

        public LayoutDepartmentForm()
        {
            InitializeComponent();
        }
        public LayoutDepartmentForm(DepartmentForm departmentForm)
        {
            InitializeComponent();
            this.departmentForm = departmentForm;
        }
        public string Number
        {
            get { return number; }
            set { number = value; lblNumber.Text = number; }
        }
        public string NameDepartment
            {
            get { return nameDepartment; }
            set { nameDepartment = value; lblDepartmentName.Text = nameDepartment; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; lblDescription.Text = description; }
        }
        public string IdDepartment
        {
            get { return idDepartment; }
            set { idDepartment = value; }
        }

        public void loadDataDepartment()
        {
            departmentForm.LoadDataDepartment();
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            string idTaiKhoan = departmentForm.IdTaiKhoan;
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, "Q0008");
            if(checkPermission)
            {
                var updateDepartment = new Department
                {
                    Id = this.idDepartment,
                    Ten = this.nameDepartment,
                    MoTa = this.description
                };
                UpdateDepartmentForm updateDepartmentForm = new UpdateDepartmentForm(this, updateDepartment);
                updateDepartmentForm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa bộ phận", "Thông báo");
            }
            
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            string idTaiKhoan = departmentForm.IdTaiKhoan;
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, "Q0009");
            if(checkPermission)
            {
                string[] information = { "Bạn có chắc chắn xóa bộ phận này?", $"{this.nameDepartment} sẽ được xóa khỏi hệ thống", "Xóa bộ phận" };
                LayoutConfirmForm deleteLayoutConfirm = new LayoutConfirmForm(this, this.idDepartment);
                deleteLayoutConfirm.Title = information[0];
                deleteLayoutConfirm.Content = information[1];
                deleteLayoutConfirm.btnConfirmText = information[2];
                deleteLayoutConfirm.Show();
            } else
            {
                MessageBox.Show("Bạn không có quyền xóa bộ phận", "Thông báo");
            }
        }

        private void btnDetailsDepartment_Click(object sender, EventArgs e)
        {
            DetailsDepartmentForm detailsDepartmentForm = new DetailsDepartmentForm(this);
            detailsDepartmentForm.Show();
        }
    }
}
