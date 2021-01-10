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
    public partial class DoctorMenu2 : Form
    {
        public DoctorMenu2()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-9GE5GMB;Initial Catalog=E Health Care;Integrated Security=True";

        private void Decisionbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);



            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                using (SqlCommand com = new SqlCommand("UPDATE Appointments SET Comment=@confirm WHERE Patient_ID=@ID", con))
                {
                    com.Parameters.AddWithValue("@ID", Patient_IDtxt.Text);

                  
                    if (Accept.Checked)
                    {
                        com.Parameters.AddWithValue("@confirm", "Accept");
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@confirm", "Denied");
                    }
                    com.ExecuteNonQuery();
                    MessageBox.Show("Your request for appointment has been inserted,click refresh to check if it has been accepted", "E Health Care");
                }

            }
            else
            {
                MessageBox.Show("Check your Connection", "E Health Care");
            }
        }

        private void ScheduleViewbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            SqlDataAdapter sqlda = new SqlDataAdapter("SElECT * FROM Appointments where Doctor_ID='"+doctid.Text+"'", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            Scheduleview.DataSource = dtbl;
        }

        private void buttonEllipse1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SElECT * FROM Appointments where Doctor_ID='" + doctid.Text + "'", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            Scheduleview.DataSource = dtbl;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DoctorMenu1 s = new DoctorMenu1();
            s.Show();
            this.Close();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu m1 = new MainMenu();
            m1.Show();
            this.Close();
        }
    }
}
