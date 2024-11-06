//<<<<<<< HEAD
﻿using System;
//=======
﻿using BLL;
using DTO;
using Fastie.Components.LayoutPersonnel;
using System;
//>>>>>>> origin/Toan
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
using Fastie.Components.LayoutPersonnel;

namespace Fastie
{
    public partial class UpdatePersonnelForm : Form
    {
//<<<<<<< HEAD
        private readonly Personnel needEdit;
        //PersonnelForm personnelForm;
        private LayoutPersonnelForm personnelForm;
        PersonnelBLL personnelBLL = new PersonnelBLL();
        public UpdatePersonnelForm(LayoutPersonnelForm personnelForm, Personnel nhanSu)
        {
            InitializeComponent();
            needEdit = nhanSu;
            this.personnelForm = personnelForm;
            // Thiết lập định dạng cho DateTimePicker trong form
            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.CustomFormat = "yyyy/MM/dd";
            // Thiết lập định dạng cho DateTimePicker trong form
            dTPDayOfWork.Format = DateTimePickerFormat.Custom;
            dTPDayOfWork.CustomFormat = "yyyy/MM/dd";
            cCBSex.Items.Add("Nam");
            cCBSex.Items.Add("Nữ");
/***=======
        PersonnelBLL personnelBLL = new PersonnelBLL();
        private Personnel personnel;
        private PersonnelForm personnelForm;
        private LayoutPersonnelForm layoutPersonnelForm;
        public UpdatePersonnelForm(LayoutPersonnelForm layoutPersonnelForm, Personnel personnel) {
            InitializeComponent();
            this.layoutPersonnelForm = layoutPersonnelForm;
            this.personnel = personnel;
>>>>>>> origin/Toan**/
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePersonnelForm_Load(object sender, EventArgs e)
        {
//<<<<<<< HEAD
            cTBName.Text = needEdit.Ten;
            cTBEmail.Text = needEdit.Email;
            cTBNumberPhone.Text = needEdit.Sdt;
            foreach (var item in cCBSex.Items)
            {
                if (item.ToString() == needEdit.GioiTinh) // So sánh với giá trị chuỗi
                {
                    cCBSex.SelectedItem = item; // Chọn giới tính hiện tại
                    break;
                }
            }
            dTPBirthday.Value = needEdit.NgaySinh;
            dTPDayOfWork.Value = needEdit.NgayVaoLam;
//=======
            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.CustomFormat = "yyyy/MM/dd";
            dTPDayOfWork.Format = DateTimePickerFormat.Custom;
            dTPDayOfWork.CustomFormat = "yyyy/MM/dd";
            cCBSex.Items.Add("Nam");
            cCBSex.Items.Add("Nữ");
//>>>>>>> origin/Toan
/***
            cTBName.Text = layoutPersonnelForm.PersonnelName;
            cTBEmail.Text = layoutPersonnelForm.Email;
            cTBNumberPhone.Text = layoutPersonnelForm.NumberPhone;
            cCBSex.Texts = layoutPersonnelForm.Gender;
            dTPBirthday.Value = DateTime.Parse(layoutPersonnelForm.DateOfBirth);
            dTPDayOfWork.Value = DateTime.Parse(layoutPersonnelForm.DateOfWork);***/
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
//<<<<<<< HEAD
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho Tên nhân sự.", "Thông báo");
                return;
            }
            needEdit.Id = personnelForm.IdPersonnel;
            needEdit.Ten = cTBName.Text;         // Lấy tên mới từ textbox cTBName
            needEdit.Email = cTBEmail.Text;
            needEdit.GioiTinh = cCBSex.SelectedItem?.ToString();
            needEdit.NgaySinh = dTPBirthday.Value;
            needEdit.NgayVaoLam = dTPDayOfWork.Value;
            needEdit.Sdt = cTBNumberPhone.Text;
            personnelBLL.UpdatePersonnel(needEdit);
            this.Close();
            MessageBox.Show("Sửa Nhân sự thành công!", "Success");
            personnelForm.loadDataPersonnel();
//=======
            //personnel.Id = layoutPersonnelForm.IdPersonnel;
           // personnel.Ten = cTBName.Text;         
           // personnel.Email = cTBEmail.Text;
           // personnel.GioiTinh = cCBSex.Texts;
           // personnel.NgaySinh = dTPBirthday.Value;
           // personnel.NgayVaoLam = dTPDayOfWork.Value;
           // personnel.Sdt = cTBNumberPhone.Text;
           // personnelBLL.UpdatePersonnel(personnel);
            
            //MessageBox.Show("Sửa Nhân sự thành công!", "Success");
            //layoutPersonnelForm.loadDataPersonnel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {/***
            personnel.Id = layoutPersonnelForm.IdPersonnel;
            personnel.Ten = cTBName.Text;
            personnel.Email = cTBEmail.Text;
            personnel.GioiTinh = cCBSex.Texts;
            personnel.NgaySinh = dTPBirthday.Value;
            personnel.NgayVaoLam = dTPDayOfWork.Value;
            personnel.Sdt = cTBNumberPhone.Text;
            personnelBLL.UpdatePersonnel(personnel);
            this.Close();
            MessageBox.Show("Sửa Nhân sự thành công!", "Success");
            layoutPersonnelForm.loadDataPersonnel();***/
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho Tên nhân sự.", "Thông báo");
                return;
            }
            //needEdit.Id = personnelForm.IdPersonnel;
            needEdit.Ten = cTBName.Text;         // Lấy tên mới từ textbox cTBName
            needEdit.Email = cTBEmail.Text;
            needEdit.GioiTinh = cCBSex.SelectedItem?.ToString();
            needEdit.NgaySinh = dTPBirthday.Value;
            needEdit.NgayVaoLam = dTPDayOfWork.Value;
            needEdit.Sdt = cTBNumberPhone.Text;
            personnelBLL.UpdatePersonnel(needEdit);
            this.Close();
            MessageBox.Show("Sửa Nhân sự thành công!", "Success");
            personnelForm.loadDataPersonnel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
//>>>>>>> origin/Toan
            this.Close();
        }
    }
}
