using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.status;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.AllTickets
{
    public class AllTicketsModel
    {
        TicketService _ticketService;
        StatusService _statusService;
        public AllTicketsModel(TicketService ticketService, StatusService statusService)
        {
            _ticketService = ticketService;
            _statusService = statusService;
        }

        public TicketWithJoinDTO[] GetNewTickets()
        {
            var status = _statusService.GetStatusByStatusName("Новая");
            return _ticketService.GetNewTickets(status.ID);
        }

        public TicketWithJoinDTO[] GetNewTicketsSearch(string searchTerm)
        {
            var status = _statusService.GetStatusByStatusName("Новая");
            return _ticketService.GetNewTicketsSearch(status.ID, searchTerm);
        }

        public void AssignedTickets(int ticket_id, int assigned_id)
        {
            var status = _statusService.GetStatusByStatusName("В работе");
            _ticketService.AssignedTicket(assigned_id, status.ID, ticket_id);
        }
    }
}
