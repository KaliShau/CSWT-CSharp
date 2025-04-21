using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.form;
using CSWT.src.modules.CreateTicket;
using System.Windows.Forms;
using CSWT.src.modules.Roles;

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
    }
}
