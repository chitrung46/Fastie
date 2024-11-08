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

namespace Fastie
{
    public partial class UpdatePersonnelForm : Form
    {

        private readonly Personnel needEdit;
  
        private LayoutPersonnelForm personnelForm;
        PersonnelBLL personnelBLL = new PersonnelBLL();
        public UpdatePersonnelForm(LayoutPersonnelForm personnelForm, Personnel nhanSu)
        {
            InitializeComponent();
            needEdit = nhanSu;
            this.personnelForm = personnelForm;

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho Tên nhân sự.", "Thông báo");
                return;
            }
            needEdit.Id = personnelForm.IdPersonnel;
            needEdit.Ten = cTBName.Text;        
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho Tên nhân sự.", "Thông báo");
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
            this.Close();
            MessageBox.Show("Sửa Nhân sự thành công!", "Success");
            personnelForm.loadDataPersonnel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
