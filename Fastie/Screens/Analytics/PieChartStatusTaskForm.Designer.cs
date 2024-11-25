namespace Fastie.Screens.Analytics
{
    partial class PieChartStatusTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PieChartStatusTaskForm));
            this.chartPieStatusTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieStatusTask)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPieStatusTask
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPieStatusTask.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPieStatusTask.Legends.Add(legend1);
            this.chartPieStatusTask.Location = new System.Drawing.Point(1, 1);
            this.chartPieStatusTask.Name = "chartPieStatusTask";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Label = "#PERCENT";
            series1.Legend = "Legend1";
            series1.Name = "ChartStatusTask";
            this.chartPieStatusTask.Series.Add(series1);
            this.chartPieStatusTask.Size = new System.Drawing.Size(1094, 564);
            this.chartPieStatusTask.TabIndex = 7;
            this.chartPieStatusTask.Text = "Thống kê công việc";
            title1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Thống kê trạng thái công việc";
            this.chartPieStatusTask.Titles.Add(title1);
            // 
            // PieChartStatusTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1094, 622);
            this.Controls.Add(this.chartPieStatusTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PieChartStatusTaskForm";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chartPieStatusTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPieStatusTask;
    }
}