using FurnitureRental.DBAccess;
using FurnitureRental.Model;
using FurnitureRental.View;

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

        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

            if (employee != null)
            {
                CurrentUser.Login(employee);

                MainMenuForm mainForm = new MainMenuForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        /// <summary>
        /// Handles the FormClosed event of the LoginForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}