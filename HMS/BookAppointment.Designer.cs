namespace HMS
{
    partial class BookAppointment
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
            this.DocIDBox = new System.Windows.Forms.TextBox();
            this.AppointComboBox = new System.Windows.Forms.ComboBox();
            this.AppointCalendar = new System.Windows.Forms.MonthCalendar();
            this.DoctorGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SetAppButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DocIDBox
            // 
            this.DocIDBox.Location = new System.Drawing.Point(179, 42);
            this.DocIDBox.Name = "DocIDBox";
            this.DocIDBox.Size = new System.Drawing.Size(121, 23);
            this.DocIDBox.TabIndex = 0;
            // 
            // AppointComboBox
            // 
            this.AppointComboBox.FormattingEnabled = true;
            this.AppointComboBox.Location = new System.Drawing.Point(179, 107);
            this.AppointComboBox.Name = "AppointComboBox";
            this.AppointComboBox.Size = new System.Drawing.Size(121, 23);
            this.AppointComboBox.TabIndex = 2;
            // 
            // AppointCalendar
            // 
            this.AppointCalendar.Location = new System.Drawing.Point(179, 162);
            this.AppointCalendar.Name = "AppointCalendar";
            this.AppointCalendar.TabIndex = 3;
            // 
            // DoctorGrid
            // 
            this.DoctorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorGrid.Location = new System.Drawing.Point(418, 156);
            this.DoctorGrid.Name = "DoctorGrid";
            this.DoctorGrid.RowTemplate.Height = 25;
            this.DoctorGrid.Size = new System.Drawing.Size(335, 168);
            this.DoctorGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doctor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Appointment Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Appointment Date";
            // 
            // SetAppButton
            // 
            this.SetAppButton.Location = new System.Drawing.Point(179, 336);
            this.SetAppButton.Name = "SetAppButton";
            this.SetAppButton.Size = new System.Drawing.Size(121, 45);
            this.SetAppButton.TabIndex = 8;
            this.SetAppButton.Text = "Set Appointment";
            this.SetAppButton.UseVisualStyleBackColor = true;
            this.SetAppButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(643, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 36);
            this.BackButton.TabIndex = 9;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 403);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SetAppButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorGrid);
            this.Controls.Add(this.AppointCalendar);
            this.Controls.Add(this.AppointComboBox);
            this.Controls.Add(this.DocIDBox);
            this.Name = "BookAppointment";
            this.Text = "BookAppointment";
            this.Load += new System.EventHandler(this.BookAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox DocIDBox;
        private ComboBox AppointComboBox;
        private MonthCalendar AppointCalendar;
        private DataGridView DoctorGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button SetAppButton;
        private Button BackButton;
    }
}