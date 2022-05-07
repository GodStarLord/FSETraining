using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.EntityData;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCity.Items.Add("Banglore");
            txtCity.Items.Add("Hubli");
            txtCity.Items.Add("Pune");
            txtCity.Items.Add("Hyderabad");
        }

        public int CalculateAge()
        {
            var today = DateTime.Today;
            var dob = DateTime.Parse(txtDateTime.Text);
            var age = today.Year - dob.Year;

            if (dob.Date > today.AddYears(-age)) age--;

            return age;
        }

        public void InsertIntoDb()
        {
            int age = CalculateAge();

            EmployeeDetail employee = new EmployeeDetail();
            employee.Name = txtFirstName.Text + " " + txtLastName.Text;
            employee.Age = age;
            employee.DateOfBirth = DateTime.Parse(txtDateTime.Text);
            employee.Gender = txtGender.Text;
            employee.Phone = txtPhone.Text;
            employee.City = txtCity.Text;
            employee.Email = txtEmail.Text;

            var tempPassword = PasswordGenerator();
            lblTempPassword.Text = "Your temporary password is " + tempPassword;

            employee.Password = tempPassword;

            HandsonDemoEntities context = new HandsonDemoEntities();

            try
            {
                context.EmployeeDetails.Add(employee);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            MessageBox.Show("Employee Added and your temporay password is " + tempPassword);
            Update_Password formPassword = new Update_Password();
            Hide();
            formPassword.Show();

        }

        public string PasswordGenerator()
        {
            int min = 1000;
            int max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(min, max).ToString();
        }

        private void btnCalculateAge_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" &&
                txtLastName.Text != "" &&
                txtGender.Text != "" &&
                txtCity.Text != "" &&
                txtPhone.Text != "" &&
                txtEmail.Text != ""
            )
            {
                var phoneNumberIsValid = Regex.IsMatch(txtPhone.Text, @"\+?\d[\d -]{8,12}\d");
                var emailIsValid = Regex.IsMatch(txtEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                
                if (phoneNumberIsValid)
                    if (emailIsValid)
                    {
                        InsertIntoDb();
                    }
                    else
                        MessageBox.Show("Email is Invalid");
                else
                    MessageBox.Show("Phone Number is Invalid");
            }
            else
                MessageBox.Show("All Fields are required");
        }
    }
}
