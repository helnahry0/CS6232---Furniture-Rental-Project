using System.Security.Cryptography;
using System.Text;

namespace FurnitureRental.Security
{
    /// <summary>
    /// Provides helper methods for hashing and verifying user passwords.
    /// </summary>
    public static class PasswordHelper
    {
        /// <summary>
        /// Generates a SHA-256 hash for the given plain text password.
        /// </summary>
        /// <param name="password">The plain text [password to hash.</param>
        /// <returns>A hexadecimal string representing the hashed password.</returns>
        public static string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(bytes);
            return Convert.ToHexString(hashBytes);
        }

        /// <summary>
        /// Verifies whether a plain text password matches a stored hashed password. 
        /// </summary>
        /// <param name="plainTextPassword"></param>
        /// <param name="storedHash"></param>
        /// <returns>True, if the computer hash of the input password matches the stored hash. Otherwise, false</returns>
        public static bool VerifyPassword(string plainTextPassword, string storedHash)
        {
            string computedHash = HashPassword(plainTextPassword);
            return string.Equals(computedHash, storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}