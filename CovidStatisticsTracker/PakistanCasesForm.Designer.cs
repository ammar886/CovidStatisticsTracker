namespace CovidStatisticsTracker
{
    partial class PakistanCasesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insertCasesNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DelBtn = new System.Windows.Forms.Button();
            this.insertCases = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.timeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insertCasesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(255, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pakistan Cases Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter New Cases:";
            // 
            // insertCasesNum
            // 
            this.insertCasesNum.Location = new System.Drawing.Point(215, 139);
            this.insertCasesNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.insertCasesNum.Name = "insertCasesNum";
            this.insertCasesNum.Size = new System.Drawing.Size(99, 20);
            this.insertCasesNum.TabIndex = 2;
            this.insertCasesNum.ValueChanged += new System.EventHandler(this.insertCasesNum_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(440, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 3;
            // 
            // DelBtn
            // 
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DelBtn.Location = new System.Drawing.Point(444, 290);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(140, 36);
            this.DelBtn.TabIndex = 6;
            this.DelBtn.Text = "Delete Record";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // insertCases
            // 
            this.insertCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.insertCases.Location = new System.Drawing.Point(215, 290);
            this.insertCases.Name = "insertCases";
            this.insertCases.Size = new System.Drawing.Size(109, 29);
            this.insertCases.TabIndex = 7;
            this.insertCases.Text = "INSERT";
            this.insertCases.UseVisualStyleBackColor = true;
            this.insertCases.Click += new System.EventHandler(this.insertCases_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(381, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(479, 140);
            this.dateInput.Multiline = true;
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(101, 20);
            this.dateInput.TabIndex = 10;
            this.dateInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(479, 201);
            this.timeInput.Multiline = true;
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(101, 20);
            this.timeInput.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(382, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(30, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PakistanCasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.App_BG;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertCases);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insertCasesNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PakistanCasesForm";
            this.Text = "PakistanCasesForm";
            ((System.ComponentModel.ISupportInitialize)(this.insertCasesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown insertCasesNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button insertCases;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.TextBox timeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}