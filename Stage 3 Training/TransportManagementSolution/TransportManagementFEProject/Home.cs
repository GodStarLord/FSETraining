using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementFEProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void allocateBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllocateBus formAllocateBus = new frmAllocateBus();
            formAllocateBus.MdiParent = this;
            formAllocateBus.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
