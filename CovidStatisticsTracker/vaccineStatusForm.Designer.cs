namespace CovidStatisticsTracker
{
    partial class vaccineStatusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.insertCityCases = new System.Windows.Forms.Button();
            this.DeleteCityCases = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dose_list = new System.Windows.Forms.ListBox();
            this.id_input = new System.Windows.Forms.TextBox();
            this.name_Input = new System.Windows.Forms.TextBox();
            this.age_Input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vaccine_Input = new System.Windows.Forms.TextBox();
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
            this.label3.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(272, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Vaccination Record Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(82, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Enter Name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(22, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 59;
            this.button1.Text = "Back to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertCityCases
            // 
            this.insertCityCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.insertCityCases.Location = new System.Drawing.Point(245, 347);
            this.insertCityCases.Name = "insertCityCases";
            this.insertCityCases.Size = new System.Drawing.Size(109, 29);
            this.insertCityCases.TabIndex = 54;
            this.insertCityCases.Text = "INSERT";
            this.insertCityCases.UseVisualStyleBackColor = true;
            this.insertCityCases.Click += new System.EventHandler(this.insertCityCases_Click);
            // 
            // DeleteCityCases
            // 
            this.DeleteCityCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteCityCases.Location = new System.Drawing.Point(449, 347);
            this.DeleteCityCases.Name = "DeleteCityCases";
            this.DeleteCityCases.Size = new System.Drawing.Size(140, 36);
            this.DeleteCityCases.TabIndex = 53;
            this.DeleteCityCases.Text = "Delete Record";
            this.DeleteCityCases.UseVisualStyleBackColor = true;
            this.DeleteCityCases.Click += new System.EventHandler(this.DeleteCityCases_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(82, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 60;
            this.label4.Text = "Enter ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(82, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 63;
            this.label5.Text = "Dose No:";
            // 
            // dose_list
            // 
            this.dose_list.FormattingEnabled = true;
            this.dose_list.Items.AddRange(new object[] {
            "1",
            "2",
            "Booster"});
            this.dose_list.Location = new System.Drawing.Point(245, 290);
            this.dose_list.Name = "dose_list";
            this.dose_list.Size = new System.Drawing.Size(92, 17);
            this.dose_list.TabIndex = 64;
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(245, 115);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(166, 20);
            this.id_input.TabIndex = 65;
            // 
            // name_Input
            // 
            this.name_Input.Location = new System.Drawing.Point(245, 159);
            this.name_Input.Name = "name_Input";
            this.name_Input.Size = new System.Drawing.Size(166, 20);
            this.name_Input.TabIndex = 66;
            // 
            // age_Input
            // 
            this.age_Input.Location = new System.Drawing.Point(245, 201);
            this.age_Input.Name = "age_Input";
            this.age_Input.Size = new System.Drawing.Size(166, 20);
            this.age_Input.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(82, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 67;
            this.label6.Text = "Enter Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(82, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 69;
            this.label7.Text = "Vaccine Name:";
            // 
            // vaccine_Input
            // 
            this.vaccine_Input.Location = new System.Drawing.Point(245, 243);
            this.vaccine_Input.Name = "vaccine_Input";
            this.vaccine_Input.Size = new System.Drawing.Size(166, 20);
            this.vaccine_Input.TabIndex = 70;
            // 
            // vaccineStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CovidStatisticsTracker.Properties.Resources.App_BG;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.vaccine_Input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.age_Input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name_Input);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.dose_list);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.insertCityCases);
            this.Controls.Add(this.DeleteCityCases);
            this.Name = "vaccineStatusForm";
            this.Text = "vaccineStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button insertCityCases;
        private System.Windows.Forms.Button DeleteCityCases;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox dose_list;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.TextBox name_Input;
        private System.Windows.Forms.TextBox age_Input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vaccine_Input;
    }
}