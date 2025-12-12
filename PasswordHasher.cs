using System;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApp1
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16;      
        private const int HashSize = 32;    
        private const int Iterations = 100_000; 

        public static string Hash(string password)
        {
            if (password is null) throw new ArgumentNullException(nameof(password));

            using (var rng = RandomNumberGenerator.Create())
            {
                var salt = new byte[SaltSize];
                rng.GetBytes(salt);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
                {
                    var hash = pbkdf2.GetBytes(HashSize);
                    return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
                }
            }
        }
        public static bool Verify(string password, string stored)
        {
            if (password is null) throw new ArgumentNullException(nameof(password));
            if (string.IsNullOrWhiteSpace(stored)) return false;

            var parts = stored.Split('.');
            if (parts.Length != 3) return false;

            if (!int.TryParse(parts[0], out int iterations)) return false;
            var salt = Convert.FromBase64String(parts[1]);
            var storedHash = Convert.FromBase64String(parts[2]);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                var computedHash = pbkdf2.GetBytes(storedHash.Length);
                return FixedTimeEquals(storedHash, computedHash);
            }
        }
        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++)
                diff |= a[i] ^ b[i];
            return diff == 0;
        }
    }
}
