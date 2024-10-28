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
        PositionBLL positionBLL = new PositionBLL();
        public PositionForm()
        {
            InitializeComponent();
            LoadPositionData();
        }
        public void LoadPositionData()
        {
            List<Position> positionList = positionBLL.GetPositionListBLL();
            dgvPosition.Rows.Clear();
            foreach (Position position in positionList)
            {
                dgvPosition.Rows.Add(position.Id, position.Ten, position.MoTa);
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the selected row
                var selectedRow = dgvPosition.SelectedRows[0];
                if (selectedRow.Cells["id"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["id"].Value.ToString()))
                {
                    MessageBox.Show("Ô dữ liệu này trống. Vui lòng chọn một chức vụ có dữ liệu hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var updatePosition = new Position
                    {
                        Id = selectedRow.Cells["iD"].Value.ToString(),
                        Ten = selectedRow.Cells["tenChucVu"].Value.ToString(),
                        MoTa = selectedRow.Cells["moTa"].Value.ToString()

                    };
                    UpdatePositionForm updatePositionForm = new UpdatePositionForm(this,updatePosition);
                    updatePositionForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ để cập nhật");
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CreatePositionForm createPositionForm = new CreatePositionForm(this);
            createPositionForm.Show();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPosition.SelectedRows[0];
                if (selectedRow.Cells["ID"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["ID"].Value.ToString()))
                {
                    MessageBox.Show("Ô dữ liệu này trống. Vui lòng chọn một chức vụ có dữ liệu hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string id = selectedRow.Cells["ID"].Value.ToString();
                        positionBLL.DeletePositionBLL(id);
                        dgvPosition.Rows.RemoveAt(selectedRow.Index);
                        MessageBox.Show("Xóa chức vụ thành công!", "Success");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để xóa.");
            }
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
