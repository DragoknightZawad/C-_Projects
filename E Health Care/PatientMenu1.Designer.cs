namespace E_Health_Care
{
    partial class PatientMenu1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMenu1));
            this.BackPatient1toMain = new System.Windows.Forms.Button();
            this.Doctorpasswordtxt = new System.Windows.Forms.TextBox();
            this.Patientidtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Patientsignupbtn = new System.Windows.Forms.Button();
            this.Patientloginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackPatient1toMain
            // 
            this.BackPatient1toMain.Location = new System.Drawing.Point(12, 12);
            this.BackPatient1toMain.Name = "BackPatient1toMain";
            this.BackPatient1toMain.Size = new System.Drawing.Size(59, 30);
            this.BackPatient1toMain.TabIndex = 11;
            this.BackPatient1toMain.Text = "Back\r\n";
            this.BackPatient1toMain.UseVisualStyleBackColor = true;
            this.BackPatient1toMain.Click += new System.EventHandler(this.BackPatient1toMain_Click);
            // 
            // Doctorpasswordtxt
            // 
            this.Doctorpasswordtxt.Location = new System.Drawing.Point(131, 135);
            this.Doctorpasswordtxt.Name = "Doctorpasswordtxt";
            this.Doctorpasswordtxt.PasswordChar = '*';
            this.Doctorpasswordtxt.Size = new System.Drawing.Size(306, 22);
            this.Doctorpasswordtxt.TabIndex = 10;
            // 
            // Patientidtxt
            // 
            this.Patientidtxt.Location = new System.Drawing.Point(121, 79);
            this.Patientidtxt.Name = "Patientidtxt";
            this.Patientidtxt.Size = new System.Drawing.Size(316, 22);
            this.Patientidtxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "User ID:";
            // 
            // Patientsignupbtn
            // 
            this.Patientsignupbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientsignupbtn.Location = new System.Drawing.Point(198, 501);
            this.Patientsignupbtn.Name = "Patientsignupbtn";
            this.Patientsignupbtn.Size = new System.Drawing.Size(118, 44);
            this.Patientsignupbtn.TabIndex = 13;
            this.Patientsignupbtn.Text = "Sign Up";
            this.Patientsignupbtn.UseVisualStyleBackColor = true;
            this.Patientsignupbtn.Click += new System.EventHandler(this.Patientsignupbtn_Click);
            // 
            // Patientloginbtn
            // 
            this.Patientloginbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientloginbtn.Location = new System.Drawing.Point(55, 501);
            this.Patientloginbtn.Name = "Patientloginbtn";
            this.Patientloginbtn.Size = new System.Drawing.Size(118, 44);
            this.Patientloginbtn.TabIndex = 12;
            this.Patientloginbtn.Text = "Log In";
            this.Patientloginbtn.UseVisualStyleBackColor = true;
            this.Patientloginbtn.Click += new System.EventHandler(this.Patientloginbtn_Click);
            // 
            // PatientMenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(573, 600);
            this.Controls.Add(this.Patientsignupbtn);
            this.Controls.Add(this.Patientloginbtn);
            this.Controls.Add(this.BackPatient1toMain);
            this.Controls.Add(this.Doctorpasswordtxt);
            this.Controls.Add(this.Patientidtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientMenu1";
            this.Text = "Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackPatient1toMain;
        private System.Windows.Forms.TextBox Doctorpasswordtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Patientsignupbtn;
        public System.Windows.Forms.TextBox Patientidtxt;
        public System.Windows.Forms.Button Patientloginbtn;
    }
}