using BLL;
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

namespace Fastie
{
    public partial class UpdatePersonnelForm : Form
    {
        private readonly Personnel needEdit;
        PersonnelForm personnelForm;
        PersonnelBLL personnelBLL = new PersonnelBLL();
        public UpdatePersonnelForm(PersonnelForm personnelForm, Personnel nhanSu)
        {
            InitializeComponent();
            needEdit = nhanSu;
            this.personnelForm = personnelForm;
            // Thiết lập định dạng cho DateTimePicker trong form
            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.CustomFormat = "dd/MM/yyyy";
            // Thiết lập định dạng cho DateTimePicker trong form
            dTPDayOfWork.Format = DateTimePickerFormat.Custom;
            dTPDayOfWork.CustomFormat = "dd/MM/yyyy";
            cCBSex.Items.Add("Nam");
            cCBSex.Items.Add("Nữ");
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePersonnelForm_Load(object sender, EventArgs e)
        {
            cTBName.Text = needEdit.Ten;
            cTBEmail.Text = needEdit.Email;
            cTBNumberPhone.Text = needEdit.Sdt;
            cCBSex.ValueMember = needEdit.GioiTinh;
            dTPBirthday.Value = needEdit.NgaySinh;
            dTPDayOfWork.Value = needEdit.NgayVaoLam;

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            
            needEdit.Ten = cTBName.Text;         // Lấy tên mới từ textbox cTBName
            needEdit.Email = cTBEmail.Text;
            needEdit.GioiTinh = cCBSex.ValueMember;
            needEdit.NgaySinh = dTPBirthday.Value;
            needEdit.NgayVaoLam = dTPDayOfWork.Value;
            needEdit.Sdt = cTBNumberPhone.Text;
            personnelBLL.UpdatePersonnel(needEdit);
            MessageBox.Show("Sửa Nhân sự thành công!", "Success");
            personnelForm.LoadPersonnelData();
            this.Close();
        }
    }
}
