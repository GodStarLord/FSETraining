namespace TransportManagementFEProject
{
    partial class Trips
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
            this.lblBusName = new System.Windows.Forms.Label();
            this.txtBusName = new System.Windows.Forms.TextBox();
            this.txtDriverID = new System.Windows.Forms.TextBox();
            this.lblDriverID = new System.Windows.Forms.Label();
            this.lblStop1 = new System.Windows.Forms.Label();
            this.lblStop1Time = new System.Windows.Forms.Label();
            this.lblStop3Time = new System.Windows.Forms.Label();
            this.txtStop3 = new System.Windows.Forms.TextBox();
            this.lblStop3 = new System.Windows.Forms.Label();
            this.lblStop2Time = new System.Windows.Forms.Label();
            this.txtStop2 = new System.Windows.Forms.TextBox();
            this.lblStop2 = new System.Windows.Forms.Label();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Stop1DateTime = new System.Windows.Forms.DateTimePicker();
            this.txtStop1 = new System.Windows.Forms.TextBox();
            this.Stop2DateTime = new System.Windows.Forms.DateTimePicker();
            this.Stop3DateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblBusName
            // 
            this.lblBusName.AutoSize = true;
            this.lblBusName.Location = new System.Drawing.Point(21, 16);
            this.lblBusName.Name = "lblBusName";
            this.lblBusName.Size = new System.Drawing.Size(73, 17);
            this.lblBusName.TabIndex = 0;
            this.lblBusName.Text = "Bus Name";
            // 
            // txtBusName
            // 
            this.txtBusName.Location = new System.Drawing.Point(115, 13);
            this.txtBusName.Name = "txtBusName";
            this.txtBusName.Size = new System.Drawing.Size(142, 22);
            this.txtBusName.TabIndex = 1;
            // 
            // txtDriverID
            // 
            this.txtDriverID.Location = new System.Drawing.Point(115, 54);
            this.txtDriverID.Name = "txtDriverID";
            this.txtDriverID.Size = new System.Drawing.Size(142, 22);
            this.txtDriverID.TabIndex = 3;
            // 
            // lblDriverID
            // 
            this.lblDriverID.AutoSize = true;
            this.lblDriverID.Location = new System.Drawing.Point(21, 57);
            this.lblDriverID.Name = "lblDriverID";
            this.lblDriverID.Size = new System.Drawing.Size(63, 17);
            this.lblDriverID.TabIndex = 2;
            this.lblDriverID.Text = "Driver ID";
            // 
            // lblStop1
            // 
            this.lblStop1.AutoSize = true;
            this.lblStop1.Location = new System.Drawing.Point(21, 100);
            this.lblStop1.Name = "lblStop1";
            this.lblStop1.Size = new System.Drawing.Size(49, 17);
            this.lblStop1.TabIndex = 4;
            this.lblStop1.Text = "Stop 1";
            // 
            // lblStop1Time
            // 
            this.lblStop1Time.AutoSize = true;
            this.lblStop1Time.Location = new System.Drawing.Point(21, 141);
            this.lblStop1Time.Name = "lblStop1Time";
            this.lblStop1Time.Size = new System.Drawing.Size(84, 17);
            this.lblStop1Time.TabIndex = 6;
            this.lblStop1Time.Text = "Stop 1 Time";
            // 
            // lblStop3Time
            // 
            this.lblStop3Time.AutoSize = true;
            this.lblStop3Time.Location = new System.Drawing.Point(301, 141);
            this.lblStop3Time.Name = "lblStop3Time";
            this.lblStop3Time.Size = new System.Drawing.Size(84, 17);
            this.lblStop3Time.TabIndex = 14;
            this.lblStop3Time.Text = "Stop 3 Time";
            // 
            // txtStop3
            // 
            this.txtStop3.Location = new System.Drawing.Point(395, 97);
            this.txtStop3.Name = "txtStop3";
            this.txtStop3.Size = new System.Drawing.Size(142, 22);
            this.txtStop3.TabIndex = 13;
            // 
            // lblStop3
            // 
            this.lblStop3.AutoSize = true;
            this.lblStop3.Location = new System.Drawing.Point(301, 100);
            this.lblStop3.Name = "lblStop3";
            this.lblStop3.Size = new System.Drawing.Size(49, 17);
            this.lblStop3.TabIndex = 12;
            this.lblStop3.Text = "Stop 3";
            // 
            // lblStop2Time
            // 
            this.lblStop2Time.AutoSize = true;
            this.lblStop2Time.Location = new System.Drawing.Point(301, 57);
            this.lblStop2Time.Name = "lblStop2Time";
            this.lblStop2Time.Size = new System.Drawing.Size(84, 17);
            this.lblStop2Time.TabIndex = 10;
            this.lblStop2Time.Text = "Stop 2 Time";
            // 
            // txtStop2
            // 
            this.txtStop2.Location = new System.Drawing.Point(395, 13);
            this.txtStop2.Name = "txtStop2";
            this.txtStop2.Size = new System.Drawing.Size(142, 22);
            this.txtStop2.TabIndex = 9;
            // 
            // lblStop2
            // 
            this.lblStop2.AutoSize = true;
            this.lblStop2.Location = new System.Drawing.Point(301, 16);
            this.lblStop2.Name = "lblStop2";
            this.lblStop2.Size = new System.Drawing.Size(49, 17);
            this.lblStop2.TabIndex = 8;
            this.lblStop2.Text = "Stop 2";
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Location = new System.Drawing.Point(167, 186);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(90, 34);
            this.btnAddTrip.TabIndex = 16;
            this.btnAddTrip.Text = "Add Trip";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(295, 186);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 34);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Stop1DateTime
            // 
            this.Stop1DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Stop1DateTime.Location = new System.Drawing.Point(115, 136);
            this.Stop1DateTime.Name = "Stop1DateTime";
            this.Stop1DateTime.Size = new System.Drawing.Size(142, 22);
            this.Stop1DateTime.TabIndex = 18;
            // 
            // txtStop1
            // 
            this.txtStop1.Location = new System.Drawing.Point(115, 97);
            this.txtStop1.Name = "txtStop1";
            this.txtStop1.Size = new System.Drawing.Size(142, 22);
            this.txtStop1.TabIndex = 5;
            // 
            // Stop2DateTime
            // 
            this.Stop2DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Stop2DateTime.Location = new System.Drawing.Point(395, 54);
            this.Stop2DateTime.Name = "Stop2DateTime";
            this.Stop2DateTime.Size = new System.Drawing.Size(142, 22);
            this.Stop2DateTime.TabIndex = 19;
            // 
            // Stop3DateTime
            // 
            this.Stop3DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Stop3DateTime.Location = new System.Drawing.Point(395, 136);
            this.Stop3DateTime.Name = "Stop3DateTime";
            this.Stop3DateTime.Size = new System.Drawing.Size(142, 22);
            this.Stop3DateTime.TabIndex = 20;
            // 
            // Trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stop3DateTime);
            this.Controls.Add(this.Stop2DateTime);
            this.Controls.Add(this.Stop1DateTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.lblStop3Time);
            this.Controls.Add(this.txtStop3);
            this.Controls.Add(this.lblStop3);
            this.Controls.Add(this.lblStop2Time);
            this.Controls.Add(this.txtStop2);
            this.Controls.Add(this.lblStop2);
            this.Controls.Add(this.lblStop1Time);
            this.Controls.Add(this.txtStop1);
            this.Controls.Add(this.lblStop1);
            this.Controls.Add(this.txtDriverID);
            this.Controls.Add(this.lblDriverID);
            this.Controls.Add(this.txtBusName);
            this.Controls.Add(this.lblBusName);
            this.Name = "Trips";
            this.Text = "Trips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusName;
        private System.Windows.Forms.TextBox txtBusName;
        private System.Windows.Forms.TextBox txtDriverID;
        private System.Windows.Forms.Label lblDriverID;
        private System.Windows.Forms.Label lblStop1;
        private System.Windows.Forms.Label lblStop1Time;
        private System.Windows.Forms.Label lblStop3Time;
        private System.Windows.Forms.TextBox txtStop3;
        private System.Windows.Forms.Label lblStop3;
        private System.Windows.Forms.Label lblStop2Time;
        private System.Windows.Forms.TextBox txtStop2;
        private System.Windows.Forms.Label lblStop2;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker Stop1DateTime;
        private System.Windows.Forms.TextBox txtStop1;
        private System.Windows.Forms.DateTimePicker Stop2DateTime;
        private System.Windows.Forms.DateTimePicker Stop3DateTime;
    }
}