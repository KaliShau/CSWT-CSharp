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

        public PriorityDTO GetPriotitiesByID(int ID)
        {
            return _priorityService.GetPriorityByID(ID);
        }

        public StatusDTO GetStatusByID(int ID)
        {
            return _statusService.GetStatusByID(ID);
        }

        public StatusDTO GetClosedStatus(string name)
        {
            return _statusService.GetStatusByStatusName(name);
        }

        public void UpdateClosedAt(int ID)
        {
            _ticketService.UpdateClosedAt(ID);
        }

        public void UpdateTicket(string title, string description, string solution, int priority_id, int status_id, int ID)
        {
            _ticketService.UpdateTicket(title, description, solution, priority_id, status_id, ID);
        }
    }
}
