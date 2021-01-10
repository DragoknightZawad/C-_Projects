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
using System.Collections;

namespace E_Health_Care
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-9GE5GMB;Initial Catalog=E Health Care;Integrated Security=True";

        private void Requestschedulebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);



            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                using (SqlCommand com = new SqlCommand("UPDATE Appointments   SET Schedule=@schedule   WHERE Patient_ID=@ID", con))
                {
                    com.Parameters.AddWithValue("@ID", textBox1.Text);


                    com.Parameters.AddWithValue("@schedule", Requestappointmentdatetime.Value);

                    com.ExecuteNonQuery();

                }
                using (SqlCommand com = new SqlCommand("UPDATE Appointments   SET Doctor_ID=@did   WHERE Patient_ID=@ID", con))
                {
                    com.Parameters.AddWithValue("@ID", textBox1.Text);


                    com.Parameters.AddWithValue("@did", DoctorIDtxt.Text);

                    com.ExecuteNonQuery();
                    MessageBox.Show("Your request for appointment has been inserted,click refresh to check if it has been accepted", "E Health Care");
                }
            }
            else
            {
                MessageBox.Show("Check your Connection", "E Health Care");
            }

        }

        private void Refreshschedulebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();



            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Appointments  " , con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                       



                        SqlDataAdapter sqlda = new SqlDataAdapter("select * from Appointments where Patient_ID='"+textBox1.Text+"' and Doctor_ID ='"+DoctorIDtxt.Text+"'", con);
                        DataTable dtbl = new DataTable();
                        sqlda.Fill(dtbl);
                        Scheduleview.DataSource = dtbl;








                        //Add Row




                    }



                    
                }

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            PatientMenu4 ij = new PatientMenu4();
            ij.Close();
            this.Close();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mu = new MainMenu();
            mu.Show();
            this.Close();
        }
    }
}

      

    

        


