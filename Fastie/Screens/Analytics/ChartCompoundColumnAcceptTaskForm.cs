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
    public partial class ChartCompoundColumnAcceptTaskForm : Form
    {
        public ChartCompoundColumnAcceptTaskForm()
        {
            InitializeComponent();
            InitializeColumnChartAcceptTask();
        }
        private void InitializeColumnChartAcceptTask()
        {
            // Đặt tiêu đề cho biểu đồ
            chartAcceptTask.Titles.Add("Thống kê số lần nhận việc");

            // Tạo một ChartArea để vẽ biểu đồ
            ChartArea chartArea = new ChartArea("MainArea");
            chartAcceptTask.ChartAreas.Clear(); // Xóa các ChartArea cũ nếu có
            chartAcceptTask.ChartAreas.Add(chartArea);

            // Tạo Series cho Nhóm 1
            Series series1 = new Series("Nhóm 1")
            {
                ChartType = SeriesChartType.Column
            };
            series1.Points.AddXY("Tháng 1", 50);
            series1.Points.AddXY("Tháng 2", 70);
            series1.Points.AddXY("Tháng 3", 60);

            // Tạo Series cho Nhóm 2
            Series series2 = new Series("Nhóm 2")
            {
                ChartType = SeriesChartType.Column
            };
            series2.Points.AddXY("Tháng 1", 40);
            series2.Points.AddXY("Tháng 2", 65);
            series2.Points.AddXY("Tháng 3", 80);

            // Thêm các Series vào biểu đồ
            chartAcceptTask.Series.Clear(); // Xóa các Series cũ nếu có
            chartAcceptTask.Series.Add(series1);
            chartAcceptTask.Series.Add(series2);

            // Cấu hình trục X và trục Y
            chartArea.AxisX.Title = "Tháng";
            chartArea.AxisY.Title = "Giá Trị";
            chartArea.AxisY.Interval = 10;

            // Thêm chú thích cho biểu đồ nếu chưa có
            if (chartAcceptTask.Legends.Count == 0)
            {
                chartAcceptTask.Legends.Add(new Legend("Legend"));
            }
        }
    }
}
