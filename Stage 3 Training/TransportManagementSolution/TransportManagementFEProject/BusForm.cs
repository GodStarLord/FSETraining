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
    public partial class BusForm : Form
    {
        public BusForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBusCapcity.Clear();
            txtBusNumber.Clear();
            txtBusOccupancy.Clear();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            BusinessLogic businessLogic = new BusinessLogic();

            bus.BusNumber = txtBusNumber.Text;
            bus.Capacity = Convert.ToInt32(txtBusCapcity.Text);
            bus.Occupancy = Convert.ToInt32(txtBusOccupancy.Text);

            var res = businessLogic.CreateBus(bus);

            if (res)
                MessageBox.Show("Bus Added");
            else
                MessageBox.Show("Bus Add Unsuccessful");
        }
    }
}
