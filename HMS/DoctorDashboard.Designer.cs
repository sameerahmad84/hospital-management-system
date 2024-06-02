namespace HMS
{
    partial class DoctorDashboard
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
            this.CheckSalaryButton = new System.Windows.Forms.Button();
            this.ManagePresButton = new System.Windows.Forms.Button();
            this.CheckAppointmentButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckSalaryButton
            // 
            this.CheckSalaryButton.Location = new System.Drawing.Point(330, 295);
            this.CheckSalaryButton.Name = "CheckSalaryButton";
            this.CheckSalaryButton.Size = new System.Drawing.Size(141, 64);
            this.CheckSalaryButton.TabIndex = 7;
            this.CheckSalaryButton.Text = "Check Salary";
            this.CheckSalaryButton.UseVisualStyleBackColor = true;
            this.CheckSalaryButton.Click += new System.EventHandler(this.CheckSalaryButton_Click);
            // 
            // ManagePresButton
            // 
            this.ManagePresButton.Location = new System.Drawing.Point(330, 175);
            this.ManagePresButton.Name = "ManagePresButton";
            this.ManagePresButton.Size = new System.Drawing.Size(141, 64);
            this.ManagePresButton.TabIndex = 6;
            this.ManagePresButton.Text = "Manage Prescription";
            this.ManagePresButton.UseVisualStyleBackColor = true;
            this.ManagePresButton.Click += new System.EventHandler(this.ManagePresButton_Click);
            // 
            // CheckAppointmentButton
            // 
            this.CheckAppointmentButton.Location = new System.Drawing.Point(330, 60);
            this.CheckAppointmentButton.Name = "CheckAppointmentButton";
            this.CheckAppointmentButton.Size = new System.Drawing.Size(141, 64);
            this.CheckAppointmentButton.TabIndex = 5;
            this.CheckAppointmentButton.Text = "Check Appointments";
            this.CheckAppointmentButton.UseVisualStyleBackColor = true;
            this.CheckAppointmentButton.Click += new System.EventHandler(this.CheckAppointmentButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(39, 376);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(98, 43);
            this.LogOutButton.TabIndex = 8;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.CheckSalaryButton);
            this.Controls.Add(this.ManagePresButton);
            this.Controls.Add(this.CheckAppointmentButton);
            this.Name = "DoctorDashboard";
            this.Text = "DoctorDashboard";
            this.Load += new System.EventHandler(this.DoctorDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CheckSalaryButton;
        private Button ManagePresButton;
        private Button CheckAppointmentButton;
        private Button LogOutButton;
    }
}