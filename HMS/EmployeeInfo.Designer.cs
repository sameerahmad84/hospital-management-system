namespace HMS
{
    partial class EmployeeInfo
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
            this.ADDButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DOBCalendar = new System.Windows.Forms.MonthCalendar();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.PhoneNoBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.EmpNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ADDButton
            // 
            this.ADDButton.Location = new System.Drawing.Point(205, 324);
            this.ADDButton.Name = "ADDButton";
            this.ADDButton.Size = new System.Drawing.Size(99, 37);
            this.ADDButton.TabIndex = 44;
            this.ADDButton.Text = "ADD";
            this.ADDButton.UseVisualStyleBackColor = true;
            this.ADDButton.Click += new System.EventHandler(this.ADDButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Job Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Employee Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Employee Name";
            // 
            // DOBCalendar
            // 
            this.DOBCalendar.Location = new System.Drawing.Point(418, 72);
            this.DOBCalendar.Name = "DOBCalendar";
            this.DOBCalendar.TabIndex = 34;
            // 
            // JobComboBox
            // 
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Location = new System.Drawing.Point(205, 257);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(157, 23);
            this.JobComboBox.TabIndex = 31;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(205, 180);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(157, 50);
            this.AddressBox.TabIndex = 30;
            // 
            // PhoneNoBox
            // 
            this.PhoneNoBox.Location = new System.Drawing.Point(205, 138);
            this.PhoneNoBox.Name = "PhoneNoBox";
            this.PhoneNoBox.Size = new System.Drawing.Size(100, 23);
            this.PhoneNoBox.TabIndex = 29;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(205, 90);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 23);
            this.EmailBox.TabIndex = 28;
            // 
            // EmpNameBox
            // 
            this.EmpNameBox.Location = new System.Drawing.Point(206, 45);
            this.EmpNameBox.Name = "EmpNameBox";
            this.EmpNameBox.Size = new System.Drawing.Size(100, 23);
            this.EmpNameBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, -63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Employee Details";
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 413);
            this.Controls.Add(this.ADDButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DOBCalendar);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.PhoneNoBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.EmpNameBox);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeInfo";
            this.Text = "EmployeeInfo";
            this.Load += new System.EventHandler(this.EmployeeInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ADDButton;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private MonthCalendar DOBCalendar;
        private ComboBox JobComboBox;
        private TextBox AddressBox;
        private TextBox PhoneNoBox;
        private TextBox EmailBox;
        private TextBox EmpNameBox;
        private Label label1;
    }
}