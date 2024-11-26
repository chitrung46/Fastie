using System;
﻿using BLL;
using DTO;
using Fastie.Components.LayoutPersonnel;
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
using Fastie.Components.LayoutDepartmen;
using Fastie.Components.Toastify;
using System.Text.RegularExpressions;

namespace Fastie
{
    public partial class UpdatePersonnelForm : Form
    {

        private readonly Personnel needEdit;
  
        private LayoutPersonnelForm layoutpersonnelForm;
        PersonnelBLL personnelBLL = new PersonnelBLL();
        public UpdatePersonnelForm(LayoutPersonnelForm layoutpersonnelForm, Personnel nhanSu)
        {
            InitializeComponent();
            needEdit = nhanSu;
            this.layoutpersonnelForm = layoutpersonnelForm;

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void UpdatePersonnelForm_Load(object sender, EventArgs e)
        {
            cCBSex.Texts = this.needEdit.GioiTinh;
            cTBName.Text = needEdit.Ten;
            cTBEmail.Text = needEdit.Email;
            cTBNumberPhone.Text = needEdit.Sdt;
            foreach (var item in cCBSex.Items)
            {
                if (item.ToString() == needEdit.GioiTinh)
                {
                    cCBSex.SelectedItem = item;
                    break;
                }
            }

            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.CustomFormat = "dd/MM/yyyy";
            dTPDayOfWork.Format = DateTimePickerFormat.Custom;
            dTPDayOfWork.CustomFormat = "dd/MM/yyyy";

            dTPBirthday.Value = needEdit.NgaySinh;
            dTPDayOfWork.Value = needEdit.NgayVaoLam;

            cCBSex.Items.Add("Nam");
            cCBSex.Items.Add("Nữ");
            this.AcceptButton = btnUpdate;
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cTBName.Text))
            {
                showMessage("Vui lòng nhập tên!", "error");
                return;
            }
            if (string.IsNullOrWhiteSpace(cTBEmail.Text))
            {
                showMessage("Vui lòng nhập email!", "error");
                return;
            }
            if (!IsValidEmail(cTBEmail.Text))
            {
                showMessage("Email không hợp lệ!", "error");
                return;
            }
            if (string.IsNullOrWhiteSpace(cCBSex.Texts))
            {
                showMessage("Vui lòng chọn giới tính!", "error");
                return;
            }
            if (string.IsNullOrWhiteSpace(cTBNumberPhone.Text))
            {
                showMessage("Vui lòng nhập số điện thoại!", "error");
                return;
            }
            if (cTBNumberPhone.Text.Length < 10)
            {
                showMessage("Số điện thoại không hợp lệ!", "error");
                return;
            }
            if (string.IsNullOrEmpty(dTPBirthday.Value.Date.ToString()))
            {
                showMessage("Vui lòng chọn ngày sinh!", "error");
                return;
            }
            if (dTPBirthday.Value.Date > DateTime.Now.Date)
            {
                showMessage("Ngày sinh không hợp lệ!", "error");
                return;
            }
            if (string.IsNullOrEmpty(dTPDayOfWork.Value.Date.ToString()))
            {
                showMessage("Vui lòng chọn ngày vào làm!", "error");
                return;
            }
            if (dTPDayOfWork.Value.Date > DateTime.Now.Date)
            {
                showMessage("Ngày vào làm không hợp lệ!", "error");
                return;
            }

            needEdit.Ten = cTBName.Text;        
            needEdit.Ten = cTBName.Text;         
            needEdit.Email = cTBEmail.Text;
            needEdit.GioiTinh = cCBSex.Texts;
            needEdit.NgaySinh = dTPBirthday.Value;
            needEdit.NgayVaoLam = dTPDayOfWork.Value;
            needEdit.Sdt = cTBNumberPhone.Text;

            try
            {
                personnelBLL.UpdatePersonnel(needEdit);
                showMessage("Sửa nhân sự thành công!", "success");
                layoutpersonnelForm.loadDataPersonnel();
                this.Close();
            }
            catch(Exception ex)
            {
                showMessage("Có lỗi xảy ra!", "error");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cTBNumberPhone__TextChanged(object sender, EventArgs e)
        {
            if (cTBNumberPhone.Text != "" && int.TryParse(cTBNumberPhone.Text, out int value))
            {
                if (value < 0)
                {
                    showMessage("Vui lòng nhập số điện thoại hợp lệ!", "error");
                    cTBNumberPhone.Text = "";
                }
            }
        }

        private void cTBNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
