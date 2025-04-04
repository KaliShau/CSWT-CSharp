using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.form;
using CSWT.src.modules.SignIn;
using CSWT.src.modules.SignUp;
using CSWT.src.shared.utils;
using System.Windows.Forms;
using CSWT.src.modules.CreateTicket;
using CSWT.src.modules.MyTickets;

namespace CSWT.src.modules.Main
{
    public class MainController
    {
        FormManager _formManager;
        public MainController(FormManager formManager)
        {
            _formManager = formManager;
        }

        public void DrugForm(Panel panel, Form form)
        {
            AddDragControl.EnableDrag(panel, form);
        }

        public void OpenCreateTicker(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<CreateTicketForm>(childrenPanel);
        }
        public void OpenMyTickets(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<MyTicketsForm>(childrenPanel);
        }

    }
}
