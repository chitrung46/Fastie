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
using DTO;
namespace Fastie
{
    public partial class UpdateDepartmentForm : Form
    {
        private readonly Department needEdit;
        DepartmentBLL departmentBLL = new DepartmentBLL();
        DepartmentForm departmentForm;

        public UpdateDepartmentForm(DepartmentForm departmentForm, Department editDepartment)
        {
            InitializeComponent();
            this.needEdit = editDepartment;
            this.departmentForm = departmentForm;
        }

        private void UpdateDepartmentForm_Load(object sender, EventArgs e)
        {
            cTBName.Text = needEdit.Ten;
            cTBDescribe.Text = needEdit.MoTa;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho Tên bộ phận.", "Thông báo");
                return; // Dừng lại không thực hiện thao tác thêm
            }
            //string id = needEdit.Id;
            needEdit.Ten = cTBName.Text;         // Lấy tên mới từ textbox cTBName
            needEdit.MoTa = cTBDescribe.Text;
            departmentBLL.UpdateDepartmentBLL(needEdit);
            MessageBox.Show("Sửa Bộ phận thành công!", "Success");
            this.Close();
            departmentForm.LoadDepartmentData();
        }
    }
}
