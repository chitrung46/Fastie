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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreatePersonnel_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customComboBox1_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void customTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void customComboBox1_OnSelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void dTPBirtday_ValueChanged(object sender, EventArgs e)
        {
           
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
                MessageBox.Show("Thêm Nhân sự mới thành công!", "Success");
                //string ngaySinhFormatted = newNhanSu.NgaySinh.ToString("yyyy-MM-dd");
                //string ngayVaoLamFormatted = newNhanSu.NgayVaoLam.ToString("yyyy-MM-dd");

                //MessageBox.Show($"Thêm Nhân sự mới thành công!);\nNgày Sinh: {ngaySinhFormatted}\nNgày Vào Làm: {ngayVaoLamFormatted}", "Success");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            personnelForm.LoadDataPersonnel();
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
    }
}
