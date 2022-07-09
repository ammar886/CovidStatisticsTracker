namespace CovidStatisticsTracker
{
    partial class cityRecord_User
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
            this.button1 = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.covidStatsTrackerDataSet = new CovidStatisticsTracker.covidStatsTrackerDataSet();
            this.cityWiseCasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityWiseCasesTableAdapter = new CovidStatisticsTracker.covidStatsTrackerDataSetTableAdapters.cityWiseCasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidStatsTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityWiseCasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(51, 23);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(167, 49);
            this.showBtn.TabIndex = 10;
            this.showBtn.Text = "Show City Record";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 339);
            this.dataGridView1.TabIndex = 9;
            // 
            // covidStatsTrackerDataSet
            // 
            this.covidStatsTrackerDataSet.DataSetName = "covidStatsTrackerDataSet";
            this.covidStatsTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityWiseCasesBindingSource
            // 
            this.cityWiseCasesBindingSource.DataMember = "cityWiseCases";
            this.cityWiseCasesBindingSource.DataSource = this.covidStatsTrackerDataSet;
            // 
            // cityWiseCasesTableAdapter
            // 
            this.cityWiseCasesTableAdapter.ClearBeforeFill = true;
            // 
            // cityRecord_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.App_BG;
            this.ClientSize = new System.Drawing.Size(786, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cityRecord_User";
            this.Text = "cityRecord_User";
            this.Load += new System.EventHandler(this.cityRecord_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidStatsTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityWiseCasesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private covidStatsTrackerDataSet covidStatsTrackerDataSet;
        private System.Windows.Forms.BindingSource cityWiseCasesBindingSource;
        private covidStatsTrackerDataSetTableAdapters.cityWiseCasesTableAdapter cityWiseCasesTableAdapter;
    }
}