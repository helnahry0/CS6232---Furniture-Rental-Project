using FurnitureRental.Model;

namespace FurnitureRental
{
    public static class CurrentUser
    {
        public static Employee? Employee { get; private set; }

        public static bool IsLoggedIn => Employee != null;

        public static void Login(Employee employee)
        {
            Employee = employee;
        }

        public static void Logout()
        {
            Employee = null;
        }
    }
}