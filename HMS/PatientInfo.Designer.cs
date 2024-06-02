namespace HMS
{
    partial class PatientInfo
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
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DOBCalendar = new System.Windows.Forms.MonthCalendar();
            this.HistoryBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.PhoneNoBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PatNameBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 57;
            this.label10.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "Medical History";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Patient Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Patient Name";
            // 
            // DOBCalendar
            // 
            this.DOBCalendar.Location = new System.Drawing.Point(467, 186);
            this.DOBCalendar.Name = "DOBCalendar";
            this.DOBCalendar.TabIndex = 50;
            // 
            // HistoryBox
            // 
            this.HistoryBox.Location = new System.Drawing.Point(467, 91);
            this.HistoryBox.Multiline = true;
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(227, 69);
            this.HistoryBox.TabIndex = 49;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(189, 232);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(157, 84);
            this.AddressBox.TabIndex = 48;
            // 
            // PhoneNoBox
            // 
            this.PhoneNoBox.Location = new System.Drawing.Point(189, 183);
            this.PhoneNoBox.Name = "PhoneNoBox";
            this.PhoneNoBox.Size = new System.Drawing.Size(157, 23);
            this.PhoneNoBox.TabIndex = 47;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(189, 135);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(157, 23);
            this.EmailBox.TabIndex = 46;
            // 
            // PatNameBox
            // 
            this.PatNameBox.Location = new System.Drawing.Point(189, 88);
            this.PatNameBox.Name = "PatNameBox";
            this.PatNameBox.Size = new System.Drawing.Size(157, 23);
            this.PatNameBox.TabIndex = 45;
            this.PatNameBox.TextChanged += new System.EventHandler(this.PatNameBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(189, 381);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(105, 35);
            this.SubmitButton.TabIndex = 58;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 440);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DOBCalendar);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.PhoneNoBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PatNameBox);
            this.Name = "PatientInfo";
            this.Text = "PatientInfo";
            this.Load += new System.EventHandler(this.PatientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private MonthCalendar DOBCalendar;
        private TextBox HistoryBox;
        private TextBox AddressBox;
        private TextBox PhoneNoBox;
        private TextBox EmailBox;
        private TextBox PatNameBox;
        private Button SubmitButton;
    }
}