namespace E_Health_Care
{
    partial class DoctorMenu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMenu2));
            this.Scheduleview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Patient_IDtxt = new System.Windows.Forms.TextBox();
            this.Decisionbtn = new System.Windows.Forms.Button();
            this.ScheduleViewbtn = new E_Health_Care.ButtonEllipse();
            this.buttonEllipse1 = new E_Health_Care.ButtonEllipse();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.RadioButton();
            this.Denied = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doctid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Scheduleview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scheduleview
            // 
            this.Scheduleview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Scheduleview.Location = new System.Drawing.Point(498, 126);
            this.Scheduleview.Name = "Scheduleview";
            this.Scheduleview.RowHeadersWidth = 51;
            this.Scheduleview.RowTemplate.Height = 24;
            this.Scheduleview.Size = new System.Drawing.Size(744, 460);
            this.Scheduleview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter the Patient ID :";
            // 
            // Patient_IDtxt
            // 
            this.Patient_IDtxt.Location = new System.Drawing.Point(209, 188);
            this.Patient_IDtxt.Name = "Patient_IDtxt";
            this.Patient_IDtxt.Size = new System.Drawing.Size(188, 22);
            this.Patient_IDtxt.TabIndex = 15;
            // 
            // Decisionbtn
            // 
            this.Decisionbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decisionbtn.Location = new System.Drawing.Point(35, 401);
            this.Decisionbtn.Name = "Decisionbtn";
            this.Decisionbtn.Size = new System.Drawing.Size(185, 51);
            this.Decisionbtn.TabIndex = 43;
            this.Decisionbtn.Text = "Accept/Deny";
            this.Decisionbtn.UseVisualStyleBackColor = true;
            this.Decisionbtn.Click += new System.EventHandler(this.Decisionbtn_Click);
            // 
            // ScheduleViewbtn
            // 
            this.ScheduleViewbtn.AutoSize = true;
            this.ScheduleViewbtn.BackColor = System.Drawing.Color.LightGray;
            this.ScheduleViewbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScheduleViewbtn.BackgroundImage")));
            this.ScheduleViewbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScheduleViewbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleViewbtn.Location = new System.Drawing.Point(498, 34);
            this.ScheduleViewbtn.Name = "ScheduleViewbtn";
            this.ScheduleViewbtn.Size = new System.Drawing.Size(126, 72);
            this.ScheduleViewbtn.TabIndex = 13;
            this.ScheduleViewbtn.Text = "View";
            this.ScheduleViewbtn.UseVisualStyleBackColor = false;
            this.ScheduleViewbtn.Click += new System.EventHandler(this.ScheduleViewbtn_Click);
            // 
            // buttonEllipse1
            // 
            this.buttonEllipse1.AutoSize = true;
            this.buttonEllipse1.BackColor = System.Drawing.Color.LightGray;
            this.buttonEllipse1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEllipse1.BackgroundImage")));
            this.buttonEllipse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEllipse1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEllipse1.Location = new System.Drawing.Point(1116, 25);
            this.buttonEllipse1.Name = "buttonEllipse1";
            this.buttonEllipse1.Size = new System.Drawing.Size(126, 72);
            this.buttonEllipse1.TabIndex = 45;
            this.buttonEllipse1.Text = "Refresh";
            this.buttonEllipse1.UseVisualStyleBackColor = false;
            this.buttonEllipse1.Click += new System.EventHandler(this.buttonEllipse1_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = true;
            this.MainMenu.Location = new System.Drawing.Point(119, 25);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(87, 39);
            this.MainMenu.TabIndex = 47;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(35, 25);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 39);
            this.Back.TabIndex = 46;
            this.Back.Text = "Back\r\n";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Accept
            // 
            this.Accept.AutoSize = true;
            this.Accept.Location = new System.Drawing.Point(0, 49);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(72, 21);
            this.Accept.TabIndex = 48;
            this.Accept.TabStop = true;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = true;
            // 
            // Denied
            // 
            this.Denied.AutoSize = true;
            this.Denied.Location = new System.Drawing.Point(129, 49);
            this.Denied.Name = "Denied";
            this.Denied.Size = new System.Drawing.Size(62, 21);
            this.Denied.TabIndex = 49;
            this.Denied.TabStop = true;
            this.Denied.Text = "Deny";
            this.Denied.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Accept);
            this.groupBox1.Controls.Add(this.Denied);
            this.groupBox1.Location = new System.Drawing.Point(39, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 100);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decision";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Doctor ID :";
            // 
            // doctid
            // 
            this.doctid.Location = new System.Drawing.Point(209, 147);
            this.doctid.Name = "doctid";
            this.doctid.Size = new System.Drawing.Size(188, 22);
            this.doctid.TabIndex = 52;
            // 
            // DoctorMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1275, 705);
            this.Controls.Add(this.doctid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.buttonEllipse1);
            this.Controls.Add(this.Decisionbtn);
            this.Controls.Add(this.Patient_IDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScheduleViewbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scheduleview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorMenu2";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.Scheduleview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Scheduleview;
        private System.Windows.Forms.Label label1;
        private ButtonEllipse ScheduleViewbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Patient_IDtxt;
        private System.Windows.Forms.Button Decisionbtn;
        private ButtonEllipse buttonEllipse1;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RadioButton Accept;
        private System.Windows.Forms.RadioButton Denied;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doctid;
    }
}