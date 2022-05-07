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
    public partial class frmAllocateBus : Form
    {
        int GetEmployeeId()
        {
            int eid;
            if (!Int32.TryParse(txtEmployeeID.Text, out eid))
            {
                txtEmployeeID.Clear();
                MessageBox.Show("Invalid Employee Id");
                txtEmployeeID.Focus();

            }
            return eid;
        }

        public frmAllocateBus()
        {
            InitializeComponent();
        }

        private void btnGetBus_Click(object sender, EventArgs e)
        {
            int eid = GetEmployeeId();

            if (eid != 0)
            {
                Booking booking = new Booking();

                List<string> busNumbers = booking.GetBusForEmployee(eid);

                if (busNumbers.Count > 0)
                {
                    foreach (string item in busNumbers)
                    {
                        ddlBusNumbers.Items.Add(item);
                    }

                    ddlBusNumbers.Visible = true;
                }
                else
                {
                    MessageBox.Show("No bus available now....");
                    ddlBusNumbers.Visible = false;
                }
            }
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            int eid = GetEmployeeId();

            string busNumber = ddlBusNumbers.SelectedItem.ToString();

            if (booking.AllocateBusForEmployee(eid, busNumber))
                MessageBox.Show("Success !!! Employee is allocated with bus");
        }
    }
}
