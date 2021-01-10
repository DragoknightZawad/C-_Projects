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
    public partial class PatientMenu4 : Form
    {

        public PatientMenu4()
        {
            InitializeComponent();



        }
        public string conString = "Data Source=DESKTOP-9GE5GMB;Initial Catalog=E Health Care;Integrated Security=True";

        private PatientMenu1 d;

        private void Back_Click(object sender, EventArgs e)
        {
            PatientMenu3 p2 = new PatientMenu3();
            this.Close();
            p2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void ToAppointment_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);

            string sql = "SELECT * from DoctorInfo Where Doctor_ID = '" + Doctorid.Text.Trim() + "'";


            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                con.Open();

                Appointment ui = new Appointment();
                this.Close();
                ui.Show();

               
            }
            else
            {
                MessageBox.Show("Check your Connection", "E Health Care");
            }



        }
        }
    }


                    



           
    
    

