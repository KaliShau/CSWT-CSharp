using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.priority;

namespace CSWT.src.modules.CreateTicket
{
    public class CreateTicketModel
    {
        PriorityService _priorityService;
        public CreateTicketModel(PriorityService priorityService)
        {
            _priorityService = priorityService;
        }

        public PriorityDTO[] GetPriorities()
        {
            return _priorityService.GetPriorities();
        }

        public PriorityDTO GetPriority(int ID)
        {
            return _priorityService.GetPriorityByID(ID);
        }
    }
}
