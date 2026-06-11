using System;

namespace Sentialx.Classes
{
    public class ReportFilter
    {
        public int? UserID { get; set; }
        public string EventType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Severity { get; set; }
        public int MinCount { get; set; }
        public bool IncludeAlerts { get; set; }

        public ReportFilter()
        {
            FromDate = DateTime.Now.AddDays(-30);
            ToDate = DateTime.Now;
            MinCount = 0;
            IncludeAlerts = true;
        }
    }
}