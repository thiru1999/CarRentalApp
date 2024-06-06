using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
    public static class Utils
    {
        public static string HashPassword(string normalPassword)
        {
            SHA256 sha = SHA256.Create();
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(normalPassword));
            var hashedPassword = new StringBuilder();
            foreach (byte b in data)
            {
                hashedPassword.Append(b.ToString("x2"));
            }
            return hashedPassword.ToString();
        }
    }
}
