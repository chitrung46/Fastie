namespace Fastie.Screens.Analytics
{
    partial class PieChartTaskCompletionRateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PieChartTaskCompletionRateForm));
            this.chartPieTaskCompletionRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieTaskCompletionRate)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPieTaskCompletionRate
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPieTaskCompletionRate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPieTaskCompletionRate.Legends.Add(legend1);
            this.chartPieTaskCompletionRate.Location = new System.Drawing.Point(0, 2);
            this.chartPieTaskCompletionRate.Name = "chartPieTaskCompletionRate";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPieTaskCompletionRate.Series.Add(series1);
            this.chartPieTaskCompletionRate.Size = new System.Drawing.Size(1094, 564);
            this.chartPieTaskCompletionRate.TabIndex = 13;
            this.chartPieTaskCompletionRate.Text = "Thống kê công việc";
            // 
            // PieChartTaskCompletionRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1094, 622);
            this.Controls.Add(this.chartPieTaskCompletionRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PieChartTaskCompletionRateForm";
            this.Text = "PieChartTaskCompletionRate";
            ((System.ComponentModel.ISupportInitialize)(this.chartPieTaskCompletionRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPieTaskCompletionRate;
    }
}