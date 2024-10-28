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

namespace Fastie
{
    public partial class CreateDepartmentForm : Form
    {
        CRUDDepartmentBLL boPhanBLL = new CRUDDepartmentBLL();

        public CreateDepartmentForm()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            try
            {
                BoPhanDTO newBoPhan = new BoPhanDTO
                {
                    Ten = cTBName.Text,
                    MoTa = cTBDescribe.Text
                };
                boPhanBLL.InsertDepartmentDAL(newBoPhan);
                MessageBox.Show("Thêm Bộ phận mới thành công!", "Success");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            this.Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            cTBName.Text = string.Empty;
            cTBDescribe.Text = string.Empty;
        }
    }
}
