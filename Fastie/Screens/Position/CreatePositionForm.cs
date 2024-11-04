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
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Position newPosition = new Position
                {
                    Ten = cTBName.Text,
                    MoTa = cTBDescribe.Text
                };
                positionBLL.InsertPosition(newPosition);
                MessageBox.Show("Thêm Chức vụ mới thành công!", "Success");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            positionForm.LoadDataPosition();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
