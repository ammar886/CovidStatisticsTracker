namespace CovidStatisticsTracker
{
    partial class graphChart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.covidStatsTrackerDataSet = new CovidStatisticsTracker.covidStatsTrackerDataSet();
            this.covidStatsTrackerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityWiseCasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityWiseCasesTableAdapter = new CovidStatisticsTracker.covidStatsTrackerDataSetTableAdapters.cityWiseCasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidStatsTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidStatsTrackerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityWiseCasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.cityWiseCasesBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(41, 33);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "cityName";
            series1.YValueMembers = "casesRecorded";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(627, 387);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // covidStatsTrackerDataSet
            // 
            this.covidStatsTrackerDataSet.DataSetName = "covidStatsTrackerDataSet";
            this.covidStatsTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // covidStatsTrackerDataSetBindingSource
            // 
            this.covidStatsTrackerDataSetBindingSource.DataSource = this.covidStatsTrackerDataSet;
            this.covidStatsTrackerDataSetBindingSource.Position = 0;
            // 
            // cityWiseCasesBindingSource
            // 
            this.cityWiseCasesBindingSource.DataMember = "cityWiseCases";
            this.cityWiseCasesBindingSource.DataSource = this.covidStatsTrackerDataSetBindingSource;
            // 
            // cityWiseCasesTableAdapter
            // 
            this.cityWiseCasesTableAdapter.ClearBeforeFill = true;
            // 
            // graphChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 462);
            this.Controls.Add(this.chart1);
            this.Name = "graphChart";
            this.Text = "graphChart";
            this.Load += new System.EventHandler(this.graphChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidStatsTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidStatsTrackerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityWiseCasesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource covidStatsTrackerDataSetBindingSource;
        private covidStatsTrackerDataSet covidStatsTrackerDataSet;
        private System.Windows.Forms.BindingSource cityWiseCasesBindingSource;
        private covidStatsTrackerDataSetTableAdapters.cityWiseCasesTableAdapter cityWiseCasesTableAdapter;
    }
}