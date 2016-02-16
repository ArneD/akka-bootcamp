namespace ChartApp
{
    partial class Main
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
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MonitorCpuButton = new System.Windows.Forms.Button();
            this.MonitorMemoryButton = new System.Windows.Forms.Button();
            this.MonitorDiskButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea1.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea1);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.sysChart.Legends.Add(legend1);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Name = "sysChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.sysChart.Series.Add(series1);
            this.sysChart.Size = new System.Drawing.Size(684, 446);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // MonitorCpuButton
            // 
            this.MonitorCpuButton.Location = new System.Drawing.Point(573, 261);
            this.MonitorCpuButton.Name = "MonitorCpuButton";
            this.MonitorCpuButton.Size = new System.Drawing.Size(99, 45);
            this.MonitorCpuButton.TabIndex = 1;
            this.MonitorCpuButton.Text = "CPU (ON)";
            this.MonitorCpuButton.UseVisualStyleBackColor = true;
            this.MonitorCpuButton.Click += new System.EventHandler(this.MonitorCpuButton_Click);
            // 
            // MonitorMemoryButton
            // 
            this.MonitorMemoryButton.Location = new System.Drawing.Point(573, 312);
            this.MonitorMemoryButton.Name = "MonitorMemoryButton";
            this.MonitorMemoryButton.Size = new System.Drawing.Size(99, 45);
            this.MonitorMemoryButton.TabIndex = 2;
            this.MonitorMemoryButton.Text = "MEMORY (OFF)";
            this.MonitorMemoryButton.UseVisualStyleBackColor = true;
            this.MonitorMemoryButton.Click += new System.EventHandler(this.MonitorMemoryButton_Click);
            // 
            // MonitorDiskButton
            // 
            this.MonitorDiskButton.Location = new System.Drawing.Point(573, 363);
            this.MonitorDiskButton.Name = "MonitorDiskButton";
            this.MonitorDiskButton.Size = new System.Drawing.Size(99, 45);
            this.MonitorDiskButton.TabIndex = 3;
            this.MonitorDiskButton.Text = "DISK (OFF)";
            this.MonitorDiskButton.UseVisualStyleBackColor = true;
            this.MonitorDiskButton.Click += new System.EventHandler(this.MonitorDiskButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(573, 171);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(99, 45);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "PAUSE II";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 446);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.MonitorDiskButton);
            this.Controls.Add(this.MonitorMemoryButton);
            this.Controls.Add(this.MonitorCpuButton);
            this.Controls.Add(this.sysChart);
            this.Name = "Main";
            this.Text = "System Metrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button MonitorCpuButton;
        private System.Windows.Forms.Button MonitorMemoryButton;
        private System.Windows.Forms.Button MonitorDiskButton;
        private System.Windows.Forms.Button PauseButton;
    }
}

