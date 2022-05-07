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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            BusinessLogic businessLogic = new BusinessLogic();

            employee.Name = txtName.Text;
            employee.Address = txtAddress.Text;
            employee.Email = txtEmail.Text;
            employee.Phone = txtPhone.Text;
            employee.Age = Convert.ToInt32(txtAge.Text);
            employee.Location = txtLocation.Text;

            var res = businessLogic.CreateEmployee(employee);

            if (res)
                MessageBox.Show("Employee Added");
            else
                MessageBox.Show("Employee Add Unsuccessful");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLocation.Clear();
            txtAge.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }
    }
}
