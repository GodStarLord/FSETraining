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
    public partial class Trips : Form
    {
        public Trips()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBusName.Clear();
            txtDriverID.Clear();
            txtStop1.Clear();
            txtStop2.Clear();
            txtStop3.Clear();
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            TransportManagementBLLibrary.Trips trips = new TransportManagementBLLibrary.Trips();
            BusinessLogic businessLogic = new BusinessLogic();

            trips.BusName = txtBusName.Text;
            trips.DriverId = Convert.ToInt32(txtDriverID.Text);
            trips.Stop1 = txtStop1.Text;
            trips.Stop2 = txtStop2.Text;
            trips.Stop3 = txtStop3.Text;
            trips.Stop1Time = DateTime.Parse(Stop1DateTime.Text);
            trips.Stop2Time = DateTime.Parse(Stop1DateTime.Text);
            trips.Stop3Time = DateTime.Parse(Stop1DateTime.Text);

            var res = businessLogic.CreateTrips(trips);

            if (res)
                MessageBox.Show("Trip Added");
            else
                MessageBox.Show("Trip Add Unsuccessful");
        }
    }
}
