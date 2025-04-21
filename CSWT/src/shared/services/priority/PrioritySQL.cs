using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWT.src.shared.services.priority
{
    public class PrioritySQL
    {
        public string GetPriorities = "SELECT * FROM Priorities;";

        public string GetPriorityByID = "SELECT * FROM Priorities WHERE ID = @ID;";

        public string CreatePriority = @"
            INSERT INTO Priorities (priority_name, description) VALUES 
            (@priority_name, @description);
        ";

        public string DeletePrioity = @"
            DELETE FROM Priorities WHERE ID = @ID;
        ";
    }
}

