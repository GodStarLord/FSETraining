namespace WinForm
{
    partial class Update_Password
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCheckPass = new System.Windows.Forms.Button();
            this.txtTempPassword = new System.Windows.Forms.TextBox();
            this.lblTempPassowrd = new System.Windows.Forms.Label();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(47, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(47, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // btnCheckPass
            // 
            this.btnCheckPass.Location = new System.Drawing.Point(433, 65);
            this.btnCheckPass.Name = "btnCheckPass";
            this.btnCheckPass.Size = new System.Drawing.Size(139, 37);
            this.btnCheckPass.TabIndex = 4;
            this.btnCheckPass.Text = "Check Password";
            this.btnCheckPass.UseVisualStyleBackColor = true;
            this.btnCheckPass.Click += new System.EventHandler(this.btnCheckPass_Click);
            // 
            // txtTempPassword
            // 
            this.txtTempPassword.Location = new System.Drawing.Point(193, 72);
            this.txtTempPassword.Name = "txtTempPassword";
            this.txtTempPassword.Size = new System.Drawing.Size(175, 22);
            this.txtTempPassword.TabIndex = 6;
            // 
            // lblTempPassowrd
            // 
            this.lblTempPassowrd.AutoSize = true;
            this.lblTempPassowrd.Location = new System.Drawing.Point(47, 75);
            this.lblTempPassowrd.Name = "lblTempPassowrd";
            this.lblTempPassowrd.Size = new System.Drawing.Size(142, 17);
            this.lblTempPassowrd.TabIndex = 5;
            this.lblTempPassowrd.Text = "Temporary Password";
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Location = new System.Drawing.Point(193, 188);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(139, 37);
            this.btnUpdatePass.TabIndex = 7;
            this.btnUpdatePass.Text = "Update Password";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // Update_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.btnUpdatePass);
            this.Controls.Add(this.txtTempPassword);
            this.Controls.Add(this.lblTempPassowrd);
            this.Controls.Add(this.btnCheckPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "Update_Password";
            this.Text = "Update_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCheckPass;
        private System.Windows.Forms.TextBox txtTempPassword;
        private System.Windows.Forms.Label lblTempPassowrd;
        private System.Windows.Forms.Button btnUpdatePass;
    }
}