
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
                // Lấy dữ liệu từ BLL
                List<AnalyticsDTO> data;

                if (departmentId == "Tất cả") // Nếu chọn tất cả bộ phận
                {
                    data = analyticsBLL.ThongKeTyLeHoanThanhTatCaBoPhan(accountId, startDate, endDate);
                }
                else // Nếu chọn bộ phận cụ thể
                {
                    data = analyticsBLL.ThongKeTyLeHoanThanh(accountId, departmentId, positionId, personnelId, startDate, endDate);
                }

                // Xóa và làm mới biểu đồ
                chartPieTaskCompletionRate.ChartAreas.Clear();
                chartPieTaskCompletionRate.Series.Clear();
                chartPieTaskCompletionRate.Legends.Clear();

                ChartArea columnChartArea = new ChartArea("ColumnChartArea")
                {
                    BackColor = Color.Transparent,
                    AxisX = { Title = "Bộ phận", Interval = 1 }, // Hiển thị tên từng bộ phận trên trục X
                    AxisY = { Title = "Tỷ lệ hoàn thành (%)" } // Hiển thị tỷ lệ trên trục Y
                };
                chartPieTaskCompletionRate.ChartAreas.Add(columnChartArea);

                Series series = new Series("Completion Rate")
                {
                    ChartType = SeriesChartType.Column, // Hiển thị dạng cột
                    ChartArea = "ColumnChartArea",
                    IsValueShownAsLabel = true // Hiển thị giá trị trên các cột
                };

                if (data != null && data.Count > 0)
                {
                    foreach (var stats in data)
                    {
                        if (!string.IsNullOrEmpty(stats.TenBoPhan) && stats.TyLeHoanThanh != null)
                        {
                            series.Points.AddXY(stats.TenBoPhan, stats.TyLeHoanThanh);
                        }
                        else
                        {
                            series.Points.AddXY(stats.TenBoPhan ?? "N/A", 0); // Xử lý nếu thiếu dữ liệu
                        }
                    }
                }
                else
                {
                    series.Points.AddXY("Không có dữ liệu", 0);
                }

                chartPieTaskCompletionRate.Series.Add(series);

                Legend legend = new Legend("Legend")
                {
                    Title = "Bộ phận",
                    Docking = Docking.Right,
                    BackColor = Color.Transparent
                };
                chartPieTaskCompletionRate.Legends.Add(legend);

                chartPieTaskCompletionRate.Titles.Clear();
                chartPieTaskCompletionRate.Titles.Add(new Title("Tỉ lệ hoàn thành công việc theo bộ phận", Docking.Top, new Font("Arial", 16, FontStyle.Bold), Color.Black));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị biểu đồ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }

}