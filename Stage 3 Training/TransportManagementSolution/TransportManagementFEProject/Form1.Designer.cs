namespace TransportManagementFEProject
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Employee Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(21, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(126, 17);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Employee Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(171, 78);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 80);
            this.txtAddress.TabIndex = 2;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(21, 179);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(128, 17);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Employee Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(171, 176);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(156, 22);
            this.txtLocation.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(370, 30);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(99, 17);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Employee Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(520, 27);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(156, 22);
            this.txtAge.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(370, 81);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(115, 17);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Employee Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(520, 78);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 22);
            this.txtPhone.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(370, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Employee Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(520, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(373, 171);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(136, 33);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create Employee";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(540, 171);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 33);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 228);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReset;
    }
}

