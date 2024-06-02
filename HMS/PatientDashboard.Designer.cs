namespace HMS
{
    partial class PatientDashboard
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
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.ViewPrescriptionButton = new System.Windows.Forms.Button();
            this.BookAppointmentButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(330, 292);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(141, 64);
            this.CheckoutButton.TabIndex = 6;
            this.CheckoutButton.Text = "Payment";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // ViewPrescriptionButton
            // 
            this.ViewPrescriptionButton.Location = new System.Drawing.Point(330, 184);
            this.ViewPrescriptionButton.Name = "ViewPrescriptionButton";
            this.ViewPrescriptionButton.Size = new System.Drawing.Size(141, 64);
            this.ViewPrescriptionButton.TabIndex = 5;
            this.ViewPrescriptionButton.Text = "View Prescription";
            this.ViewPrescriptionButton.UseVisualStyleBackColor = true;
            this.ViewPrescriptionButton.Click += new System.EventHandler(this.ViewPrescriptionButton_Click);
            // 
            // BookAppointmentButton
            // 
            this.BookAppointmentButton.Location = new System.Drawing.Point(330, 79);
            this.BookAppointmentButton.Name = "BookAppointmentButton";
            this.BookAppointmentButton.Size = new System.Drawing.Size(141, 64);
            this.BookAppointmentButton.TabIndex = 4;
            this.BookAppointmentButton.Text = "Book Appointment";
            this.BookAppointmentButton.UseVisualStyleBackColor = true;
            this.BookAppointmentButton.Click += new System.EventHandler(this.BookAppointmentButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(45, 370);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(98, 43);
            this.LogOutButton.TabIndex = 7;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // PatientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.ViewPrescriptionButton);
            this.Controls.Add(this.BookAppointmentButton);
            this.Name = "PatientDashboard";
            this.Text = "PatientDashboard";
            this.Load += new System.EventHandler(this.PatientDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CheckoutButton;
        private Button ViewPrescriptionButton;
        private Button BookAppointmentButton;
        private Button LogOutButton;
    }
}