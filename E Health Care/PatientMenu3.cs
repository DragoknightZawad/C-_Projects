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
    public partial class PatientMenu3 : Form
    {
        
        public PatientMenu3()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-9GE5GMB;Initial Catalog=E Health Care;Integrated Security=True";
        private PatientMenu4 d;


        private void locationlbl_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonEllipse1_Click(object sender, EventArgs e)
        {

            d = new PatientMenu4();
            this.Close();
            d.Show();
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            SqlDataAdapter sqlda = new SqlDataAdapter("SElECT * FROM DoctorInfo", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            d.Doctorinfoview.DataSource = dtbl;


        }

        private void buttonEllipse2_Click(object sender, EventArgs e)
        {
            d = new PatientMenu4();
            this.Close();
            d.Show();
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            SqlDataAdapter sqlda = new SqlDataAdapter("SElECT * FROM DoctorInfo", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            d.Doctorinfoview.DataSource = dtbl;

        }

        private void buttonEllipse3_Click(object sender, EventArgs e)
        {
            d = new PatientMenu4();
            this.Close();
            d.Show();
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            SqlDataAdapter sqlda = new SqlDataAdapter("SElECT * FROM DoctorInfot", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            d.Doctorinfoview.DataSource = dtbl;
        }

        private void buttonEllipse4_Click(object sender, EventArgs e)
        {
            d = new PatientMenu4();
            this.Close();
            d.Show();
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            SqlDataAdapter sqlda = new SqlDataAdapter("SElECT * FROM DoctorInfo", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            d.Doctorinfoview.DataSource = dtbl;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            PatientMenu2 o = new PatientMenu2();
            this.Close();
            o.Show();

        }
    }
}
