using FurnitureRental.Model;

namespace FurnitureRental
{
    /// <summary>
    ///     Class for managing the current logged-in user (employee) in the application.
    /// </summary>
    public static class CurrentUser
    {
        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <value>
        /// The employee.
        /// </value>
        public static Employee? Employee { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is logged in.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is logged in; otherwise, <c>false</c>.
        /// </value>
        public static bool IsLoggedIn => Employee != null;

        /// <summary>
        /// Logins the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public static void Login(Employee employee)
        {
            Employee = employee;
        }

        /// <summary>
        /// Logouts this instance.
        /// </summary>
        public static void Logout()
        {
            Employee = null;
        }
    }
}