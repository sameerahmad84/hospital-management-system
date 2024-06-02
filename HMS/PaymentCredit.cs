using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class PaymentCredit : Form
    {
        public PaymentCredit()
        {
            InitializeComponent();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if(CCNameBox.Text!=""&&CCNumberBox.Text!=""&& CVVBox.Text!="")
            {
                MessageBox.Show("Payment Done Successfully");
                this.Hide();
                new PatientDashboard().Show();
            }
            else
            {
                MessageBox.Show("Cannot Left Any Field Empty");
            }
        }

        private void PaymentCredit_Load(object sender, EventArgs e)
        {

        }
    }
}
