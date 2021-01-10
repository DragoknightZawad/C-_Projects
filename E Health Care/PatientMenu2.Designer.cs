namespace E_Health_Care
{
    partial class PatientMenu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMenu2));
            this.button2 = new System.Windows.Forms.Button();
            this.PatientMenu2to3btn = new System.Windows.Forms.Button();
            this.Catagorycombo = new System.Windows.Forms.ComboBox();
            this.Locationcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PatientMenu2to3btn
            // 
            this.PatientMenu2to3btn.Location = new System.Drawing.Point(159, 248);
            this.PatientMenu2to3btn.Name = "PatientMenu2to3btn";
            this.PatientMenu2to3btn.Size = new System.Drawing.Size(127, 49);
            this.PatientMenu2to3btn.TabIndex = 10;
            this.PatientMenu2to3btn.Text = "Next";
            this.PatientMenu2to3btn.UseVisualStyleBackColor = true;
            this.PatientMenu2to3btn.Click += new System.EventHandler(this.PatientMenu2to3btn_Click);
            // 
            // Catagorycombo
            // 
            this.Catagorycombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Catagorycombo.FormattingEnabled = true;
            this.Catagorycombo.Items.AddRange(new object[] {
            "Orthopedic",
            "Neurologist",
            "Skin / Dermatology",
            "Allergist",
            "Anaesthesiologist",
            "Andrologist",
            "Cardiologist",
            "Cardiac Electrophysiologist",
            "Emergency Room (ER) Doctors",
            "Endocrinologist",
            "Epidemiologist",
            "Family Medicine Physician",
            "Gastroenterologist",
            "Geriatrician",
            "Hyperbaric Physician",
            "Hematologist",
            "Hepatologist",
            "Immunologist",
            "Infectious Disease Specialist",
            "Intensivist",
            "Internal Medicine Specialist",
            "Maxillofacial Surgeon / Oral Surgeon",
            "Medical Examiner",
            "Medical Geneticist",
            "Neonatologist",
            "Nephrologist",
            "Neurologist",
            "Neurosurgeon",
            "Nuclear Medicine Specialist",
            "Obstetrician/Gynecologist (OB/GYN)",
            "Occupational Medicine Specialist",
            "Oncologist",
            "Ophthalmologist",
            "Orthopedic Surgeon / Orthopedist",
            "Otolaryngologist (also ENT Specialist)"});
            this.Catagorycombo.Location = new System.Drawing.Point(454, 99);
            this.Catagorycombo.Name = "Catagorycombo";
            this.Catagorycombo.Size = new System.Drawing.Size(121, 24);
            this.Catagorycombo.TabIndex = 9;
            // 
            // Locationcombo
            // 
            this.Locationcombo.FormattingEnabled = true;
            this.Locationcombo.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Khulna",
            "Barisal",
            "Coxbazar"});
            this.Locationcombo.Location = new System.Drawing.Point(454, 29);
            this.Locationcombo.Name = "Locationcombo";
            this.Locationcombo.Size = new System.Drawing.Size(121, 24);
            this.Locationcombo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Catagory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Location :";
            // 
            // PatientMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(635, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PatientMenu2to3btn);
            this.Controls.Add(this.Catagorycombo);
            this.Controls.Add(this.Locationcombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientMenu2";
            this.Text = "Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PatientMenu2to3btn;
        private System.Windows.Forms.ComboBox Catagorycombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Locationcombo;
    }
}