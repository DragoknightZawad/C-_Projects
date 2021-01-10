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
    public partial class DoctorMenu1 : Form
    {
        public DoctorMenu1()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-9GE5GMB;Initial Catalog=E Health Care;Integrated Security=True";
        private void Doctorsignupbtn_Click(object sender, EventArgs e)
        {
            DoctorSighnup s = new DoctorSighnup();
            s.Show();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Close();
        }

        private void Doctorloginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string sql = "SELECT * from Doctor Where Doctor_ID = '" + Doctoridtxt.Text.Trim() + "'and Doctor_Password = '" + Doctorpasswordtxt.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
           
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                DoctorMenu2 p2 = new DoctorMenu2();
                this.Close();
                p2.Show();
            }
            else
            {
                MessageBox.Show("Check your User Name and Password", "E Health Care");
            }
        }
    }
}
