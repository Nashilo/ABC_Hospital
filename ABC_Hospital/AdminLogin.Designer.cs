namespace ABC_Hospital
{
    partial class AdminLogin
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
            this.AdminL = new System.Windows.Forms.Label();
            this.AdminID = new System.Windows.Forms.Label();
            this.AdminPassword = new System.Windows.Forms.Label();
            this.AdminIdtextBox = new System.Windows.Forms.TextBox();
            this.AdminPasswordtextBox = new System.Windows.Forms.TextBox();
            this.AdLoginButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminL
            // 
            this.AdminL.AutoSize = true;
            this.AdminL.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AdminL.Location = new System.Drawing.Point(157, 88);
            this.AdminL.Name = "AdminL";
            this.AdminL.Size = new System.Drawing.Size(223, 41);
            this.AdminL.TabIndex = 0;
            this.AdminL.Text = "ADMIN LOGIN";
            // 
            // AdminID
            // 
            this.AdminID.AutoSize = true;
            this.AdminID.Location = new System.Drawing.Point(110, 228);
            this.AdminID.Name = "AdminID";
            this.AdminID.Size = new System.Drawing.Size(68, 20);
            this.AdminID.TabIndex = 1;
            this.AdminID.Text = "AdminID";
            this.AdminID.Click += new System.EventHandler(this.label2_Click);
            // 
            // AdminPassword
            // 
            this.AdminPassword.AutoSize = true;
            this.AdminPassword.Location = new System.Drawing.Point(110, 272);
            this.AdminPassword.Name = "AdminPassword";
            this.AdminPassword.Size = new System.Drawing.Size(70, 20);
            this.AdminPassword.TabIndex = 2;
            this.AdminPassword.Text = "Password";
            this.AdminPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // AdminIdtextBox
            // 
            this.AdminIdtextBox.Location = new System.Drawing.Point(238, 221);
            this.AdminIdtextBox.Name = "AdminIdtextBox";
            this.AdminIdtextBox.Size = new System.Drawing.Size(248, 27);
            this.AdminIdtextBox.TabIndex = 3;
            // 
            // AdminPasswordtextBox
            // 
            this.AdminPasswordtextBox.Location = new System.Drawing.Point(238, 265);
            this.AdminPasswordtextBox.Name = "AdminPasswordtextBox";
            this.AdminPasswordtextBox.Size = new System.Drawing.Size(248, 27);
            this.AdminPasswordtextBox.TabIndex = 4;
            // 
            // AdLoginButton
            // 
            this.AdLoginButton.Location = new System.Drawing.Point(392, 321);
            this.AdLoginButton.Name = "AdLoginButton";
            this.AdLoginButton.Size = new System.Drawing.Size(94, 29);
            this.AdLoginButton.TabIndex = 5;
            this.AdLoginButton.Text = "Login";
            this.AdLoginButton.UseVisualStyleBackColor = true;
            this.AdLoginButton.Click += new System.EventHandler(this.AdLoginButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(220, 321);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(32, 396);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 29);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ABC_Hospital.Properties.Resources.AdminLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AdLoginButton);
            this.Controls.Add(this.AdminPasswordtextBox);
            this.Controls.Add(this.AdminIdtextBox);
            this.Controls.Add(this.AdminPassword);
            this.Controls.Add(this.AdminID);
            this.Controls.Add(this.AdminL);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AdminL;
        private Label AdminID;
        private Label AdminPassword;
        private TextBox AdminIdtextBox;
        private TextBox AdminPasswordtextBox;
        private Button AdLoginButton;
        private Button ClearButton;
        private Button ExitButton;
    }
}