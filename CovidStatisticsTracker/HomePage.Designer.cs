namespace CovidStatisticsTracker
{
    partial class HomePage
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
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.AdminSignUpBtn = new System.Windows.Forms.Button();
            this.userSignUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.appTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.appTitleLabel.Location = new System.Drawing.Point(133, 18);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(471, 37);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "COVID STATISTICS TRACKER";
            // 
            // AdminSignUpBtn
            // 
            this.AdminSignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AdminSignUpBtn.Location = new System.Drawing.Point(140, 144);
            this.AdminSignUpBtn.Name = "AdminSignUpBtn";
            this.AdminSignUpBtn.Size = new System.Drawing.Size(206, 43);
            this.AdminSignUpBtn.TabIndex = 1;
            this.AdminSignUpBtn.Text = "Admin Sign Up";
            this.AdminSignUpBtn.UseVisualStyleBackColor = true;
            this.AdminSignUpBtn.Click += new System.EventHandler(this.AdminSignUpBtn_Click);
            // 
            // userSignUpBtn
            // 
            this.userSignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.userSignUpBtn.Location = new System.Drawing.Point(398, 144);
            this.userSignUpBtn.Name = "userSignUpBtn";
            this.userSignUpBtn.Size = new System.Drawing.Size(206, 43);
            this.userSignUpBtn.TabIndex = 2;
            this.userSignUpBtn.Text = "User Sign Up";
            this.userSignUpBtn.UseVisualStyleBackColor = true;
            this.userSignUpBtn.Click += new System.EventHandler(this.userSignUpBtn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.Untitled_design;
            this.ClientSize = new System.Drawing.Size(718, 325);
            this.Controls.Add(this.userSignUpBtn);
            this.Controls.Add(this.AdminSignUpBtn);
            this.Controls.Add(this.appTitleLabel);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Button AdminSignUpBtn;
        private System.Windows.Forms.Button userSignUpBtn;
    }
}

