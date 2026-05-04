using System.Security.Cryptography;
using System.Text;

namespace FurnitureRental.Security
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(bytes);
            return Convert.ToHexString(hashBytes);
        }

        public static bool VerifyPassword(string plainTextPassword, string storedHash)
        {
            string computedHash = HashPassword(plainTextPassword);
            return string.Equals(computedHash, storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}