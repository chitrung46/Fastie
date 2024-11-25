﻿using Google.Apis.Auth.OAuth2;
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
        private string idTaiKhoanNguoiDung;
        private string idBoPhanNguoiDung;
        DepartmentBLL departmentBLL = new DepartmentBLL();
        private string fileName;
        private string imageName;
        private string loaiGiaoViec;
        private string idCongViecGoc;
        private bool result;
        public DetailAssignTaskForm(string loaiGiaoViec, string idTaiKhoan, string idBoPhan)
        {
            InitializeGoogleDriveService();
            InitializeComponent();
            this.idTaiKhoanNguoiDung = idTaiKhoan;
            this.idBoPhanNguoiDung = idBoPhan;
            this.loaiGiaoViec = loaiGiaoViec;
            //LoadTaskTypeComboBox();
            LoadDepartmentComboBox();
            dtpTimeCompleted.Format = DateTimePickerFormat.Custom;
            dtpTimeCompleted.CustomFormat = "dd/MM/yyyy HH:mm";
        }
        public DetailAssignTaskForm(string loaiGiaoViec, string idCongViecGoc, string idTaiKhoan, string idBoPhan)
        {
            InitializeGoogleDriveService();
            InitializeComponent();
            this.idCongViecGoc = idCongViecGoc;
            this.idTaiKhoanNguoiDung = idTaiKhoan;
            this.idBoPhanNguoiDung = idBoPhan;
            this.loaiGiaoViec = loaiGiaoViec;
            //LoadTaskTypeComboBox();
            LoadDepartmentComboBox();
            dtpTimeCompleted.Format = DateTimePickerFormat.Custom;
            dtpTimeCompleted.CustomFormat = "dd/MM/yyyy HH:mm";
        }
        public DetailAssignTaskForm(string idTaiKhoan, string idBoPhan)
        {
            InitializeGoogleDriveService();
            InitializeComponent();
            this.idTaiKhoanNguoiDung = idTaiKhoan;
            this.idBoPhanNguoiDung = idBoPhan;
            LoadTaskTypeComboBox();
            LoadDepartmentComboBox();
            dtpTimeCompleted.Format = DateTimePickerFormat.Custom;
            dtpTimeCompleted.CustomFormat = "dd/MM/yyyy HH:mm";
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
            cCBLoaiCongViec.DisplayMember = "Ten";  // Hiển thị tên loại công việc
            cCBLoaiCongViec.ValueMember = "Id";     // Giá trị là ID của loại công việc
            cCBLoaiCongViec.SelectedIndex = -1;
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
                    showMessage("Tải file thành công!", "success");
                }
                else
                {
                    showMessage("Tải file thất bại!", "error");
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
            
            if (string.IsNullOrWhiteSpace(txbTaskName.Text) || string.IsNullOrWhiteSpace(cCBLoaiCongViec.Texts) ||
            string.IsNullOrWhiteSpace(cTBDescribeTask.Text) || dtpTimeCompleted.Value == null || dtpTimeCompleted.Value <= DateTime.Now)
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
                if (loaiGiaoViec == "Giao việc")
                {
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
                        DanhSachTaiLieu = ""
                    };
                    result = taskBLL.GiaoViec(loaiGiaoViec, thongTinGiaoViec);
                }
                if (loaiGiaoViec == "Giao việc phát sinh")
                {                    
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
                        IdCongViecGoc = this.idCongViecGoc,
                        DanhSachTaiLieu = ""
                    };
                    result = taskBLL.GiaoViec(loaiGiaoViec, thongTinGiaoViec);
                                     
                }

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
            LayQuanLiHoacNhanSuTheoBoPhanDuocChon();
        }
        private void LayQuanLiHoacNhanSuTheoBoPhanDuocChon()
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

            // Add selected recipient to dgvRecipients
            dgvTaiKhoanNhanViec.Rows.Add(selectedRecipient.Id, selectedRecipient.Ten);
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            if (dgvBoPhanNhanViec.SelectedRows.Count > 0)
            {
                dgvBoPhanNhanViec.Rows.RemoveAt(dgvBoPhanNhanViec.SelectedRows[0].Index);
                LayQuanLiHoacNhanSuTheoBoPhanDuocChon();  // Refresh managers after removing a department
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailAssignTaskForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAdd;
        }
    }
}
