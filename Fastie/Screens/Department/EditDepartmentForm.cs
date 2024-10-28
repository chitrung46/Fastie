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
    public partial class EditDepartmentForm : Form
    {
        private readonly BoPhanDTO needEdit;
        CRUDDepartmentBLL boPhanBLL = new CRUDDepartmentBLL();
        public EditDepartmentForm(BoPhanDTO editDepartment)
        {
            InitializeComponent();
            this.needEdit = editDepartment;
        }

        private void EditDepartmentForm_Load(object sender, EventArgs e)
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
            //string id = needEdit.Id;
            needEdit.Ten = cTBName.Text;         // Lấy tên mới từ textbox cTBName
            needEdit.MoTa = cTBDescribe.Text;
            boPhanBLL.EditDepartmentDAL(needEdit);
            MessageBox.Show("Sửa Bộ phận thành công!", "Success");
            this.Close();
        }
    }
}
