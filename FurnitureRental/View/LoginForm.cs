using FurnitureRental.DBAcess;
using FurnitureRental.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace FurnitureRental
{
    public partial class LoginForm : Form
    {
        private readonly EmployeeDbDal employeeDbDal = new EmployeeDbDal();

        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            lblError.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                lblError.Text = "Username is required.";
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Password is required.";
                txtPassword.Focus();
                return;
            }

            Employee? employee = employeeDbDal.AuthenticateEmployee(username, password);

            if (employee == null)
            {
                lblError.Text = "Invalid username or password.";
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            CurrentUser.Login(employee);

            Form1 mainForm = new Form1();
            mainForm.Show();

            Hide();
        }
    }
}