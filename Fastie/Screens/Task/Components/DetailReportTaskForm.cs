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
using System.IO;
using System.Net.Http;
using BLL;

namespace Fastie.Screens.Task.Components
{
    public partial class DetailReportTaskForm : Form
    {
        LayoutDetailReportForm layoutDetailReportForm;
        private string duongDanHinhAnh;
        private string duongDanTaiLieu;
        private TaskBLL taskBLL = new TaskBLL();
        public DetailReportTaskForm(LayoutDetailReportForm layoutDetailReportForm)
        {
            InitializeComponent();
            this.layoutDetailReportForm = layoutDetailReportForm;
        }

        private void DetailReportTaskForm_Load(object sender, EventArgs e)
        {
            lblPositionName.Text = layoutDetailReportForm.IdReport;
            lblPositionContent.Text = layoutDetailReportForm.ReportContent;
            label1.Text = layoutDetailReportForm.ReportDate;
            label10.Text = layoutDetailReportForm.ImageName;
            lblFileName.Text = layoutDetailReportForm.FileName;
            duongDanHinhAnh = layoutDetailReportForm.ImageUrl;
            duongDanTaiLieu = layoutDetailReportForm.FileUrl;
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
            if (string.IsNullOrEmpty(duongDanTaiLieu))
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
