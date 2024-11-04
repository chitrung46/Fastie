using BLL;
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

namespace Fastie
{
    public partial class UpdatePersonnelForm : Form
    {
        PersonnelBLL personnelBLL = new PersonnelBLL();
        private Personnel personnel;
        private PersonnelForm personnelForm;
        private LayoutPersonnelForm layoutPersonnelForm;
        public UpdatePersonnelForm(LayoutPersonnelForm layoutPersonnelForm, Personnel personnel) {
            InitializeComponent();
            this.layoutPersonnelForm = layoutPersonnelForm;
            this.personnel = personnel;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePersonnelForm_Load(object sender, EventArgs e)
        {
            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.CustomFormat = "dd/MM/yyyy";
            dTPDayOfWork.Format = DateTimePickerFormat.Custom;
            dTPDayOfWork.CustomFormat = "dd/MM/yyyy";
            cCBSex.Items.Add("Nam");
            cCBSex.Items.Add("Nữ");

            cTBName.Text = layoutPersonnelForm.PersonnelName;
            cTBEmail.Text = layoutPersonnelForm.Email;
            cTBNumberPhone.Text = layoutPersonnelForm.NumberPhone;
            cCBSex.Texts = layoutPersonnelForm.Gender;
            dTPBirthday.Value = DateTime.Parse(layoutPersonnelForm.DateOfBirth);
            dTPDayOfWork.Value = DateTime.Parse(layoutPersonnelForm.DateOfWork);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
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
            layoutPersonnelForm.loadDataPersonnel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            layoutPersonnelForm.loadDataPersonnel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
