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
using Fastie.Components.Toastify;

namespace Fastie.Screens.Task
{
    public partial class DetailAssignPositiveTaskForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        private string idTaiKhoanNguoiDung;
        private string idBoPhanNguoiDung;
        private string loaiGiaoViec = "Giao việc chủ động";
        private bool result;
        DepartmentBLL departmentBLL = new DepartmentBLL();
        public DetailAssignPositiveTaskForm(string idTaiKhoan, string idBoPhan)
        {
            InitializeComponent();
            this.idTaiKhoanNguoiDung = idTaiKhoan;
            this.idBoPhanNguoiDung = idBoPhan;
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
            cCBLoaiCongViec.DataSource = danhSachLoaiCongViec;
            foreach (var item in danhSachLoaiCongViec)
            {
                Console.WriteLine("Id: " + item.Id + ", Ten: " + item.Ten);   // Kiểm tra dữ liệu
            }
            cCBLoaiCongViec.DisplayMember = "Ten";  // Hiển thị tên loại công việc
            cCBLoaiCongViec.ValueMember = "Id";     // Giá trị là ID của loại công việc
            cCBLoaiCongViec.SelectedIndex = -1;
        }
        
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTaskName.Text) || string.IsNullOrWhiteSpace(cCBLoaiCongViec.Texts) ||
            string.IsNullOrWhiteSpace(cTBDescribeTask.Text) || dtpTimeCompleted.Value == null || dtpTimeCompleted.Value <= DateTime.Now || string.IsNullOrWhiteSpace(txbSoNhanSuChuDong.Text))
            {
                showMessage("Vui lòng nhập đủ thông tin!", "error");
                return; // Exit the method if validation fails
            }
            if (cCBLoaiCongViec.Texts == "Giao việc")
            {
                List<String> danhSachTaiKhoanNhanViec = new List<String>();
                List<String> danhSachBoPhanNhanViec = new List<String>();

                foreach (DataGridViewRow row in dgvBoPhanNhanViec.Rows)
                {
                    string idBoPhanNhanViec = row.Cells["idBoPhan"].Value?.ToString();
                    if (!string.IsNullOrEmpty(idBoPhanNhanViec))
                    {
                        danhSachBoPhanNhanViec.Add(idBoPhanNhanViec);
                    }
                }
                foreach (DataGridViewRow row in dgvTaiKhoanNhanViec.Rows)
                {
                    string idTaiKhoanNhanViec = row.Cells["idTaiKhoan"].Value?.ToString();
                    if (!string.IsNullOrEmpty(idTaiKhoanNhanViec))
                    {
                        danhSachTaiKhoanNhanViec.Add(idTaiKhoanNhanViec);
                    }
                }
                
                
                var thongTinGiaoViec = new ThongTinGiaoViec()
                {
                    Ten = txbTaskName.Text,
                    MoTa = cTBDescribeTask.Text,
                    ThoiHanHoanThanh = dtpTimeCompleted.Value.ToString(),
                    IdBoPhanGiaoViec = this.idBoPhanNguoiDung,
                    IdTaiKhoanGiaoViec = this.idTaiKhoanNguoiDung,
                    DanhSachTaiKhoanNhanViec = string.Join(",", danhSachTaiKhoanNhanViec),
                    DanhSachBoPhanNhanViec = string.Join(",", danhSachBoPhanNhanViec),
                    DanhSachHinhAnh = "",
                    DanhSachTaiLieu = "",
                    SoLuongNhanSuChuDong = Convert.ToInt32(txbSoNhanSuChuDong.Text)
                };
                result = taskBLL.GiaoViec("Giao việc chủ động", thongTinGiaoViec);
                

                if (result)
                {
                    showMessage("Giao việc thành công", "success");
                }
                else
                {
                    showMessage("Giao việc thất bại", "error");
                }
                this.Close();
            }
            else if (cCBLoaiCongViec.Texts == "Ra thông báo")
            {
                showMessage("Chưa hoàn thiện chức năng", "success");
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            var selectedDepartment = cbxDepartment.SelectedItem as DTO.Department;
            if (selectedDepartment == null) return;

            // Check if department already exists in DataGridView
            foreach (DataGridViewRow row in dgvBoPhanNhanViec.Rows)
            {
                if (row.Cells["idBoPhan"].Value?.ToString() == selectedDepartment.Id)
                {
                    showMessage("Bộ phận đã được thêm", "error");
                    return;
                }
            }

            // Add selected department to DataGridView
            dgvBoPhanNhanViec.Rows.Add(selectedDepartment.Id, selectedDepartment.Ten);

            // Populate comboBoxNguoiNhan with managers of all departments in dgvDepartments
            LayQuanLiBoPhanDuocChon();
        }
        private void LayQuanLiBoPhanDuocChon()
        {
            List<AcceptTaskPersonnel> managers = new List<AcceptTaskPersonnel>();

            foreach (DataGridViewRow row in dgvBoPhanNhanViec.Rows)
            {
                string idBoPhanValue = row.Cells["idBoPhan"].Value?.ToString();
                if (!string.IsNullOrEmpty(idBoPhanValue))
                {
                    if (idBoPhanValue == this.idBoPhanNguoiDung)
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
            foreach (DataGridViewRow row in dgvTaiKhoanNhanViec.Rows)
            {
                if (row.Cells["idTaiKhoan"].Value?.ToString() == selectedRecipient.Id)
                {
                    showMessage("Người nhận đã được thêm", "error");
                    return;
                }
            }

            dgvTaiKhoanNhanViec.Rows.Add(selectedRecipient.Id, selectedRecipient.Ten);
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            if (dgvBoPhanNhanViec.SelectedRows.Count > 0)
            {
                dgvBoPhanNhanViec.Rows.RemoveAt(dgvBoPhanNhanViec.SelectedRows[0].Index);
                LayQuanLiBoPhanDuocChon(); 
            }
            else
            {
                showMessage("Vui lòng chọn bộ phận để xóa", "error");
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoanNhanViec.SelectedRows.Count > 0)
            {
                dgvTaiKhoanNhanViec.Rows.RemoveAt(dgvTaiKhoanNhanViec.SelectedRows[0].Index);
            }
            else
            {
                showMessage("Vui lòng chọn người nhận để xóa", "error");
            }
        }

        private void DetailAssignPositiveTaskForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnUpdate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
