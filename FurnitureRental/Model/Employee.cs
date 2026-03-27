namespace FurnitureRental.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Role { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}".Trim();
    }
}