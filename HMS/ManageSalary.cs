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
    public partial class ManageSalary : Form
    {
        public ManageSalary()
        {
            InitializeComponent();
        }

        private void ManageSalary_Load(object sender, EventArgs e)
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

        void LoadData()
        {
            string connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Salary", connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Salary");
            SalaryGrid.DataSource = ds.Tables["Salary"].DefaultView;
        }

        private void ADDButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            if (EmpIDBox.Text != "" && AmountBox.Text != "")
            {
                try
                {
                    string query = "Insert into Salary Values(" + EmpIDBox.Text + "," + AmountBox.Text + ")";
                    SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                    cnn.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    LoadData();
                    EmpIDBox.Text = "";
                    AmountBox.Text = "";
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (SalaryIDBox.Text != "" && EmpIDBox.Text != "" && AmountBox.Text != "")
            {
                try
                {
                    string query = "UPDATE Salary SET EmployeeID = " + EmpIDBox.Text + " , Amount=" + AmountBox.Text + " WHERE SID=" + SalaryIDBox.Text + ";";
                    SqlCommand da = new SqlCommand(query, cnn);
                    da.ExecuteNonQuery();
                    LoadData();
                    SalaryIDBox.Text = "";
                    EmpIDBox.Text = "";
                    AmountBox.Text = "";
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
            if (SalaryIDBox.Text != "")
            {
                try
                {
                    string Query = "SELECT * FROM Salary Where SID=" + SalaryIDBox.Text + "";
                    SqlCommand cmd = new(Query, cnn);
                    SqlDataReader Rdata = cmd.ExecuteReader();

                    if (Rdata.HasRows)
                    {
                        string QueryN = "Delete FROM Salary Where SID=" + SalaryIDBox.Text + "";
                        SqlCommand Exec = new SqlCommand(QueryN, cnn1);
                        Exec.ExecuteNonQuery();
                        LoadData();
                        SalaryIDBox.Text = "";
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            string Query = "SELECT * FROM Salary Where SID=" + SalaryIDBox.Text + "";
            cnn.Open();
            SqlCommand cmd = new(Query, cnn);
            SqlDataReader Rdata = cmd.ExecuteReader();
            if (Rdata.HasRows)
                while (Rdata.Read())
                {
                    EmpIDBox.Text = Rdata[2].ToString();
                    AmountBox.Text = Rdata[3].ToString();
                }
            else
            {
                MessageBox.Show("Record Not Found");
            }
            cnn.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }
    }
}
