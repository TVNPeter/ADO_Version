using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EF_Version
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert string to byte[]
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                // Hash
                byte[] hash = sha256.ComputeHash(bytes);
                // Convert byte[] to hex string
                StringBuilder result = new StringBuilder();
                foreach (byte b in hash)
                    result.Append(b.ToString("x2"));
                return result.ToString();
            }
        }
    }
}