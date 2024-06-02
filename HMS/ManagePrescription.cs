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
    public partial class ManagePrescription : Form
    {
        public ManagePrescription()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ManagePrescription_Load(object sender, EventArgs e)
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Prescriptions WHERE DoctorID = " + DoctorDashboard.instance.ID + "", connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Prescriptions");
            PrescriptionGrid.DataSource = ds.Tables["Prescriptions"].DefaultView;
        }

        private void PresButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            if (PatIDBox.Text != "" && MedNameBox.Text != "" && FreqBox.Text != "" && DoseBox.Text != "" && DurationBox.Text != "")
            {
                try
                {
                    string query = "Insert into Prescriptions Values(" + PatIDBox.Text + "," + DoctorDashboard.instance.ID + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + MedNameBox.Text + "','" + DoseBox.Text + "','" + FreqBox.Text + "','" + DurationBox.Text + "')";
                    SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                    cnn.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    LoadData();
                    PatIDBox.Text = "";
                    MedNameBox.Text = "";
                    DoseBox.Text = "";
                    FreqBox.Text = "";
                    DurationBox.Text = "";
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
            if (PresIDBox.Text != "")
            {
                try
                {
                    string Query = "SELECT * FROM Prescriptions Where PrescriptionID=" + PresIDBox.Text + "";
                    SqlCommand cmd = new(Query, cnn);
                    SqlDataReader Rdata = cmd.ExecuteReader();
                    
                    if (Rdata.HasRows)
                    {
                        string QueryN = "Delete from Prescriptions Where PrescriptionID="+ PresIDBox.Text +"";
                        SqlCommand Exec = new SqlCommand(QueryN, cnn1);
                        Exec.ExecuteNonQuery();
                        LoadData();
                        PresIDBox.Text = "";
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            string Query = "SELECT * FROM Prescriptions Where PrescriptionID="+PresIDBox.Text+"";
            cnn.Open();
            SqlCommand cmd = new(Query, cnn);
            SqlDataReader Rdata = cmd.ExecuteReader();
            if(Rdata.HasRows)
            while (Rdata.Read())
            {
                PatIDBox.Text = Rdata[1].ToString();  
                MedNameBox.Text = Rdata[4].ToString();
                DoseBox.Text = Rdata[5].ToString();
                FreqBox.Text = Rdata[6].ToString();
                DurationBox.Text = Rdata[7].ToString();
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
            cnn.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if (PatIDBox.Text != "" && MedNameBox.Text != "" && FreqBox.Text != "" && DoseBox.Text != "" && DurationBox.Text != "")
            {
                try
                {
                    string query = "UPDATE Prescriptions SET PatientID ="+PatIDBox.Text+", Medication_Name = '"+MedNameBox.Text+"' , Dosage='"+DoseBox.Text+"' , Frequency='"+ FreqBox.Text +"' ,Duration='"+DurationBox.Text+"' WHERE PrescriptionID="+PresIDBox.Text+";";
                    SqlCommand da = new SqlCommand(query, cnn);
                    da.ExecuteNonQuery();
                    LoadData();
                    PatIDBox.Text = "";
                    MedNameBox.Text = "";
                    DoseBox.Text = "";
                    FreqBox.Text = "";
                    DurationBox.Text = "";
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
            new DoctorDashboard().Show();
        }
    }
}
