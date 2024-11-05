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
using DTO;
using Fastie.Components.LayoutDepartmen;
using Fastie.Components.LayoutPersonnel;
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
            loadDataPersonnel();
        }

        public void LoadDataPersonnel()
        {
            loadDataPersonnel();
        }

        private void loadDataPersonnel ()
        {
            flowLayoutPanelPersonnel.Controls.Clear();
            List<Personnel> departmentList = personnelBLL.GetPersonnelList();
            int i = 0;
            foreach (Personnel persomell in departmentList)
            {
                var layoutPersonnelForm = new LayoutPersonnelForm(this)
                {
                    Number = (i + 1).ToString(),
                    PersonnelName = persomell.Ten,
                    Email = persomell.Email,
                    Gender = persomell.GioiTinh,
                    DateOfBirth = persomell.NgaySinh.ToString(),
                    DateOfWork = persomell.NgayVaoLam.ToString(),
                    IdPersonnel = persomell.Id,
                    NumberPhone = persomell.Sdt
                };
                flowLayoutPanelPersonnel.Controls.Add(layoutPersonnelForm);
                i++;
            }
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
                MessageBox.Show("Bạn không có quyền thêm nhân viên");
            }
        }
    }
}
