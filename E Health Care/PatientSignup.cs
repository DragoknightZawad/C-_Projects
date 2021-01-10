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
    public partial class PatientSignup : Form
    {
        public PatientSignup()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-9GE5GMB;Initial Catalog=E Health Care;Integrated Security=True";
        private void BackPatientSignuptoPatientMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMenu1 m1 = new PatientMenu1();
            m1.Show();
        }

        private void Patientsignupbtn2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string sql = "INSERT INTO Patients(Patient_ID,Patient_Name,Email,Nationality,Password,Birthdate,Contact_Number,Gender) VALUES(@id,@name,@email,@password,@nationality,@birthdate,@contact,@gender)";
            string sql1 = "INSERT INTO Appointments(Patient_ID) VALUES(@id)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    cmd.Parameters.Add("@id", SqlDbType.VarChar, 10).Value = PatientIDtxt.Text;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Patientsunametxt.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = Patientemailtxt.Text;
                    cmd.Parameters.Add("@nationality", SqlDbType.VarChar).Value = Patientnationalitytxt.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = Patientsupasswordtxt.Text;
                    cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = PatientBirthdate.Value;
                    cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value= Patientcontacttxt.Text;

                    if (Male.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Gender", "Male");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Gender", "Female");
                    }

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    using (SqlCommand cmd2 = new SqlCommand(sql1,con))
                    {

                        cmd2.Parameters.Add("@id", SqlDbType.VarChar, 10).Value = PatientIDtxt.Text;
                        cmd2.CommandType = CommandType.Text;
                        cmd2.ExecuteNonQuery();
                    }

                    MessageBox.Show("Signup has made successfully", "E Health Care");


                }
            }
        }
    }
}
