using FurnitureRental.DAL;
using FurnitureRental.Model;

namespace FurnitureRental.Controller
{
    /// <summary>
    /// Handles employee authentication logic.
    /// </summary>
    public class EmployeeController
    {
        private readonly EmployeeDbDal employeeDbDal;

        /// <summary>
        /// Creates a new EmployeeController.
        /// </summary>
        public EmployeeController()
        {
            employeeDbDal = new EmployeeDbDal();
        }

        /// <summary>
        /// Authenticates an employee by username and password.
        /// </summary>
        /// <param name="username">The employee username.</param>
        /// <param name="password">The employee password.</param>
        /// <param name="errorMessage">Validation or authentication error.</param>
        /// <returns>The authenticated employee or null if authentication fails.</returns>
        public Employee? AuthenticateEmployee(string username, string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            username = username.Trim();
            password = password.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Username is required.";
                return null;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Password is required.";
                return null;
            }

            Employee? employee = employeeDbDal.AuthenticateEmployee(username, password);

            if (employee == null)
            {
                errorMessage = "Invalid username or password.";
                return null;
            }

            return employee;
        }
    }
}