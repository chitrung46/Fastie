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
            List<AnalyticsDTO> data = analyticsBLL.ThongKeNhanViecChuDongVaDieuChinh(accountId, departmentId, positionId, personnelId, startDate, endDate);

            // Set chart title
            chartAcceptTask.Titles.Add("Thống kê số lần nhận việc và xin điều chỉnh phân công");

            // Set up ChartArea
            ChartArea chartArea = new ChartArea("MainArea");
            chartAcceptTask.ChartAreas.Clear();
            chartAcceptTask.ChartAreas.Add(chartArea);

            // Configure series
            Series seriesAcceptTask = new Series("Nhận việc chủ động") { ChartType = SeriesChartType.Column };
            Series seriesAdjustRequest = new Series("Xin điều chỉnh") { ChartType = SeriesChartType.Column };

            seriesAcceptTask.Points.AddXY("Nhận việc", data[0].SoLanNhanViecChuDong);
            seriesAdjustRequest.Points.AddXY("Xin điều chỉnh", data[0].SoLanXinDieuChinh);

            // Add series to the chart
            chartAcceptTask.Series.Clear();
            chartAcceptTask.Series.Add(seriesAcceptTask);
            chartAcceptTask.Series.Add(seriesAdjustRequest);

            // Configure axis
            chartArea.AxisX.Title = "Trạng thái";
            chartArea.AxisY.Title = "Số lượng";
            chartArea.AxisY.Interval = 1;

            // Add legend if not present
            if (chartAcceptTask.Legends.Count == 0)
            {
                chartAcceptTask.Legends.Add(new Legend("Legend"));
            }
        }
    }
}
