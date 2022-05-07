namespace WinForm
{
    partial class HomeFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editMyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMyDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMyDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editMyDetailsToolStripMenuItem
            // 
            this.editMyDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMyDetailsToolStripMenuItem1});
            this.editMyDetailsToolStripMenuItem.Name = "editMyDetailsToolStripMenuItem";
            this.editMyDetailsToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editMyDetailsToolStripMenuItem.Text = "Menu";
            // 
            // editMyDetailsToolStripMenuItem1
            // 
            this.editMyDetailsToolStripMenuItem1.Name = "editMyDetailsToolStripMenuItem1";
            this.editMyDetailsToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.editMyDetailsToolStripMenuItem1.Text = "Edit My Details";
            this.editMyDetailsToolStripMenuItem1.Click += new System.EventHandler(this.editMyDetailsToolStripMenuItem1_Click);
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeFrm";
            this.Text = "HomeFrm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editMyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMyDetailsToolStripMenuItem1;
    }
}