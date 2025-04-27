using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.services.report
{
    public class ReportSQL
    {
        public string GenerateUsersReport = @"
            SELECT u.id, u.username, 
                    CONCAT(u.first_name, ' ', u.last_name) as full_name,
                    u.email, r.role_name, u.created_at
            FROM Users u
            LEFT JOIN Roles r ON u.role_id = r.id
        ";

        public string GetReportById = "SELECT * FROM reports WHERE ID = @ID;";
        public string GetMyReports = "SELECT * FROM reports WHERE user_id = @user_id;";

        public string GetMyReportsSearch = @"
            SELECT * FROM reports  
            WHERE user_id = @user_id 
            AND (
                    report_name ILIKE '%' || @searchTerm || '%'
                    OR report_type ILIKE '%' || @searchTerm || '%'
                )
        ;";

        public string GetAllReports = "SELECT * FROM reports;";

        public string GetAllReportsSearch = @"
            SELECT * FROM reports  
            WHERE 
            report_name ILIKE '%' || @searchTerm || '%'
            OR report_type ILIKE '%' || @searchTerm || '%'
        ;";

        public string GetAllRequests => @"
    SELECT 
        t.id, 
        t.title, 
        s.status_name as status, 
        p.priority_name as priority, 
        CONCAT(u1.first_name, ' ', u1.last_name) as author,
        CONCAT(u2.first_name, ' ', u2.last_name) as assignee,
        t.created_at as created_date, 
        t.closed_at as completed_date
    FROM Tickets t
    JOIN Statuses s ON t.status_id = s.id
    JOIN Priorities p ON t.priority_id = p.id
    JOIN Users u1 ON t.client_id = u1.id
    LEFT JOIN Users u2 ON t.assigned_to = u2.id
    ORDER BY t.created_at DESC";

        public string GetRequestsByDateRange => @"
    SELECT 
        t.id, 
        t.title, 
        s.status_name as status, 
        p.priority_name as priority, 
        CONCAT(u1.first_name, ' ', u1.last_name) as author,
        CONCAT(u2.first_name, ' ', u2.last_name) as assignee,
        t.created_at as created_date, 
        t.closed_at as completed_date
    FROM Tickets t
    JOIN Statuses s ON t.status_id = s.id
    JOIN Priorities p ON t.priority_id = p.id
    JOIN Users u1 ON t.client_id = u1.id
    LEFT JOIN Users u2 ON t.assigned_to = u2.id
    WHERE t.created_at BETWEEN @startDate AND @endDate
    ORDER BY t.created_at DESC";

    }

}
