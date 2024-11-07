using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.DepartmentBLL;
using DTO;
using DTO.TaskDTO;

namespace Fastie.Screens.Task
{
    public partial class DetailAssignPositiveTaskForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        private string idTaiKhoan;
        private string idBoPhanKhiDangNhap;
        DepartmentBLL departmentBLL = new DepartmentBLL();
        public DetailAssignPositiveTaskForm(string idTaiKhoan, string idBoPhan)
        {
            InitializeComponent();
            this.idTaiKhoan = idTaiKhoan;
            this.idBoPhanKhiDangNhap = idBoPhan;
            LoadTaskTypeComboBox();
            LoadDepartmentComboBox();
            dtpTimeCompleted.Format = DateTimePickerFormat.Custom;
            dtpTimeCompleted.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadDepartmentComboBox()
        {
            List<DTO.Department> danhSachBoPhan = departmentBLL.GetDepartmentList();
            cbxDepartment.DataSource = danhSachBoPhan;
            cbxDepartment.DisplayMember = "Ten";  // Hiển thị tên loại công việc
            cbxDepartment.ValueMember = "Id";     // Giá trị là ID của loại công việc
            cbxDepartment.SelectedIndex = -1;
        }
        private void LoadTaskTypeComboBox()
        {
            List<TaskType> danhSachLoaiCongViec = taskBLL.LayDanhSachLoaiCongViec();
            customComboBox1.DataSource = danhSachLoaiCongViec;
            foreach (var item in danhSachLoaiCongViec)
            {
                Console.WriteLine("Id: " + item.Id + ", Ten: " + item.Ten);   // Kiểm tra dữ liệu
            }
            customComboBox1.DisplayMember = "Ten";  // Hiển thị tên loại công việc
            customComboBox1.ValueMember = "Id";     // Giá trị là ID của loại công việc
            customComboBox1.SelectedIndex = -1;
        }
        

        private void txbTaskName_Load(object sender, EventArgs e)
        {

        }

        private void cbxDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cTBDescribeTask_Load(object sender, EventArgs e)
        {

        }

        private void cbxPersonnel_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTaskName.Text) || string.IsNullOrWhiteSpace(customComboBox1.Texts) ||
            string.IsNullOrWhiteSpace(cTBDescribeTask.Text) || dtpTimeCompleted.Value == null || dtpTimeCompleted.Value <= DateTime.Now || string.IsNullOrWhiteSpace(txbSoNhanSuChuDong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if validation fails
            }
            string testIdLichSu = taskBLL.TaoLichSuId();
            if (testIdLichSu != null)
            {
                MessageBox.Show("Tạo ID lịch sử thành công", testIdLichSu);
            }
            else
            {
                MessageBox.Show("Tạo ID lịch sử thất bại");
            }

            var task = new TaskInfo()
            {
                IdLoaiCongViec = taskBLL.LayIdLoaiCongViecTuTen(customComboBox1.Texts),
                IdBoPhanGiaoViec = this.idBoPhanKhiDangNhap,
                Id = taskBLL.TaoCongViecId(taskBLL.LayIdLoaiCongViecTuTen(customComboBox1.Texts), this.idBoPhanKhiDangNhap),
                Ten = txbTaskName.Text,
                GhiChu = "",
                MoTa = cTBDescribeTask.Text,
                ThoiGianGiaoViec = DateTime.Now,
                ThoiHanHoanThanh = dtpTimeCompleted.Value,
                IdTienDoCongViec = "TD001",
                IdTaiKhoanGiaoViec = this.idTaiKhoan,
                IdLichSuMacDinh = taskBLL.TaoLichSuId()
            };

            bool result = taskBLL.ThemCongViecGiaoViec(task);
            if (result)
            {
                int soLuongNhanSuChuDong;
                if (int.TryParse(txbSoNhanSuChuDong.Text, out soLuongNhanSuChuDong))
                {
                    taskBLL.ThemCongViecChuDong(task.Id, soLuongNhanSuChuDong);
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string departmentId = row.Cells["idBoPhan"].Value?.ToString();
                    if (!string.IsNullOrEmpty(departmentId))
                    {
                        // Save department assignment to BoPhanNhanViec table
                        taskBLL.LuuBoPhanNhanViec(departmentId, task.Id);
                    }
                }
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    string recipientId = row.Cells["idNhanSu"].Value?.ToString();
                    if (!string.IsNullOrEmpty(recipientId))
                    {
                        // Save recipient assignment to TaiKhoanNhanViec table
                        taskBLL.LuuTaiKhoanNhanViec(recipientId, task.Id);
                    }
                }
                MessageBox.Show("Công việc đã được thêm thành công!", "Thông báo");
                this.Close();
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            var selectedDepartment = cbxDepartment.SelectedItem as DTO.Department;
            if (selectedDepartment == null) return;

            // Check if department already exists in DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["idBoPhan"].Value?.ToString() == selectedDepartment.Id)
                {
                    MessageBox.Show("Department is already added.");
                    return;
                }
            }

            // Add selected department to DataGridView
            dataGridView1.Rows.Add(selectedDepartment.Id, selectedDepartment.Ten);

            // Populate comboBoxNguoiNhan with managers of all departments in dgvDepartments
            LayQuanLiBoPhanDuocChon();
        }
        private void LayQuanLiBoPhanDuocChon()
        {
            List<AcceptTaskPersonnel> managers = new List<AcceptTaskPersonnel>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string idBoPhanValue = row.Cells["idBoPhan"].Value?.ToString();
                if (!string.IsNullOrEmpty(idBoPhanValue))
                {
                    if (idBoPhanValue == this.idBoPhanKhiDangNhap)
                    {
                        List<AcceptTaskPersonnel> departmentPersonnel = departmentBLL.LayNhanSuBoPhan(idBoPhanValue);
                        managers.AddRange(departmentPersonnel);
                    }
                    else
                    {
                        List<AcceptTaskPersonnel> departmentManagers = departmentBLL.LayQuanLiBoPhan(idBoPhanValue);
                        managers.AddRange(departmentManagers);
                    }
                    // Get managers for each department in dgvDepartments

                }
            }

            // Remove duplicates and set as the DataSource of comboBoxNguoiNhan
            var uniqueManagers = managers.GroupBy(m => m.Id).Select(g => g.First()).ToList();
            cbxPersonnel.DataSource = uniqueManagers;
            cbxPersonnel.DisplayMember = "Tên";
            cbxPersonnel.ValueMember = "Id";
            cbxPersonnel.SelectedIndex = -1;
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            var selectedRecipient = cbxPersonnel.SelectedItem as AcceptTaskPersonnel;
            if (selectedRecipient == null) return;

            // Check if recipient is already added
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["idNhanSu"].Value?.ToString() == selectedRecipient.Id)
                {
                    //MessageBox.Show("Recipient is already added.");
                    return;
                }
            }

            // Add selected recipient to dgvRecipients
            dataGridView2.Rows.Add(selectedRecipient.Id, selectedRecipient.Ten);
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                LayQuanLiBoPhanDuocChon();  // Refresh managers after removing a department
            }
            else
            {
                MessageBox.Show("Please select a department to remove.");
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a recipient to remove.");
            }
        }
    }
}
