using BLL.AnalyticsBLL;
using DAL;
using DTO.AnalyticsDTO;
using Fastie.Components.Toastify;
using Fastie.Screens.Analytics;
using Microsoft.Office.Interop.Word;
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
using System.Windows.Forms.DataVisualization.Charting;
using Word = Microsoft.Office.Interop.Word;


namespace Fastie
{
    public partial class Analytics : Form
    {
        private string currentAccountId;
        private string currentRole;
        private string selectedDepartmentId;
        private string selectedPositionId;
        private string selectedPersonnelId;
        private KeyValuePair<string, string> selectChartType;
        private bool isLoaded = false;


        AnalyticsBLL analyticsBLL = new AnalyticsBLL();

        public Analytics(string accountId)
        {
            InitializeComponent();
            currentAccountId = accountId;
            btnExportWorđ.Visible = false;
            btnExportPDF.Visible = false;
            //string userRole = analyticsBLL.GetRoleByAccountId(currentAccountId);
            currentRole = analyticsBLL.LayChuVuID(currentAccountId); // Get role from stored procedure
            if (currentRole == "Nhân viên")
            {
                lblDepartment.Visible = false;
                lblPosition.Visible = false;
                lblPersonnel.Visible = false;

                cbDepartment.Visible = false; // Ẩn label Bộ phận
                cbPosition.Visible = false;   // Ẩn label Chức vụ
                cbPersonnel.Visible = false; // Ẩn label Nhân sự
            }
            
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            isLoaded = false;
            TaiBoPhan();
            TaiChucVu("Tất cả");
            TaiNhanSu(null, null);
            LoadChartOptions();
            isLoaded = true;
            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.CustomFormat = "dd/MM/yyyy";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            cbAnalytics_OnSelectedIndexChanged(cbAnalytics, EventArgs.Empty);
        }


        private void LoadChartOptions()
        {
            cbAnalytics.Items.Clear();
            cbAnalytics.Items.Add(new KeyValuePair<string, string>(null, "Chọn"));
            cbAnalytics.Items.Add(new KeyValuePair<string, string>("pie", "Thống kê trạng thái"));
            cbAnalytics.Items.Add(new KeyValuePair<string, string>("bar", "Thống kê hoàn thành"));
            cbAnalytics.Items.Add(new KeyValuePair<string, string>("bar_accept", "Thông kê nhận việc chủ động, số lần xin điều chỉnh phân công"));
            cbAnalytics.Items.Add(new KeyValuePair<string, string>("pie_task_complete", "Thống kê tỉ lệ hoàn thành công việc - tỉ lệ không hoàn thành"));

            cbAnalytics.DisplayMember = "Value";
            cbAnalytics.ValueMember = "Key";
            cbAnalytics.SelectedIndex = 0; // Mặc định là "Click để chọn"
        }



        private void ShowPieChart()
        {
            if (cbDepartment.SelectedItem == null || cbPosition.SelectedItem == null || cbPersonnel.SelectedItem == null || cbAnalytics.SelectedItem == null)
                return;

            if (((KeyValuePair<string, string>)cbDepartment.SelectedItem).Value == "Chọn" ||
                ((KeyValuePair<string, string>)cbPosition.SelectedItem).Value == "Chọn" ||
                ((KeyValuePair<string, string>)cbPersonnel.SelectedItem).Value == "Chọn" ||
                ((KeyValuePair<string, string>)cbAnalytics.SelectedItem).Value == "Chọn")
                return;

            DateTime startDate = dTPBirthday.Value;
            DateTime endDate = dateTimePicker1.Value;

            // Lấy idTaiKhoan dựa trên idNhanSu đã chọn
            string idTaiKhoan = GetTaiKhoanId(selectedPersonnelId);

            Console.WriteLine($"[ShowPieChart] idNhanSu: {selectedPersonnelId}, idTaiKhoan: {idTaiKhoan}");

            if (string.IsNullOrEmpty(idTaiKhoan))
            {
                showMessage("Không tìm thấy tài khoản tương ứng với nhân sự!", "error");
                return;
            }

            PieChartStatusTaskForm pieChartStatusTaskForm = new PieChartStatusTaskForm(
                idTaiKhoan,
                selectedDepartmentId,
                selectedPositionId,
                selectedPersonnelId,
                startDate,
                endDate
            );

            addFormInMainLayout(pieChartStatusTaskForm);
        }


