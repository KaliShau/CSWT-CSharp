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
        LEFT JOIN Roles r ON u.role_id = r.id";
    }
}
