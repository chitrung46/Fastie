using BLL.PermissionBLL;
using Fastie.Components.LayoutRole;
using Fastie.Components.NoPermissionAccessForm;
using Fastie.Screens.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fastie.Screens.Task.AssignmentAdjustmentTask;
using Fastie.Screens.Task.ReportTask;
using BLL;
using DTO;
using Fastie.Components.Toastify;
using System.Net.Http;

namespace Fastie
{
    public partial class TaskForm: Form
    {
        PermissionBLL permissionBLL = new PermissionBLL();
        TaskBLL taskBLL = new TaskBLL();

        private string thoiGianBaoCao;
        private string idTaiKhoanBaoCao;
        private string idCongViec;
        private string tienDoHoanThanh;
        private string noiDungBaoCao;
        private string urlTaiLieu;
        private string urlHinhAnh;
        private string idLichSuCongViec;

        private string idTaiKhoanNhanViec;
        private string idCongViecNhanViec;

        private string idTaiKhoan;
        private string idChucVu;
        private string idBoPhan;
        private string formCurrent;
        public TaskForm(string idTaiKhoan, string idBoPhan, string idChucVu)
        {
            InitializeComponent();

            this.idTaiKhoan = idTaiKhoan;
            this.idChucVu = idChucVu;
            this.idBoPhan = idBoPhan;

            handleAcceptTask();
            handleReportOnline();

            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0019");
            setStateButton(btnTaskTable);
            if (checkPermission) {
                this.formCurrent = "TaskTableForm";
                TaskTableForm taskTableForm = new TaskTableForm(this);
                addFormInMainLayout(taskTableForm);

            } else {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
        }
 
        public string IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public string IdChucVu { get => idChucVu; set => idChucVu = value; }

        public string IdBoPhan { get => idBoPhan; set => idBoPhan = value; }
        public string FormCurrent { get => formCurrent; set => formCurrent = value; }

        //Check other panel is not click
        private void setStateButton(Button stateButton)
        {
            Button[] button = {btnTaskTable, btnAssignTask, btnAcceptTask, btnReportTask, btnAdjustTask};
            for (int i = 0; i < button.Length; i++)
            {
                if (button[i] != stateButton)
                {
                    button[i].BackColor = Color.FromArgb(55, 55, 55);
                }
            }
            stateButton.BackColor = Color.FromArgb(59, 171, 201);
        }

        //Add form in main layout
        public void AddFormInMainLayout(Form userControl)
        {
            addFormInMainLayout(userControl);
        }
        private void addFormInMainLayout(Form userControl)
        {
            mainLayout.Controls.Clear();
            userControl.TopLevel = false;
            mainLayout.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }
        private void btnTaskTable_Click(object sender, EventArgs e) 
        {
            this.formCurrent = "TaskTableForm";
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0019");
            setStateButton(btnTaskTable);
            if (checkPermission)
            {
                TaskTableForm taskTableForm = new TaskTableForm(this);
                addFormInMainLayout(taskTableForm);
            } else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            this.formCurrent = "AssignTaskForm";
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0020");
            setStateButton(btnAssignTask);
            if (checkPermission)
            {
                AssignTaskForm assignTaskForm = new AssignTaskForm(this);
                addFormInMainLayout(assignTaskForm);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }

        }

        private void btnAcceptTask_Click(object sender, EventArgs e)
        {
            this.formCurrent = "AcceptTaskForm";
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0021");
            setStateButton(btnAcceptTask);
            if (checkPermission)
            {
                AcceptTaskForm acceptTaskForm = new AcceptTaskForm(this);
                addFormInMainLayout(acceptTaskForm);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
;
            
        }

        private void btnReportTask_Click(object sender, EventArgs e)
        {
            bool checkPermission = permissionBLL.checkPermission(this.idTaiKhoan, "Q0022");
            setStateButton(btnReportTask);
            if (checkPermission)
            {
                ReportTaskForm reportTaskForm = new ReportTaskForm(this);
                addFormInMainLayout(reportTaskForm);
            }
            else
            {
                NoPermissionAccessForm noPermissionAccessForm = new NoPermissionAccessForm();
                addFormInMainLayout(noPermissionAccessForm);
            }
            
        }

        private void btnAdjustTask_Click(object sender, EventArgs e)
        {
            AssignmentAdjustmentTaskForm assignmentAdjustmentTaskForm = new AssignmentAdjustmentTaskForm(this);
            addFormInMainLayout(assignmentAdjustmentTaskForm);
            setStateButton(btnAdjustTask);
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
        }

        //load report task online
        private async void handleReportOnline()
        {
            try
            {
                // API Key của bạn
                string spreadsheetId = "1d0GYgmQ2-GFwFIF40c5BkaHUMMl2AMe5RK-5CNn3uuo";  // Thay bằng Spreadsheet ID
                string range = "'Answer_1'!A2:G";  // Dải dữ liệu cần đọc
                var values = await handleDataSheet(spreadsheetId, range);

                if (values == null)
                {
                    Console.WriteLine("No data available.");
                    return;
                }

                for (int i = 0; i < values.Count; i++)
                {
                    this.thoiGianBaoCao = values[i][0]?.ToString();
                    this.idTaiKhoanBaoCao = values[i][1]?.ToString();
                    this.idCongViec = values[i][2]?.ToString();
                    this.tienDoHoanThanh = values[i][3]?.ToString();
                    this.noiDungBaoCao = values[i][4]?.ToString();
                    this.urlTaiLieu = values[i][5]?.ToString();
                    this.urlHinhAnh = values[i][6]?.ToString();
                    reportOnline();
                }
            }
            catch (Exception ex)
            {
                showMessage($"Lỗi kết nối mạng {ex.Message}", "error");
            }
        }

        private async void handleAcceptTask()
        {

           // API Key của bạn
            string spreadsheetId = "15iJdUaTMNOW6dMI2CZ9h9qKPQLQzOfK6j-BxZaaxdyw";  // Thay bằng Spreadsheet ID
            string range = "'Answer_1'!A2:C";  // Dải dữ liệu cần đọc
            var values = await handleDataSheet(spreadsheetId, range);

            if (values == null)
            {
                Console.WriteLine("Không có dữ liệu nhận việc.");
                return;
            }

            for (int i = 0; i < values.Count; i++)
            {
                this.idTaiKhoanNhanViec = values[i][1]?.ToString();
                this.idCongViecNhanViec = values[i][2]?.ToString();
                if (!string.IsNullOrEmpty(this.idTaiKhoanNhanViec) || !string.IsNullOrEmpty(this.idCongViecNhanViec))
                {
                    taskBLL.NhanCongViecOnline(this.idTaiKhoanNhanViec, this.idCongViecNhanViec, "Nhận việc");
                } else
                {
                    Console.WriteLine("Không có dữ liệu nhận việc.");
                }
            }
        }

        private async Task<IList<IList<Object>>> handleDataSheet(string spreadsheetId, string range)
        {
            try {
                string apiKey = "AIzaSyCHVUVNsmnAkuyVb6dStMTRd0nF9Q2uGdI";

                // URL để truy cập dữ liệu từ Google Sheets
                string url = $"https://sheets.googleapis.com/v4/spreadsheets/{spreadsheetId}/values/{range}?key={apiKey}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        // Phân tích dữ liệu JSON trả về
                        var result = Newtonsoft.Json.JsonConvert.DeserializeObject<GoogleSheetResponse>(json);

                        if (result != null && result.Values != null)
                        {
                            return result.Values;
                        }
                    }
                    else
                    {
                        showMessage("Vui lòng kiểm tra kết nối mạng", "error");
                    }
                }

            }
            catch (Exception ex)
            {
                showMessage("Vui lòng kiểm tra kết nối mạng", "error");
            }
            return null;
        }

