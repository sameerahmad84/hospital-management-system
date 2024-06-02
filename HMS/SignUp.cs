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
using System.Xml;
using System.Xml.Linq;

namespace HMS
{
    public partial class SignUp : Form
    {
        public static SignUp instance;
        public string ID,User, Password, Role;
        public SignUp()
        {
            InitializeComponent();
            instance = this;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            RoleComboBox.Items.Add("Admin");
            RoleComboBox.Items.Add("Doctor");
            RoleComboBox.Items.Add("Patient");
        }

        private void ClearData()
        {
            UserNameBox.Text = "";
            PasswordBox.Text = "";
            RoleComboBox.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            object SelectedItem = RoleComboBox.SelectedItem;
            string Item = Convert.ToString(SelectedItem);
            if (UserNameBox.Text!=""&& PasswordBox.Text != "" && Item !="")
            {
                try
                {
                    string query = "Insert into Admins Values('" + UserNameBox.Text + "','" + PasswordBox.Text + "','" + Item + "')";
                    SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                    cnn.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully..");
                    User = UserNameBox.Text;
                    Password = PasswordBox.Text;
                    Role = Item;
                    if (Item=="Admin")
                    {
                        ClearData();
                        this.Hide();
                        new Login().Show();
                    }
                    else if (Item == "Doctor")
                    {
                        SqlCommand cmd = new SqlCommand("SELECT AccountID FROM Admins Where Username='" + UserNameBox.Text + "' AND Password='" + PasswordBox.Text + "' AND AccountRole='" + Item + "'", cnn);
                        ID = Convert.ToString(cmd.ExecuteScalar());
                        ClearData();
                        this.Hide();
                        new EmployeeInfo().Show();
                    }
                    else if (Item == "Patient")
                    {
                        SqlCommand cmd = new SqlCommand("SELECT AccountID FROM Admins Where Username='" + UserNameBox.Text + "' AND Password='" + PasswordBox.Text + "' AND AccountRole='" + Item + "'", cnn);
                        ID =Convert.ToString(cmd.ExecuteScalar());
                        new PatientInfo().Show();
                        ClearData();
                        this.Hide();
                    }
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
