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
    public partial class PositionForm : Form
    {
        CRUDPositionBLL chucVuBLL = new CRUDPositionBLL();
        public PositionForm()
        {
            InitializeComponent();
            LoadPositionData();
        }
        public void LoadPositionData()
        {
            List<ChucVuDTO> positionList = chucVuBLL.GetPositionListDAL();
            dgvPosition.Rows.Clear();
            foreach (ChucVuDTO position in positionList)
            {
                dgvPosition.Rows.Add(position.Id, position.Ten, position.MoTa);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the selected row
                var selectedRow = dgvPosition.SelectedRows[0];
                if (selectedRow.Cells["ID"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["ID"].Value.ToString()))
                {
                    MessageBox.Show("Ô dữ liệu này trống. Vui lòng chọn một bộ phận có dữ liệu hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var editPosition = new ChucVuDTO
                    {
                        Id = selectedRow.Cells["ID"].Value.ToString(),
                        Ten = selectedRow.Cells["tenChucVu"].Value.ToString(),
                        MoTa = selectedRow.Cells["moTa"].Value.ToString()

                    };
                    EditPositionForm editPositionForm = new EditPositionForm(editPosition);
                    editPositionForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to edit."); // Inform user if no selection
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CreatePositionForm createPositionForm = new CreatePositionForm();
            createPositionForm.Show();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPosition.SelectedRows[0];
                if (selectedRow.Cells["ID"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["ID"].Value.ToString()))
                {
                    MessageBox.Show("Ô dữ liệu này trống. Vui lòng chọn một bộ phận có dữ liệu hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bộ phận này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string id = selectedRow.Cells["ID"].Value.ToString();
                        chucVuBLL.DeletePositionDAL(id);
                        dgvPosition.Rows.RemoveAt(selectedRow.Index);
                        MessageBox.Show("Xóa bộ phận thành công!", "Success");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bộ phận để xóa.");
            }
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
