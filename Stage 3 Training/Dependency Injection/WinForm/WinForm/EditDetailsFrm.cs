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
    public partial class EditDetailsFrm : Form
    {
        private EmployeeDetail details;

        public EditDetailsFrm()
        {
            InitializeComponent();
        }

        public void InsertIntoDb()
        {
            HandsonDemoEntities _context = new HandsonDemoEntities();
            details = _context.EmployeeDetails.SingleOrDefault(x => x.Email == LoginFrm.Email);

            details.Name = txtName.Text;
            details.City = txtCity.Text;
            details.DateOfBirth = DateTime.Parse(txtDateTime.Text);
            details.Gender = txtGender.Text;
            details.Phone = txtPhone.Text;

            _context.SaveChanges();

            MessageBox.Show("Details Updated");

        }
        private void EditDetailsFrm_Load(object sender, EventArgs e)
        {
            HandsonDemoEntities _context = new HandsonDemoEntities();

            details = _context.EmployeeDetails.SingleOrDefault(x => x.Email == LoginFrm.Email);

            txtName.Text = details.Name;
            txtDateTime.Value = (DateTime)details.DateOfBirth;
            txtGender.Text = details.Gender;
            txtCity.Text = details.City;
            txtPhone.Text = details.Phone;
            txtEmail.Text = details.Email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
    }
}
