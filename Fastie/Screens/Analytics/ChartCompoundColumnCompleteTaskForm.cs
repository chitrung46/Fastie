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
    public partial class ChartCompoundColumnCompleteTaskForm : Form
    {
        private string accountId;
        private string departmentId;
        private string positionId;
        private string personnelId;
        private DateTime startDate;
        private DateTime endDate;

        private AnalyticsBLL analyticsBLL = new AnalyticsBLL();

        public ChartCompoundColumnCompleteTaskForm(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            this.accountId = accountId;
            this.departmentId = departmentId;
            this.positionId = positionId;
            this.personnelId = personnelId;
            this.startDate = startDate;
            this.endDate = endDate;

            InitializeColumnChartForCompleteTask();
        }

        private void InitializeColumnChartForCompleteTask()
        {
            List<AnalyticsDTO> data = analyticsBLL.ThongKeHoanThanh(accountId, departmentId, positionId, personnelId, startDate, endDate);

            // Set chart title
            chartCompleteTask.Titles.Add("Thống kê công việc hoàn thành");

            // Set up ChartArea
            ChartArea chartArea = new ChartArea("MainArea");
            chartCompleteTask.ChartAreas.Clear();
            chartCompleteTask.ChartAreas.Add(chartArea);

            // Configure series
            Series seriesOnTime = new Series("Đúng hạn") { ChartType = SeriesChartType.Column };
            Series seriesLate = new Series("Trễ hạn") { ChartType = SeriesChartType.Column };

            seriesOnTime.Points.AddXY("Hoàn thành", data[0].SoLuongDungHan);
            seriesLate.Points.AddXY("Hoàn thành", data[0].SoLuongTreHan);

            // Add series to the chart
            chartCompleteTask.Series.Clear();
            chartCompleteTask.Series.Add(seriesOnTime);
            chartCompleteTask.Series.Add(seriesLate);

            // Configure axis
            chartArea.AxisX.Title = "Trạng thái";
            chartArea.AxisY.Title = "Số lượng";
            chartArea.AxisY.Interval = 1;

            // Add legend if not present
            if (chartCompleteTask.Legends.Count == 0)
            {
                chartCompleteTask.Legends.Add(new Legend("Legend"));
            }
        }
    }
}
