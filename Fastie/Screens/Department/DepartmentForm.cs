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
using GUI.TruniControls;
namespace Fastie
{
    public partial class DepartmentForm : Form
    {
        DepartmentBLL departmentBLL = new DepartmentBLL();
        public DepartmentForm()
        {
            InitializeComponent();
            LoadDepartmentData();

        }

        public void LoadDepartmentData ()
        {
            List<Department> departmentList = departmentBLL.GetDepartmentListBLL();
            dgvPosition.Rows.Clear();
            foreach (Department department in departmentList)
            {
                dgvPosition.Rows.Add(department.Id, department.Ten, department.MoTa);
            }
        }
        private void dgvPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CreateDepartmentForm createDepartmentForm = new CreateDepartmentForm(this);
            createDepartmentForm.Show();
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
                    var updateDepartment = new Department
                    {
                        Id = selectedRow.Cells["ID"].Value.ToString(),
                        Ten = selectedRow.Cells["tenBoPhan"].Value.ToString(),
                        MoTa = selectedRow.Cells["moTa"].Value.ToString()

                    };
                    UpdateDepartmentForm updateDepartmentForm = new UpdateDepartmentForm(this, updateDepartment);
                    updateDepartmentForm.Show();
                }                                 
            }
            else
            {
                MessageBox.Show("Please select a student to edit."); // Inform user if no selection
            }
            
        }

        private void dgvPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

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
                        departmentBLL.DeleteDepartmentBLL(id);
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
    }
}