        public class GoogleSheetResponse
        {
            public IList<IList<object>> Values { get; set; }
        }

        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }

        private void reportOnline()
        {
            if (this.tienDoHoanThanh == "Đang thực hiện")
            {
                idLichSuCongViec = taskBLL.BaoCaoDangTienHanhCongViecOnline(this.idCongViec, this.idTaiKhoanBaoCao, this.thoiGianBaoCao, this.noiDungBaoCao);
            }
            else
            {
                idLichSuCongViec = taskBLL.BaoCaoHoanThanhCongViecOnline(this.idCongViec, this.idTaiKhoanBaoCao, this.thoiGianBaoCao, this.noiDungBaoCao);
            }
            if (this.urlTaiLieu != null && string.IsNullOrEmpty(this.idLichSuCongViec) == false)
            {
                var baoCao = new BaoCao()
                {
                    Ten = "tai_lieu",
                    Loai = "tài liệu",
                    DuongDan = this.urlTaiLieu,
                    IdLichSuCongViec = this.idLichSuCongViec
                };
                taskBLL.ThemTaiLieu(baoCao);
            }
            if (this.urlTaiLieu != null && string.IsNullOrEmpty(this.idLichSuCongViec) == false)
            {
                var baoCao = new BaoCao()
                {
                    Ten = "hinh_anh",
                    Loai = "hình ảnh",
                    DuongDan = this.urlHinhAnh,
                    IdLichSuCongViec = this.idLichSuCongViec
                };
                taskBLL.ThemHinhAnh(baoCao);
            }
        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {
            handleAcceptTask();
            handleReportOnline();

            TaskTableForm taskTableForm = new TaskTableForm(this);
            AssignTaskForm assignTaskForm = new AssignTaskForm(this);
            AcceptTaskForm acceptTaskForm = new AcceptTaskForm(this);
            ReportTaskForm reportTaskForm = new ReportTaskForm(this);

            reportTaskForm.loadDataReportTask();
            acceptTaskForm.loadDataAcceptTask();
            assignTaskForm.LoadDataAssignTask();
            taskTableForm.LoadTaskTable();

            showMessage("Dữ liệu đã được cập nhật", "success");
        }
    }
}
