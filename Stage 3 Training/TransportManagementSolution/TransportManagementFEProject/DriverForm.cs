using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManagementBLLibrary;

namespace TransportManagementFEProject
{
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Clear();
            txtDriverName.Clear();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            BusinessLogic businessLogic = new BusinessLogic();
            Driver driver = new Driver();

            driver.Name = txtDriverName.Text;
            driver.PhoneNumber = txtPhoneNumber.Text;

            var res = businessLogic.CreateDriver(driver);

            if (res)
                MessageBox.Show("Driver Insertion");
            else
                MessageBox.Show("Driver Insertion Unsuccessful");
        }
    }
}
