using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Sentialx.Classes
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }

        public static string HashPassword(string plainText)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }

        public static User Authenticate(string username, string password)
        {
            string hash = HashPassword(password);
            string query = "SELECT * FROM Users WHERE Username=@u AND PasswordHash=@p";
            SqlParameter[] p = {
                new SqlParameter("@u", username),
                new SqlParameter("@p", hash)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, p);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new User
            {
                UserID = Convert.ToInt32(row["UserID"]),
                Username = row["Username"].ToString(),
                PasswordHash = row["PasswordHash"].ToString(),
                Role = row["Role"].ToString(),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }

        public override string ToString() => $"{Username} ({Role})";
    }
}