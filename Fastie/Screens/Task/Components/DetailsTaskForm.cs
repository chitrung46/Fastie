using Fastie.Components.LayoutRole;
using Fastie.Components.LayoutTask;
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
using Fastie.Screens.Task.Components;
using System.IO;
using System.Net.Http;
using Fastie.Screens.Task.ReportTask;

namespace Fastie.Screens.Task
{
    public partial class DetailsTaskForm : Form
    {
        private TaskForm taskForm;
        private ReportTaskForm reportTaskForm;
        private LayoutGetTaskForm layoutGetTaskForm;
        private LayoutTaskForm layoutTaskForm;
        private LayoutAssignTaskForm layoutAssignTaskForm;
        private TaskBLL taskBLL = new TaskBLL();
        private string idTaiKhoan;
        private string idTask;
        private string currentTaskType;
        private TaskInfo taskInfo;
        private bool congViecPhatSinh;
        private bool congViecChuDong;
        private string idCongViecGoc;
        private string duongDanHinhAnh;
        private string duongDanTaiLieu;
        public DetailsTaskForm(TaskForm taskForm, string idTask, string currentTaskType)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.idTask = idTask;
            this.idTaiKhoan = taskForm.IdTaiKhoan;
            this.currentTaskType = currentTaskType;
            //KiemTraCongViecChuDongVaPhatSinh(idTask);
            LoadTaskDetails();
            congViecChuDong = taskBLL.KiemTraCongViecChuDong(idTask);
            congViecPhatSinh = taskBLL.KiemTraCongViecPhatSinh(idTask, out idCongViecGoc);
            btnOriginalTask.Visible = congViecPhatSinh;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnAdjustmentTask.Visible = true;

            if (!congViecChuDong)
            {
                label4.Visible = false;
                customPanel6.Visible = false;
            }


        }

        public DetailsTaskForm(TaskForm taskForm, string idTask)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.idTask = idTask;
            this.idTaiKhoan = taskForm.IdTaiKhoan;
            LoadTaskDetails();
            congViecChuDong = taskBLL.KiemTraCongViecChuDong(idTask);
            congViecPhatSinh = taskBLL.KiemTraCongViecPhatSinh(idTask, out idCongViecGoc);
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnAdjustmentTask.Visible = true;
            btnOriginalTask.Visible = congViecPhatSinh;
            
