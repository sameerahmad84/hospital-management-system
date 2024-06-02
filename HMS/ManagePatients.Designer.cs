namespace HMS
{
    partial class ManagePatients
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PatNameBox = new System.Windows.Forms.TextBox();
            this.PatIDBox = new System.Windows.Forms.TextBox();
            this.PatientGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneNoBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HistoryBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(654, 228);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(99, 37);
            this.SearchButton.TabIndex = 47;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(168, 292);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 37);
            this.UpdateButton.TabIndex = 46;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(653, 174);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(99, 37);
            this.RemoveButton.TabIndex = 45;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Patient Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Patient ID";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(168, 177);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 23);
            this.EmailBox.TabIndex = 28;
            // 
            // PatNameBox
            // 
            this.PatNameBox.Location = new System.Drawing.Point(168, 127);
            this.PatNameBox.Name = "PatNameBox";
            this.PatNameBox.Size = new System.Drawing.Size(100, 23);
            this.PatNameBox.TabIndex = 27;
            this.PatNameBox.TextChanged += new System.EventHandler(this.PatNameBox_TextChanged);
            // 
            // PatIDBox
            // 
            this.PatIDBox.Location = new System.Drawing.Point(653, 127);
            this.PatIDBox.Name = "PatIDBox";
            this.PatIDBox.Size = new System.Drawing.Size(100, 23);
            this.PatIDBox.TabIndex = 26;
            // 
            // PatientGrid
            // 
            this.PatientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGrid.Location = new System.Drawing.Point(64, 361);
            this.PatientGrid.Name = "PatientGrid";
            this.PatientGrid.RowTemplate.Height = 25;
            this.PatientGrid.Size = new System.Drawing.Size(665, 192);
            this.PatientGrid.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Patient Details";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(676, 36);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 36);
            this.BackButton.TabIndex = 48;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Phone Number";
            // 
            // PhoneNoBox
            // 
            this.PhoneNoBox.Location = new System.Drawing.Point(168, 225);
            this.PhoneNoBox.Name = "PhoneNoBox";
            this.PhoneNoBox.Size = new System.Drawing.Size(100, 23);
            this.PhoneNoBox.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Medical History";
            // 
            // HistoryBox
            // 
            this.HistoryBox.Location = new System.Drawing.Point(392, 221);
            this.HistoryBox.Multiline = true;
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(157, 69);
            this.HistoryBox.TabIndex = 32;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(392, 127);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(157, 50);
            this.AddressBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Address";
            // 
            // ManagePatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 580);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.PhoneNoBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PatNameBox);
            this.Controls.Add(this.PatIDBox);
            this.Controls.Add(this.PatientGrid);
            this.Controls.Add(this.label1);
            this.Name = "ManagePatients";
            this.Text = "ManagePatients";
            this.Load += new System.EventHandler(this.ManagePatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SearchButton;
        private Button UpdateButton;
        private Button RemoveButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox EmailBox;
        private TextBox PatNameBox;
        private TextBox PatIDBox;
        private DataGridView PatientGrid;
        private Label label1;
        private Button BackButton;
        private Label label5;
        private TextBox PhoneNoBox;
        private Label label8;
        private TextBox HistoryBox;
        private TextBox AddressBox;
        private Label label6;
    }
}