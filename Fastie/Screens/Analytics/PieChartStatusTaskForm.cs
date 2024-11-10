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

            // Cấu hình để hiển thị phần trăm thay vì tên
            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT"; // Hiển thị % cho từng phần thay vì tên
            series.LegendText = "#VALX"; // Hiển thị tên hạng mục trong phần chú thích

            // Thêm các điểm dữ liệu
            series.Points.AddXY("Công việc chờ nhận", 10);
            series.Points.AddXY("Công việc chưa bắt đầu", 20);
            series.Points.AddXY("Công việc đang thực hiện", 30);
            series.Points.AddXY("Công việc chờ duyệt", 30);
            series.Points.AddXY("Công việc hoàn thành", 10);

            // Thêm Series vào biểu đồ
            chartPieStatusTask.Series.Clear(); // Xóa các Series cũ nếu có
            chartPieStatusTask.Series.Add(series);


            // Thêm chú thích cho biểu đồ
            if (chartPieStatusTask.Legends.Count == 0)
            {
                chartPieStatusTask.Legends.Add(new Legend("Legend"));
            }
        }


        private void chartPieStatusTask_Click(object sender, EventArgs e)
        {

        }
    }
}
