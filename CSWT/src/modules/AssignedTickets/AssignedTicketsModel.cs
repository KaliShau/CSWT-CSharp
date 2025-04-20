using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.status;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.AssignedTickets
{
    public class AssignedTicketsModel
    {
        TicketService _ticketService;
        public AssignedTicketsModel(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public TicketWithJoinDTO[] GetAssignedTickets(int assigned_to)
        {
            return _ticketService.GetAssignedTickets(assigned_to);
        }

        public TicketWithJoinDTO[] GetAssignedTicketsSearch(int assigned_to, string searchTerm)
        {
            return _ticketService.GetAssignedTicketsSearch(assigned_to, searchTerm);
        }
    }
}