        private void ShowColumnChart()
        {
            if (cbPersonnel.SelectedItem == null || selectedPersonnelId == null)
            {
                showMessage("Vui lòng chọn nhân sự hợp lệ!", "error");
                return;
            }

            string idTaiKhoan = GetTaiKhoanId(selectedPersonnelId);
            Console.WriteLine($"[ShowColumnChart] idNhanSu: {selectedPersonnelId}, idTaiKhoan: {idTaiKhoan}");

            if (string.IsNullOrEmpty(idTaiKhoan))
            {
                showMessage("Không tìm thấy tài khoản tương ứng với nhân sự!", "error");
                return;
            }

            ChartCompoundColumnCompleteTaskForm columnChartForm = new ChartCompoundColumnCompleteTaskForm(
                idTaiKhoan,
                selectedDepartmentId,
                selectedPositionId,
                selectedPersonnelId,
                dTPBirthday.Value,
                dateTimePicker1.Value
            );

            addFormInMainLayout(columnChartForm);
        }

        private void ShowTaskCompletionRateChart()
        {
            if (cbPersonnel.SelectedItem == null || selectedPersonnelId == null)
            {
                showMessage("Vui lòng chọn nhân sự hợp lệ!", "error");
                return;
            }

            string idTaiKhoan = GetTaiKhoanId(selectedPersonnelId);
            Console.WriteLine($"[ShowTaskCompletionRateChart] idNhanSu: {selectedPersonnelId}, idTaiKhoan: {idTaiKhoan}");

            if (string.IsNullOrEmpty(idTaiKhoan))
            {
                showMessage("Không tìm thấy tài khoản tương ứng với nhân sự!", "error");
                return;
            }

            PieChartTaskCompletionRateForm completionRateChartForm = new PieChartTaskCompletionRateForm(
                idTaiKhoan,
                selectedDepartmentId,
                selectedPositionId,
                selectedPersonnelId,
                dTPBirthday.Value,
                dateTimePicker1.Value
            );

            addFormInMainLayout(completionRateChartForm);
        }

        private void addFormInMainLayout(Form userControl)
        {
            PanelChart.Controls.Clear();
            userControl.TopLevel = false;
            PanelChart.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }
        private void TaiBoPhan()
        {
            List<AnalyticsDTO> departments;

            if (currentRole == "Giám đốc")
            {
                departments = analyticsBLL.LayTaCaBoPhan();
            }
            else
            {
                departments = analyticsBLL.LayBoPhanDuaTrenIDTaiKhoan(currentAccountId);
            }

            cbDepartment.Items.Clear();
            cbDepartment.Items.Add(new KeyValuePair<string, string>("Tất cả", "Tất cả"));
            cbDepartment.Items.Add(new KeyValuePair<string, string>(null, "Chọn"));

            foreach (var dept in departments)
            {
                cbDepartment.Items.Add(new KeyValuePair<string, string>(dept.IdBoPhan, dept.TenBoPhan));
            }

            cbDepartment.DisplayMember = "Value";
            cbDepartment.ValueMember = "Key";
            cbDepartment.SelectedIndex = 0;
        }


