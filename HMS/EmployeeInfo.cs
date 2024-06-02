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
    public partial class EmployeeInfo : Form
    {
        public string ID;
        public EmployeeInfo()
        {
            InitializeComponent();
            ID=SignUp.instance.ID;
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            JobComboBox.Items.Add("Doctor");
        }

        private void ADDButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            object SelectedItem = JobComboBox.SelectedItem;
            string Item = Convert.ToString(SelectedItem);
            if (EmpNameBox.Text != "" && EmailBox.Text != "" && PhoneNoBox.Text != "" && AddressBox.Text != "" && Item != "")
            {
                try
                {
                    string query = "Insert into Employees Values('" + EmpNameBox.Text + "','" + EmailBox.Text + "','" + PhoneNoBox.Text + "','" + AddressBox.Text + "','" + Item + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DOBCalendar.SelectionRange.Start.ToShortDateString() + "'," +ID+ ")";  
                    SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                    cnn.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    this.Hide();
                    new DoctorDashboard().Show();
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
