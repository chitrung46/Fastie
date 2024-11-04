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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            needEdit.Ten = cTBName.Text;        
            needEdit.MoTa = cTBDesribe.Text;
            positionBLL.UpdatePosition(needEdit);
            MessageBox.Show("Sửa Bộ phận thành công!", "Success");
            positionForm.LoadPositionData();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
