namespace TransportManagementFEProject
{
    partial class DriverForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Driver Name";
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(227, 27);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(170, 22);
            this.txtDriverName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(227, 65);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(170, 22);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(57, 68);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(145, 17);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Driver Phone Number";
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(80, 115);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(100, 33);
            this.btnAddDriver.TabIndex = 4;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(259, 115);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.lblName);
            this.Name = "DriverForm";
            this.Text = "DriverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnReset;
    }
}