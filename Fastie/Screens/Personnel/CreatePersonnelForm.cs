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
using Fastie.Components.LayoutDepartment;
using Fastie.Components.Toastify;
using System.Text.RegularExpressions;

namespace Fastie
{
    public partial class CreatePersonnelForm : Form
    {
        PersonnelBLL nhanSuBLL = new PersonnelBLL();
        private PersonnelForm personnelForm;
        public CreatePersonnelForm(PersonnelForm personnelForm)
        {
            InitializeComponent();
            this.personnelForm = personnelForm;
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
            if(dTPBirthday.Value.Date > DateTime.Now.Date)
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

            try
            {
                Personnel newNhanSu = new Personnel
                {
                    Ten = cTBName.Text,
                    Email = cTBEmail.Text,
                    GioiTinh = cCBSex.SelectedItem.ToString(),
                    NgaySinh = dTPBirthday.Value.Date,
                    NgayVaoLam = dTPDayOfWork.Value.Date,
                    Sdt = cTBNumberPhone.Text
                };
                nhanSuBLL.InsertPersonnel(newNhanSu);
                showMessage("Thêm Nhân sự mới thành công!", "success");
                personnelForm.LoadDataPersonnel();
                this.Close();
            }
            catch (Exception ex)
            {
                showMessage("Email đã tồn tại", "error");
                return;
            }
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Mẫu kiểm tra định dạng email
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatePersonnelForm_Load(object sender, EventArgs e)
        {
            cCBSex.Items.Add("Nam");
            cCBSex.Items.Add("Nữ");
            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.CustomFormat = "dd/MM/yyyy";
            dTPDayOfWork.Format = DateTimePickerFormat.Custom;
            dTPDayOfWork.CustomFormat = "dd/MM/yyyy";
            this.AcceptButton = btnAdd;
        }

        private void cTBNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}
