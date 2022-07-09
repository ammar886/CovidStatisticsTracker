namespace CovidStatisticsTracker
{
    partial class SignUpPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminID_txtBox = new System.Windows.Forms.TextBox();
            this.adminPass_txtBox = new System.Windows.Forms.TextBox();
            this.Sign_Up_Btn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.confirmPassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginDirect = new System.Windows.Forms.Button();
            this.showPassCB = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up as Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // adminID_txtBox
            // 
            this.adminID_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(55)))), ((int)(((byte)(236)))));
            this.adminID_txtBox.ForeColor = System.Drawing.Color.Black;
            this.adminID_txtBox.Location = new System.Drawing.Point(209, 153);
            this.adminID_txtBox.Multiline = true;
            this.adminID_txtBox.Name = "adminID_txtBox";
            this.adminID_txtBox.Size = new System.Drawing.Size(176, 21);
            this.adminID_txtBox.TabIndex = 3;
            this.adminID_txtBox.TextChanged += new System.EventHandler(this.adminID_txtBox_TextChanged);
            // 
            // adminPass_txtBox
            // 
            this.adminPass_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(55)))), ((int)(((byte)(236)))));
            this.adminPass_txtBox.Location = new System.Drawing.Point(209, 203);
            this.adminPass_txtBox.Multiline = true;
            this.adminPass_txtBox.Name = "adminPass_txtBox";
            this.adminPass_txtBox.PasswordChar = '*';
            this.adminPass_txtBox.Size = new System.Drawing.Size(176, 21);
            this.adminPass_txtBox.TabIndex = 4;
            this.adminPass_txtBox.TextChanged += new System.EventHandler(this.adminPass_txtBox_TextChanged);
            // 
            // Sign_Up_Btn
            // 
            this.Sign_Up_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(228)))));
            this.Sign_Up_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sign_Up_Btn.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Btn.ForeColor = System.Drawing.Color.Transparent;
            this.Sign_Up_Btn.Location = new System.Drawing.Point(100, 343);
            this.Sign_Up_Btn.Name = "Sign_Up_Btn";
            this.Sign_Up_Btn.Size = new System.Drawing.Size(111, 29);
            this.Sign_Up_Btn.TabIndex = 5;
            this.Sign_Up_Btn.Text = "Sign Up";
            this.Sign_Up_Btn.UseVisualStyleBackColor = false;
            this.Sign_Up_Btn.Click += new System.EventHandler(this.Sign_Up_Btn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(228)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Transparent;
            this.clearBtn.Location = new System.Drawing.Point(281, 343);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 29);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // confirmPassBox
            // 
            this.confirmPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(55)))), ((int)(((byte)(236)))));
            this.confirmPassBox.Location = new System.Drawing.Point(209, 258);
            this.confirmPassBox.Multiline = true;
            this.confirmPassBox.Name = "confirmPassBox";
            this.confirmPassBox.PasswordChar = '*';
            this.confirmPassBox.Size = new System.Drawing.Size(176, 21);
            this.confirmPassBox.TabIndex = 8;
            this.confirmPassBox.TextChanged += new System.EventHandler(this.confirmPassBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Already have an account?";
            // 
            // LoginDirect
            // 
            this.LoginDirect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(228)))));
            this.LoginDirect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginDirect.Font = new System.Drawing.Font("Roboto Lt", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginDirect.ForeColor = System.Drawing.Color.Transparent;
            this.LoginDirect.Location = new System.Drawing.Point(206, 458);
            this.LoginDirect.Name = "LoginDirect";
            this.LoginDirect.Size = new System.Drawing.Size(76, 23);
            this.LoginDirect.TabIndex = 10;
            this.LoginDirect.Text = "Login";
            this.LoginDirect.UseVisualStyleBackColor = false;
            this.LoginDirect.Click += new System.EventHandler(this.LoginDirect_Click);
            // 
            // showPassCB
            // 
            this.showPassCB.AutoSize = true;
            this.showPassCB.BackColor = System.Drawing.Color.Transparent;
            this.showPassCB.Font = new System.Drawing.Font("Roboto Cn", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassCB.Location = new System.Drawing.Point(318, 298);
            this.showPassCB.Name = "showPassCB";
            this.showPassCB.Size = new System.Drawing.Size(92, 17);
            this.showPassCB.TabIndex = 12;
            this.showPassCB.Text = "Show Password";
            this.showPassCB.UseVisualStyleBackColor = false;
            this.showPassCB.CheckedChanged += new System.EventHandler(this.showPassCB_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CovidStatisticsTracker.Properties.Resources.sign_up;
            this.pictureBox1.Location = new System.Drawing.Point(182, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.Untitled_design;
            this.ClientSize = new System.Drawing.Size(450, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showPassCB);
            this.Controls.Add(this.LoginDirect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmPassBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.Sign_Up_Btn);
            this.Controls.Add(this.adminPass_txtBox);
            this.Controls.Add(this.adminID_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminID_txtBox;
        private System.Windows.Forms.TextBox adminPass_txtBox;
        private System.Windows.Forms.Button Sign_Up_Btn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox confirmPassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LoginDirect;
        private System.Windows.Forms.CheckBox showPassCB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}