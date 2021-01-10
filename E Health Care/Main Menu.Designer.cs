namespace E_Health_Care
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Maintopatientbtn = new System.Windows.Forms.Button();
            this.Mainmenutodoctorbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Maintopatientbtn
            // 
            this.Maintopatientbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintopatientbtn.Location = new System.Drawing.Point(47, 305);
            this.Maintopatientbtn.Name = "Maintopatientbtn";
            this.Maintopatientbtn.Size = new System.Drawing.Size(141, 56);
            this.Maintopatientbtn.TabIndex = 0;
            this.Maintopatientbtn.Text = "Patient";
            this.Maintopatientbtn.UseVisualStyleBackColor = true;
            this.Maintopatientbtn.Click += new System.EventHandler(this.Maintopatientbtn_Click);
            // 
            // Mainmenutodoctorbtn
            // 
            this.Mainmenutodoctorbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainmenutodoctorbtn.Location = new System.Drawing.Point(234, 305);
            this.Mainmenutodoctorbtn.Name = "Mainmenutodoctorbtn";
            this.Mainmenutodoctorbtn.Size = new System.Drawing.Size(141, 56);
            this.Mainmenutodoctorbtn.TabIndex = 1;
            this.Mainmenutodoctorbtn.Text = "Doctor";
            this.Mainmenutodoctorbtn.UseVisualStyleBackColor = true;
            this.Mainmenutodoctorbtn.Click += new System.EventHandler(this.Mainmenutodoctorbtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mainmenutodoctorbtn);
            this.Controls.Add(this.Maintopatientbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "E Health Care";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Maintopatientbtn;
        private System.Windows.Forms.Button Mainmenutodoctorbtn;
    }
}

