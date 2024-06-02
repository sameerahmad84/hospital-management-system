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
    public partial class PatientInfo : Form
    {
        public static PatientInfo instance;
        public string ID,user, pass, role;
        public PatientInfo()
        {
            InitializeComponent();
        }

        private void PatNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            ID = SignUp.instance.ID;
            user = SignUp.instance.User;
            pass = SignUp.instance.Password;
            role = SignUp.instance.Role;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            if (PatNameBox.Text != "" && EmailBox.Text!="" && PhoneNoBox.Text!="" && AddressBox.Text!="" && HistoryBox.Text!="")
            {
                try
                {
                    string query = "Insert into Patients Values('" + PatNameBox.Text + "','" + EmailBox.Text + "','" + PhoneNoBox.Text + "','" + AddressBox.Text + "','" + DOBCalendar.SelectionRange.Start.ToShortDateString() + "','" + HistoryBox.Text + "','" + ID +  "')";
                    SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                    cnn.Open();
                    da.SelectCommand.ExecuteNonQuery();
                        this.Hide();
                        new PatientDashboard().Show();
                }
                catch
                {
                    MessageBox.Show("Error occured...");
                }
                finally
                {
                    cnn.Close();
                }
            }
            else
            {
                MessageBox.Show("You Cannot Left Any Field Empty");
            }
        }
    }
}
