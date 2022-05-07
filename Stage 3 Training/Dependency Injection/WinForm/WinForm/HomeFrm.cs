using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
        }

        private void editMyDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditDetailsFrm editDetailsFrm = new EditDetailsFrm();
            editDetailsFrm.MdiParent = this;
            editDetailsFrm.Show();
        }
    }
}
