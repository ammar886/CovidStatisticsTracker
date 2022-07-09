namespace CovidStatisticsTracker
{
    partial class WorldWideCasesForm
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
            this.insertCasesNumWW = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertCasesWW = new System.Windows.Forms.Button();
            this.DelBtnWW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insertCasesNumWW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(535, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 17;
            // 
            // insertCasesNumWW
            // 
            this.insertCasesNumWW.Location = new System.Drawing.Point(250, 125);
            this.insertCasesNumWW.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.insertCasesNumWW.Name = "insertCasesNumWW";
            this.insertCasesNumWW.Size = new System.Drawing.Size(99, 20);
            this.insertCasesNumWW.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(35, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter New Cases:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(259, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "World Wide Cases Portal";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(54, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Back to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(539, 185);
            this.timeInput.Multiline = true;
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(101, 20);
            this.timeInput.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(433, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Time:";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(539, 125);
            this.dateInput.Multiline = true;
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(101, 20);
            this.dateInput.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(433, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date:";
            // 
            // insertCasesWW
            // 
            this.insertCasesWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.insertCasesWW.Location = new System.Drawing.Point(250, 282);
            this.insertCasesWW.Name = "insertCasesWW";
            this.insertCasesWW.Size = new System.Drawing.Size(109, 29);
            this.insertCasesWW.TabIndex = 19;
            this.insertCasesWW.Text = "INSERT";
            this.insertCasesWW.UseVisualStyleBackColor = true;
            this.insertCasesWW.Click += new System.EventHandler(this.insertCasesWW_Click);
            // 
            // DelBtnWW
            // 
            this.DelBtnWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DelBtnWW.Location = new System.Drawing.Point(437, 275);
            this.DelBtnWW.Name = "DelBtnWW";
            this.DelBtnWW.Size = new System.Drawing.Size(140, 36);
            this.DelBtnWW.TabIndex = 18;
            this.DelBtnWW.Text = "Delete Record";
            this.DelBtnWW.UseVisualStyleBackColor = true;
            this.DelBtnWW.Click += new System.EventHandler(this.DelBtnWW_Click);
            // 
            // WorldWideCasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.App_BG;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insertCasesNumWW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertCasesWW);
            this.Controls.Add(this.DelBtnWW);
            this.Name = "WorldWideCasesForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.insertCasesNumWW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown insertCasesNumWW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox timeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertCasesWW;
        private System.Windows.Forms.Button DelBtnWW;
    }
}