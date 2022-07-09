namespace CovidStatisticsTracker
{
    partial class cityCasesForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.insertcasesCityNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertCityCases = new System.Windows.Forms.Button();
            this.DeleteCityCases = new System.Windows.Forms.Button();
            this.citiesList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.insertcasesCityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(638, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 39;
            // 
            // insertcasesCityNum
            // 
            this.insertcasesCityNum.Location = new System.Drawing.Point(299, 117);
            this.insertcasesCityNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.insertcasesCityNum.Name = "insertcasesCityNum";
            this.insertcasesCityNum.Size = new System.Drawing.Size(99, 20);
            this.insertcasesCityNum.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(315, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cities Record Portal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(86, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 46;
            this.button1.Text = "Back to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(568, 184);
            this.timeInput.Multiline = true;
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(101, 20);
            this.timeInput.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(483, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Time:";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(568, 121);
            this.dateInput.Multiline = true;
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(101, 20);
            this.dateInput.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(483, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Date:";
            // 
            // insertCityCases
            // 
            this.insertCityCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.insertCityCases.Location = new System.Drawing.Point(278, 265);
            this.insertCityCases.Name = "insertCityCases";
            this.insertCityCases.Size = new System.Drawing.Size(109, 29);
            this.insertCityCases.TabIndex = 41;
            this.insertCityCases.Text = "INSERT";
            this.insertCityCases.UseVisualStyleBackColor = true;
            this.insertCityCases.Click += new System.EventHandler(this.insertCityCases_Click);
            // 
            // DeleteCityCases
            // 
            this.DeleteCityCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteCityCases.Location = new System.Drawing.Point(487, 265);
            this.DeleteCityCases.Name = "DeleteCityCases";
            this.DeleteCityCases.Size = new System.Drawing.Size(140, 36);
            this.DeleteCityCases.TabIndex = 40;
            this.DeleteCityCases.Text = "Delete Record";
            this.DeleteCityCases.UseVisualStyleBackColor = true;
            this.DeleteCityCases.Click += new System.EventHandler(this.DeleteCityCases_Click);
            // 
            // citiesList
            // 
            this.citiesList.FormattingEnabled = true;
            this.citiesList.Items.AddRange(new object[] {
            "Faisalabad",
            "Gujranwala",
            "Islamabad",
            "Karachi",
            "Sialkot",
            "Lahore",
            "Quetta",
            "Rawalpindi"});
            this.citiesList.Location = new System.Drawing.Point(278, 184);
            this.citiesList.Name = "citiesList";
            this.citiesList.Size = new System.Drawing.Size(120, 30);
            this.citiesList.TabIndex = 47;
            this.citiesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(82, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Enter New Cases:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(141, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = "Select City:";
            // 
            // cityCasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.App_BG;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.citiesList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insertcasesCityNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertCityCases);
            this.Controls.Add(this.DeleteCityCases);
            this.Name = "cityCasesForm";
            this.Text = "cityCasesForm";
            this.Load += new System.EventHandler(this.cityCasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insertcasesCityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown insertcasesCityNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox timeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertCityCases;
        private System.Windows.Forms.Button DeleteCityCases;
        private System.Windows.Forms.ListBox citiesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}