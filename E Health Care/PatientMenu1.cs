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
namespace E_Health_Care
{
    public partial class PatientMenu1 : Form
    {
        public PatientMenu1()
        {
            InitializeComponent();
        }
        
        public string conString = "Data Source=DESKTOP-9GE5GMB;Initial Catalog=E Health Care;Integrated Security=True";
        private void Patientsignupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientSignup m2 = new PatientSignup();
            m2.Show();
        }

        private void BackPatient1toMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m1 = new MainMenu();
            m1.Show();
        }

        public void Patientloginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string sql = "SELECT * from Patients Where Patient_ID = '" + Patientidtxt.Text.Trim() + "'and Password = '" + Doctorpasswordtxt.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                PatientMenu2 p2 = new PatientMenu2();
                this.Hide();
                p2.Show();
            }
            else
            {
                MessageBox.Show("Check your User Name and Password", "E Health Care");
            }
        }
    }
}
