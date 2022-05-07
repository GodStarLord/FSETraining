using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.EntityData;

namespace WinForm
{
    public partial class Update_Password : Form
    {
        public Update_Password()
        {
            InitializeComponent();
            
        }

        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            HandsonDemoEntities _context = new HandsonDemoEntities();
            var employee = _context.EmployeeDetails.SingleOrDefault(x => x.Email == txtEmail.Text);
            
            if ( employee != null && employee.Password == txtTempPassword.Text)
            {
                MessageBox.Show("You can update your password");
            }
            else
            {
                MessageBox.Show("Wrong Password / Employee not found");
            }
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            HandsonDemoEntities _context = new HandsonDemoEntities();
            var employee = _context.EmployeeDetails.SingleOrDefault(x => x.Email == txtEmail.Text);

            if (employee != null)
            {
                employee.Password = txtPassword.Text;
                _context.SaveChanges();
                MessageBox.Show("Password Updated");
            }
        }
    }
}
