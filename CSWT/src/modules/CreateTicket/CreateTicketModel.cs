using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.priority;
using CSWT.src.shared.services.status;
using CSWT.src.shared.services.ticket;

namespace CSWT.src.modules.CreateTicket
{
    public class CreateTicketModel
    {
        PriorityService _priorityService;
        StatusService _statusService;
        TicketService _ticketService;
        public CreateTicketModel(PriorityService priorityService, StatusService statusService, TicketService ticketService)
        {
            _priorityService = priorityService;
            _statusService = statusService;
            _ticketService = ticketService;
        }

        public PriorityDTO[] GetPriorities()
        {
            return _priorityService.GetPriorities();
        }

        public PriorityDTO GetPriorityByID(int ID)
        {
            return _priorityService.GetPriorityByID(ID);
        }

        public StatusDTO GetStatusByStatusName(string statusName)
        {
            return _statusService.GetStatusByStatusName(statusName);
        }

        public void CreateTicket(string title, string description, int client_id, int priority_id, int status_id)
        {
            _ticketService.CreateTicket(title, description, client_id, priority_id, status_id);
        }
    }
}
