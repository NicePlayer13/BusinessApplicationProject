using System.Security.Cryptography;
using System.Text;

namespace BusinessApplicationProject.Helpers
{
    /// <summary>
    /// Provides functionality to securely hash passwords using SHA-256.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>
        /// Hashes a plain text password using SHA-256.
        /// </summary>
        /// <param name="password">The plain text password to hash.</param>
        /// <returns>The hashed password as a lowercase hexadecimal string.</returns>
        public static string Hash(string password)
        {
            using var sha = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }
}
