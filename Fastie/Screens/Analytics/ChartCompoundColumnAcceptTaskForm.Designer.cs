﻿namespace Fastie.Screens.Analytics
{
    partial class ChartCompoundColumnAcceptTaskForm
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
            this.chartAcceptTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartAcceptTask)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAcceptTask
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAcceptTask.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAcceptTask.Legends.Add(legend1);
            this.chartAcceptTask.Location = new System.Drawing.Point(0, 1);
            this.chartAcceptTask.Name = "chartAcceptTask";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAcceptTask.Series.Add(series1);
            this.chartAcceptTask.Size = new System.Drawing.Size(1094, 564);
            this.chartAcceptTask.TabIndex = 11;
            this.chartAcceptTask.Text = "Thống kê công việc";
            // 
            // ChartCompoundColumnAcceptTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1094, 622);
            this.Controls.Add(this.chartAcceptTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChartCompoundColumnAcceptTaskForm";
            this.Text = "chartCompoundColumnAcceptTask";
            ((System.ComponentModel.ISupportInitialize)(this.chartAcceptTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAcceptTask;
    }
}