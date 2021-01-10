namespace E_Health_Care
{
    partial class DoctorMenu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMenu1));
            this.Doctorpasswordtxt = new System.Windows.Forms.TextBox();
            this.Doctoridtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Doctorsignupbtn = new System.Windows.Forms.Button();
            this.Doctorloginbtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Doctorpasswordtxt
            // 
            this.Doctorpasswordtxt.Location = new System.Drawing.Point(145, 92);
            this.Doctorpasswordtxt.Name = "Doctorpasswordtxt";
            this.Doctorpasswordtxt.PasswordChar = '*';
            this.Doctorpasswordtxt.Size = new System.Drawing.Size(306, 22);
            this.Doctorpasswordtxt.TabIndex = 14;
            // 
            // Doctoridtxt
            // 
            this.Doctoridtxt.Location = new System.Drawing.Point(135, 36);
            this.Doctoridtxt.Name = "Doctoridtxt";
            this.Doctoridtxt.Size = new System.Drawing.Size(316, 22);
            this.Doctoridtxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "User ID:";
            // 
            // Doctorsignupbtn
            // 
            this.Doctorsignupbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctorsignupbtn.Location = new System.Drawing.Point(182, 495);
            this.Doctorsignupbtn.Name = "Doctorsignupbtn";
            this.Doctorsignupbtn.Size = new System.Drawing.Size(118, 44);
            this.Doctorsignupbtn.TabIndex = 16;
            this.Doctorsignupbtn.Text = "Sign Up";
            this.Doctorsignupbtn.UseVisualStyleBackColor = true;
            this.Doctorsignupbtn.Click += new System.EventHandler(this.Doctorsignupbtn_Click);
            // 
            // Doctorloginbtn
            // 
            this.Doctorloginbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctorloginbtn.Location = new System.Drawing.Point(39, 495);
            this.Doctorloginbtn.Name = "Doctorloginbtn";
            this.Doctorloginbtn.Size = new System.Drawing.Size(118, 44);
            this.Doctorloginbtn.TabIndex = 15;
            this.Doctorloginbtn.Text = "Log In";
            this.Doctorloginbtn.UseVisualStyleBackColor = true;
            this.Doctorloginbtn.Click += new System.EventHandler(this.Doctorloginbtn_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(1, 8);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(59, 30);
            this.Back.TabIndex = 17;
            this.Back.Text = "Back\r\n";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DoctorMenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(509, 590);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Doctorsignupbtn);
            this.Controls.Add(this.Doctorloginbtn);
            this.Controls.Add(this.Doctorpasswordtxt);
            this.Controls.Add(this.Doctoridtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorMenu1";
            this.Text = "Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Doctorpasswordtxt;
        private System.Windows.Forms.TextBox Doctoridtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Doctorsignupbtn;
        private System.Windows.Forms.Button Doctorloginbtn;
        private System.Windows.Forms.Button Back;
    }
}