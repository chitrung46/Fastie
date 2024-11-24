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
            dTPBirthday.CustomFormat = "yyyy/MM/dd";
            dTPDayOfWork.Format = DateTimePickerFormat.Custom;
            dTPDayOfWork.CustomFormat = "yyyy/MM/dd";

            cCBSex.Items.Add("Nam");
            cCBSex.Items.Add("Nữ");
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                showMessage("Vui lòng nhập đầy đủ thông tin", "error");
                return;
            }
            needEdit.Ten = cTBName.Text;        

            needEdit.Ten = cTBName.Text;         // Lấy tên mới từ textbox cTBName
            needEdit.Email = cTBEmail.Text;
            needEdit.GioiTinh = cCBSex.Texts;
            needEdit.NgaySinh = dTPBirthday.Value;
            needEdit.NgayVaoLam = dTPDayOfWork.Value;
            needEdit.Sdt = cTBNumberPhone.Text;
            personnelBLL.UpdatePersonnel(needEdit);
            
            showMessage("Sửa nhân sự thành công!", "success");
            layoutpersonnelForm.loadDataPersonnel();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
