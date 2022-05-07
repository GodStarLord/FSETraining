namespace WinForm
{
    partial class Form1
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCalculateAge = new System.Windows.Forms.Button();
            this.lblTempPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(51, 48);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(160, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(160, 93);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(51, 93);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(160, 138);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(200, 22);
            this.txtDateTime.TabIndex = 4;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(51, 138);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(87, 17);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Date of Birth";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(160, 178);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(200, 22);
            this.txtGender.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(51, 178);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(51, 219);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.FormattingEnabled = true;
            this.txtCity.Location = new System.Drawing.Point(160, 219);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 24);
            this.txtCity.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(160, 261);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 11;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(51, 261);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 298);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(51, 298);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // btnCalculateAge
            // 
            this.btnCalculateAge.Location = new System.Drawing.Point(160, 349);
            this.btnCalculateAge.Name = "btnCalculateAge";
            this.btnCalculateAge.Size = new System.Drawing.Size(129, 35);
            this.btnCalculateAge.TabIndex = 14;
            this.btnCalculateAge.Text = "Sign Up";
            this.btnCalculateAge.UseVisualStyleBackColor = true;
            this.btnCalculateAge.Click += new System.EventHandler(this.btnCalculateAge_Click);
            // 
            // lblTempPassword
            // 
            this.lblTempPassword.AutoSize = true;
            this.lblTempPassword.Location = new System.Drawing.Point(138, 405);
            this.lblTempPassword.Name = "lblTempPassword";
            this.lblTempPassword.Size = new System.Drawing.Size(0, 17);
            this.lblTempPassword.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.lblTempPassword);
            this.Controls.Add(this.btnCalculateAge);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker txtDateTime;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCalculateAge;
        private System.Windows.Forms.Label lblTempPassword;
    }
}

