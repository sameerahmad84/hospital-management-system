namespace HMS
{
    partial class ManageSalary
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.EmpIDBox = new System.Windows.Forms.TextBox();
            this.SalaryIDBox = new System.Windows.Forms.TextBox();
            this.SalaryGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ADDButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(691, 21);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 36);
            this.BackButton.TabIndex = 66;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(595, 213);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(99, 37);
            this.SearchButton.TabIndex = 65;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(272, 213);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 37);
            this.UpdateButton.TabIndex = 64;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(594, 159);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(99, 37);
            this.RemoveButton.TabIndex = 63;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "Salary ID";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(183, 162);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(210, 23);
            this.AmountBox.TabIndex = 53;
            // 
            // EmpIDBox
            // 
            this.EmpIDBox.Location = new System.Drawing.Point(183, 112);
            this.EmpIDBox.Name = "EmpIDBox";
            this.EmpIDBox.Size = new System.Drawing.Size(210, 23);
            this.EmpIDBox.TabIndex = 52;
            // 
            // SalaryIDBox
            // 
            this.SalaryIDBox.Location = new System.Drawing.Point(594, 112);
            this.SalaryIDBox.Name = "SalaryIDBox";
            this.SalaryIDBox.Size = new System.Drawing.Size(100, 23);
            this.SalaryIDBox.TabIndex = 51;
            // 
            // SalaryGrid
            // 
            this.SalaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryGrid.Location = new System.Drawing.Point(83, 308);
            this.SalaryGrid.Name = "SalaryGrid";
            this.SalaryGrid.RowTemplate.Height = 25;
            this.SalaryGrid.Size = new System.Drawing.Size(665, 192);
            this.SalaryGrid.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(325, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 49;
            this.label1.Text = "Salary Details";
            // 
            // ADDButton
            // 
            this.ADDButton.Location = new System.Drawing.Point(143, 213);
            this.ADDButton.Name = "ADDButton";
            this.ADDButton.Size = new System.Drawing.Size(99, 37);
            this.ADDButton.TabIndex = 67;
            this.ADDButton.Text = "ADD";
            this.ADDButton.UseVisualStyleBackColor = true;
            this.ADDButton.Click += new System.EventHandler(this.ADDButton_Click);
            // 
            // ManageSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 552);
            this.Controls.Add(this.ADDButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.EmpIDBox);
            this.Controls.Add(this.SalaryIDBox);
            this.Controls.Add(this.SalaryGrid);
            this.Controls.Add(this.label1);
            this.Name = "ManageSalary";
            this.Text = "ManageSalary";
            this.Load += new System.EventHandler(this.ManageSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackButton;
        private Button SearchButton;
        private Button UpdateButton;
        private Button RemoveButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox AmountBox;
        private TextBox EmpIDBox;
        private TextBox SalaryIDBox;
        private DataGridView SalaryGrid;
        private Label label1;
        private Button ADDButton;
    }
}