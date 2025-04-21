using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.services.status
{
    public class StatusSQL
    {
        public string GetStatusByID = @"
            SELECT * FROM Statuses WHERE ID = @ID;
        ";

        public string GetStatusByStatusName = @"
            SELECT * FROM Statuses WHERE status_name = @status_name;
        ";

        public string GetStatuses = "SELECT * FROM Statuses;";

        public string CreateStatus = @"
            INSERT INTO Statuses (status_name, description) VALUES 
            (@status_name, @description);
        ";

        public string DeleteStatus = @"
            DELETE FROM Statuses WHERE ID = @ID;
        ";
    }
}
