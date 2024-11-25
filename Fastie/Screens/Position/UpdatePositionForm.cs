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
using Fastie.Components.LayoutDepartment;
using Fastie.Components.Toastify;
namespace Fastie
{
    public partial class UpdatePositionForm : Form
    {
        private readonly Position needEdit;
        private LayoutPositionForm positionForm;
        PositionBLL positionBLL = new PositionBLL();
        public UpdatePositionForm(LayoutPositionForm positionForm, Position chucVu)
        {
            InitializeComponent();
            needEdit = chucVu;
            this.positionForm = positionForm;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditPositionForm_Load(object sender, EventArgs e)
        {
            cTBName.Text = needEdit.Ten;
            cTBDesribe.Text = needEdit.MoTa;
            this.AcceptButton = btnUpdate;
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cTBName.Text))
            {
                showMessage("Vui lòng nhập tên chức vụ", "error");
                return;
            }
            needEdit.Ten = cTBName.Text;        
            needEdit.MoTa = cTBDesribe.Text;
            positionBLL.UpdatePosition(needEdit);
            showMessage("Sửa chức vụ thành công!", "success");
            positionForm.LoadPositionData();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
