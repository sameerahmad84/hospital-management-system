using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class DoctorDashboard : Form
    {
        public static DoctorDashboard instance;
        public string user, pass, role, ID, Name;

        private void CheckSalaryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CheckSalary().Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void ManagePresButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagePrescription().Show();
        }

        public DoctorDashboard()
        {
            InitializeComponent();
            instance = this;
        }

        private void CheckAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CheckAppointment().Show();
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            if (Login.instance.flag)
            {
                user = SignUp.instance.User;
                pass = SignUp.instance.Password;
                role = SignUp.instance.Role;
            }
            else
            {
                user = Login.instance.User;
                pass = Login.instance.Password;
                role = Login.instance.Role;
            }
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            string Query = "SELECT E.* FROM Employees E INNER JOIN Admins A ON E.AccountID = A.AccountID WHERE A.Username = '" + user + "' AND A.Password='" + pass + "' AND AccountRole='" + role + "'";
            cnn.Open();
            SqlCommand cmd = new(Query, cnn);
            SqlDataReader Rdata = cmd.ExecuteReader();
            while (Rdata.Read())
            {
                ID = Rdata[0].ToString();   //1. row, 1. column
                Name = Rdata[1].ToString();   //1. row, 2. column
            }
            cnn.Close();
        }
    }
}
