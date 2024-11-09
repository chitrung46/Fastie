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
    public partial class PieChartStatusTaskForm : Form
    {
        public PieChartStatusTaskForm()
        {
            InitializeComponent();
            InitializePieChartStateTask();
        }

        private void InitializePieChartStateTask()
        {
            // Đặt tiêu đề cho biểu đồ
            chartPieStatusTask.Titles.Add("Thống kê trạng thái công việc");

            // Tạo một ChartArea mới dành riêng cho biểu đồ tròn
            ChartArea pieChartArea = new ChartArea("PieChartArea");
            chartPieStatusTask.ChartAreas.Clear(); // Xóa các ChartArea cũ nếu có
            chartPieStatusTask.ChartAreas.Add(pieChartArea);

            // Tạo một Series với kiểu biểu đồ là Pie
            Series series = new Series("Số Lượng")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "PieChartArea" // Liên kết Series với ChartArea mới
            };

            // Thêm các dữ liệu mẫu vào Series
            //(vd 1 công việc chờ nhận, 1 cv chưa bắt đầu, 5 cv đang thực hiện, 3 cv chờ duyệt, 7 cv hoàn thành)
            series.Points.AddXY("1 công việc chờ nhận", 10);
            series.Points.AddXY("1 công việc chưa bắt đầu", 10);
            series.Points.AddXY("5 công việc đang thực hiện", 25);
            series.Points.AddXY("3 công việc chờ duyệt", 15);
            series.Points.AddXY("7 công việc hoàn thành", 40);

            // Thêm Series vào biểu đồ
            chartPieStatusTask.Series.Clear(); // Xóa các Series cũ nếu có
            chartPieStatusTask.Series.Add(series);

            // Cấu hình để hiển thị giá trị và nhãn trên mỗi phần
            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT"; // Hiển thị % cho từng phần
            series.LegendText = "#VALX"; // Hiển thị tên hạng mục trong phần chú thích

            // Thêm chú thích cho biểu đồ
            if (chartPieStatusTask.Legends.Count == 0)
            {
                chartPieStatusTask.Legends.Add(new Legend("Legend"));
            }
        }
    }
}
