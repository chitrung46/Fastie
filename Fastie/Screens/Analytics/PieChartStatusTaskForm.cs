using BLL.AnalyticsBLL;
using DTO.AnalyticsDTO;
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
        private AnalyticsBLL analyticsBLL = new AnalyticsBLL();
        private string accountId;
        private string departmentId;
        private string positionId;
        private string personnelId;
        private DateTime startDate;
        private DateTime endDate;

        public PieChartStatusTaskForm(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.accountId = accountId;
            this.departmentId = departmentId;
            this.positionId = positionId;
            this.personnelId = personnelId;
            this.startDate = startDate;
            this.endDate = endDate;

            InitializePieChartStateTask();
        }

        private void InitializePieChartStateTask()
        {
            try
            {
                // Fetch data from BLL
                List<AnalyticsDTO> data = analyticsBLL.ThongKeTrangThaiCongViec(accountId, departmentId, positionId, personnelId, startDate, endDate);

                // Clear old chart data
                chartPieStatusTask.ChartAreas.Clear();
                chartPieStatusTask.Series.Clear();
                chartPieStatusTask.Legends.Clear();

                // Create a new ChartArea
                ChartArea pieChartArea = new ChartArea("PieChartArea");
                pieChartArea.BackColor = Color.Transparent;
                chartPieStatusTask.ChartAreas.Add(pieChartArea);

                // Create a new Series for Pie Chart
                Series series = new Series("Task Status")
                {
                    ChartType = SeriesChartType.Pie,
                    ChartArea = "PieChartArea",
                    IsValueShownAsLabel = true,
                    Label = "#PERCENT", // Show percentages on the chart
                    LegendText = "#VALX" // Show categories in the legend
                };

                // Populate Series with data
                foreach (var item in data)
                {
                    series.Points.AddXY(item.TenChucVu, Convert.ToInt32(item.IdChucVu)); // Assuming `TenChucVu` = Status, `IdChucVu` = Count
                }

                // Add Series to Chart
                chartPieStatusTask.Series.Add(series);

                // Add Legend
                Legend legend = new Legend("TaskLegend")
                {
                    Title = "Task Status",
                    Docking = Docking.Right,
                    BackColor = Color.Transparent
                };
                chartPieStatusTask.Legends.Add(legend);

                // Customize chart appearance
                chartPieStatusTask.BackColor = Color.White;
                chartPieStatusTask.Titles.Clear();
                chartPieStatusTask.Titles.Add(new Title("Thống kê trạng thái của các công việc", Docking.Top, new Font("Arial", 16, FontStyle.Bold), Color.Black));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing pie chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

