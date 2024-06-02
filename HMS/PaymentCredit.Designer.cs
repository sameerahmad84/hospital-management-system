namespace HMS
{
    partial class PaymentCredit
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
            this.PayButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PayCalendar = new System.Windows.Forms.MonthCalendar();
            this.CVVBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CCNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CCNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(370, 404);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(75, 23);
            this.PayButton.TabIndex = 17;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Expiration Date";
            // 
            // PayCalendar
            // 
            this.PayCalendar.Location = new System.Drawing.Point(346, 194);
            this.PayCalendar.Name = "PayCalendar";
            this.PayCalendar.TabIndex = 15;
            // 
            // CVVBox
            // 
            this.CVVBox.Location = new System.Drawing.Point(346, 147);
            this.CVVBox.Name = "CVVBox";
            this.CVVBox.Size = new System.Drawing.Size(95, 23);
            this.CVVBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "CVV Code";
            // 
            // CCNumberBox
            // 
            this.CCNumberBox.Location = new System.Drawing.Point(346, 84);
            this.CCNumberBox.Name = "CCNumberBox";
            this.CCNumberBox.Size = new System.Drawing.Size(156, 23);
            this.CCNumberBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Credit Card Number";
            // 
            // CCNameBox
            // 
            this.CCNameBox.Location = new System.Drawing.Point(346, 24);
            this.CCNameBox.Name = "CCNameBox";
            this.CCNameBox.Size = new System.Drawing.Size(156, 23);
            this.CCNameBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "CardHolder Name";
            // 
            // PaymentCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PayCalendar);
            this.Controls.Add(this.CVVBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CCNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CCNameBox);
            this.Controls.Add(this.label1);
            this.Name = "PaymentCredit";
            this.Text = "PaymentCredit";
            this.Load += new System.EventHandler(this.PaymentCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PayButton;
        private Label label4;
        private MonthCalendar PayCalendar;
        private TextBox CVVBox;
        private Label label3;
        private TextBox CCNumberBox;
        private Label label2;
        private TextBox CCNameBox;
        private Label label1;
    }
}