            if (!congViecChuDong)
            {
                label4.Visible = false;
                customPanel6.Visible = false;
            }
            
        }
        public DetailsTaskForm(ReportTaskForm reportTaskForm, string idTask)
        {
            InitializeComponent();
            this.reportTaskForm = reportTaskForm;
            this.idTask = idTask;
            this.idTaiKhoan = reportTaskForm.taskForm.IdTaiKhoan;
            LoadTaskDetails();
            congViecChuDong = taskBLL.KiemTraCongViecChuDong(idTask);
            congViecPhatSinh = taskBLL.KiemTraCongViecPhatSinh(idTask, out idCongViecGoc);
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnAdjustmentTask.Visible = true;
            btnOriginalTask.Visible = congViecPhatSinh;

            if (!congViecChuDong)
            {
                label4.Visible = false;
                customPanel6.Visible = false;
            }

        }
        public DetailsTaskForm(TaskForm taskForm, LayoutGetTaskForm layoutGetTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutGetTaskForm = layoutGetTaskForm;
            this.idTaiKhoan = taskForm.IdTaiKhoan;

            LoadTaskDetails();
            congViecChuDong = taskBLL.KiemTraCongViecChuDong(idTask);
            congViecPhatSinh = taskBLL.KiemTraCongViecPhatSinh(idTask, out idCongViecGoc);
            btnOriginalTask.Visible = congViecPhatSinh;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnAdjustmentTask.Visible = true;

            if (!congViecChuDong)
            {
                label4.Visible = false;
                customPanel6.Visible = false;
            }
        }
        public DetailsTaskForm(TaskForm taskForm, LayoutTaskForm layoutTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutTaskForm = layoutTaskForm;
            this.idTaiKhoan = taskForm.IdTaiKhoan;
            LoadTaskDetails();
        }
        public DetailsTaskForm(TaskForm taskForm, LayoutAssignTaskForm layoutAssignTaskForm)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.layoutAssignTaskForm = layoutAssignTaskForm;
            this.idTask = layoutAssignTaskForm.IdTask;
            this.idTaiKhoan = taskForm.IdTaiKhoan;
            
            LoadTaskDetails();
            congViecChuDong = taskBLL.KiemTraCongViecChuDong(idTask);
            congViecPhatSinh = taskBLL.KiemTraCongViecPhatSinh(idTask, out idCongViecGoc);
            btnDelete.Visible = true;
            btnEdit.Visible = true;
            btnAdjustmentTask.Visible = false;
            btnOriginalTask.Visible = congViecPhatSinh;

            if (!congViecChuDong)
            {
                label4.Visible = false;
                customPanel6.Visible = false;
            }
        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            BackForm();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            BackForm();
        }

        private void BackForm()
        {
            switch (taskForm.FormCurrent)
            {
                case "AcceptTaskForm":
                    var acceptTaskForm = new AcceptTaskForm(taskForm);
                    taskForm.AddFormInMainLayout(acceptTaskForm);
                    if (currentTaskType == "Việc chủ động")
                    {
                        acceptTaskForm.loadDataAcceptTask("Việc chủ động");
                        acceptTaskForm.BtnStateTask("Việc chủ động");
                    }
                    else if (currentTaskType == "Việc được giao")
                    {
                        acceptTaskForm.loadDataAcceptTask("Việc được giao");
                        acceptTaskForm.BtnStateTask("Việc được giao");
                    }
                    else
                    {
                        MessageBox.Show("Không xác định được loại công việc.", "Lỗi");
                    }
                    break;

                case "TaskTableForm":
                    TaskTableForm taskTableForm = new TaskTableForm(taskForm);
                    taskForm.AddFormInMainLayout(taskTableForm);
                    break;

                case "AssignTaskForm":
                    AssignTaskForm assignTaskForm = new AssignTaskForm(taskForm);
                    taskForm.AddFormInMainLayout(assignTaskForm);
                    break;
                case "ReportTaskForm":
                    ReportTaskForm reportTaskForm = new ReportTaskForm(taskForm);
                    taskForm.AddFormInMainLayout(reportTaskForm);
                    break;
            }
        }
        private void KiemTraCongViecChuDongVaPhatSinh (string idTask)
        {
            congViecChuDong = taskBLL.KiemTraCongViecChuDong(idTask);
            congViecPhatSinh = taskBLL.KiemTraCongViecPhatSinh(idTask, out idCongViecGoc);
            
        }


        private void addFormInPanelReport(Form userControl)
        {
            pnlReport.Controls.Clear();
            userControl.TopLevel = false;
            pnlReport.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        private void LoadTaskDetails()
        {
            // Ghi log idTask ra console
            //MessageBox.Show($"ID công việc: {idTask}");

            // Gọi phương thức LayChiTietCongViec từ TaskBLL để lấy thông tin chi tiết công việc
            TaskInfo task = taskBLL.LayChiTietCongViec(idTask);

            if (task != null)
            {
                lblIdTask.Text = task.Id;
                lblTaskNamee.Text = task.Ten;
                lblTypeJob.Text = task.TenLoaiCongViec;
                lblDescribeTask.Text = task.MoTa;
                dtpTimeCompleted.Text = task.ThoiHanHoanThanh.HasValue ? task.ThoiHanHoanThanh.Value.ToString("dd/MM/yyyy") : "N/A";
                lblDepartment.Text = task.TenBoPhan;
                lblPersonnel.Text = task.TenNhanSuNhanViec;
                lblNumber.Text = task.SoLuongNhanSuChuDong ?? "0";
                label10.Text = task.TenHinhAnh;
                lblFileName.Text = task.TenTaiLieu;
                duongDanHinhAnh = task.DuongDanHinhAnh;
                duongDanTaiLieu = task.DuongDanTaiLieu;
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết công việc.", "Lỗi");
            }
        }


        private void DetailsTaskForm_Load(object sender, EventArgs e)
        {
            //LoadTaskDetails();

            switch (taskForm.FormCurrent)
            {

                case "TaskTableForm":
                    NearlyReportForm nearlyReportTaskTableForm = new NearlyReportForm(taskForm, idTask);
                    addFormInPanelReport(nearlyReportTaskTableForm);
                    break;
                case "AcceptTaskForm":
                    LoadTaskDetails();
                    break;
                case "AssignTaskForm":
                    NearlyReportForm nearlyReportAssignTaskForm = new NearlyReportForm(taskForm, idTask);
                    addFormInPanelReport(nearlyReportAssignTaskForm);
                    break;
            }
        }


        private void flowLayoutPanelReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TaskInfo task = taskBLL.LayChiTietCongViec(idTask);

            //if (task != null)
            //{
            //    lblIdTask.Text = task.Id;
            //    lblTaskNamee.Text = task.Ten;
            //    lblTypeJob.Text = task.TenLoaiCongViec;
            //    lblDescribeTask.Text = task.MoTa;
            //    dtpTimeCompleted.Text = task.ThoiHanHoanThanh.HasValue ? task.ThoiHanHoanThanh.Value.ToString("dd/MM/yyyy") : "N/A";
            //    lblDepartment.Text = task.TenBoPhan;
            //    lblPersonnel.Text = task.TenNhanSuNhanViec;
            //    lblNumber.Text = task.SoLuongNhanSuChuDong ?? "0";
            //    label10.Text = task.TenHinhAnh;
            //    lblFileName.Text = task.TenTaiLieu;
            //    duongDanHinhAnh = task.DuongDanHinhAnh;
            //    duongDanTaiLieu = task.DuongDanTaiLieu;
            //}
            if (congViecChuDong)
            {
                DetailAssignPositiveTaskForm detailAssignPositiveTaskForm = new DetailAssignPositiveTaskForm(task, idTask, "Giao việc chủ động", taskForm.IdTaiKhoan, taskForm.IdBoPhan);
                detailAssignPositiveTaskForm.Show();
                duongDanHinhAnh = detailAssignPositiveTaskForm.DuongDanAnh;
                duongDanTaiLieu = detailAssignPositiveTaskForm.DuongDanFile;
            }
            else if (congViecPhatSinh)
            {
                DetailAssignTaskForm detailAssignTaskForm = new DetailAssignTaskForm(task, idTask, "Giao việc phát sinh", taskForm.IdTaiKhoan, taskForm.IdBoPhan);
                detailAssignTaskForm.Show();
                duongDanHinhAnh = detailAssignTaskForm.DuongDanAnh;
                duongDanTaiLieu = detailAssignTaskForm.DuongDanFile;
            }
            else
            {
                DetailAssignTaskForm detailAssignTaskForm = new DetailAssignTaskForm(task, idTask, "Giao việc",  taskForm.IdTaiKhoan, taskForm.IdBoPhan);
                detailAssignTaskForm.Show();
                duongDanHinhAnh = detailAssignTaskForm.DuongDanAnh;
                duongDanTaiLieu = detailAssignTaskForm.DuongDanFile;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            congViecPhatSinh = taskBLL.KiemTraCongViecPhatSinh(idTask, out idCongViecGoc);
            if (!congViecPhatSinh)
            {
                string[] information = { "Bạn có chắc chắn xóa công việc này?", "Bạn sẽ không thể thực hiện các chức năng hệ thống", "Xóa việc" };

                LayoutConfirmForm layoutConfirmForm = new LayoutConfirmForm(this, idTask);
                layoutConfirmForm.Title = information[0];
                layoutConfirmForm.Content = information[1];
                layoutConfirmForm.btnConfirmText = information[2];
                layoutConfirmForm.Show();
            }
            else
            {
                string[] information = { "Bạn có chắc chắn xóa công việc này?", "Bạn sẽ không thể thực hiện các chức năng hệ thống", "Xóa việc phát sinh" };

                LayoutConfirmForm layoutConfirmForm = new LayoutConfirmForm(this, idTask);
                layoutConfirmForm.Title = information[0];
                layoutConfirmForm.Content = information[1];
                layoutConfirmForm.btnConfirmText = information[2];
                layoutConfirmForm.Show();
            }
        }

        private void btnAdjustmentTask_Click(object sender, EventArgs e)
        {
            ReasonAdjustmentForm reasonAdjustmentForm = new ReasonAdjustmentForm(this.idTaiKhoan, this.idTask);
            reasonAdjustmentForm.Show();
        }

        private void btnOriginalTask_Click(object sender, EventArgs e)
        {
            if(congViecPhatSinh)
            {
                DetailsTaskForm detailsTaskForm = new DetailsTaskForm(taskForm, idCongViecGoc);
                detailsTaskForm.FormBorderStyle = FormBorderStyle.Sizable;
                detailsTaskForm.lblBack.Visible = false;
                detailsTaskForm.pictureBack.Visible = false;
                detailsTaskForm.Show();
            }
            
        }
        private string ChuyenLinkSangUC(string googleDriveLink)
        {
            try
            {
                // Tìm vị trí "/d/" và "/view"
                int startIndex = googleDriveLink.IndexOf("/d/") + 3; // Bỏ qua "/d/"
                int endIndex = googleDriveLink.IndexOf("/view");

                // Lấy FILE_ID từ link
                if (startIndex > 0 && endIndex > startIndex)
                {
                    string fileId = googleDriveLink.Substring(startIndex, endIndex - startIndex);

                    // Trả về link tải trực tiếp
                    return $"https://drive.google.com/uc?id={fileId}";
                }
                else
                {
                    throw new FormatException("Liên kết không đúng định dạng Google Drive.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và trả về thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi chuyển đổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        private async void customButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(duongDanHinhAnh))
            {
                return;
            }
            // Chuyển đổi link sang dạng tải trực tiếp
            //string linkGoc = duongDanHinhAnh;

            // Convert the link to a direct download link
            string link = ChuyenLinkSangUC(duongDanHinhAnh);

            if (!string.IsNullOrEmpty(link))
            {
                // Get local Pictures folder path
                string picturesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(link);

                        if (response.IsSuccessStatusCode)
                        {
                            // Check if the response is an image
                            string contentType = response.Content.Headers.ContentType.MediaType;

                            if (contentType.StartsWith("image"))
                            {
                                byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

                                // Generate a unique file name with timestamp
                                string extension = contentType.Split('/')[1]; // e.g., "jpeg", "png"
                                string uniqueFileName = $"DownloadedImage_{DateTime.Now:yyyyMMdd_HHmmss}.{extension}";
                                string localPath = Path.Combine(picturesFolder, uniqueFileName);

                                // Save the image to local path
                                File.WriteAllBytes(localPath, fileBytes);

                                MessageBox.Show($"Image downloaded successfully: {localPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                System.Diagnostics.Process.Start("explorer.exe", picturesFolder);
                            }
                            else
                            {
                                MessageBox.Show("The URL does not point to an image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to download the file. Please check the URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            
        }
        private string ChuyenLinkTaiLieuSangUC(string googleDriveLink)
        {
            try
            {
                int startIndex = googleDriveLink.IndexOf("/d/") + 3;
                int endIndex = googleDriveLink.IndexOf("/view");

                if (startIndex > 0 && endIndex > startIndex)
                {
                    string fileId = googleDriveLink.Substring(startIndex, endIndex - startIndex);
                    return $"https://drive.google.com/uc?id={fileId}&export=download";
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi chuyển đổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private async void btnUploadFile_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(duongDanTaiLieu))
            {
                return;
            }
            string link = ChuyenLinkTaiLieuSangUC(duongDanTaiLieu);
            if (string.IsNullOrEmpty(link))
            {
                //MessageBox.Show("Link không được để trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(link);

                    if (response.IsSuccessStatusCode)
                    {
                        string contentType = response.Content.Headers.ContentType.MediaType;

                        // Kiểm tra MIME type, file cần là text/plain
                        if (contentType.Contains("text") || contentType.Contains("octet-stream"))
                        {
                            byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

                            // Tên file lưu trữ
                            string downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            string uniqueFileName = $"DownloadedFile_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                            string localPath = Path.Combine(downloadFolder, uniqueFileName);

                            File.WriteAllBytes(localPath, fileBytes);
                            MessageBox.Show($"Tải file thành công: {localPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            System.Diagnostics.Process.Start("explorer.exe", downloadFolder);
                        }
                        else
                        {
                            MessageBox.Show("URL không trỏ tới file hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể tải file. Kiểm tra URL hoặc quyền chia sẻ file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
