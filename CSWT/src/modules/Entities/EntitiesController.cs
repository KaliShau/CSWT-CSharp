using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.form;
using CSWT.src.modules.CreateTicket;
using System.Windows.Forms;
using CSWT.src.modules.Roles;
using CSWT.src.modules.Statuses;
using CSWT.src.modules.Priorities;
using CSWT.src.modules.Departments;
using CSWT.src.modules.Users;
using CSWT.src.modules.Ticket;
using CSWT.src.modules.Tickets;

namespace CSWT.src.modules.Entities
{
    public class EntitiesController
    {
        FormManager _formManager;

        public EntitiesController(FormManager formManager)
        {
            _formManager = formManager;
        }

        public void OpenRoles(Panel childrenPanel)
        {
            _formManager.OpenEntitiesForm<RolesForm>(childrenPanel);
        }
        public void OpenStatuses(Panel childrenPanel)
        {
            _formManager.OpenEntitiesForm<StatusesForm>(childrenPanel);
        }

        public void OpenPriorities(Panel childrenPanel)
        {
            _formManager.OpenEntitiesForm<PrioritiesForm>(childrenPanel);
        }

        public void OpenDepartments(Panel childrenPanel)
        {
            _formManager.OpenEntitiesForm<DepartmentsForm>(childrenPanel);
        }

        public void OpenUsers(Panel childrenPanel)
        {
            _formManager.OpenEntitiesForm<UsersForm>(childrenPanel);
        }

        public void OpenTickets(Panel childrenPanel)
        {
            _formManager.OpenEntitiesForm<TicketsForm>(childrenPanel);
        }
    }
}
