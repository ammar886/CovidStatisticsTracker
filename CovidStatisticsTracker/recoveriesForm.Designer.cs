namespace CovidStatisticsTracker
{
    partial class recoveriesForm
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
            this.recoveriesNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertRecoveries = new System.Windows.Forms.Button();
            this.DelRecoveries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recoveriesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(598, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 28;
            // 
            // recoveriesNum
            // 
            this.recoveriesNum.Location = new System.Drawing.Point(280, 122);
            this.recoveriesNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.recoveriesNum.Name = "recoveriesNum";
            this.recoveriesNum.Size = new System.Drawing.Size(99, 20);
            this.recoveriesNum.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(65, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter Recoveries:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(317, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Recoveries Portal";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(69, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 35;
            this.button1.Text = "Back to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(558, 178);
            this.timeInput.Multiline = true;
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(101, 20);
            this.timeInput.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(464, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Time:";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(558, 126);
            this.dateInput.Multiline = true;
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(101, 20);
            this.dateInput.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(464, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Date:";
            // 
            // insertRecoveries
            // 
            this.insertRecoveries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.insertRecoveries.Location = new System.Drawing.Point(256, 284);
            this.insertRecoveries.Name = "insertRecoveries";
            this.insertRecoveries.Size = new System.Drawing.Size(109, 29);
            this.insertRecoveries.TabIndex = 30;
            this.insertRecoveries.Text = "INSERT";
            this.insertRecoveries.UseVisualStyleBackColor = true;
            this.insertRecoveries.Click += new System.EventHandler(this.insertRecoveries_Click);
            // 
            // DelRecoveries
            // 
            this.DelRecoveries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DelRecoveries.Location = new System.Drawing.Point(458, 277);
            this.DelRecoveries.Name = "DelRecoveries";
            this.DelRecoveries.Size = new System.Drawing.Size(140, 36);
            this.DelRecoveries.TabIndex = 29;
            this.DelRecoveries.Text = "Delete Record";
            this.DelRecoveries.UseVisualStyleBackColor = true;
            this.DelRecoveries.Click += new System.EventHandler(this.DelRecoveries_Click);
            // 
            // recoveriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.App_BG;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recoveriesNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertRecoveries);
            this.Controls.Add(this.DelRecoveries);
            this.Name = "recoveriesForm";
            this.Text = "recoveriesForm";
            this.Load += new System.EventHandler(this.recoveriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recoveriesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown recoveriesNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox timeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertRecoveries;
        private System.Windows.Forms.Button DelRecoveries;
    }
}