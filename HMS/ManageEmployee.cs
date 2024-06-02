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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        void LoadData()
        {
            string connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");
            EmployeeGrid.DataSource = ds.Tables["Employees"].DefaultView;
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            string profile_path = Path.GetFullPath(System.Reflection.Assembly.GetExecutingAssembly().Location + @"\..\..\..\..\..\Media\");
            BackButton.Image = Image.FromFile(profile_path + "back.png").GetThumbnailImage(32, 32, null, IntPtr.Zero);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BackButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            LoadData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (EmpIDBox.Text != "" && EmpNameBox.Text != "" && EmailBox.Text != "" && PhoneNoBox.Text != "" && AddressBox.Text != "" && JobComboBox.Text != "")
            {
                try
                {
                    string query = "UPDATE Employees SET Name = '" + EmpNameBox.Text + "' , Email='" + EmailBox.Text + "' , Phone_Number='" + PhoneNoBox.Text + "' ,Address='" + AddressBox.Text + "' ,Job_Title='" + JobComboBox.Text + "' WHERE EmployeeID=" + EmpIDBox.Text + ";";
                    SqlCommand da = new SqlCommand(query, cnn);
                    da.ExecuteNonQuery();
                    LoadData();
                    EmpIDBox.Text = "";
                    EmpNameBox.Text = "";
                    EmailBox.Text = "";
                    PhoneNoBox.Text = "";
                    AddressBox.Text = "";
                    JobComboBox.Text = "";
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            string Query = "SELECT * FROM Employees Where EmployeeID=" + EmpIDBox.Text + "";
            cnn.Open();
            SqlCommand cmd = new(Query, cnn);
            SqlDataReader Rdata = cmd.ExecuteReader();
            if (Rdata.HasRows)
                while (Rdata.Read())
                {
                    EmpIDBox.Text = Rdata[1].ToString();
                    EmpNameBox.Text = Rdata[2].ToString();
                    EmailBox.Text = Rdata[3].ToString();
                    PhoneNoBox.Text = Rdata[4].ToString();
                    AddressBox.Text = Rdata[5].ToString();
                    JobComboBox.Text = Rdata[6].ToString();
                }
            else
            {
                MessageBox.Show("Record Not Found");
            }
            cnn.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            SqlConnection cnn1;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn1 = new SqlConnection(connetionString);
            cnn.Open();
            cnn1.Open();
            if (EmpIDBox.Text != "")
            {
                try
                {
                    string Query = "SELECT * FROM Employees Where EmployeeID=" + EmpIDBox.Text + "";
                    SqlCommand cmd = new(Query, cnn);
                    SqlDataReader Rdata = cmd.ExecuteReader();

                    if (Rdata.HasRows)
                    {
                        string QueryN = "Delete from Employees Where EmployeeID=" + EmpIDBox.Text + "";
                        SqlCommand Exec = new SqlCommand(QueryN, cnn1);
                        Exec.ExecuteNonQuery();
                        LoadData();
                        EmpIDBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found");
                    }
                }
                catch
                {
                    MessageBox.Show("Error occured...");
                }
                finally
                {
                    cnn.Close();
                    cnn1.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Prescription ID");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }
    }
}
