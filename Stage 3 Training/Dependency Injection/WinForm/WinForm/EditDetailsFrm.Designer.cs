namespace WinForm
{
    partial class EditDetailsFrm
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
            this.lblTempPassword = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTempPassword
            // 
            this.lblTempPassword.AutoSize = true;
            this.lblTempPassword.Location = new System.Drawing.Point(254, 350);
            this.lblTempPassword.Name = "lblTempPassword";
            this.lblTempPassword.Size = new System.Drawing.Size(0, 17);
            this.lblTempPassword.TabIndex = 31;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(276, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 35);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(276, 243);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(167, 243);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(276, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 27;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(167, 206);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Phone";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(167, 164);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 24;
            this.lblCity.Text = "City";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(276, 123);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(200, 22);
            this.txtGender.TabIndex = 23;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(167, 123);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 22;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(167, 83);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(87, 17);
            this.lblDOB.TabIndex = 21;
            this.lblDOB.Text = "Date of Birth";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(276, 83);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(200, 22);
            this.txtDateTime.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(276, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(167, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(276, 164);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 22);
            this.txtCity.TabIndex = 32;
            // 
            // EditDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblTempPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "EditDetailsFrm";
            this.Text = "EditDetailsFrm";
            this.Load += new System.EventHandler(this.EditDetailsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker txtDateTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCity;
    }
}