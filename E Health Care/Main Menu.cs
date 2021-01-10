using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Health_Care
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Maintopatientbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientMenu1 m1 = new PatientMenu1();
            m1.Show();
            
        }

        private void Mainmenutodoctorbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorMenu1 d = new DoctorMenu1();
            d.Show();
        }
    }
}
