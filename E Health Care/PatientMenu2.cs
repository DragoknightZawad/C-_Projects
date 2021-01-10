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
    public partial class PatientMenu2 : Form 
    {
        public PatientMenu2()
        {
            InitializeComponent();
        }
        
        private void PatientMenu2to3btn_Click(object sender, EventArgs e)
        {
            if (Locationcombo.SelectedIndex > -1 && Catagorycombo.SelectedIndex>-1)
            {
                // do something
                PatientMenu3 m4 = new PatientMenu3();
                m4.locationlbl.Text = Locationcombo.SelectedItem.ToString();
                m4.Catagorylbl.Text = Catagorycombo.SelectedItem.ToString();
                m4.Show();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Choose Location and Catagory","E Health");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientMenu1 p = new PatientMenu1();
            this.Close();
            p.Show();
        }
    }
}
