using System;
using System.Collections.Generic;

namespace CSWT.src.shared.services.report
{
    public class ReportDTO
    {
        public int ID { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string report_name { get; set; }
        public string report_type { get; set; }
    }

    public class ReportWithJson : ReportDTO
    {
        public string json { get; set; }
    }

    //////////////////////// 

    public class ReportBase
    {
        public string Title { get; set; }
        public DateTime GeneratedAt { get; set; }
        public int CurrentUserId { get; set; }
    }


    public class UsersReport : ReportBase
    {
        public List<UserReportItem> Users { get; set; } 
    }

    public class UserReportItem
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    //////////////////////// 

    public class RequestsReport : ReportBase
    {
        public List<RequestReportItem> Requests { get; set; }
        public string PeriodDescription { get; set; } 
    }

    public class RequestReportItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Author { get; set; }
        public string Assignee { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
