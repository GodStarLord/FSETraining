namespace TransportManagementFEProject
{
    partial class frmAllocateBus
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
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnGetBus = new System.Windows.Forms.Button();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.ddlBusNumbers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(86, 43);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(87, 17);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(213, 40);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(121, 22);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // btnGetBus
            // 
            this.btnGetBus.Location = new System.Drawing.Point(397, 37);
            this.btnGetBus.Name = "btnGetBus";
            this.btnGetBus.Size = new System.Drawing.Size(75, 28);
            this.btnGetBus.TabIndex = 2;
            this.btnGetBus.Text = "Get Bus";
            this.btnGetBus.UseVisualStyleBackColor = true;
            this.btnGetBus.Click += new System.EventHandler(this.btnGetBus_Click);
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(213, 188);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(121, 28);
            this.btnAllocate.TabIndex = 3;
            this.btnAllocate.Text = "Allocate Bus";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // ddlBusNumbers
            // 
            this.ddlBusNumbers.FormattingEnabled = true;
            this.ddlBusNumbers.Location = new System.Drawing.Point(213, 98);
            this.ddlBusNumbers.Name = "ddlBusNumbers";
            this.ddlBusNumbers.Size = new System.Drawing.Size(121, 24);
            this.ddlBusNumbers.TabIndex = 4;
            this.ddlBusNumbers.Visible = false;
            // 
            // frmAllocateBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddlBusNumbers);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.btnGetBus);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Name = "frmAllocateBus";
            this.Text = "frmAllocateBus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Button btnGetBus;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.ComboBox ddlBusNumbers;
    }
}