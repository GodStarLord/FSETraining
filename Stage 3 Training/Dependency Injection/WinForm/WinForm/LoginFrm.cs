using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.EntityData;

namespace WinForm
{
    public partial class LoginFrm : Form
    {
        public static string UserName;
        public static string Email;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HandsonDemoEntities _context = new HandsonDemoEntities();

            var details = _context.EmployeeDetails.SingleOrDefault(x => x.Email == txtEmail.Text);
            UserName = details.Name;
            Email = details.Email;

            if (details != null && details.Password == txtPassword.Text)
            {
                HomeFrm homeFrm = new HomeFrm();
                Hide();
                homeFrm.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
