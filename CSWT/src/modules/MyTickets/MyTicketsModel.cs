using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.MyTickets
{
    public class MyTicketsModel
    {
        TicketService _ticketService;
        public MyTicketsModel(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public TicketWithJoinDTO[] GetMyTickets(int client_id)
        {
            return _ticketService.GetTicketsByClientId(client_id);
        }

        public TicketWithJoinDTO[] GetMyTicketsSearch(int client_id, string searchTerm)
        {
            return _ticketService.GetTicketsByClientIdSearch(client_id, searchTerm);
        }

        public void DeleteTicket(int ID)
        {
            _ticketService.DeleteTicket(ID);
        }
    }
}
