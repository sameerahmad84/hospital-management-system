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
    public partial class ManagePatients : Form
    {
        public ManagePatients()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            string connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Patients", connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Patients");
            PatientGrid.DataSource = ds.Tables["Patients"].DefaultView;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (PatIDBox.Text != "" && PatNameBox.Text != "" && EmailBox.Text != "" && PhoneNoBox.Text != "" && AddressBox.Text != "" && HistoryBox.Text != "")
            {
                try
                {
                    string query = "UPDATE Patients SET Name = '" + PatNameBox.Text + "' , Email='" + EmailBox.Text + "' , Phone_Number='" + PhoneNoBox.Text + "' ,Address='" + AddressBox.Text + "' WHERE PatientID=" + PatIDBox.Text + ";";
                    SqlCommand da = new SqlCommand(query, cnn);
                    da.ExecuteNonQuery();
                    LoadData();
                    PatIDBox.Text = "";
                    PatNameBox.Text = "";
                    EmailBox.Text = "";
                    PhoneNoBox.Text = "";
                    EmailBox.Text = "";
                    PhoneNoBox.Text = "";
                    AddressBox.Text = "";
                    HistoryBox.Text = "";
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

        private void ManagePatients_Load(object sender, EventArgs e)
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

        private void PatNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            string Query = "SELECT * FROM Patients Where PatientID=" + PatIDBox.Text + "";
            cnn.Open();
            SqlCommand cmd = new(Query, cnn);
            SqlDataReader Rdata = cmd.ExecuteReader();
            if (Rdata.HasRows)
                while (Rdata.Read())
                {
                    PatNameBox.Text = Rdata[2].ToString();
                    PhoneNoBox.Text = Rdata[3].ToString();
                    AddressBox.Text = Rdata[4].ToString();
                    HistoryBox.Text = Rdata[6].ToString();
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
            if (PatIDBox.Text != "")
            {
                try
                {
                    string Query = "SELECT * FROM Patients Where PatientID=" + PatIDBox.Text + "";
                    SqlCommand cmd = new(Query, cnn);
                    SqlDataReader Rdata = cmd.ExecuteReader();

                    if (Rdata.HasRows)
                    {
                        string QueryN = "Delete FROM Patients Where PatientID=" + PatIDBox.Text + "";
                        SqlCommand Exec = new SqlCommand(QueryN, cnn1);
                        Exec.ExecuteNonQuery();
                        LoadData();
                        PatIDBox.Text = "";
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
