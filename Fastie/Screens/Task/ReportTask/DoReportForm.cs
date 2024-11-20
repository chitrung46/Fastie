using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Fastie.Components.Toastify;
using Fastie.Components.LayoutTask;
using DTO;
using BLL;
using static System.Net.Mime.MediaTypeNames;

namespace Fastie.Screens.Task.ReportTask
{
    public partial class DoReportForm : Form
    {
        private ReportTaskForm reportTaskForm;
        TaskBLL taskBLL = new TaskBLL();
        private string taskId;
        private DriveService driveService;
        private string fileName;
        private string fileUrl;
        private string imageName;
        private string imageUrl;
        private string duongDanFile; // Lưu link Google Drive của file
        private string duongDanAnh;
        private string idLichSuCongViec;
        public DoReportForm(ReportTaskForm reportTaskForm, string taskId)
        {
            InitializeComponent();
            InitializeGoogleDriveService();
            this.reportTaskForm = reportTaskForm;
            this.taskId = taskId;
        }
        private void InitializeGoogleDriveService()
        {
            string apiKey = "AIzaSyCHVUVNsmnAkuyVb6dStMTRd0nF9Q2uGdI"; // Thay thế bằng API Key thực của bạn.

            driveService = new DriveService(new BaseClientService.Initializer
            {
                ApiKey = apiKey,
                ApplicationName = "FileAndImageUploader"
            });

            MessageBox.Show("Google Drive service initialized successfully with API Key!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            btnUploadFile.ForeColor = Color.FromArgb(59, 171, 201);
            btnUploadImage.ForeColor = Color.FromArgb(255, 255, 255);
            SelectFile();
            lblFileName.Text = fileName;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            btnUploadImage.ForeColor = Color.FromArgb(59, 171, 201);
            btnUploadFile.ForeColor = Color.FromArgb(255, 255, 255);
            SelectImage();
            lblImageName.Text = imageName;
        }
        private void SelectFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt;*.csv|Word Documents|*.doc;*.docx|Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileUrl = openFileDialog.FileName;
                    fileName = Path.GetFileName(openFileDialog.FileName);
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
                    imageUrl = openFileDialog.FileName;
                    imageName = Path.GetFileName(openFileDialog.FileName);
                }
            }
        }
        private void UploadToGoogleDrive(string mimeType, string fileName, bool isImage)
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
                request.Fields = "id, webViewLink";
                var result = request.Upload();

                if (result.Status == Google.Apis.Upload.UploadStatus.Completed)
                {
                    // Tạo link Google Drive
                    string fileId = request.ResponseBody.Id;
                    string fileLink = $"https://drive.google.com/file/d/{fileId}/view";

                    // Lưu link vào thuộc tính tương ứng
                    if (isImage)
                    {
                        duongDanAnh = fileLink;
                        showMessage("Upload ảnh thành công!", "success");
                    }
                    else
                    {
                        duongDanFile = fileLink;
                        showMessage("Upload file thành công!", "success");
                    }
                }
                else
                {
                    showMessage("Upload thất bại!", "error");
                }
            }
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReportContent.Text))
            {
                showMessage("Vui lòng nhập đủ thông tin!", "error");
                //MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!chkCompleteTask.Checked)
            {
                idLichSuCongViec = taskBLL.BaoCaoDangTienHanhCongViec(taskId, reportTaskForm.taskForm.IdTaiKhoan, txtReportContent.Text.ToString());
            }
            else 
            {
                idLichSuCongViec = taskBLL.BaoCaoHoanThanhCongViec(taskId, reportTaskForm.taskForm.IdTaiKhoan, txtReportContent.Text.ToString());
            }
            if (!string.IsNullOrEmpty(fileUrl))
            {
                UploadToGoogleDrive("application/octet-stream", fileUrl, false);
                var baoCao = new BaoCao()
                {
                    Ten = fileName,
                    Loai = "Tài liệu",
                    DuongDan = duongDanFile,
                    IdLichSuCongViec = idLichSuCongViec
                };
                taskBLL.ThemTaiLieu(baoCao);
            }
            if (!string.IsNullOrEmpty(imageUrl))
            {
                // Gửi ảnh lên Google Drive
                UploadToGoogleDrive("image/jpeg", imageUrl, true);
                var baoCao = new BaoCao()
                {
                    Ten = imageName,
                    Loai = "Hình ảnh",
                    DuongDan = duongDanAnh,
                    IdLichSuCongViec = idLichSuCongViec
                };
                taskBLL.ThemHinhAnh(baoCao);
            }
            reportTaskForm.LoadDataTaskTable();
            this.Close();
        }
    }
}
