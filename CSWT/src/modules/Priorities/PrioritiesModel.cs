using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.priority;
using CSWT.src.shared.services.status;

namespace CSWT.src.modules.Priorities
{
    public class PrioritiesModel
    {
        PriorityService _priorityService;
        public PrioritiesModel(PriorityService priorityService)
        {
            _priorityService = priorityService;
        }

        public PriorityDTO[] GetPriorities()
        {
            return _priorityService.GetPriorities();
        }

        public void CreatePriority(string priority_name, string description)
        {
            _priorityService.CreatePriority(priority_name, description);
        }

        public void DeletePriority(int ID)
        {
            _priorityService.DeleteStatus(ID);
        }
    }
}
