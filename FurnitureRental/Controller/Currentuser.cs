using FurnitureRental.Model;

namespace FurnitureRental.Controller
{
    /// <summary>
    /// Class for managing the current logged-in employee in the application.
    /// </summary>
    public static class CurrentUser
    {
        /// <summary>
        /// Gets the current employee.
        /// </summary>
        public static Employee? Employee { get; private set; }

        /// <summary>
        /// Logs in the specified employee.
        /// </summary>
        /// <param name="employee">The employee to log in.</param>
        public static void Login(Employee employee)
        {
            Employee = employee;
        }

        /// <summary>
        /// Logs out the current employee.
        /// </summary>
        public static void Logout()
        {
            Employee = null;
        }
    }
}