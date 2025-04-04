using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.db;

namespace CSWT.src.shared.services.ticket
{
    public class TicketSQL
    {
        public string CreateTicket = @"INSERT INTO Tickets 
            (title, description, client_id, priority_id, status_id) VALUES
            (@title, @description, @client_id, @priority_id, @status_id);
        ";
    }
}
