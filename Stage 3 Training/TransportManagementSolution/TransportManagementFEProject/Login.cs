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
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BusinessLogic businessLogic = new BusinessLogic();

            var username = txtUserName.Text.ToString();
            var password = txtPassword.Text.ToString();

            //var result = businessLogic.LoginCheck(username, password);

            if (businessLogic.userName.Equals(username) && businessLogic.passWord.Equals(password))
            {
                Home homeForm = new Home();
                homeForm.Show();

                Hide();
            }
            else
            {
                MessageBox.Show("Username and Password is incorrect. Try again !");
            }

            //if (result)
            //{
            //    Home homeForm = new Home();
            //    homeForm.Show();

            //    Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Username and Password is incorrect. Try again !");
            //}
        }
    }
}
