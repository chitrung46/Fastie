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

namespace Fastie.Screens.Analytics
{
    public partial class PieChartTaskCompletionRateForm : Form
    {
        public PieChartTaskCompletionRateForm()
        {
            InitializeComponent();
            InitializePieChartTaskCompletionRate();
        }

        private void InitializePieChartTaskCompletionRate()
        {
            // Đặt tiêu đề cho biểu đồ
            chartPieTaskCompletionRate.Titles.Add("Tỉ lệ hoàn thành công việc");

            // Tạo một ChartArea mới dành riêng cho biểu đồ tròn
            ChartArea pieChartArea = new ChartArea("PieChartArea");
            chartPieTaskCompletionRate.ChartAreas.Clear(); // Xóa các ChartArea cũ nếu có
            chartPieTaskCompletionRate.ChartAreas.Add(pieChartArea);

            // Tạo một Series với kiểu biểu đồ là Pie
            Series series = new Series("Số Lượng")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "PieChartArea" // Liên kết Series với ChartArea mới
            };

            // Thêm các dữ liệu mẫu vào Series
            //(vd 1 công việc chờ nhận, 1 cv chưa bắt đầu, 5 cv đang thực hiện, 3 cv chờ duyệt, 7 cv hoàn thành)
            series.Points.AddXY("công việc chưa hoàn thành", 30);
            series.Points.AddXY("công việc hoàn thành", 70);

            // Thêm Series vào biểu đồ
            chartPieTaskCompletionRate.Series.Clear(); // Xóa các Series cũ nếu có
            chartPieTaskCompletionRate.Series.Add(series);



            // Thêm chú thích cho biểu đồ
            if (chartPieTaskCompletionRate.Legends.Count == 0)
            {
                chartPieTaskCompletionRate.Legends.Add(new Legend("Legend"));
            }
        }
    }
}
