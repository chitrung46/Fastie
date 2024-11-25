using BLL.AnalyticsBLL;
using DTO.AnalyticsDTO;
using Fastie.Components.Toastify;
using Fastie.Screens.Analytics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Fastie
{
    public partial class Analytics : Form
    {
        private string currentAccountId;
        private string currentRole;
        private string selectedDepartmentId;
        private string selectedPositionId;
        private string selectedPersonnelId;
        private bool isLoaded = false;

        AnalyticsBLL analyticsBLL = new AnalyticsBLL();

        public Analytics(string accountId)
        {
            InitializeComponent();
            currentAccountId = accountId;
            //string userRole = analyticsBLL.GetRoleByAccountId(currentAccountId);
            currentRole = analyticsBLL.LayChuVuID(currentAccountId); // Get role from stored procedure
            if (currentRole == "Nhân viên")
            {
                cbDepartment.Visible = false;
                cbPosition.Visible = false;
                cbPersonnel.Visible = false;

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
            cbAnalytics.Items.Add(new KeyValuePair<string, string>("pie", "Biểu đồ tròn - thống kê trạng thái"));
            cbAnalytics.Items.Add(new KeyValuePair<string, string>("bar", "Biểu đồ cột - Thống kê hoàn thành"));
            cbAnalytics.Items.Add(new KeyValuePair<string, string>("bar_accept", "Biểu đồ cột - Thông kê nhận việc chủ động, số lần xin điều chỉnh phân công"));
            cbAnalytics.Items.Add(new KeyValuePair<string, string>("pie_task_complete", "Biểu đồ thống kê tỉ lệ hoàn thành công việc - tỉ lệ không hoàn thành"));

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

            Console.WriteLine($"Pie Chart Parameters - AccountId: {currentAccountId}, DepartmentId: {selectedDepartmentId}, PositionId: {selectedPositionId}, PersonnelId: {selectedPersonnelId}, StartDate: {startDate}, EndDate: {endDate}");

            PieChartStatusTaskForm pieChartStatusTaskForm = new PieChartStatusTaskForm(
                currentAccountId,
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
            DateTime startDate = dTPBirthday.Value;
            DateTime endDate = dateTimePicker1.Value;

            // Log input parameters
            Console.WriteLine($"Column Chart Parameters - AccountId: {currentAccountId}, DepartmentId: {selectedDepartmentId}, PositionId: {selectedPositionId}, PersonnelId: {selectedPersonnelId}, StartDate: {startDate}, EndDate: {endDate}");

            ChartCompoundColumnCompleteTaskForm columnChartForm = new ChartCompoundColumnCompleteTaskForm(
                currentAccountId,
                selectedDepartmentId,
                selectedPositionId,
                selectedPersonnelId,
                startDate,
                endDate
            );

            addFormInMainLayout(columnChartForm);
        }
        private void ShowTaskCompletionRateChart()
        {
            if (!isLoaded) return;

            DateTime startDate = dTPBirthday.Value;
            DateTime endDate = dateTimePicker1.Value;

            PieChartTaskCompletionRateForm completionRateChartForm = new PieChartTaskCompletionRateForm(
                currentAccountId,
                selectedDepartmentId,
                selectedPositionId,
                selectedPersonnelId,
                startDate,
                endDate
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
            DateTime startDate = dTPBirthday.Value;
            DateTime endDate = dateTimePicker1.Value;

            ChartCompoundColumnAcceptTaskForm acceptTaskChartForm = new ChartCompoundColumnAcceptTaskForm(
                currentAccountId,
                selectedDepartmentId,
                selectedPositionId,
                selectedPersonnelId,
                startDate,
                endDate
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



        private void cbAnalytics_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;

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






    }
}

