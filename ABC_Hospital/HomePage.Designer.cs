namespace ABC_Hospital
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PatientB = new System.Windows.Forms.Button();
            this.PatientButton = new System.Windows.Forms.Button();
            this.DoctorButton = new System.Windows.Forms.Button();
            this.HospitalName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatientB
            // 
            this.PatientB.Location = new System.Drawing.Point(181, 209);
            this.PatientB.Name = "PatientB";
            this.PatientB.Size = new System.Drawing.Size(94, 29);
            this.PatientB.TabIndex = 0;
            this.PatientB.Text = "PATIENT";
            this.PatientB.UseVisualStyleBackColor = true;
            this.PatientB.Click += new System.EventHandler(this.PatientB_Click);
            // 
            // PatientButton
            // 
            this.PatientButton.Location = new System.Drawing.Point(181, 265);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(94, 29);
            this.PatientButton.TabIndex = 1;
            this.PatientButton.Text = "ADMIN";
            this.PatientButton.UseVisualStyleBackColor = true;
            this.PatientButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoctorButton
            // 
            this.DoctorButton.Location = new System.Drawing.Point(181, 324);
            this.DoctorButton.Name = "DoctorButton";
            this.DoctorButton.Size = new System.Drawing.Size(94, 29);
            this.DoctorButton.TabIndex = 2;
            this.DoctorButton.Text = "DOCTOR";
            this.DoctorButton.UseVisualStyleBackColor = true;
            // 
            // HospitalName
            // 
            this.HospitalName.AutoSize = true;
            this.HospitalName.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HospitalName.Location = new System.Drawing.Point(12, 49);
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.Size = new System.Drawing.Size(478, 54);
            this.HospitalName.TabIndex = 3;
            this.HospitalName.Text = "ABC PRIVATE HOSPITAL";
            this.HospitalName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(137, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "WELCOME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ABC_Hospital.Properties.Resources.hos1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HospitalName);
            this.Controls.Add(this.DoctorButton);
            this.Controls.Add(this.PatientButton);
            this.Controls.Add(this.PatientB);
            this.Name = "HomePage";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button AdminButton;
        public Button PatientButton;
        public Button DoctorButton;
        public Label HospitalName;
        public Label label2;
        public Button PatientB;
    }
}