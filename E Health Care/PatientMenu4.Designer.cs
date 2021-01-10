namespace E_Health_Care
{
    partial class PatientMenu4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMenu4));
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Doctorinfoview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ToAppointment = new System.Windows.Forms.Button();
            this.Doctorid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Doctorinfoview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Doctor\'s ID of your choice\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(22, 21);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 39);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back\r\n";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Doctorinfoview
            // 
            this.Doctorinfoview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doctorinfoview.Location = new System.Drawing.Point(530, 198);
            this.Doctorinfoview.Name = "Doctorinfoview";
            this.Doctorinfoview.RowHeadersWidth = 51;
            this.Doctorinfoview.RowTemplate.Height = 24;
            this.Doctorinfoview.Size = new System.Drawing.Size(704, 439);
            this.Doctorinfoview.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 69);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doctor Info";
            // 
            // ToAppointment
            // 
            this.ToAppointment.Location = new System.Drawing.Point(1057, 36);
            this.ToAppointment.Name = "ToAppointment";
            this.ToAppointment.Size = new System.Drawing.Size(135, 40);
            this.ToAppointment.TabIndex = 7;
            this.ToAppointment.Text = "Next";
            this.ToAppointment.UseVisualStyleBackColor = true;
            this.ToAppointment.Click += new System.EventHandler(this.ToAppointment_Click);
            // 
            // Doctorid
            // 
            this.Doctorid.Location = new System.Drawing.Point(445, 102);
            this.Doctorid.Name = "Doctorid";
            this.Doctorid.Size = new System.Drawing.Size(160, 22);
            this.Doctorid.TabIndex = 8;
            // 
            // PatientMenu4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1272, 749);
            this.Controls.Add(this.Doctorid);
            this.Controls.Add(this.ToAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Doctorinfoview);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientMenu4";
            this.Text = "E Health Care";
            ((System.ComponentModel.ISupportInitialize)(this.Doctorinfoview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        public System.Windows.Forms.DataGridView Doctorinfoview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToAppointment;
        private System.Windows.Forms.TextBox Doctorid;
    }
}