        private void TaiChucVu(string departmentId)
        {
            List<AnalyticsDTO> positions;

            cbPosition.Enabled = !string.IsNullOrEmpty(departmentId) && departmentId != null;
            if (!cbPosition.Enabled) return;

            if (departmentId == "Chọn")
            {
                cbPosition.Items.Clear();
                cbPosition.Items.Add(new KeyValuePair<string, string>(null, "Chọn"));
                cbPosition.SelectedIndex = 0;
                return;
            }

            positions = analyticsBLL.LayChucVuDuaTrenBoPhan(departmentId);

            cbPosition.Items.Clear();
            cbPosition.Items.Add(new KeyValuePair<string, string>(null, "Chọn"));

            foreach (var pos in positions)
            {
                cbPosition.Items.Add(new KeyValuePair<string, string>(pos.IdChucVu, pos.TenChucVu));
            }

            cbPosition.DisplayMember = "Value";
            cbPosition.ValueMember = "Key";
            cbPosition.SelectedIndex = 0;

        }

        private void TaiNhanSu(string departmentId, string positionId)
        {
            cbPersonnel.Items.Clear();

            if (string.IsNullOrEmpty(positionId) || string.IsNullOrEmpty(departmentId))
            {
                cbPersonnel.SelectedIndex = -1;
                return;
            }

            List<AnalyticsDTO> personnelList = analyticsBLL.LayNhanSuDuaTrenChucVuVaBoPhan(departmentId, positionId);

            if (personnelList == null || personnelList.Count == 0)
            {
                cbPersonnel.SelectedIndex = -1;
                return;
            }

            foreach (var person in personnelList)
            {
                cbPersonnel.Items.Add(new KeyValuePair<string, string>(person.IdNhanSu, person.TenNhanSu));
            }

            cbPersonnel.DisplayMember = "Value";
            cbPersonnel.ValueMember = "Key";

            cbPersonnel.SelectedIndex = -1;
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded || cbDepartment.SelectedItem == null) return;

            var selectedItem = (KeyValuePair<string, string>)cbDepartment.SelectedItem;

            if (selectedItem.Value == "Chọn")
            {
                showMessage("Vui lòng chọn bộ phận hợp lệ!", "error");
                selectedDepartmentId = null;
                cbPosition.SelectedIndex = 0; // Reset lại combobox chức vụ
                cbPersonnel.SelectedIndex = 0; // Reset lại combobox nhân sự
                return;
            }

            selectedDepartmentId = selectedItem.Key;

