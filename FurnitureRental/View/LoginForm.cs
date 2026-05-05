using FurnitureRental.Controller;
using FurnitureRental.Model;
using FurnitureRental.View;

namespace FurnitureRental
{
    /// <summary>
    /// Provides the employee login screen.
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly EmployeeController employeeController;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            txtPassword.UseSystemPasswordChar = true;
            lblError.Text = string.Empty;
        }

        /// <summary>
        /// Handles the login button click event.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;

            Employee? employee = employeeController.AuthenticateEmployee(
                txtUsername.Text,
                txtPassword.Text,
                out string errorMessage);

            if (employee == null)
            {
                lblError.Text = errorMessage;
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            CurrentUser.Login(employee);

            txtPassword.Clear();
            Hide();

            using MainMenuForm mainForm = new MainMenuForm();
            DialogResult result = mainForm.ShowDialog();

            if (result == DialogResult.Retry)
            {
                Show();
                txtUsername.Focus();
                return;
            }

            Close();
        }

        /// <summary>
        /// Handles the form closed event.
        /// </summary>
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}