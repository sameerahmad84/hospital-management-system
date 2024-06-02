namespace HMS
{
    partial class PayMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayMethod));
            this.CashButton = new System.Windows.Forms.Button();
            this.CreditButton = new System.Windows.Forms.Button();
            this.PrintBill = new System.Drawing.Printing.PrintDocument();
            this.PreviewBill = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // CashButton
            // 
            this.CashButton.Location = new System.Drawing.Point(141, 149);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(104, 35);
            this.CashButton.TabIndex = 0;
            this.CashButton.Text = "Cash";
            this.CashButton.UseVisualStyleBackColor = true;
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click);
            // 
            // CreditButton
            // 
            this.CreditButton.Location = new System.Drawing.Point(389, 149);
            this.CreditButton.Name = "CreditButton";
            this.CreditButton.Size = new System.Drawing.Size(104, 35);
            this.CreditButton.TabIndex = 1;
            this.CreditButton.Text = "Credit Card";
            this.CreditButton.UseVisualStyleBackColor = true;
            this.CreditButton.Click += new System.EventHandler(this.CreditButton_Click);
            // 
            // PrintBill
            // 
            this.PrintBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintBill_PrintPage);
            // 
            // PreviewBill
            // 
            this.PreviewBill.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PreviewBill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PreviewBill.ClientSize = new System.Drawing.Size(400, 300);
            this.PreviewBill.Enabled = true;
            this.PreviewBill.Icon = ((System.Drawing.Icon)(resources.GetObject("PreviewBill.Icon")));
            this.PreviewBill.Name = "PreviewBill";
            this.PreviewBill.Visible = false;
            this.PreviewBill.Load += new System.EventHandler(this.PreviewBill_Load);
            // 
            // PayMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 360);
            this.Controls.Add(this.CreditButton);
            this.Controls.Add(this.CashButton);
            this.Name = "PayMethod";
            this.Text = "PayMethod";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CashButton;
        private Button CreditButton;
        private System.Drawing.Printing.PrintDocument PrintBill;
        private PrintPreviewDialog PreviewBill;
    }
}