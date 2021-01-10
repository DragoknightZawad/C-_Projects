namespace E_Health_Care
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.label1 = new System.Windows.Forms.Label();
            this.Requestappointmentdatetime = new System.Windows.Forms.DateTimePicker();
            this.Scheduleview = new System.Windows.Forms.DataGridView();
            this.Requestschedulebtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainMenu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.DoctorIDtxt = new System.Windows.Forms.TextBox();
            this.Refreshschedulebtn = new E_Health_Care.ButtonEllipse();
            ((System.ComponentModel.ISupportInitialize)(this.Scheduleview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your schedule";
            // 
            // Requestappointmentdatetime
            // 
            this.Requestappointmentdatetime.Location = new System.Drawing.Point(230, 643);
            this.Requestappointmentdatetime.Name = "Requestappointmentdatetime";
            this.Requestappointmentdatetime.Size = new System.Drawing.Size(283, 22);
            this.Requestappointmentdatetime.TabIndex = 1;
            // 
            // Scheduleview
            // 
            this.Scheduleview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scheduleview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Scheduleview.Location = new System.Drawing.Point(582, 110);
            this.Scheduleview.Name = "Scheduleview";
            this.Scheduleview.RowHeadersWidth = 51;
            this.Scheduleview.RowTemplate.Height = 24;
            this.Scheduleview.Size = new System.Drawing.Size(651, 593);
            this.Scheduleview.TabIndex = 2;
            // 
            // Requestschedulebtn
            // 
            this.Requestschedulebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Requestschedulebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Requestschedulebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Requestschedulebtn.Location = new System.Drawing.Point(371, 683);
            this.Requestschedulebtn.Name = "Requestschedulebtn";
            this.Requestschedulebtn.Size = new System.Drawing.Size(106, 48);
            this.Requestschedulebtn.TabIndex = 3;
            this.Requestschedulebtn.Text = "Request";
            this.Requestschedulebtn.UseVisualStyleBackColor = false;
            this.Requestschedulebtn.Click += new System.EventHandler(this.Requestschedulebtn_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(16, 689);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 39);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back\r\n";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 564);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 22);
            this.textBox1.TabIndex = 11;
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = true;
            this.MainMenu.Location = new System.Drawing.Point(93, 683);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(87, 39);
            this.MainMenu.TabIndex = 13;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Doctor ID";
            // 
            // DoctorIDtxt
            // 
            this.DoctorIDtxt.Location = new System.Drawing.Point(230, 608);
            this.DoctorIDtxt.Name = "DoctorIDtxt";
            this.DoctorIDtxt.Size = new System.Drawing.Size(283, 22);
            this.DoctorIDtxt.TabIndex = 16;
            // 
            // Refreshschedulebtn
            // 
            this.Refreshschedulebtn.AutoSize = true;
            this.Refreshschedulebtn.BackColor = System.Drawing.Color.LightGray;
            this.Refreshschedulebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refreshschedulebtn.BackgroundImage")));
            this.Refreshschedulebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Refreshschedulebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshschedulebtn.Location = new System.Drawing.Point(790, 22);
            this.Refreshschedulebtn.Name = "Refreshschedulebtn";
            this.Refreshschedulebtn.Size = new System.Drawing.Size(180, 82);
            this.Refreshschedulebtn.TabIndex = 7;
            this.Refreshschedulebtn.Text = "\r\nRefresh\r\n\r\n";
            this.Refreshschedulebtn.UseVisualStyleBackColor = false;
            this.Refreshschedulebtn.Click += new System.EventHandler(this.Refreshschedulebtn_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 754);
            this.Controls.Add(this.DoctorIDtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Refreshschedulebtn);
            this.Controls.Add(this.Requestschedulebtn);
            this.Controls.Add(this.Scheduleview);
            this.Controls.Add(this.Requestappointmentdatetime);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appointment";
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.Scheduleview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Requestappointmentdatetime;
        private System.Windows.Forms.Button Requestschedulebtn;
        private ButtonEllipse Refreshschedulebtn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MainMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.DataGridView Scheduleview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DoctorIDtxt;
    }
}