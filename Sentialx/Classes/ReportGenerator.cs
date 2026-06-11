using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Sentialx.Classes
{
    public class ReportGenerator
    {
        public ReportFilter Filter { get; set; }
        private StringBuilder _report;

        public ReportGenerator(ReportFilter filter)
        {
            Filter = filter;
            _report = new StringBuilder();
        }

        public string Generate()
        {
            _report.Clear();
            AppendHeader();
            AppendFiltersUsed();
            AppendEventSummary();
            AppendTopUsers();
            if (Filter.MinCount > 0) AppendThresholdExceeded();
            if (Filter.IncludeAlerts) AppendAlertsSummary();
            AppendFooter();
            return _report.ToString();
        }

        private void AppendHeader()
        {
            _report.AppendLine("============================================");
            _report.AppendLine("          SYSTEM ACTIVITY REPORT");
            _report.AppendLine("  Generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            _report.AppendLine("============================================");
        }

        private void AppendFiltersUsed()
        {
            _report.AppendLine("Type     : " + (Filter.EventType ?? "All"));
            _report.AppendLine("User     : " + (Filter.UserID.HasValue ? Filter.UserID.ToString() : "All"));
            _report.AppendLine("From     : " + Filter.FromDate.ToString("yyyy-MM-dd"));
            _report.AppendLine("To       : " + Filter.ToDate.ToString("yyyy-MM-dd"));
            _report.AppendLine("Min Count: " + (Filter.MinCount > 0 ? Filter.MinCount.ToString() : "None"));
            _report.AppendLine("Alerts   : " + (Filter.IncludeAlerts ? "Included" : "Excluded"));
            _report.AppendLine("--------------------------------------------");
        }

        private DataTable GetFilteredEvents()
        {
            StringBuilder q = new StringBuilder(
                "SELECT e.EventID, u.Username, e.EventType, e.Description, e.Timestamp " +
                "FROM Events e JOIN Users u ON e.UserID = u.UserID " +
                "WHERE e.Timestamp BETWEEN @from AND @to");

            if (Filter.UserID.HasValue)
                q.Append(" AND e.UserID=@uid");
            if (!string.IsNullOrEmpty(Filter.EventType))
                q.Append(" AND e.EventType=@type");
            q.Append(" ORDER BY e.Timestamp DESC");

            List<SqlParameter> pList = new List<SqlParameter>();
            pList.Add(new SqlParameter("@from", Filter.FromDate));
            pList.Add(new SqlParameter("@to", Filter.ToDate));
            if (Filter.UserID.HasValue)
                pList.Add(new SqlParameter("@uid", Filter.UserID.Value));
            if (!string.IsNullOrEmpty(Filter.EventType))
                pList.Add(new SqlParameter("@type", Filter.EventType));

            return DatabaseHelper.ExecuteQuery(q.ToString(), pList.ToArray());
        }

        private void AppendEventSummary()
        {
            DataTable dt = GetFilteredEvents();
            _report.AppendLine("Total Events Matched: " + dt.Rows.Count);
            _report.AppendLine();

            Dictionary<string, int> typeCounts = new Dictionary<string, int>();
            foreach (DataRow row in dt.Rows)
            {
                string t = row["EventType"].ToString();
                if (!typeCounts.ContainsKey(t)) typeCounts[t] = 0;
                typeCounts[t]++;
            }

            _report.AppendLine("By Event Type:");
            foreach (KeyValuePair<string, int> kv in typeCounts)
            {
                double pct = dt.Rows.Count > 0 ? (kv.Value * 100.0 / dt.Rows.Count) : 0;
                _report.AppendLine("  " + kv.Key.PadRight(20) + ": " + kv.Value.ToString().PadLeft(4) + "  (" + pct.ToString("F1") + "%)");
            }
            _report.AppendLine();
        }

        private void AppendTopUsers()
        {
            string query =
                "SELECT TOP 5 u.Username, COUNT(*) AS Total " +
                "FROM Events e JOIN Users u ON e.UserID = u.UserID " +
                "WHERE e.Timestamp BETWEEN @from AND @to " +
                "GROUP BY u.Username ORDER BY Total DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query, new SqlParameter[] {
                new SqlParameter("@from", Filter.FromDate),
                new SqlParameter("@to",   Filter.ToDate)
            });

            _report.AppendLine("Top Users:");
            foreach (DataRow row in dt.Rows)
                _report.AppendLine("  " + row["Username"].ToString().PadRight(20) + ": " + row["Total"] + " events");
            _report.AppendLine();
        }

        private void AppendThresholdExceeded()
        {
            string query =
                "SELECT u.Username, e.EventType, COUNT(*) AS Total " +
                "FROM Events e JOIN Users u ON e.UserID = u.UserID " +
                "WHERE e.Timestamp BETWEEN @from AND @to " +
                "GROUP BY u.Username, e.EventType " +
                "HAVING COUNT(*) >= @min ORDER BY Total DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query, new SqlParameter[] {
                new SqlParameter("@from", Filter.FromDate),
                new SqlParameter("@to",   Filter.ToDate),
                new SqlParameter("@min",  Filter.MinCount)
            });

            _report.AppendLine("Threshold Exceeded (>= " + Filter.MinCount + "):");
            if (dt.Rows.Count == 0)
                _report.AppendLine("  None.");
            else
                foreach (DataRow row in dt.Rows)
                    _report.AppendLine("  " + row["Username"].ToString().PadRight(20) + " | " +
                                       row["EventType"].ToString().PadRight(15) + " | " +
                                       row["Total"] + " times");
            _report.AppendLine();
        }

        private void AppendAlertsSummary()
        {
            StringBuilder q = new StringBuilder(
                "SELECT a.AlertType, a.Severity, u.Username, a.Timestamp " +
                "FROM Alerts a " +
                "JOIN Events e ON a.EventID = e.EventID " +
                "JOIN Users  u ON e.UserID  = u.UserID " +
                "WHERE a.Timestamp BETWEEN @from AND @to");

            if (!string.IsNullOrEmpty(Filter.Severity))
                q.Append(" AND a.Severity=@sev");
            q.Append(" ORDER BY a.Timestamp DESC");

            List<SqlParameter> pList = new List<SqlParameter>();
            pList.Add(new SqlParameter("@from", Filter.FromDate));
            pList.Add(new SqlParameter("@to", Filter.ToDate));
            if (!string.IsNullOrEmpty(Filter.Severity))
                pList.Add(new SqlParameter("@sev", Filter.Severity));

            DataTable dt = DatabaseHelper.ExecuteQuery(q.ToString(), pList.ToArray());

            _report.AppendLine("Alerts Summary:");
            if (dt.Rows.Count == 0)
                _report.AppendLine("  No alerts in this period.");
            else
                foreach (DataRow row in dt.Rows)
                    _report.AppendLine("  [" + row["Severity"].ToString().PadRight(6) + "] " +
                                       row["AlertType"].ToString().PadRight(22) + " | " +
                                       row["Username"].ToString().PadRight(15) + " | " +
                                       Convert.ToDateTime(row["Timestamp"]).ToString("yyyy-MM-dd"));
            _report.AppendLine();
        }

        private void AppendFooter()
        {
            _report.AppendLine("============================================");
            _report.AppendLine("  Generated by Sentialx Monitoring System");
            _report.AppendLine("============================================");
        }

        public void ExportToFile(string filePath)
        {
            try
            {
                File.WriteAllText(filePath, _report.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception("Export failed: " + ex.Message);
            }
        }
    }
}