using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("D:\\Codes\\Stage 3 Training\\Hands On\\Day 2\\AsyncExample\\Demo.txt"))
            {
                var content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }

        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            //Task unit of Work
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            lblResult.Text = "Processing File";
            var count = await task;

            lblResult.Text = count.ToString() + " Character is File";
        }
    }
}
