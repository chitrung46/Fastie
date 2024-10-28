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
    public partial class UpdatePositionForm : Form
    {
        private readonly Position needEdit;
        PositionForm positionForm;
        PositionBLL positionBLL = new PositionBLL();
        public UpdatePositionForm(PositionForm positionForm, Position chucVu)
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

        private void customButton1_Click(object sender, EventArgs e)
        {
            needEdit.Ten = cTBName.Text;         // Lấy tên mới từ textbox cTBName
            needEdit.MoTa = cTBDesribe.Text;
            positionBLL.UpdatePositionBLL(needEdit);
            MessageBox.Show("Sửa Bộ phận thành công!", "Success");
            positionForm.LoadPositionData();
            this.Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
