using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Sentialx.Classes
{
    public class EventLog
    {
        public int EventID { get; set; }
        public int UserID { get; set; }
        public string EventType { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }

        public void Save()
        {
            string query = @"INSERT INTO Events (UserID, EventType, Description)
                             VALUES (@uid, @type, @desc)";
            SqlParameter[] p = {
                new SqlParameter("@uid",  UserID),
                new SqlParameter("@type", EventType),
                new SqlParameter("@desc", Description)
            };
            DatabaseHelper.ExecuteNonQuery(query, p);
        }

        public static DataTable GetAll()
        {
            string query = @"SELECT e.EventID, u.Username, e.EventType,
                                    e.Description, e.Timestamp
                             FROM Events e
                             JOIN Users u ON e.UserID = u.UserID
                             ORDER BY e.Timestamp DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static DataTable GetByUser(int userID)
        {
            string query = "SELECT * FROM Events WHERE UserID=@uid ORDER BY Timestamp DESC";
            return DatabaseHelper.ExecuteQuery(query,
                new[] { new SqlParameter("@uid", userID) });
        }

        public static DataTable GetByDateRange(DateTime from, DateTime to)
        {
            string query = @"SELECT e.*, u.Username FROM Events e
                             JOIN Users u ON e.UserID = u.UserID
                             WHERE e.Timestamp BETWEEN @from AND @to
                             ORDER BY e.Timestamp DESC";
            SqlParameter[] p = {
                new SqlParameter("@from", from),
                new SqlParameter("@to",   to)
            };
            return DatabaseHelper.ExecuteQuery(query, p);
        }

        public static DataTable GetByType(string eventType)
        {
            string query = @"SELECT e.*, u.Username FROM Events e
                             JOIN Users u ON e.UserID = u.UserID
                             WHERE e.EventType=@type ORDER BY e.Timestamp DESC";
            return DatabaseHelper.ExecuteQuery(query,
                new[] { new SqlParameter("@type", eventType) });
        }
    }
}
