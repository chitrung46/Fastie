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
using DTO;
using Fastie.Components.LayoutDepartmen;
using Fastie.Components.LayoutPersonnel;

namespace Fastie
{
    public partial class UpdatePersonnelForm : Form
    {
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

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho Tên nhân sự.", "Thông báo");
                return;
            }
            needEdit.Ten = cTBName.Text;         // Lấy tên mới từ textbox cTBName
            needEdit.Email = cTBEmail.Text;
            needEdit.GioiTinh = cCBSex.SelectedItem?.ToString();
            needEdit.NgaySinh = dTPBirthday.Value;
            needEdit.NgayVaoLam = dTPDayOfWork.Value;
            needEdit.Sdt = cTBNumberPhone.Text;
            personnelBLL.UpdatePersonnel(needEdit);
            MessageBox.Show("Sửa Nhân sự thành công!", "Success");
            personnelForm.loadDataPersonnel();
            this.Close();
        }
    }
}
