using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class Login : Form
    {
        public static Login instance;
        public string ID,User, Password, Role;
        public bool flag = true;
        public Login()
        {
            InitializeComponent();
            instance=this;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            RoleComboBox.Items.Add("Admin");
            RoleComboBox.Items.Add("Doctor");
            RoleComboBox.Items.Add("Patient");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            object SelectedItem = RoleComboBox.SelectedItem;
            string Item = Convert.ToString(SelectedItem);
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Admins WHERE Username='" + UserNameBox.Text + "' AND Password='" + PasswordBox.Text + "' AND AccountRole='"+ Item +"'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                User = UserNameBox.Text;
                Password=PasswordBox.Text;
                Role = Item;
                SqlCommand cmd = new SqlCommand("SELECT AccountID FROM Admins Where Username='" + UserNameBox.Text + "' AND Password='" + PasswordBox.Text + "' AND AccountRole='" + Item + "'", cnn);
                ID = Convert.ToString(cmd.ExecuteScalar());
                if (Item == "Admin")
                {
                    flag=false;
                    this.Hide();
                    new AdminDashboard().Show();
                    cnn.Close();
                }
                else if (Item == "Doctor")
                {
                    flag = false;
                    this.Hide();
                    new DoctorDashboard().Show();
                    cnn.Close();
                }
                else if (Item == "Patient")
                {
                    flag = false;
                    this.Hide();
                    new PatientDashboard().Show();
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("Please Select Role");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }
    }
}
