
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
                // Lấy tỷ lệ hoàn thành từ BLL
                decimal tyLeHoanThanh = analyticsBLL.ThongKeTyLeHoanThanh(
                    accountId,
                    departmentId,
                    positionId,
                    personnelId,
                    startDate,
                    endDate
                );

                // Xóa và làm mới biểu đồ
                chartPieTaskCompletionRate.ChartAreas.Clear();
                chartPieTaskCompletionRate.Series.Clear();
                chartPieTaskCompletionRate.Legends.Clear();

                // Tạo ChartArea
                ChartArea chartArea = new ChartArea("MainArea")
                {
                    BackColor = Color.Transparent
                };
                chartArea.AxisX.Title = "Trạng thái";
                chartArea.AxisY.Title = "Tỷ lệ (%)";
                chartArea.AxisY.Interval = 10;
                chartPieTaskCompletionRate.ChartAreas.Add(chartArea);

                // Tạo Series
                Series series = new Series("Tỷ lệ hoàn thành")
                {
                    ChartType = SeriesChartType.Column,
                    ChartArea = "MainArea",
                    IsValueShownAsLabel = true
                };

                // Thêm dữ liệu vào Series
                series.Points.AddXY("Tỷ lệ hoàn thành", tyLeHoanThanh);

                chartPieTaskCompletionRate.Series.Add(series);

                // Thêm tiêu đề
                chartPieTaskCompletionRate.Titles.Clear();
                chartPieTaskCompletionRate.Titles.Add(new Title(
                    "Tỷ lệ hoàn thành công việc",
                    Docking.Top,
                    new Font("Arial", 16, FontStyle.Bold),
                    Color.Black
                ));

                // Thêm chú thích (Legend)
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