using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Sentialx.Classes
{
    public class LogImporter
    {
        public int ImportedCount { get; private set; }
        public int SkippedCount { get; private set; }

        private static readonly string[] ValidTypes =
            { "Login", "FailedLogin", "Action", "Delete", "Error" };

        public void ImportFromCSV(string filePath, ProgressBar progressBar, System.Windows.Forms.Label statusLabel)
        {
            ImportedCount = 0;
            SkippedCount = 0;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length < 2)
                    throw new Exception("File is empty or has no data rows.");

                progressBar.Visible = true;
                progressBar.Maximum = lines.Length - 1;
                progressBar.Value = 0;

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i].Trim();
                    if (string.IsNullOrEmpty(line)) { SkippedCount++; continue; }

                    string[] cols = line.Split(',');
                    if (cols.Length < 4) { SkippedCount++; continue; }

                    try
                    {
                        DateTime timestamp = DateTime.Parse(cols[0].Trim());
                        int userID = int.Parse(cols[1].Trim());
                        string eventType = cols[2].Trim();
                        string description = cols[3].Trim();

                        if (!IsValidType(eventType)) { SkippedCount++; continue; }
                        if (!UserExists(userID)) { SkippedCount++; continue; }

                        InsertEvent(userID, eventType, description, timestamp);

                        // Pass timestamp so ThreatDetector checks within the CSV time window
                        ThreatDetector.CheckRules(userID, timestamp);

                        ImportedCount++;
                    }
                    catch
                    {
                        SkippedCount++;
                    }

                    progressBar.Value = i;
                    statusLabel.Text = "Importing... " + i + " / " + (lines.Length - 1);
                    Application.DoEvents();
                }

                progressBar.Visible = false;
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                throw new Exception("Import failed: " + ex.Message);
            }
        }

        private bool IsValidType(string eventType)
        {
            foreach (string t in ValidTypes)
                if (t == eventType) return true;
            return false;
        }

        private bool UserExists(int userID)
        {
            object result = DatabaseHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Users WHERE UserID=@id",
                new SqlParameter[] { new SqlParameter("@id", userID) });
            return Convert.ToInt32(result) > 0;
        }

        private void InsertEvent(int userID, string eventType, string description, DateTime timestamp)
        {
            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Events (UserID, EventType, Description, Timestamp) VALUES (@uid, @type, @desc, @ts)",
                new SqlParameter[] {
                    new SqlParameter("@uid",  userID),
                    new SqlParameter("@type", eventType),
                    new SqlParameter("@desc", description),
                    new SqlParameter("@ts",   timestamp)
                });
        }

        public static void SaveSampleCSV(string filePath)
        {
            string sample =
                "Timestamp,UserID,EventType,Description\n" +
                "2026-05-01 09:00:01,1,Login,User logged in successfully\n" +
                "2026-05-01 09:01:15,1,Action,Viewed records list\n" +
                "2026-05-01 09:02:30,1,Action,Modified record 12\n" +
                "2026-05-01 09:03:00,1,Delete,Deleted record 5\n" +
                "2026-05-01 09:03:10,1,Delete,Deleted record 6\n" +
                "2026-05-01 09:03:20,1,Delete,Deleted record 7\n" +
                "2026-05-01 09:05:00,1,FailedLogin,Wrong password attempt\n" +
                "2026-05-01 09:05:05,1,FailedLogin,Wrong password attempt\n" +
                "2026-05-01 09:05:10,1,FailedLogin,Wrong password attempt\n" +
                "2026-05-01 09:10:00,1,Error,Connection timeout\n" +
                "2026-05-01 09:10:05,1,Error,Null reference exception\n" +
                "2026-05-01 09:10:10,1,Error,Database query failed\n" +
                "2026-05-01 09:10:15,1,Error,File not found\n" +
                "2026-05-01 09:10:20,1,Error,Access denied\n" +
                "2026-05-01 09:15:00,1,Action,Exported report\n";

            File.WriteAllText(filePath, sample);
        }
    }
}