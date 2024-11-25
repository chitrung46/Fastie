using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
    public partial class DetailAssignTaskForm : Form
    {
        private DriveService driveService;
        TaskBLL taskBLL = new TaskBLL();
        private string idTaiKhoan;
        private string idBoPhanKhiDangNhap;
        DepartmentBLL departmentBLL = new DepartmentBLL();
        private string fileName;
        private string imageName;
        public DetailAssignTaskForm(string idTaiKhoan, string idBoPhan)
        {
            InitializeGoogleDriveService();
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
            customComboBox1.DisplayMember = "Ten";  // Hiển thị tên loại công việc
            customComboBox1.ValueMember = "Id";     // Giá trị là ID của loại công việc
            customComboBox1.SelectedIndex = -1;
        }
        private void InitializeGoogleDriveService()
        {

            string serviceAccountKeyPath = "credential_fastie.json";

            // Xác thực với Google Drive API
            var credential = GoogleCredential.FromFile(serviceAccountKeyPath)
                .CreateScoped(DriveService.Scope.Drive);

            driveService = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "FileAndImageUploader"
            });

            //MessageBox.Show("Google Drive service initialized successfully!");
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            btnUploadFile.ForeColor = Color.FromArgb(59, 171, 201);
            btnUploadImage.ForeColor = Color.FromArgb(255, 255, 255);
            SelectFile();
            lblFileName.Text = fileName;
            //UploadToGoogleDrive("application/octet-stream", fileName);
        }
        private void SelectFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt;*.csv|Word Documents|*.doc;*.docx|Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            btnUploadImage.ForeColor = Color.FromArgb(59, 171, 201);
            btnUploadFile.ForeColor = Color.FromArgb(255, 255, 255);
            SelectImage();
            label9.Text = imageName;
            //UploadToGoogleDrive("image/jpeg", imageName);
        }
        private void UploadToGoogleDrive(string mimeType, string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("No file or image selected.");
                return;
            }

            // Chọn folderId dựa trên mimeType
            string folderId = mimeType == "image/jpeg"
                ? "1EdDf2u_LCZEPwcTXIVhtzuBacK9J3MYI" // imageFolderId
                : "178rcweIiY0X6MZbkJDC6NZdLqsE6oH_C"; // fileFolderId

            // Tạo metadata cho tệp
            var fileMetadata = new Google.Apis.Drive.v3.Data.File
            {
                Name = Path.GetFileName(fileName),
                Parents = new[] { folderId }
            };

            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var request = driveService.Files.Create(fileMetadata, stream, mimeType);
                request.Fields = "id";
                var result = request.Upload();

                if (result.Status == Google.Apis.Upload.UploadStatus.Completed)
                {
                    MessageBox.Show($"Uploaded successfully! File ID: {request.ResponseBody.Id}");
                }
                else
                {
                    MessageBox.Show($"Upload failed: {result.Exception?.Message}");
                }
            }
        }
        private void SelectImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageName = openFileDialog.FileName;
                }
            }
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTaskName.Text) || string.IsNullOrWhiteSpace(customComboBox1.Texts) ||
            string.IsNullOrWhiteSpace(cTBDescribeTask.Text) || dtpTimeCompleted.Value == null || dtpTimeCompleted.Value <= DateTime.Now)
            {
                showMessage("Vui lòng nhập đủ thông tin!", "error");
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if validation fails
            }
            string testIdLichSu = taskBLL.TaoLichSuId();
            var task = new TaskInfo()
            {
                IdLoaiCongViec = taskBLL.LayIdLoaiCongViecTuTen(customComboBox1.Texts),
                IdBoPhanGiaoViec =this.idBoPhanKhiDangNhap,
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
            LayQuanLiHoacNhanSuTheoBoPhanDuocChon();
        }
        private void LayQuanLiHoacNhanSuTheoBoPhanDuocChon()
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
                LayQuanLiHoacNhanSuTheoBoPhanDuocChon();  // Refresh managers after removing a department
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
