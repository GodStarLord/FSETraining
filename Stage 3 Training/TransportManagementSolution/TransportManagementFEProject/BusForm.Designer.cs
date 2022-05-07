namespace TransportManagementFEProject
{
    partial class BusForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.txtBusCapcity = new System.Windows.Forms.TextBox();
            this.lblBusCapacity = new System.Windows.Forms.Label();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.lblBusNumber = new System.Windows.Forms.Label();
            this.txtBusOccupancy = new System.Windows.Forms.TextBox();
            this.lblBusOccupancy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(232, 146);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 33);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(53, 146);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(100, 33);
            this.btnAddBus.TabIndex = 10;
            this.btnAddBus.Text = "Add Bus";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // txtBusCapcity
            // 
            this.txtBusCapcity.Location = new System.Drawing.Point(201, 58);
            this.txtBusCapcity.Name = "txtBusCapcity";
            this.txtBusCapcity.Size = new System.Drawing.Size(170, 22);
            this.txtBusCapcity.TabIndex = 9;
            // 
            // lblBusCapacity
            // 
            this.lblBusCapacity.AutoSize = true;
            this.lblBusCapacity.Location = new System.Drawing.Point(31, 61);
            this.lblBusCapacity.Name = "lblBusCapacity";
            this.lblBusCapacity.Size = new System.Drawing.Size(90, 17);
            this.lblBusCapacity.TabIndex = 8;
            this.lblBusCapacity.Text = "Bus Capacity";
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(201, 20);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(170, 22);
            this.txtBusNumber.TabIndex = 7;
            // 
            // lblBusNumber
            // 
            this.lblBusNumber.AutoSize = true;
            this.lblBusNumber.Location = new System.Drawing.Point(31, 23);
            this.lblBusNumber.Name = "lblBusNumber";
            this.lblBusNumber.Size = new System.Drawing.Size(86, 17);
            this.lblBusNumber.TabIndex = 6;
            this.lblBusNumber.Text = "Bus Number";
            // 
            // txtBusOccupancy
            // 
            this.txtBusOccupancy.Location = new System.Drawing.Point(201, 98);
            this.txtBusOccupancy.Name = "txtBusOccupancy";
            this.txtBusOccupancy.Size = new System.Drawing.Size(170, 22);
            this.txtBusOccupancy.TabIndex = 13;
            // 
            // lblBusOccupancy
            // 
            this.lblBusOccupancy.AutoSize = true;
            this.lblBusOccupancy.Location = new System.Drawing.Point(31, 101);
            this.lblBusOccupancy.Name = "lblBusOccupancy";
            this.lblBusOccupancy.Size = new System.Drawing.Size(107, 17);
            this.lblBusOccupancy.TabIndex = 12;
            this.lblBusOccupancy.Text = "Bus Occupancy";
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBusOccupancy);
            this.Controls.Add(this.lblBusOccupancy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.txtBusCapcity);
            this.Controls.Add(this.lblBusCapacity);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.lblBusNumber);
            this.Name = "BusForm";
            this.Text = "BusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.TextBox txtBusCapcity;
        private System.Windows.Forms.Label lblBusCapacity;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Label lblBusNumber;
        private System.Windows.Forms.TextBox txtBusOccupancy;
        private System.Windows.Forms.Label lblBusOccupancy;
    }
}