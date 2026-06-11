using System;
using Microsoft.Data.SqlClient;

namespace Sentialx.Classes
{
    public static class ThreatDetector
    {
        public static int FailedLoginThreshold = 3;
        public static int RapidActionThreshold = 10;
        public static int MassDeleteThreshold = 3;
        public static int ErrorSpikeThreshold = 5;
        public static int TimeWindowSeconds = 60;

        public static void CheckRules(int userID)
        {
            CheckRules(userID, DateTime.Now);
        }

        public static void CheckRules(int userID, DateTime referenceTime)
        {
            DateTime window = referenceTime.AddSeconds(-TimeWindowSeconds);
            CheckFailedLogins(userID, window, referenceTime);
            CheckRapidActions(userID, window, referenceTime);
            CheckMassDelete(userID, window, referenceTime);
            CheckErrorSpike(window, referenceTime);
        }

        private static int CountEvents(int userID, string eventType, DateTime since, DateTime until)
        {
            string query = @"SELECT COUNT(*) FROM Events
                             WHERE UserID=@uid AND EventType=@type
                             AND Timestamp >= @since AND Timestamp <= @until";
            SqlParameter[] p = {
                new SqlParameter("@uid",   userID),
                new SqlParameter("@type",  eventType),
                new SqlParameter("@since", since),
                new SqlParameter("@until", until)
            };
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, p));
        }

        private static int GetLastEventID(int userID, DateTime until)
        {
            string query = @"SELECT TOP 1 EventID FROM Events
                             WHERE UserID=@uid AND Timestamp <= @until
                             ORDER BY Timestamp DESC";
            SqlParameter[] p = {
                new SqlParameter("@uid",   userID),
                new SqlParameter("@until", until)
            };
            object result = DatabaseHelper.ExecuteScalar(query, p);
            return result == null ? 0 : Convert.ToInt32(result);
        }

        private static void RaiseAlert(int eventID, string alertType, string severity)
        {
            if (eventID <= 0) return;

            string check = @"SELECT COUNT(*) FROM Alerts
                             WHERE EventID=@eid AND AlertType=@type AND IsResolved=0";
            SqlParameter[] cp = {
                new SqlParameter("@eid",  eventID),
                new SqlParameter("@type", alertType)
            };
            int existing = Convert.ToInt32(DatabaseHelper.ExecuteScalar(check, cp));
            if (existing > 0) return;

            new Alert
            {
                EventID = eventID,
                AlertType = alertType,
                Severity = severity
            }.Save();
        }

        private static void CheckFailedLogins(int userID, DateTime since, DateTime until)
        {
            if (CountEvents(userID, "FailedLogin", since, until) >= FailedLoginThreshold)
                RaiseAlert(GetLastEventID(userID, until), "BruteForce", "High");
        }

        private static void CheckRapidActions(int userID, DateTime since, DateTime until)
        {
            if (CountEvents(userID, "Action", since, until) >= RapidActionThreshold)
                RaiseAlert(GetLastEventID(userID, until), "SuspiciousActivity", "Medium");
        }

        private static void CheckMassDelete(int userID, DateTime since, DateTime until)
        {
            if (CountEvents(userID, "Delete", since, until) >= MassDeleteThreshold)
                RaiseAlert(GetLastEventID(userID, until), "MassDelete", "High");
        }

        private static void CheckErrorSpike(DateTime since, DateTime until)
        {
            string query = @"SELECT COUNT(*) FROM Events
                             WHERE EventType='Error'
                             AND Timestamp >= @since AND Timestamp <= @until";
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, new[] {
                new SqlParameter("@since", since),
                new SqlParameter("@until", until)
            }));

            if (count >= ErrorSpikeThreshold)
            {
                string latest = @"SELECT TOP 1 EventID FROM Events
                                  WHERE EventType='Error' AND Timestamp <= @until
                                  ORDER BY Timestamp DESC";
                object eid = DatabaseHelper.ExecuteScalar(latest,
                    new[] { new SqlParameter("@until", until) });
                if (eid != null)
                    RaiseAlert(Convert.ToInt32(eid), "SystemInstability", "Medium");
            }
        }
    }
}