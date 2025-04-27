using System;
using System.Collections.Generic;

namespace CSWT.src.shared.services.report
{
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
}
