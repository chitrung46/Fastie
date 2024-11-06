using BLL;
using BLL.PermissionBLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie.Components.LayoutPersonnel
{
    public partial class LayoutPersonnelForm : UserControl
    {
        private string number;
        private string personnelName;
        private string email;
        private string gender;
        private DateTime dateOfBirth;
        private DateTime dateOfWork;
        private string idPersonnel;
        private string numberPhone;
        private PersonnelForm personnelForm;
        PermissionBLL permissionBLL = new PermissionBLL();
        public LayoutPersonnelForm()
        {
            InitializeComponent();
        }
        public LayoutPersonnelForm(PersonnelForm personnelForm)
        {
            InitializeComponent();
            this.personnelForm = personnelForm;
        }
        public string Number
        {
            get { return number; }
            set { number = value; lblNumber.Text = number; }
        }

        public string PersonnelName
        {
            get { return personnelName; }
            set { personnelName = value; lblPersonnelName.Text = personnelName; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; lblEmail.Text = email; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; lblGender.Text = gender; }
        }
        public DateTime DateOfBirth
            {
            get { return dateOfBirth; }
            set { dateOfBirth = value; lblDateOfBirth.Text = dateOfBirth.ToString("dd/MM/yyyy"); }
        }
        public DateTime DateOfWork
        {
            get { return dateOfWork; }
            set { dateOfWork = value;  }
        }

        public string IdPersonnel
        {
            get { return idPersonnel; }
            set { idPersonnel = value; }
        }
        public string NumberPhone
        {
            get { return numberPhone; }
            set { numberPhone = value; lblNumberPhone.Text = numberPhone; }
        }

        public void loadDataPersonnel()
        {
            personnelForm.LoadDataPersonnel();
        }

        private void btnDeletePersonnel_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(personnelForm.IdTaiKhoan, "Q0017");
            if(checkPermission)
            {
                string[] information = { "Bạn có chắc chắn xóa nhân sự này?", $"{this.personnelName} sẽ được xóa khỏi hệ thống", "Xóa nhân sự" };
                LayoutConfirmForm deleteLayoutConfirm = new LayoutConfirmForm(this, this.IdPersonnel);
                deleteLayoutConfirm.Title = information[0];
                deleteLayoutConfirm.Content = information[1];
                deleteLayoutConfirm.btnConfirmText = information[2];
                deleteLayoutConfirm.Show();
            } else {                 
                MessageBox.Show("Bạn không có quyền xóa nhân viên");
            }

        }

        private void btnEditPersonnel_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(personnelForm.IdTaiKhoan, "Q0016");
            if (checkPermission)
            {
                var updatePersonnel = new Personnel
                {
                    Id = this.idPersonnel,
                    Ten = this.personnelName,
                    Email = this.email,
                    GioiTinh = this.gender,
                    NgaySinh = this.dateOfBirth,
                    NgayVaoLam = this.dateOfWork,
                    Sdt = this.numberPhone
                }; 
                UpdatePersonnelForm updatePersonnelForm = new UpdatePersonnelForm(this, updatePersonnel);
                updatePersonnelForm.Show();
            } else
            {
                MessageBox.Show("Bạn không có quyền sửa nhân viên");
            }
        }
    }
}
