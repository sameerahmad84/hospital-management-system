namespace HMS
{
    partial class ManageEmployee
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
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.EmpIDBox = new System.Windows.Forms.TextBox();
            this.EmpNameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneNoBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Location = new System.Drawing.Point(55, 410);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.RowTemplate.Height = 25;
            this.EmployeeGrid.Size = new System.Drawing.Size(873, 192);
            this.EmployeeGrid.TabIndex = 1;
            this.EmployeeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmpIDBox
            // 
            this.EmpIDBox.Location = new System.Drawing.Point(334, 107);
            this.EmpIDBox.Name = "EmpIDBox";
            this.EmpIDBox.Size = new System.Drawing.Size(100, 23);
            this.EmpIDBox.TabIndex = 2;
            // 
            // EmpNameBox
            // 
            this.EmpNameBox.Location = new System.Drawing.Point(334, 163);
            this.EmpNameBox.Name = "EmpNameBox";
            this.EmpNameBox.Size = new System.Drawing.Size(100, 23);
            this.EmpNameBox.TabIndex = 3;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(334, 213);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 23);
            this.EmailBox.TabIndex = 4;
            // 
            // PhoneNoBox
            // 
            this.PhoneNoBox.Location = new System.Drawing.Point(334, 261);
            this.PhoneNoBox.Name = "PhoneNoBox";
            this.PhoneNoBox.Size = new System.Drawing.Size(100, 23);
            this.PhoneNoBox.TabIndex = 5;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(536, 107);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(157, 50);
            this.AddressBox.TabIndex = 6;
            // 
            // JobComboBox
            // 
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Location = new System.Drawing.Point(536, 184);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(157, 23);
            this.JobComboBox.TabIndex = 7;
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(536, 240);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(157, 23);
            this.SalaryBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employee Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Job Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Salary";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(507, 342);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(99, 37);
            this.RemoveButton.TabIndex = 21;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(334, 342);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 37);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(661, 342);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(99, 37);
            this.SearchButton.TabIndex = 23;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(874, 28);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 36);
            this.BackButton.TabIndex = 24;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 614);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.PhoneNoBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.EmpNameBox);
            this.Controls.Add(this.EmpIDBox);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.label1);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView EmployeeGrid;
        private TextBox EmpIDBox;
        private TextBox EmpNameBox;
        private TextBox EmailBox;
        private TextBox PhoneNoBox;
        private TextBox AddressBox;
        private ComboBox JobComboBox;
        private TextBox SalaryBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button RemoveButton;
        private Button UpdateButton;
        private Button SearchButton;
        private Button BackButton;
    }
}