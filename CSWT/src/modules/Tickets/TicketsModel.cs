using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.Tickets
{
    public class TicketsModel
    {
        TicketService _ticketService;
        public TicketsModel(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public TicketWithJoinDTO[] GetTickets()
        {
            return _ticketService.GetTickets();
        }

        public void DeleteTicket(int ID)
        {
            _ticketService.DeleteTicket(ID);
        }
    }
}
