using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Sentialx.Classes
{
    public class Alert
    {
        public int AlertID { get; set; }
        public int EventID { get; set; }
        public string AlertType { get; set; }
        public string Severity { get; set; }
        public bool IsResolved { get; set; }
        public DateTime Timestamp { get; set; }

        public void Save()
        {
            string query = @"INSERT INTO Alerts (EventID, AlertType, Severity)
                             VALUES (@eid, @type, @sev)";
            SqlParameter[] p = {
                new SqlParameter("@eid",  EventID),
                new SqlParameter("@type", AlertType),
                new SqlParameter("@sev",  Severity)
            };
            DatabaseHelper.ExecuteNonQuery(query, p);
        }

        public static void Resolve(int alertID)
        {
            string query = "UPDATE Alerts SET IsResolved=1 WHERE AlertID=@id";
            DatabaseHelper.ExecuteNonQuery(query,
                new[] { new SqlParameter("@id", alertID) });
        }

        public static DataTable GetOpen()
        {
            string query = @"SELECT a.AlertID, a.AlertType, a.Severity,
                                    e.EventType, u.Username, a.Timestamp
                             FROM Alerts a
                             JOIN Events e ON a.EventID = e.EventID
                             JOIN Users  u ON e.UserID  = u.UserID
                             WHERE a.IsResolved = 0
                             ORDER BY a.Timestamp DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static DataTable GetBySeverity(string severity)
        {
            string query = @"SELECT a.*, u.Username FROM Alerts a
                             JOIN Events e ON a.EventID = e.EventID
                             JOIN Users  u ON e.UserID  = u.UserID
                             WHERE a.Severity=@sev ORDER BY a.Timestamp DESC";
            return DatabaseHelper.ExecuteQuery(query,
                new[] { new SqlParameter("@sev", severity) });
        }
    }
}
