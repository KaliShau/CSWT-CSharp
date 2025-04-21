using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.services.status;

namespace CSWT.src.modules.Statuses
{
    public class StatusesModel
    {
        StatusService _statusService;
        public StatusesModel(StatusService statusService)
        {
            _statusService = statusService;
        }

        public StatusDTO[] GetStatuses()
        {
            return _statusService.GetStatuses();
        }

        public void CreateStatus(string status_name, string description)
        {
            _statusService.CreateStatus(status_name, description);
        }

        public void DeleteStatus(int ID)
        {
            _statusService.DeleteStatus(ID);
        }
    }
}
