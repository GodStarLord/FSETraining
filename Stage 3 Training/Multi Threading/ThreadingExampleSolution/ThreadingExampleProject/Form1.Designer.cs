namespace ThreadingExampleProject
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(258, 138);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(213, 22);
            this.txtBox.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(258, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 39);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(370, 209);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(101, 39);
            this.btnHello.TabIndex = 3;
            this.btnHello.Text = "Say Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHello;
    }
}

