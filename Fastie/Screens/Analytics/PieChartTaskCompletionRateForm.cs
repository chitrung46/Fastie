
using BLL.AnalyticsBLL;
using DTO;
using DTO.AnalyticsDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fastie.Screens.Analytics
{
    public partial class PieChartTaskCompletionRateForm : Form
    {
        private AnalyticsBLL analyticsBLL = new AnalyticsBLL();
        private string accountId;
        private string departmentId;
        private string positionId;
        private string personnelId;
        private DateTime startDate;
        private DateTime endDate;

        public PieChartTaskCompletionRateForm(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            this.accountId = accountId;
            this.departmentId = departmentId;
            this.positionId = positionId;
            this.personnelId = personnelId;
            this.startDate = startDate;
            this.endDate = endDate;

            InitializeColumnChart();
        }

        private void InitializeColumnChart()
{
    try
    {
        // Biến để lưu danh sách tỷ lệ hoàn thành
        List<AnalyticsDTO> data = null;

        if (string.IsNullOrEmpty(departmentId) || departmentId == "Tất cả")
        {
            data = analyticsBLL.ThongKeTyLeHoanThanhTatCaBoPhan(accountId, startDate, endDate);
        }
        else
        {
            decimal tyLeHoanThanh = analyticsBLL.ThongKeTyLeHoanThanh(
                accountId,
                departmentId,
                positionId,
                personnelId,
                startDate,
                endDate
            );

            data = new List<AnalyticsDTO>
            {
                new AnalyticsDTO
                {
                    TenBoPhan = "Tỷ lệ hoàn thành",
                    TyLeHoanThanh = tyLeHoanThanh
                }
            };
        }

        // Kiểm tra nếu không có dữ liệu
        if (data == null || data.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu để hiển thị biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Debug dữ liệu
        foreach (var item in data)
        {
            Console.WriteLine($"Bộ phận: {item.TenBoPhan}, Tỷ lệ hoàn thành: {item.TyLeHoanThanh}");
        }

        // Xóa và làm mới biểu đồ
        chartPieTaskCompletionRate.ChartAreas.Clear();
        chartPieTaskCompletionRate.Series.Clear();
        chartPieTaskCompletionRate.Legends.Clear();

        ChartArea chartArea = new ChartArea("MainArea")
        {
            BackColor = Color.Transparent
        };
        chartArea.AxisX.Title = "Bộ phận";
        chartArea.AxisY.Title = "Tỷ lệ (%)";
        chartArea.AxisY.Interval = 10;
        chartArea.AxisX.Interval = 1; // Hiển thị tất cả nhãn
        chartArea.AxisX.LabelStyle.Angle = -45; // Xoay nhãn
        chartPieTaskCompletionRate.ChartAreas.Add(chartArea);

        Series series = new Series("Tỷ lệ hoàn thành")
        {
            ChartType = SeriesChartType.Column,
            ChartArea = "MainArea",
            IsValueShownAsLabel = true
        };

        foreach (var item in data)
        {
            decimal tyLeHoanThanh = item.TyLeHoanThanh ?? 0; // Xử lý null
            series.Points.AddXY(item.TenBoPhan, tyLeHoanThanh);
        }

        chartPieTaskCompletionRate.Series.Add(series);

        chartPieTaskCompletionRate.Titles.Clear();
        chartPieTaskCompletionRate.Titles.Add(new Title(
            "Tỷ lệ hoàn thành công việc",
            Docking.Top,
            new Font("Arial", 16, FontStyle.Bold),
            Color.Black
        ));

        Legend legend = new Legend("Legend")
        {
            Docking = Docking.Bottom,
            BackColor = Color.Transparent
        };
        chartPieTaskCompletionRate.Legends.Add(legend);
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Lỗi khi hiển thị biểu đồ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}







    }

}