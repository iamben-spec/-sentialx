using System;

namespace Sentialx.Classes
{
    public static class EventLogger
    {
        private static void Log(int userID, string type, string description)
        {
            EventLog ev = new EventLog
            {
                UserID = userID,
                EventType = type,
                Description = description
            };
            ev.Save();
            ThreatDetector.CheckRules(userID);
        }

        public static void LogLogin(int userID, string username)
            => Log(userID, "Login", $"User '{username}' logged in successfully.");

        public static void LogFailedLogin(int userID, string username)
            => Log(userID, "FailedLogin", $"Failed login attempt for '{username}'.");

        public static void LogAction(int userID, string actionDetail)
            => Log(userID, "Action", actionDetail);

        public static void LogDelete(int userID, string deleteDetail)
            => Log(userID, "Delete", deleteDetail);

        public static void LogError(int userID, string errorDetail)
            => Log(userID, "Error", errorDetail);
    }
}
