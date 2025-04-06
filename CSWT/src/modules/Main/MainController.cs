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
using CSWT.src.modules.AllTickets;

namespace CSWT.src.modules.Main
{
    public class MainController
    {
        FormManager _formManager;
        FormContext _formContext;
        public MainController(FormManager formManager, FormContext formContext)
        {
            _formManager = formManager;
            _formContext = formContext;
        }
        public void InitChildrenPanel(Panel childrenPanel)
        {
            _formContext.childrenPanel = childrenPanel;
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

        public void OpenAllTickets(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<AllTicketsForm>(childrenPanel);
        }

    }
}
