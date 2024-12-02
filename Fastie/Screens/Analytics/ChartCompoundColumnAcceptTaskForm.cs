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
using BLL.AnalyticsBLL;
using DTO.AnalyticsDTO;

namespace Fastie.Screens.Analytics
{
    public partial class ChartCompoundColumnAcceptTaskForm : Form
    {
        private string accountId;
        private string departmentId;
        private string positionId;
        private string personnelId;
        private DateTime startDate;
        private DateTime endDate;

        private AnalyticsBLL analyticsBLL = new AnalyticsBLL();

        public ChartCompoundColumnAcceptTaskForm(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            this.accountId = accountId;
            this.departmentId = departmentId;
            this.positionId = positionId;
            this.personnelId = personnelId;
            this.startDate = startDate;
            this.endDate = endDate;

            InitializeColumnChartAcceptTask();
        }

        private void InitializeColumnChartAcceptTask()
        {
            try
            {
                Console.WriteLine($"[UI Input] accountId: {accountId}, departmentId: {departmentId}, positionId: {positionId}, personnelId: {personnelId}, startDate: {startDate}, endDate: {endDate}");
                List<AnalyticsDTO> data = analyticsBLL.ThongKeNhanViecChuDongVaDieuChinh(accountId, departmentId, positionId, personnelId, startDate, endDate);

                if (data == null || data.Count == 0)
                {
                    Console.WriteLine("[UI Log] No data returned from BLL.");
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var item in data)
                {
                    Console.WriteLine($"[UI Data Row] SoLanNhanViecChuDong: {item.SoLanNhanViecChuDong}, SoLanXinDieuChinh: {item.SoLanXinDieuChinhPhanCong}");
                }

                // Chart rendering logic
                chartAcceptTask.Titles.Clear();
                chartAcceptTask.Titles.Add("Thống kê số lần nhận việc và xin điều chỉnh phân công");

                ChartArea chartArea = new ChartArea("MainArea");
                chartAcceptTask.ChartAreas.Clear();
                chartAcceptTask.ChartAreas.Add(chartArea);

                Series seriesAcceptTask = new Series("Nhận việc chủ động") { ChartType = SeriesChartType.Column };
                Series seriesAdjustRequest = new Series("Xin điều chỉnh") { ChartType = SeriesChartType.Column };

                foreach (var item in data)
                {
                    seriesAcceptTask.Points.AddXY("Nhận việc", item.SoLanNhanViecChuDong);
                    seriesAdjustRequest.Points.AddXY("Xin điều chỉnh", item.SoLanXinDieuChinhPhanCong);
                }

                chartAcceptTask.Series.Clear();
                chartAcceptTask.Series.Add(seriesAcceptTask);
                chartAcceptTask.Series.Add(seriesAdjustRequest);

                chartArea.AxisX.Title = "Trạng thái";
                chartArea.AxisY.Title = "Số lượng";
                chartArea.AxisY.Interval = 1;

                if (chartAcceptTask.Legends.Count == 0)
                {
                    chartAcceptTask.Legends.Add(new Legend("Legend"));
                }

                Console.WriteLine("[UI Log] Chart initialized successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UI Error] {ex.Message}");
                MessageBox.Show($"Lỗi khi hiển thị biểu đồ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
