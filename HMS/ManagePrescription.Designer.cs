namespace HMS
{
    partial class ManagePrescription
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
            this.PresButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FreqBox = new System.Windows.Forms.TextBox();
            this.DoseBox = new System.Windows.Forms.TextBox();
            this.MedNameBox = new System.Windows.Forms.TextBox();
            this.PatIDBox = new System.Windows.Forms.TextBox();
            this.PrescriptionGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PresIDBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(827, 218);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(99, 37);
            this.SearchButton.TabIndex = 67;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(306, 295);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 37);
            this.UpdateButton.TabIndex = 66;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(827, 285);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(99, 37);
            this.RemoveButton.TabIndex = 65;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // PresButton
            // 
            this.PresButton.Location = new System.Drawing.Point(152, 295);
            this.PresButton.Name = "PresButton";
            this.PresButton.Size = new System.Drawing.Size(99, 37);
            this.PresButton.TabIndex = 64;
            this.PresButton.Text = "ADD";
            this.PresButton.UseVisualStyleBackColor = true;
            this.PresButton.Click += new System.EventHandler(this.PresButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 62;
            this.label8.Text = "Frequency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Dosage";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Patient ID";
            // 
            // FreqBox
            // 
            this.FreqBox.Location = new System.Drawing.Point(152, 226);
            this.FreqBox.Name = "FreqBox";
            this.FreqBox.Size = new System.Drawing.Size(168, 23);
            this.FreqBox.TabIndex = 55;
            // 
            // DoseBox
            // 
            this.DoseBox.Location = new System.Drawing.Point(438, 173);
            this.DoseBox.Name = "DoseBox";
            this.DoseBox.Size = new System.Drawing.Size(168, 23);
            this.DoseBox.TabIndex = 54;
            // 
            // MedNameBox
            // 
            this.MedNameBox.Location = new System.Drawing.Point(152, 173);
            this.MedNameBox.Name = "MedNameBox";
            this.MedNameBox.Size = new System.Drawing.Size(168, 23);
            this.MedNameBox.TabIndex = 53;
            // 
            // PatIDBox
            // 
            this.PatIDBox.Location = new System.Drawing.Point(152, 121);
            this.PatIDBox.Name = "PatIDBox";
            this.PatIDBox.Size = new System.Drawing.Size(168, 23);
            this.PatIDBox.TabIndex = 51;
            // 
            // PrescriptionGrid
            // 
            this.PrescriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptionGrid.Location = new System.Drawing.Point(69, 357);
            this.PrescriptionGrid.Name = "PrescriptionGrid";
            this.PrescriptionGrid.RowTemplate.Height = 25;
            this.PrescriptionGrid.Size = new System.Drawing.Size(810, 198);
            this.PrescriptionGrid.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(371, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 36);
            this.label1.TabIndex = 48;
            this.label1.Text = "Prescriptions Detail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 68;
            this.label7.Text = "Medication Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 69;
            this.label9.Text = "Duration";
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(438, 121);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(168, 23);
            this.DurationBox.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "Prescription ID";
            // 
            // PresIDBox
            // 
            this.PresIDBox.Location = new System.Drawing.Point(827, 121);
            this.PresIDBox.Name = "PresIDBox";
            this.PresIDBox.Size = new System.Drawing.Size(112, 23);
            this.PresIDBox.TabIndex = 71;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 577);
            this.splitter1.TabIndex = 73;
            this.splitter1.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(880, 30);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 36);
            this.BackButton.TabIndex = 74;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManagePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 577);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PresIDBox);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.PresButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FreqBox);
            this.Controls.Add(this.DoseBox);
            this.Controls.Add(this.MedNameBox);
            this.Controls.Add(this.PatIDBox);
            this.Controls.Add(this.PrescriptionGrid);
            this.Controls.Add(this.label1);
            this.Name = "ManagePrescription";
            this.Text = "ManagePrescription";
            this.Load += new System.EventHandler(this.ManagePrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SearchButton;
        private Button UpdateButton;
        private Button RemoveButton;
        private Button PresButton;
        private Label label8;
        private Label label6;
        private Label label3;
        private TextBox FreqBox;
        private TextBox DoseBox;
        private TextBox MedNameBox;
        private TextBox PatIDBox;
        private DataGridView PrescriptionGrid;
        private Label label1;
        private Label label7;
        private Label label9;
        private TextBox DurationBox;
        private Label label2;
        private TextBox PresIDBox;
        private Splitter splitter1;
        private Button BackButton;
    }
}