using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class BookAppointment : Form
    {
        public string ID;
        public BookAppointment()
        {
            InitializeComponent();
                ID = PatientDashboard.instance.ID;
            
        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            string profile_path = Path.GetFullPath(System.Reflection.Assembly.GetExecutingAssembly().Location + @"\..\..\..\..\..\Media\");
            BackButton.Image = Image.FromFile(profile_path+"back.png").GetThumbnailImage(32, 32, null, IntPtr.Zero);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BackButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            AppointComboBox.Items.Add("Emergency Appointment");
            AppointComboBox.Items.Add("Routine Appointment");
            AppointComboBox.Items.Add("Minor Illness");
            AppointComboBox.Items.Add("Telephone Appointment");

            string connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT EmployeeID as DoctorID,Name,Job_Title as Designation FROM Employees Where Job_Title='Doctor'", connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");
            DoctorGrid.DataSource = ds.Tables["Employees"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            object SelectedItem = AppointComboBox.SelectedItem;
            string Item = Convert.ToString(SelectedItem);
            if (DocIDBox.Text != "" && Item != "")
            {
                try
                {
                    string query = "Insert into Appointments Values(" + ID + "," + DocIDBox.Text + ",'" + AppointCalendar.SelectionRange.Start.ToShortDateString() + "','" + Item + "')";
                    SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                    MessageBox.Show(query);
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientDashboard().Show();
        }
    }
}
