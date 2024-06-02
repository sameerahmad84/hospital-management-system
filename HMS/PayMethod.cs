using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class PayMethod : Form
    {
        public PayMethod()
        {
            InitializeComponent();
        }

        private void PrintBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string PayID=default, PatID = default, PayAmount = default, PayDate = default;
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            string Query = "SELECT TOP 1 * FROM Payments WHERE PatientID = "+PatientDashboard.instance.ID+" ORDER BY Payment_Date_Time DESC;";
            cnn.Open();
            SqlCommand cmd = new(Query, cnn);
            SqlDataReader Rdata = cmd.ExecuteReader();
            while (Rdata.Read())
            {
                PayID = Rdata[0].ToString();
                PatID = Rdata[1].ToString();
                PayDate = Rdata[2].ToString();
                PayAmount = Rdata[3].ToString();
            }
            e.Graphics.DrawString("                          HMS                                              ", new Font("Arial", 36),new SolidBrush(Color.Black),0,0);
            e.Graphics.DrawString("                                                                                               ", new Font("Arial", 16), new SolidBrush(Color.Black), 0, 100);
            e.Graphics.DrawString("                Payment ID                                    " +PayID + "", new Font("Arial", 16), new SolidBrush(Color.Black), 0, 150);
            e.Graphics.DrawString("                                                                                               ", new Font("Arial", 16), new SolidBrush(Color.Black), 0, 200);
            e.Graphics.DrawString("                Patient ID                                      " + PatID + "", new Font("Arial", 16), new SolidBrush(Color.Black), 0, 250);
            e.Graphics.DrawString("                                                                                               ", new Font("Arial", 16), new SolidBrush(Color.Black), 0, 300);
            e.Graphics.DrawString("                Date                                             " + PayDate + "", new Font("Arial", 16), new SolidBrush(Color.Black), 0, 350);
            e.Graphics.DrawString("                                                                                               ", new Font("Arial", 16), new SolidBrush(Color.Black), 0, 400);
            e.Graphics.DrawString("                Amount                                      " + PayAmount + "", new Font("Arial", 16), new SolidBrush(Color.Black), 0, 450);
        }

        private void CashButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            string query = "INSERT INTO Payments (PatientID, Payment_Date_Time, Payment_Amount, Payment_Type, isPaid) SELECT Appointment.PatientID, GETDATE(), CASE Appointment.Appointment_Type    WHEN 'Emergency Appointment' THEN 100    WHEN 'Routine Appointment' THEN 50    WHEN 'Minor Illness Appointment' THEN 75    WHEN 'Telephone Appointment' THEN 30 END, Appointment.Appointment_Type, 0 FROM Appointments Appointment WHERE Appointment.PatientID ="+PatientDashboard.instance.ID+"";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            PreviewBill.Document = PrintBill;
            PreviewBill.Show();
            this.Hide();
            new PatientDashboard().Show();
        }

        private void PreviewBill_Load(object sender, EventArgs e)
        {

        }

        private void CreditButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            string query = "INSERT INTO Payments (PatientID, Payment_Date_Time, Payment_Amount, Payment_Type, isPaid) SELECT Appointment.PatientID, GETDATE(), CASE Appointment.Appointment_Type    WHEN 'Emergency Appointment' THEN 100    WHEN 'Routine Appointment' THEN 50    WHEN 'Minor Illness Appointment' THEN 75    WHEN 'Telephone Appointment' THEN 30 END, Appointment.Appointment_Type, 1 FROM Appointments Appointment WHERE Appointment.PatientID =" + PatientDashboard.instance.ID + "";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.SelectCommand.ExecuteNonQuery();
            cnn.Close();
            this.Hide();
            new PaymentCredit().Show();
        }
    }
}
