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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MonitorCpuButton = new System.Windows.Forms.Button();
            this.MonitorMemoryButton = new System.Windows.Forms.Button();
            this.MonitorDiskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea4.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea4);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.sysChart.Legends.Add(legend4);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Name = "sysChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.sysChart.Series.Add(series4);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 446);
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
    }
}