            try
            {
                TaiChucVu(selectedDepartmentId);
                TaiNhanSu(selectedDepartmentId, null);
                ShowTaskCompletionRateChart();
                showMessage("Đã tải dữ liệu bộ phận thành công!", "success");
            }
            catch (Exception ex)
            {
                showMessage($"Lỗi khi tải dữ liệu bộ phận: {ex.Message}", "error");
            }
        }


        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded || cbPosition.SelectedItem == null) return;

            var selectedItem = (KeyValuePair<string, string>)cbPosition.SelectedItem;

            if (selectedItem.Value == "Chọn")
            {
                showMessage("Vui lòng chọn chức vụ hợp lệ!", "error");
                selectedPositionId = null;
                cbPersonnel.SelectedIndex = 0; // Reset lại nhân sự
                return;
            }

            selectedPositionId = selectedItem.Key;

            try
            {
                TaiNhanSu(selectedDepartmentId, selectedPositionId);
                ShowTaskCompletionRateChart();
                showMessage("Đã tải dữ liệu chức vụ thành công!", "success");
            }
            catch (Exception ex)
            {
                showMessage($"Lỗi khi tải dữ liệu chức vụ: {ex.Message}", "error");
            }
        }



        private void ShowColumnChartAcceptTasks()
        {
            if (cbPersonnel.SelectedItem == null || selectedPersonnelId == null)
            {
                showMessage("Vui lòng chọn nhân sự hợp lệ!", "error");
                return;
            }

            string idTaiKhoan = GetTaiKhoanId(selectedPersonnelId);
            Console.WriteLine($"[ShowColumnChartAcceptTasks] idNhanSu: {selectedPersonnelId}, idTaiKhoan: {idTaiKhoan}");

            if (string.IsNullOrEmpty(idTaiKhoan))
            {
                showMessage("Không tìm thấy tài khoản tương ứng với nhân sự!", "error");
                return;
            }

            ChartCompoundColumnAcceptTaskForm acceptTaskChartForm = new ChartCompoundColumnAcceptTaskForm(
                idTaiKhoan,
                selectedDepartmentId,
                selectedPositionId,
                selectedPersonnelId,
                dTPBirthday.Value,
                dateTimePicker1.Value
            );

            addFormInMainLayout(acceptTaskChartForm);
        }

        private void cbPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded || cbPersonnel.SelectedItem == null) return;

            var selectedItem = (KeyValuePair<string, string>)cbPersonnel.SelectedItem;

            if (selectedItem.Value == "Chọn")
            {
                showMessage("Vui lòng chọn nhân sự hợp lệ!", "error");
                return;
            }

            selectedPersonnelId = selectedItem.Key;

            try
            {
                ShowPieChart();
                showMessage("Đã cập nhật biểu đồ nhân sự thành công!", "success");
            }
            catch (Exception ex)
            {
                showMessage($"Lỗi khi cập nhật biểu đồ nhân sự: {ex.Message}", "error");
            }
        }
        private string GetTaiKhoanId(string idNhanSu)
        {
            string idTaiKhoan = "";
            string query = "SELECT id FROM TaiKhoan WHERE TaiKhoan.idNhanSu = @idNhanSu";

            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@idNhanSu", idNhanSu);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        idTaiKhoan = reader["id"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching idTaiKhoan for idNhanSu {idNhanSu}: {ex.Message}");
                }
                finally
                {
                    con.Close();
                }
            }

            return idTaiKhoan;
        }



        private void cbAnalytics_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;

            selectChartType = (KeyValuePair<string, string>)cbAnalytics.SelectedItem;

            var selectedChartType = (KeyValuePair<string, string>)cbAnalytics.SelectedItem;

            if (selectedChartType.Value == "Chọn")
            {
                return;
            }

            try
            {
                switch (selectedChartType.Key)
                {
                    case "pie":
                        ShowPieChart();
                        break;

                    case "bar":
                        ShowColumnChart();
                        break;

                    case "bar_accept":
                        ShowColumnChartAcceptTasks();
                        break;

                    case "pie_task_complete":
                        ShowTaskCompletionRateChart();
                        break;

                    default:
                        showMessage("Không tìm thấy loại biểu đồ phù hợp!", "error");
                        break;
                }
                showMessage("Đã cập nhật biểu đồ thành công!", "success");
            }
            catch (Exception ex)
            {
                showMessage($"Lỗi khi cập nhật biểu đồ: {ex.Message}", "error");
            }
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        /*
        private void btnExportWorđ_Click(object sender, EventArgs e)
        {
            try { 

            string departmentId = ((KeyValuePair<string, string>)cbDepartment.SelectedItem).Key;
            string positionId = ((KeyValuePair<string, string>)cbPosition.SelectedItem).Key;
            string personnelId = ((KeyValuePair<string, string>)cbPersonnel.SelectedItem).Key;
            string hoTen = cbPersonnel.SelectedItem != null ? cbPersonnel.SelectedItem.ToString() : "Không xác định";
            string chucVu = cbPosition.SelectedItem != null ? cbPosition.SelectedItem.ToString() : "Không xác định"; // Lấy dữ liệu từ Label hoặc TextBox hiển thị chức vụ
            string boPhan = cbDepartment.SelectedItem != null ? cbDepartment.SelectedItem.ToString() : "Không xác định"; // Lấy dữ liệu từ Label hoặc TextBox hiển thị bộ phận

            // Lấy thời gian bắt đầu và kết thúc
            DateTime startDate = dTPBirthday.Value;
            DateTime endDate = dateTimePicker1.Value;

            // Kiểm tra điều kiện đầu vào
            if (string.IsNullOrEmpty(departmentId) || departmentId == "Chọn")
            {
                showMessage("Vui lòng chọn bộ phận hợp lệ!", "error");
                return;
            }

            if (selectChartType.Key == null || selectChartType.Value == "Chọn")
            {
                showMessage("Vui lòng chọn loại biểu đồ hợp lệ trước khi xuất file!", "error");
                return;
            }

            // Lưu biểu đồ dựa trên loại được chọn
            string chartPath = string.Empty;
            switch (selectChartType.Key)
            {
                case "pie":
                    chartPath = SavePieChartImage(); // Phương thức lưu biểu đồ tròn
                    break;

                case "bar":
                    chartPath = SaveColumnChartImage(); // Phương thức lưu biểu đồ cột
                    break;

                default:
                    showMessage("Loại biểu đồ không hợp lệ!", "error");
                    return;
            }

            if (string.IsNullOrEmpty(chartPath))
            {
                showMessage("Không thể lưu biểu đồ. Vui lòng thử lại!", "error");
                return;
            }

            // Lấy id tài khoản dựa trên nhân sự
            string idTaiKhoan = GetTaiKhoanId(personnelId);
            if (string.IsNullOrEmpty(idTaiKhoan))
            {
                showMessage("Không thể lấy tài khoản. Vui lòng kiểm tra thông tin nhân sự!", "error");
                return;
            }

            // Truyền thông tin vào form XuatFile
            XuatFile exportForm = new XuatFile(
                departmentId,
                personnelId,
                idTaiKhoan,
                startDate.ToString("yyyy-MM-dd"),
                endDate.ToString("yyyy-MM-dd"),
                chartPath,
                hoTen,
                chucVu,
                boPhan
            );
            exportForm.Show();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có exception
                showMessage($"Đã xảy ra lỗi khi xuất file: {ex.Message}", "error");
            }
        }
        */
        private void btnExportWorđ_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDepartment.SelectedItem == null)
                {
                    showMessage("Vui lòng chọn bộ phận!", "error");
                    return;
                }
                if (cbPosition.SelectedItem == null)
                {
                    showMessage("Vui lòng chọn chức vụ!", "error");
                    return;
                }
                if (cbPersonnel.SelectedItem == null)
                {
                    showMessage("Vui lòng chọn nhân sự!", "error");
                    return;
                }

                // Lấy dữ liệu từ các ComboBox
                string departmentId = ((KeyValuePair<string, string>)cbDepartment.SelectedItem).Key;
                string positionId = ((KeyValuePair<string, string>)cbPosition.SelectedItem).Key;
                string personnelId = ((KeyValuePair<string, string>)cbPersonnel.SelectedItem).Key;
                string hoTen = cbPersonnel.SelectedItem != null ? cbPersonnel.SelectedItem.ToString() : "Không xác định";
                string chucVu = cbPosition.SelectedItem != null ? cbPosition.SelectedItem.ToString() : "Không xác định";
                string boPhan = cbDepartment.SelectedItem != null ? cbDepartment.SelectedItem.ToString() : "Không xác định";

                // Lấy thời gian bắt đầu và kết thúc
                DateTime startDate = dTPBirthday.Value;
                DateTime endDate = dateTimePicker1.Value;
                if (startDate > endDate)
                {
                    showMessage("Thời gian bắt đầu không được lớn hơn thời gian kết thúc!", "error");
                    return;
                }
                // Kiểm tra điều kiện đầu vào
                if (string.IsNullOrEmpty(departmentId) || departmentId == "Chọn")
                {
                    showMessage("Vui lòng chọn bộ phận hợp lệ!", "error");
                    return;
                }

                if (selectChartType.Key == null || selectChartType.Value == "Chọn")
                {
                    showMessage("Vui lòng chọn loại biểu đồ hợp lệ trước khi xuất file!", "error");
                    return;
                }

                // Lưu biểu đồ dựa trên loại được chọn
                string chartPath = string.Empty;
                switch (selectChartType.Key)
                {
                    case "pie":
                        chartPath = SavePieChartImage(); // Lưu biểu đồ tròn
                        break;

                    case "bar":
                        chartPath = SaveColumnChartImage(); // Lưu biểu đồ cột
                        break;

                    default:
                        showMessage("Loại biểu đồ không hợp lệ!", "error");
                        return;
                }

                if (string.IsNullOrEmpty(chartPath))
                {
                    showMessage("Không thể lưu biểu đồ. Vui lòng thử lại!", "error");
                    return;
                }

                // Lấy id tài khoản dựa trên nhân sự
                string idTaiKhoan = GetTaiKhoanId(personnelId);
                if (string.IsNullOrEmpty(idTaiKhoan))
                {
                    showMessage("Không thể lấy tài khoản. Vui lòng kiểm tra thông tin nhân sự!", "error");
                    return;
                }

                // Truyền thông tin vào form XuatFile
                XuatFile exportForm = new XuatFile(
                    departmentId,
                    personnelId,
                    idTaiKhoan,
                    startDate.ToString(),
                    endDate.ToString(),
                    chartPath,
                    hoTen,
                    chucVu,
                    boPhan
                );
                exportForm.Show();
            }
            catch (NullReferenceException ex)
            {
                // Xử lý lỗi NullReference cụ thể
                showMessage($"Dữ liệu bị thiếu hoặc null: {ex.Message}", "error");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chung
                showMessage($"Đã xảy ra lỗi khi xuất file: {ex.Message}", "error");
            }
            finally
            {
                // Giải phóng tài nguyên (nếu có)
                // Ví dụ: đóng các kết nối, xóa file tạm...
            }
        }

        private string SavePieChartImage()
        {
            string chartPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "pie_chart.png");
            try
            {
                ShowPieChart(); // Hiển thị biểu đồ trước khi lưu
                using (Bitmap bitmap = new Bitmap(PanelChart.Width, PanelChart.Height))
                {
                    PanelChart.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, PanelChart.Width, PanelChart.Height));
                    bitmap.Save(chartPath, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu biểu đồ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return chartPath;
        }

        private string SaveColumnChartImage()
        {
            string chartPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "column_chart.png");
            try
            {
                ShowColumnChart(); // Hiển thị biểu đồ trước khi lưu
                using (Bitmap bitmap = new Bitmap(PanelChart.Width, PanelChart.Height))
                {
                    PanelChart.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, PanelChart.Width, PanelChart.Height));
                    bitmap.Save(chartPath, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu biểu đồ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return chartPath;
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            btnExportWorđ.Visible = true;
            btnExportPDF.Visible = true;
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedItem == null)
            {
                showMessage("Vui lòng chọn bộ phận!", "error");
                return;
            }
            if (cbPosition.SelectedItem == null)
            {
                showMessage("Vui lòng chọn chức vụ!", "error");
                return;
            }
            if (cbPersonnel.SelectedItem == null)
            {
                showMessage("Vui lòng chọn nhân sự!", "error");
                return;
            }
            string filePathWord = "D:\\Bao_cao.docx";
            string filePathPDF = "D:\\Bao_cao.pdf";

            try
            {
                // Gọi hàm xuất file Word (tương tự như `btnExportWord_Click`)
                btnExportWorđ_Click(sender, e);

                // Tạo đối tượng Word Application
                Word.Application wordApp = new Word.Application();
                Word.Document doc = null;

                try
                {
                    // Mở file Word
                    doc = wordApp.Documents.Open(filePathWord);

                    // Chuyển đổi Word sang PDF
                    doc.ExportAsFixedFormat(filePathPDF, Word.WdExportFormat.wdExportFormatPDF);

                    MessageBox.Show($"File PDF đã được tạo thành công tại: {filePathPDF}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi chuyển đổi sang PDF: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Đóng tài liệu và ứng dụng Word
                    if (doc != null)
                        doc.Close();
                    wordApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

