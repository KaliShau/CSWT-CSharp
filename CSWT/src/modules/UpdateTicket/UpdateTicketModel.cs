using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.priority;
using CSWT.src.shared.services.status;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.UpdateTicket
{
    public class UpdateTicketModel
    {
        TicketService _ticketService;
        StatusService _statusService;
        PriorityService _priorityService;
        public UpdateTicketModel(TicketService ticketService, StatusService statusService, PriorityService priorityService)
        {
            _ticketService = ticketService;
            _statusService = statusService;
            _priorityService = priorityService;
        }

        public TicketWithJoinDTO GetTicketByID(int ID)
        {
            return _ticketService.GetTicketByID(ID);
        }

        public PriorityDTO[] GetPriotities()
        {
            return _priorityService.GetPriorities();
        }

        public StatusDTO[] GetStatuses()
        {
            return _statusService.GetStatuses();
        }
    }
}
