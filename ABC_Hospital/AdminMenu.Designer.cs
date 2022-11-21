namespace ABC_Hospital
{
    partial class AdminMenu
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
            this.PatientRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientRegistration
            // 
            this.PatientRegistration.Location = new System.Drawing.Point(138, 204);
            this.PatientRegistration.Name = "PatientRegistration";
            this.PatientRegistration.Size = new System.Drawing.Size(209, 29);
            this.PatientRegistration.TabIndex = 0;
            this.PatientRegistration.Text = "Register Patient";
            this.PatientRegistration.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.PatientRegistration);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button PatientRegistration;
    }
}