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

        private void customButton1_Click(object sender, EventArgs e)
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
<<<<<<< HEAD
                MessageBox.Show("Thêm Nhân sự mới thành công!", "Success");
                //string ngaySinhFormatted = newNhanSu.NgaySinh.ToString("yyyy-MM-dd");
                //string ngayVaoLamFormatted = newNhanSu.NgayVaoLam.ToString("yyyy-MM-dd");

                //MessageBox.Show($"Thêm Nhân sự mới thành công!);\nNgày Sinh: {ngaySinhFormatted}\nNgày Vào Làm: {ngayVaoLamFormatted}", "Success");
                
=======
                string ngaySinhFormatted = newNhanSu.NgaySinh.ToString("yyyy-MM-dd");
                string ngayVaoLamFormatted = newNhanSu.NgayVaoLam.ToString("yyyy-MM-dd");

                MessageBox.Show($"Thêm Nhân sự mới thành công!\nNgày Sinh: {ngaySinhFormatted}\nNgày Vào Làm: {ngayVaoLamFormatted}", "Success");
                personnelForm.LoadDataPersonnel();
>>>>>>> origin/Toan
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
<<<<<<< HEAD
            personnelForm.LoadDataPersonnel();
=======
>>>>>>> origin/Toan
            this.Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            //cTBName.Text = string.Empty;
            //cTBEmail.Text = string.Empty;
            //cTBNumberPhone.Text = string.Empty;
            //cCBSex.SelectedIndex = -1;
            //dTPBirthday.Value = DateTime.Now;
            //dTPDayOfWork.Value = DateTime.Now;
            this.Close();
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
                string ngaySinhFormatted = newNhanSu.NgaySinh.ToString("yyyy-MM-dd");
                string ngayVaoLamFormatted = newNhanSu.NgayVaoLam.ToString("yyyy-MM-dd");

                MessageBox.Show($"Thêm Nhân sự mới thành công!\nNgày Sinh: {ngaySinhFormatted}\nNgày Vào Làm: {ngayVaoLamFormatted}", "Success");
                personnelForm.LoadDataPersonnel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
