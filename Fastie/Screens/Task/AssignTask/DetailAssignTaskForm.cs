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
using System.Reflection;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using System.Windows.Media;
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
        private string fileUrl;
        private string imageName;
        private string imageUrl;
        private string duongDanFile; // Lưu link Google Drive của file
        private string duongDanAnh;
        private string loaiGiaoViec;
        private string idCongViecGoc;
        private bool result;
        private string idCongViec;

        public string DuongDanAnh
        {
            get { return duongDanAnh; }
            set { duongDanAnh = value; }
        }

        // Thuộc tính để truy cập và thay đổi giá trị của duongDanTaiLieu
        public string DuongDanFile
        {
            get { return duongDanFile; }
            set { duongDanFile = value; }
        }
        public DetailAssignTaskForm(string loaiGiaoViec, string idTaiKhoan, string idBoPhan)
        {
            InitializeGoogleDriveService();
            InitializeComponent();
            this.idTaiKhoanNguoiDung = idTaiKhoan;
            this.idBoPhanNguoiDung = idBoPhan;
            this.loaiGiaoViec = loaiGiaoViec;
            //LoadTaskTypeComboBox();
            LoadDepartmentComboBox();
            dtpTimeCompleted.Value = DateTime.Now;
            dtpTimeCompleted.Format = DateTimePickerFormat.Custom;
            dtpTimeCompleted.CustomFormat = "dd/MM/yyyy    HH:mm";
        }


        public DetailAssignTaskForm(TaskInfo taskInfo, string idCongViec, string loaiGiaoViec, string idTaiKhoan, string idBoPhan)
        {
            InitializeGoogleDriveService();
            InitializeComponent();


            // Lưu thông tin từ tham số
            this.idTaiKhoanNguoiDung = idTaiKhoan;
            this.idBoPhanNguoiDung = idBoPhan;
            this.loaiGiaoViec = loaiGiaoViec;
            this.idCongViec = idCongViec;
            LoadDepartmentComboBox();
            // Gán thông tin taskInfo vào các ô hiển thị
            if (taskInfo != null)
            {
                //lblIdTask.Text = taskInfo.Id;
                txbTaskName.Text = taskInfo.Ten;
                cCBLoaiCongViec.Texts = taskInfo.TenLoaiCongViec;
                cTBDescribeTask.Text = taskInfo.MoTa;
                dtpTimeCompleted.Value = taskInfo.ThoiHanHoanThanh.HasValue ? taskInfo.ThoiHanHoanThanh.Value : DateTime.Now;
                //cbxDepartment.Text = taskInfo.TenBoPhan;
                //lblPersonnel.Text = taskInfo.TenNhanSuNhanViec;
                //lblNumber.Text = taskInfo.SoLuongNhanSuChuDong ?? "0";
                duongDanAnh = taskInfo.DuongDanHinhAnh ?? null;
                duongDanFile = taskInfo.DuongDanTaiLieu ?? null;
                lblFileName.Text = taskInfo.TenTaiLieu ?? null;
                label9.Text = taskInfo.TenHinhAnh ?? null;

            }
            RemoveAllClickEvents(btnAdd);
            btnAdd.Click += new EventHandler(capNhatCongViec_Click);
        }
        private void RemoveAllClickEvents(Button button)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(button);
            PropertyInfo pi = button.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(button, null);
            list.RemoveHandler(obj, list[obj]);
        }
        private void capNhatCongViec_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileUrl))
            {
                UploadToGoogleDrive("application/octet-stream", fileUrl, false);

            }
            if (!string.IsNullOrEmpty(imageUrl))
            {
                // Gửi ảnh lên Google Drive
                UploadToGoogleDrive("image/jpeg", imageUrl, true);

            }
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
                    if (idTaiKhoanNhanViec == this.idTaiKhoanNguoiDung)
                    {
                        showMessage("Không thể tự giao việc cho bản thân", "error");
                        return; // Thoát khỏi hàm nếu phát hiện lỗi
                    }
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
                    
                    IdTaiKhoanGiaoViec = this.idTaiKhoanNguoiDung,
                    DanhSachTaiKhoanNhanViec = string.Join(",", danhSachTaiKhoanNhanViec),
                    DanhSachBoPhanNhanViec = string.Join(",", danhSachBoPhanNhanViec),
                    DanhSachHinhAnh = duongDanAnh,
                    DanhSachTaiLieu = duongDanFile,
                    TenHinhAnh = imageName,
                    TenTaiLieu = fileName
                };
                result = taskBLL.CapNhatCongViec(idCongViec, loaiGiaoViec, thongTinGiaoViec);
            }
            if (loaiGiaoViec == "Giao việc phát sinh")
            {
                var thongTinGiaoViec = new ThongTinGiaoViec()
                {
                    Ten = txbTaskName.Text,
                    MoTa = cTBDescribeTask.Text,
                    ThoiHanHoanThanh = dtpTimeCompleted.Value.ToString(),
                    
                    IdTaiKhoanGiaoViec = this.idTaiKhoanNguoiDung,
                    DanhSachTaiKhoanNhanViec = string.Join(",", danhSachTaiKhoanNhanViec),
                    DanhSachBoPhanNhanViec = string.Join(",", danhSachBoPhanNhanViec),
                    DanhSachHinhAnh = duongDanAnh,
                    IdCongViecGoc = this.idCongViecGoc,
                    DanhSachTaiLieu = duongDanFile,
                    TenHinhAnh = imageName,
                    TenTaiLieu = fileName
                };
                result = taskBLL.CapNhatCongViec(idCongViec, loaiGiaoViec, thongTinGiaoViec);

            }
            this.Close();
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
            dtpTimeCompleted.Value = DateTime.Now;
            dtpTimeCompleted.Format = DateTimePickerFormat.Custom;
            dtpTimeCompleted.CustomFormat = "dd/MM/yyyy    HH:mm";
        }
        public DetailAssignTaskForm(string idTaiKhoan, string idBoPhan)
        {
            InitializeGoogleDriveService();
            InitializeComponent();
            this.idTaiKhoanNguoiDung = idTaiKhoan;
            this.idBoPhanNguoiDung = idBoPhan;
            LoadTaskTypeComboBox();
            LoadDepartmentComboBox();
            dtpTimeCompleted.Value = DateTime.Now;
            dtpTimeCompleted.Format = DateTimePickerFormat.Custom;
            dtpTimeCompleted.CustomFormat = "dd/MM/yyyy    HH:mm";
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
                    fileUrl = openFileDialog.FileName;
                    fileName = Path.GetFileName(openFileDialog.FileName);
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


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileUrl))
            {
                UploadToGoogleDrive("application/octet-stream", fileUrl, false);
                
            }
            if (!string.IsNullOrEmpty(imageUrl))
            {
                // Gửi ảnh lên Google Drive
                UploadToGoogleDrive("image/jpeg", imageUrl, true);
                
            }
            if (string.IsNullOrWhiteSpace(txbTaskName.Text) 
                && string.IsNullOrWhiteSpace(cCBLoaiCongViec.Texts)
                && string.IsNullOrWhiteSpace(cTBDescribeTask.Text)
                && (dtpTimeCompleted.Value == null || dtpTimeCompleted.Value <= DateTime.Now))
            {
                showMessage("Vui lòng nhập đủ thông tin!", "error");
                return; // Exit the method if validation fails
            }




            if (string.IsNullOrWhiteSpace(txbTaskName.Text)) 
            {
                showMessage("Vui lòng nhập tên công việc!", "error");
                return; // Exit the method if validation fails
            }

            if (string.IsNullOrWhiteSpace(cCBLoaiCongViec.Texts))
            {
                showMessage("Vui lòng chọn loại công việc!", "error");
                return; // Exit the method if validation fails
            }
            if (string.IsNullOrWhiteSpace(cTBDescribeTask.Text))
            {
                showMessage("Vui lòng nhập mô tả công việc!", "error");
                return; // Exit the method if validation fails
            }
            if (dtpTimeCompleted.Value == null) 
            {
                showMessage("Vui lòng chọn thời hạn hoan thành!", "error");
                return; // Exit the method if validation fails
            }
            if (dtpTimeCompleted.Value <= DateTime.Now)
            {
                showMessage("Chọn thời hạn hoàn thành hợp lệ!", "error");
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
                        if (idTaiKhoanNhanViec == this.idTaiKhoanNguoiDung)
                        {
                            showMessage("Không thể tự giao việc cho bản thân", "error");
                            return; // Thoát khỏi hàm nếu phát hiện lỗi
                        }
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
                        DanhSachHinhAnh = duongDanAnh,
                        DanhSachTaiLieu = duongDanFile,
                        TenHinhAnh = imageName,
                        TenTaiLieu = fileName
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
                        DanhSachHinhAnh = duongDanAnh,
                        IdCongViecGoc = this.idCongViecGoc,
                        DanhSachTaiLieu = duongDanFile,
                        TenHinhAnh = imageName,
                        TenTaiLieu = fileName
                    };
                    result = taskBLL.GiaoViec(loaiGiaoViec, thongTinGiaoViec);
                                     
                }

                if (result)
                {
                    showMessage("Giao việc thành công", "success");
                    sendRequest();
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

        private bool sendRequest()
        {
            try
            {
                // Thông tin email gửi
                string fromEmail = "fastie.n02@gmail.com";
                string fromPassword = "rtpl hzno ottm erol"; // Mật khẩu ứng dụng của email gửi
                string userName = "Đặng Nhật Toàn";
                string assignerName = "Đỗ Thị Kiều Thanh";
                string assignerPhone = "0986746985";
                // Nội dung email xác nhận
                string content = $@"
Kính gửi {userName},

Bạn được giao một nhiệm vụ mới từ đội ngũ Firon. Vui lòng xem thông tin chi tiết bên dưới và thực hiện nhiệm vụ đúng thời hạn được yêu cầu. Nếu có bất kỳ thắc mắc nào, xin vui lòng liên hệ với người giao việc.

Thông tin công việc:
- Ngày giao nhiệm vụ: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}
- Tên công việc: {txbTaskName.Text}
- Mô tả nhiệm vụ: {cTBDescribeTask.Text}
- Hạn hoàn thành: {dtpTimeCompleted.Value.ToString("dd/MM/yyyy")}
- Người giao việc: {assignerName}
- Số điện thoại liên hệ: {assignerPhone}

Chúng tôi mong bạn sẽ hoàn thành nhiệm vụ một cách hiệu quả và đúng tiến độ. Nếu có thêm thông tin cần làm rõ, vui lòng trả lời email này hoặc liên hệ trực tiếp với người giao việc.

Chân thành cảm ơn và chúc bạn hoàn thành tốt nhiệm vụ!

Trân trọng,
Firon
Đội ngũ hỗ trợ quản lý công việc
";


                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage();
                mail.To.Add("nhattoan664t@gmail.com"); // Email người nhận
                mail.From = new MailAddress(fromEmail); // Email người gửi
                mail.Subject = "Xác nhận giao việc - [Đội ngũ Fastie]"; // Tiêu đề email
                mail.Body = content; // Nội dung email

                // Thiết lập cấu hình SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromEmail, fromPassword)
                };

                // Gửi email
                smtp.Send(mail);

                // Trả về true nếu gửi thành công
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi, có thể log thêm thông tin lỗi vào đây
                showMessage(ex.Message, "error");
                return false;
            }
        }
    }
}
