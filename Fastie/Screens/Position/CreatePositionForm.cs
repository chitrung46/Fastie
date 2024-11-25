using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using Fastie.Components.LayoutDepartment;
using Fastie.Components.Toastify;
namespace Fastie
{
    public partial class CreatePositionForm : Form
    {
        PositionBLL positionBLL = new PositionBLL();
        private PositionForm positionForm;
        public CreatePositionForm(PositionForm positionForm) 
        {
            InitializeComponent();
            this.positionForm = positionForm;
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cTBName.Text))
            {
                showMessage("Vui lòng nhập đầy đủ thông tin", "error");
                return;
            }
            try
            {
                Position newPosition = new Position
                {
                    Ten = cTBName.Text,
                    MoTa = cTBDescribe.Text
                };
                positionBLL.InsertPosition(newPosition);
                showMessage("Thêm Chức vụ mới thành công!", "success");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
            positionForm.LoadDataPosition();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatePositionForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAdd;
        }
    }
}
