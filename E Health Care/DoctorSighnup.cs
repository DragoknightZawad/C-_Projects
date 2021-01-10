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
    public partial class DoctorSighnup : Form
    {
        public DoctorSighnup()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-9GE5GMB;Initial Catalog=E Health Care;Integrated Security=True";

        private void Doctorsignupbtn2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string sql = "INSERT INTO Doctor(Doctor_ID,Doctor_Name,Hospital,Email,Doctor_Password,Contact_Number,Qualification) VALUES(@id,@name,@hospital,@email,@password,@contact,@qualification)";
            string sql1 = "INSERT INTO DoctorInfo(Doctor_ID,Doctor_Name,Email,Contact_Number,Qualification) VALUES(@id,@name,@email,@contact,@qualification)";
          

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {



                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Doctoridtxt.Text;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Doctorname.Text;
                    cmd.Parameters.Add("@hospital", SqlDbType.VarChar).Value = Hospitalnametxt.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = Doctoremailtxt.Text;
                    cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = Doctorcontacttxt.Text;
                    cmd.Parameters.Add("@qualification", SqlDbType.VarChar).Value = qualificationtxt.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = Doctorsupasswordtxt.Text;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    using (SqlCommand cmd1 = new SqlCommand(sql1, con))
                    {

                        cmd1.Parameters.Add("@id", SqlDbType.VarChar).Value = Doctoridtxt.Text;
                        cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = Doctorname.Text;

                        cmd1.Parameters.Add("@email", SqlDbType.VarChar).Value = Doctoremailtxt.Text;
                        cmd1.Parameters.Add("@contact", SqlDbType.VarChar).Value = Doctorcontacttxt.Text;
                        cmd1.Parameters.Add("@qualification", SqlDbType.VarChar).Value = qualificationtxt.Text;


                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Doctor Sighnup has completed", "E Health Care");


                    }
                  
                }

            }


        }

        private void Back_Click(object sender, EventArgs e)
        {
            DoctorMenu1 uj = new DoctorMenu1();
            uj.Show();
            this.Close();
        }
    }
}




