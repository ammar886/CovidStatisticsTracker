namespace CovidStatisticsTracker
{
    partial class loginForm
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.adminPassLogin_txtBox = new System.Windows.Forms.TextBox();
            this.adminIDlogin_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUpBtbF = new System.Windows.Forms.Button();
            this.showPassLogin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(166, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to Continue";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearBtn.Location = new System.Drawing.Point(278, 353);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 29);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Login_Btn
            // 
            this.Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Login_Btn.Location = new System.Drawing.Point(132, 353);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(75, 29);
            this.Login_Btn.TabIndex = 11;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // adminPassLogin_txtBox
            // 
            this.adminPassLogin_txtBox.Location = new System.Drawing.Point(198, 207);
            this.adminPassLogin_txtBox.Multiline = true;
            this.adminPassLogin_txtBox.Name = "adminPassLogin_txtBox";
            this.adminPassLogin_txtBox.PasswordChar = '*';
            this.adminPassLogin_txtBox.Size = new System.Drawing.Size(210, 21);
            this.adminPassLogin_txtBox.TabIndex = 10;
            // 
            // adminIDlogin_txtBox
            // 
            this.adminIDlogin_txtBox.Location = new System.Drawing.Point(198, 163);
            this.adminIDlogin_txtBox.Multiline = true;
            this.adminIDlogin_txtBox.Name = "adminIDlogin_txtBox";
            this.adminIDlogin_txtBox.Size = new System.Drawing.Size(210, 21);
            this.adminIDlogin_txtBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(98, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(98, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Admin ID";
            // 
            // confirmPassBox
            // 
            this.confirmPassBox.Location = new System.Drawing.Point(198, 260);
            this.confirmPassBox.Multiline = true;
            this.confirmPassBox.Name = "confirmPassBox";
            this.confirmPassBox.PasswordChar = '*';
            this.confirmPassBox.Size = new System.Drawing.Size(210, 21);
            this.confirmPassBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(44, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Confim Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(192, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Don\'t have an account?";
            // 
            // SignUpBtbF
            // 
            this.SignUpBtbF.Location = new System.Drawing.Point(183, 433);
            this.SignUpBtbF.Name = "SignUpBtbF";
            this.SignUpBtbF.Size = new System.Drawing.Size(134, 23);
            this.SignUpBtbF.TabIndex = 16;
            this.SignUpBtbF.Text = "Create Account";
            this.SignUpBtbF.UseVisualStyleBackColor = true;
            this.SignUpBtbF.Click += new System.EventHandler(this.SignUpBtbF_Click);
            // 
            // showPassLogin
            // 
            this.showPassLogin.AutoSize = true;
            this.showPassLogin.BackColor = System.Drawing.Color.Transparent;
            this.showPassLogin.Location = new System.Drawing.Point(306, 310);
            this.showPassLogin.Name = "showPassLogin";
            this.showPassLogin.Size = new System.Drawing.Size(102, 17);
            this.showPassLogin.TabIndex = 17;
            this.showPassLogin.Text = "Show Password";
            this.showPassLogin.UseVisualStyleBackColor = false;
            this.showPassLogin.CheckedChanged += new System.EventHandler(this.showPassLogin_CheckedChanged);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.Untitled_design;
            this.ClientSize = new System.Drawing.Size(457, 491);
            this.Controls.Add(this.showPassLogin);
            this.Controls.Add(this.SignUpBtbF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmPassBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.adminPassLogin_txtBox);
            this.Controls.Add(this.adminIDlogin_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.TextBox adminPassLogin_txtBox;
        private System.Windows.Forms.TextBox adminIDlogin_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SignUpBtbF;
        private System.Windows.Forms.CheckBox showPassLogin;
    }
}