namespace CovidStatisticsTracker
{
    partial class underTreatForm
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
            this.underTreatNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertUnderTreat = new System.Windows.Forms.Button();
            this.Del_UnderTreat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.underTreatNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(611, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 39;
            // 
            // underTreatNum
            // 
            this.underTreatNum.Location = new System.Drawing.Point(295, 119);
            this.underTreatNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.underTreatNum.Name = "underTreatNum";
            this.underTreatNum.Size = new System.Drawing.Size(99, 20);
            this.underTreatNum.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Enter UnderTreatment Cases:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(264, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Under Treatment Cases Portal";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(16, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 46;
            this.button1.Text = "Back to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(555, 170);
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
            this.label5.Location = new System.Drawing.Point(477, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Time:";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(555, 115);
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
            this.label4.Location = new System.Drawing.Point(477, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Date:";
            // 
            // insertUnderTreat
            // 
            this.insertUnderTreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.insertUnderTreat.Location = new System.Drawing.Point(269, 279);
            this.insertUnderTreat.Name = "insertUnderTreat";
            this.insertUnderTreat.Size = new System.Drawing.Size(109, 29);
            this.insertUnderTreat.TabIndex = 41;
            this.insertUnderTreat.Text = "INSERT";
            this.insertUnderTreat.UseVisualStyleBackColor = true;
            this.insertUnderTreat.Click += new System.EventHandler(this.insertUnderTreat_Click);
            // 
            // Del_UnderTreat
            // 
            this.Del_UnderTreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Del_UnderTreat.Location = new System.Drawing.Point(471, 274);
            this.Del_UnderTreat.Name = "Del_UnderTreat";
            this.Del_UnderTreat.Size = new System.Drawing.Size(140, 36);
            this.Del_UnderTreat.TabIndex = 40;
            this.Del_UnderTreat.Text = "Delete Record";
            this.Del_UnderTreat.UseVisualStyleBackColor = true;
            this.Del_UnderTreat.Click += new System.EventHandler(this.Del_UnderTreat_Click);
            // 
            // underTreatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.App_BG;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.underTreatNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertUnderTreat);
            this.Controls.Add(this.Del_UnderTreat);
            this.Name = "underTreatForm";
            this.Text = "underTreatForm";
            this.Load += new System.EventHandler(this.underTreatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.underTreatNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown underTreatNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox timeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertUnderTreat;
        private System.Windows.Forms.Button Del_UnderTreat;
    }
}