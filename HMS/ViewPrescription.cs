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
    public partial class ViewPrescription : Form
    {
        public ViewPrescription()
        {
            InitializeComponent();
        }

        private void ViewPrescription_Load(object sender, EventArgs e)
        {
            string profile_path = Path.GetFullPath(System.Reflection.Assembly.GetExecutingAssembly().Location + @"\..\..\..\..\..\Media\");
            BackButton.Image = Image.FromFile(profile_path + "back.png").GetThumbnailImage(32, 32, null, IntPtr.Zero);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BackButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            string connetionString = "Data Source=NANI;Initial Catalog=HMS;User ID=HMS;Password=2021SE7;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Prescriptions WHERE PatientID="+PatientDashboard.instance.ID+"", connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Prescriptions");
            AppointGrid.DataSource = ds.Tables["Prescriptions"].DefaultView;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientDashboard().Show();
        }
    }
}
