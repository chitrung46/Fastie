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
namespace Fastie
{
    public partial class CreatePositionForm : Form
    {
        CRUDPositionBLL chucVuBLL = new CRUDPositionBLL();
        public CreatePositionForm()
        {
            InitializeComponent();
        }

        private void CreatePosition_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ChucVuDTO newChucVu = new ChucVuDTO
                {
                    Ten = cTBName.Text,
                    MoTa = cTBDescribe.Text
                };
                chucVuBLL.InsertPositionDAL(newChucVu);
                MessageBox.Show("Thêm Chức vụ mới thành công!", "Success");
                
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
