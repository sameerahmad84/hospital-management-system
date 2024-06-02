namespace HMS
{
    partial class AdminDashboard
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
            this.ManageEmpButton = new System.Windows.Forms.Button();
            this.ManagePatButton = new System.Windows.Forms.Button();
            this.ManagePresButton = new System.Windows.Forms.Button();
            this.ManageSalaryButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageEmpButton
            // 
            this.ManageEmpButton.Location = new System.Drawing.Point(330, 29);
            this.ManageEmpButton.Name = "ManageEmpButton";
            this.ManageEmpButton.Size = new System.Drawing.Size(141, 64);
            this.ManageEmpButton.TabIndex = 0;
            this.ManageEmpButton.Text = "Manage Employees";
            this.ManageEmpButton.UseVisualStyleBackColor = true;
            this.ManageEmpButton.Click += new System.EventHandler(this.ManageEmpButton_Click);
            // 
            // ManagePatButton
            // 
            this.ManagePatButton.Location = new System.Drawing.Point(330, 139);
            this.ManagePatButton.Name = "ManagePatButton";
            this.ManagePatButton.Size = new System.Drawing.Size(141, 64);
            this.ManagePatButton.TabIndex = 2;
            this.ManagePatButton.Text = "Manage Patients";
            this.ManagePatButton.UseVisualStyleBackColor = true;
            this.ManagePatButton.Click += new System.EventHandler(this.ManagePatButton_Click);
            // 
            // ManagePresButton
            // 
            this.ManagePresButton.Location = new System.Drawing.Point(330, 253);
            this.ManagePresButton.Name = "ManagePresButton";
            this.ManagePresButton.Size = new System.Drawing.Size(141, 64);
            this.ManagePresButton.TabIndex = 3;
            this.ManagePresButton.Text = "Manage Prescriptions";
            this.ManagePresButton.UseVisualStyleBackColor = true;
            this.ManagePresButton.Click += new System.EventHandler(this.ManagePresButton_Click);
            // 
            // ManageSalaryButton
            // 
            this.ManageSalaryButton.Location = new System.Drawing.Point(330, 357);
            this.ManageSalaryButton.Name = "ManageSalaryButton";
            this.ManageSalaryButton.Size = new System.Drawing.Size(141, 64);
            this.ManageSalaryButton.TabIndex = 5;
            this.ManageSalaryButton.Text = "Manage Salary";
            this.ManageSalaryButton.UseVisualStyleBackColor = true;
            this.ManageSalaryButton.Click += new System.EventHandler(this.ManageSalaryButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(50, 368);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(98, 43);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ManageSalaryButton);
            this.Controls.Add(this.ManagePresButton);
            this.Controls.Add(this.ManagePatButton);
            this.Controls.Add(this.ManageEmpButton);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ManageEmpButton;
        private Button ManagePatButton;
        private Button ManagePresButton;
        private Button ManageSalaryButton;
        private Button LogOutButton;
    }
}