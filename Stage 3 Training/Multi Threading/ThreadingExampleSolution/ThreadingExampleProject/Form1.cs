using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingExampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        public async Task<string> GetDataForText()
        {
            string result = "";

            await Task.Run(() =>
            {
                for (int i = 10; i < 101; i = i + 10)
                {
                    Thread.Sleep(500);
                    result += i + " ";
                }
            });

            return result;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            txtBox.Text = await GetDataForText();
        }
    }
}
