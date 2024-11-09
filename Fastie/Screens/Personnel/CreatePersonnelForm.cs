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

namespace Fastie
{
    public partial class CreatePersonnelForm : Form
    {
        PersonnelBLL nhanSuBLL = new PersonnelBLL();
        private PersonnelForm personnelForm;
        public CreatePersonnelForm(PersonnelForm personnelForm)
        {
            InitializeComponent();
            // Thiết lập định dạng cho DateTimePicker trong form
            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.CustomFormat = "yyyy-MM-dd";
            // Thiết lập định dạng cho DateTimePicker trong form
            dTPDayOfWork.Format = DateTimePickerFormat.Custom;
            dTPDayOfWork.CustomFormat = "yyyy-MM-dd";
            cCBSex.Items.Add("Nam");
            cCBSex.Items.Add("Nữ");
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
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            personnelForm.LoadDataPersonnel();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
