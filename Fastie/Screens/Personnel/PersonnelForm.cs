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
using BLL.PermissionBLL;
using DAL.DepartmentDAL;
using DTO;
using Fastie.Components.LayoutPersonnel;
using Fastie.Components.Toastify;
namespace Fastie
{
    public partial class PersonnelForm : Form
    {
        PersonnelBLL personnelBLL = new PersonnelBLL();
        PermissionBLL permissionBLL = new PermissionBLL(); 
        private string idTaiKhoan;
        private string idChucVu;
        public PersonnelForm(string idTaiKhoan, string idChucVu)
        {
            InitializeComponent();
            this.idTaiKhoan = idTaiKhoan;
            this.idChucVu = idChucVu;
        }

        public string IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public string IdChucVu { get => idChucVu; set => idChucVu = value; }

        private void PersonnelForm_Load(object sender, EventArgs e)
        {
            List<Personnel> personnelList = personnelBLL.GetPersonnelList();
            loadDataPersonnel(personnelList);
        }

        public void LoadDataPersonnel() 
        {
            List<Personnel> personnelList = personnelBLL.GetPersonnelList();
            loadDataPersonnel(personnelList);
        }
        private void loadDataPersonnel (List<Personnel> personnelList)
        {
            flowLayoutPanelPersonnel.Controls.Clear();
            int i = 0;
            foreach (Personnel personnel in personnelList)
            {
                var layoutPersonnelForm = new LayoutPersonnelForm(this)
                {
                    Number = (i + 1).ToString(),
                    PersonnelName = personnel.Ten,
                    Email = personnel.Email,
                    Gender = personnel.GioiTinh,
                    DateOfBirth = personnel.NgaySinh,
                    IdPersonnel = personnel.Id,
                    NumberPhone = personnel.Sdt
                };
                layoutPersonnelForm.DateOfWork = personnel.NgayVaoLam;
                flowLayoutPanelPersonnel.Controls.Add(layoutPersonnelForm);
                i++;
            }
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }

        private void btnAddPersonnel_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(idTaiKhoan, "Q0015");
            if(checkPermission)
            {
                CreatePersonnelForm createPersonnelForm = new CreatePersonnelForm(this);
                createPersonnelForm.Show();
            }
            else
            {
                showMessage("Bạn không có quyền thêm nhân viên", "error");
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (searchValue == "")
            {
                List<Personnel> personnelList = personnelBLL.GetPersonnelList();
                loadDataPersonnel(personnelList);
            }
            else
            {
                List<Personnel> personnelList = personnelBLL.TimKiemNhanSu(searchValue);
                loadDataPersonnel(personnelList);
            }
        }
    }
}
